
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGuardrailPackDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Projected from membership rows; a supplied array replaces membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ruleIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> RuleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailPackDTO" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ruleIds">
        /// Projected from membership rows; a supplied array replaces membership.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGuardrailPackDTO(
            string name,
            global::System.Collections.Generic.IList<global::System.Guid> ruleIds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RuleIds = ruleIds ?? throw new global::System.ArgumentNullException(nameof(ruleIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGuardrailPackDTO" /> class.
        /// </summary>
        public CreateGuardrailPackDTO()
        {
        }

    }
}