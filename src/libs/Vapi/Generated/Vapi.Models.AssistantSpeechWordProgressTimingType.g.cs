
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Discriminator for cursor-based word progress (e.g. Minimax subtitle data).
    /// </summary>
    public enum AssistantSpeechWordProgressTimingType
    {
        /// <summary>
        /// 
        /// </summary>
        WordProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantSpeechWordProgressTimingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSpeechWordProgressTimingType value)
        {
            return value switch
            {
                AssistantSpeechWordProgressTimingType.WordProgress => "word-progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSpeechWordProgressTimingType? ToEnum(string value)
        {
            return value switch
            {
                "word-progress" => AssistantSpeechWordProgressTimingType.WordProgress,
                _ => null,
            };
        }
    }
}