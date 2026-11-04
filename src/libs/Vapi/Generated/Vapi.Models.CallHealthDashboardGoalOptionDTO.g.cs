
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardGoalOptionDTO
    {
        /// <summary>
        /// Explicit selected goal identity, stable across its revisions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GoalId { get; set; }

        /// <summary>
        /// Current visible revision of the selected goal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeedsWhen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SucceedsWhen { get; set; }

        /// <summary>
        /// Current optional semantic exclusions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaveOut")]
        public string? LeaveOut { get; set; }

        /// <summary>
        /// Current revision for display; clients select by stable goalId, never by this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GoalVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalOptionDTO" /> class.
        /// </summary>
        /// <param name="goalId">
        /// Explicit selected goal identity, stable across its revisions.
        /// </param>
        /// <param name="succeedsWhen">
        /// Current visible revision of the selected goal.
        /// </param>
        /// <param name="goalVersion">
        /// Current revision for display; clients select by stable goalId, never by this version.
        /// </param>
        /// <param name="leaveOut">
        /// Current optional semantic exclusions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardGoalOptionDTO(
            global::System.Guid goalId,
            string succeedsWhen,
            string goalVersion,
            string? leaveOut)
        {
            this.GoalId = goalId;
            this.SucceedsWhen = succeedsWhen ?? throw new global::System.ArgumentNullException(nameof(succeedsWhen));
            this.LeaveOut = leaveOut;
            this.GoalVersion = goalVersion ?? throw new global::System.ArgumentNullException(nameof(goalVersion));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalOptionDTO" /> class.
        /// </summary>
        public CallHealthDashboardGoalOptionDTO()
        {
        }

    }
}