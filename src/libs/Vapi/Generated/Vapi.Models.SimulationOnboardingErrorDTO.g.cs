
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingErrorDTO
    {
        /// <summary>
        /// Which refusal this is. Retry `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS` with the same key and `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED` or `SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE` after `retryAfterSeconds`, send a new key for `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, and stop for `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationOnboardingErrorDTOCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationOnboardingErrorDTOCode Code { get; set; }

        /// <summary>
        /// What happened, written for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Seconds to wait before retrying, the same value as the `Retry-After` header. For a daily limit, the seconds until 00:00 UTC.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retryAfterSeconds")]
        public double? RetryAfterSeconds { get; set; }

        /// <summary>
        /// The daily limit that was reached, on a daily-limit refusal only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingErrorDTO" /> class.
        /// </summary>
        /// <param name="code">
        /// Which refusal this is. Retry `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS` with the same key and `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED` or `SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE` after `retryAfterSeconds`, send a new key for `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, and stop for `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`.
        /// </param>
        /// <param name="message">
        /// What happened, written for the user.
        /// </param>
        /// <param name="retryAfterSeconds">
        /// Seconds to wait before retrying, the same value as the `Retry-After` header. For a daily limit, the seconds until 00:00 UTC.
        /// </param>
        /// <param name="limit">
        /// The daily limit that was reached, on a daily-limit refusal only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingErrorDTO(
            global::Vapi.SimulationOnboardingErrorDTOCode code,
            string message,
            double? retryAfterSeconds,
            double? limit)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryAfterSeconds = retryAfterSeconds;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingErrorDTO" /> class.
        /// </summary>
        public SimulationOnboardingErrorDTO()
        {
        }

    }
}