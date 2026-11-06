
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailFixedResponseActionType
    {
        /// <summary>
        ///
        /// </summary>
        AutoResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailFixedResponseActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailFixedResponseActionType value)
        {
            return value switch
            {
                GuardrailFixedResponseActionType.AutoResponse => "auto-response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailFixedResponseActionType? ToEnum(string value)
        {
            return value switch
            {
                "auto-response" => GuardrailFixedResponseActionType.AutoResponse,
                _ => null,
            };
        }
    }
}