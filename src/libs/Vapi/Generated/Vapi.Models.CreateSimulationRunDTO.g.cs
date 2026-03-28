
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSimulationRunDTO
    {
        /// <summary>
        /// Array of simulations and/or suites to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>> Simulations { get; set; }

        /// <summary>
        /// Target to test against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad> Target { get; set; }

        /// <summary>
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public double? Iterations { get; set; }

        /// <summary>
        /// Transport configuration for the simulation runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public global::Vapi.SimulationRunTransportConfiguration? Transport { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationRunDTO" /> class.
        /// </summary>
        /// <param name="simulations">
        /// Array of simulations and/or suites to run
        /// </param>
        /// <param name="target">
        /// Target to test against
        /// </param>
        /// <param name="iterations">
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="transport">
        /// Transport configuration for the simulation runs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSimulationRunDTO(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>> simulations,
            global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad> target,
            double? iterations,
            global::Vapi.SimulationRunTransportConfiguration? transport)
        {
            this.Simulations = simulations ?? throw new global::System.ArgumentNullException(nameof(simulations));
            this.Target = target;
            this.Iterations = iterations;
            this.Transport = transport;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationRunDTO" /> class.
        /// </summary>
        public CreateSimulationRunDTO()
        {
        }
    }
}