
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    public enum GetChatPaginatedDTOSortBy
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
    public static class GetChatPaginatedDTOSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChatPaginatedDTOSortBy value)
        {
            return value switch
            {
                GetChatPaginatedDTOSortBy.Cost => "cost",
                GetChatPaginatedDTOSortBy.CreatedAt => "createdAt",
                GetChatPaginatedDTOSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChatPaginatedDTOSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => GetChatPaginatedDTOSortBy.Cost,
                "createdAt" => GetChatPaginatedDTOSortBy.CreatedAt,
                "duration" => GetChatPaginatedDTOSortBy.Duration,
                _ => null,
            };
        }
    }
}