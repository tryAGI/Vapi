
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateSlackWebhookCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSlackWebhookCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSlackWebhookCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateSlackWebhookCredentialDTOProvider.SlackWebhook => "slack-webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSlackWebhookCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "slack-webhook" => UpdateSlackWebhookCredentialDTOProvider.SlackWebhook,
                _ => null,
            };
        }
    }
}