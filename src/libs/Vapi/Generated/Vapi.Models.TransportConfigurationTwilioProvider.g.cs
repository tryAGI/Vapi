
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum TransportConfigurationTwilioProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransportConfigurationTwilioProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransportConfigurationTwilioProvider value)
        {
            return value switch
            {
                TransportConfigurationTwilioProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransportConfigurationTwilioProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TransportConfigurationTwilioProvider.Twilio,
                _ => null,
            };
        }
    }
}