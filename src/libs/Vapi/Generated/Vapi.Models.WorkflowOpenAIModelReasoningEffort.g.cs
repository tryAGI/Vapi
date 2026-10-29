
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the reasoning effort for structured output extraction. It applies to the primary extraction attempt only; the GPT-4.1 and Gemini fallbacks run without it. Other features that use this model type ignore it.<br/>
    /// Only reasoning models accept it, and each accepts only the efforts OpenAI supports for it (for example `none` and `xhigh` on gpt-5.6, `minimal` on gpt-5). When unset, OpenAI's default effort for the model applies, except on GPT-6 models, which Vapi sends with `none`.<br/>
    /// Reasoning tokens are billed as output tokens.
    /// </summary>
    public enum WorkflowOpenAIModelReasoningEffort
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowOpenAIModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowOpenAIModelReasoningEffort value)
        {
            return value switch
            {
                WorkflowOpenAIModelReasoningEffort.High => "high",
                WorkflowOpenAIModelReasoningEffort.Low => "low",
                WorkflowOpenAIModelReasoningEffort.Medium => "medium",
                WorkflowOpenAIModelReasoningEffort.Minimal => "minimal",
                WorkflowOpenAIModelReasoningEffort.None => "none",
                WorkflowOpenAIModelReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowOpenAIModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => WorkflowOpenAIModelReasoningEffort.High,
                "low" => WorkflowOpenAIModelReasoningEffort.Low,
                "medium" => WorkflowOpenAIModelReasoningEffort.Medium,
                "minimal" => WorkflowOpenAIModelReasoningEffort.Minimal,
                "none" => WorkflowOpenAIModelReasoningEffort.None,
                "xhigh" => WorkflowOpenAIModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}