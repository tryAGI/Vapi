
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailRedirectActionType
    {
        /// <summary>
        ///
        /// </summary>
        AutoResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailRedirectActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRedirectActionType value)
        {
            return value switch
            {
                GuardrailRedirectActionType.AutoResponse => "auto-response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRedirectActionType? ToEnum(string value)
        {
            return value switch
            {
                "auto-response" => GuardrailRedirectActionType.AutoResponse,
                _ => null,
            };
        }
    }
}