#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolControllerCreateRequest : global::System.IEquatable<ToolControllerCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.ToolControllerCreateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateApiRequestToolDTO? ApiRequest { get; init; }
#else
        public global::Vapi.CreateApiRequestToolDTO? ApiRequest { get; }
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
        public global::Vapi.CreateCodeToolDTO? Code { get; init; }
#else
        public global::Vapi.CreateCodeToolDTO? Code { get; }
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
        public global::Vapi.CreateDtmfToolDTO? Dtmf { get; init; }
#else
        public global::Vapi.CreateDtmfToolDTO? Dtmf { get; }
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
        public global::Vapi.CreateEndCallToolDTO? EndCall { get; init; }
#else
        public global::Vapi.CreateEndCallToolDTO? EndCall { get; }
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
        public global::Vapi.CreateFunctionToolDTO? Function { get; init; }
#else
        public global::Vapi.CreateFunctionToolDTO? Function { get; }
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
        public global::Vapi.CreateTransferCallToolDTO? TransferCall { get; init; }
#else
        public global::Vapi.CreateTransferCallToolDTO? TransferCall { get; }
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
        public global::Vapi.CreateHandoffToolDTO? Handoff { get; init; }
#else
        public global::Vapi.CreateHandoffToolDTO? Handoff { get; }
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
        public global::Vapi.CreateBashToolDTO? Bash { get; init; }
#else
        public global::Vapi.CreateBashToolDTO? Bash { get; }
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
        public global::Vapi.CreateComputerToolDTO? Computer { get; init; }
#else
        public global::Vapi.CreateComputerToolDTO? Computer { get; }
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
        public global::Vapi.CreateTextEditorToolDTO? TextEditor { get; init; }
#else
        public global::Vapi.CreateTextEditorToolDTO? TextEditor { get; }
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
        public global::Vapi.CreateQueryToolDTO? Query { get; init; }
#else
        public global::Vapi.CreateQueryToolDTO? Query { get; }
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
        public global::Vapi.CreateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; init; }
#else
        public global::Vapi.CreateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; }
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
        public global::Vapi.CreateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; init; }
#else
        public global::Vapi.CreateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; }
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
        public global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; }
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
        public global::Vapi.CreateSlackSendMessageToolDTO? SlackMessageSend { get; init; }
#else
        public global::Vapi.CreateSlackSendMessageToolDTO? SlackMessageSend { get; }
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
        public global::Vapi.CreateSmsToolDTO? Sms { get; init; }
#else
        public global::Vapi.CreateSmsToolDTO? Sms { get; }
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
        public global::Vapi.CreateMcpToolDTO? Mcp { get; init; }
#else
        public global::Vapi.CreateMcpToolDTO? Mcp { get; }
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
        public global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; }
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
        public global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; }
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
        public global::Vapi.CreateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; init; }
#else
        public global::Vapi.CreateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; }
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
        public global::Vapi.CreateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; init; }
#else
        public global::Vapi.CreateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; }
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
        public global::Vapi.CreateSipRequestToolDTO? SipRequest { get; init; }
#else
        public global::Vapi.CreateSipRequestToolDTO? SipRequest { get; }
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
        public global::Vapi.CreateVoicemailToolDTO? Voicemail { get; init; }
#else
        public global::Vapi.CreateVoicemailToolDTO? Voicemail { get; }
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
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateApiRequestToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateApiRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateApiRequestToolDTO?(ToolControllerCreateRequest @this) => @this.ApiRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateApiRequestToolDTO? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateCodeToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateCodeToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCodeToolDTO?(ToolControllerCreateRequest @this) => @this.Code;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateCodeToolDTO? value)
        {
            Code = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateDtmfToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateDtmfToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateDtmfToolDTO?(ToolControllerCreateRequest @this) => @this.Dtmf;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateDtmfToolDTO? value)
        {
            Dtmf = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateEndCallToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateEndCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateEndCallToolDTO?(ToolControllerCreateRequest @this) => @this.EndCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateEndCallToolDTO? value)
        {
            EndCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateFunctionToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateFunctionToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateFunctionToolDTO?(ToolControllerCreateRequest @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateFunctionToolDTO? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateTransferCallToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateTransferCallToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTransferCallToolDTO?(ToolControllerCreateRequest @this) => @this.TransferCall;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateTransferCallToolDTO? value)
        {
            TransferCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateHandoffToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateHandoffToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateHandoffToolDTO?(ToolControllerCreateRequest @this) => @this.Handoff;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateHandoffToolDTO? value)
        {
            Handoff = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateBashToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateBashToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateBashToolDTO?(ToolControllerCreateRequest @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateBashToolDTO? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateComputerToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateComputerToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateComputerToolDTO?(ToolControllerCreateRequest @this) => @this.Computer;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateComputerToolDTO? value)
        {
            Computer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateTextEditorToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateTextEditorToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTextEditorToolDTO?(ToolControllerCreateRequest @this) => @this.TextEditor;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateTextEditorToolDTO? value)
        {
            TextEditor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateQueryToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateQueryToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateQueryToolDTO?(ToolControllerCreateRequest @this) => @this.Query;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateQueryToolDTO? value)
        {
            Query = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoogleCalendarCreateEventToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoogleCalendarCreateEventToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarCreateEventToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoogleCalendarCreateEventToolDTO? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoogleSheetsRowAppendToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoogleSheetsRowAppendToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleSheetsRowAppendToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoogleSheetsRowAppendToolDTO? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?(ToolControllerCreateRequest @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateSlackSendMessageToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateSlackSendMessageToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSlackSendMessageToolDTO?(ToolControllerCreateRequest @this) => @this.SlackMessageSend;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateSlackSendMessageToolDTO? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateSmsToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateSmsToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSmsToolDTO?(ToolControllerCreateRequest @this) => @this.Sms;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateSmsToolDTO? value)
        {
            Sms = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateMcpToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateMcpToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateMcpToolDTO?(ToolControllerCreateRequest @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateMcpToolDTO? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelContactCreateToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoHighLevelContactCreateToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelContactCreateToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelContactCreate;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelContactCreateToolDTO? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelContactGetToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateGoHighLevelContactGetToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelContactGetToolDTO?(ToolControllerCreateRequest @this) => @this.GohighlevelContactGet;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateGoHighLevelContactGetToolDTO? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateSipRequestToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateSipRequestToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSipRequestToolDTO?(ToolControllerCreateRequest @this) => @this.SipRequest;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateSipRequestToolDTO? value)
        {
            SipRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolControllerCreateRequest(global::Vapi.CreateVoicemailToolDTO value) => new ToolControllerCreateRequest((global::Vapi.CreateVoicemailToolDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateVoicemailToolDTO?(ToolControllerCreateRequest @this) => @this.Voicemail;

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(global::Vapi.CreateVoicemailToolDTO? value)
        {
            Voicemail = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolControllerCreateRequest(
            global::Vapi.ToolControllerCreateRequestDiscriminatorType? type,
            global::Vapi.CreateApiRequestToolDTO? apiRequest,
            global::Vapi.CreateCodeToolDTO? code,
            global::Vapi.CreateDtmfToolDTO? dtmf,
            global::Vapi.CreateEndCallToolDTO? endCall,
            global::Vapi.CreateFunctionToolDTO? function,
            global::Vapi.CreateTransferCallToolDTO? transferCall,
            global::Vapi.CreateHandoffToolDTO? handoff,
            global::Vapi.CreateBashToolDTO? bash,
            global::Vapi.CreateComputerToolDTO? computer,
            global::Vapi.CreateTextEditorToolDTO? textEditor,
            global::Vapi.CreateQueryToolDTO? query,
            global::Vapi.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate,
            global::Vapi.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend,
            global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck,
            global::Vapi.CreateSlackSendMessageToolDTO? slackMessageSend,
            global::Vapi.CreateSmsToolDTO? sms,
            global::Vapi.CreateMcpToolDTO? mcp,
            global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck,
            global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate,
            global::Vapi.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate,
            global::Vapi.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet,
            global::Vapi.CreateSipRequestToolDTO? sipRequest,
            global::Vapi.CreateVoicemailToolDTO? voicemail
            )
        {
            Type = type;

            ApiRequest = apiRequest;
            Code = code;
            Dtmf = dtmf;
            EndCall = endCall;
            Function = function;
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
            return IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && IsVoicemail;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.CreateApiRequestToolDTO?, TResult>? apiRequest = null,
            global::System.Func<global::Vapi.CreateCodeToolDTO?, TResult>? code = null,
            global::System.Func<global::Vapi.CreateDtmfToolDTO?, TResult>? dtmf = null,
            global::System.Func<global::Vapi.CreateEndCallToolDTO?, TResult>? endCall = null,
            global::System.Func<global::Vapi.CreateFunctionToolDTO?, TResult>? function = null,
            global::System.Func<global::Vapi.CreateTransferCallToolDTO?, TResult>? transferCall = null,
            global::System.Func<global::Vapi.CreateHandoffToolDTO?, TResult>? handoff = null,
            global::System.Func<global::Vapi.CreateBashToolDTO?, TResult>? bash = null,
            global::System.Func<global::Vapi.CreateComputerToolDTO?, TResult>? computer = null,
            global::System.Func<global::Vapi.CreateTextEditorToolDTO?, TResult>? textEditor = null,
            global::System.Func<global::Vapi.CreateQueryToolDTO?, TResult>? query = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarCreateEventToolDTO?, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::Vapi.CreateGoogleSheetsRowAppendToolDTO?, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.CreateSlackSendMessageToolDTO?, TResult>? slackMessageSend = null,
            global::System.Func<global::Vapi.CreateSmsToolDTO?, TResult>? sms = null,
            global::System.Func<global::Vapi.CreateMcpToolDTO?, TResult>? mcp = null,
            global::System.Func<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::Vapi.CreateGoHighLevelContactCreateToolDTO?, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::Vapi.CreateGoHighLevelContactGetToolDTO?, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::Vapi.CreateSipRequestToolDTO?, TResult>? sipRequest = null,
            global::System.Func<global::Vapi.CreateVoicemailToolDTO?, TResult>? voicemail = null,
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
            global::System.Action<global::Vapi.CreateApiRequestToolDTO?>? apiRequest = null,
            global::System.Action<global::Vapi.CreateCodeToolDTO?>? code = null,
            global::System.Action<global::Vapi.CreateDtmfToolDTO?>? dtmf = null,
            global::System.Action<global::Vapi.CreateEndCallToolDTO?>? endCall = null,
            global::System.Action<global::Vapi.CreateFunctionToolDTO?>? function = null,
            global::System.Action<global::Vapi.CreateTransferCallToolDTO?>? transferCall = null,
            global::System.Action<global::Vapi.CreateHandoffToolDTO?>? handoff = null,
            global::System.Action<global::Vapi.CreateBashToolDTO?>? bash = null,
            global::System.Action<global::Vapi.CreateComputerToolDTO?>? computer = null,
            global::System.Action<global::Vapi.CreateTextEditorToolDTO?>? textEditor = null,
            global::System.Action<global::Vapi.CreateQueryToolDTO?>? query = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarCreateEventToolDTO?>? googleCalendarEventCreate = null,
            global::System.Action<global::Vapi.CreateGoogleSheetsRowAppendToolDTO?>? googleSheetsRowAppend = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.CreateSlackSendMessageToolDTO?>? slackMessageSend = null,
            global::System.Action<global::Vapi.CreateSmsToolDTO?>? sms = null,
            global::System.Action<global::Vapi.CreateMcpToolDTO?>? mcp = null,
            global::System.Action<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::Vapi.CreateGoHighLevelContactCreateToolDTO?>? gohighlevelContactCreate = null,
            global::System.Action<global::Vapi.CreateGoHighLevelContactGetToolDTO?>? gohighlevelContactGet = null,
            global::System.Action<global::Vapi.CreateSipRequestToolDTO?>? sipRequest = null,
            global::System.Action<global::Vapi.CreateVoicemailToolDTO?>? voicemail = null,
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
                typeof(global::Vapi.CreateApiRequestToolDTO),
                Code,
                typeof(global::Vapi.CreateCodeToolDTO),
                Dtmf,
                typeof(global::Vapi.CreateDtmfToolDTO),
                EndCall,
                typeof(global::Vapi.CreateEndCallToolDTO),
                Function,
                typeof(global::Vapi.CreateFunctionToolDTO),
                TransferCall,
                typeof(global::Vapi.CreateTransferCallToolDTO),
                Handoff,
                typeof(global::Vapi.CreateHandoffToolDTO),
                Bash,
                typeof(global::Vapi.CreateBashToolDTO),
                Computer,
                typeof(global::Vapi.CreateComputerToolDTO),
                TextEditor,
                typeof(global::Vapi.CreateTextEditorToolDTO),
                Query,
                typeof(global::Vapi.CreateQueryToolDTO),
                GoogleCalendarEventCreate,
                typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO),
                GoogleSheetsRowAppend,
                typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO),
                GoogleCalendarAvailabilityCheck,
                typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO),
                SlackMessageSend,
                typeof(global::Vapi.CreateSlackSendMessageToolDTO),
                Sms,
                typeof(global::Vapi.CreateSmsToolDTO),
                Mcp,
                typeof(global::Vapi.CreateMcpToolDTO),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO),
                GohighlevelCalendarEventCreate,
                typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO),
                GohighlevelContactCreate,
                typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO),
                GohighlevelContactGet,
                typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO),
                SipRequest,
                typeof(global::Vapi.CreateSipRequestToolDTO),
                Voicemail,
                typeof(global::Vapi.CreateVoicemailToolDTO),
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
        public bool Equals(ToolControllerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateApiRequestToolDTO?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCodeToolDTO?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateDtmfToolDTO?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateEndCallToolDTO?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateFunctionToolDTO?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTransferCallToolDTO?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateHandoffToolDTO?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateBashToolDTO?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateComputerToolDTO?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTextEditorToolDTO?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateQueryToolDTO?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleCalendarCreateEventToolDTO?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleSheetsRowAppendToolDTO?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSlackSendMessageToolDTO?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSmsToolDTO?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateMcpToolDTO?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelContactCreateToolDTO?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelContactGetToolDTO?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSipRequestToolDTO?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateVoicemailToolDTO?>.Default.Equals(Voicemail, other.Voicemail) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolControllerCreateRequest obj1, ToolControllerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolControllerCreateRequest obj1, ToolControllerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerCreateRequest o && Equals(o);
        }
    }
}
