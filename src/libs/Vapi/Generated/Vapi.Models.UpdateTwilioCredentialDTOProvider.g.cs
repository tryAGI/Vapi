
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateTwilioCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTwilioCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTwilioCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateTwilioCredentialDTOProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTwilioCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => UpdateTwilioCredentialDTOProvider.Twilio,
                _ => null,
            };
        }
    }
}