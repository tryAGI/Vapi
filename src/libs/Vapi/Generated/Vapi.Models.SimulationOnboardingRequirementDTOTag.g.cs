
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Indicates an assumption, a requirement that needs a voice simulation, or a requirement that cannot be tested.
    /// </summary>
    public enum SimulationOnboardingRequirementDTOTag
    {
        /// <summary>
        ///
        /// </summary>
        Assumption,
        /// <summary>
        ///
        /// </summary>
        NotTestable,
        /// <summary>
        ///
        /// </summary>
        VoiceOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationOnboardingRequirementDTOTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationOnboardingRequirementDTOTag value)
        {
            return value switch
            {
                SimulationOnboardingRequirementDTOTag.Assumption => "assumption",
                SimulationOnboardingRequirementDTOTag.NotTestable => "not-testable",
                SimulationOnboardingRequirementDTOTag.VoiceOnly => "voice-only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationOnboardingRequirementDTOTag? ToEnum(string value)
        {
            return value switch
            {
                "assumption" => SimulationOnboardingRequirementDTOTag.Assumption,
                "not-testable" => SimulationOnboardingRequirementDTOTag.NotTestable,
                "voice-only" => SimulationOnboardingRequirementDTOTag.VoiceOnly,
                _ => null,
            };
        }
    }
}