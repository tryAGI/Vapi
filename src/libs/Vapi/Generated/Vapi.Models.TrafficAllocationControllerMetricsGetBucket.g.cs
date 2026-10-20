
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficAllocationControllerMetricsGetBucket
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationControllerMetricsGetBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationControllerMetricsGetBucket value)
        {
            return value switch
            {
                TrafficAllocationControllerMetricsGetBucket.Day => "day",
                TrafficAllocationControllerMetricsGetBucket.Hour => "hour",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationControllerMetricsGetBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => TrafficAllocationControllerMetricsGetBucket.Day,
                "hour" => TrafficAllocationControllerMetricsGetBucket.Hour,
                _ => null,
            };
        }
    }
}