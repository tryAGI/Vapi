
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteViewDTO
    {
        /// <summary>
        /// The suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suite")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationOnboardingSuiteRefDTO Suite { get; set; }

        /// <summary>
        /// Assistant the suite is assigned to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// The suite's simulations, in order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteSimulationDTO> Simulations { get; set; }

        /// <summary>
        /// Coverage of the agreed requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationOnboardingSuiteCoverageDTO Coverage { get; set; }

        /// <summary>
        /// The agreed requirements the suite was generated from, to name the gaps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> Requirements { get; set; }

        /// <summary>
        /// Documentation to link when you summarize the suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationOnboardingSuiteDocsDTO Docs { get; set; }

        /// <summary>
        /// True when the request matched one already applied (same `idempotencyKey` or `patchKey`) and nothing changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Reused { get; set; }

        /// <summary>
        /// Simulations an edit asked to rewrite that were not rewritten, for example because the rewrite did not generate in time. Retry them with a new `patchKey`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedEditSimulationIds")]
        public global::System.Collections.Generic.IList<string>? FailedEditSimulationIds { get; set; }

        /// <summary>
        /// Tool paths the suite's simulations do not exercise as configured, such as a tool mocked although it runs natively. Omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolGaps")]
        public global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingToolGapDTO>? ToolGaps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteViewDTO" /> class.
        /// </summary>
        /// <param name="suite">
        /// The suite.
        /// </param>
        /// <param name="assistantId">
        /// Assistant the suite is assigned to.
        /// </param>
        /// <param name="simulations">
        /// The suite's simulations, in order.
        /// </param>
        /// <param name="coverage">
        /// Coverage of the agreed requirements.
        /// </param>
        /// <param name="requirements">
        /// The agreed requirements the suite was generated from, to name the gaps.
        /// </param>
        /// <param name="docs">
        /// Documentation to link when you summarize the suite.
        /// </param>
        /// <param name="reused">
        /// True when the request matched one already applied (same `idempotencyKey` or `patchKey`) and nothing changed.
        /// </param>
        /// <param name="failedEditSimulationIds">
        /// Simulations an edit asked to rewrite that were not rewritten, for example because the rewrite did not generate in time. Retry them with a new `patchKey`.
        /// </param>
        /// <param name="toolGaps">
        /// Tool paths the suite's simulations do not exercise as configured, such as a tool mocked although it runs natively. Omitted when there are none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteViewDTO(
            global::Vapi.SimulationOnboardingSuiteRefDTO suite,
            string assistantId,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteSimulationDTO> simulations,
            global::Vapi.SimulationOnboardingSuiteCoverageDTO coverage,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> requirements,
            global::Vapi.SimulationOnboardingSuiteDocsDTO docs,
            bool reused,
            global::System.Collections.Generic.IList<string>? failedEditSimulationIds,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingToolGapDTO>? toolGaps)
        {
            this.Suite = suite ?? throw new global::System.ArgumentNullException(nameof(suite));
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.Simulations = simulations ?? throw new global::System.ArgumentNullException(nameof(simulations));
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
            this.Requirements = requirements ?? throw new global::System.ArgumentNullException(nameof(requirements));
            this.Docs = docs ?? throw new global::System.ArgumentNullException(nameof(docs));
            this.Reused = reused;
            this.FailedEditSimulationIds = failedEditSimulationIds;
            this.ToolGaps = toolGaps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteViewDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteViewDTO()
        {
        }

    }
}