
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignControllerFindAllV2SortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignControllerFindAllV2SortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllV2SortOrder value)
        {
            return value switch
            {
                CampaignControllerFindAllV2SortOrder.Asc => "ASC",
                CampaignControllerFindAllV2SortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllV2SortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => CampaignControllerFindAllV2SortOrder.Asc,
                "DESC" => CampaignControllerFindAllV2SortOrder.Desc,
                _ => null,
            };
        }
    }
}