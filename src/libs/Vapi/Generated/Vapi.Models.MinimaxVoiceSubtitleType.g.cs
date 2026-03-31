
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
    public enum MinimaxVoiceSubtitleType
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
    public static class MinimaxVoiceSubtitleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinimaxVoiceSubtitleType value)
        {
            return value switch
            {
                MinimaxVoiceSubtitleType.Sentence => "sentence",
                MinimaxVoiceSubtitleType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinimaxVoiceSubtitleType? ToEnum(string value)
        {
            return value switch
            {
                "sentence" => MinimaxVoiceSubtitleType.Sentence,
                "word" => MinimaxVoiceSubtitleType.Word,
                _ => null,
            };
        }
    }
}