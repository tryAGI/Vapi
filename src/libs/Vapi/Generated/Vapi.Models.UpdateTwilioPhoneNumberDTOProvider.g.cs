
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is to use numbers bought on Twilio.
    /// </summary>
    public enum UpdateTwilioPhoneNumberDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTwilioPhoneNumberDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTwilioPhoneNumberDTOProvider value)
        {
            return value switch
            {
                UpdateTwilioPhoneNumberDTOProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTwilioPhoneNumberDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => UpdateTwilioPhoneNumberDTOProvider.Twilio,
                _ => null,
            };
        }
    }
}