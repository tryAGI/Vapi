
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantSpeechWordAlignmentTiming
    {
        /// <summary>
        /// Discriminator for exact per-word timing (e.g. ElevenLabs alignment).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AssistantSpeechWordAlignmentTimingTypeJsonConverter))]
        public global::Vapi.AssistantSpeechWordAlignmentTimingType Type { get; set; }

        /// <summary>
        /// The individual words in this audio segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Words { get; set; }

        /// <summary>
        /// Start time in milliseconds for each word (parallel to `words`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordsStartTimesMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> WordsStartTimesMs { get; set; }

        /// <summary>
        /// End time in milliseconds for each word (parallel to `words`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordsEndTimesMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> WordsEndTimesMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordAlignmentTiming" /> class.
        /// </summary>
        /// <param name="words">
        /// The individual words in this audio segment.
        /// </param>
        /// <param name="wordsStartTimesMs">
        /// Start time in milliseconds for each word (parallel to `words`).
        /// </param>
        /// <param name="wordsEndTimesMs">
        /// End time in milliseconds for each word (parallel to `words`).
        /// </param>
        /// <param name="type">
        /// Discriminator for exact per-word timing (e.g. ElevenLabs alignment).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantSpeechWordAlignmentTiming(
            global::System.Collections.Generic.IList<string> words,
            global::System.Collections.Generic.IList<double> wordsStartTimesMs,
            global::System.Collections.Generic.IList<double> wordsEndTimesMs,
            global::Vapi.AssistantSpeechWordAlignmentTimingType type)
        {
            this.Type = type;
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.WordsStartTimesMs = wordsStartTimesMs ?? throw new global::System.ArgumentNullException(nameof(wordsStartTimesMs));
            this.WordsEndTimesMs = wordsEndTimesMs ?? throw new global::System.ArgumentNullException(nameof(wordsEndTimesMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantSpeechWordAlignmentTiming" /> class.
        /// </summary>
        public AssistantSpeechWordAlignmentTiming()
        {
        }
    }
}