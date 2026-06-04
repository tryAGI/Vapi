
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).<br/>
    /// Default Value: voice
    /// </summary>
    public enum VapiWebsocketTransportConversationType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiWebsocketTransportConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiWebsocketTransportConversationType value)
        {
            return value switch
            {
                VapiWebsocketTransportConversationType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiWebsocketTransportConversationType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => VapiWebsocketTransportConversationType.Voice,
                _ => null,
            };
        }
    }
}