
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Provider-specific metadata. Polymorphic across tool variants with no shared<br/>
    /// discriminator, so it is validated as a plain object (mirrors how<br/>
    /// `ToolCallResult.metadata` is typed).
    /// </summary>
    public sealed partial class CreateToolDraftDTOMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}