
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SaveGuardrailPackDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Projected from membership rows; a supplied array replaces membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RuleIds { get; set; }

        /// <summary>
        /// The complete last-read snapshot prevents silently replacing another editor’s changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GuardrailPackSnapshot Expected { get; set; }

        /// <summary>
        /// Exact deduplicated impact acknowledged by the user; rechecked while the pack is locked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmedAssistantIds")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ConfirmedAssistantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveGuardrailPackDTO" /> class.
        /// </summary>
        /// <param name="expected">
        /// The complete last-read snapshot prevents silently replacing another editor’s changes.
        /// </param>
        /// <param name="name"></param>
        /// <param name="ruleIds">
        /// Projected from membership rows; a supplied array replaces membership.
        /// </param>
        /// <param name="confirmedAssistantIds">
        /// Exact deduplicated impact acknowledged by the user; rechecked while the pack is locked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SaveGuardrailPackDTO(
            global::Vapi.GuardrailPackSnapshot expected,
            string? name,
            global::System.Collections.Generic.IList<global::System.Guid>? ruleIds,
            global::System.Collections.Generic.IList<global::System.Guid>? confirmedAssistantIds)
        {
            this.Name = name;
            this.RuleIds = ruleIds;
            this.Expected = expected ?? throw new global::System.ArgumentNullException(nameof(expected));
            this.ConfirmedAssistantIds = confirmedAssistantIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveGuardrailPackDTO" /> class.
        /// </summary>
        public SaveGuardrailPackDTO()
        {
        }

    }
}