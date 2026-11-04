
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantSummaryResponseDTO
    {
        /// <summary>
        /// Current permitted assistant metadata, fetched in a batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardAssistantReferenceDTO Assistant { get; set; }

        /// <summary>
        /// Every row represents an explicitly selected, tenant-owned assistant goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalDefinition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardGoalDefinitionDTO GoalDefinition { get; set; }

        /// <summary>
        /// Window totals for the selected goal, including zero-result assistants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardGoalSummaryDTO Goal { get; set; }

        /// <summary>
        /// One ascending contiguous page of UTC dates, including empty buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalDailyDTO> Results { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seriesPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardSeriesPageDTO SeriesPage { get; set; }

        /// <summary>
        /// Received-work processing coverage, separate from success rates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coverage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardCoverageDTO Coverage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantSummaryResponseDTO" /> class.
        /// </summary>
        /// <param name="assistant">
        /// Current permitted assistant metadata, fetched in a batch.
        /// </param>
        /// <param name="goalDefinition">
        /// Every row represents an explicitly selected, tenant-owned assistant goal.
        /// </param>
        /// <param name="goal">
        /// Window totals for the selected goal, including zero-result assistants.
        /// </param>
        /// <param name="results">
        /// One ascending contiguous page of UTC dates, including empty buckets.
        /// </param>
        /// <param name="seriesPage"></param>
        /// <param name="coverage">
        /// Received-work processing coverage, separate from success rates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantSummaryResponseDTO(
            global::Vapi.CallHealthDashboardAssistantReferenceDTO assistant,
            global::Vapi.CallHealthDashboardGoalDefinitionDTO goalDefinition,
            global::Vapi.CallHealthDashboardGoalSummaryDTO goal,
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalDailyDTO> results,
            global::Vapi.CallHealthDashboardSeriesPageDTO seriesPage,
            global::Vapi.CallHealthDashboardCoverageDTO coverage)
        {
            this.Assistant = assistant ?? throw new global::System.ArgumentNullException(nameof(assistant));
            this.GoalDefinition = goalDefinition ?? throw new global::System.ArgumentNullException(nameof(goalDefinition));
            this.Goal = goal ?? throw new global::System.ArgumentNullException(nameof(goal));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.SeriesPage = seriesPage ?? throw new global::System.ArgumentNullException(nameof(seriesPage));
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantSummaryResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantSummaryResponseDTO()
        {
        }

    }
}