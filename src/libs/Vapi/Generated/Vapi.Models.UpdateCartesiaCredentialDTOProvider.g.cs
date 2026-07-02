
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCartesiaCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCartesiaCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCartesiaCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateCartesiaCredentialDTOProvider.Cartesia => "cartesia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCartesiaCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cartesia" => UpdateCartesiaCredentialDTOProvider.Cartesia,
                _ => null,
            };
        }
    }
}