
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 'explicit' splits calls across this allocation's targets. 'follow-latest' sends every call to the newest published version.
    /// </summary>
    public enum TrafficAllocationAllocationIntent
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        FollowLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationAllocationIntentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationAllocationIntent value)
        {
            return value switch
            {
                TrafficAllocationAllocationIntent.Explicit => "explicit",
                TrafficAllocationAllocationIntent.FollowLatest => "follow-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationAllocationIntent? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => TrafficAllocationAllocationIntent.Explicit,
                "follow-latest" => TrafficAllocationAllocationIntent.FollowLatest,
                _ => null,
            };
        }
    }
}