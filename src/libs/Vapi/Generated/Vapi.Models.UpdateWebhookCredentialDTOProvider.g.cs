
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateWebhookCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateWebhookCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateWebhookCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateWebhookCredentialDTOProvider.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateWebhookCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => UpdateWebhookCredentialDTOProvider.Webhook,
                _ => null,
            };
        }
    }
}