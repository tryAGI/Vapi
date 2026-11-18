
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailRuleConflictResponseDTO
    {
        /// <summary>
        /// Machine-readable cause; clients branch on this, never on `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailRuleConflictResponseDTOErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GuardrailRuleConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Sentence-case copy safe to show the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRuleConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="error">
        /// Machine-readable cause; clients branch on this, never on `message`.
        /// </param>
        /// <param name="message">
        /// Sentence-case copy safe to show the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailRuleConflictResponseDTO(
            global::Vapi.GuardrailRuleConflictResponseDTOError error,
            string message)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRuleConflictResponseDTO" /> class.
        /// </summary>
        public GuardrailRuleConflictResponseDTO()
        {
        }

    }
}