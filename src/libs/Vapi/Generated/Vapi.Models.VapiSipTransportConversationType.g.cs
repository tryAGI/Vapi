
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).<br/>
    /// Default Value: voice
    /// </summary>
    public enum VapiSipTransportConversationType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiSipTransportConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiSipTransportConversationType value)
        {
            return value switch
            {
                VapiSipTransportConversationType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiSipTransportConversationType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => VapiSipTransportConversationType.Voice,
                _ => null,
            };
        }
    }
}