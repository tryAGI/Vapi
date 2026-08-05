
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunListSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationRunListSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetSnapshotName")]
        public string? TargetSnapshotName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SimulationCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunListSummary" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="simulationCount"></param>
        /// <param name="targetSnapshotName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunListSummary(
            global::Vapi.SimulationRunListSource source,
            double simulationCount,
            string? targetSnapshotName)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.TargetSnapshotName = targetSnapshotName;
            this.SimulationCount = simulationCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunListSummary" /> class.
        /// </summary>
        public SimulationRunListSummary()
        {
        }

    }
}