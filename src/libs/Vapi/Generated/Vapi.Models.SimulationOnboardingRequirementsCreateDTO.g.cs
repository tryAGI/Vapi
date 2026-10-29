
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingRequirementsCreateDTO
    {
        /// <summary>
        /// Assistant to draft requirements for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssistantId { get; set; }

        /// <summary>
        /// The draft being revised, exactly as this endpoint returned it. Send it with `feedback`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousDraft")]
        public global::Vapi.SimulationOnboardingRequirementsDraftDTO? PreviousDraft { get; set; }

        /// <summary>
        /// Natural-language instructions for revising the requirements in `previousDraft`, including answers to open questions. Required when `previousDraft` is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback")]
        public string? Feedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementsCreateDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant to draft requirements for.
        /// </param>
        /// <param name="previousDraft">
        /// The draft being revised, exactly as this endpoint returned it. Send it with `feedback`.
        /// </param>
        /// <param name="feedback">
        /// Natural-language instructions for revising the requirements in `previousDraft`, including answers to open questions. Required when `previousDraft` is provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingRequirementsCreateDTO(
            global::System.Guid assistantId,
            global::Vapi.SimulationOnboardingRequirementsDraftDTO? previousDraft,
            string? feedback)
        {
            this.AssistantId = assistantId;
            this.PreviousDraft = previousDraft;
            this.Feedback = feedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementsCreateDTO" /> class.
        /// </summary>
        public SimulationOnboardingRequirementsCreateDTO()
        {
        }

    }
}