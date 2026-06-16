
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Telnyx transport provider
    /// </summary>
    public enum TelnyxTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Telnyx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelnyxTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelnyxTransportProvider value)
        {
            return value switch
            {
                TelnyxTransportProvider.Telnyx => "telnyx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelnyxTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "telnyx" => TelnyxTransportProvider.Telnyx,
                _ => null,
            };
        }
    }
}