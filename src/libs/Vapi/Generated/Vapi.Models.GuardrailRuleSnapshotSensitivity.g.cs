
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
    /// </summary>
    public enum GuardrailRuleSnapshotSensitivity
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
    public static class GuardrailRuleSnapshotSensitivityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRuleSnapshotSensitivity value)
        {
            return value switch
            {
                GuardrailRuleSnapshotSensitivity.Aggressive => "aggressive",
                GuardrailRuleSnapshotSensitivity.Low => "low",
                GuardrailRuleSnapshotSensitivity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRuleSnapshotSensitivity? ToEnum(string value)
        {
            return value switch
            {
                "aggressive" => GuardrailRuleSnapshotSensitivity.Aggressive,
                "low" => GuardrailRuleSnapshotSensitivity.Low,
                "medium" => GuardrailRuleSnapshotSensitivity.Medium,
                _ => null,
            };
        }
    }
}