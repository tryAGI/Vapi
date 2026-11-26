
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptEvaluationResult
    {
        /// <summary>
        /// This is the word error rate: (substitutions + deletions + insertions)<br/>
        /// divided by the answer key's word count. Null when the answer key has no<br/>
        /// words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wer")]
        public double? Wer { get; set; }

        /// <summary>
        /// This is the number of answer-key words transcribed correctly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Hits { get; set; }

        /// <summary>
        /// This is the number of answer-key words transcribed as a different word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("substitutions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Substitutions { get; set; }

        /// <summary>
        /// This is the number of answer-key words missing from the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Deletions { get; set; }

        /// <summary>
        /// This is the number of transcript words with no answer-key word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("insertions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Insertions { get; set; }

        /// <summary>
        /// This is the number of words in the normalized answer key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceWordCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReferenceWordCount { get; set; }

        /// <summary>
        /// This is the number of words in the normalized transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hypothesisWordCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HypothesisWordCount { get; set; }

        /// <summary>
        /// This is each key value's verdict, in answer-key order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TranscriptKeyValueResult> KeyValues { get; set; }

        /// <summary>
        /// This is each of the scenario's metric evaluations, in the scenario's order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TranscriptMetricEvaluationResult> Evaluations { get; set; }

        /// <summary>
        /// This is false when a required evaluation failed or a required key value<br/>
        /// did not come through exactly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptEvaluationResult" /> class.
        /// </summary>
        /// <param name="hits">
        /// This is the number of answer-key words transcribed correctly.
        /// </param>
        /// <param name="substitutions">
        /// This is the number of answer-key words transcribed as a different word.
        /// </param>
        /// <param name="deletions">
        /// This is the number of answer-key words missing from the transcript.
        /// </param>
        /// <param name="insertions">
        /// This is the number of transcript words with no answer-key word.
        /// </param>
        /// <param name="referenceWordCount">
        /// This is the number of words in the normalized answer key.
        /// </param>
        /// <param name="hypothesisWordCount">
        /// This is the number of words in the normalized transcript.
        /// </param>
        /// <param name="keyValues">
        /// This is each key value's verdict, in answer-key order.
        /// </param>
        /// <param name="evaluations">
        /// This is each of the scenario's metric evaluations, in the scenario's order.
        /// </param>
        /// <param name="passed">
        /// This is false when a required evaluation failed or a required key value<br/>
        /// did not come through exactly.
        /// </param>
        /// <param name="wer">
        /// This is the word error rate: (substitutions + deletions + insertions)<br/>
        /// divided by the answer key's word count. Null when the answer key has no<br/>
        /// words.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptEvaluationResult(
            double hits,
            double substitutions,
            double deletions,
            double insertions,
            double referenceWordCount,
            double hypothesisWordCount,
            global::System.Collections.Generic.IList<global::Vapi.TranscriptKeyValueResult> keyValues,
            global::System.Collections.Generic.IList<global::Vapi.TranscriptMetricEvaluationResult> evaluations,
            bool passed,
            double? wer)
        {
            this.Wer = wer;
            this.Hits = hits;
            this.Substitutions = substitutions;
            this.Deletions = deletions;
            this.Insertions = insertions;
            this.ReferenceWordCount = referenceWordCount;
            this.HypothesisWordCount = hypothesisWordCount;
            this.KeyValues = keyValues ?? throw new global::System.ArgumentNullException(nameof(keyValues));
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.Passed = passed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptEvaluationResult" /> class.
        /// </summary>
        public TranscriptEvaluationResult()
        {
        }

    }
}