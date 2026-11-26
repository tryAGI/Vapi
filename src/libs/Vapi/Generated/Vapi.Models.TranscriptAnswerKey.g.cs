
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptAnswerKey
    {
        /// <summary>
        /// This is the verbatim transcript of everything the recording contains. A<br/>
        /// mixed recording of both parties needs both parties' words, in order. At<br/>
        /// most 30,000 words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// These are values the transcript must carry, each scored exact, near or<br/>
        /// missed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyValues")]
        public global::System.Collections.Generic.IList<global::Vapi.TranscriptKeyValue>? KeyValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptAnswerKey" /> class.
        /// </summary>
        /// <param name="transcript">
        /// This is the verbatim transcript of everything the recording contains. A<br/>
        /// mixed recording of both parties needs both parties' words, in order. At<br/>
        /// most 30,000 words.
        /// </param>
        /// <param name="keyValues">
        /// These are values the transcript must carry, each scored exact, near or<br/>
        /// missed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptAnswerKey(
            string transcript,
            global::System.Collections.Generic.IList<global::Vapi.TranscriptKeyValue>? keyValues)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.KeyValues = keyValues;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptAnswerKey" /> class.
        /// </summary>
        public TranscriptAnswerKey()
        {
        }

    }
}