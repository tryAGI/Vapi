
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the tool.
    /// </summary>
    public enum ToolDraftType
    {
        /// <summary>
        ///
        /// </summary>
        ApiRequest,
        /// <summary>
        ///
        /// </summary>
        Bash,
        /// <summary>
        ///
        /// </summary>
        Code,
        /// <summary>
        ///
        /// </summary>
        Computer,
        /// <summary>
        ///
        /// </summary>
        Dtmf,
        /// <summary>
        ///
        /// </summary>
        EndCall,
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Ghl,
        /// <summary>
        ///
        /// </summary>
        GohighlevelCalendarAvailabilityCheck,
        /// <summary>
        ///
        /// </summary>
        GohighlevelCalendarEventCreate,
        /// <summary>
        ///
        /// </summary>
        GohighlevelContactCreate,
        /// <summary>
        ///
        /// </summary>
        GohighlevelContactGet,
        /// <summary>
        ///
        /// </summary>
        GoogleCalendarAvailabilityCheck,
        /// <summary>
        ///
        /// </summary>
        GoogleCalendarEventCreate,
        /// <summary>
        ///
        /// </summary>
        GoogleSheetsRowAppend,
        /// <summary>
        ///
        /// </summary>
        Handoff,
        /// <summary>
        ///
        /// </summary>
        KnowledgeBase,
        /// <summary>
        ///
        /// </summary>
        Make,
        /// <summary>
        ///
        /// </summary>
        Mcp,
        /// <summary>
        ///
        /// </summary>
        Output,
        /// <summary>
        ///
        /// </summary>
        Query,
        /// <summary>
        ///
        /// </summary>
        SipRequest,
        /// <summary>
        ///
        /// </summary>
        SlackMessageSend,
        /// <summary>
        ///
        /// </summary>
        Sms,
        /// <summary>
        ///
        /// </summary>
        TextEditor,
        /// <summary>
        ///
        /// </summary>
        TransferCall,
        /// <summary>
        ///
        /// </summary>
        TransferCancel,
        /// <summary>
        ///
        /// </summary>
        TransferSuccessful,
        /// <summary>
        ///
        /// </summary>
        Voicemail,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolDraftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDraftType value)
        {
            return value switch
            {
                ToolDraftType.ApiRequest => "apiRequest",
                ToolDraftType.Bash => "bash",
                ToolDraftType.Code => "code",
                ToolDraftType.Computer => "computer",
                ToolDraftType.Dtmf => "dtmf",
                ToolDraftType.EndCall => "endCall",
                ToolDraftType.Function => "function",
                ToolDraftType.Ghl => "ghl",
                ToolDraftType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                ToolDraftType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                ToolDraftType.GohighlevelContactCreate => "gohighlevel.contact.create",
                ToolDraftType.GohighlevelContactGet => "gohighlevel.contact.get",
                ToolDraftType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                ToolDraftType.GoogleCalendarEventCreate => "google.calendar.event.create",
                ToolDraftType.GoogleSheetsRowAppend => "google.sheets.row.append",
                ToolDraftType.Handoff => "handoff",
                ToolDraftType.KnowledgeBase => "knowledgeBase",
                ToolDraftType.Make => "make",
                ToolDraftType.Mcp => "mcp",
                ToolDraftType.Output => "output",
                ToolDraftType.Query => "query",
                ToolDraftType.SipRequest => "sipRequest",
                ToolDraftType.SlackMessageSend => "slack.message.send",
                ToolDraftType.Sms => "sms",
                ToolDraftType.TextEditor => "textEditor",
                ToolDraftType.TransferCall => "transferCall",
                ToolDraftType.TransferCancel => "transferCancel",
                ToolDraftType.TransferSuccessful => "transferSuccessful",
                ToolDraftType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDraftType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => ToolDraftType.ApiRequest,
                "bash" => ToolDraftType.Bash,
                "code" => ToolDraftType.Code,
                "computer" => ToolDraftType.Computer,
                "dtmf" => ToolDraftType.Dtmf,
                "endCall" => ToolDraftType.EndCall,
                "function" => ToolDraftType.Function,
                "ghl" => ToolDraftType.Ghl,
                "gohighlevel.calendar.availability.check" => ToolDraftType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => ToolDraftType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => ToolDraftType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => ToolDraftType.GohighlevelContactGet,
                "google.calendar.availability.check" => ToolDraftType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => ToolDraftType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => ToolDraftType.GoogleSheetsRowAppend,
                "handoff" => ToolDraftType.Handoff,
                "knowledgeBase" => ToolDraftType.KnowledgeBase,
                "make" => ToolDraftType.Make,
                "mcp" => ToolDraftType.Mcp,
                "output" => ToolDraftType.Output,
                "query" => ToolDraftType.Query,
                "sipRequest" => ToolDraftType.SipRequest,
                "slack.message.send" => ToolDraftType.SlackMessageSend,
                "sms" => ToolDraftType.Sms,
                "textEditor" => ToolDraftType.TextEditor,
                "transferCall" => ToolDraftType.TransferCall,
                "transferCancel" => ToolDraftType.TransferCancel,
                "transferSuccessful" => ToolDraftType.TransferSuccessful,
                "voicemail" => ToolDraftType.Voicemail,
                _ => null,
            };
        }
    }
}