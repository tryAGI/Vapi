
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is a built-in metric to evaluate instead of a structured output. Mutually exclusive with structuredOutputId<br/>
    /// and structuredOutput, and only available on a scenario with `transcriptReplay`, which takes no other evaluations.<br/>
    /// - wer: the word error rate of the replayed recording's transcript against the answer key, as a fraction where 0<br/>
    ///   is perfect and 0.1 is 10%; insertions can push it above 1. `value` must be from 0 to 1. For example,<br/>
    ///   `{ "metric": "wer", "comparator": "&lt;=", "value": 0.1 }`.<br/>
    /// Example: wer
    /// </summary>
    public enum EvaluationPlanItemMetric
    {
        /// <summary>
        /// the word error rate of the replayed recording's transcript against the answer key, as a fraction where 0
        /// </summary>
        Wer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationPlanItemMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationPlanItemMetric value)
        {
            return value switch
            {
                EvaluationPlanItemMetric.Wer => "wer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationPlanItemMetric? ToEnum(string value)
        {
            return value switch
            {
                "wer" => EvaluationPlanItemMetric.Wer,
                _ => null,
            };
        }
    }
}