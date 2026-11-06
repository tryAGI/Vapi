
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Structured editor input. Supplied PATCH authoring replaces the complete object; advanced text writes clear it to null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authoring")]
        public global::Vapi.GuardrailAuthoring? Authoring { get; set; }

        /// <summary>
        /// Evaluated instructions, generated from authoring or supplied in advanced mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailRuleSensitivityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GuardrailRuleSensitivity Sensitivity { get; set; }

        /// <summary>
        /// Supplied PATCH actions replace the complete variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction> Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRule" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="orgId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="name"></param>
        /// <param name="sensitivity">
        /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
        /// </param>
        /// <param name="action">
        /// Supplied PATCH actions replace the complete variant.
        /// </param>
        /// <param name="authoring">
        /// Structured editor input. Supplied PATCH authoring replaces the complete object; advanced text writes clear it to null.
        /// </param>
        /// <param name="instructions">
        /// Evaluated instructions, generated from authoring or supplied in advanced mode.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailRule(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            global::Vapi.GuardrailRuleSensitivity sensitivity,
            global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction> action,
            global::Vapi.GuardrailAuthoring? authoring,
            string? instructions)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Authoring = authoring;
            this.Instructions = instructions;
            this.Sensitivity = sensitivity;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRule" /> class.
        /// </summary>
        public GuardrailRule()
        {
        }

    }
}