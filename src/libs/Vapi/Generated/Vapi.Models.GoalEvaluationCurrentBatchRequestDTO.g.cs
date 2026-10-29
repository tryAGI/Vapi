
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoalEvaluationCurrentBatchRequestDTO
    {
        /// <summary>
        /// Explicit call/goal pairs. The organization comes from the authenticated caller.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.GoalEvaluationCurrentCallRequestDTO> Evaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentBatchRequestDTO" /> class.
        /// </summary>
        /// <param name="evaluations">
        /// Explicit call/goal pairs. The organization comes from the authenticated caller.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoalEvaluationCurrentBatchRequestDTO(
            global::System.Collections.Generic.IList<global::Vapi.GoalEvaluationCurrentCallRequestDTO> evaluations)
        {
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentBatchRequestDTO" /> class.
        /// </summary>
        public GoalEvaluationCurrentBatchRequestDTO()
        {
        }

    }
}