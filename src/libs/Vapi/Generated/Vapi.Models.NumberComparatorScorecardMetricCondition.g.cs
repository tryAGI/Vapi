
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NumberComparatorScorecardMetricCondition
    {
        /// <summary>
        /// This is the type of the condition. Currently only 'comparator' is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionTypeJsonConverter))]
        public global::Vapi.NumberComparatorScorecardMetricConditionType Type { get; set; }

        /// <summary>
        /// This is the comparator that will be used to compare the result of the structured output with the value specified.<br/>
        /// Only '=', '!=', '&gt;', '&lt;', '&gt;=', and '&lt;=' are supported for number conditions<br/>
        /// Only '=' is supported for boolean conditions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionComparatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.NumberComparatorScorecardMetricConditionComparator Comparator { get; set; }

        /// <summary>
        /// This is the value that will be used to compare the result of the structured output with the comparator.<br/>
        /// If the result of the comparison is true, the points will be added to the overall score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// These are the points that will be added to the overall score if the condition is met.<br/>
        /// The points must be between 0 and 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Points { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberComparatorScorecardMetricCondition" /> class.
        /// </summary>
        /// <param name="comparator">
        /// This is the comparator that will be used to compare the result of the structured output with the value specified.<br/>
        /// Only '=', '!=', '&gt;', '&lt;', '&gt;=', and '&lt;=' are supported for number conditions<br/>
        /// Only '=' is supported for boolean conditions.
        /// </param>
        /// <param name="value">
        /// This is the value that will be used to compare the result of the structured output with the comparator.<br/>
        /// If the result of the comparison is true, the points will be added to the overall score.
        /// </param>
        /// <param name="points">
        /// These are the points that will be added to the overall score if the condition is met.<br/>
        /// The points must be between 0 and 100.
        /// </param>
        /// <param name="type">
        /// This is the type of the condition. Currently only 'comparator' is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NumberComparatorScorecardMetricCondition(
            global::Vapi.NumberComparatorScorecardMetricConditionComparator comparator,
            double value,
            double points,
            global::Vapi.NumberComparatorScorecardMetricConditionType type)
        {
            this.Type = type;
            this.Comparator = comparator;
            this.Value = value;
            this.Points = points;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberComparatorScorecardMetricCondition" /> class.
        /// </summary>
        public NumberComparatorScorecardMetricCondition()
        {
        }

    }
}