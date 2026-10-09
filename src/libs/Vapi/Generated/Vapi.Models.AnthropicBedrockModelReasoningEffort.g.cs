
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Reasoning effort for claude-haiku-5-5. `none` turns thinking off. `low` to `max`<br/>
    /// use adaptive thinking at that effort; higher effort can add latency before the<br/>
    /// model speaks. Unset means `none`. Rejected for every other model.
    /// </summary>
    public enum AnthropicBedrockModelReasoningEffort
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
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
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
    public static class AnthropicBedrockModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBedrockModelReasoningEffort value)
        {
            return value switch
            {
                AnthropicBedrockModelReasoningEffort.High => "high",
                AnthropicBedrockModelReasoningEffort.Low => "low",
                AnthropicBedrockModelReasoningEffort.Max => "max",
                AnthropicBedrockModelReasoningEffort.Medium => "medium",
                AnthropicBedrockModelReasoningEffort.None => "none",
                AnthropicBedrockModelReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBedrockModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicBedrockModelReasoningEffort.High,
                "low" => AnthropicBedrockModelReasoningEffort.Low,
                "max" => AnthropicBedrockModelReasoningEffort.Max,
                "medium" => AnthropicBedrockModelReasoningEffort.Medium,
                "none" => AnthropicBedrockModelReasoningEffort.None,
                "xhigh" => AnthropicBedrockModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}