
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Controls the granularity of subtitle/timing data returned by Minimax<br/>
    /// during synthesis. Set to 'word' to receive per-word timestamps in<br/>
    /// assistant.speechStarted events for karaoke-style caption rendering.<br/>
    /// @default "sentence"<br/>
    /// Default Value: sentence
    /// </summary>
    public enum FallbackMinimaxVoiceSubtitleType
    {
        /// <summary>
        /// 
        /// </summary>
        Sentence,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackMinimaxVoiceSubtitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackMinimaxVoiceSubtitleType value)
        {
            return value switch
            {
                FallbackMinimaxVoiceSubtitleType.Sentence => "sentence",
                FallbackMinimaxVoiceSubtitleType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackMinimaxVoiceSubtitleType? ToEnum(string value)
        {
            return value switch
            {
                "sentence" => FallbackMinimaxVoiceSubtitleType.Sentence,
                "word" => FallbackMinimaxVoiceSubtitleType.Word,
                _ => null,
            };
        }
    }
}