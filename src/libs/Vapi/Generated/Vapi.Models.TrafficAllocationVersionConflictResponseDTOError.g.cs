
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficAllocationVersionConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        VersionInGoverningAllocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationVersionConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationVersionConflictResponseDTOError value)
        {
            return value switch
            {
                TrafficAllocationVersionConflictResponseDTOError.VersionInGoverningAllocation => "version_in_governing_allocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationVersionConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "version_in_governing_allocation" => TrafficAllocationVersionConflictResponseDTOError.VersionInGoverningAllocation,
                _ => null,
            };
        }
    }
}