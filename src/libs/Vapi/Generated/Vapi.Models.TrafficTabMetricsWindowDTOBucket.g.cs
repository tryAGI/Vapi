
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficTabMetricsWindowDTOBucket
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
    public static class TrafficTabMetricsWindowDTOBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficTabMetricsWindowDTOBucket value)
        {
            return value switch
            {
                TrafficTabMetricsWindowDTOBucket.Day => "day",
                TrafficTabMetricsWindowDTOBucket.Hour => "hour",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficTabMetricsWindowDTOBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => TrafficTabMetricsWindowDTOBucket.Day,
                "hour" => TrafficTabMetricsWindowDTOBucket.Hour,
                _ => null,
            };
        }
    }
}