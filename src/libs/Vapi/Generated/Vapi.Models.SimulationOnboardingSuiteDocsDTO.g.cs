
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteDocsDTO
    {
        /// <summary>
        /// Link to testing best practices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bestPractices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BestPractices { get; set; }

        /// <summary>
        /// Link explaining why tools are mocked by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolMocks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolMocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteDocsDTO" /> class.
        /// </summary>
        /// <param name="bestPractices">
        /// Link to testing best practices.
        /// </param>
        /// <param name="toolMocks">
        /// Link explaining why tools are mocked by default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteDocsDTO(
            string bestPractices,
            string toolMocks)
        {
            this.BestPractices = bestPractices ?? throw new global::System.ArgumentNullException(nameof(bestPractices));
            this.ToolMocks = toolMocks ?? throw new global::System.ArgumentNullException(nameof(toolMocks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteDocsDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteDocsDTO()
        {
        }

    }
}