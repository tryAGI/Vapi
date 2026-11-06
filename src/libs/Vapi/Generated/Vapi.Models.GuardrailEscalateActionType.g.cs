
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailEscalateActionType
    {
        /// <summary>
        ///
        /// </summary>
        Escalate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailEscalateActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailEscalateActionType value)
        {
            return value switch
            {
                GuardrailEscalateActionType.Escalate => "escalate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailEscalateActionType? ToEnum(string value)
        {
            return value switch
            {
                "escalate" => GuardrailEscalateActionType.Escalate,
                _ => null,
            };
        }
    }
}