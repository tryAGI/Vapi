
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of target assigned to the simulation suite.
    /// </summary>
    public enum SimulationSuiteTargetAssignmentTargetType
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
    public static class SimulationSuiteTargetAssignmentTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimulationSuiteTargetAssignmentTargetType value)
        {
            return value switch
            {
                SimulationSuiteTargetAssignmentTargetType.Assistant => "assistant",
                SimulationSuiteTargetAssignmentTargetType.Squad => "squad",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimulationSuiteTargetAssignmentTargetType? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SimulationSuiteTargetAssignmentTargetType.Assistant,
                "squad" => SimulationSuiteTargetAssignmentTargetType.Squad,
                _ => null,
            };
        }
    }
}