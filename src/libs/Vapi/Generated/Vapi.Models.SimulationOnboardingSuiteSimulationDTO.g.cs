
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteSimulationDTO
    {
        /// <summary>
        /// Simulation id; pass it back to edit or remove the simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Scenario the simulation runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scenarioId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScenarioId { get; set; }

        /// <summary>
        /// Scenario name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Name of the simulated caller's personality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalityName")]
        public string? PersonalityName { get; set; }

        /// <summary>
        /// Each success criterion, as the yes/no question it is judged by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successCriteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SuccessCriteria { get; set; }

        /// <summary>
        /// Requirement ids this simulation covers, e.g. `R3`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirementIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequirementIds { get; set; }

        /// <summary>
        /// Tools the scenario mocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mockedTools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MockedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteSimulationDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Simulation id; pass it back to edit or remove the simulation.
        /// </param>
        /// <param name="scenarioId">
        /// Scenario the simulation runs.
        /// </param>
        /// <param name="name">
        /// Scenario name.
        /// </param>
        /// <param name="successCriteria">
        /// Each success criterion, as the yes/no question it is judged by.
        /// </param>
        /// <param name="requirementIds">
        /// Requirement ids this simulation covers, e.g. `R3`.
        /// </param>
        /// <param name="mockedTools">
        /// Tools the scenario mocks.
        /// </param>
        /// <param name="personalityName">
        /// Name of the simulated caller's personality.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteSimulationDTO(
            string id,
            string scenarioId,
            string name,
            global::System.Collections.Generic.IList<string> successCriteria,
            global::System.Collections.Generic.IList<string> requirementIds,
            global::System.Collections.Generic.IList<string> mockedTools,
            string? personalityName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ScenarioId = scenarioId ?? throw new global::System.ArgumentNullException(nameof(scenarioId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PersonalityName = personalityName;
            this.SuccessCriteria = successCriteria ?? throw new global::System.ArgumentNullException(nameof(successCriteria));
            this.RequirementIds = requirementIds ?? throw new global::System.ArgumentNullException(nameof(requirementIds));
            this.MockedTools = mockedTools ?? throw new global::System.ArgumentNullException(nameof(mockedTools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteSimulationDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteSimulationDTO()
        {
        }

    }
}