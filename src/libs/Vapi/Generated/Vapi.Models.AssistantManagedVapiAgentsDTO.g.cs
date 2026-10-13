
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantManagedVapiAgentsDTO
    {
        /// <summary>
        /// The Vapi Agents agent that manages the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AgentId { get; set; }

        /// <summary>
        /// The agent's page in Vapi Agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentUrl { get; set; }

        /// <summary>
        /// The Vapi Agents MCP server, where an AI client makes the change instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantManagedVapiAgentsDTO" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The Vapi Agents agent that manages the assistant.
        /// </param>
        /// <param name="agentUrl">
        /// The agent's page in Vapi Agents.
        /// </param>
        /// <param name="mcpUrl">
        /// The Vapi Agents MCP server, where an AI client makes the change instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantManagedVapiAgentsDTO(
            global::System.Guid agentId,
            string agentUrl,
            string mcpUrl)
        {
            this.AgentId = agentId;
            this.AgentUrl = agentUrl ?? throw new global::System.ArgumentNullException(nameof(agentUrl));
            this.McpUrl = mcpUrl ?? throw new global::System.ArgumentNullException(nameof(mcpUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantManagedVapiAgentsDTO" /> class.
        /// </summary>
        public AssistantManagedVapiAgentsDTO()
        {
        }

    }
}