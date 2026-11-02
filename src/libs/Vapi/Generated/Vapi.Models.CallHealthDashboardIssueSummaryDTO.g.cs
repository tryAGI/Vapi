
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueSummaryDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardIssueSummaryDTOStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueSummaryDTOStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RowVersion { get; set; }

        /// <summary>
        /// Owning goal identity; issue-ID routes derive this selection from the issue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GoalId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardAssistantReferenceDTO Assistant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AffectedCallCount { get; set; }

        /// <summary>
        /// Same assistant/current-goal/window denominator used by the goal reads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AnalyzedCallCount { get; set; }

        /// <summary>
        /// Distinct calls matching this issue / analyzedCallCount; absent at zero.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("affectedCallRate")]
        public double? AffectedCallRate { get; set; }

        /// <summary>
        /// One ascending contiguous page of UTC buckets; memberships across issues are not unique calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dailySeries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardIssueDailyDTO> DailySeries { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastSeenAt")]
        public global::System.DateTime? LastSeenAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueCoverageDTO Coverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueSummaryDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="rowVersion"></param>
        /// <param name="goalId">
        /// Owning goal identity; issue-ID routes derive this selection from the issue.
        /// </param>
        /// <param name="summary"></param>
        /// <param name="assistant"></param>
        /// <param name="affectedCallCount"></param>
        /// <param name="analyzedCallCount">
        /// Same assistant/current-goal/window denominator used by the goal reads.
        /// </param>
        /// <param name="dailySeries">
        /// One ascending contiguous page of UTC buckets; memberships across issues are not unique calls.
        /// </param>
        /// <param name="coverage"></param>
        /// <param name="affectedCallRate">
        /// Distinct calls matching this issue / analyzedCallCount; absent at zero.
        /// </param>
        /// <param name="lastSeenAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueSummaryDTO(
            global::System.Guid id,
            string name,
            global::Vapi.CallHealthDashboardIssueSummaryDTOStatus status,
            long rowVersion,
            global::System.Guid goalId,
            string summary,
            global::Vapi.CallHealthDashboardAssistantReferenceDTO assistant,
            long affectedCallCount,
            long analyzedCallCount,
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardIssueDailyDTO> dailySeries,
            global::Vapi.CallHealthDashboardIssueCoverageDTO coverage,
            double? affectedCallRate,
            global::System.DateTime? lastSeenAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.RowVersion = rowVersion;
            this.GoalId = goalId;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Assistant = assistant ?? throw new global::System.ArgumentNullException(nameof(assistant));
            this.AffectedCallCount = affectedCallCount;
            this.AnalyzedCallCount = analyzedCallCount;
            this.AffectedCallRate = affectedCallRate;
            this.DailySeries = dailySeries ?? throw new global::System.ArgumentNullException(nameof(dailySeries));
            this.LastSeenAt = lastSeenAt;
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueSummaryDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueSummaryDTO()
        {
        }

    }
}