
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantSpeechWordProgressTiming
    {
        /// <summary>
        /// Discriminator for cursor-based word progress (e.g. Minimax subtitle data).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AssistantSpeechWordProgressTimingTypeJsonConverter))]
        public global::Vapi.AssistantSpeechWordProgressTimingType Type { get; set; }

        /// <summary>
        /// Number of words spoken so far in this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordsSpoken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WordsSpoken { get; set; }

        /// <summary>
        /// Total number of words sent to the TTS provider for this turn.<br/>
        /// **Important**: this value grows across events within a single turn because<br/>
        /// Minimax synthesizes audio incrementally as the LLM streams tokens. Treat<br/>
        /// it as "best known total so far" — it will stabilize once synthesis is<br/>
        /// complete.<br/>
        /// A value of `0` is a valid sentinel meaning "not yet known". This can occur<br/>
        /// on the very first `assistant-speech` event of a turn if audio begins<br/>
        /// playing before the TTS provider has confirmed word-count data. Clients<br/>
        /// **must** guard against divide-by-zero when computing a progress fraction:<br/>
        /// ```ts<br/>
        /// const pct = totalWords &gt; 0 ? wordsSpoken / totalWords : 0;<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalWords { get; set; }

        /// <summary>
        /// The text of the latest spoken segment (sentence or clause). Use this<br/>
        /// for caption display — it corresponds to the chunk just confirmed by<br/>
        /// the TTS provider, unlike `text` on the parent message which carries<br/>
        /// the full turn text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        public string? Segment { get; set; }

        /// <summary>
        /// Audio duration in milliseconds for the latest spoken segment. Pair<br/>
        /// with `segment` to animate karaoke-style word reveals — divide the<br/>
        /// segment text across this duration for approximate per-word timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentDurationMs")]
        public double? SegmentDurationMs { get; set; }

        /// <summary>
        /// Per-word timestamps for the latest spoken segment. Available when the<br/>
        /// TTS provider supports word-level timing (e.g. Minimax with<br/>
        /// subtitle_type: "word"). Syllables from the provider are aggregated<br/>
        /// into whole words with start/end times relative to the segment start.<br/>
        /// Use these for precise karaoke-style highlighting instead of<br/>
        /// interpolating from segmentDurationMs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordProgressTiming" /> class.
        /// </summary>
        /// <param name="wordsSpoken">
        /// Number of words spoken so far in this turn.
        /// </param>
        /// <param name="totalWords">
        /// Total number of words sent to the TTS provider for this turn.<br/>
        /// **Important**: this value grows across events within a single turn because<br/>
        /// Minimax synthesizes audio incrementally as the LLM streams tokens. Treat<br/>
        /// it as "best known total so far" — it will stabilize once synthesis is<br/>
        /// complete.<br/>
        /// A value of `0` is a valid sentinel meaning "not yet known". This can occur<br/>
        /// on the very first `assistant-speech` event of a turn if audio begins<br/>
        /// playing before the TTS provider has confirmed word-count data. Clients<br/>
        /// **must** guard against divide-by-zero when computing a progress fraction:<br/>
        /// ```ts<br/>
        /// const pct = totalWords &gt; 0 ? wordsSpoken / totalWords : 0;<br/>
        /// ```
        /// </param>
        /// <param name="type">
        /// Discriminator for cursor-based word progress (e.g. Minimax subtitle data).
        /// </param>
        /// <param name="segment">
        /// The text of the latest spoken segment (sentence or clause). Use this<br/>
        /// for caption display — it corresponds to the chunk just confirmed by<br/>
        /// the TTS provider, unlike `text` on the parent message which carries<br/>
        /// the full turn text.
        /// </param>
        /// <param name="segmentDurationMs">
        /// Audio duration in milliseconds for the latest spoken segment. Pair<br/>
        /// with `segment` to animate karaoke-style word reveals — divide the<br/>
        /// segment text across this duration for approximate per-word timing.
        /// </param>
        /// <param name="words">
        /// Per-word timestamps for the latest spoken segment. Available when the<br/>
        /// TTS provider supports word-level timing (e.g. Minimax with<br/>
        /// subtitle_type: "word"). Syllables from the provider are aggregated<br/>
        /// into whole words with start/end times relative to the segment start.<br/>
        /// Use these for precise karaoke-style highlighting instead of<br/>
        /// interpolating from segmentDurationMs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantSpeechWordProgressTiming(
            double wordsSpoken,
            double totalWords,
            global::Vapi.AssistantSpeechWordProgressTimingType type,
            string? segment,
            double? segmentDurationMs,
            global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>? words)
        {
            this.Type = type;
            this.WordsSpoken = wordsSpoken;
            this.TotalWords = totalWords;
            this.Segment = segment;
            this.SegmentDurationMs = segmentDurationMs;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordProgressTiming" /> class.
        /// </summary>
        public AssistantSpeechWordProgressTiming()
        {
        }
    }
}