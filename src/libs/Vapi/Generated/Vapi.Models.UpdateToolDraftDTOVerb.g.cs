
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the SIP method to send (sip-request tool).
    /// </summary>
    public enum UpdateToolDraftDTOVerb
    {
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateToolDraftDTOVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolDraftDTOVerb value)
        {
            return value switch
            {
                UpdateToolDraftDTOVerb.Info => "INFO",
                UpdateToolDraftDTOVerb.Message => "MESSAGE",
                UpdateToolDraftDTOVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolDraftDTOVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => UpdateToolDraftDTOVerb.Info,
                "MESSAGE" => UpdateToolDraftDTOVerb.Message,
                "NOTIFY" => UpdateToolDraftDTOVerb.Notify,
                _ => null,
            };
        }
    }
}