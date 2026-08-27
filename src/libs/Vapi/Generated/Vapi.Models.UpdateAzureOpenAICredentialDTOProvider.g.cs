
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAzureOpenAICredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAzureOpenAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAzureOpenAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAzureOpenAICredentialDTOProvider.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAzureOpenAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => UpdateAzureOpenAICredentialDTOProvider.AzureOpenai,
                _ => null,
            };
        }
    }
}