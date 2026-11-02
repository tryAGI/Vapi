
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardIssueDetailResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueSummaryDTO Issue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seriesPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardSeriesPageDTO SeriesPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIssueDefinitionDTO Definition { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDetailResponseDTO" /> class.
        /// </summary>
        /// <param name="issue"></param>
        /// <param name="seriesPage"></param>
        /// <param name="definition"></param>
        /// <param name="coverage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardIssueDetailResponseDTO(
            global::Vapi.CallHealthDashboardIssueSummaryDTO issue,
            global::Vapi.CallHealthDashboardSeriesPageDTO seriesPage,
            global::Vapi.CallHealthDashboardIssueDefinitionDTO definition,
            global::Vapi.CallHealthDashboardCoverageDTO coverage)
        {
            this.Issue = issue ?? throw new global::System.ArgumentNullException(nameof(issue));
            this.SeriesPage = seriesPage ?? throw new global::System.ArgumentNullException(nameof(seriesPage));
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Coverage = coverage ?? throw new global::System.ArgumentNullException(nameof(coverage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardIssueDetailResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardIssueDetailResponseDTO()
        {
        }

    }
}