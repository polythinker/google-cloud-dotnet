﻿// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Cloud.Spanner.Data.CommonTesting;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [PerformanceLog]
    [Collection(nameof(TransactionTableFixture))]
    [CommonTestDiagnostics]
    public class TransactionTests : TransactionTestBase
    {
        public TransactionTests(TransactionTableFixture fixture)
            : base(fixture)
        {
        }

        private async Task IncrementByOneAsync(SpannerConnection connection, bool orphanTransaction = false)
        {
            var retrySettings = RetrySettings.FromExponentialBackoff(
                maxAttempts: int.MaxValue,
                initialBackoff: TimeSpan.FromMilliseconds(250),
                maxBackoff: TimeSpan.FromSeconds(5),
                backoffMultiplier: 1.5,
                retryFilter: ignored => false,
                RetrySettings.RandomJitter);
            TimeSpan nextDelay = TimeSpan.Zero;
            SpannerException spannerException;
            DateTime deadline = DateTime.UtcNow.AddSeconds(30);

            while (true)
            {
                spannerException = null;
                try
                {
                    // We use manually created transactions here so the tests run on .NET Core.
                    using (var transaction = await connection.BeginTransactionAsync())
                    {
                        long current;
                        using (var cmd = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
                        {
                            cmd.Parameters.Add("k", SpannerDbType.String, _key);
                            cmd.Transaction = transaction;
                            var fetched = await cmd.ExecuteScalarAsync().ConfigureAwait(false);
                            current = fetched is DBNull ? 0L : (long)fetched;
                        }
                        using (var cmd = connection.CreateUpdateCommand(_fixture.TableName))
                        {
                            cmd.Parameters.Add("k", SpannerDbType.String, _key);
                            cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, current + 1);
                            cmd.Transaction = transaction;
                            await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                            if (!orphanTransaction)
                            {
                                await transaction.CommitAsync().ConfigureAwait(false);
                            }
                        }
                    }
                    return;
                }
                // Keep trying for up to 30 seconds
                catch (SpannerException ex) when (ex.IsRetryable && DateTime.UtcNow < deadline)
                {
                    nextDelay = retrySettings.NextBackoff(nextDelay);
                    await Task.Delay(retrySettings.BackoffJitter.GetDelay(nextDelay));
                    spannerException = ex;
                }
            }
        }

        [Fact]
        public async Task DisposedTransactionDoesntLeak()
        {
            // This test ensures that a transaction that had neither commit nor rollback called does
            // not leak its transaction state to a subsequent transaction.
            // The way this works currently is that every session added to the pool gets its state cleared.
            // The reserved session in SpannerConnection can only be used for readonly transactions and is
            // therefore immune to this bug.  However if that every changes, this test will catch it.
            using (var connection = _fixture.GetConnection())
            {
                connection.Open();
                // The following line increments by one, but never commits the transaction, allowing it
                // to get disposed (which releases the session).
                await IncrementByOneAsync(connection, true);

                await RetryHelpers.ExecuteWithRetryAsync(async () =>
                {
                    using (var tx = await connection.BeginTransactionAsync())
                    {
                        // Because Cloud Spanner does not have "read your writes"
                        // to test any leaks, we must commit the transaction and then read it.
                        await tx.CommitAsync();
                    }
                });

                // The value should not be present in the table.
                using (var cmd = connection.CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
                {
                    cmd.Parameters.Add("k", SpannerDbType.String, _key);
                    Assert.Equal(DBNull.Value, await cmd.ExecuteScalarAsync().ConfigureAwait(false));
                }
            }
        }

        // [START spanner_test_transaction_retry_on_aborted]
        [Fact]
        public async Task AbortedThrownCorrectly()
        {
            // connection 1 starts a transaction and reads
            // connection 2 starts a transaction and reads the same row
            // connection 1 writes and commits
            // connection 2 reads again -- abort should be thrown.

            // Note: deeply nested using statements to ensure that we dispose of everything even in the case of failure,
            // but we manually dispose of both tx1 and connection1. 
            using (var connection1 = new SpannerConnection(_fixture.ConnectionString))
            {
                using (var connection2 = new SpannerConnection(_fixture.ConnectionString))
                {

                    await Task.WhenAll(connection1.OpenAsync(), connection2.OpenAsync());
                    using (var tx1 = await connection1.BeginTransactionAsync())
                    {

                        // TX1 READ
                        using (var cmd = CreateSelectAllCommandForKey(connection1))
                        {
                            cmd.Transaction = tx1;
                            using (var reader = await cmd.ExecuteReaderAsync())
                            {
                                Assert.True(await reader.ReadAsync());
                            }
                        }

                        // TX2 START
                        using (var tx2 = await connection2.BeginTransactionAsync())
                        {

                            // TX2 READ
                            using (var cmd = CreateSelectAllCommandForKey(connection2))
                            {
                                cmd.Transaction = tx2;
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    Assert.True(await reader.ReadAsync());
                                }
                            }

                            // TX1 WRITE/COMMIT
                            using (var cmd = connection1.CreateUpdateCommand(_fixture.TableName))
                            {
                                cmd.Parameters.Add("k", SpannerDbType.String, _key);
                                cmd.Parameters.Add("Int64Value", SpannerDbType.Int64, 0);
                                cmd.Transaction = tx1;
                                await cmd.ExecuteNonQueryAsync().ConfigureAwait(false);
                                await tx1.CommitAsync().ConfigureAwait(false);
                                tx1.Dispose();
                            }
                            connection1.Dispose();

                            // TX2 READ AGAIN/THROWS            
                            using (var cmd = CreateSelectAllCommandForKey(connection2))
                            {
                                cmd.Transaction = tx2;
                                using (var reader = await cmd.ExecuteReaderAsync())
                                {
                                    var thrownException = await Assert.ThrowsAsync<SpannerException>(() => reader.ReadAsync());
                                    Assert.True(thrownException.IsRetryable);
                                }
                            }
                        }
                    }
                }
            }
        }
        // [END spanner_test_transaction_retry_on_aborted]

        // [START spanner_test_transaction_query_increment]
        [Fact]
        public async Task MultiWrite()
        {
            // To ensure good concurrency (ie that the transactions are not serial)
            // we'll preopen 5 transactions to ensure they have sessions and then start the increment
            // process
            const int concurrentThreads = 5;
            var connections = new SpannerConnection[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i] = _fixture.GetConnection();
                connections[i].Open();
            }

            var tasks = new Task[concurrentThreads];
            for (var i = 0; i < concurrentThreads; i++)
            {
                tasks[i] = IncrementByOneAsync(connections[i]);
            }
            await Task.WhenAll(tasks).ConfigureAwait(false);

            // Now ensure we have the correct value
            using (var cmd = connections[0].CreateSelectCommand($"SELECT Int64Value FROM {_fixture.TableName} WHERE K=@k"))
            {
                cmd.Parameters.Add("k", SpannerDbType.String, _key);
                Assert.Equal(5, await cmd.ExecuteScalarAsync<long>().ConfigureAwait(false));
            }

            for (var i = 0; i < concurrentThreads; i++)
            {
                connections[i].Dispose();
            }
        }
        // [END spanner_test_transaction_query_increment]

        [Fact]
        public void MultiTableWrite()
        {
            // For simplicity, use a new key so that this test is entirely self-contained.
            string key = IdGenerator.FromGuid();
            RetryHelpers.ExecuteWithRetry(() =>
            {
                using (var connection = _fixture.GetConnection())
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var cmd1 = connection.CreateInsertCommand(_fixture.TableName))
                        {
                            cmd1.Transaction = transaction;
                            cmd1.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd1.Parameters.Add("StringValue", SpannerDbType.String).Value = "text";
                            cmd1.ExecuteNonQuery();
                        }

                        using (var cmd2 = connection.CreateInsertCommand(_fixture.TableName2))
                        {
                            cmd2.Transaction = transaction;
                            cmd2.Parameters.Add("K", SpannerDbType.String).Value = key;
                            cmd2.Parameters.Add("Int64Value", SpannerDbType.Int64).Value = 50;
                            cmd2.ExecuteNonQuery();
                        }
                        
                        // Commit mutations from both commands, atomically.
                        transaction.Commit();
                    }
                }
            });

            // Read the values from both tables
            using (var connection = _fixture.GetConnection())
            {
                using (var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName} WHERE K=@Key"))
                {
                    command.Parameters.Add("Key", SpannerDbType.String).Value = key;
                    using (var reader = command.ExecuteReader())
                    {
                        Assert.True(reader.Read());
                        Assert.Equal("text", reader["StringValue"]);
                        Assert.False(reader.Read());
                    }
                }

                using (var command = connection.CreateSelectCommand($"SELECT * FROM {_fixture.TableName2} WHERE K=@Key"))
                {
                    command.Parameters.Add("Key", SpannerDbType.String).Value = key;
                    using (var reader = command.ExecuteReader())
                    {
                        Assert.True(reader.Read());
                        Assert.Equal(50L, reader["Int64Value"]);
                        Assert.False(reader.Read());
                    }
                }
            }
        }

        // [START spanner_test_read_exact]
        [Fact]
        public async Task ReadExact()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var targetReadTimestamp = _fixture.TimestampBeforeEntries;
                using (var tx =
                    await connection.BeginReadOnlyTransactionAsync(
                        TimestampBound.OfReadTimestamp(targetReadTimestamp)))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(targetReadTimestamp, tx.TimestampBound.Timestamp);

                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.False(
                            await reader.ReadAsync(),
                            "no data should be here from yesterday!");
                    }
                }
            }
        }
        // [END spanner_test_read_exact]

        // [START spanner_test_exact_read_concurrent_updates]
        [Fact]
        public async Task ReadExactSingle()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.OfReadTimestamp(_oldestEntry.Timestamp)))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_oldestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }
        // [END spanner_test_exact_read_concurrent_updates]

        // [START spanner_test_read_min_single_use]
        // [END spanner_test_read_min_single_use]
        // [START spanner_test_read_min]
        [Fact]
        public async Task ReadMin()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();

                // Can't use MinReadTimestamp to create a transaction
                var bound = TimestampBound.OfMinReadTimestamp(_newestEntry.Timestamp);
                await Assert.ThrowsAsync<ArgumentException>(() => connection.BeginReadOnlyTransactionAsync(bound));

                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader = await cmd.ExecuteReaderAsync(bound))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }
        // [END spanner_test_read_min]

        // [START spanner_test_read_exact_staleness]
        [Fact]
        public async Task ReadStaleExact()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var bound = TimestampBound.OfExactStaleness(_fixture.Staleness);
                using (var tx = await connection.BeginReadOnlyTransactionAsync(bound))
                {
                    Assert.Equal(TransactionMode.ReadOnly, tx.Mode);
                    Assert.Equal(_fixture.Staleness, tx.TimestampBound.Staleness);

                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        Assert.False(await reader.ReadAsync(), "We should have read no rows at this time!");
                    }
                }
            }
        }
        // [END spanner_test_read_exact_staleness]

        // [START spanner_test_read_exact_staleness_concurrent_updates]
        [Fact]
        public async Task ReadStaleExactSingle()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                var bound = TimestampBound.OfExactStaleness(_fixture.Staleness);
                using (var reader = await cmd.ExecuteReaderAsync(bound))
                {
                    Assert.False(await reader.ReadAsync(), "We should have read no rows at this time!");
                }
            }
        }
        // [END spanner_test_read_exact_staleness_concurrent_updates]

        // [START spanner_test_read_max_staleness_single_use]
        // [END spanner_test_read_max_staleness_single_use]
        // [START spanner_test_read_max_staleness]
        [Fact]
        public async Task ReadStaleMax()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();

                // Can't use MaxStaleness to create a transaction
                var staleBound = TimestampBound.OfMaxStaleness(_fixture.Staleness);
                await Assert.ThrowsAsync<ArgumentException>(() => connection.BeginReadOnlyTransactionAsync(staleBound));

                var cmd = CreateSelectAllCommandForKey(connection);
                var recentBound = TimestampBound.OfMaxStaleness(TimeSpan.FromMilliseconds(5));
                using (var reader = await cmd.ExecuteReaderAsync(recentBound))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }
        // [END spanner_test_read_max_staleness]

        // [START spanner_test_strong_read]
        [Fact]
        public async Task ReadStrong()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                using (var tx = await connection.BeginReadOnlyTransactionAsync(TimestampBound.Strong))
                {
                    var cmd = CreateSelectAllCommandForKey(connection);
                    cmd.Transaction = tx;
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Assert.Equal(
                                _newestEntry.Value,
                                reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                        }
                    }
                }
            }
        }
        // [END spanner_test_strong_read]

        // [START spanner_test_strong_read_concurrent_updates]
        [Fact]
        public async Task ReadStrongSingle()
        {
            using (var connection = _fixture.GetConnection())
            {
                await connection.OpenAsync();
                var cmd = CreateSelectAllCommandForKey(connection);
                using (var reader = await cmd.ExecuteReaderAsync(TimestampBound.Strong))
                {
                    if (await reader.ReadAsync())
                    {
                        Assert.Equal(_newestEntry.Value, reader.GetFieldValue<string>(reader.GetOrdinal("StringValue")));
                    }
                }
            }
        }
        // [END spanner_test_strong_read_concurrent_updates]
    }
}
