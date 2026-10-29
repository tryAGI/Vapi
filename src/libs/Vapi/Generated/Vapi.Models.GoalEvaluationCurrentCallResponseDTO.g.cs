
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoalEvaluationCurrentCallResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GoalId { get; set; }

        /// <summary>
        /// Current revision of the requested goal for a visible call. Absent when that goal does not belong to the source assistant or the source is hidden. An absent evaluation does not imply queued or pending work.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentGoalVersion")]
        public string? CurrentGoalVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentEvaluation")]
        public global::Vapi.GoalEvaluationCurrentDTO? CurrentEvaluation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentCallResponseDTO" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="goalId"></param>
        /// <param name="currentGoalVersion">
        /// Current revision of the requested goal for a visible call. Absent when that goal does not belong to the source assistant or the source is hidden. An absent evaluation does not imply queued or pending work.
        /// </param>
        /// <param name="currentEvaluation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoalEvaluationCurrentCallResponseDTO(
            global::System.Guid callId,
            global::System.Guid goalId,
            string? currentGoalVersion,
            global::Vapi.GoalEvaluationCurrentDTO? currentEvaluation)
        {
            this.CallId = callId;
            this.GoalId = goalId;
            this.CurrentGoalVersion = currentGoalVersion;
            this.CurrentEvaluation = currentEvaluation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentCallResponseDTO" /> class.
        /// </summary>
        public GoalEvaluationCurrentCallResponseDTO()
        {
        }

    }
}