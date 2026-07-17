
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRef
    {
        /// <summary>
        /// This is the unique identifier of the tool whose version is being pinned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ToolId { get; set; }

        /// <summary>
        /// Public version label of the tool, e.g. "v3"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRef" /> class.
        /// </summary>
        /// <param name="toolId">
        /// This is the unique identifier of the tool whose version is being pinned.
        /// </param>
        /// <param name="version">
        /// Public version label of the tool, e.g. "v3"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRef(
            global::System.Guid toolId,
            string version)
        {
            this.ToolId = toolId;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRef" /> class.
        /// </summary>
        public ToolRef()
        {
        }

    }
}