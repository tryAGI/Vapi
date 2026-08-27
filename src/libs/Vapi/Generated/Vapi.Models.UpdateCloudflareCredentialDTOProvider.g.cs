
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Credential provider. Only allowed value is cloudflare
    /// </summary>
    public enum UpdateCloudflareCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Cloudflare,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCloudflareCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCloudflareCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateCloudflareCredentialDTOProvider.Cloudflare => "cloudflare",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCloudflareCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cloudflare" => UpdateCloudflareCredentialDTOProvider.Cloudflare,
                _ => null,
            };
        }
    }
}