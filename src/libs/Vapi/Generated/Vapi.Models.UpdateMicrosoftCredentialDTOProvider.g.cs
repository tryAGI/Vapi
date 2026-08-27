
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateMicrosoftCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateMicrosoftCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMicrosoftCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateMicrosoftCredentialDTOProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMicrosoftCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => UpdateMicrosoftCredentialDTOProvider.Microsoft,
                _ => null,
            };
        }
    }
}