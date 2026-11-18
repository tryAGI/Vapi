
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaveGuardrailRuleDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SaveGuardrailRuleDTOSensitivityJsonConverter))]
        public global::Vapi.SaveGuardrailRuleDTOSensitivity? Sensitivity { get; set; }

        /// <summary>
        /// Supplied PATCH actions replace the complete variant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>))]
        public global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>? Action { get; set; }

        /// <summary>
        /// Last-read configuration; the complete snapshot prevents lost edits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GuardrailRuleSnapshot Expected { get; set; }

        /// <summary>
        /// Current deduplicated assistant impact acknowledged before a shared save.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmedAssistantIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ConfirmedAssistantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveGuardrailRuleDTO" /> class.
        /// </summary>
        /// <param name="expected">
        /// Last-read configuration; the complete snapshot prevents lost edits.
        /// </param>
        /// <param name="name"></param>
        /// <param name="authoring">
        /// Structured editor input. Supplied PATCH authoring replaces the complete object; advanced text writes clear it to null.
        /// </param>
        /// <param name="instructions">
        /// Advanced text input. Do not supply it together with structured authoring.
        /// </param>
        /// <param name="sensitivity">
        /// Evaluation sensitivity; numeric cutoffs are internal and provisional.
        /// </param>
        /// <param name="action">
        /// Supplied PATCH actions replace the complete variant.
        /// </param>
        /// <param name="confirmedAssistantIds">
        /// Current deduplicated assistant impact acknowledged before a shared save.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveGuardrailRuleDTO(
            global::Vapi.GuardrailRuleSnapshot expected,
            string? name,
            global::Vapi.GuardrailAuthoring? authoring,
            string? instructions,
            global::Vapi.SaveGuardrailRuleDTOSensitivity? sensitivity,
            global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>? action,
            global::System.Collections.Generic.IList<global::System.Guid>? confirmedAssistantIds)
        {
            this.Name = name;
            this.Authoring = authoring;
            this.Instructions = instructions;
            this.Sensitivity = sensitivity;
            this.Action = action;
            this.Expected = expected ?? throw new global::System.ArgumentNullException(nameof(expected));
            this.ConfirmedAssistantIds = confirmedAssistantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveGuardrailRuleDTO" /> class.
        /// </summary>
        public SaveGuardrailRuleDTO()
        {
        }

    }
}