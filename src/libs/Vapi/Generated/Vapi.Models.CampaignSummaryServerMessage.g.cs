
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignSummaryServerMessage
    {
        /// <summary>
        ///
        /// </summary>
        CampaignArchived,
        /// <summary>
        ///
        /// </summary>
        CampaignCancelled,
        /// <summary>
        ///
        /// </summary>
        CampaignEnded,
        /// <summary>
        ///
        /// </summary>
        CampaignJobContinued,
        /// <summary>
        ///
        /// </summary>
        CampaignStarted,
        /// <summary>
        ///
        /// </summary>
        CampaignUnarchived,
        /// <summary>
        ///
        /// </summary>
        ContactCompleted,
        /// <summary>
        ///
        /// </summary>
        ContactDispatched,
        /// <summary>
        ///
        /// </summary>
        ContactFailed,
        /// <summary>
        ///
        /// </summary>
        ContactPredialFailed,
        /// <summary>
        ///
        /// </summary>
        ContactSkipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignSummaryServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignSummaryServerMessage value)
        {
            return value switch
            {
                CampaignSummaryServerMessage.CampaignArchived => "campaign.archived",
                CampaignSummaryServerMessage.CampaignCancelled => "campaign.cancelled",
                CampaignSummaryServerMessage.CampaignEnded => "campaign.ended",
                CampaignSummaryServerMessage.CampaignJobContinued => "campaign.job.continued",
                CampaignSummaryServerMessage.CampaignStarted => "campaign.started",
                CampaignSummaryServerMessage.CampaignUnarchived => "campaign.unarchived",
                CampaignSummaryServerMessage.ContactCompleted => "contact.completed",
                CampaignSummaryServerMessage.ContactDispatched => "contact.dispatched",
                CampaignSummaryServerMessage.ContactFailed => "contact.failed",
                CampaignSummaryServerMessage.ContactPredialFailed => "contact.predial-failed",
                CampaignSummaryServerMessage.ContactSkipped => "contact.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignSummaryServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "campaign.archived" => CampaignSummaryServerMessage.CampaignArchived,
                "campaign.cancelled" => CampaignSummaryServerMessage.CampaignCancelled,
                "campaign.ended" => CampaignSummaryServerMessage.CampaignEnded,
                "campaign.job.continued" => CampaignSummaryServerMessage.CampaignJobContinued,
                "campaign.started" => CampaignSummaryServerMessage.CampaignStarted,
                "campaign.unarchived" => CampaignSummaryServerMessage.CampaignUnarchived,
                "contact.completed" => CampaignSummaryServerMessage.ContactCompleted,
                "contact.dispatched" => CampaignSummaryServerMessage.ContactDispatched,
                "contact.failed" => CampaignSummaryServerMessage.ContactFailed,
                "contact.predial-failed" => CampaignSummaryServerMessage.ContactPredialFailed,
                "contact.skipped" => CampaignSummaryServerMessage.ContactSkipped,
                _ => null,
            };
        }
    }
}