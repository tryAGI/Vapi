
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomLLMCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomLLMCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomLLMCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateCustomLLMCredentialDTOProvider.CustomLlm => "custom-llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomLLMCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "custom-llm" => UpdateCustomLLMCredentialDTOProvider.CustomLlm,
                _ => null,
            };
        }
    }
}