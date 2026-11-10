
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantGoalDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssistantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GoalId { get; set; }

        /// <summary>
        /// Committed decimal bigint revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GoalVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeedsWhen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SucceedsWhen { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaveOut")]
        public string? LeaveOut { get; set; }

        /// <summary>
        /// Committed goal-change time anchoring its fixed backfill window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantGoalDTO" /> class.
        /// </summary>
        /// <param name="orgId"></param>
        /// <param name="assistantId"></param>
        /// <param name="goalId"></param>
        /// <param name="goalVersion">
        /// Committed decimal bigint revision.
        /// </param>
        /// <param name="succeedsWhen"></param>
        /// <param name="createdAt">
        /// Committed goal-change time anchoring its fixed backfill window.
        /// </param>
        /// <param name="leaveOut"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantGoalDTO(
            global::System.Guid orgId,
            global::System.Guid assistantId,
            global::System.Guid goalId,
            string goalVersion,
            string succeedsWhen,
            global::System.DateTime createdAt,
            string? leaveOut)
        {
            this.OrgId = orgId;
            this.AssistantId = assistantId;
            this.GoalId = goalId;
            this.GoalVersion = goalVersion ?? throw new global::System.ArgumentNullException(nameof(goalVersion));
            this.SucceedsWhen = succeedsWhen ?? throw new global::System.ArgumentNullException(nameof(succeedsWhen));
            this.LeaveOut = leaveOut;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantGoalDTO" /> class.
        /// </summary>
        public AssistantGoalDTO()
        {
        }

    }
}