
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    public enum CreateGuardrailRuleDTOSensitivity
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
    public static class CreateGuardrailRuleDTOSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGuardrailRuleDTOSensitivity value)
        {
            return value switch
            {
                CreateGuardrailRuleDTOSensitivity.Aggressive => "aggressive",
                CreateGuardrailRuleDTOSensitivity.Low => "low",
                CreateGuardrailRuleDTOSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGuardrailRuleDTOSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "aggressive" => CreateGuardrailRuleDTOSensitivity.Aggressive,
                "low" => CreateGuardrailRuleDTOSensitivity.Low,
                "medium" => CreateGuardrailRuleDTOSensitivity.Medium,
                _ => null,
            };
        }
    }
}