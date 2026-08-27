
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Set to 'cancelled' to stop the campaign ('ended' is a V1 alias). Scheduled<br/>
    /// calls are deleted; in-progress calls are allowed to finish.
    /// </summary>
    public enum UpdateCampaignDTOStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Ended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCampaignDTOStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCampaignDTOStatus value)
        {
            return value switch
            {
                UpdateCampaignDTOStatus.Cancelled => "cancelled",
                UpdateCampaignDTOStatus.Ended => "ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCampaignDTOStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => UpdateCampaignDTOStatus.Cancelled,
                "ended" => UpdateCampaignDTOStatus.Ended,
                _ => null,
            };
        }
    }
}