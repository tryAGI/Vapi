
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignServerMessage
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
    public static class CampaignServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignServerMessage value)
        {
            return value switch
            {
                CampaignServerMessage.CampaignArchived => "campaign.archived",
                CampaignServerMessage.CampaignCancelled => "campaign.cancelled",
                CampaignServerMessage.CampaignEnded => "campaign.ended",
                CampaignServerMessage.CampaignJobContinued => "campaign.job.continued",
                CampaignServerMessage.CampaignStarted => "campaign.started",
                CampaignServerMessage.CampaignUnarchived => "campaign.unarchived",
                CampaignServerMessage.ContactCompleted => "contact.completed",
                CampaignServerMessage.ContactDispatched => "contact.dispatched",
                CampaignServerMessage.ContactFailed => "contact.failed",
                CampaignServerMessage.ContactPredialFailed => "contact.predial-failed",
                CampaignServerMessage.ContactSkipped => "contact.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "campaign.archived" => CampaignServerMessage.CampaignArchived,
                "campaign.cancelled" => CampaignServerMessage.CampaignCancelled,
                "campaign.ended" => CampaignServerMessage.CampaignEnded,
                "campaign.job.continued" => CampaignServerMessage.CampaignJobContinued,
                "campaign.started" => CampaignServerMessage.CampaignStarted,
                "campaign.unarchived" => CampaignServerMessage.CampaignUnarchived,
                "contact.completed" => CampaignServerMessage.ContactCompleted,
                "contact.dispatched" => CampaignServerMessage.ContactDispatched,
                "contact.failed" => CampaignServerMessage.ContactFailed,
                "contact.predial-failed" => CampaignServerMessage.ContactPredialFailed,
                "contact.skipped" => CampaignServerMessage.ContactSkipped,
                _ => null,
            };
        }
    }
}