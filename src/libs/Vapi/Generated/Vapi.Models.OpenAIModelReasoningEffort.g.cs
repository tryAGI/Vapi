
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Reasoning effort for reasoning-capable OpenAI models.<br/>
    /// For `gpt-realtime-2`: forwarded to V2 stream's session.update as `reasoning.effort`.<br/>
    /// For non-realtime OpenAI models: routed through `modelSpecificOverridesGet` (openAIUtil.ts:622-726).<br/>
    /// Narrower than CompletionRequestParams.reasoningEffort intentionally: 'none' is an internal-only override value set by modelSpecificOverridesGet for GPT-5 family, not user-settable via DTO.
    /// </summary>
    public enum OpenAIModelReasoningEffort
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIModelReasoningEffort value)
        {
            return value switch
            {
                OpenAIModelReasoningEffort.High => "high",
                OpenAIModelReasoningEffort.Low => "low",
                OpenAIModelReasoningEffort.Medium => "medium",
                OpenAIModelReasoningEffort.Minimal => "minimal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIModelReasoningEffort.High,
                "low" => OpenAIModelReasoningEffort.Low,
                "medium" => OpenAIModelReasoningEffort.Medium,
                "minimal" => OpenAIModelReasoningEffort.Minimal,
                _ => null,
            };
        }
    }
}