
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LatencyExpectation
    {
        /// <summary>
        /// This is the latency component to measure.<br/>
        /// - turn: total time from the end of user speech to the start of assistant speech<br/>
        /// - model: LLM time to first token<br/>
        /// - voice: TTS time to first audio<br/>
        /// Example: turn
        /// </summary>
        /// <example>turn</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.LatencyExpectationMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.LatencyExpectationMetric Metric { get; set; }

        /// <summary>
        /// This is how the call's per-turn latencies are aggregated before comparing.<br/>
        /// p95 uses the nearest-rank method, so on calls with fewer than 20 turns it<br/>
        /// equals the max.<br/>
        /// Example: median
        /// </summary>
        /// <example>median</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.LatencyExpectationAggregationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.LatencyExpectationAggregation Aggregation { get; set; }

        /// <summary>
        /// This is the ceiling in milliseconds. The expectation passes when the<br/>
        /// aggregated latency is less than or equal to this value.<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("thresholdMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ThresholdMs { get; set; }

        /// <summary>
        /// This is whether this expectation must pass for the simulation to pass.<br/>
        /// Defaults to true. If false, the result is informational only.<br/>
        /// On a voice simulation, a metric that no turn measured fails the expectation.<br/>
        /// GPT Live targets are skipped, because their latency is not measured yet.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyExpectation" /> class.
        /// </summary>
        /// <param name="metric">
        /// This is the latency component to measure.<br/>
        /// - turn: total time from the end of user speech to the start of assistant speech<br/>
        /// - model: LLM time to first token<br/>
        /// - voice: TTS time to first audio<br/>
        /// Example: turn
        /// </param>
        /// <param name="aggregation">
        /// This is how the call's per-turn latencies are aggregated before comparing.<br/>
        /// p95 uses the nearest-rank method, so on calls with fewer than 20 turns it<br/>
        /// equals the max.<br/>
        /// Example: median
        /// </param>
        /// <param name="thresholdMs">
        /// This is the ceiling in milliseconds. The expectation passes when the<br/>
        /// aggregated latency is less than or equal to this value.<br/>
        /// Example: 1200
        /// </param>
        /// <param name="required">
        /// This is whether this expectation must pass for the simulation to pass.<br/>
        /// Defaults to true. If false, the result is informational only.<br/>
        /// On a voice simulation, a metric that no turn measured fails the expectation.<br/>
        /// GPT Live targets are skipped, because their latency is not measured yet.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LatencyExpectation(
            global::Vapi.LatencyExpectationMetric metric,
            global::Vapi.LatencyExpectationAggregation aggregation,
            double thresholdMs,
            bool? required)
        {
            this.Metric = metric;
            this.Aggregation = aggregation;
            this.ThresholdMs = thresholdMs;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LatencyExpectation" /> class.
        /// </summary>
        public LatencyExpectation()
        {
        }

    }
}