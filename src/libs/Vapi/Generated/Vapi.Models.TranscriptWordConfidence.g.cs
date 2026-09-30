
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptWordConfidence
    {
        /// <summary>
        /// The word as the transcriber recognised it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Word { get; set; }

        /// <summary>
        /// Offset at which the word begins, measured from the start of the<br/>
        /// transcriber stream (ElevenLabs, which transcribes each utterance as its<br/>
        /// own request, measures from the start of that utterance's audio). The unit<br/>
        /// is transcriber-specific today: seconds for Deepgram, Soniox, Gladia and<br/>
        /// ElevenLabs realtime (`scribe_v2_realtime`); milliseconds for AssemblyAI,<br/>
        /// ElevenLabs HTTP Scribe and Google. Transcribers without per-word timing<br/>
        /// emit a placeholder, typically `0`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// Offset at which the word ends, with the same origin and unit as `start`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// The transcriber's confidence for this word, in [0, 1]. Transcribers that<br/>
        /// report no per-word score, or whose stream does not map one (Cartesia,<br/>
        /// ElevenLabs HTTP Scribe, Google, Talkscriber and custom transcribers), emit<br/>
        /// `1` for every word; that placeholder is not a measurement. ElevenLabs<br/>
        /// realtime passes through its token log-probability, which is not a [0, 1]<br/>
        /// confidence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The word with punctuation and casing applied, when the transcriber<br/>
        /// reports a punctuated form. The snake_case name deliberately mirrors the<br/>
        /// transcriber wire spelling already stored on every existing message;<br/>
        /// renaming it would break stored data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("punctuated_word")]
        public string? PunctuatedWord { get; set; }

        /// <summary>
        /// The language the transcriber detected for this word, when it reports one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The diarized speaker index this word was attributed to, when the<br/>
        /// transcriber reports one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public double? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWordConfidence" /> class.
        /// </summary>
        /// <param name="word">
        /// The word as the transcriber recognised it.
        /// </param>
        /// <param name="start">
        /// Offset at which the word begins, measured from the start of the<br/>
        /// transcriber stream (ElevenLabs, which transcribes each utterance as its<br/>
        /// own request, measures from the start of that utterance's audio). The unit<br/>
        /// is transcriber-specific today: seconds for Deepgram, Soniox, Gladia and<br/>
        /// ElevenLabs realtime (`scribe_v2_realtime`); milliseconds for AssemblyAI,<br/>
        /// ElevenLabs HTTP Scribe and Google. Transcribers without per-word timing<br/>
        /// emit a placeholder, typically `0`.
        /// </param>
        /// <param name="end">
        /// Offset at which the word ends, with the same origin and unit as `start`.
        /// </param>
        /// <param name="confidence">
        /// The transcriber's confidence for this word, in [0, 1]. Transcribers that<br/>
        /// report no per-word score, or whose stream does not map one (Cartesia,<br/>
        /// ElevenLabs HTTP Scribe, Google, Talkscriber and custom transcribers), emit<br/>
        /// `1` for every word; that placeholder is not a measurement. ElevenLabs<br/>
        /// realtime passes through its token log-probability, which is not a [0, 1]<br/>
        /// confidence.
        /// </param>
        /// <param name="punctuatedWord">
        /// The word with punctuation and casing applied, when the transcriber<br/>
        /// reports a punctuated form. The snake_case name deliberately mirrors the<br/>
        /// transcriber wire spelling already stored on every existing message;<br/>
        /// renaming it would break stored data.
        /// </param>
        /// <param name="language">
        /// The language the transcriber detected for this word, when it reports one.
        /// </param>
        /// <param name="speaker">
        /// The diarized speaker index this word was attributed to, when the<br/>
        /// transcriber reports one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptWordConfidence(
            string word,
            double start,
            double end,
            double confidence,
            string? punctuatedWord,
            string? language,
            double? speaker)
        {
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
            this.Start = start;
            this.End = end;
            this.Confidence = confidence;
            this.PunctuatedWord = punctuatedWord;
            this.Language = language;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptWordConfidence" /> class.
        /// </summary>
        public TranscriptWordConfidence()
        {
        }

    }
}