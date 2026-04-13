
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScorecardControllerGetPaginatedSortBy
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
    public static class ScorecardControllerGetPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScorecardControllerGetPaginatedSortBy value)
        {
            return value switch
            {
                ScorecardControllerGetPaginatedSortBy.Cost => "cost",
                ScorecardControllerGetPaginatedSortBy.CreatedAt => "createdAt",
                ScorecardControllerGetPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScorecardControllerGetPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ScorecardControllerGetPaginatedSortBy.Cost,
                "createdAt" => ScorecardControllerGetPaginatedSortBy.CreatedAt,
                "duration" => ScorecardControllerGetPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}