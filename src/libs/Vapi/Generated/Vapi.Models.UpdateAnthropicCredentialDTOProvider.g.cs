
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAnthropicCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAnthropicCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAnthropicCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAnthropicCredentialDTOProvider.Anthropic => "anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAnthropicCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateAnthropicCredentialDTOProvider.Anthropic,
                _ => null,
            };
        }
    }
}