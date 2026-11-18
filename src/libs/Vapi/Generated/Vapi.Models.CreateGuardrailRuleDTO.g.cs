
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGuardrailRuleDTO
    {
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
        /// Advanced text input. Do not supply it together with structured authoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sensitivity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateGuardrailRuleDTOSensitivityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CreateGuardrailRuleDTOSensitivity Sensitivity { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateGuardrailRuleDTO" /> class.
        /// </summary>
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
        /// Advanced text input. Do not supply it together with structured authoring.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailRuleDTO(
            string name,
            global::Vapi.CreateGuardrailRuleDTOSensitivity sensitivity,
            global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction> action,
            global::Vapi.GuardrailAuthoring? authoring,
            string? instructions)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Authoring = authoring;
            this.Instructions = instructions;
            this.Sensitivity = sensitivity;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailRuleDTO" /> class.
        /// </summary>
        public CreateGuardrailRuleDTO()
        {
        }

    }
}