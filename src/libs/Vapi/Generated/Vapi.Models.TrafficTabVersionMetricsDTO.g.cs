
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficTabVersionMetricsDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionId")]
        public global::System.Guid? AssistantVersionId { get; set; }

        /// <summary>
        /// The published version label, such as "v7". Null when no version row resolves (unversioned calls, or a since-purged version).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionLabel")]
        public string? AssistantVersionLabel { get; set; }

        /// <summary>
        /// True for the row aggregating calls with no assistant version (stored as SQL NULL).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unversioned")]
        public bool? Unversioned { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Calls { get; set; }

        /// <summary>
        /// The version's share in the currently-governing allocation. Null when the version is not in the current split — never rendered as 0%.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuredPercentage")]
        public double? ConfiguredPercentage { get; set; }

        /// <summary>
        /// calls / totalCalls * 100 over the window, rounded to 3 decimals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actualPercentage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ActualPercentage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationSeconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabDurationSecondsDTO DurationSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costPerMinute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabCostPerMinuteDTO CostPerMinute { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.TrafficTabLatencyMsDTO LatencyMs { get; set; }

        /// <summary>
        /// Full per-reason counts; the UI unions and top-Ns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReasons")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TrafficTabEndedReasonCountDTO> EndedReasons { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeseries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.TrafficTabTimeseriesPointDTO> Timeseries { get; set; }

        /// <summary>
        /// Present only when structuredOutputIds was given.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputs")]
        public global::System.Collections.Generic.IList<global::Vapi.TrafficTabStructuredOutputDTO>? StructuredOutputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabVersionMetricsDTO" /> class.
        /// </summary>
        /// <param name="calls"></param>
        /// <param name="actualPercentage">
        /// calls / totalCalls * 100 over the window, rounded to 3 decimals.
        /// </param>
        /// <param name="durationSeconds"></param>
        /// <param name="costPerMinute"></param>
        /// <param name="latencyMs"></param>
        /// <param name="endedReasons">
        /// Full per-reason counts; the UI unions and top-Ns.
        /// </param>
        /// <param name="timeseries"></param>
        /// <param name="assistantVersionId"></param>
        /// <param name="assistantVersionLabel">
        /// The published version label, such as "v7". Null when no version row resolves (unversioned calls, or a since-purged version).
        /// </param>
        /// <param name="unversioned">
        /// True for the row aggregating calls with no assistant version (stored as SQL NULL).
        /// </param>
        /// <param name="configuredPercentage">
        /// The version's share in the currently-governing allocation. Null when the version is not in the current split — never rendered as 0%.
        /// </param>
        /// <param name="structuredOutputs">
        /// Present only when structuredOutputIds was given.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficTabVersionMetricsDTO(
            double calls,
            double actualPercentage,
            global::Vapi.TrafficTabDurationSecondsDTO durationSeconds,
            global::Vapi.TrafficTabCostPerMinuteDTO costPerMinute,
            global::Vapi.TrafficTabLatencyMsDTO latencyMs,
            global::System.Collections.Generic.IList<global::Vapi.TrafficTabEndedReasonCountDTO> endedReasons,
            global::System.Collections.Generic.IList<global::Vapi.TrafficTabTimeseriesPointDTO> timeseries,
            global::System.Guid? assistantVersionId,
            string? assistantVersionLabel,
            bool? unversioned,
            double? configuredPercentage,
            global::System.Collections.Generic.IList<global::Vapi.TrafficTabStructuredOutputDTO>? structuredOutputs)
        {
            this.AssistantVersionId = assistantVersionId;
            this.AssistantVersionLabel = assistantVersionLabel;
            this.Unversioned = unversioned;
            this.Calls = calls;
            this.ConfiguredPercentage = configuredPercentage;
            this.ActualPercentage = actualPercentage;
            this.DurationSeconds = durationSeconds ?? throw new global::System.ArgumentNullException(nameof(durationSeconds));
            this.CostPerMinute = costPerMinute ?? throw new global::System.ArgumentNullException(nameof(costPerMinute));
            this.LatencyMs = latencyMs ?? throw new global::System.ArgumentNullException(nameof(latencyMs));
            this.EndedReasons = endedReasons ?? throw new global::System.ArgumentNullException(nameof(endedReasons));
            this.Timeseries = timeseries ?? throw new global::System.ArgumentNullException(nameof(timeseries));
            this.StructuredOutputs = structuredOutputs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficTabVersionMetricsDTO" /> class.
        /// </summary>
        public TrafficTabVersionMetricsDTO()
        {
        }

    }
}