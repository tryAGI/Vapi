
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the key for Gemini in Google AI Studio. Get it from here: https://aistudio.google.com/app/apikey
    /// </summary>
    public enum UpdateGoogleCredentialDTOProvider
    {
        /// <summary>
        /// https://aistudio.google.com/app/apikey
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoogleCredentialDTOProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => UpdateGoogleCredentialDTOProvider.Google,
                _ => null,
            };
        }
    }
}