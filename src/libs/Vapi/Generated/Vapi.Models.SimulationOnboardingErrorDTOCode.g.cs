
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Which refusal this is. Retry `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS` with the same key and `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED` or `SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE` after `retryAfterSeconds`, send a new key for `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, and stop for `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`.
    /// </summary>
    public enum SimulationOnboardingErrorDTOCode
    {
        /// <summary>
        ///
        /// </summary>
        SimulationOnboardingConcurrencyLimited,
        /// <summary>
        ///
        /// </summary>
        SimulationOnboardingGenerationInProgress,
        /// <summary>
        ///
        /// </summary>
        SimulationOnboardingIdempotencyKeyReused,
        /// <summary>
        ///
        /// </summary>
        SimulationOnboardingQuotaExceeded,
        /// <summary>
        ///
        /// </summary>
        SimulationOnboardingQuotaUnavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationOnboardingErrorDTOCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationOnboardingErrorDTOCode value)
        {
            return value switch
            {
                SimulationOnboardingErrorDTOCode.SimulationOnboardingConcurrencyLimited => "SIMULATION_ONBOARDING_CONCURRENCY_LIMITED",
                SimulationOnboardingErrorDTOCode.SimulationOnboardingGenerationInProgress => "SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS",
                SimulationOnboardingErrorDTOCode.SimulationOnboardingIdempotencyKeyReused => "SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED",
                SimulationOnboardingErrorDTOCode.SimulationOnboardingQuotaExceeded => "SIMULATION_ONBOARDING_QUOTA_EXCEEDED",
                SimulationOnboardingErrorDTOCode.SimulationOnboardingQuotaUnavailable => "SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationOnboardingErrorDTOCode? ToEnum(string value)
        {
            return value switch
            {
                "SIMULATION_ONBOARDING_CONCURRENCY_LIMITED" => SimulationOnboardingErrorDTOCode.SimulationOnboardingConcurrencyLimited,
                "SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS" => SimulationOnboardingErrorDTOCode.SimulationOnboardingGenerationInProgress,
                "SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED" => SimulationOnboardingErrorDTOCode.SimulationOnboardingIdempotencyKeyReused,
                "SIMULATION_ONBOARDING_QUOTA_EXCEEDED" => SimulationOnboardingErrorDTOCode.SimulationOnboardingQuotaExceeded,
                "SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE" => SimulationOnboardingErrorDTOCode.SimulationOnboardingQuotaUnavailable,
                _ => null,
            };
        }
    }
}