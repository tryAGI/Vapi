
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TranscriptMetricEvaluationResult
    {
        /// <summary>
        /// This is the evaluation's position in the scenario's evaluations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Index { get; set; }

        /// <summary>
        /// This is the metric evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TranscriptMetricEvaluationResultMetricJsonConverter))]
        public global::Vapi.TranscriptMetricEvaluationResultMetric Metric { get; set; }

        /// <summary>
        /// This is the comparison made: the metric's value on the left, `expectedValue` on the right.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TranscriptMetricEvaluationResultComparatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TranscriptMetricEvaluationResultComparator Comparator { get; set; }

        /// <summary>
        /// This is the value the evaluation compares against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedValue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpectedValue { get; set; }

        /// <summary>
        /// This is the metric's value for this run. Null when it could not be measured, such as a word error rate for an<br/>
        /// answer key with no words; the evaluation then fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actualValue")]
        public double? ActualValue { get; set; }

        /// <summary>
        /// This is whether the comparison held.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("passed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Passed { get; set; }

        /// <summary>
        /// This is whether the evaluation decides pass or fail. When false it is informational only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetricEvaluationResult" /> class.
        /// </summary>
        /// <param name="index">
        /// This is the evaluation's position in the scenario's evaluations.
        /// </param>
        /// <param name="comparator">
        /// This is the comparison made: the metric's value on the left, `expectedValue` on the right.
        /// </param>
        /// <param name="expectedValue">
        /// This is the value the evaluation compares against.
        /// </param>
        /// <param name="passed">
        /// This is whether the comparison held.
        /// </param>
        /// <param name="required">
        /// This is whether the evaluation decides pass or fail. When false it is informational only.
        /// </param>
        /// <param name="metric">
        /// This is the metric evaluated.
        /// </param>
        /// <param name="actualValue">
        /// This is the metric's value for this run. Null when it could not be measured, such as a word error rate for an<br/>
        /// answer key with no words; the evaluation then fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptMetricEvaluationResult(
            double index,
            global::Vapi.TranscriptMetricEvaluationResultComparator comparator,
            double expectedValue,
            bool passed,
            bool required,
            global::Vapi.TranscriptMetricEvaluationResultMetric metric,
            double? actualValue)
        {
            this.Index = index;
            this.Metric = metric;
            this.Comparator = comparator;
            this.ExpectedValue = expectedValue;
            this.ActualValue = actualValue;
            this.Passed = passed;
            this.Required = required;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptMetricEvaluationResult" /> class.
        /// </summary>
        public TranscriptMetricEvaluationResult()
        {
        }

    }
}