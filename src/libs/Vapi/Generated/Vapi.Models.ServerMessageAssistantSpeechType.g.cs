
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the message. "assistant-speech" is sent as assistant audio is being played.
    /// </summary>
    public enum ServerMessageAssistantSpeechType
    {
        /// <summary>
        /// 
        /// </summary>
        AssistantSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageAssistantSpeechTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageAssistantSpeechType value)
        {
            return value switch
            {
                ServerMessageAssistantSpeechType.AssistantSpeechStarted => "assistant.speechStarted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageAssistantSpeechType? ToEnum(string value)
        {
            return value switch
            {
                "assistant.speechStarted" => ServerMessageAssistantSpeechType.AssistantSpeechStarted,
                _ => null,
            };
        }
    }
}