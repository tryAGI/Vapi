
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the status of the campaign.
    /// </summary>
    public enum CampaignSummaryStatus
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
    public static class CampaignSummaryStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignSummaryStatus value)
        {
            return value switch
            {
                CampaignSummaryStatus.Archived => "archived",
                CampaignSummaryStatus.Cancelled => "cancelled",
                CampaignSummaryStatus.Ended => "ended",
                CampaignSummaryStatus.InProgress => "in-progress",
                CampaignSummaryStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignSummaryStatus? ToEnum(string value)
        {
            return value switch
            {
                "archived" => CampaignSummaryStatus.Archived,
                "cancelled" => CampaignSummaryStatus.Cancelled,
                "ended" => CampaignSummaryStatus.Ended,
                "in-progress" => CampaignSummaryStatus.InProgress,
                "scheduled" => CampaignSummaryStatus.Scheduled,
                _ => null,
            };
        }
    }
}