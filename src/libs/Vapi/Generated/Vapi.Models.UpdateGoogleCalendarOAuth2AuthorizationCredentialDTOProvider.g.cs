
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-authorization" => UpdateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider.GoogleCalendarOauth2Authorization,
                _ => null,
            };
        }
    }
}