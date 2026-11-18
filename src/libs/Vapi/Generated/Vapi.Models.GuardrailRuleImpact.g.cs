
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailRuleImpact
    {
        /// <summary>
        /// Distinct assistants affected across direct, pack, draft, and version selections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> AssistantIds { get; set; }

        /// <summary>
        /// Packs currently containing the rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> PackIds { get; set; }

        /// <summary>
        /// Names for the same distinct assistant identities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistants")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.GuardrailRuleUsage> Assistants { get; set; }

        /// <summary>
        /// Names for the containing pack identities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.GuardrailRuleUsage> Packs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRuleImpact" /> class.
        /// </summary>
        /// <param name="assistantIds">
        /// Distinct assistants affected across direct, pack, draft, and version selections.
        /// </param>
        /// <param name="packIds">
        /// Packs currently containing the rule.
        /// </param>
        /// <param name="assistants">
        /// Names for the same distinct assistant identities.
        /// </param>
        /// <param name="packs">
        /// Names for the containing pack identities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailRuleImpact(
            global::System.Collections.Generic.IList<global::System.Guid> assistantIds,
            global::System.Collections.Generic.IList<global::System.Guid> packIds,
            global::System.Collections.Generic.IList<global::Vapi.GuardrailRuleUsage> assistants,
            global::System.Collections.Generic.IList<global::Vapi.GuardrailRuleUsage> packs)
        {
            this.AssistantIds = assistantIds ?? throw new global::System.ArgumentNullException(nameof(assistantIds));
            this.PackIds = packIds ?? throw new global::System.ArgumentNullException(nameof(packIds));
            this.Assistants = assistants ?? throw new global::System.ArgumentNullException(nameof(assistants));
            this.Packs = packs ?? throw new global::System.ArgumentNullException(nameof(packs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRuleImpact" /> class.
        /// </summary>
        public GuardrailRuleImpact()
        {
        }

    }
}