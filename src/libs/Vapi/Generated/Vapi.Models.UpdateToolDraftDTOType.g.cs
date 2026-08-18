
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the tool.
    /// </summary>
    public enum UpdateToolDraftDTOType
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
    public static class UpdateToolDraftDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolDraftDTOType value)
        {
            return value switch
            {
                UpdateToolDraftDTOType.ApiRequest => "apiRequest",
                UpdateToolDraftDTOType.Bash => "bash",
                UpdateToolDraftDTOType.Code => "code",
                UpdateToolDraftDTOType.Computer => "computer",
                UpdateToolDraftDTOType.Dtmf => "dtmf",
                UpdateToolDraftDTOType.EndCall => "endCall",
                UpdateToolDraftDTOType.Function => "function",
                UpdateToolDraftDTOType.Ghl => "ghl",
                UpdateToolDraftDTOType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                UpdateToolDraftDTOType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                UpdateToolDraftDTOType.GohighlevelContactCreate => "gohighlevel.contact.create",
                UpdateToolDraftDTOType.GohighlevelContactGet => "gohighlevel.contact.get",
                UpdateToolDraftDTOType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                UpdateToolDraftDTOType.GoogleCalendarEventCreate => "google.calendar.event.create",
                UpdateToolDraftDTOType.GoogleSheetsRowAppend => "google.sheets.row.append",
                UpdateToolDraftDTOType.Handoff => "handoff",
                UpdateToolDraftDTOType.KnowledgeBase => "knowledgeBase",
                UpdateToolDraftDTOType.Make => "make",
                UpdateToolDraftDTOType.Mcp => "mcp",
                UpdateToolDraftDTOType.Output => "output",
                UpdateToolDraftDTOType.Query => "query",
                UpdateToolDraftDTOType.SipRequest => "sipRequest",
                UpdateToolDraftDTOType.SlackMessageSend => "slack.message.send",
                UpdateToolDraftDTOType.Sms => "sms",
                UpdateToolDraftDTOType.TextEditor => "textEditor",
                UpdateToolDraftDTOType.TransferCall => "transferCall",
                UpdateToolDraftDTOType.TransferCancel => "transferCancel",
                UpdateToolDraftDTOType.TransferSuccessful => "transferSuccessful",
                UpdateToolDraftDTOType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolDraftDTOType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => UpdateToolDraftDTOType.ApiRequest,
                "bash" => UpdateToolDraftDTOType.Bash,
                "code" => UpdateToolDraftDTOType.Code,
                "computer" => UpdateToolDraftDTOType.Computer,
                "dtmf" => UpdateToolDraftDTOType.Dtmf,
                "endCall" => UpdateToolDraftDTOType.EndCall,
                "function" => UpdateToolDraftDTOType.Function,
                "ghl" => UpdateToolDraftDTOType.Ghl,
                "gohighlevel.calendar.availability.check" => UpdateToolDraftDTOType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => UpdateToolDraftDTOType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => UpdateToolDraftDTOType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => UpdateToolDraftDTOType.GohighlevelContactGet,
                "google.calendar.availability.check" => UpdateToolDraftDTOType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => UpdateToolDraftDTOType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => UpdateToolDraftDTOType.GoogleSheetsRowAppend,
                "handoff" => UpdateToolDraftDTOType.Handoff,
                "knowledgeBase" => UpdateToolDraftDTOType.KnowledgeBase,
                "make" => UpdateToolDraftDTOType.Make,
                "mcp" => UpdateToolDraftDTOType.Mcp,
                "output" => UpdateToolDraftDTOType.Output,
                "query" => UpdateToolDraftDTOType.Query,
                "sipRequest" => UpdateToolDraftDTOType.SipRequest,
                "slack.message.send" => UpdateToolDraftDTOType.SlackMessageSend,
                "sms" => UpdateToolDraftDTOType.Sms,
                "textEditor" => UpdateToolDraftDTOType.TextEditor,
                "transferCall" => UpdateToolDraftDTOType.TransferCall,
                "transferCancel" => UpdateToolDraftDTOType.TransferCancel,
                "transferSuccessful" => UpdateToolDraftDTOType.TransferSuccessful,
                "voicemail" => UpdateToolDraftDTOType.Voicemail,
                _ => null,
            };
        }
    }
}