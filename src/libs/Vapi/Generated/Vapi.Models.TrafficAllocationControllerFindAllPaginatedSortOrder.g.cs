
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficAllocationControllerFindAllPaginatedSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationControllerFindAllPaginatedSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationControllerFindAllPaginatedSortOrder value)
        {
            return value switch
            {
                TrafficAllocationControllerFindAllPaginatedSortOrder.Asc => "ASC",
                TrafficAllocationControllerFindAllPaginatedSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationControllerFindAllPaginatedSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => TrafficAllocationControllerFindAllPaginatedSortOrder.Asc,
                "DESC" => TrafficAllocationControllerFindAllPaginatedSortOrder.Desc,
                _ => null,
            };
        }
    }
}