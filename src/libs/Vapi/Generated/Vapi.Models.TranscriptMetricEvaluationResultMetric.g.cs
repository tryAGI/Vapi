
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the metric evaluated.
    /// </summary>
    public enum TranscriptMetricEvaluationResultMetric
    {
        /// <summary>
        ///
        /// </summary>
        Wer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptMetricEvaluationResultMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptMetricEvaluationResultMetric value)
        {
            return value switch
            {
                TranscriptMetricEvaluationResultMetric.Wer => "wer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptMetricEvaluationResultMetric? ToEnum(string value)
        {
            return value switch
            {
                "wer" => TranscriptMetricEvaluationResultMetric.Wer,
                _ => null,
            };
        }
    }
}