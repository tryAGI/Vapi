
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Bucket size for the timeseries. Defaults to 'day'.
    /// </summary>
    public enum GetTrafficTabMetricsDTOBucket
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
    public static class GetTrafficTabMetricsDTOBucketExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrafficTabMetricsDTOBucket value)
        {
            return value switch
            {
                GetTrafficTabMetricsDTOBucket.Day => "day",
                GetTrafficTabMetricsDTOBucket.Hour => "hour",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrafficTabMetricsDTOBucket? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetTrafficTabMetricsDTOBucket.Day,
                "hour" => GetTrafficTabMetricsDTOBucket.Hour,
                _ => null,
            };
        }
    }
}