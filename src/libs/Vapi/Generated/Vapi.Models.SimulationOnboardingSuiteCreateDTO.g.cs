
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteCreateDTO
    {
        /// <summary>
        /// Assistant the suite tests and is assigned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssistantId { get; set; }

        /// <summary>
        /// One key per agreed draft. Retrying with the same key returns the suite already saved, or a 409 while it is still generating, instead of generating another.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotencyKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdempotencyKey { get; set; }

        /// <summary>
        /// The requirements your user agreed to, from the requirements draft. Each id at most once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteCreateDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant the suite tests and is assigned to.
        /// </param>
        /// <param name="idempotencyKey">
        /// One key per agreed draft. Retrying with the same key returns the suite already saved, or a 409 while it is still generating, instead of generating another.
        /// </param>
        /// <param name="requirements">
        /// The requirements your user agreed to, from the requirements draft. Each id at most once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteCreateDTO(
            global::System.Guid assistantId,
            string idempotencyKey,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> requirements)
        {
            this.AssistantId = assistantId;
            this.IdempotencyKey = idempotencyKey ?? throw new global::System.ArgumentNullException(nameof(idempotencyKey));
            this.Requirements = requirements ?? throw new global::System.ArgumentNullException(nameof(requirements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteCreateDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteCreateDTO()
        {
        }

    }
}