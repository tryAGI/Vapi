
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficAllocationStaleConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        StaleAllocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationStaleConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationStaleConflictResponseDTOError value)
        {
            return value switch
            {
                TrafficAllocationStaleConflictResponseDTOError.StaleAllocation => "stale_allocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationStaleConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "stale_allocation" => TrafficAllocationStaleConflictResponseDTOError.StaleAllocation,
                _ => null,
            };
        }
    }
}