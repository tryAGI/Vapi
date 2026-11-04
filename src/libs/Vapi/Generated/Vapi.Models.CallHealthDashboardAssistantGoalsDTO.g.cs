
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantGoalsDTO
    {
        /// <summary>
        /// Requested assistant identity whose current published row remains visible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssistantId { get; set; }

        /// <summary>
        /// Empty when this visible assistant has no goals; no goal is automatically selected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goals")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalOptionDTO> Goals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantGoalsDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// Requested assistant identity whose current published row remains visible.
        /// </param>
        /// <param name="goals">
        /// Empty when this visible assistant has no goals; no goal is automatically selected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantGoalsDTO(
            global::System.Guid assistantId,
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardGoalOptionDTO> goals)
        {
            this.AssistantId = assistantId;
            this.Goals = goals ?? throw new global::System.ArgumentNullException(nameof(goals));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantGoalsDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantGoalsDTO()
        {
        }

    }
}