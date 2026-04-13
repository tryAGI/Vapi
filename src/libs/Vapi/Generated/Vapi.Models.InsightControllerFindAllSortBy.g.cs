
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum InsightControllerFindAllSortBy
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
    public static class InsightControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InsightControllerFindAllSortBy value)
        {
            return value switch
            {
                InsightControllerFindAllSortBy.Cost => "cost",
                InsightControllerFindAllSortBy.CreatedAt => "createdAt",
                InsightControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InsightControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => InsightControllerFindAllSortBy.Cost,
                "createdAt" => InsightControllerFindAllSortBy.CreatedAt,
                "duration" => InsightControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}