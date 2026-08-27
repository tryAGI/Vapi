
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAnthropicBedrockCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        AnthropicBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnthropicBedrockCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnthropicBedrockCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAnthropicBedrockCredentialDTOProvider.AnthropicBedrock => "anthropic-bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnthropicBedrockCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-bedrock" => UpdateAnthropicBedrockCredentialDTOProvider.AnthropicBedrock,
                _ => null,
            };
        }
    }
}