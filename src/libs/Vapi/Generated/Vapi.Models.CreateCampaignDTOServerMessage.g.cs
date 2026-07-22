
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCampaignDTOServerMessage
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
    public static class CreateCampaignDTOServerMessageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCampaignDTOServerMessage value)
        {
            return value switch
            {
                CreateCampaignDTOServerMessage.CampaignArchived => "campaign.archived",
                CreateCampaignDTOServerMessage.CampaignCancelled => "campaign.cancelled",
                CreateCampaignDTOServerMessage.CampaignEnded => "campaign.ended",
                CreateCampaignDTOServerMessage.CampaignJobContinued => "campaign.job.continued",
                CreateCampaignDTOServerMessage.CampaignStarted => "campaign.started",
                CreateCampaignDTOServerMessage.CampaignUnarchived => "campaign.unarchived",
                CreateCampaignDTOServerMessage.ContactCompleted => "contact.completed",
                CreateCampaignDTOServerMessage.ContactDispatched => "contact.dispatched",
                CreateCampaignDTOServerMessage.ContactFailed => "contact.failed",
                CreateCampaignDTOServerMessage.ContactPredialFailed => "contact.predial-failed",
                CreateCampaignDTOServerMessage.ContactSkipped => "contact.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCampaignDTOServerMessage? ToEnum(string value)
        {
            return value switch
            {
                "campaign.archived" => CreateCampaignDTOServerMessage.CampaignArchived,
                "campaign.cancelled" => CreateCampaignDTOServerMessage.CampaignCancelled,
                "campaign.ended" => CreateCampaignDTOServerMessage.CampaignEnded,
                "campaign.job.continued" => CreateCampaignDTOServerMessage.CampaignJobContinued,
                "campaign.started" => CreateCampaignDTOServerMessage.CampaignStarted,
                "campaign.unarchived" => CreateCampaignDTOServerMessage.CampaignUnarchived,
                "contact.completed" => CreateCampaignDTOServerMessage.ContactCompleted,
                "contact.dispatched" => CreateCampaignDTOServerMessage.ContactDispatched,
                "contact.failed" => CreateCampaignDTOServerMessage.ContactFailed,
                "contact.predial-failed" => CreateCampaignDTOServerMessage.ContactPredialFailed,
                "contact.skipped" => CreateCampaignDTOServerMessage.ContactSkipped,
                _ => null,
            };
        }
    }
}