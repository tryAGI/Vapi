
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCredentialProvider value)
        {
            return value switch
            {
                WebhookCredentialProvider.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => WebhookCredentialProvider.Webhook,
                _ => null,
            };
        }
    }
}