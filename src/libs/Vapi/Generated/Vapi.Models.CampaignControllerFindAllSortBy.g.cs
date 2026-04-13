
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignControllerFindAllSortBy
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
    public static class CampaignControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllSortBy value)
        {
            return value switch
            {
                CampaignControllerFindAllSortBy.Cost => "cost",
                CampaignControllerFindAllSortBy.CreatedAt => "createdAt",
                CampaignControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CampaignControllerFindAllSortBy.Cost,
                "createdAt" => CampaignControllerFindAllSortBy.CreatedAt,
                "duration" => CampaignControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}