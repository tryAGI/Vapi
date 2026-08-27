
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGroqCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Groq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGroqCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGroqCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGroqCredentialDTOProvider.Groq => "groq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGroqCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "groq" => UpdateGroqCredentialDTOProvider.Groq,
                _ => null,
            };
        }
    }
}