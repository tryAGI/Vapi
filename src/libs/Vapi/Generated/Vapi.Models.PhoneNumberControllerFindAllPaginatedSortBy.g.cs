
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum PhoneNumberControllerFindAllPaginatedSortBy
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
    public static class PhoneNumberControllerFindAllPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PhoneNumberControllerFindAllPaginatedSortBy value)
        {
            return value switch
            {
                PhoneNumberControllerFindAllPaginatedSortBy.Cost => "cost",
                PhoneNumberControllerFindAllPaginatedSortBy.CreatedAt => "createdAt",
                PhoneNumberControllerFindAllPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PhoneNumberControllerFindAllPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => PhoneNumberControllerFindAllPaginatedSortBy.Cost,
                "createdAt" => PhoneNumberControllerFindAllPaginatedSortBy.CreatedAt,
                "duration" => PhoneNumberControllerFindAllPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}