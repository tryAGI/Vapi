
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StructuredOutputRunPreviewResponse
    {
        /// <summary>
        /// These are the structured outputs whose conditions gated them, keyed by<br/>
        /// structured output id. Absent when nothing was skipped. An entry here means<br/>
        /// no extraction ran and no cost was incurred for that output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? Skipped { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunPreviewResponse" /> class.
        /// </summary>
        /// <param name="skipped">
        /// These are the structured outputs whose conditions gated them, keyed by<br/>
        /// structured output id. Absent when nothing was skipped. An entry here means<br/>
        /// no extraction ran and no cost was incurred for that output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputRunPreviewResponse(
            global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>? skipped)
        {
            this.Skipped = skipped;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRunPreviewResponse" /> class.
        /// </summary>
        public StructuredOutputRunPreviewResponse()
        {
        }

    }
}