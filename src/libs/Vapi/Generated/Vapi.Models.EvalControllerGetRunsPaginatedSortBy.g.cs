
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvalControllerGetRunsPaginatedSortBy
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
    public static class EvalControllerGetRunsPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalControllerGetRunsPaginatedSortBy value)
        {
            return value switch
            {
                EvalControllerGetRunsPaginatedSortBy.Cost => "cost",
                EvalControllerGetRunsPaginatedSortBy.CreatedAt => "createdAt",
                EvalControllerGetRunsPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalControllerGetRunsPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => EvalControllerGetRunsPaginatedSortBy.Cost,
                "createdAt" => EvalControllerGetRunsPaginatedSortBy.CreatedAt,
                "duration" => EvalControllerGetRunsPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}