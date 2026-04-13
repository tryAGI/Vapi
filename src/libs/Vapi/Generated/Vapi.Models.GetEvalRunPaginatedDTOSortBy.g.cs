
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum GetEvalRunPaginatedDTOSortBy
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
    public static class GetEvalRunPaginatedDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetEvalRunPaginatedDTOSortBy value)
        {
            return value switch
            {
                GetEvalRunPaginatedDTOSortBy.Cost => "cost",
                GetEvalRunPaginatedDTOSortBy.CreatedAt => "createdAt",
                GetEvalRunPaginatedDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetEvalRunPaginatedDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetEvalRunPaginatedDTOSortBy.Cost,
                "createdAt" => GetEvalRunPaginatedDTOSortBy.CreatedAt,
                "duration" => GetEvalRunPaginatedDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}