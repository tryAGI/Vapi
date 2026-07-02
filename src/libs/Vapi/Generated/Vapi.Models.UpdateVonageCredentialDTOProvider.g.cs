
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateVonageCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vonage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateVonageCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateVonageCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateVonageCredentialDTOProvider.Vonage => "vonage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateVonageCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "vonage" => UpdateVonageCredentialDTOProvider.Vonage,
                _ => null,
            };
        }
    }
}