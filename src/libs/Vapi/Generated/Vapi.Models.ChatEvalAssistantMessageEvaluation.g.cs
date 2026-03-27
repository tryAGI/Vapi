
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatEvalAssistantMessageEvaluation
    {
        /// <summary>
        /// This is the role of the message author.<br/>
        /// For an assistant message evaluation, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </summary>
        /// <default>global::Vapi.ChatEvalAssistantMessageEvaluationRole.Assistant</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageEvaluationRoleJsonConverter))]
        public global::Vapi.ChatEvalAssistantMessageEvaluationRole Role { get; set; } = global::Vapi.ChatEvalAssistantMessageEvaluationRole.Assistant;

        /// <summary>
        /// This is the judge plan that instructs how to evaluate the assistant message.<br/>
        /// The assistant message can be evaluated against fixed content (exact match or RegEx) or with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("judgePlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI> JudgePlan { get; set; }

        /// <summary>
        /// This is the plan for how the overall evaluation will proceed after the assistant message is evaluated.<br/>
        /// This lets you configure whether to stop the evaluation if this message fails, and whether to override any content for future turns
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuePlan")]
        public global::Vapi.AssistantMessageEvaluationContinuePlan? ContinuePlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageEvaluation" /> class.
        /// </summary>
        /// <param name="role">
        /// This is the role of the message author.<br/>
        /// For an assistant message evaluation, the role is always 'assistant'<br/>
        /// @default 'assistant'<br/>
        /// Default Value: assistant
        /// </param>
        /// <param name="judgePlan">
        /// This is the judge plan that instructs how to evaluate the assistant message.<br/>
        /// The assistant message can be evaluated against fixed content (exact match or RegEx) or with an LLM-as-judge by defining the evaluation criteria in a prompt.
        /// </param>
        /// <param name="continuePlan">
        /// This is the plan for how the overall evaluation will proceed after the assistant message is evaluated.<br/>
        /// This lets you configure whether to stop the evaluation if this message fails, and whether to override any content for future turns
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatEvalAssistantMessageEvaluation(
            global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI> judgePlan,
            global::Vapi.AssistantMessageEvaluationContinuePlan? continuePlan,
            global::Vapi.ChatEvalAssistantMessageEvaluationRole role = global::Vapi.ChatEvalAssistantMessageEvaluationRole.Assistant)
        {
            this.JudgePlan = judgePlan;
            this.Role = role;
            this.ContinuePlan = continuePlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatEvalAssistantMessageEvaluation" /> class.
        /// </summary>
        public ChatEvalAssistantMessageEvaluation()
        {
        }
    }
}