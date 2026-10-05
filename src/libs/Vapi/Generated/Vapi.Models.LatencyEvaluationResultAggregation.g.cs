
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is how the per-turn latencies were aggregated.
    /// </summary>
    public enum LatencyEvaluationResultAggregation
    {
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Mean,
        /// <summary>
        ///
        /// </summary>
        Median,
        /// <summary>
        ///
        /// </summary>
        P95,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LatencyEvaluationResultAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LatencyEvaluationResultAggregation value)
        {
            return value switch
            {
                LatencyEvaluationResultAggregation.Max => "max",
                LatencyEvaluationResultAggregation.Mean => "mean",
                LatencyEvaluationResultAggregation.Median => "median",
                LatencyEvaluationResultAggregation.P95 => "p95",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LatencyEvaluationResultAggregation? ToEnum(string value)
        {
            return value switch
            {
                "max" => LatencyEvaluationResultAggregation.Max,
                "mean" => LatencyEvaluationResultAggregation.Mean,
                "median" => LatencyEvaluationResultAggregation.Median,
                "p95" => LatencyEvaluationResultAggregation.P95,
                _ => null,
            };
        }
    }
}