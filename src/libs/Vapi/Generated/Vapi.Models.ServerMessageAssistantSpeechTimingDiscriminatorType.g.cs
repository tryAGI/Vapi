
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ServerMessageAssistantSpeechTimingDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        WordAlignment,
        /// <summary>
        /// 
        /// </summary>
        WordProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageAssistantSpeechTimingDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageAssistantSpeechTimingDiscriminatorType value)
        {
            return value switch
            {
                ServerMessageAssistantSpeechTimingDiscriminatorType.WordAlignment => "word-alignment",
                ServerMessageAssistantSpeechTimingDiscriminatorType.WordProgress => "word-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageAssistantSpeechTimingDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "word-alignment" => ServerMessageAssistantSpeechTimingDiscriminatorType.WordAlignment,
                "word-progress" => ServerMessageAssistantSpeechTimingDiscriminatorType.WordProgress,
                _ => null,
            };
        }
    }
}