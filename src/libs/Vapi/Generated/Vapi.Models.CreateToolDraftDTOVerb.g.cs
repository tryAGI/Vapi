
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the SIP method to send (sip-request tool).
    /// </summary>
    public enum CreateToolDraftDTOVerb
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
    public static class CreateToolDraftDTOVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolDraftDTOVerb value)
        {
            return value switch
            {
                CreateToolDraftDTOVerb.Info => "INFO",
                CreateToolDraftDTOVerb.Message => "MESSAGE",
                CreateToolDraftDTOVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolDraftDTOVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => CreateToolDraftDTOVerb.Info,
                "MESSAGE" => CreateToolDraftDTOVerb.Message,
                "NOTIFY" => CreateToolDraftDTOVerb.Notify,
                _ => null,
            };
        }
    }
}