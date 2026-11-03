
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Reson8Transcriber
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.Reson8TranscriberProviderJsonConverter))]
        public global::Vapi.Reson8TranscriberProvider Provider { get; set; }

        /// <summary>
        /// The Reson8 speech-to-text endpoint to use. `turns` is Reson8's turn-detection endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.Reson8TranscriberModelJsonConverter))]
        public global::Vapi.Reson8TranscriberModel? Model { get; set; }

        /// <summary>
        /// Language for transcription (e.g. `nl`), or a comma-separated candidate list such as `nl,en` which constrains auto-detection. When omitted, Reson8 auto-detects the language per utterance. Supported: de, en, es, fr, fy, it, nl, pl, pt, sv.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Domain-specific terms to boost recognition (brand names, product codes, jargon). Sent to Reson8 as the `phrases` parameter. Max 250 phrases.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyterms")]
        public global::System.Collections.Generic.IList<string>? Keyterms { get; set; }

        /// <summary>
        /// A stored Reson8 phrase collection (custom model) id, managed via the Reson8 API or console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customModelId")]
        public string? CustomModelId { get; set; }

        /// <summary>
        /// Threshold (0-1) at which Reson8 emits an eager turn-end candidate. Provider default 0.5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerTurnProbability")]
        public double? EagerTurnProbability { get; set; }

        /// <summary>
        /// Threshold (0-1) at which Reson8 confirms the end of a turn. Provider default 0.92.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finalTurnProbability")]
        public double? FinalTurnProbability { get; set; }

        /// <summary>
        /// How Reson8 renders filler words in transcripts. Provider default `natural`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fillerMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.Reson8TranscriberFillerModeJsonConverter))]
        public global::Vapi.Reson8TranscriberFillerMode? FillerMode { get; set; }

        /// <summary>
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackPlan")]
        public global::Vapi.FallbackTranscriberPlan? FallbackPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Reson8Transcriber" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="model">
        /// The Reson8 speech-to-text endpoint to use. `turns` is Reson8's turn-detection endpoint.
        /// </param>
        /// <param name="language">
        /// Language for transcription (e.g. `nl`), or a comma-separated candidate list such as `nl,en` which constrains auto-detection. When omitted, Reson8 auto-detects the language per utterance. Supported: de, en, es, fr, fy, it, nl, pl, pt, sv.
        /// </param>
        /// <param name="keyterms">
        /// Domain-specific terms to boost recognition (brand names, product codes, jargon). Sent to Reson8 as the `phrases` parameter. Max 250 phrases.
        /// </param>
        /// <param name="customModelId">
        /// A stored Reson8 phrase collection (custom model) id, managed via the Reson8 API or console.
        /// </param>
        /// <param name="eagerTurnProbability">
        /// Threshold (0-1) at which Reson8 emits an eager turn-end candidate. Provider default 0.5.
        /// </param>
        /// <param name="finalTurnProbability">
        /// Threshold (0-1) at which Reson8 confirms the end of a turn. Provider default 0.92.
        /// </param>
        /// <param name="fillerMode">
        /// How Reson8 renders filler words in transcripts. Provider default `natural`.
        /// </param>
        /// <param name="fallbackPlan">
        /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Reson8Transcriber(
            global::Vapi.Reson8TranscriberProvider provider,
            global::Vapi.Reson8TranscriberModel? model,
            string? language,
            global::System.Collections.Generic.IList<string>? keyterms,
            string? customModelId,
            double? eagerTurnProbability,
            double? finalTurnProbability,
            global::Vapi.Reson8TranscriberFillerMode? fillerMode,
            global::Vapi.FallbackTranscriberPlan? fallbackPlan)
        {
            this.Provider = provider;
            this.Model = model;
            this.Language = language;
            this.Keyterms = keyterms;
            this.CustomModelId = customModelId;
            this.EagerTurnProbability = eagerTurnProbability;
            this.FinalTurnProbability = finalTurnProbability;
            this.FillerMode = fillerMode;
            this.FallbackPlan = fallbackPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Reson8Transcriber" /> class.
        /// </summary>
        public Reson8Transcriber()
        {
        }

    }
}