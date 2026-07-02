
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateGoHighLevelCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateGoHighLevelCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateGoHighLevelCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateGoHighLevelCredentialDTOProvider.Gohighlevel => "gohighlevel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateGoHighLevelCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "gohighlevel" => UpdateGoHighLevelCredentialDTOProvider.Gohighlevel,
                _ => null,
            };
        }
    }
}