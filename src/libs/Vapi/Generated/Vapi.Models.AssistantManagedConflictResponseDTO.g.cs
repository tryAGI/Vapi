
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantManagedConflictResponseDTO
    {
        /// <summary>
        /// Vapi for CX manages the assistant. The lock refuses writes to the assistant itself (update, replace, delete, restore, version delete, traffic splits) and to outcomes, monitors and structured outputs that link or unlink it. It doesn't cover what changes a call without writing the assistant: call-level assistantOverrides or assistantVersion, squad member pins and overrides, which phone number points at it, edits to the tools or knowledge bases it references, or Vapi's own model-retirement sweep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AssistantManagedConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.AssistantManagedConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Why the write was rejected and how to make the change in Vapi for CX instead: the agent link, the Vapi for CX MCP URL with the steps to connect it, and which of its tools to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vapiAgents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.AssistantManagedVapiAgentsDTO VapiAgents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantManagedConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Why the write was rejected and how to make the change in Vapi for CX instead: the agent link, the Vapi for CX MCP URL with the steps to connect it, and which of its tools to call.
        /// </param>
        /// <param name="vapiAgents"></param>
        /// <param name="error">
        /// Vapi for CX manages the assistant. The lock refuses writes to the assistant itself (update, replace, delete, restore, version delete, traffic splits) and to outcomes, monitors and structured outputs that link or unlink it. It doesn't cover what changes a call without writing the assistant: call-level assistantOverrides or assistantVersion, squad member pins and overrides, which phone number points at it, edits to the tools or knowledge bases it references, or Vapi's own model-retirement sweep.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantManagedConflictResponseDTO(
            string message,
            global::Vapi.AssistantManagedVapiAgentsDTO vapiAgents,
            global::Vapi.AssistantManagedConflictResponseDTOError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.VapiAgents = vapiAgents ?? throw new global::System.ArgumentNullException(nameof(vapiAgents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantManagedConflictResponseDTO" /> class.
        /// </summary>
        public AssistantManagedConflictResponseDTO()
        {
        }

    }
}