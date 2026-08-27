
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        GoogleSheetsOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.sheets.oauth2-authorization" => UpdateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.GoogleSheetsOauth2Authorization,
                _ => null,
            };
        }
    }
}