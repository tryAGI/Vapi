
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantOverviewDTO
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantOverviewDTO" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantOverviewDTO(
            global::Vapi.CallHealthDashboardAssistantReferenceDTO assistant,
            global::Vapi.CallHealthDashboardGoalDefinitionDTO goalDefinition,
            global::Vapi.CallHealthDashboardGoalSummaryDTO goal)
        {
            this.Assistant = assistant ?? throw new global::System.ArgumentNullException(nameof(assistant));
            this.GoalDefinition = goalDefinition ?? throw new global::System.ArgumentNullException(nameof(goalDefinition));
            this.Goal = goal ?? throw new global::System.ArgumentNullException(nameof(goal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantOverviewDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantOverviewDTO()
        {
        }

    }
}