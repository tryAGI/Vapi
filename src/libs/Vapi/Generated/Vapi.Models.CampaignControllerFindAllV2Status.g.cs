
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignControllerFindAllV2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Archived,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Ended,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignControllerFindAllV2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerFindAllV2Status value)
        {
            return value switch
            {
                CampaignControllerFindAllV2Status.Archived => "archived",
                CampaignControllerFindAllV2Status.Cancelled => "cancelled",
                CampaignControllerFindAllV2Status.Ended => "ended",
                CampaignControllerFindAllV2Status.InProgress => "in-progress",
                CampaignControllerFindAllV2Status.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerFindAllV2Status? ToEnum(string value)
        {
            return value switch
            {
                "archived" => CampaignControllerFindAllV2Status.Archived,
                "cancelled" => CampaignControllerFindAllV2Status.Cancelled,
                "ended" => CampaignControllerFindAllV2Status.Ended,
                "in-progress" => CampaignControllerFindAllV2Status.InProgress,
                "scheduled" => CampaignControllerFindAllV2Status.Scheduled,
                _ => null,
            };
        }
    }
}