
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionControllerFindAllPaginatedSortBy
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
    public static class SessionControllerFindAllPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionControllerFindAllPaginatedSortBy value)
        {
            return value switch
            {
                SessionControllerFindAllPaginatedSortBy.Cost => "cost",
                SessionControllerFindAllPaginatedSortBy.CreatedAt => "createdAt",
                SessionControllerFindAllPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionControllerFindAllPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => SessionControllerFindAllPaginatedSortBy.Cost,
                "createdAt" => SessionControllerFindAllPaginatedSortBy.CreatedAt,
                "duration" => SessionControllerFindAllPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}