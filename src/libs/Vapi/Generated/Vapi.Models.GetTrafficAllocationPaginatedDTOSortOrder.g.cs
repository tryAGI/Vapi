
#nullable enable

namespace Vapi
{
    /// <summary>
    /// The sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    public enum GetTrafficAllocationPaginatedDTOSortOrder
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
    public static class GetTrafficAllocationPaginatedDTOSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrafficAllocationPaginatedDTOSortOrder value)
        {
            return value switch
            {
                GetTrafficAllocationPaginatedDTOSortOrder.Asc => "ASC",
                GetTrafficAllocationPaginatedDTOSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrafficAllocationPaginatedDTOSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => GetTrafficAllocationPaginatedDTOSortOrder.Asc,
                "DESC" => GetTrafficAllocationPaginatedDTOSortOrder.Desc,
                _ => null,
            };
        }
    }
}