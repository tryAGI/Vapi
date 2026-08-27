
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateTogetherAICredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        TogetherAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTogetherAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTogetherAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateTogetherAICredentialDTOProvider.TogetherAi => "together-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTogetherAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "together-ai" => UpdateTogetherAICredentialDTOProvider.TogetherAi,
                _ => null,
            };
        }
    }
}