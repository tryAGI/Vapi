
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the SIP method to send (sip-request tool).
    /// </summary>
    public enum ToolDraftVerb
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
    public static class ToolDraftVerbExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDraftVerb value)
        {
            return value switch
            {
                ToolDraftVerb.Info => "INFO",
                ToolDraftVerb.Message => "MESSAGE",
                ToolDraftVerb.Notify => "NOTIFY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDraftVerb? ToEnum(string value)
        {
            return value switch
            {
                "INFO" => ToolDraftVerb.Info,
                "MESSAGE" => ToolDraftVerb.Message,
                "NOTIFY" => ToolDraftVerb.Notify,
                _ => null,
            };
        }
    }
}