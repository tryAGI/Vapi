
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingSuiteEditDTO
    {
        /// <summary>
        /// Simulation in the suite whose scenario is rewritten.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SimulationId { get; set; }

        /// <summary>
        /// The user's requested change, in their own words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instruction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteEditDTO" /> class.
        /// </summary>
        /// <param name="simulationId">
        /// Simulation in the suite whose scenario is rewritten.
        /// </param>
        /// <param name="instruction">
        /// The user's requested change, in their own words.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingSuiteEditDTO(
            global::System.Guid simulationId,
            string instruction)
        {
            this.SimulationId = simulationId;
            this.Instruction = instruction ?? throw new global::System.ArgumentNullException(nameof(instruction));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingSuiteEditDTO" /> class.
        /// </summary>
        public SimulationOnboardingSuiteEditDTO()
        {
        }

    }
}