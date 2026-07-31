
#nullable enable

namespace Vapi
{
    /// <summary>
    /// These are the structured outputs whose conditions gated them, keyed by<br/>
    /// structured output id. Absent when nothing was skipped. An entry here means<br/>
    /// no extraction ran and no cost was incurred for that output.
    /// </summary>
    public sealed partial class StructuredOutputRunPreviewResponseSkipped
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}