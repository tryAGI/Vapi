
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoalEvaluationCurrentDTO
    {
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
        /// Current immutable goal revision, encoded as a decimal bigint string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GoalVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callEndedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallEndedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GoalEvaluationCurrentDTOProcessingStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GoalEvaluationCurrentDTOProcessingState ProcessingState { get; set; }

        /// <summary>
        /// Absent until a semantic result is accepted. Processing failures are never goal_not_met.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalOutcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GoalEvaluationCurrentDTOGoalOutcomeJsonConverter))]
        public global::Vapi.GoalEvaluationCurrentDTOGoalOutcome? GoalOutcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentDTO" /> class.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="goalId"></param>
        /// <param name="goalVersion">
        /// Current immutable goal revision, encoded as a decimal bigint string.
        /// </param>
        /// <param name="callEndedAt"></param>
        /// <param name="processingState"></param>
        /// <param name="goalOutcome">
        /// Absent until a semantic result is accepted. Processing failures are never goal_not_met.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoalEvaluationCurrentDTO(
            global::System.Guid assistantId,
            global::System.Guid goalId,
            string goalVersion,
            global::System.DateTime callEndedAt,
            global::Vapi.GoalEvaluationCurrentDTOProcessingState processingState,
            global::Vapi.GoalEvaluationCurrentDTOGoalOutcome? goalOutcome)
        {
            this.AssistantId = assistantId;
            this.GoalId = goalId;
            this.GoalVersion = goalVersion ?? throw new global::System.ArgumentNullException(nameof(goalVersion));
            this.CallEndedAt = callEndedAt;
            this.ProcessingState = processingState;
            this.GoalOutcome = goalOutcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentDTO" /> class.
        /// </summary>
        public GoalEvaluationCurrentDTO()
        {
        }

    }
}