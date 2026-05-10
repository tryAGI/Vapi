
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ClientMessageAssistantSpeechTimingDiscriminatorType
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
    public static class ClientMessageAssistantSpeechTimingDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageAssistantSpeechTimingDiscriminatorType value)
        {
            return value switch
            {
                ClientMessageAssistantSpeechTimingDiscriminatorType.WordAlignment => "word-alignment",
                ClientMessageAssistantSpeechTimingDiscriminatorType.WordProgress => "word-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageAssistantSpeechTimingDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "word-alignment" => ClientMessageAssistantSpeechTimingDiscriminatorType.WordAlignment,
                "word-progress" => ClientMessageAssistantSpeechTimingDiscriminatorType.WordProgress,
                _ => null,
            };
        }
    }
}