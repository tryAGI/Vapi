
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is to bring your own phone numbers from your own SIP trunks or Carriers.
    /// </summary>
    public enum UpdateByoPhoneNumberDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        ByoPhoneNumber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateByoPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateByoPhoneNumberDTOProvider value)
        {
            return value switch
            {
                UpdateByoPhoneNumberDTOProvider.ByoPhoneNumber => "byo-phone-number",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateByoPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "byo-phone-number" => UpdateByoPhoneNumberDTOProvider.ByoPhoneNumber,
                _ => null,
            };
        }
    }
}