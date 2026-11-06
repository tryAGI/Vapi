
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum GuardrailRedirectActionMode
    {
        /// <summary>
        ///
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailRedirectActionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailRedirectActionMode value)
        {
            return value switch
            {
                GuardrailRedirectActionMode.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailRedirectActionMode? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => GuardrailRedirectActionMode.Redirect,
                _ => null,
            };
        }
    }
}