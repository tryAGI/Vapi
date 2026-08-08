
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CampaignContactWithOutcomeStatus
    {
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
        ContactPending,
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
    public static class CampaignContactWithOutcomeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignContactWithOutcomeStatus value)
        {
            return value switch
            {
                CampaignContactWithOutcomeStatus.ContactCompleted => "contact.completed",
                CampaignContactWithOutcomeStatus.ContactDispatched => "contact.dispatched",
                CampaignContactWithOutcomeStatus.ContactFailed => "contact.failed",
                CampaignContactWithOutcomeStatus.ContactPending => "contact.pending",
                CampaignContactWithOutcomeStatus.ContactPredialFailed => "contact.predial-failed",
                CampaignContactWithOutcomeStatus.ContactSkipped => "contact.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignContactWithOutcomeStatus? ToEnum(string value)
        {
            return value switch
            {
                "contact.completed" => CampaignContactWithOutcomeStatus.ContactCompleted,
                "contact.dispatched" => CampaignContactWithOutcomeStatus.ContactDispatched,
                "contact.failed" => CampaignContactWithOutcomeStatus.ContactFailed,
                "contact.pending" => CampaignContactWithOutcomeStatus.ContactPending,
                "contact.predial-failed" => CampaignContactWithOutcomeStatus.ContactPredialFailed,
                "contact.skipped" => CampaignContactWithOutcomeStatus.ContactSkipped,
                _ => null,
            };
        }
    }
}