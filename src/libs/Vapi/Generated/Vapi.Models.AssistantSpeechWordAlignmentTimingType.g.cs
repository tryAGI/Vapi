
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Discriminator for exact per-word timing (e.g. ElevenLabs alignment).
    /// </summary>
    public enum AssistantSpeechWordAlignmentTimingType
    {
        /// <summary>
        /// 
        /// </summary>
        WordAlignment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantSpeechWordAlignmentTimingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSpeechWordAlignmentTimingType value)
        {
            return value switch
            {
                AssistantSpeechWordAlignmentTimingType.WordAlignment => "word-alignment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSpeechWordAlignmentTimingType? ToEnum(string value)
        {
            return value switch
            {
                "word-alignment" => AssistantSpeechWordAlignmentTimingType.WordAlignment,
                _ => null,
            };
        }
    }
}