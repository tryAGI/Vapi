
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is how the call's per-turn latencies are aggregated before comparing.<br/>
    /// p95 uses the nearest-rank method, so on calls with fewer than 20 turns it<br/>
    /// equals the max.<br/>
    /// Example: median
    /// </summary>
    public enum LatencyExpectationAggregation
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
    public static class LatencyExpectationAggregationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LatencyExpectationAggregation value)
        {
            return value switch
            {
                LatencyExpectationAggregation.Max => "max",
                LatencyExpectationAggregation.Mean => "mean",
                LatencyExpectationAggregation.Median => "median",
                LatencyExpectationAggregation.P95 => "p95",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LatencyExpectationAggregation? ToEnum(string value)
        {
            return value switch
            {
                "max" => LatencyExpectationAggregation.Max,
                "mean" => LatencyExpectationAggregation.Mean,
                "median" => LatencyExpectationAggregation.Median,
                "p95" => LatencyExpectationAggregation.P95,
                _ => null,
            };
        }
    }
}