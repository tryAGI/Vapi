
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the comparison made: the metric's value on the left, `expectedValue` on the right.
    /// </summary>
    public enum TranscriptMetricEvaluationResultComparator
    {
        /// <summary>
        ///
        /// </summary>
        Eq,
        /// <summary>
        ///
        /// </summary>
        Gt,
        /// <summary>
        ///
        /// </summary>
        Gte,
        /// <summary>
        ///
        /// </summary>
        Lt,
        /// <summary>
        ///
        /// </summary>
        Lte,
        /// <summary>
        ///
        /// </summary>
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptMetricEvaluationResultComparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptMetricEvaluationResultComparator value)
        {
            return value switch
            {
                TranscriptMetricEvaluationResultComparator.Eq => "eq",
                TranscriptMetricEvaluationResultComparator.Gt => "gt",
                TranscriptMetricEvaluationResultComparator.Gte => "gte",
                TranscriptMetricEvaluationResultComparator.Lt => "lt",
                TranscriptMetricEvaluationResultComparator.Lte => "lte",
                TranscriptMetricEvaluationResultComparator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptMetricEvaluationResultComparator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => TranscriptMetricEvaluationResultComparator.Eq,
                "gt" => TranscriptMetricEvaluationResultComparator.Gt,
                "gte" => TranscriptMetricEvaluationResultComparator.Gte,
                "lt" => TranscriptMetricEvaluationResultComparator.Lt,
                "lte" => TranscriptMetricEvaluationResultComparator.Lte,
                "neq" => TranscriptMetricEvaluationResultComparator.Neq,
                _ => null,
            };
        }
    }
}