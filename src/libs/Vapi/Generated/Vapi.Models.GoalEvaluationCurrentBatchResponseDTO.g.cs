
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GoalEvaluationCurrentBatchResponseDTO
    {
        /// <summary>
        /// One entry per requested call/goal pair, in request order, including entries without a current evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.GoalEvaluationCurrentCallResponseDTO> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentBatchResponseDTO" /> class.
        /// </summary>
        /// <param name="results">
        /// One entry per requested call/goal pair, in request order, including entries without a current evaluation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoalEvaluationCurrentBatchResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.GoalEvaluationCurrentCallResponseDTO> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoalEvaluationCurrentBatchResponseDTO" /> class.
        /// </summary>
        public GoalEvaluationCurrentBatchResponseDTO()
        {
        }

    }
}