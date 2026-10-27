
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationRunItemResults
    {
        /// <summary>
        /// Retention-permitted target extraction values, present only when enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputs")]
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SimulationRunItemResultsStructuredOutputs2>? StructuredOutputs { get; set; }

        /// <summary>
        /// Condition-gated outputs or audio outputs unsupported by chat.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skippedStructuredOutputs")]
        public global::System.Collections.Generic.Dictionary<string, global::Vapi.SimulationRunItemResultsSkippedStructuredOutputs2>? SkippedStructuredOutputs { get; set; }

        /// <summary>
        /// Sanitized diagnostic; optional target extraction never changes pass/fail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputError")]
        public string? StructuredOutputError { get; set; }

        /// <summary>
        /// This is the list of results from structured output evaluations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult> Evaluations { get; set; }

        /// <summary>
        /// This indicates whether all required, non-skipped structured output evaluations and latency expectations passed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// This contains the latency metrics collected from the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMetrics")]
        public global::Vapi.LatencyMetrics? LatencyMetrics { get; set; }

        /// <summary>
        /// This is the list of results from the scenario's latency expectations.<br/>
        /// Absent when the scenario has no latency expectations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyEvaluations")]
        public global::System.Collections.Generic.IList<global::Vapi.LatencyEvaluationResult>? LatencyEvaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResults" /> class.
        /// </summary>
        /// <param name="evaluations">
        /// This is the list of results from structured output evaluations.
        /// </param>
        /// <param name="passed">
        /// This indicates whether all required, non-skipped structured output evaluations and latency expectations passed.
        /// </param>
        /// <param name="structuredOutputs">
        /// Retention-permitted target extraction values, present only when enabled.
        /// </param>
        /// <param name="skippedStructuredOutputs">
        /// Condition-gated outputs or audio outputs unsupported by chat.
        /// </param>
        /// <param name="structuredOutputError">
        /// Sanitized diagnostic; optional target extraction never changes pass/fail.
        /// </param>
        /// <param name="latencyMetrics">
        /// This contains the latency metrics collected from the call.
        /// </param>
        /// <param name="latencyEvaluations">
        /// This is the list of results from the scenario's latency expectations.<br/>
        /// Absent when the scenario has no latency expectations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationRunItemResults(
            global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult> evaluations,
            bool passed,
            global::System.Collections.Generic.Dictionary<string, global::Vapi.SimulationRunItemResultsStructuredOutputs2>? structuredOutputs,
            global::System.Collections.Generic.Dictionary<string, global::Vapi.SimulationRunItemResultsSkippedStructuredOutputs2>? skippedStructuredOutputs,
            string? structuredOutputError,
            global::Vapi.LatencyMetrics? latencyMetrics,
            global::System.Collections.Generic.IList<global::Vapi.LatencyEvaluationResult>? latencyEvaluations)
        {
            this.StructuredOutputs = structuredOutputs;
            this.SkippedStructuredOutputs = skippedStructuredOutputs;
            this.StructuredOutputError = structuredOutputError;
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.Passed = passed;
            this.LatencyMetrics = latencyMetrics;
            this.LatencyEvaluations = latencyEvaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunItemResults" /> class.
        /// </summary>
        public SimulationRunItemResults()
        {
        }

    }
}