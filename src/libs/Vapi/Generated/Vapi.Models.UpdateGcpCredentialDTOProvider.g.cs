
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateGcpCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGcpCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGcpCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGcpCredentialDTOProvider.Gcp => "gcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGcpCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gcp" => UpdateGcpCredentialDTOProvider.Gcp,
                _ => null,
            };
        }
    }
}