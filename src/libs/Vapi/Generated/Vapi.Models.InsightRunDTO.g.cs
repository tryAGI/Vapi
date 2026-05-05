
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InsightRunDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatPlan")]
        public global::Vapi.InsightRunFormatPlan? FormatPlan { get; set; }

        /// <summary>
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </summary>
        /// <example>{ start: "2025-01-01", end: "2025-01-07", step: "day" }</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRangeOverride")]
        public global::Vapi.InsightTimeRangeWithStep? TimeRangeOverride { get; set; }

        /// <summary>
        /// Optional runtime assistant scope for dashboards.<br/>
        /// This is applied to call-table queries without mutating the saved insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunDTO" /> class.
        /// </summary>
        /// <param name="formatPlan"></param>
        /// <param name="timeRangeOverride">
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </param>
        /// <param name="assistantId">
        /// Optional runtime assistant scope for dashboards.<br/>
        /// This is applied to call-table queries without mutating the saved insight.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InsightRunDTO(
            global::Vapi.InsightRunFormatPlan? formatPlan,
            global::Vapi.InsightTimeRangeWithStep? timeRangeOverride,
            string? assistantId)
        {
            this.FormatPlan = formatPlan;
            this.TimeRangeOverride = timeRangeOverride;
            this.AssistantId = assistantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InsightRunDTO" /> class.
        /// </summary>
        public InsightRunDTO()
        {
        }
    }
}