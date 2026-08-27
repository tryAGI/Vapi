
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignControllerGetCampaignV2ContactsStatu
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
    public static class CampaignControllerGetCampaignV2ContactsStatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignControllerGetCampaignV2ContactsStatu value)
        {
            return value switch
            {
                CampaignControllerGetCampaignV2ContactsStatu.ContactCompleted => "contact.completed",
                CampaignControllerGetCampaignV2ContactsStatu.ContactDispatched => "contact.dispatched",
                CampaignControllerGetCampaignV2ContactsStatu.ContactFailed => "contact.failed",
                CampaignControllerGetCampaignV2ContactsStatu.ContactPending => "contact.pending",
                CampaignControllerGetCampaignV2ContactsStatu.ContactPredialFailed => "contact.predial-failed",
                CampaignControllerGetCampaignV2ContactsStatu.ContactSkipped => "contact.skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignControllerGetCampaignV2ContactsStatu? ToEnum(string value)
        {
            return value switch
            {
                "contact.completed" => CampaignControllerGetCampaignV2ContactsStatu.ContactCompleted,
                "contact.dispatched" => CampaignControllerGetCampaignV2ContactsStatu.ContactDispatched,
                "contact.failed" => CampaignControllerGetCampaignV2ContactsStatu.ContactFailed,
                "contact.pending" => CampaignControllerGetCampaignV2ContactsStatu.ContactPending,
                "contact.predial-failed" => CampaignControllerGetCampaignV2ContactsStatu.ContactPredialFailed,
                "contact.skipped" => CampaignControllerGetCampaignV2ContactsStatu.ContactSkipped,
                _ => null,
            };
        }
    }
}