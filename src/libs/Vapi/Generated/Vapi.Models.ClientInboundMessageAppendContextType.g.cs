
#nullable enable

namespace Vapi
{
    /// <summary>
    /// HTTP-only: append context to a GPT-Live call via `call.monitor.controlUrl`.<br/>
    /// Not supported on WebSocket text frames or SDK data channels.
    /// </summary>
    public enum ClientInboundMessageAppendContextType
    {
        /// <summary>
        ///
        /// </summary>
        AppendContext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageAppendContextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageAppendContextType value)
        {
            return value switch
            {
                ClientInboundMessageAppendContextType.AppendContext => "append-context",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageAppendContextType? ToEnum(string value)
        {
            return value switch
            {
                "append-context" => ClientInboundMessageAppendContextType.AppendContext,
                _ => null,
            };
        }
    }
}