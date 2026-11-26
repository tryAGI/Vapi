
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is how the value came through.<br/>
    /// - exact: letter for letter, or as an accepted variant<br/>
    /// - near: a close spelling, at most about one wrong letter in five<br/>
    /// - missed: not found
    /// </summary>
    public enum TranscriptKeyValueResultVerdict
    {
        /// <summary>
        /// letter for letter, or as an accepted variant
        /// </summary>
        Exact,
        /// <summary>
        /// not found
        /// </summary>
        Missed,
        /// <summary>
        /// a close spelling, at most about one wrong letter in five
        /// </summary>
        Near,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptKeyValueResultVerdictExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptKeyValueResultVerdict value)
        {
            return value switch
            {
                TranscriptKeyValueResultVerdict.Exact => "exact",
                TranscriptKeyValueResultVerdict.Missed => "missed",
                TranscriptKeyValueResultVerdict.Near => "near",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptKeyValueResultVerdict? ToEnum(string value)
        {
            return value switch
            {
                "exact" => TranscriptKeyValueResultVerdict.Exact,
                "missed" => TranscriptKeyValueResultVerdict.Missed,
                "near" => TranscriptKeyValueResultVerdict.Near,
                _ => null,
            };
        }
    }
}