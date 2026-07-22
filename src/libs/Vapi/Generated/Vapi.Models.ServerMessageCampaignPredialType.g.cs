
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the message. "campaign.predial" is sent to the campaign's server before each contact is dialed, so the server can decide whether the contact is eligible to be called. It is only sent when the campaign's `predialPlan` is set (and not disabled).
    /// </summary>
    public enum ServerMessageCampaignPredialType
    {
        /// <summary>
        /// 
        /// </summary>
        CampaignPredial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessageCampaignPredialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessageCampaignPredialType value)
        {
            return value switch
            {
                ServerMessageCampaignPredialType.CampaignPredial => "campaign.predial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessageCampaignPredialType? ToEnum(string value)
        {
            return value switch
            {
                "campaign.predial" => ServerMessageCampaignPredialType.CampaignPredial,
                _ => null,
            };
        }
    }
}