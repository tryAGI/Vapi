
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateMistralCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Mistral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMistralCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMistralCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateMistralCredentialDTOProvider.Mistral => "mistral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMistralCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "mistral" => UpdateMistralCredentialDTOProvider.Mistral,
                _ => null,
            };
        }
    }
}