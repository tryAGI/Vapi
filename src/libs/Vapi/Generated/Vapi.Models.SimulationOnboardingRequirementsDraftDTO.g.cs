
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingRequirementsDraftDTO
    {
        /// <summary>
        /// Draft version, 1 for a first draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Version { get; set; }

        /// <summary>
        /// What changed since the previous draft.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changeNote")]
        public string? ChangeNote { get; set; }

        /// <summary>
        /// What the draft was based on, e.g. the prompt and tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Sources { get; set; }

        /// <summary>
        /// Draft test requirements describing the expected assistant behavior. Review and refine these before generating a simulation suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> Requirements { get; set; }

        /// <summary>
        /// Questions about ambiguous or missing assistant behavior to resolve before generating a simulation suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openQuestions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingOpenQuestionDTO> OpenQuestions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementsDraftDTO" /> class.
        /// </summary>
        /// <param name="version">
        /// Draft version, 1 for a first draft.
        /// </param>
        /// <param name="sources">
        /// What the draft was based on, e.g. the prompt and tools.
        /// </param>
        /// <param name="requirements">
        /// Draft test requirements describing the expected assistant behavior. Review and refine these before generating a simulation suite.
        /// </param>
        /// <param name="openQuestions">
        /// Questions about ambiguous or missing assistant behavior to resolve before generating a simulation suite.
        /// </param>
        /// <param name="changeNote">
        /// What changed since the previous draft.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingRequirementsDraftDTO(
            double version,
            global::System.Collections.Generic.IList<string> sources,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> requirements,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingOpenQuestionDTO> openQuestions,
            string? changeNote)
        {
            this.Version = version;
            this.ChangeNote = changeNote;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Requirements = requirements ?? throw new global::System.ArgumentNullException(nameof(requirements));
            this.OpenQuestions = openQuestions ?? throw new global::System.ArgumentNullException(nameof(openQuestions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingRequirementsDraftDTO" /> class.
        /// </summary>
        public SimulationOnboardingRequirementsDraftDTO()
        {
        }

    }
}