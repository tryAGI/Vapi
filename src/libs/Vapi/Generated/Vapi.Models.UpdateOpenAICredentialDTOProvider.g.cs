
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateOpenAICredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOpenAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOpenAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateOpenAICredentialDTOProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOpenAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => UpdateOpenAICredentialDTOProvider.Openai,
                _ => null,
            };
        }
    }
}