
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunItemCounts
    {
        /// <summary>
        /// Total number of run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Number of passed run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Passed { get; set; }

        /// <summary>
        /// Number of failed run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Failed { get; set; }

        /// <summary>
        /// Number of running/evaluating run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("running")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Running { get; set; }

        /// <summary>
        /// Number of queued run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Queued { get; set; }

        /// <summary>
        /// Number of canceled run items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Canceled { get; set; }

        /// <summary>
        /// Number of distinct simulations represented by the run items. Omitted when any item has no simulation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinctSimulationTotal")]
        public double? DistinctSimulationTotal { get; set; }

        /// <summary>
        /// Number of distinct simulations with a failed or canceled item. Omitted when any item has no simulation ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distinctSimulationFailed")]
        public double? DistinctSimulationFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCounts" /> class.
        /// </summary>
        /// <param name="total">
        /// Total number of run items
        /// </param>
        /// <param name="passed">
        /// Number of passed run items
        /// </param>
        /// <param name="failed">
        /// Number of failed run items
        /// </param>
        /// <param name="running">
        /// Number of running/evaluating run items
        /// </param>
        /// <param name="queued">
        /// Number of queued run items
        /// </param>
        /// <param name="canceled">
        /// Number of canceled run items
        /// </param>
        /// <param name="distinctSimulationTotal">
        /// Number of distinct simulations represented by the run items. Omitted when any item has no simulation ID.
        /// </param>
        /// <param name="distinctSimulationFailed">
        /// Number of distinct simulations with a failed or canceled item. Omitted when any item has no simulation ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemCounts(
            double total,
            double passed,
            double failed,
            double running,
            double queued,
            double canceled,
            double? distinctSimulationTotal,
            double? distinctSimulationFailed)
        {
            this.Total = total;
            this.Passed = passed;
            this.Failed = failed;
            this.Running = running;
            this.Queued = queued;
            this.Canceled = canceled;
            this.DistinctSimulationTotal = distinctSimulationTotal;
            this.DistinctSimulationFailed = distinctSimulationFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemCounts" /> class.
        /// </summary>
        public SimulationRunItemCounts()
        {
        }

    }
}