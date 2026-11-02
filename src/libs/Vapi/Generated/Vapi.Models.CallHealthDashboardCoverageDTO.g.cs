
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AsOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intake")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardIntakeCoverageDTO Intake { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardGoalGapsDTO Goal { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardClassificationCoverageDTO Classification { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardAssignmentCoverageDTO Assignment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discovery")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardDiscoveryCoverageDTO Discovery { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sweep")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardSweepCoverageDTO Sweep { get; set; }

        /// <summary>
        /// Completeness of received authorized work only; never source delivery coverage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countsComplete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CountsComplete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardCoverageDTO" /> class.
        /// </summary>
        /// <param name="asOf"></param>
        /// <param name="intake"></param>
        /// <param name="goal"></param>
        /// <param name="classification"></param>
        /// <param name="assignment"></param>
        /// <param name="discovery"></param>
        /// <param name="sweep"></param>
        /// <param name="countsComplete">
        /// Completeness of received authorized work only; never source delivery coverage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardCoverageDTO(
            global::System.DateTime asOf,
            global::Vapi.CallHealthDashboardIntakeCoverageDTO intake,
            global::Vapi.CallHealthDashboardGoalGapsDTO goal,
            global::Vapi.CallHealthDashboardClassificationCoverageDTO classification,
            global::Vapi.CallHealthDashboardAssignmentCoverageDTO assignment,
            global::Vapi.CallHealthDashboardDiscoveryCoverageDTO discovery,
            global::Vapi.CallHealthDashboardSweepCoverageDTO sweep,
            bool countsComplete)
        {
            this.AsOf = asOf;
            this.Intake = intake ?? throw new global::System.ArgumentNullException(nameof(intake));
            this.Goal = goal ?? throw new global::System.ArgumentNullException(nameof(goal));
            this.Classification = classification ?? throw new global::System.ArgumentNullException(nameof(classification));
            this.Assignment = assignment ?? throw new global::System.ArgumentNullException(nameof(assignment));
            this.Discovery = discovery ?? throw new global::System.ArgumentNullException(nameof(discovery));
            this.Sweep = sweep ?? throw new global::System.ArgumentNullException(nameof(sweep));
            this.CountsComplete = countsComplete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardCoverageDTO()
        {
        }

    }
}