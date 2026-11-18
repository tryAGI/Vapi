
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardGoalCallDTO
    {
        /// <summary>
        /// The call this row reports the goal result for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CallId { get; set; }

        /// <summary>
        /// Call completion time (endedAt), never startedAt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallTime { get; set; }

        /// <summary>
        /// Current goal revision the result belongs to; the list returns no other revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GoalVersion { get; set; }

        /// <summary>
        /// Where this call's evaluation under goalVersion stands.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processingState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardGoalCallDTOProcessingStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardGoalCallDTOProcessingState ProcessingState { get; set; }

        /// <summary>
        /// Absent until a result is accepted; a processing failure is never goal_not_met.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalOutcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardGoalCallDTOGoalOutcomeJsonConverter))]
        public global::Vapi.CallHealthDashboardGoalCallDTOGoalOutcome? GoalOutcome { get; set; }

        /// <summary>
        /// The assistant version the call ran on; absent when it ran on none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionId")]
        public global::System.Guid? AssistantVersionId { get; set; }

        /// <summary>
        /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        public string? AssistantVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallDTO" /> class.
        /// </summary>
        /// <param name="callId">
        /// The call this row reports the goal result for.
        /// </param>
        /// <param name="callTime">
        /// Call completion time (endedAt), never startedAt.
        /// </param>
        /// <param name="goalVersion">
        /// Current goal revision the result belongs to; the list returns no other revision.
        /// </param>
        /// <param name="processingState">
        /// Where this call's evaluation under goalVersion stands.
        /// </param>
        /// <param name="goalOutcome">
        /// Absent until a result is accepted; a processing failure is never goal_not_met.
        /// </param>
        /// <param name="assistantVersionId">
        /// The assistant version the call ran on; absent when it ran on none.
        /// </param>
        /// <param name="assistantVersion">
        /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardGoalCallDTO(
            global::System.Guid callId,
            global::System.DateTime callTime,
            string goalVersion,
            global::Vapi.CallHealthDashboardGoalCallDTOProcessingState processingState,
            global::Vapi.CallHealthDashboardGoalCallDTOGoalOutcome? goalOutcome,
            global::System.Guid? assistantVersionId,
            string? assistantVersion)
        {
            this.CallId = callId;
            this.CallTime = callTime;
            this.GoalVersion = goalVersion ?? throw new global::System.ArgumentNullException(nameof(goalVersion));
            this.ProcessingState = processingState;
            this.GoalOutcome = goalOutcome;
            this.AssistantVersionId = assistantVersionId;
            this.AssistantVersion = assistantVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallDTO" /> class.
        /// </summary>
        public CallHealthDashboardGoalCallDTO()
        {
        }

    }
}