
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Machine-readable cause; clients branch on this, never on `message`.
    /// </summary>
    public enum GuardrailRuleConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        GlobalAssignment,
        /// <summary>
        ///
        /// </summary>
        ImpactChanged,
        /// <summary>
        ///
        /// </summary>
        RuleChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailRuleConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRuleConflictResponseDTOError value)
        {
            return value switch
            {
                GuardrailRuleConflictResponseDTOError.GlobalAssignment => "global_assignment",
                GuardrailRuleConflictResponseDTOError.ImpactChanged => "impact_changed",
                GuardrailRuleConflictResponseDTOError.RuleChanged => "rule_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRuleConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "global_assignment" => GuardrailRuleConflictResponseDTOError.GlobalAssignment,
                "impact_changed" => GuardrailRuleConflictResponseDTOError.ImpactChanged,
                "rule_changed" => GuardrailRuleConflictResponseDTOError.RuleChanged,
                _ => null,
            };
        }
    }
}