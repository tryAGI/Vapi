
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).<br/>
    /// Default Value: voice
    /// </summary>
    public enum VapiWebCallTransportConversationType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiWebCallTransportConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiWebCallTransportConversationType value)
        {
            return value switch
            {
                VapiWebCallTransportConversationType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiWebCallTransportConversationType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => VapiWebCallTransportConversationType.Voice,
                _ => null,
            };
        }
    }
}