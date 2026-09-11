
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Higher effort can increase response time. Omit to use low.<br/>
    /// Default Value: low
    /// </summary>
    public enum OpenAIReasonerReasoningEffort
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
    public static class OpenAIReasonerReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIReasonerReasoningEffort value)
        {
            return value switch
            {
                OpenAIReasonerReasoningEffort.High => "high",
                OpenAIReasonerReasoningEffort.Low => "low",
                OpenAIReasonerReasoningEffort.Max => "max",
                OpenAIReasonerReasoningEffort.Medium => "medium",
                OpenAIReasonerReasoningEffort.None => "none",
                OpenAIReasonerReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIReasonerReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIReasonerReasoningEffort.High,
                "low" => OpenAIReasonerReasoningEffort.Low,
                "max" => OpenAIReasonerReasoningEffort.Max,
                "medium" => OpenAIReasonerReasoningEffort.Medium,
                "none" => OpenAIReasonerReasoningEffort.None,
                "xhigh" => OpenAIReasonerReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}