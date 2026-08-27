
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateGoHighLevelMCPCredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        GhlOauth2Authorization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoHighLevelMCPCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoHighLevelMCPCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoHighLevelMCPCredentialDTOProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoHighLevelMCPCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "ghl.oauth2-authorization" => UpdateGoHighLevelMCPCredentialDTOProvider.GhlOauth2Authorization,
                _ => null,
            };
        }
    }
}