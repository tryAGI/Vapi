
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalControllerGetPaginatedSortBy
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
    public static class EvalControllerGetPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalControllerGetPaginatedSortBy value)
        {
            return value switch
            {
                EvalControllerGetPaginatedSortBy.Cost => "cost",
                EvalControllerGetPaginatedSortBy.CreatedAt => "createdAt",
                EvalControllerGetPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalControllerGetPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => EvalControllerGetPaginatedSortBy.Cost,
                "createdAt" => EvalControllerGetPaginatedSortBy.CreatedAt,
                "duration" => EvalControllerGetPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}