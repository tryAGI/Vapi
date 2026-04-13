
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum GetSessionPaginatedDTOSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSessionPaginatedDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSessionPaginatedDTOSortBy value)
        {
            return value switch
            {
                GetSessionPaginatedDTOSortBy.Cost => "cost",
                GetSessionPaginatedDTOSortBy.CreatedAt => "createdAt",
                GetSessionPaginatedDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSessionPaginatedDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetSessionPaginatedDTOSortBy.Cost,
                "createdAt" => GetSessionPaginatedDTOSortBy.CreatedAt,
                "duration" => GetSessionPaginatedDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}