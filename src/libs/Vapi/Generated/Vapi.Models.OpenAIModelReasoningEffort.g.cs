
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Reasoning effort for reasoning-capable OpenAI models.<br/>
    /// For `gpt-realtime-2`: forwarded to V2 stream's session.update as `reasoning.effort`.<br/>
    /// For non-realtime OpenAI models, model-aware validation limits newly public<br/>
    /// values while preserving the existing four-value storage contract.
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
                OpenAIModelReasoningEffort.None => "none",
                OpenAIModelReasoningEffort.Xhigh => "xhigh",
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
                "none" => OpenAIModelReasoningEffort.None,
                "xhigh" => OpenAIModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}