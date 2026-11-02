
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Reasoning effort for the judge on claude-haiku-5-5. `none` turns thinking<br/>
    /// off. `low` to `max` let the judge think before it submits its verdict.<br/>
    /// Unset means `none`. Rejected for every other model.
    /// </summary>
    public enum EvalAnthropicModelReasoningEffort
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
    public static class EvalAnthropicModelReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalAnthropicModelReasoningEffort value)
        {
            return value switch
            {
                EvalAnthropicModelReasoningEffort.High => "high",
                EvalAnthropicModelReasoningEffort.Low => "low",
                EvalAnthropicModelReasoningEffort.Max => "max",
                EvalAnthropicModelReasoningEffort.Medium => "medium",
                EvalAnthropicModelReasoningEffort.None => "none",
                EvalAnthropicModelReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalAnthropicModelReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => EvalAnthropicModelReasoningEffort.High,
                "low" => EvalAnthropicModelReasoningEffort.Low,
                "max" => EvalAnthropicModelReasoningEffort.Max,
                "medium" => EvalAnthropicModelReasoningEffort.Medium,
                "none" => EvalAnthropicModelReasoningEffort.None,
                "xhigh" => EvalAnthropicModelReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}