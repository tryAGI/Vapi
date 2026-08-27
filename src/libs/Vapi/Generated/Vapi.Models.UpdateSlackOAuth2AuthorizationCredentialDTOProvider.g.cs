
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateSlackOAuth2AuthorizationCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        SlackOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSlackOAuth2AuthorizationCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSlackOAuth2AuthorizationCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateSlackOAuth2AuthorizationCredentialDTOProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSlackOAuth2AuthorizationCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack.oauth2-authorization" => UpdateSlackOAuth2AuthorizationCredentialDTOProvider.SlackOauth2Authorization,
                _ => null,
            };
        }
    }
}