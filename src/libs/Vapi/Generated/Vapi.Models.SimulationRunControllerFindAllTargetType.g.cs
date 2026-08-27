
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum SimulationRunControllerFindAllTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        Squad,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimulationRunControllerFindAllTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationRunControllerFindAllTargetType value)
        {
            return value switch
            {
                SimulationRunControllerFindAllTargetType.Assistant => "assistant",
                SimulationRunControllerFindAllTargetType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationRunControllerFindAllTargetType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SimulationRunControllerFindAllTargetType.Assistant,
                "squad" => SimulationRunControllerFindAllTargetType.Squad,
                _ => null,
            };
        }
    }
}