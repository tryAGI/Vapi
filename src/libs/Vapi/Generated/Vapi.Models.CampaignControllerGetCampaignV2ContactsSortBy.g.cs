
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignControllerGetCampaignV2ContactsSortBy
    {
        /// <summary>
        /// 
        /// </summary>
        Position,
        /// <summary>
        /// 
        /// </summary>
        Status,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignControllerGetCampaignV2ContactsSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerGetCampaignV2ContactsSortBy value)
        {
            return value switch
            {
                CampaignControllerGetCampaignV2ContactsSortBy.Position => "position",
                CampaignControllerGetCampaignV2ContactsSortBy.Status => "status",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerGetCampaignV2ContactsSortBy? ToEnum(string value)
        {
            return value switch
            {
                "position" => CampaignControllerGetCampaignV2ContactsSortBy.Position,
                "status" => CampaignControllerGetCampaignV2ContactsSortBy.Status,
                _ => null,
            };
        }
    }
}