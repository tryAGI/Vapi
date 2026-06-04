
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vapi websocket transport provider
    /// </summary>
    public enum VapiWebsocketTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        VapiWebsocket,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiWebsocketTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiWebsocketTransportProvider value)
        {
            return value switch
            {
                VapiWebsocketTransportProvider.VapiWebsocket => "vapi.websocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiWebsocketTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi.websocket" => VapiWebsocketTransportProvider.VapiWebsocket,
                _ => null,
            };
        }
    }
}