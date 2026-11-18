
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardGoalVersionSummaryDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registeredCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RegisteredCallCount { get; set; }

        /// <summary>
        /// Calls with an accepted semantic eligibility decision and binary goal outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eligibleCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EligibleCallCount { get; set; }

        /// <summary>
        /// Accepted semantic exclusions; absent from the goal denominator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ineligibleCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long IneligibleCallCount { get; set; }

        /// <summary>
        /// No accepted eligibility decision, including technical or privacy exclusions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unassessedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UnassessedCallCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalMetCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long GoalMetCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalNotMetCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long GoalNotMetCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluatedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EvaluatedCallCount { get; set; }

        /// <summary>
        /// Accepted current-goal results, including ineligible; independent of issue processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analyzedCallCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long AnalyzedCallCount { get; set; }

        /// <summary>
        /// Goal-met / evaluatedCallCount; omitted when there are no binary outcomes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalMetRate")]
        public double? GoalMetRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalNotMetRate")]
        public double? GoalNotMetRate { get; set; }

        /// <summary>
        /// The version the calls ran on; null groups the calls that ran on no version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionId")]
        public global::System.Guid? AssistantVersionId { get; set; }

        /// <summary>
        /// The version's label, such as v3; absent for calls on no version or whose label was unavailable at registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        public string? AssistantVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalVersionSummaryDTO" /> class.
        /// </summary>
        /// <param name="registeredCallCount"></param>
        /// <param name="eligibleCallCount">
        /// Calls with an accepted semantic eligibility decision and binary goal outcome.
        /// </param>
        /// <param name="ineligibleCallCount">
        /// Accepted semantic exclusions; absent from the goal denominator.
        /// </param>
        /// <param name="unassessedCallCount">
        /// No accepted eligibility decision, including technical or privacy exclusions.
        /// </param>
        /// <param name="goalMetCount"></param>
        /// <param name="goalNotMetCount"></param>
        /// <param name="evaluatedCallCount"></param>
        /// <param name="analyzedCallCount">
        /// Accepted current-goal results, including ineligible; independent of issue processing.
        /// </param>
        /// <param name="goalMetRate">
        /// Goal-met / evaluatedCallCount; omitted when there are no binary outcomes.
        /// </param>
        /// <param name="goalNotMetRate"></param>
        /// <param name="assistantVersionId">
        /// The version the calls ran on; null groups the calls that ran on no version.
        /// </param>
        /// <param name="assistantVersion">
        /// The version's label, such as v3; absent for calls on no version or whose label was unavailable at registration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardGoalVersionSummaryDTO(
            long registeredCallCount,
            long eligibleCallCount,
            long ineligibleCallCount,
            long unassessedCallCount,
            long goalMetCount,
            long goalNotMetCount,
            long evaluatedCallCount,
            long analyzedCallCount,
            double? goalMetRate,
            double? goalNotMetRate,
            global::System.Guid? assistantVersionId,
            string? assistantVersion)
        {
            this.RegisteredCallCount = registeredCallCount;
            this.EligibleCallCount = eligibleCallCount;
            this.IneligibleCallCount = ineligibleCallCount;
            this.UnassessedCallCount = unassessedCallCount;
            this.GoalMetCount = goalMetCount;
            this.GoalNotMetCount = goalNotMetCount;
            this.EvaluatedCallCount = evaluatedCallCount;
            this.AnalyzedCallCount = analyzedCallCount;
            this.GoalMetRate = goalMetRate;
            this.GoalNotMetRate = goalNotMetRate;
            this.AssistantVersionId = assistantVersionId;
            this.AssistantVersion = assistantVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalVersionSummaryDTO" /> class.
        /// </summary>
        public CallHealthDashboardGoalVersionSummaryDTO()
        {
        }

    }
}