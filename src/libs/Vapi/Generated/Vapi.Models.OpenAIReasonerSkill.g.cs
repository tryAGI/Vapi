
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAIReasonerSkill
    {
        /// <summary>
        /// Unique name within this assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Explain when the reasoner should load this skill. Always visible in its catalog.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Full skill instructions, loaded only while this skill is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Tools available only after loading this skill. Can be combined with toolIds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>? Tools { get; set; }

        /// <summary>
        /// Existing organization-owned tools available only after loading this skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ToolIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasonerSkill" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique name within this assistant.
        /// </param>
        /// <param name="description">
        /// Explain when the reasoner should load this skill. Always visible in its catalog.
        /// </param>
        /// <param name="content">
        /// Full skill instructions, loaded only while this skill is active.
        /// </param>
        /// <param name="tools">
        /// Tools available only after loading this skill. Can be combined with toolIds.
        /// </param>
        /// <param name="toolIds">
        /// Existing organization-owned tools available only after loading this skill.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAIReasonerSkill(
            string name,
            string description,
            string content,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>? tools,
            global::System.Collections.Generic.IList<global::System.Guid>? toolIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Tools = tools;
            this.ToolIds = toolIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIReasonerSkill" /> class.
        /// </summary>
        public OpenAIReasonerSkill()
        {
        }

    }
}