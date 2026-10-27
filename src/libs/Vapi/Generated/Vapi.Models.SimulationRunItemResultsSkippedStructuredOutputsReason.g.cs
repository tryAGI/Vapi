
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunItemResultsSkippedStructuredOutputsReason
    {
        /// <summary>
        ///
        /// </summary>
        AudioNotSupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunItemResultsSkippedStructuredOutputsReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunItemResultsSkippedStructuredOutputsReason value)
        {
            return value switch
            {
                SimulationRunItemResultsSkippedStructuredOutputsReason.AudioNotSupported => "audio-not-supported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunItemResultsSkippedStructuredOutputsReason? ToEnum(string value)
        {
            return value switch
            {
                "audio-not-supported" => SimulationRunItemResultsSkippedStructuredOutputsReason.AudioNotSupported,
                _ => null,
            };
        }
    }
}