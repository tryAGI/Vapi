
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the api key for Pi in InflectionAI's console. Get it from here: https://developers.inflection.ai/keys, billing will need to be setup
    /// </summary>
    public enum UpdateInflectionAICredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        InflectionAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateInflectionAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateInflectionAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateInflectionAICredentialDTOProvider.InflectionAi => "inflection-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateInflectionAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "inflection-ai" => UpdateInflectionAICredentialDTOProvider.InflectionAi,
                _ => null,
            };
        }
    }
}