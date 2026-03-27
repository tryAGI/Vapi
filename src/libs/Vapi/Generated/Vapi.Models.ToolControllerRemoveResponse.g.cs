#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolControllerRemoveResponse : global::System.IEquatable<ToolControllerRemoveResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.ToolControllerRemoveResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.ApiRequestTool? ApiRequest { get; init; }
#else
        public global::Vapi.ApiRequestTool? ApiRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiRequest))]
#endif
        public bool IsApiRequest => ApiRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CodeTool? Code { get; init; }
#else
        public global::Vapi.CodeTool? Code { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.DtmfTool? Dtmf { get; init; }
#else
        public global::Vapi.DtmfTool? Dtmf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dtmf))]
#endif
        public bool IsDtmf => Dtmf != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.EndCallTool? EndCall { get; init; }
#else
        public global::Vapi.EndCallTool? EndCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndCall))]
#endif
        public bool IsEndCall => EndCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.FunctionTool? Function { get; init; }
#else
        public global::Vapi.FunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GhlTool? Ghl { get; init; }
#else
        public global::Vapi.GhlTool? Ghl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ghl))]
#endif
        public bool IsGhl => Ghl != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.TransferCallTool? TransferCall { get; init; }
#else
        public global::Vapi.TransferCallTool? TransferCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferCall))]
#endif
        public bool IsTransferCall => TransferCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.HandoffTool? Handoff { get; init; }
#else
        public global::Vapi.HandoffTool? Handoff { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Handoff))]
#endif
        public bool IsHandoff => Handoff != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.BashTool? Bash { get; init; }
#else
        public global::Vapi.BashTool? Bash { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash))]
#endif
        public bool IsBash => Bash != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.ComputerTool? Computer { get; init; }
#else
        public global::Vapi.ComputerTool? Computer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer))]
#endif
        public bool IsComputer => Computer != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.TextEditorTool? TextEditor { get; init; }
#else
        public global::Vapi.TextEditorTool? TextEditor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor))]
#endif
        public bool IsTextEditor => TextEditor != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.QueryTool? Query { get; init; }
#else
        public global::Vapi.QueryTool? Query { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Query))]
#endif
        public bool IsQuery => Query != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoogleCalendarCreateEventTool? GoogleCalendarEventCreate { get; init; }
#else
        public global::Vapi.GoogleCalendarCreateEventTool? GoogleCalendarEventCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarEventCreate))]
#endif
        public bool IsGoogleCalendarEventCreate => GoogleCalendarEventCreate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoogleSheetsRowAppendTool? GoogleSheetsRowAppend { get; init; }
#else
        public global::Vapi.GoogleSheetsRowAppendTool? GoogleSheetsRowAppend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSheetsRowAppend))]
#endif
        public bool IsGoogleSheetsRowAppend => GoogleSheetsRowAppend != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoogleCalendarCheckAvailabilityTool? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.GoogleCalendarCheckAvailabilityTool? GoogleCalendarAvailabilityCheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarAvailabilityCheck))]
#endif
        public bool IsGoogleCalendarAvailabilityCheck => GoogleCalendarAvailabilityCheck != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.SlackSendMessageTool? SlackMessageSend { get; init; }
#else
        public global::Vapi.SlackSendMessageTool? SlackMessageSend { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackMessageSend))]
#endif
        public bool IsSlackMessageSend => SlackMessageSend != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.SmsTool? Sms { get; init; }
#else
        public global::Vapi.SmsTool? Sms { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sms))]
#endif
        public bool IsSms => Sms != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.McpTool? Mcp { get; init; }
#else
        public global::Vapi.McpTool? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoHighLevelCalendarAvailabilityTool? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.GoHighLevelCalendarAvailabilityTool? GohighlevelCalendarAvailabilityCheck { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelCalendarAvailabilityCheck))]
#endif
        public bool IsGohighlevelCalendarAvailabilityCheck => GohighlevelCalendarAvailabilityCheck != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoHighLevelCalendarEventCreateTool? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::Vapi.GoHighLevelCalendarEventCreateTool? GohighlevelCalendarEventCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelCalendarEventCreate))]
#endif
        public bool IsGohighlevelCalendarEventCreate => GohighlevelCalendarEventCreate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoHighLevelContactCreateTool? GohighlevelContactCreate { get; init; }
#else
        public global::Vapi.GoHighLevelContactCreateTool? GohighlevelContactCreate { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelContactCreate))]
#endif
        public bool IsGohighlevelContactCreate => GohighlevelContactCreate != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.GoHighLevelContactGetTool? GohighlevelContactGet { get; init; }
#else
        public global::Vapi.GoHighLevelContactGetTool? GohighlevelContactGet { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GohighlevelContactGet))]
#endif
        public bool IsGohighlevelContactGet => GohighlevelContactGet != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.SipRequestTool? SipRequest { get; init; }
#else
        public global::Vapi.SipRequestTool? SipRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipRequest))]
#endif
        public bool IsSipRequest => SipRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.VoicemailTool? Voicemail { get; init; }
#else
        public global::Vapi.VoicemailTool? Voicemail { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voicemail))]
#endif
        public bool IsVoicemail => Voicemail != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.ApiRequestTool value) => new ToolControllerRemoveResponse((global::Vapi.ApiRequestTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.ApiRequestTool?(ToolControllerRemoveResponse @this) => @this.ApiRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.ApiRequestTool? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.CodeTool value) => new ToolControllerRemoveResponse((global::Vapi.CodeTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CodeTool?(ToolControllerRemoveResponse @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.CodeTool? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.DtmfTool value) => new ToolControllerRemoveResponse((global::Vapi.DtmfTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.DtmfTool?(ToolControllerRemoveResponse @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.DtmfTool? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.EndCallTool value) => new ToolControllerRemoveResponse((global::Vapi.EndCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.EndCallTool?(ToolControllerRemoveResponse @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.EndCallTool? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.FunctionTool value) => new ToolControllerRemoveResponse((global::Vapi.FunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.FunctionTool?(ToolControllerRemoveResponse @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.FunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GhlTool value) => new ToolControllerRemoveResponse((global::Vapi.GhlTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GhlTool?(ToolControllerRemoveResponse @this) => @this.Ghl;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GhlTool? value)
        {
            Ghl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.TransferCallTool value) => new ToolControllerRemoveResponse((global::Vapi.TransferCallTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.TransferCallTool?(ToolControllerRemoveResponse @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.TransferCallTool? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.HandoffTool value) => new ToolControllerRemoveResponse((global::Vapi.HandoffTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.HandoffTool?(ToolControllerRemoveResponse @this) => @this.Handoff;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.HandoffTool? value)
        {
            Handoff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.BashTool value) => new ToolControllerRemoveResponse((global::Vapi.BashTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.BashTool?(ToolControllerRemoveResponse @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.BashTool? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.ComputerTool value) => new ToolControllerRemoveResponse((global::Vapi.ComputerTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.ComputerTool?(ToolControllerRemoveResponse @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.ComputerTool? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.TextEditorTool value) => new ToolControllerRemoveResponse((global::Vapi.TextEditorTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.TextEditorTool?(ToolControllerRemoveResponse @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.TextEditorTool? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.QueryTool value) => new ToolControllerRemoveResponse((global::Vapi.QueryTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.QueryTool?(ToolControllerRemoveResponse @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.QueryTool? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoogleCalendarCreateEventTool value) => new ToolControllerRemoveResponse((global::Vapi.GoogleCalendarCreateEventTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoogleCalendarCreateEventTool?(ToolControllerRemoveResponse @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoogleCalendarCreateEventTool? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoogleSheetsRowAppendTool value) => new ToolControllerRemoveResponse((global::Vapi.GoogleSheetsRowAppendTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoogleSheetsRowAppendTool?(ToolControllerRemoveResponse @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoogleSheetsRowAppendTool? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoogleCalendarCheckAvailabilityTool value) => new ToolControllerRemoveResponse((global::Vapi.GoogleCalendarCheckAvailabilityTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoogleCalendarCheckAvailabilityTool?(ToolControllerRemoveResponse @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoogleCalendarCheckAvailabilityTool? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.SlackSendMessageTool value) => new ToolControllerRemoveResponse((global::Vapi.SlackSendMessageTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.SlackSendMessageTool?(ToolControllerRemoveResponse @this) => @this.SlackMessageSend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.SlackSendMessageTool? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.SmsTool value) => new ToolControllerRemoveResponse((global::Vapi.SmsTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.SmsTool?(ToolControllerRemoveResponse @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.SmsTool? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.McpTool value) => new ToolControllerRemoveResponse((global::Vapi.McpTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.McpTool?(ToolControllerRemoveResponse @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.McpTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoHighLevelCalendarAvailabilityTool value) => new ToolControllerRemoveResponse((global::Vapi.GoHighLevelCalendarAvailabilityTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoHighLevelCalendarAvailabilityTool?(ToolControllerRemoveResponse @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoHighLevelCalendarAvailabilityTool? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoHighLevelCalendarEventCreateTool value) => new ToolControllerRemoveResponse((global::Vapi.GoHighLevelCalendarEventCreateTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoHighLevelCalendarEventCreateTool?(ToolControllerRemoveResponse @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoHighLevelCalendarEventCreateTool? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoHighLevelContactCreateTool value) => new ToolControllerRemoveResponse((global::Vapi.GoHighLevelContactCreateTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoHighLevelContactCreateTool?(ToolControllerRemoveResponse @this) => @this.GohighlevelContactCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoHighLevelContactCreateTool? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.GoHighLevelContactGetTool value) => new ToolControllerRemoveResponse((global::Vapi.GoHighLevelContactGetTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.GoHighLevelContactGetTool?(ToolControllerRemoveResponse @this) => @this.GohighlevelContactGet;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.GoHighLevelContactGetTool? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.SipRequestTool value) => new ToolControllerRemoveResponse((global::Vapi.SipRequestTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.SipRequestTool?(ToolControllerRemoveResponse @this) => @this.SipRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.SipRequestTool? value)
        {
            SipRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerRemoveResponse(global::Vapi.VoicemailTool value) => new ToolControllerRemoveResponse((global::Vapi.VoicemailTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.VoicemailTool?(ToolControllerRemoveResponse @this) => @this.Voicemail;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(global::Vapi.VoicemailTool? value)
        {
            Voicemail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerRemoveResponse(
            global::Vapi.ToolControllerRemoveResponseDiscriminatorType? type,
            global::Vapi.ApiRequestTool? apiRequest,
            global::Vapi.CodeTool? code,
            global::Vapi.DtmfTool? dtmf,
            global::Vapi.EndCallTool? endCall,
            global::Vapi.FunctionTool? function,
            global::Vapi.GhlTool? ghl,
            global::Vapi.TransferCallTool? transferCall,
            global::Vapi.HandoffTool? handoff,
            global::Vapi.BashTool? bash,
            global::Vapi.ComputerTool? computer,
            global::Vapi.TextEditorTool? textEditor,
            global::Vapi.QueryTool? query,
            global::Vapi.GoogleCalendarCreateEventTool? googleCalendarEventCreate,
            global::Vapi.GoogleSheetsRowAppendTool? googleSheetsRowAppend,
            global::Vapi.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck,
            global::Vapi.SlackSendMessageTool? slackMessageSend,
            global::Vapi.SmsTool? sms,
            global::Vapi.McpTool? mcp,
            global::Vapi.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck,
            global::Vapi.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate,
            global::Vapi.GoHighLevelContactCreateTool? gohighlevelContactCreate,
            global::Vapi.GoHighLevelContactGetTool? gohighlevelContactGet,
            global::Vapi.SipRequestTool? sipRequest,
            global::Vapi.VoicemailTool? voicemail
            )
        {
            Type = type;

            ApiRequest = apiRequest;
            Code = code;
            Dtmf = dtmf;
            EndCall = endCall;
            Function = function;
            Ghl = ghl;
            TransferCall = transferCall;
            Handoff = handoff;
            Bash = bash;
            Computer = computer;
            TextEditor = textEditor;
            Query = query;
            GoogleCalendarEventCreate = googleCalendarEventCreate;
            GoogleSheetsRowAppend = googleSheetsRowAppend;
            GoogleCalendarAvailabilityCheck = googleCalendarAvailabilityCheck;
            SlackMessageSend = slackMessageSend;
            Sms = sms;
            Mcp = mcp;
            GohighlevelCalendarAvailabilityCheck = gohighlevelCalendarAvailabilityCheck;
            GohighlevelCalendarEventCreate = gohighlevelCalendarEventCreate;
            GohighlevelContactCreate = gohighlevelContactCreate;
            GohighlevelContactGet = gohighlevelContactGet;
            SipRequest = sipRequest;
            Voicemail = voicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Voicemail as object ??
            SipRequest as object ??
            GohighlevelContactGet as object ??
            GohighlevelContactCreate as object ??
            GohighlevelCalendarEventCreate as object ??
            GohighlevelCalendarAvailabilityCheck as object ??
            Mcp as object ??
            Sms as object ??
            SlackMessageSend as object ??
            GoogleCalendarAvailabilityCheck as object ??
            GoogleSheetsRowAppend as object ??
            GoogleCalendarEventCreate as object ??
            Query as object ??
            TextEditor as object ??
            Computer as object ??
            Bash as object ??
            Handoff as object ??
            TransferCall as object ??
            Ghl as object ??
            Function as object ??
            EndCall as object ??
            Dtmf as object ??
            Code as object ??
            ApiRequest as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ApiRequest?.ToString() ??
            Code?.ToString() ??
            Dtmf?.ToString() ??
            EndCall?.ToString() ??
            Function?.ToString() ??
            Ghl?.ToString() ??
            TransferCall?.ToString() ??
            Handoff?.ToString() ??
            Bash?.ToString() ??
            Computer?.ToString() ??
            TextEditor?.ToString() ??
            Query?.ToString() ??
            GoogleCalendarEventCreate?.ToString() ??
            GoogleSheetsRowAppend?.ToString() ??
            GoogleCalendarAvailabilityCheck?.ToString() ??
            SlackMessageSend?.ToString() ??
            Sms?.ToString() ??
            Mcp?.ToString() ??
            GohighlevelCalendarAvailabilityCheck?.ToString() ??
            GohighlevelCalendarEventCreate?.ToString() ??
            GohighlevelContactCreate?.ToString() ??
            GohighlevelContactGet?.ToString() ??
            SipRequest?.ToString() ??
            Voicemail?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsGhl && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && IsVoicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.ApiRequestTool?, TResult>? apiRequest = null,
            global::System.Func<global::Vapi.CodeTool?, TResult>? code = null,
            global::System.Func<global::Vapi.DtmfTool?, TResult>? dtmf = null,
            global::System.Func<global::Vapi.EndCallTool?, TResult>? endCall = null,
            global::System.Func<global::Vapi.FunctionTool?, TResult>? function = null,
            global::System.Func<global::Vapi.GhlTool?, TResult>? ghl = null,
            global::System.Func<global::Vapi.TransferCallTool?, TResult>? transferCall = null,
            global::System.Func<global::Vapi.HandoffTool?, TResult>? handoff = null,
            global::System.Func<global::Vapi.BashTool?, TResult>? bash = null,
            global::System.Func<global::Vapi.ComputerTool?, TResult>? computer = null,
            global::System.Func<global::Vapi.TextEditorTool?, TResult>? textEditor = null,
            global::System.Func<global::Vapi.QueryTool?, TResult>? query = null,
            global::System.Func<global::Vapi.GoogleCalendarCreateEventTool?, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::Vapi.GoogleSheetsRowAppendTool?, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::Vapi.GoogleCalendarCheckAvailabilityTool?, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.SlackSendMessageTool?, TResult>? slackMessageSend = null,
            global::System.Func<global::Vapi.SmsTool?, TResult>? sms = null,
            global::System.Func<global::Vapi.McpTool?, TResult>? mcp = null,
            global::System.Func<global::Vapi.GoHighLevelCalendarAvailabilityTool?, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.GoHighLevelCalendarEventCreateTool?, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::Vapi.GoHighLevelContactCreateTool?, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::Vapi.GoHighLevelContactGetTool?, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::Vapi.SipRequestTool?, TResult>? sipRequest = null,
            global::System.Func<global::Vapi.VoicemailTool?, TResult>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiRequest && apiRequest != null)
            {
                return apiRequest(ApiRequest!);
            }
            else if (IsCode && code != null)
            {
                return code(Code!);
            }
            else if (IsDtmf && dtmf != null)
            {
                return dtmf(Dtmf!);
            }
            else if (IsEndCall && endCall != null)
            {
                return endCall(EndCall!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsGhl && ghl != null)
            {
                return ghl(Ghl!);
            }
            else if (IsTransferCall && transferCall != null)
            {
                return transferCall(TransferCall!);
            }
            else if (IsHandoff && handoff != null)
            {
                return handoff(Handoff!);
            }
            else if (IsBash && bash != null)
            {
                return bash(Bash!);
            }
            else if (IsComputer && computer != null)
            {
                return computer(Computer!);
            }
            else if (IsTextEditor && textEditor != null)
            {
                return textEditor(TextEditor!);
            }
            else if (IsQuery && query != null)
            {
                return query(Query!);
            }
            else if (IsGoogleCalendarEventCreate && googleCalendarEventCreate != null)
            {
                return googleCalendarEventCreate(GoogleCalendarEventCreate!);
            }
            else if (IsGoogleSheetsRowAppend && googleSheetsRowAppend != null)
            {
                return googleSheetsRowAppend(GoogleSheetsRowAppend!);
            }
            else if (IsGoogleCalendarAvailabilityCheck && googleCalendarAvailabilityCheck != null)
            {
                return googleCalendarAvailabilityCheck(GoogleCalendarAvailabilityCheck!);
            }
            else if (IsSlackMessageSend && slackMessageSend != null)
            {
                return slackMessageSend(SlackMessageSend!);
            }
            else if (IsSms && sms != null)
            {
                return sms(Sms!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }
            else if (IsGohighlevelCalendarAvailabilityCheck && gohighlevelCalendarAvailabilityCheck != null)
            {
                return gohighlevelCalendarAvailabilityCheck(GohighlevelCalendarAvailabilityCheck!);
            }
            else if (IsGohighlevelCalendarEventCreate && gohighlevelCalendarEventCreate != null)
            {
                return gohighlevelCalendarEventCreate(GohighlevelCalendarEventCreate!);
            }
            else if (IsGohighlevelContactCreate && gohighlevelContactCreate != null)
            {
                return gohighlevelContactCreate(GohighlevelContactCreate!);
            }
            else if (IsGohighlevelContactGet && gohighlevelContactGet != null)
            {
                return gohighlevelContactGet(GohighlevelContactGet!);
            }
            else if (IsSipRequest && sipRequest != null)
            {
                return sipRequest(SipRequest!);
            }
            else if (IsVoicemail && voicemail != null)
            {
                return voicemail(Voicemail!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.ApiRequestTool?>? apiRequest = null,
            global::System.Action<global::Vapi.CodeTool?>? code = null,
            global::System.Action<global::Vapi.DtmfTool?>? dtmf = null,
            global::System.Action<global::Vapi.EndCallTool?>? endCall = null,
            global::System.Action<global::Vapi.FunctionTool?>? function = null,
            global::System.Action<global::Vapi.GhlTool?>? ghl = null,
            global::System.Action<global::Vapi.TransferCallTool?>? transferCall = null,
            global::System.Action<global::Vapi.HandoffTool?>? handoff = null,
            global::System.Action<global::Vapi.BashTool?>? bash = null,
            global::System.Action<global::Vapi.ComputerTool?>? computer = null,
            global::System.Action<global::Vapi.TextEditorTool?>? textEditor = null,
            global::System.Action<global::Vapi.QueryTool?>? query = null,
            global::System.Action<global::Vapi.GoogleCalendarCreateEventTool?>? googleCalendarEventCreate = null,
            global::System.Action<global::Vapi.GoogleSheetsRowAppendTool?>? googleSheetsRowAppend = null,
            global::System.Action<global::Vapi.GoogleCalendarCheckAvailabilityTool?>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.SlackSendMessageTool?>? slackMessageSend = null,
            global::System.Action<global::Vapi.SmsTool?>? sms = null,
            global::System.Action<global::Vapi.McpTool?>? mcp = null,
            global::System.Action<global::Vapi.GoHighLevelCalendarAvailabilityTool?>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.GoHighLevelCalendarEventCreateTool?>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::Vapi.GoHighLevelContactCreateTool?>? gohighlevelContactCreate = null,
            global::System.Action<global::Vapi.GoHighLevelContactGetTool?>? gohighlevelContactGet = null,
            global::System.Action<global::Vapi.SipRequestTool?>? sipRequest = null,
            global::System.Action<global::Vapi.VoicemailTool?>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApiRequest)
            {
                apiRequest?.Invoke(ApiRequest!);
            }
            else if (IsCode)
            {
                code?.Invoke(Code!);
            }
            else if (IsDtmf)
            {
                dtmf?.Invoke(Dtmf!);
            }
            else if (IsEndCall)
            {
                endCall?.Invoke(EndCall!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsGhl)
            {
                ghl?.Invoke(Ghl!);
            }
            else if (IsTransferCall)
            {
                transferCall?.Invoke(TransferCall!);
            }
            else if (IsHandoff)
            {
                handoff?.Invoke(Handoff!);
            }
            else if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
            else if (IsComputer)
            {
                computer?.Invoke(Computer!);
            }
            else if (IsTextEditor)
            {
                textEditor?.Invoke(TextEditor!);
            }
            else if (IsQuery)
            {
                query?.Invoke(Query!);
            }
            else if (IsGoogleCalendarEventCreate)
            {
                googleCalendarEventCreate?.Invoke(GoogleCalendarEventCreate!);
            }
            else if (IsGoogleSheetsRowAppend)
            {
                googleSheetsRowAppend?.Invoke(GoogleSheetsRowAppend!);
            }
            else if (IsGoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck?.Invoke(GoogleCalendarAvailabilityCheck!);
            }
            else if (IsSlackMessageSend)
            {
                slackMessageSend?.Invoke(SlackMessageSend!);
            }
            else if (IsSms)
            {
                sms?.Invoke(Sms!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
            else if (IsGohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(GohighlevelCalendarAvailabilityCheck!);
            }
            else if (IsGohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate?.Invoke(GohighlevelCalendarEventCreate!);
            }
            else if (IsGohighlevelContactCreate)
            {
                gohighlevelContactCreate?.Invoke(GohighlevelContactCreate!);
            }
            else if (IsGohighlevelContactGet)
            {
                gohighlevelContactGet?.Invoke(GohighlevelContactGet!);
            }
            else if (IsSipRequest)
            {
                sipRequest?.Invoke(SipRequest!);
            }
            else if (IsVoicemail)
            {
                voicemail?.Invoke(Voicemail!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ApiRequest,
                typeof(global::Vapi.ApiRequestTool),
                Code,
                typeof(global::Vapi.CodeTool),
                Dtmf,
                typeof(global::Vapi.DtmfTool),
                EndCall,
                typeof(global::Vapi.EndCallTool),
                Function,
                typeof(global::Vapi.FunctionTool),
                Ghl,
                typeof(global::Vapi.GhlTool),
                TransferCall,
                typeof(global::Vapi.TransferCallTool),
                Handoff,
                typeof(global::Vapi.HandoffTool),
                Bash,
                typeof(global::Vapi.BashTool),
                Computer,
                typeof(global::Vapi.ComputerTool),
                TextEditor,
                typeof(global::Vapi.TextEditorTool),
                Query,
                typeof(global::Vapi.QueryTool),
                GoogleCalendarEventCreate,
                typeof(global::Vapi.GoogleCalendarCreateEventTool),
                GoogleSheetsRowAppend,
                typeof(global::Vapi.GoogleSheetsRowAppendTool),
                GoogleCalendarAvailabilityCheck,
                typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool),
                SlackMessageSend,
                typeof(global::Vapi.SlackSendMessageTool),
                Sms,
                typeof(global::Vapi.SmsTool),
                Mcp,
                typeof(global::Vapi.McpTool),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool),
                GohighlevelCalendarEventCreate,
                typeof(global::Vapi.GoHighLevelCalendarEventCreateTool),
                GohighlevelContactCreate,
                typeof(global::Vapi.GoHighLevelContactCreateTool),
                GohighlevelContactGet,
                typeof(global::Vapi.GoHighLevelContactGetTool),
                SipRequest,
                typeof(global::Vapi.SipRequestTool),
                Voicemail,
                typeof(global::Vapi.VoicemailTool),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ToolControllerRemoveResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.ApiRequestTool?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CodeTool?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.DtmfTool?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.EndCallTool?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.FunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GhlTool?>.Default.Equals(Ghl, other.Ghl) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TransferCallTool?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.HandoffTool?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.BashTool?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.ComputerTool?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TextEditorTool?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.QueryTool?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoogleCalendarCreateEventTool?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoogleSheetsRowAppendTool?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoogleCalendarCheckAvailabilityTool?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.SlackSendMessageTool?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.SmsTool?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.McpTool?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoHighLevelCalendarAvailabilityTool?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoHighLevelCalendarEventCreateTool?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoHighLevelContactCreateTool?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.GoHighLevelContactGetTool?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.SipRequestTool?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.VoicemailTool?>.Default.Equals(Voicemail, other.Voicemail) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolControllerRemoveResponse obj1, ToolControllerRemoveResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerRemoveResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolControllerRemoveResponse obj1, ToolControllerRemoveResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerRemoveResponse o && Equals(o);
        }
    }
}
