
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the message. "assistant-speech" is sent as assistant audio is being played.
    /// </summary>
    public enum ClientMessageAssistantSpeechType
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageAssistantSpeechTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageAssistantSpeechType value)
        {
            return value switch
            {
                ClientMessageAssistantSpeechType.AssistantSpeechStarted => "assistant.speechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageAssistantSpeechType? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => ClientMessageAssistantSpeechType.AssistantSpeechStarted,
                _ => null,
            };
        }
    }
}