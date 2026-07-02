
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the api key for Grok in XAi's console. Get it from here: https://console.x.ai
    /// </summary>
    public enum UpdateXAiCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateXAiCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateXAiCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateXAiCredentialDTOProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateXAiCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "xai" => UpdateXAiCredentialDTOProvider.Xai,
                _ => null,
            };
        }
    }
}