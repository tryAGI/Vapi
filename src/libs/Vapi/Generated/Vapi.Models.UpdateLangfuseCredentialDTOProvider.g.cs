
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateLangfuseCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Langfuse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateLangfuseCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLangfuseCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateLangfuseCredentialDTOProvider.Langfuse => "langfuse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLangfuseCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "langfuse" => UpdateLangfuseCredentialDTOProvider.Langfuse,
                _ => null,
            };
        }
    }
}