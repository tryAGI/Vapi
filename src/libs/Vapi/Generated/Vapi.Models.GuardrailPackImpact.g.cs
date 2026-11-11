
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailPackImpact
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> AssistantIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPackImpact" /> class.
        /// </summary>
        /// <param name="assistantIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailPackImpact(
            global::System.Collections.Generic.IList<global::System.Guid> assistantIds)
        {
            this.AssistantIds = assistantIds ?? throw new global::System.ArgumentNullException(nameof(assistantIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailPackImpact" /> class.
        /// </summary>
        public GuardrailPackImpact()
        {
        }

    }
}