
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    public enum SaveGuardrailRuleDTOSensitivity
    {
        /// <summary>
        ///
        /// </summary>
        Aggressive,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SaveGuardrailRuleDTOSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SaveGuardrailRuleDTOSensitivity value)
        {
            return value switch
            {
                SaveGuardrailRuleDTOSensitivity.Aggressive => "aggressive",
                SaveGuardrailRuleDTOSensitivity.Low => "low",
                SaveGuardrailRuleDTOSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SaveGuardrailRuleDTOSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "aggressive" => SaveGuardrailRuleDTOSensitivity.Aggressive,
                "low" => SaveGuardrailRuleDTOSensitivity.Low,
                "medium" => SaveGuardrailRuleDTOSensitivity.Medium,
                _ => null,
            };
        }
    }
}