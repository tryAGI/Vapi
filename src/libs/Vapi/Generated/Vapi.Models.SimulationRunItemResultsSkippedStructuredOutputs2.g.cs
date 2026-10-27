
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationRunItemResultsSkippedStructuredOutputs2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmetCondition")]
        public object? UnmetCondition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationRunItemResultsSkippedStructuredOutputsReasonJsonConverter))]
        public global::Vapi.SimulationRunItemResultsSkippedStructuredOutputsReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResultsSkippedStructuredOutputs2" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unmetCondition"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemResultsSkippedStructuredOutputs2(
            string name,
            object? unmetCondition,
            global::Vapi.SimulationRunItemResultsSkippedStructuredOutputsReason? reason)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UnmetCondition = unmetCondition;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResultsSkippedStructuredOutputs2" /> class.
        /// </summary>
        public SimulationRunItemResultsSkippedStructuredOutputs2()
        {
        }

    }
}