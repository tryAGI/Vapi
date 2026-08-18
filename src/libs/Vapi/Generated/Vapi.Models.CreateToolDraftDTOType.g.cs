
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type of the tool.
    /// </summary>
    public enum CreateToolDraftDTOType
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
    public static class CreateToolDraftDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolDraftDTOType value)
        {
            return value switch
            {
                CreateToolDraftDTOType.ApiRequest => "apiRequest",
                CreateToolDraftDTOType.Bash => "bash",
                CreateToolDraftDTOType.Code => "code",
                CreateToolDraftDTOType.Computer => "computer",
                CreateToolDraftDTOType.Dtmf => "dtmf",
                CreateToolDraftDTOType.EndCall => "endCall",
                CreateToolDraftDTOType.Function => "function",
                CreateToolDraftDTOType.Ghl => "ghl",
                CreateToolDraftDTOType.GohighlevelCalendarAvailabilityCheck => "gohighlevel.calendar.availability.check",
                CreateToolDraftDTOType.GohighlevelCalendarEventCreate => "gohighlevel.calendar.event.create",
                CreateToolDraftDTOType.GohighlevelContactCreate => "gohighlevel.contact.create",
                CreateToolDraftDTOType.GohighlevelContactGet => "gohighlevel.contact.get",
                CreateToolDraftDTOType.GoogleCalendarAvailabilityCheck => "google.calendar.availability.check",
                CreateToolDraftDTOType.GoogleCalendarEventCreate => "google.calendar.event.create",
                CreateToolDraftDTOType.GoogleSheetsRowAppend => "google.sheets.row.append",
                CreateToolDraftDTOType.Handoff => "handoff",
                CreateToolDraftDTOType.KnowledgeBase => "knowledgeBase",
                CreateToolDraftDTOType.Make => "make",
                CreateToolDraftDTOType.Mcp => "mcp",
                CreateToolDraftDTOType.Output => "output",
                CreateToolDraftDTOType.Query => "query",
                CreateToolDraftDTOType.SipRequest => "sipRequest",
                CreateToolDraftDTOType.SlackMessageSend => "slack.message.send",
                CreateToolDraftDTOType.Sms => "sms",
                CreateToolDraftDTOType.TextEditor => "textEditor",
                CreateToolDraftDTOType.TransferCall => "transferCall",
                CreateToolDraftDTOType.TransferCancel => "transferCancel",
                CreateToolDraftDTOType.TransferSuccessful => "transferSuccessful",
                CreateToolDraftDTOType.Voicemail => "voicemail",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolDraftDTOType? ToEnum(string value)
        {
            return value switch
            {
                "apiRequest" => CreateToolDraftDTOType.ApiRequest,
                "bash" => CreateToolDraftDTOType.Bash,
                "code" => CreateToolDraftDTOType.Code,
                "computer" => CreateToolDraftDTOType.Computer,
                "dtmf" => CreateToolDraftDTOType.Dtmf,
                "endCall" => CreateToolDraftDTOType.EndCall,
                "function" => CreateToolDraftDTOType.Function,
                "ghl" => CreateToolDraftDTOType.Ghl,
                "gohighlevel.calendar.availability.check" => CreateToolDraftDTOType.GohighlevelCalendarAvailabilityCheck,
                "gohighlevel.calendar.event.create" => CreateToolDraftDTOType.GohighlevelCalendarEventCreate,
                "gohighlevel.contact.create" => CreateToolDraftDTOType.GohighlevelContactCreate,
                "gohighlevel.contact.get" => CreateToolDraftDTOType.GohighlevelContactGet,
                "google.calendar.availability.check" => CreateToolDraftDTOType.GoogleCalendarAvailabilityCheck,
                "google.calendar.event.create" => CreateToolDraftDTOType.GoogleCalendarEventCreate,
                "google.sheets.row.append" => CreateToolDraftDTOType.GoogleSheetsRowAppend,
                "handoff" => CreateToolDraftDTOType.Handoff,
                "knowledgeBase" => CreateToolDraftDTOType.KnowledgeBase,
                "make" => CreateToolDraftDTOType.Make,
                "mcp" => CreateToolDraftDTOType.Mcp,
                "output" => CreateToolDraftDTOType.Output,
                "query" => CreateToolDraftDTOType.Query,
                "sipRequest" => CreateToolDraftDTOType.SipRequest,
                "slack.message.send" => CreateToolDraftDTOType.SlackMessageSend,
                "sms" => CreateToolDraftDTOType.Sms,
                "textEditor" => CreateToolDraftDTOType.TextEditor,
                "transferCall" => CreateToolDraftDTOType.TransferCall,
                "transferCancel" => CreateToolDraftDTOType.TransferCancel,
                "transferSuccessful" => CreateToolDraftDTOType.TransferSuccessful,
                "voicemail" => CreateToolDraftDTOType.Voicemail,
                _ => null,
            };
        }
    }
}