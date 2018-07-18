// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using iam = Google.Cloud.Iam.V1;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Kms.V1
{
    /// <summary>
    /// Settings for a <see cref="KeyManagementServiceClient"/>.
    /// </summary>
    public sealed partial class KeyManagementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="KeyManagementServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="KeyManagementServiceSettings"/>.
        /// </returns>
        public static KeyManagementServiceSettings GetDefault() => new KeyManagementServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeyManagementServiceSettings"/> object with default settings.
        /// </summary>
        public KeyManagementServiceSettings() { }

        private KeyManagementServiceSettings(KeyManagementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListKeyRingsSettings = existing.ListKeyRingsSettings;
            ListCryptoKeysSettings = existing.ListCryptoKeysSettings;
            ListCryptoKeyVersionsSettings = existing.ListCryptoKeyVersionsSettings;
            GetKeyRingSettings = existing.GetKeyRingSettings;
            GetCryptoKeySettings = existing.GetCryptoKeySettings;
            GetCryptoKeyVersionSettings = existing.GetCryptoKeyVersionSettings;
            CreateKeyRingSettings = existing.CreateKeyRingSettings;
            CreateCryptoKeySettings = existing.CreateCryptoKeySettings;
            CreateCryptoKeyVersionSettings = existing.CreateCryptoKeyVersionSettings;
            UpdateCryptoKeySettings = existing.UpdateCryptoKeySettings;
            UpdateCryptoKeyVersionSettings = existing.UpdateCryptoKeyVersionSettings;
            EncryptSettings = existing.EncryptSettings;
            DecryptSettings = existing.DecryptSettings;
            UpdateCryptoKeyPrimaryVersionSettings = existing.UpdateCryptoKeyPrimaryVersionSettings;
            DestroyCryptoKeyVersionSettings = existing.DestroyCryptoKeyVersionSettings;
            RestoreCryptoKeyVersionSettings = existing.RestoreCryptoKeyVersionSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeyManagementServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="KeyManagementServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="KeyManagementServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="KeyManagementServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.ListKeyRings</c> and <c>KeyManagementServiceClient.ListKeyRingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.ListKeyRings</c> and
        /// <c>KeyManagementServiceClient.ListKeyRingsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListKeyRingsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.ListCryptoKeys</c> and <c>KeyManagementServiceClient.ListCryptoKeysAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.ListCryptoKeys</c> and
        /// <c>KeyManagementServiceClient.ListCryptoKeysAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListCryptoKeysSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.ListCryptoKeyVersions</c> and <c>KeyManagementServiceClient.ListCryptoKeyVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.ListCryptoKeyVersions</c> and
        /// <c>KeyManagementServiceClient.ListCryptoKeyVersionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListCryptoKeyVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.GetKeyRing</c> and <c>KeyManagementServiceClient.GetKeyRingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.GetKeyRing</c> and
        /// <c>KeyManagementServiceClient.GetKeyRingAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetKeyRingSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.GetCryptoKey</c> and <c>KeyManagementServiceClient.GetCryptoKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.GetCryptoKey</c> and
        /// <c>KeyManagementServiceClient.GetCryptoKeyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCryptoKeySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.GetCryptoKeyVersion</c> and <c>KeyManagementServiceClient.GetCryptoKeyVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.GetCryptoKeyVersion</c> and
        /// <c>KeyManagementServiceClient.GetCryptoKeyVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCryptoKeyVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.CreateKeyRing</c> and <c>KeyManagementServiceClient.CreateKeyRingAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.CreateKeyRing</c> and
        /// <c>KeyManagementServiceClient.CreateKeyRingAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateKeyRingSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.CreateCryptoKey</c> and <c>KeyManagementServiceClient.CreateCryptoKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.CreateCryptoKey</c> and
        /// <c>KeyManagementServiceClient.CreateCryptoKeyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateCryptoKeySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.CreateCryptoKeyVersion</c> and <c>KeyManagementServiceClient.CreateCryptoKeyVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.CreateCryptoKeyVersion</c> and
        /// <c>KeyManagementServiceClient.CreateCryptoKeyVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateCryptoKeyVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.UpdateCryptoKey</c> and <c>KeyManagementServiceClient.UpdateCryptoKeyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.UpdateCryptoKey</c> and
        /// <c>KeyManagementServiceClient.UpdateCryptoKeyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCryptoKeySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.UpdateCryptoKeyVersion</c> and <c>KeyManagementServiceClient.UpdateCryptoKeyVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.UpdateCryptoKeyVersion</c> and
        /// <c>KeyManagementServiceClient.UpdateCryptoKeyVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCryptoKeyVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.Encrypt</c> and <c>KeyManagementServiceClient.EncryptAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.Encrypt</c> and
        /// <c>KeyManagementServiceClient.EncryptAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings EncryptSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.Decrypt</c> and <c>KeyManagementServiceClient.DecryptAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.Decrypt</c> and
        /// <c>KeyManagementServiceClient.DecryptAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DecryptSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.UpdateCryptoKeyPrimaryVersion</c> and <c>KeyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.UpdateCryptoKeyPrimaryVersion</c> and
        /// <c>KeyManagementServiceClient.UpdateCryptoKeyPrimaryVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCryptoKeyPrimaryVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.DestroyCryptoKeyVersion</c> and <c>KeyManagementServiceClient.DestroyCryptoKeyVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.DestroyCryptoKeyVersion</c> and
        /// <c>KeyManagementServiceClient.DestroyCryptoKeyVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DestroyCryptoKeyVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.RestoreCryptoKeyVersion</c> and <c>KeyManagementServiceClient.RestoreCryptoKeyVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.RestoreCryptoKeyVersion</c> and
        /// <c>KeyManagementServiceClient.RestoreCryptoKeyVersionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings RestoreCryptoKeyVersionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.SetIamPolicy</c> and <c>KeyManagementServiceClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.SetIamPolicy</c> and
        /// <c>KeyManagementServiceClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.GetIamPolicy</c> and <c>KeyManagementServiceClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.GetIamPolicy</c> and
        /// <c>KeyManagementServiceClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeyManagementServiceClient.TestIamPermissions</c> and <c>KeyManagementServiceClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>KeyManagementServiceClient.TestIamPermissions</c> and
        /// <c>KeyManagementServiceClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="KeyManagementServiceSettings"/> object.</returns>
        public KeyManagementServiceSettings Clone() => new KeyManagementServiceSettings(this);
    }

    /// <summary>
    /// KeyManagementService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class KeyManagementServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeyManagementService service, which is a host of "cloudkms.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("cloudkms.googleapis.com", 443);

        /// <summary>
        /// The default KeyManagementService scopes.
        /// </summary>
        /// <remarks>
        /// The default KeyManagementService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeyManagementServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Kms.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// KeyManagementServiceClient client = await KeyManagementServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Kms.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     KeyManagementServiceClient.DefaultEndpoint.Host, KeyManagementServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeyManagementServiceClient client = KeyManagementServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeyManagementServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="KeyManagementServiceClient"/>.</returns>
        public static async stt::Task<KeyManagementServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, KeyManagementServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="KeyManagementServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Kms.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// KeyManagementServiceClient client = KeyManagementServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Kms.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     KeyManagementServiceClient.DefaultEndpoint.Host, KeyManagementServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// KeyManagementServiceClient client = KeyManagementServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="KeyManagementServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeyManagementServiceClient"/>.</returns>
        public static KeyManagementServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, KeyManagementServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="KeyManagementServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="KeyManagementServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeyManagementServiceClient"/>.</returns>
        public static KeyManagementServiceClient Create(grpccore::Channel channel, KeyManagementServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            KeyManagementService.KeyManagementServiceClient grpcClient = new KeyManagementService.KeyManagementServiceClient(channel);
            return new KeyManagementServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, KeyManagementServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeyManagementServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, KeyManagementServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, KeyManagementServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC KeyManagementService client.
        /// </summary>
        public virtual KeyManagementService.KeyManagementServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [KeyRings][google.cloud.kms.v1.KeyRing], in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRingsAsync(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListKeyRingsAsync(
                new ListKeyRingsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [KeyRings][google.cloud.kms.v1.KeyRing], in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRings(
            LocationName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListKeyRings(
                new ListKeyRingsRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRingsAsync(
            ListKeyRingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRings(
            ListKeyRingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
        /// `projects/*/locations/*/keyRings/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeysAsync(
            KeyRingName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCryptoKeysAsync(
                new ListCryptoKeysRequest
                {
                    ParentAsKeyRingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the [KeyRing][google.cloud.kms.v1.KeyRing] to list, in the format
        /// `projects/*/locations/*/keyRings/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeys(
            KeyRingName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCryptoKeys(
                new ListCryptoKeysRequest
                {
                    ParentAsKeyRingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeysAsync(
            ListCryptoKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeys(
            ListCryptoKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to list, in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersionsAsync(
            CryptoKeyName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCryptoKeyVersionsAsync(
                new ListCryptoKeyVersionsRequest
                {
                    ParentAsCryptoKeyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to list, in the format
        /// `projects/*/locations/*/keyRings/*/cryptoKeys/*`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersions(
            CryptoKeyName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListCryptoKeyVersions(
                new ListCryptoKeyVersionsRequest
                {
                    ParentAsCryptoKeyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersionsAsync(
            ListCryptoKeyVersionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersions(
            ListCryptoKeyVersionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.KeyRing.name] of the [KeyRing][google.cloud.kms.v1.KeyRing] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> GetKeyRingAsync(
            KeyRingName name,
            gaxgrpc::CallSettings callSettings = null) => GetKeyRingAsync(
                new GetKeyRingRequest
                {
                    KeyRingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.KeyRing.name] of the [KeyRing][google.cloud.kms.v1.KeyRing] to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> GetKeyRingAsync(
            KeyRingName name,
            st::CancellationToken cancellationToken) => GetKeyRingAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.KeyRing.name] of the [KeyRing][google.cloud.kms.v1.KeyRing] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual KeyRing GetKeyRing(
            KeyRingName name,
            gaxgrpc::CallSettings callSettings = null) => GetKeyRing(
                new GetKeyRingRequest
                {
                    KeyRingName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> GetKeyRingAsync(
            GetKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> GetKeyRingAsync(
            GetKeyRingRequest request,
            st::CancellationToken cancellationToken) => GetKeyRingAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual KeyRing GetKeyRing(
            GetKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> GetCryptoKeyAsync(
            CryptoKeyName name,
            gaxgrpc::CallSettings callSettings = null) => GetCryptoKeyAsync(
                new GetCryptoKeyRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> GetCryptoKeyAsync(
            CryptoKeyName name,
            st::CancellationToken cancellationToken) => GetCryptoKeyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey GetCryptoKey(
            CryptoKeyName name,
            gaxgrpc::CallSettings callSettings = null) => GetCryptoKey(
                new GetCryptoKeyRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> GetCryptoKeyAsync(
            GetCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> GetCryptoKeyAsync(
            GetCryptoKeyRequest request,
            st::CancellationToken cancellationToken) => GetCryptoKeyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey GetCryptoKey(
            GetCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKeyVersion.name] of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> GetCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => GetCryptoKeyVersionAsync(
                new GetCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKeyVersion.name] of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> GetCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            st::CancellationToken cancellationToken) => GetCryptoKeyVersionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="name">
        /// The [name][google.cloud.kms.v1.CryptoKeyVersion.name] of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion GetCryptoKeyVersion(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => GetCryptoKeyVersion(
                new GetCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> GetCryptoKeyVersionAsync(
            GetCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> GetCryptoKeyVersionAsync(
            GetCryptoKeyVersionRequest request,
            st::CancellationToken cancellationToken) => GetCryptoKeyVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion GetCryptoKeyVersion(
            GetCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [KeyRings][google.cloud.kms.v1.KeyRing], in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="keyRingId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="keyRing">
        /// A [KeyRing][google.cloud.kms.v1.KeyRing] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> CreateKeyRingAsync(
            LocationName parent,
            string keyRingId,
            KeyRing keyRing,
            gaxgrpc::CallSettings callSettings = null) => CreateKeyRingAsync(
                new CreateKeyRingRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    KeyRingId = gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)),
                    KeyRing = gax::GaxPreconditions.CheckNotNull(keyRing, nameof(keyRing)),
                },
                callSettings);

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [KeyRings][google.cloud.kms.v1.KeyRing], in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="keyRingId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="keyRing">
        /// A [KeyRing][google.cloud.kms.v1.KeyRing] with initial field values.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> CreateKeyRingAsync(
            LocationName parent,
            string keyRingId,
            KeyRing keyRing,
            st::CancellationToken cancellationToken) => CreateKeyRingAsync(
                parent,
                keyRingId,
                keyRing,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [KeyRings][google.cloud.kms.v1.KeyRing], in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="keyRingId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="keyRing">
        /// A [KeyRing][google.cloud.kms.v1.KeyRing] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual KeyRing CreateKeyRing(
            LocationName parent,
            string keyRingId,
            KeyRing keyRing,
            gaxgrpc::CallSettings callSettings = null) => CreateKeyRing(
                new CreateKeyRingRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    KeyRingId = gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)),
                    KeyRing = gax::GaxPreconditions.CheckNotNull(keyRing, nameof(keyRing)),
                },
                callSettings);

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> CreateKeyRingAsync(
            CreateKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<KeyRing> CreateKeyRingAsync(
            CreateKeyRingRequest request,
            st::CancellationToken cancellationToken) => CreateKeyRingAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual KeyRing CreateKeyRing(
            CreateKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.KeyRing.name] of the KeyRing associated with the
        /// [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="cryptoKeyId">
        /// Required. It must be unique within a KeyRing and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cryptoKey">
        /// A [CryptoKey][google.cloud.kms.v1.CryptoKey] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> CreateCryptoKeyAsync(
            KeyRingName parent,
            string cryptoKeyId,
            CryptoKey cryptoKey,
            gaxgrpc::CallSettings callSettings = null) => CreateCryptoKeyAsync(
                new CreateCryptoKeyRequest
                {
                    ParentAsKeyRingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CryptoKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)),
                    CryptoKey = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
                },
                callSettings);

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.KeyRing.name] of the KeyRing associated with the
        /// [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="cryptoKeyId">
        /// Required. It must be unique within a KeyRing and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cryptoKey">
        /// A [CryptoKey][google.cloud.kms.v1.CryptoKey] with initial field values.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> CreateCryptoKeyAsync(
            KeyRingName parent,
            string cryptoKeyId,
            CryptoKey cryptoKey,
            st::CancellationToken cancellationToken) => CreateCryptoKeyAsync(
                parent,
                cryptoKeyId,
                cryptoKey,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.KeyRing.name] of the KeyRing associated with the
        /// [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </param>
        /// <param name="cryptoKeyId">
        /// Required. It must be unique within a KeyRing and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cryptoKey">
        /// A [CryptoKey][google.cloud.kms.v1.CryptoKey] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey CreateCryptoKey(
            KeyRingName parent,
            string cryptoKeyId,
            CryptoKey cryptoKey,
            gaxgrpc::CallSettings callSettings = null) => CreateCryptoKey(
                new CreateCryptoKeyRequest
                {
                    ParentAsKeyRingName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CryptoKeyId = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)),
                    CryptoKey = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
                },
                callSettings);

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> CreateCryptoKeyAsync(
            CreateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> CreateCryptoKeyAsync(
            CreateCryptoKeyRequest request,
            st::CancellationToken cancellationToken) => CreateCryptoKeyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey CreateCryptoKey(
            CreateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] associated with
        /// the [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </param>
        /// <param name="cryptoKeyVersion">
        /// A [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> CreateCryptoKeyVersionAsync(
            CryptoKeyName parent,
            CryptoKeyVersion cryptoKeyVersion,
            gaxgrpc::CallSettings callSettings = null) => CreateCryptoKeyVersionAsync(
                new CreateCryptoKeyVersionRequest
                {
                    ParentAsCryptoKeyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CryptoKeyVersion = gax::GaxPreconditions.CheckNotNull(cryptoKeyVersion, nameof(cryptoKeyVersion)),
                },
                callSettings);

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] associated with
        /// the [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </param>
        /// <param name="cryptoKeyVersion">
        /// A [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with initial field values.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> CreateCryptoKeyVersionAsync(
            CryptoKeyName parent,
            CryptoKeyVersion cryptoKeyVersion,
            st::CancellationToken cancellationToken) => CreateCryptoKeyVersionAsync(
                parent,
                cryptoKeyVersion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="parent">
        /// Required. The [name][google.cloud.kms.v1.CryptoKey.name] of the [CryptoKey][google.cloud.kms.v1.CryptoKey] associated with
        /// the [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </param>
        /// <param name="cryptoKeyVersion">
        /// A [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with initial field values.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion CreateCryptoKeyVersion(
            CryptoKeyName parent,
            CryptoKeyVersion cryptoKeyVersion,
            gaxgrpc::CallSettings callSettings = null) => CreateCryptoKeyVersion(
                new CreateCryptoKeyVersionRequest
                {
                    ParentAsCryptoKeyName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    CryptoKeyVersion = gax::GaxPreconditions.CheckNotNull(cryptoKeyVersion, nameof(cryptoKeyVersion)),
                },
                callSettings);

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> CreateCryptoKeyVersionAsync(
            CreateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> CreateCryptoKeyVersionAsync(
            CreateCryptoKeyVersionRequest request,
            st::CancellationToken cancellationToken) => CreateCryptoKeyVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion CreateCryptoKeyVersion(
            CreateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="cryptoKey">
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyAsync(
            CryptoKey cryptoKey,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKeyAsync(
                new UpdateCryptoKeyRequest
                {
                    CryptoKey = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="cryptoKey">
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyAsync(
            CryptoKey cryptoKey,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyAsync(
                cryptoKey,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="cryptoKey">
        /// [CryptoKey][google.cloud.kms.v1.CryptoKey] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey UpdateCryptoKey(
            CryptoKey cryptoKey,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKey(
                new UpdateCryptoKeyRequest
                {
                    CryptoKey = gax::GaxPreconditions.CheckNotNull(cryptoKey, nameof(cryptoKey)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyAsync(
            UpdateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyAsync(
            UpdateCryptoKeyRequest request,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey UpdateCryptoKey(
            UpdateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="cryptoKeyVersion">
        /// [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> UpdateCryptoKeyVersionAsync(
            CryptoKeyVersion cryptoKeyVersion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKeyVersionAsync(
                new UpdateCryptoKeyVersionRequest
                {
                    CryptoKeyVersion = gax::GaxPreconditions.CheckNotNull(cryptoKeyVersion, nameof(cryptoKeyVersion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="cryptoKeyVersion">
        /// [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> UpdateCryptoKeyVersionAsync(
            CryptoKeyVersion cryptoKeyVersion,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyVersionAsync(
                cryptoKeyVersion,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="cryptoKeyVersion">
        /// [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion UpdateCryptoKeyVersion(
            CryptoKeyVersion cryptoKeyVersion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKeyVersion(
                new UpdateCryptoKeyVersionRequest
                {
                    CryptoKeyVersion = gax::GaxPreconditions.CheckNotNull(cryptoKeyVersion, nameof(cryptoKeyVersion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> UpdateCryptoKeyVersionAsync(
            UpdateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> UpdateCryptoKeyVersionAsync(
            UpdateCryptoKeyVersionRequest request,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion UpdateCryptoKeyVersion(
            UpdateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] or [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]
        /// to use for encryption.
        ///
        /// If a [CryptoKey][google.cloud.kms.v1.CryptoKey] is specified, the server will use its
        /// [primary version][google.cloud.kms.v1.CryptoKey.primary].
        /// </param>
        /// <param name="plaintext">
        /// Required. The data to encrypt. Must be no larger than 64KiB.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EncryptResponse> EncryptAsync(
            CryptoKeyPathName name,
            pb::ByteString plaintext,
            gaxgrpc::CallSettings callSettings = null) => EncryptAsync(
                new EncryptRequest
                {
                    CryptoKeyPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Plaintext = gax::GaxPreconditions.CheckNotNull(plaintext, nameof(plaintext)),
                },
                callSettings);

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] or [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]
        /// to use for encryption.
        ///
        /// If a [CryptoKey][google.cloud.kms.v1.CryptoKey] is specified, the server will use its
        /// [primary version][google.cloud.kms.v1.CryptoKey.primary].
        /// </param>
        /// <param name="plaintext">
        /// Required. The data to encrypt. Must be no larger than 64KiB.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EncryptResponse> EncryptAsync(
            CryptoKeyPathName name,
            pb::ByteString plaintext,
            st::CancellationToken cancellationToken) => EncryptAsync(
                name,
                plaintext,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] or [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]
        /// to use for encryption.
        ///
        /// If a [CryptoKey][google.cloud.kms.v1.CryptoKey] is specified, the server will use its
        /// [primary version][google.cloud.kms.v1.CryptoKey.primary].
        /// </param>
        /// <param name="plaintext">
        /// Required. The data to encrypt. Must be no larger than 64KiB.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EncryptResponse Encrypt(
            CryptoKeyPathName name,
            pb::ByteString plaintext,
            gaxgrpc::CallSettings callSettings = null) => Encrypt(
                new EncryptRequest
                {
                    CryptoKeyPathName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Plaintext = gax::GaxPreconditions.CheckNotNull(plaintext, nameof(plaintext)),
                },
                callSettings);

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EncryptResponse> EncryptAsync(
            EncryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<EncryptResponse> EncryptAsync(
            EncryptRequest request,
            st::CancellationToken cancellationToken) => EncryptAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual EncryptResponse Encrypt(
            EncryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to use for decryption.
        /// The server will choose the appropriate version.
        /// </param>
        /// <param name="ciphertext">
        /// Required. The encrypted data originally returned in
        /// [EncryptResponse.ciphertext][google.cloud.kms.v1.EncryptResponse.ciphertext].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DecryptResponse> DecryptAsync(
            CryptoKeyName name,
            pb::ByteString ciphertext,
            gaxgrpc::CallSettings callSettings = null) => DecryptAsync(
                new DecryptRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Ciphertext = gax::GaxPreconditions.CheckNotNull(ciphertext, nameof(ciphertext)),
                },
                callSettings);

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to use for decryption.
        /// The server will choose the appropriate version.
        /// </param>
        /// <param name="ciphertext">
        /// Required. The encrypted data originally returned in
        /// [EncryptResponse.ciphertext][google.cloud.kms.v1.EncryptResponse.ciphertext].
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DecryptResponse> DecryptAsync(
            CryptoKeyName name,
            pb::ByteString ciphertext,
            st::CancellationToken cancellationToken) => DecryptAsync(
                name,
                ciphertext,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to use for decryption.
        /// The server will choose the appropriate version.
        /// </param>
        /// <param name="ciphertext">
        /// Required. The encrypted data originally returned in
        /// [EncryptResponse.ciphertext][google.cloud.kms.v1.EncryptResponse.ciphertext].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DecryptResponse Decrypt(
            CryptoKeyName name,
            pb::ByteString ciphertext,
            gaxgrpc::CallSettings callSettings = null) => Decrypt(
                new DecryptRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Ciphertext = gax::GaxPreconditions.CheckNotNull(ciphertext, nameof(ciphertext)),
                },
                callSettings);

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DecryptResponse> DecryptAsync(
            DecryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DecryptResponse> DecryptAsync(
            DecryptRequest request,
            st::CancellationToken cancellationToken) => DecryptAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DecryptResponse Decrypt(
            DecryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to update.
        /// </param>
        /// <param name="cryptoKeyVersionId">
        /// The id of the child [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use as primary.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyPrimaryVersionAsync(
            CryptoKeyName name,
            string cryptoKeyVersionId,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKeyPrimaryVersionAsync(
                new UpdateCryptoKeyPrimaryVersionRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    CryptoKeyVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)),
                },
                callSettings);

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to update.
        /// </param>
        /// <param name="cryptoKeyVersionId">
        /// The id of the child [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use as primary.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyPrimaryVersionAsync(
            CryptoKeyName name,
            string cryptoKeyVersionId,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyPrimaryVersionAsync(
                name,
                cryptoKeyVersionId,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKey][google.cloud.kms.v1.CryptoKey] to update.
        /// </param>
        /// <param name="cryptoKeyVersionId">
        /// The id of the child [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to use as primary.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey UpdateCryptoKeyPrimaryVersion(
            CryptoKeyName name,
            string cryptoKeyVersionId,
            gaxgrpc::CallSettings callSettings = null) => UpdateCryptoKeyPrimaryVersion(
                new UpdateCryptoKeyPrimaryVersionRequest
                {
                    CryptoKeyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    CryptoKeyVersionId = gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)),
                },
                callSettings);

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyPrimaryVersionAsync(
            UpdateCryptoKeyPrimaryVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKey> UpdateCryptoKeyPrimaryVersionAsync(
            UpdateCryptoKeyPrimaryVersionRequest request,
            st::CancellationToken cancellationToken) => UpdateCryptoKeyPrimaryVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKey UpdateCryptoKeyPrimaryVersion(
            UpdateCryptoKeyPrimaryVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to destroy.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> DestroyCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => DestroyCryptoKeyVersionAsync(
                new DestroyCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to destroy.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> DestroyCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            st::CancellationToken cancellationToken) => DestroyCryptoKeyVersionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to destroy.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion DestroyCryptoKeyVersion(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => DestroyCryptoKeyVersion(
                new DestroyCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> DestroyCryptoKeyVersionAsync(
            DestroyCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> DestroyCryptoKeyVersionAsync(
            DestroyCryptoKeyVersionRequest request,
            st::CancellationToken cancellationToken) => DestroyCryptoKeyVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion DestroyCryptoKeyVersion(
            DestroyCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to restore.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> RestoreCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => RestoreCryptoKeyVersionAsync(
                new RestoreCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to restore.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> RestoreCryptoKeyVersionAsync(
            CryptoKeyVersionName name,
            st::CancellationToken cancellationToken) => RestoreCryptoKeyVersionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="name">
        /// The resource name of the [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] to restore.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion RestoreCryptoKeyVersion(
            CryptoKeyVersionName name,
            gaxgrpc::CallSettings callSettings = null) => RestoreCryptoKeyVersion(
                new RestoreCryptoKeyVersionRequest
                {
                    CryptoKeyVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> RestoreCryptoKeyVersionAsync(
            RestoreCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<CryptoKeyVersion> RestoreCryptoKeyVersionAsync(
            RestoreCryptoKeyVersionRequest request,
            st::CancellationToken cancellationToken) => RestoreCryptoKeyVersionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual CryptoKeyVersion RestoreCryptoKeyVersion(
            RestoreCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            KeyNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            KeyNameOneof resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            KeyNameOneof resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            KeyNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            KeyNameOneof resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            KeyNameOneof resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            KeyNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            KeyNameOneof resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            KeyNameOneof resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { gax::GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// KeyManagementService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class KeyManagementServiceClientImpl : KeyManagementServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListKeyRingsRequest, ListKeyRingsResponse> _callListKeyRings;
        private readonly gaxgrpc::ApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse> _callListCryptoKeys;
        private readonly gaxgrpc::ApiCall<ListCryptoKeyVersionsRequest, ListCryptoKeyVersionsResponse> _callListCryptoKeyVersions;
        private readonly gaxgrpc::ApiCall<GetKeyRingRequest, KeyRing> _callGetKeyRing;
        private readonly gaxgrpc::ApiCall<GetCryptoKeyRequest, CryptoKey> _callGetCryptoKey;
        private readonly gaxgrpc::ApiCall<GetCryptoKeyVersionRequest, CryptoKeyVersion> _callGetCryptoKeyVersion;
        private readonly gaxgrpc::ApiCall<CreateKeyRingRequest, KeyRing> _callCreateKeyRing;
        private readonly gaxgrpc::ApiCall<CreateCryptoKeyRequest, CryptoKey> _callCreateCryptoKey;
        private readonly gaxgrpc::ApiCall<CreateCryptoKeyVersionRequest, CryptoKeyVersion> _callCreateCryptoKeyVersion;
        private readonly gaxgrpc::ApiCall<UpdateCryptoKeyRequest, CryptoKey> _callUpdateCryptoKey;
        private readonly gaxgrpc::ApiCall<UpdateCryptoKeyVersionRequest, CryptoKeyVersion> _callUpdateCryptoKeyVersion;
        private readonly gaxgrpc::ApiCall<EncryptRequest, EncryptResponse> _callEncrypt;
        private readonly gaxgrpc::ApiCall<DecryptRequest, DecryptResponse> _callDecrypt;
        private readonly gaxgrpc::ApiCall<UpdateCryptoKeyPrimaryVersionRequest, CryptoKey> _callUpdateCryptoKeyPrimaryVersion;
        private readonly gaxgrpc::ApiCall<DestroyCryptoKeyVersionRequest, CryptoKeyVersion> _callDestroyCryptoKeyVersion;
        private readonly gaxgrpc::ApiCall<RestoreCryptoKeyVersionRequest, CryptoKeyVersion> _callRestoreCryptoKeyVersion;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the KeyManagementService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeyManagementServiceSettings"/> used within this client </param>
        public KeyManagementServiceClientImpl(KeyManagementService.KeyManagementServiceClient grpcClient, KeyManagementServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeyManagementServiceSettings effectiveSettings = settings ?? KeyManagementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            iam::IAMPolicy.IAMPolicyClient grpcIAMPolicyClient = grpcClient.CreateIAMPolicyClient();
            _callListKeyRings = clientHelper.BuildApiCall<ListKeyRingsRequest, ListKeyRingsResponse>(
                GrpcClient.ListKeyRingsAsync, GrpcClient.ListKeyRings, effectiveSettings.ListKeyRingsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListCryptoKeys = clientHelper.BuildApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse>(
                GrpcClient.ListCryptoKeysAsync, GrpcClient.ListCryptoKeys, effectiveSettings.ListCryptoKeysSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callListCryptoKeyVersions = clientHelper.BuildApiCall<ListCryptoKeyVersionsRequest, ListCryptoKeyVersionsResponse>(
                GrpcClient.ListCryptoKeyVersionsAsync, GrpcClient.ListCryptoKeyVersions, effectiveSettings.ListCryptoKeyVersionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callGetKeyRing = clientHelper.BuildApiCall<GetKeyRingRequest, KeyRing>(
                GrpcClient.GetKeyRingAsync, GrpcClient.GetKeyRing, effectiveSettings.GetKeyRingSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetCryptoKey = clientHelper.BuildApiCall<GetCryptoKeyRequest, CryptoKey>(
                GrpcClient.GetCryptoKeyAsync, GrpcClient.GetCryptoKey, effectiveSettings.GetCryptoKeySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callGetCryptoKeyVersion = clientHelper.BuildApiCall<GetCryptoKeyVersionRequest, CryptoKeyVersion>(
                GrpcClient.GetCryptoKeyVersionAsync, GrpcClient.GetCryptoKeyVersion, effectiveSettings.GetCryptoKeyVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callCreateKeyRing = clientHelper.BuildApiCall<CreateKeyRingRequest, KeyRing>(
                GrpcClient.CreateKeyRingAsync, GrpcClient.CreateKeyRing, effectiveSettings.CreateKeyRingSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateCryptoKey = clientHelper.BuildApiCall<CreateCryptoKeyRequest, CryptoKey>(
                GrpcClient.CreateCryptoKeyAsync, GrpcClient.CreateCryptoKey, effectiveSettings.CreateCryptoKeySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callCreateCryptoKeyVersion = clientHelper.BuildApiCall<CreateCryptoKeyVersionRequest, CryptoKeyVersion>(
                GrpcClient.CreateCryptoKeyVersionAsync, GrpcClient.CreateCryptoKeyVersion, effectiveSettings.CreateCryptoKeyVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"parent={request.Parent}"));
            _callUpdateCryptoKey = clientHelper.BuildApiCall<UpdateCryptoKeyRequest, CryptoKey>(
                GrpcClient.UpdateCryptoKeyAsync, GrpcClient.UpdateCryptoKey, effectiveSettings.UpdateCryptoKeySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"crypto_key.name={request.CryptoKey.Name}"));
            _callUpdateCryptoKeyVersion = clientHelper.BuildApiCall<UpdateCryptoKeyVersionRequest, CryptoKeyVersion>(
                GrpcClient.UpdateCryptoKeyVersionAsync, GrpcClient.UpdateCryptoKeyVersion, effectiveSettings.UpdateCryptoKeyVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"crypto_key_version.name={request.CryptoKeyVersion.Name}"));
            _callEncrypt = clientHelper.BuildApiCall<EncryptRequest, EncryptResponse>(
                GrpcClient.EncryptAsync, GrpcClient.Encrypt, effectiveSettings.EncryptSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDecrypt = clientHelper.BuildApiCall<DecryptRequest, DecryptResponse>(
                GrpcClient.DecryptAsync, GrpcClient.Decrypt, effectiveSettings.DecryptSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callUpdateCryptoKeyPrimaryVersion = clientHelper.BuildApiCall<UpdateCryptoKeyPrimaryVersionRequest, CryptoKey>(
                GrpcClient.UpdateCryptoKeyPrimaryVersionAsync, GrpcClient.UpdateCryptoKeyPrimaryVersion, effectiveSettings.UpdateCryptoKeyPrimaryVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callDestroyCryptoKeyVersion = clientHelper.BuildApiCall<DestroyCryptoKeyVersionRequest, CryptoKeyVersion>(
                GrpcClient.DestroyCryptoKeyVersionAsync, GrpcClient.DestroyCryptoKeyVersion, effectiveSettings.DestroyCryptoKeyVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callRestoreCryptoKeyVersion = clientHelper.BuildApiCall<RestoreCryptoKeyVersionRequest, CryptoKeyVersion>(
                GrpcClient.RestoreCryptoKeyVersionAsync, GrpcClient.RestoreCryptoKeyVersion, effectiveSettings.RestoreCryptoKeyVersionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"name={request.Name}"));
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.SetIamPolicyAsync, grpcIAMPolicyClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                grpcIAMPolicyClient.GetIamPolicyAsync, grpcIAMPolicyClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                grpcIAMPolicyClient.TestIamPermissionsAsync, grpcIAMPolicyClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource={request.Resource}"));
            Modify_ApiCall(ref _callListKeyRings);
            Modify_ListKeyRingsApiCall(ref _callListKeyRings);
            Modify_ApiCall(ref _callListCryptoKeys);
            Modify_ListCryptoKeysApiCall(ref _callListCryptoKeys);
            Modify_ApiCall(ref _callListCryptoKeyVersions);
            Modify_ListCryptoKeyVersionsApiCall(ref _callListCryptoKeyVersions);
            Modify_ApiCall(ref _callGetKeyRing);
            Modify_GetKeyRingApiCall(ref _callGetKeyRing);
            Modify_ApiCall(ref _callGetCryptoKey);
            Modify_GetCryptoKeyApiCall(ref _callGetCryptoKey);
            Modify_ApiCall(ref _callGetCryptoKeyVersion);
            Modify_GetCryptoKeyVersionApiCall(ref _callGetCryptoKeyVersion);
            Modify_ApiCall(ref _callCreateKeyRing);
            Modify_CreateKeyRingApiCall(ref _callCreateKeyRing);
            Modify_ApiCall(ref _callCreateCryptoKey);
            Modify_CreateCryptoKeyApiCall(ref _callCreateCryptoKey);
            Modify_ApiCall(ref _callCreateCryptoKeyVersion);
            Modify_CreateCryptoKeyVersionApiCall(ref _callCreateCryptoKeyVersion);
            Modify_ApiCall(ref _callUpdateCryptoKey);
            Modify_UpdateCryptoKeyApiCall(ref _callUpdateCryptoKey);
            Modify_ApiCall(ref _callUpdateCryptoKeyVersion);
            Modify_UpdateCryptoKeyVersionApiCall(ref _callUpdateCryptoKeyVersion);
            Modify_ApiCall(ref _callEncrypt);
            Modify_EncryptApiCall(ref _callEncrypt);
            Modify_ApiCall(ref _callDecrypt);
            Modify_DecryptApiCall(ref _callDecrypt);
            Modify_ApiCall(ref _callUpdateCryptoKeyPrimaryVersion);
            Modify_UpdateCryptoKeyPrimaryVersionApiCall(ref _callUpdateCryptoKeyPrimaryVersion);
            Modify_ApiCall(ref _callDestroyCryptoKeyVersion);
            Modify_DestroyCryptoKeyVersionApiCall(ref _callDestroyCryptoKeyVersion);
            Modify_ApiCall(ref _callRestoreCryptoKeyVersion);
            Modify_RestoreCryptoKeyVersionApiCall(ref _callRestoreCryptoKeyVersion);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListKeyRingsApiCall(ref gaxgrpc::ApiCall<ListKeyRingsRequest, ListKeyRingsResponse> call);
        partial void Modify_ListCryptoKeysApiCall(ref gaxgrpc::ApiCall<ListCryptoKeysRequest, ListCryptoKeysResponse> call);
        partial void Modify_ListCryptoKeyVersionsApiCall(ref gaxgrpc::ApiCall<ListCryptoKeyVersionsRequest, ListCryptoKeyVersionsResponse> call);
        partial void Modify_GetKeyRingApiCall(ref gaxgrpc::ApiCall<GetKeyRingRequest, KeyRing> call);
        partial void Modify_GetCryptoKeyApiCall(ref gaxgrpc::ApiCall<GetCryptoKeyRequest, CryptoKey> call);
        partial void Modify_GetCryptoKeyVersionApiCall(ref gaxgrpc::ApiCall<GetCryptoKeyVersionRequest, CryptoKeyVersion> call);
        partial void Modify_CreateKeyRingApiCall(ref gaxgrpc::ApiCall<CreateKeyRingRequest, KeyRing> call);
        partial void Modify_CreateCryptoKeyApiCall(ref gaxgrpc::ApiCall<CreateCryptoKeyRequest, CryptoKey> call);
        partial void Modify_CreateCryptoKeyVersionApiCall(ref gaxgrpc::ApiCall<CreateCryptoKeyVersionRequest, CryptoKeyVersion> call);
        partial void Modify_UpdateCryptoKeyApiCall(ref gaxgrpc::ApiCall<UpdateCryptoKeyRequest, CryptoKey> call);
        partial void Modify_UpdateCryptoKeyVersionApiCall(ref gaxgrpc::ApiCall<UpdateCryptoKeyVersionRequest, CryptoKeyVersion> call);
        partial void Modify_EncryptApiCall(ref gaxgrpc::ApiCall<EncryptRequest, EncryptResponse> call);
        partial void Modify_DecryptApiCall(ref gaxgrpc::ApiCall<DecryptRequest, DecryptResponse> call);
        partial void Modify_UpdateCryptoKeyPrimaryVersionApiCall(ref gaxgrpc::ApiCall<UpdateCryptoKeyPrimaryVersionRequest, CryptoKey> call);
        partial void Modify_DestroyCryptoKeyVersionApiCall(ref gaxgrpc::ApiCall<DestroyCryptoKeyVersionRequest, CryptoKeyVersion> call);
        partial void Modify_RestoreCryptoKeyVersionApiCall(ref gaxgrpc::ApiCall<RestoreCryptoKeyVersionRequest, CryptoKeyVersion> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(KeyManagementService.KeyManagementServiceClient grpcClient, KeyManagementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC KeyManagementService client.
        /// </summary>
        public override KeyManagementService.KeyManagementServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListKeyRingsRequest(ref ListKeyRingsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListCryptoKeysRequest(ref ListCryptoKeysRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListCryptoKeyVersionsRequest(ref ListCryptoKeyVersionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetKeyRingRequest(ref GetKeyRingRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetCryptoKeyRequest(ref GetCryptoKeyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetCryptoKeyVersionRequest(ref GetCryptoKeyVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateKeyRingRequest(ref CreateKeyRingRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateCryptoKeyRequest(ref CreateCryptoKeyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateCryptoKeyVersionRequest(ref CreateCryptoKeyVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateCryptoKeyRequest(ref UpdateCryptoKeyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateCryptoKeyVersionRequest(ref UpdateCryptoKeyVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_EncryptRequest(ref EncryptRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DecryptRequest(ref DecryptRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateCryptoKeyPrimaryVersionRequest(ref UpdateCryptoKeyPrimaryVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DestroyCryptoKeyVersionRequest(ref DestroyCryptoKeyVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_RestoreCryptoKeyVersionRequest(ref RestoreCryptoKeyVersionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRingsAsync(
            ListKeyRingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyRingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListKeyRingsRequest, ListKeyRingsResponse, KeyRing>(_callListKeyRings, request, callSettings);
        }

        /// <summary>
        /// Lists [KeyRings][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="KeyRing"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListKeyRingsResponse, KeyRing> ListKeyRings(
            ListKeyRingsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListKeyRingsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListKeyRingsRequest, ListKeyRingsResponse, KeyRing>(_callListKeyRings, request, callSettings);
        }

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeysAsync(
            ListCryptoKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCryptoKeysRequest, ListCryptoKeysResponse, CryptoKey>(_callListCryptoKeys, request, callSettings);
        }

        /// <summary>
        /// Lists [CryptoKeys][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKey"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListCryptoKeysResponse, CryptoKey> ListCryptoKeys(
            ListCryptoKeysRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeysRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCryptoKeysRequest, ListCryptoKeysResponse, CryptoKey>(_callListCryptoKeys, request, callSettings);
        }

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersionsAsync(
            ListCryptoKeyVersionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeyVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCryptoKeyVersionsRequest, ListCryptoKeyVersionsResponse, CryptoKeyVersion>(_callListCryptoKeyVersions, request, callSettings);
        }

        /// <summary>
        /// Lists [CryptoKeyVersions][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="CryptoKeyVersion"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListCryptoKeyVersionsResponse, CryptoKeyVersion> ListCryptoKeyVersions(
            ListCryptoKeyVersionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCryptoKeyVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCryptoKeyVersionsRequest, ListCryptoKeyVersionsResponse, CryptoKeyVersion>(_callListCryptoKeyVersions, request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<KeyRing> GetKeyRingAsync(
            GetKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRingRequest(ref request, ref callSettings);
            return _callGetKeyRing.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [KeyRing][google.cloud.kms.v1.KeyRing].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override KeyRing GetKeyRing(
            GetKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeyRingRequest(ref request, ref callSettings);
            return _callGetKeyRing.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKey> GetCryptoKeyAsync(
            GetCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCryptoKeyRequest(ref request, ref callSettings);
            return _callGetCryptoKey.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKey][google.cloud.kms.v1.CryptoKey], as well as its
        /// [primary][google.cloud.kms.v1.CryptoKey.primary] [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKey GetCryptoKey(
            GetCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCryptoKeyRequest(ref request, ref callSettings);
            return _callGetCryptoKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKeyVersion> GetCryptoKeyVersionAsync(
            GetCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callGetCryptoKeyVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metadata for a given [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKeyVersion GetCryptoKeyVersion(
            GetCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callGetCryptoKeyVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<KeyRing> CreateKeyRingAsync(
            CreateKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRingRequest(ref request, ref callSettings);
            return _callCreateKeyRing.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new [KeyRing][google.cloud.kms.v1.KeyRing] in a given Project and Location.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override KeyRing CreateKeyRing(
            CreateKeyRingRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateKeyRingRequest(ref request, ref callSettings);
            return _callCreateKeyRing.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKey> CreateCryptoKeyAsync(
            CreateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCryptoKeyRequest(ref request, ref callSettings);
            return _callCreateCryptoKey.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new [CryptoKey][google.cloud.kms.v1.CryptoKey] within a [KeyRing][google.cloud.kms.v1.KeyRing].
        ///
        /// [CryptoKey.purpose][google.cloud.kms.v1.CryptoKey.purpose] is required.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKey CreateCryptoKey(
            CreateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCryptoKeyRequest(ref request, ref callSettings);
            return _callCreateCryptoKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKeyVersion> CreateCryptoKeyVersionAsync(
            CreateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callCreateCryptoKeyVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Create a new [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        ///
        /// The server will assign the next sequential id. If unset,
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKeyVersion CreateCryptoKeyVersion(
            CreateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callCreateCryptoKeyVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKey> UpdateCryptoKeyAsync(
            UpdateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyRequest(ref request, ref callSettings);
            return _callUpdateCryptoKey.Async(request, callSettings);
        }

        /// <summary>
        /// Update a [CryptoKey][google.cloud.kms.v1.CryptoKey].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKey UpdateCryptoKey(
            UpdateCryptoKeyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyRequest(ref request, ref callSettings);
            return _callUpdateCryptoKey.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKeyVersion> UpdateCryptoKeyVersionAsync(
            UpdateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callUpdateCryptoKeyVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Update a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion]'s metadata.
        ///
        /// [state][google.cloud.kms.v1.CryptoKeyVersion.state] may be changed between
        /// [ENABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.ENABLED] and
        /// [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED] using this
        /// method. See [DestroyCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.DestroyCryptoKeyVersion] and [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] to
        /// move between other states.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKeyVersion UpdateCryptoKeyVersion(
            UpdateCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callUpdateCryptoKeyVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<EncryptResponse> EncryptAsync(
            EncryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptRequest(ref request, ref callSettings);
            return _callEncrypt.Async(request, callSettings);
        }

        /// <summary>
        /// Encrypts data, so that it can only be recovered by a call to [Decrypt][google.cloud.kms.v1.KeyManagementService.Decrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override EncryptResponse Encrypt(
            EncryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EncryptRequest(ref request, ref callSettings);
            return _callEncrypt.Sync(request, callSettings);
        }

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DecryptResponse> DecryptAsync(
            DecryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DecryptRequest(ref request, ref callSettings);
            return _callDecrypt.Async(request, callSettings);
        }

        /// <summary>
        /// Decrypts data that was protected by [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt].
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DecryptResponse Decrypt(
            DecryptRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DecryptRequest(ref request, ref callSettings);
            return _callDecrypt.Sync(request, callSettings);
        }

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKey> UpdateCryptoKeyPrimaryVersionAsync(
            UpdateCryptoKeyPrimaryVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyPrimaryVersionRequest(ref request, ref callSettings);
            return _callUpdateCryptoKeyPrimaryVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Update the version of a [CryptoKey][google.cloud.kms.v1.CryptoKey] that will be used in [Encrypt][google.cloud.kms.v1.KeyManagementService.Encrypt]
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKey UpdateCryptoKeyPrimaryVersion(
            UpdateCryptoKeyPrimaryVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCryptoKeyPrimaryVersionRequest(ref request, ref callSettings);
            return _callUpdateCryptoKeyPrimaryVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKeyVersion> DestroyCryptoKeyVersionAsync(
            DestroyCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DestroyCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callDestroyCryptoKeyVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Schedule a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] for destruction.
        ///
        /// Upon calling this method, [CryptoKeyVersion.state][google.cloud.kms.v1.CryptoKeyVersion.state] will be set to
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED]
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be set to a time 24
        /// hours in the future, at which point the [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be changed to
        /// [DESTROYED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROYED], and the key
        /// material will be irrevocably destroyed.
        ///
        /// Before the [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] is reached,
        /// [RestoreCryptoKeyVersion][google.cloud.kms.v1.KeyManagementService.RestoreCryptoKeyVersion] may be called to reverse the process.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKeyVersion DestroyCryptoKeyVersion(
            DestroyCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DestroyCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callDestroyCryptoKeyVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<CryptoKeyVersion> RestoreCryptoKeyVersionAsync(
            RestoreCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callRestoreCryptoKeyVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Restore a [CryptoKeyVersion][google.cloud.kms.v1.CryptoKeyVersion] in the
        /// [DESTROY_SCHEDULED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DESTROY_SCHEDULED],
        /// state.
        ///
        /// Upon restoration of the CryptoKeyVersion, [state][google.cloud.kms.v1.CryptoKeyVersion.state]
        /// will be set to [DISABLED][google.cloud.kms.v1.CryptoKeyVersion.CryptoKeyVersionState.DISABLED],
        /// and [destroy_time][google.cloud.kms.v1.CryptoKeyVersion.destroy_time] will be cleared.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override CryptoKeyVersion RestoreCryptoKeyVersion(
            RestoreCryptoKeyVersionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreCryptoKeyVersionRequest(ref request, ref callSettings);
            return _callRestoreCryptoKeyVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for a resource.
        /// Returns an empty policy if the resource exists and does not have a policy
        /// set.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// If the resource does not exist, this will return an empty set of
        /// permissions, not a NOT_FOUND error.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListKeyRingsRequest : gaxgrpc::IPageRequest { }
    public partial class ListKeyRingsResponse : gaxgrpc::IPageResponse<KeyRing>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<KeyRing> GetEnumerator() => KeyRings.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCryptoKeysRequest : gaxgrpc::IPageRequest { }
    public partial class ListCryptoKeysResponse : gaxgrpc::IPageResponse<CryptoKey>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<CryptoKey> GetEnumerator() => CryptoKeys.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCryptoKeyVersionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListCryptoKeyVersionsResponse : gaxgrpc::IPageResponse<CryptoKeyVersion>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<CryptoKeyVersion> GetEnumerator() => CryptoKeyVersions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable iam::IAMPolicy.IAMPolicyClient client creation
    public static partial class KeyManagementService
    {
        public partial class KeyManagementServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="iam::IAMPolicy.IAMPolicyClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new iam::IAMPolicy.IAMPolicyClient for the same target as this client.</returns>
            public virtual iam::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() => new iam::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }


}