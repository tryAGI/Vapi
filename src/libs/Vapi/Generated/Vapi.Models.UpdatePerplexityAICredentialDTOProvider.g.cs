
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdatePerplexityAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdatePerplexityAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePerplexityAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdatePerplexityAICredentialDTOProvider.PerplexityAi => "perplexity-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePerplexityAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "perplexity-ai" => UpdatePerplexityAICredentialDTOProvider.PerplexityAi,
                _ => null,
            };
        }
    }
}