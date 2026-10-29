
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
        /// A unique key for this suite generation request. Retrying with the same key returns the saved suite, or a 409 while generation is in progress. Use a new key for a different assistant or requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotencyKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdempotencyKey { get; set; }

        /// <summary>
        /// The reviewed test requirements to generate simulations for, from the requirements draft. Each requirement must have a unique id.
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
        /// A unique key for this suite generation request. Retrying with the same key returns the saved suite, or a 409 while generation is in progress. Use a new key for a different assistant or requirements.
        /// </param>
        /// <param name="requirements">
        /// The reviewed test requirements to generate simulations for, from the requirements draft. Each requirement must have a unique id.
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