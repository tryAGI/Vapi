
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateOpenRouterCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Openrouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOpenRouterCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOpenRouterCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateOpenRouterCredentialDTOProvider.Openrouter => "openrouter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOpenRouterCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "openrouter" => UpdateOpenRouterCredentialDTOProvider.Openrouter,
                _ => null,
            };
        }
    }
}