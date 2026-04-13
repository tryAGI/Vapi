
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum GetEvalPaginatedDTOSortBy
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
    public static class GetEvalPaginatedDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalPaginatedDTOSortBy value)
        {
            return value switch
            {
                GetEvalPaginatedDTOSortBy.Cost => "cost",
                GetEvalPaginatedDTOSortBy.CreatedAt => "createdAt",
                GetEvalPaginatedDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalPaginatedDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetEvalPaginatedDTOSortBy.Cost,
                "createdAt" => GetEvalPaginatedDTOSortBy.CreatedAt,
                "duration" => GetEvalPaginatedDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}