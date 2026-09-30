
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserMessageMetadata
    {
        /// <summary>
        /// Per-word confidence scores from the transcriber. After consecutive<br/>
        /// transcript fragments are merged into one message the list covers the whole<br/>
        /// merged message, or is absent when any fragment lacked word scores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordLevelConfidence")]
        public global::System.Collections.Generic.IList<global::Vapi.TranscriptWordConfidence>? WordLevelConfidence { get; set; }

        /// <summary>
        /// Marks a message injected out-of-band rather than produced by the<br/>
        /// transcriber (e.g. an inbound SMS relayed into the conversation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The channel or address the out-of-band message arrived from (e.g. the<br/>
        /// sender's phone number for an SMS).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageMetadata" /> class.
        /// </summary>
        /// <param name="wordLevelConfidence">
        /// Per-word confidence scores from the transcriber. After consecutive<br/>
        /// transcript fragments are merged into one message the list covers the whole<br/>
        /// merged message, or is absent when any fragment lacked word scores.
        /// </param>
        /// <param name="type">
        /// Marks a message injected out-of-band rather than produced by the<br/>
        /// transcriber (e.g. an inbound SMS relayed into the conversation).
        /// </param>
        /// <param name="source">
        /// The channel or address the out-of-band message arrived from (e.g. the<br/>
        /// sender's phone number for an SMS).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMessageMetadata(
            global::System.Collections.Generic.IList<global::Vapi.TranscriptWordConfidence>? wordLevelConfidence,
            string? type,
            string? source)
        {
            this.WordLevelConfidence = wordLevelConfidence;
            this.Type = type;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessageMetadata" /> class.
        /// </summary>
        public UserMessageMetadata()
        {
        }

    }
}