
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalToolResponseMessageEvaluation
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For a tool response message evaluation, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </summary>
        /// <default>global::Vapi.ChatEvalToolResponseMessageEvaluationRole.Tool</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageEvaluationRoleJsonConverter))]
        public global::Vapi.ChatEvalToolResponseMessageEvaluationRole Role { get; set; } = global::Vapi.ChatEvalToolResponseMessageEvaluationRole.Tool;

        /// <summary>
        /// This is the judge plan that instructs how to evaluate the tool response message.<br/>
        /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judgePlan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.AssistantMessageJudgePlanAI JudgePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageEvaluation" /> class.
        /// </summary>
        /// <param name="judgePlan">
        /// This is the judge plan that instructs how to evaluate the tool response message.<br/>
        /// The tool response message can be evaluated with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </param>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For a tool response message evaluation, the role is always 'tool'<br/>
        /// @default 'tool'<br/>
        /// Default Value: tool
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvalToolResponseMessageEvaluation(
            global::Vapi.AssistantMessageJudgePlanAI judgePlan,
            global::Vapi.ChatEvalToolResponseMessageEvaluationRole role = global::Vapi.ChatEvalToolResponseMessageEvaluationRole.Tool)
        {
            this.Role = role;
            this.JudgePlan = judgePlan ?? throw new global::System.ArgumentNullException(nameof(judgePlan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalToolResponseMessageEvaluation" /> class.
        /// </summary>
        public ChatEvalToolResponseMessageEvaluation()
        {
        }
    }
}