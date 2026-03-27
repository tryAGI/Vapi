
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpToolMetadata
    {
        /// <summary>
        /// This is the protocol used for MCP communication. Defaults to Streamable HTTP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocol")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.McpToolMetadataProtocolJsonConverter))]
        public global::Vapi.McpToolMetadataProtocol? Protocol { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMetadata" /> class.
        /// </summary>
        /// <param name="protocol">
        /// This is the protocol used for MCP communication. Defaults to Streamable HTTP.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolMetadata(
            global::Vapi.McpToolMetadataProtocol? protocol)
        {
            this.Protocol = protocol;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolMetadata" /> class.
        /// </summary>
        public McpToolMetadata()
        {
        }
    }
}