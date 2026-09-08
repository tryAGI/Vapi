
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum ScenarioInUseConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        ScenarioInUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScenarioInUseConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScenarioInUseConflictResponseDTOError value)
        {
            return value switch
            {
                ScenarioInUseConflictResponseDTOError.ScenarioInUse => "scenario_in_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScenarioInUseConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "scenario_in_use" => ScenarioInUseConflictResponseDTOError.ScenarioInUse,
                _ => null,
            };
        }
    }
}