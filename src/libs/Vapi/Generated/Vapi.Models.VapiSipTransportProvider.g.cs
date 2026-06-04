
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vapi SIP transport provider
    /// </summary>
    public enum VapiSipTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        VapiSip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiSipTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiSipTransportProvider value)
        {
            return value switch
            {
                VapiSipTransportProvider.VapiSip => "vapi.sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiSipTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi.sip" => VapiSipTransportProvider.VapiSip,
                _ => null,
            };
        }
    }
}