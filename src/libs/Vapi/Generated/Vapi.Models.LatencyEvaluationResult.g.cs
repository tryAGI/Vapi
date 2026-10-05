
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LatencyEvaluationResult
    {
        /// <summary>
        /// This is the latency component that was measured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.LatencyEvaluationResultMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.LatencyEvaluationResultMetric Metric { get; set; }

        /// <summary>
        /// This is how the per-turn latencies were aggregated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.LatencyEvaluationResultAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.LatencyEvaluationResultAggregation Aggregation { get; set; }

        /// <summary>
        /// This is the ceiling in milliseconds the aggregated latency was compared against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholdMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ThresholdMs { get; set; }

        /// <summary>
        /// This is the aggregated latency in milliseconds, rounded to the nearest<br/>
        /// millisecond. The pass/fail verdict is decided on this rounded value.<br/>
        /// Absent when the expectation was skipped or no turn measured this metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actualMs")]
        public double? ActualMs { get; set; }

        /// <summary>
        /// This is the number of turns that contributed a value for this metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampleCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SampleCount { get; set; }

        /// <summary>
        /// This indicates whether the aggregated latency was at or below the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// This indicates whether this expectation was required for the simulation to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// This indicates whether this expectation was skipped. Expectations are only<br/>
        /// skipped on chat simulations and GPT Live targets, which record no latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isSkipped")]
        public bool? IsSkipped { get; set; }

        /// <summary>
        /// This contains the reason for skipping the expectation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipReason")]
        public string? SkipReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyEvaluationResult" /> class.
        /// </summary>
        /// <param name="metric">
        /// This is the latency component that was measured.
        /// </param>
        /// <param name="aggregation">
        /// This is how the per-turn latencies were aggregated.
        /// </param>
        /// <param name="thresholdMs">
        /// This is the ceiling in milliseconds the aggregated latency was compared against.
        /// </param>
        /// <param name="sampleCount">
        /// This is the number of turns that contributed a value for this metric.
        /// </param>
        /// <param name="passed">
        /// This indicates whether the aggregated latency was at or below the threshold.
        /// </param>
        /// <param name="required">
        /// This indicates whether this expectation was required for the simulation to pass.
        /// </param>
        /// <param name="actualMs">
        /// This is the aggregated latency in milliseconds, rounded to the nearest<br/>
        /// millisecond. The pass/fail verdict is decided on this rounded value.<br/>
        /// Absent when the expectation was skipped or no turn measured this metric.
        /// </param>
        /// <param name="isSkipped">
        /// This indicates whether this expectation was skipped. Expectations are only<br/>
        /// skipped on chat simulations and GPT Live targets, which record no latency.
        /// </param>
        /// <param name="skipReason">
        /// This contains the reason for skipping the expectation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatencyEvaluationResult(
            global::Vapi.LatencyEvaluationResultMetric metric,
            global::Vapi.LatencyEvaluationResultAggregation aggregation,
            double thresholdMs,
            double sampleCount,
            bool passed,
            bool required,
            double? actualMs,
            bool? isSkipped,
            string? skipReason)
        {
            this.Metric = metric;
            this.Aggregation = aggregation;
            this.ThresholdMs = thresholdMs;
            this.ActualMs = actualMs;
            this.SampleCount = sampleCount;
            this.Passed = passed;
            this.Required = required;
            this.IsSkipped = isSkipped;
            this.SkipReason = skipReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyEvaluationResult" /> class.
        /// </summary>
        public LatencyEvaluationResult()
        {
        }

    }
}