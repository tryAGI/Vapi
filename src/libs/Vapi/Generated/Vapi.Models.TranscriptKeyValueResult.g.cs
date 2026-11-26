
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptKeyValueResult
    {
        /// <summary>
        /// This is the key value's position in the answer key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Index { get; set; }

        /// <summary>
        /// This is the key value as the answer key wrote it. Absent for organizations<br/>
        /// with HIPAA, PCI or zero data retention enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// This is how the value came through.<br/>
        /// - exact: letter for letter, or as an accepted variant<br/>
        /// - near: a close spelling, at most about one wrong letter in five<br/>
        /// - missed: not found
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verdict")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TranscriptKeyValueResultVerdictJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TranscriptKeyValueResultVerdict Verdict { get; set; }

        /// <summary>
        /// This is whether this key value had to come through exactly for the<br/>
        /// simulation to pass. Kept for every organization, since it carries no answer-key text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptKeyValueResult" /> class.
        /// </summary>
        /// <param name="index">
        /// This is the key value's position in the answer key.
        /// </param>
        /// <param name="verdict">
        /// This is how the value came through.<br/>
        /// - exact: letter for letter, or as an accepted variant<br/>
        /// - near: a close spelling, at most about one wrong letter in five<br/>
        /// - missed: not found
        /// </param>
        /// <param name="required">
        /// This is whether this key value had to come through exactly for the<br/>
        /// simulation to pass. Kept for every organization, since it carries no answer-key text.
        /// </param>
        /// <param name="value">
        /// This is the key value as the answer key wrote it. Absent for organizations<br/>
        /// with HIPAA, PCI or zero data retention enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptKeyValueResult(
            double index,
            global::Vapi.TranscriptKeyValueResultVerdict verdict,
            bool required,
            string? value)
        {
            this.Index = index;
            this.Value = value;
            this.Verdict = verdict;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptKeyValueResult" /> class.
        /// </summary>
        public TranscriptKeyValueResult()
        {
        }

    }
}