
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderResourceControllerGetProviderResourcesPaginatedSortBy
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
    public static class ProviderResourceControllerGetProviderResourcesPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderResourceControllerGetProviderResourcesPaginatedSortBy value)
        {
            return value switch
            {
                ProviderResourceControllerGetProviderResourcesPaginatedSortBy.Cost => "cost",
                ProviderResourceControllerGetProviderResourcesPaginatedSortBy.CreatedAt => "createdAt",
                ProviderResourceControllerGetProviderResourcesPaginatedSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderResourceControllerGetProviderResourcesPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => ProviderResourceControllerGetProviderResourcesPaginatedSortBy.Cost,
                "createdAt" => ProviderResourceControllerGetProviderResourcesPaginatedSortBy.CreatedAt,
                "duration" => ProviderResourceControllerGetProviderResourcesPaginatedSortBy.Duration,
                _ => null,
            };
        }
    }
}