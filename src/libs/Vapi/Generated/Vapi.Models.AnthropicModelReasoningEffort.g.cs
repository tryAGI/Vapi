
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Reasoning effort for claude-haiku-5-5. `none` turns thinking off. `low` to `max`<br/>
    /// use adaptive thinking at that effort; higher effort can add latency before the<br/>
    /// model speaks. Unset means `none`. Rejected for every other model.
    /// </summary>
    public enum AnthropicModelReasoningEffort
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
    public static class AnthropicModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicModelReasoningEffort value)
        {
            return value switch
            {
                AnthropicModelReasoningEffort.High => "high",
                AnthropicModelReasoningEffort.Low => "low",
                AnthropicModelReasoningEffort.Max => "max",
                AnthropicModelReasoningEffort.Medium => "medium",
                AnthropicModelReasoningEffort.None => "none",
                AnthropicModelReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => AnthropicModelReasoningEffort.High,
                "low" => AnthropicModelReasoningEffort.Low,
                "max" => AnthropicModelReasoningEffort.Max,
                "medium" => AnthropicModelReasoningEffort.Medium,
                "none" => AnthropicModelReasoningEffort.None,
                "xhigh" => AnthropicModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}