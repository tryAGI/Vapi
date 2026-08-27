
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignControllerFindAllV2SortBy
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
    public static class CampaignControllerFindAllV2SortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllV2SortBy value)
        {
            return value switch
            {
                CampaignControllerFindAllV2SortBy.Cost => "cost",
                CampaignControllerFindAllV2SortBy.CreatedAt => "createdAt",
                CampaignControllerFindAllV2SortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllV2SortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => CampaignControllerFindAllV2SortBy.Cost,
                "createdAt" => CampaignControllerFindAllV2SortBy.CreatedAt,
                "duration" => CampaignControllerFindAllV2SortBy.Duration,
                _ => null,
            };
        }
    }
}