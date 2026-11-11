
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Machine-readable cause; clients branch on this, never on `message`.
    /// </summary>
    public enum GuardrailPackConflictResponseDTOError
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
        PackChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailPackConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailPackConflictResponseDTOError value)
        {
            return value switch
            {
                GuardrailPackConflictResponseDTOError.GlobalAssignment => "global_assignment",
                GuardrailPackConflictResponseDTOError.ImpactChanged => "impact_changed",
                GuardrailPackConflictResponseDTOError.PackChanged => "pack_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailPackConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "global_assignment" => GuardrailPackConflictResponseDTOError.GlobalAssignment,
                "impact_changed" => GuardrailPackConflictResponseDTOError.ImpactChanged,
                "pack_changed" => GuardrailPackConflictResponseDTOError.PackChanged,
                _ => null,
            };
        }
    }
}