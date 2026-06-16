
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Twilio transport provider
    /// </summary>
    public enum TwilioTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioTransportProvider value)
        {
            return value switch
            {
                TwilioTransportProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TwilioTransportProvider.Twilio,
                _ => null,
            };
        }
    }
}