
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    public enum GuardrailRuleSensitivity
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
    public static class GuardrailRuleSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRuleSensitivity value)
        {
            return value switch
            {
                GuardrailRuleSensitivity.Aggressive => "aggressive",
                GuardrailRuleSensitivity.Low => "low",
                GuardrailRuleSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRuleSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "aggressive" => GuardrailRuleSensitivity.Aggressive,
                "low" => GuardrailRuleSensitivity.Low,
                "medium" => GuardrailRuleSensitivity.Medium,
                _ => null,
            };
        }
    }
}