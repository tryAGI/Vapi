
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        GoogleCalendarOauth2Client,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoogleCalendarOAuth2ClientCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "google.calendar.oauth2-client" => UpdateGoogleCalendarOAuth2ClientCredentialDTOProvider.GoogleCalendarOauth2Client,
                _ => null,
            };
        }
    }
}