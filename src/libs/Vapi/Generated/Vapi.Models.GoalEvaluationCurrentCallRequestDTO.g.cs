
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoalEvaluationCurrentCallRequestDTO
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentCallRequestDTO" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="goalId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoalEvaluationCurrentCallRequestDTO(
            global::System.Guid callId,
            global::System.Guid goalId)
        {
            this.CallId = callId;
            this.GoalId = goalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentCallRequestDTO" /> class.
        /// </summary>
        public GoalEvaluationCurrentCallRequestDTO()
        {
        }

    }
}