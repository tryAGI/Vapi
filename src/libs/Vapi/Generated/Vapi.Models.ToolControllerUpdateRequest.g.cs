#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolControllerUpdateRequest : global::System.IEquatable<ToolControllerUpdateRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.ToolControllerUpdateRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateApiRequestToolDTO? ApiRequest { get; init; }
#else
        public global::Vapi.UpdateApiRequestToolDTO? ApiRequest { get; }
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
        public bool TryPickApiRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateApiRequestToolDTO? value)
        {
            value = ApiRequest;
            return IsApiRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateApiRequestToolDTO PickApiRequest() => ApiRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateCodeToolDTO? Code { get; init; }
#else
        public global::Vapi.UpdateCodeToolDTO? Code { get; }
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
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateCodeToolDTO? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateCodeToolDTO PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateDtmfToolDTO? Dtmf { get; init; }
#else
        public global::Vapi.UpdateDtmfToolDTO? Dtmf { get; }
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
        public bool TryPickDtmf(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateDtmfToolDTO? value)
        {
            value = Dtmf;
            return IsDtmf;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateDtmfToolDTO PickDtmf() => Dtmf is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dtmf' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateEndCallToolDTO? EndCall { get; init; }
#else
        public global::Vapi.UpdateEndCallToolDTO? EndCall { get; }
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
        public bool TryPickEndCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateEndCallToolDTO? value)
        {
            value = EndCall;
            return IsEndCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateEndCallToolDTO PickEndCall() => EndCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EndCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateFunctionToolDTO? Function { get; init; }
#else
        public global::Vapi.UpdateFunctionToolDTO? Function { get; }
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
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateFunctionToolDTO? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateFunctionToolDTO PickFunction() => Function is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateKnowledgeBaseToolDTO? KnowledgeBase { get; init; }
#else
        public global::Vapi.UpdateKnowledgeBaseToolDTO? KnowledgeBase { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KnowledgeBase))]
#endif
        public bool IsKnowledgeBase => KnowledgeBase != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickKnowledgeBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateKnowledgeBaseToolDTO? value)
        {
            value = KnowledgeBase;
            return IsKnowledgeBase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateKnowledgeBaseToolDTO PickKnowledgeBase() => KnowledgeBase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'KnowledgeBase' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateTransferCallToolDTO? TransferCall { get; init; }
#else
        public global::Vapi.UpdateTransferCallToolDTO? TransferCall { get; }
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
        public bool TryPickTransferCall(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateTransferCallToolDTO? value)
        {
            value = TransferCall;
            return IsTransferCall;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTransferCallToolDTO PickTransferCall() => TransferCall is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TransferCall' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateHandoffToolDTO? Handoff { get; init; }
#else
        public global::Vapi.UpdateHandoffToolDTO? Handoff { get; }
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
        public bool TryPickHandoff(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateHandoffToolDTO? value)
        {
            value = Handoff;
            return IsHandoff;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateHandoffToolDTO PickHandoff() => Handoff is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Handoff' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateBashToolDTO? Bash { get; init; }
#else
        public global::Vapi.UpdateBashToolDTO? Bash { get; }
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
        public bool TryPickBash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateBashToolDTO? value)
        {
            value = Bash;
            return IsBash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateBashToolDTO PickBash() => Bash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bash' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateComputerToolDTO? Computer { get; init; }
#else
        public global::Vapi.UpdateComputerToolDTO? Computer { get; }
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
        public bool TryPickComputer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateComputerToolDTO? value)
        {
            value = Computer;
            return IsComputer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateComputerToolDTO PickComputer() => Computer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Computer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateTextEditorToolDTO? TextEditor { get; init; }
#else
        public global::Vapi.UpdateTextEditorToolDTO? TextEditor { get; }
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
        public bool TryPickTextEditor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateTextEditorToolDTO? value)
        {
            value = TextEditor;
            return IsTextEditor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateTextEditorToolDTO PickTextEditor() => TextEditor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateQueryToolDTO? Query { get; init; }
#else
        public global::Vapi.UpdateQueryToolDTO? Query { get; }
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
        public bool TryPickQuery(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateQueryToolDTO? value)
        {
            value = Query;
            return IsQuery;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateQueryToolDTO PickQuery() => Query is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Query' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; init; }
#else
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? GoogleCalendarEventCreate { get; }
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
        public bool TryPickGoogleCalendarEventCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? value)
        {
            value = GoogleCalendarEventCreate;
            return IsGoogleCalendarEventCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCreateEventToolDTO PickGoogleCalendarEventCreate() => GoogleCalendarEventCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarEventCreate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; init; }
#else
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? GoogleSheetsRowAppend { get; }
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
        public bool TryPickGoogleSheetsRowAppend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? value)
        {
            value = GoogleSheetsRowAppend;
            return IsGoogleSheetsRowAppend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleSheetsRowAppendToolDTO PickGoogleSheetsRowAppend() => GoogleSheetsRowAppend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSheetsRowAppend' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? GoogleCalendarAvailabilityCheck { get; }
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
        public bool TryPickGoogleCalendarAvailabilityCheck(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            value = GoogleCalendarAvailabilityCheck;
            return IsGoogleCalendarAvailabilityCheck;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO PickGoogleCalendarAvailabilityCheck() => GoogleCalendarAvailabilityCheck is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarAvailabilityCheck' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateSlackSendMessageToolDTO? SlackMessageSend { get; init; }
#else
        public global::Vapi.UpdateSlackSendMessageToolDTO? SlackMessageSend { get; }
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
        public bool TryPickSlackMessageSend(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateSlackSendMessageToolDTO? value)
        {
            value = SlackMessageSend;
            return IsSlackMessageSend;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSlackSendMessageToolDTO PickSlackMessageSend() => SlackMessageSend is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackMessageSend' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateSmsToolDTO? Sms { get; init; }
#else
        public global::Vapi.UpdateSmsToolDTO? Sms { get; }
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
        public bool TryPickSms(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateSmsToolDTO? value)
        {
            value = Sms;
            return IsSms;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSmsToolDTO PickSms() => Sms is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sms' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateMcpToolDTO? Mcp { get; init; }
#else
        public global::Vapi.UpdateMcpToolDTO? Mcp { get; }
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
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateMcpToolDTO? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateMcpToolDTO PickMcp() => Mcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; init; }
#else
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? GohighlevelCalendarAvailabilityCheck { get; }
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
        public bool TryPickGohighlevelCalendarAvailabilityCheck(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            value = GohighlevelCalendarAvailabilityCheck;
            return IsGohighlevelCalendarAvailabilityCheck;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO PickGohighlevelCalendarAvailabilityCheck() => GohighlevelCalendarAvailabilityCheck is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelCalendarAvailabilityCheck' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; init; }
#else
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? GohighlevelCalendarEventCreate { get; }
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
        public bool TryPickGohighlevelCalendarEventCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            value = GohighlevelCalendarEventCreate;
            return IsGohighlevelCalendarEventCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO PickGohighlevelCalendarEventCreate() => GohighlevelCalendarEventCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelCalendarEventCreate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; init; }
#else
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO? GohighlevelContactCreate { get; }
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
        public bool TryPickGohighlevelContactCreate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoHighLevelContactCreateToolDTO? value)
        {
            value = GohighlevelContactCreate;
            return IsGohighlevelContactCreate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactCreateToolDTO PickGohighlevelContactCreate() => GohighlevelContactCreate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelContactCreate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; init; }
#else
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO? GohighlevelContactGet { get; }
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
        public bool TryPickGohighlevelContactGet(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateGoHighLevelContactGetToolDTO? value)
        {
            value = GohighlevelContactGet;
            return IsGohighlevelContactGet;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateGoHighLevelContactGetToolDTO PickGohighlevelContactGet() => GohighlevelContactGet is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GohighlevelContactGet' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateSipRequestToolDTO? SipRequest { get; init; }
#else
        public global::Vapi.UpdateSipRequestToolDTO? SipRequest { get; }
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
        public bool TryPickSipRequest(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateSipRequestToolDTO? value)
        {
            value = SipRequest;
            return IsSipRequest;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateSipRequestToolDTO PickSipRequest() => SipRequest is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipRequest' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateVoicemailToolDTO? Voicemail { get; init; }
#else
        public global::Vapi.UpdateVoicemailToolDTO? Voicemail { get; }
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
        public bool TryPickVoicemail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.UpdateVoicemailToolDTO? value)
        {
            value = Voicemail;
            return IsVoicemail;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.UpdateVoicemailToolDTO PickVoicemail() => Voicemail is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Voicemail' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateApiRequestToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateApiRequestToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateApiRequestToolDTO?(ToolControllerUpdateRequest @this) => @this.ApiRequest;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateApiRequestToolDTO? value)
        {
            ApiRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromApiRequest(global::Vapi.UpdateApiRequestToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateCodeToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateCodeToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateCodeToolDTO?(ToolControllerUpdateRequest @this) => @this.Code;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateCodeToolDTO? value)
        {
            Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromCode(global::Vapi.UpdateCodeToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateDtmfToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateDtmfToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateDtmfToolDTO?(ToolControllerUpdateRequest @this) => @this.Dtmf;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateDtmfToolDTO? value)
        {
            Dtmf = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromDtmf(global::Vapi.UpdateDtmfToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateEndCallToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateEndCallToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateEndCallToolDTO?(ToolControllerUpdateRequest @this) => @this.EndCall;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateEndCallToolDTO? value)
        {
            EndCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromEndCall(global::Vapi.UpdateEndCallToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateFunctionToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateFunctionToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateFunctionToolDTO?(ToolControllerUpdateRequest @this) => @this.Function;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateFunctionToolDTO? value)
        {
            Function = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromFunction(global::Vapi.UpdateFunctionToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateKnowledgeBaseToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateKnowledgeBaseToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateKnowledgeBaseToolDTO?(ToolControllerUpdateRequest @this) => @this.KnowledgeBase;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateKnowledgeBaseToolDTO? value)
        {
            KnowledgeBase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromKnowledgeBase(global::Vapi.UpdateKnowledgeBaseToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateTransferCallToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateTransferCallToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateTransferCallToolDTO?(ToolControllerUpdateRequest @this) => @this.TransferCall;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateTransferCallToolDTO? value)
        {
            TransferCall = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromTransferCall(global::Vapi.UpdateTransferCallToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateHandoffToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateHandoffToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateHandoffToolDTO?(ToolControllerUpdateRequest @this) => @this.Handoff;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateHandoffToolDTO? value)
        {
            Handoff = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromHandoff(global::Vapi.UpdateHandoffToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateBashToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateBashToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateBashToolDTO?(ToolControllerUpdateRequest @this) => @this.Bash;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateBashToolDTO? value)
        {
            Bash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromBash(global::Vapi.UpdateBashToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateComputerToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateComputerToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateComputerToolDTO?(ToolControllerUpdateRequest @this) => @this.Computer;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateComputerToolDTO? value)
        {
            Computer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromComputer(global::Vapi.UpdateComputerToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateTextEditorToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateTextEditorToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateTextEditorToolDTO?(ToolControllerUpdateRequest @this) => @this.TextEditor;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateTextEditorToolDTO? value)
        {
            TextEditor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromTextEditor(global::Vapi.UpdateTextEditorToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateQueryToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateQueryToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateQueryToolDTO?(ToolControllerUpdateRequest @this) => @this.Query;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateQueryToolDTO? value)
        {
            Query = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromQuery(global::Vapi.UpdateQueryToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoogleCalendarCreateEventToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoogleCalendarCreateEventToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleCalendarEventCreate;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? value)
        {
            GoogleCalendarEventCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGoogleCalendarEventCreate(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoogleSheetsRowAppendToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoogleSheetsRowAppendToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleSheetsRowAppend;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? value)
        {
            GoogleSheetsRowAppend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGoogleSheetsRowAppend(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO?(ToolControllerUpdateRequest @this) => @this.GoogleCalendarAvailabilityCheck;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? value)
        {
            GoogleCalendarAvailabilityCheck = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGoogleCalendarAvailabilityCheck(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateSlackSendMessageToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateSlackSendMessageToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateSlackSendMessageToolDTO?(ToolControllerUpdateRequest @this) => @this.SlackMessageSend;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateSlackSendMessageToolDTO? value)
        {
            SlackMessageSend = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromSlackMessageSend(global::Vapi.UpdateSlackSendMessageToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateSmsToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateSmsToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateSmsToolDTO?(ToolControllerUpdateRequest @this) => @this.Sms;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateSmsToolDTO? value)
        {
            Sms = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromSms(global::Vapi.UpdateSmsToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateMcpToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateMcpToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateMcpToolDTO?(ToolControllerUpdateRequest @this) => @this.Mcp;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateMcpToolDTO? value)
        {
            Mcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromMcp(global::Vapi.UpdateMcpToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelCalendarAvailabilityCheck;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? value)
        {
            GohighlevelCalendarAvailabilityCheck = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGohighlevelCalendarAvailabilityCheck(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelCalendarEventCreate;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? value)
        {
            GohighlevelCalendarEventCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGohighlevelCalendarEventCreate(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelContactCreateToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoHighLevelContactCreateToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoHighLevelContactCreateToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelContactCreate;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelContactCreateToolDTO? value)
        {
            GohighlevelContactCreate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGohighlevelContactCreate(global::Vapi.UpdateGoHighLevelContactCreateToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelContactGetToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateGoHighLevelContactGetToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateGoHighLevelContactGetToolDTO?(ToolControllerUpdateRequest @this) => @this.GohighlevelContactGet;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateGoHighLevelContactGetToolDTO? value)
        {
            GohighlevelContactGet = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromGohighlevelContactGet(global::Vapi.UpdateGoHighLevelContactGetToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateSipRequestToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateSipRequestToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateSipRequestToolDTO?(ToolControllerUpdateRequest @this) => @this.SipRequest;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateSipRequestToolDTO? value)
        {
            SipRequest = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromSipRequest(global::Vapi.UpdateSipRequestToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolControllerUpdateRequest(global::Vapi.UpdateVoicemailToolDTO value) => new ToolControllerUpdateRequest((global::Vapi.UpdateVoicemailToolDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.UpdateVoicemailToolDTO?(ToolControllerUpdateRequest @this) => @this.Voicemail;

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(global::Vapi.UpdateVoicemailToolDTO? value)
        {
            Voicemail = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolControllerUpdateRequest FromVoicemail(global::Vapi.UpdateVoicemailToolDTO? value) => new ToolControllerUpdateRequest(value);

        /// <summary>
        ///
        /// </summary>
        public ToolControllerUpdateRequest(
            global::Vapi.ToolControllerUpdateRequestDiscriminatorType? type,
            global::Vapi.UpdateApiRequestToolDTO? apiRequest,
            global::Vapi.UpdateCodeToolDTO? code,
            global::Vapi.UpdateDtmfToolDTO? dtmf,
            global::Vapi.UpdateEndCallToolDTO? endCall,
            global::Vapi.UpdateFunctionToolDTO? function,
            global::Vapi.UpdateKnowledgeBaseToolDTO? knowledgeBase,
            global::Vapi.UpdateTransferCallToolDTO? transferCall,
            global::Vapi.UpdateHandoffToolDTO? handoff,
            global::Vapi.UpdateBashToolDTO? bash,
            global::Vapi.UpdateComputerToolDTO? computer,
            global::Vapi.UpdateTextEditorToolDTO? textEditor,
            global::Vapi.UpdateQueryToolDTO? query,
            global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate,
            global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend,
            global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck,
            global::Vapi.UpdateSlackSendMessageToolDTO? slackMessageSend,
            global::Vapi.UpdateSmsToolDTO? sms,
            global::Vapi.UpdateMcpToolDTO? mcp,
            global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck,
            global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate,
            global::Vapi.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate,
            global::Vapi.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet,
            global::Vapi.UpdateSipRequestToolDTO? sipRequest,
            global::Vapi.UpdateVoicemailToolDTO? voicemail
            )
        {
            Type = type;

            ApiRequest = apiRequest;
            Code = code;
            Dtmf = dtmf;
            EndCall = endCall;
            Function = function;
            KnowledgeBase = knowledgeBase;
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
            KnowledgeBase as object ??
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
            KnowledgeBase?.ToString() ??
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
            return IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && IsGohighlevelContactGet && !IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && IsSipRequest && !IsVoicemail || !IsApiRequest && !IsCode && !IsDtmf && !IsEndCall && !IsFunction && !IsKnowledgeBase && !IsTransferCall && !IsHandoff && !IsBash && !IsComputer && !IsTextEditor && !IsQuery && !IsGoogleCalendarEventCreate && !IsGoogleSheetsRowAppend && !IsGoogleCalendarAvailabilityCheck && !IsSlackMessageSend && !IsSms && !IsMcp && !IsGohighlevelCalendarAvailabilityCheck && !IsGohighlevelCalendarEventCreate && !IsGohighlevelContactCreate && !IsGohighlevelContactGet && !IsSipRequest && IsVoicemail;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.UpdateApiRequestToolDTO, TResult>? apiRequest = null,
            global::System.Func<global::Vapi.UpdateCodeToolDTO, TResult>? code = null,
            global::System.Func<global::Vapi.UpdateDtmfToolDTO, TResult>? dtmf = null,
            global::System.Func<global::Vapi.UpdateEndCallToolDTO, TResult>? endCall = null,
            global::System.Func<global::Vapi.UpdateFunctionToolDTO, TResult>? function = null,
            global::System.Func<global::Vapi.UpdateKnowledgeBaseToolDTO, TResult>? knowledgeBase = null,
            global::System.Func<global::Vapi.UpdateTransferCallToolDTO, TResult>? transferCall = null,
            global::System.Func<global::Vapi.UpdateHandoffToolDTO, TResult>? handoff = null,
            global::System.Func<global::Vapi.UpdateBashToolDTO, TResult>? bash = null,
            global::System.Func<global::Vapi.UpdateComputerToolDTO, TResult>? computer = null,
            global::System.Func<global::Vapi.UpdateTextEditorToolDTO, TResult>? textEditor = null,
            global::System.Func<global::Vapi.UpdateQueryToolDTO, TResult>? query = null,
            global::System.Func<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO, TResult>? googleCalendarEventCreate = null,
            global::System.Func<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO, TResult>? googleSheetsRowAppend = null,
            global::System.Func<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO, TResult>? googleCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.UpdateSlackSendMessageToolDTO, TResult>? slackMessageSend = null,
            global::System.Func<global::Vapi.UpdateSmsToolDTO, TResult>? sms = null,
            global::System.Func<global::Vapi.UpdateMcpToolDTO, TResult>? mcp = null,
            global::System.Func<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO, TResult>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Func<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO, TResult>? gohighlevelCalendarEventCreate = null,
            global::System.Func<global::Vapi.UpdateGoHighLevelContactCreateToolDTO, TResult>? gohighlevelContactCreate = null,
            global::System.Func<global::Vapi.UpdateGoHighLevelContactGetToolDTO, TResult>? gohighlevelContactGet = null,
            global::System.Func<global::Vapi.UpdateSipRequestToolDTO, TResult>? sipRequest = null,
            global::System.Func<global::Vapi.UpdateVoicemailToolDTO, TResult>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0 && apiRequest != null)
            {
                return apiRequest(__value0);
            }
            else if (Code is { } __value1 && code != null)
            {
                return code(__value1);
            }
            else if (Dtmf is { } __value2 && dtmf != null)
            {
                return dtmf(__value2);
            }
            else if (EndCall is { } __value3 && endCall != null)
            {
                return endCall(__value3);
            }
            else if (Function is { } __value4 && function != null)
            {
                return function(__value4);
            }
            else if (KnowledgeBase is { } __value5 && knowledgeBase != null)
            {
                return knowledgeBase(__value5);
            }
            else if (TransferCall is { } __value6 && transferCall != null)
            {
                return transferCall(__value6);
            }
            else if (Handoff is { } __value7 && handoff != null)
            {
                return handoff(__value7);
            }
            else if (Bash is { } __value8 && bash != null)
            {
                return bash(__value8);
            }
            else if (Computer is { } __value9 && computer != null)
            {
                return computer(__value9);
            }
            else if (TextEditor is { } __value10 && textEditor != null)
            {
                return textEditor(__value10);
            }
            else if (Query is { } __value11 && query != null)
            {
                return query(__value11);
            }
            else if (GoogleCalendarEventCreate is { } __value12 && googleCalendarEventCreate != null)
            {
                return googleCalendarEventCreate(__value12);
            }
            else if (GoogleSheetsRowAppend is { } __value13 && googleSheetsRowAppend != null)
            {
                return googleSheetsRowAppend(__value13);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value14 && googleCalendarAvailabilityCheck != null)
            {
                return googleCalendarAvailabilityCheck(__value14);
            }
            else if (SlackMessageSend is { } __value15 && slackMessageSend != null)
            {
                return slackMessageSend(__value15);
            }
            else if (Sms is { } __value16 && sms != null)
            {
                return sms(__value16);
            }
            else if (Mcp is { } __value17 && mcp != null)
            {
                return mcp(__value17);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value18 && gohighlevelCalendarAvailabilityCheck != null)
            {
                return gohighlevelCalendarAvailabilityCheck(__value18);
            }
            else if (GohighlevelCalendarEventCreate is { } __value19 && gohighlevelCalendarEventCreate != null)
            {
                return gohighlevelCalendarEventCreate(__value19);
            }
            else if (GohighlevelContactCreate is { } __value20 && gohighlevelContactCreate != null)
            {
                return gohighlevelContactCreate(__value20);
            }
            else if (GohighlevelContactGet is { } __value21 && gohighlevelContactGet != null)
            {
                return gohighlevelContactGet(__value21);
            }
            else if (SipRequest is { } __value22 && sipRequest != null)
            {
                return sipRequest(__value22);
            }
            else if (Voicemail is { } __value23 && voicemail != null)
            {
                return voicemail(__value23);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.UpdateApiRequestToolDTO>? apiRequest = null,

            global::System.Action<global::Vapi.UpdateCodeToolDTO>? code = null,

            global::System.Action<global::Vapi.UpdateDtmfToolDTO>? dtmf = null,

            global::System.Action<global::Vapi.UpdateEndCallToolDTO>? endCall = null,

            global::System.Action<global::Vapi.UpdateFunctionToolDTO>? function = null,

            global::System.Action<global::Vapi.UpdateKnowledgeBaseToolDTO>? knowledgeBase = null,

            global::System.Action<global::Vapi.UpdateTransferCallToolDTO>? transferCall = null,

            global::System.Action<global::Vapi.UpdateHandoffToolDTO>? handoff = null,

            global::System.Action<global::Vapi.UpdateBashToolDTO>? bash = null,

            global::System.Action<global::Vapi.UpdateComputerToolDTO>? computer = null,

            global::System.Action<global::Vapi.UpdateTextEditorToolDTO>? textEditor = null,

            global::System.Action<global::Vapi.UpdateQueryToolDTO>? query = null,

            global::System.Action<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO>? googleCalendarEventCreate = null,

            global::System.Action<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO>? googleSheetsRowAppend = null,

            global::System.Action<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO>? googleCalendarAvailabilityCheck = null,

            global::System.Action<global::Vapi.UpdateSlackSendMessageToolDTO>? slackMessageSend = null,

            global::System.Action<global::Vapi.UpdateSmsToolDTO>? sms = null,

            global::System.Action<global::Vapi.UpdateMcpToolDTO>? mcp = null,

            global::System.Action<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO>? gohighlevelCalendarAvailabilityCheck = null,

            global::System.Action<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO>? gohighlevelCalendarEventCreate = null,

            global::System.Action<global::Vapi.UpdateGoHighLevelContactCreateToolDTO>? gohighlevelContactCreate = null,

            global::System.Action<global::Vapi.UpdateGoHighLevelContactGetToolDTO>? gohighlevelContactGet = null,

            global::System.Action<global::Vapi.UpdateSipRequestToolDTO>? sipRequest = null,

            global::System.Action<global::Vapi.UpdateVoicemailToolDTO>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0)
            {
                apiRequest?.Invoke(__value0);
            }
            else if (Code is { } __value1)
            {
                code?.Invoke(__value1);
            }
            else if (Dtmf is { } __value2)
            {
                dtmf?.Invoke(__value2);
            }
            else if (EndCall is { } __value3)
            {
                endCall?.Invoke(__value3);
            }
            else if (Function is { } __value4)
            {
                function?.Invoke(__value4);
            }
            else if (KnowledgeBase is { } __value5)
            {
                knowledgeBase?.Invoke(__value5);
            }
            else if (TransferCall is { } __value6)
            {
                transferCall?.Invoke(__value6);
            }
            else if (Handoff is { } __value7)
            {
                handoff?.Invoke(__value7);
            }
            else if (Bash is { } __value8)
            {
                bash?.Invoke(__value8);
            }
            else if (Computer is { } __value9)
            {
                computer?.Invoke(__value9);
            }
            else if (TextEditor is { } __value10)
            {
                textEditor?.Invoke(__value10);
            }
            else if (Query is { } __value11)
            {
                query?.Invoke(__value11);
            }
            else if (GoogleCalendarEventCreate is { } __value12)
            {
                googleCalendarEventCreate?.Invoke(__value12);
            }
            else if (GoogleSheetsRowAppend is { } __value13)
            {
                googleSheetsRowAppend?.Invoke(__value13);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value14)
            {
                googleCalendarAvailabilityCheck?.Invoke(__value14);
            }
            else if (SlackMessageSend is { } __value15)
            {
                slackMessageSend?.Invoke(__value15);
            }
            else if (Sms is { } __value16)
            {
                sms?.Invoke(__value16);
            }
            else if (Mcp is { } __value17)
            {
                mcp?.Invoke(__value17);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value18)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(__value18);
            }
            else if (GohighlevelCalendarEventCreate is { } __value19)
            {
                gohighlevelCalendarEventCreate?.Invoke(__value19);
            }
            else if (GohighlevelContactCreate is { } __value20)
            {
                gohighlevelContactCreate?.Invoke(__value20);
            }
            else if (GohighlevelContactGet is { } __value21)
            {
                gohighlevelContactGet?.Invoke(__value21);
            }
            else if (SipRequest is { } __value22)
            {
                sipRequest?.Invoke(__value22);
            }
            else if (Voicemail is { } __value23)
            {
                voicemail?.Invoke(__value23);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vapi.UpdateApiRequestToolDTO>? apiRequest = null,
            global::System.Action<global::Vapi.UpdateCodeToolDTO>? code = null,
            global::System.Action<global::Vapi.UpdateDtmfToolDTO>? dtmf = null,
            global::System.Action<global::Vapi.UpdateEndCallToolDTO>? endCall = null,
            global::System.Action<global::Vapi.UpdateFunctionToolDTO>? function = null,
            global::System.Action<global::Vapi.UpdateKnowledgeBaseToolDTO>? knowledgeBase = null,
            global::System.Action<global::Vapi.UpdateTransferCallToolDTO>? transferCall = null,
            global::System.Action<global::Vapi.UpdateHandoffToolDTO>? handoff = null,
            global::System.Action<global::Vapi.UpdateBashToolDTO>? bash = null,
            global::System.Action<global::Vapi.UpdateComputerToolDTO>? computer = null,
            global::System.Action<global::Vapi.UpdateTextEditorToolDTO>? textEditor = null,
            global::System.Action<global::Vapi.UpdateQueryToolDTO>? query = null,
            global::System.Action<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO>? googleCalendarEventCreate = null,
            global::System.Action<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO>? googleSheetsRowAppend = null,
            global::System.Action<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO>? googleCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.UpdateSlackSendMessageToolDTO>? slackMessageSend = null,
            global::System.Action<global::Vapi.UpdateSmsToolDTO>? sms = null,
            global::System.Action<global::Vapi.UpdateMcpToolDTO>? mcp = null,
            global::System.Action<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO>? gohighlevelCalendarAvailabilityCheck = null,
            global::System.Action<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO>? gohighlevelCalendarEventCreate = null,
            global::System.Action<global::Vapi.UpdateGoHighLevelContactCreateToolDTO>? gohighlevelContactCreate = null,
            global::System.Action<global::Vapi.UpdateGoHighLevelContactGetToolDTO>? gohighlevelContactGet = null,
            global::System.Action<global::Vapi.UpdateSipRequestToolDTO>? sipRequest = null,
            global::System.Action<global::Vapi.UpdateVoicemailToolDTO>? voicemail = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ApiRequest is { } __value0)
            {
                apiRequest?.Invoke(__value0);
            }
            else if (Code is { } __value1)
            {
                code?.Invoke(__value1);
            }
            else if (Dtmf is { } __value2)
            {
                dtmf?.Invoke(__value2);
            }
            else if (EndCall is { } __value3)
            {
                endCall?.Invoke(__value3);
            }
            else if (Function is { } __value4)
            {
                function?.Invoke(__value4);
            }
            else if (KnowledgeBase is { } __value5)
            {
                knowledgeBase?.Invoke(__value5);
            }
            else if (TransferCall is { } __value6)
            {
                transferCall?.Invoke(__value6);
            }
            else if (Handoff is { } __value7)
            {
                handoff?.Invoke(__value7);
            }
            else if (Bash is { } __value8)
            {
                bash?.Invoke(__value8);
            }
            else if (Computer is { } __value9)
            {
                computer?.Invoke(__value9);
            }
            else if (TextEditor is { } __value10)
            {
                textEditor?.Invoke(__value10);
            }
            else if (Query is { } __value11)
            {
                query?.Invoke(__value11);
            }
            else if (GoogleCalendarEventCreate is { } __value12)
            {
                googleCalendarEventCreate?.Invoke(__value12);
            }
            else if (GoogleSheetsRowAppend is { } __value13)
            {
                googleSheetsRowAppend?.Invoke(__value13);
            }
            else if (GoogleCalendarAvailabilityCheck is { } __value14)
            {
                googleCalendarAvailabilityCheck?.Invoke(__value14);
            }
            else if (SlackMessageSend is { } __value15)
            {
                slackMessageSend?.Invoke(__value15);
            }
            else if (Sms is { } __value16)
            {
                sms?.Invoke(__value16);
            }
            else if (Mcp is { } __value17)
            {
                mcp?.Invoke(__value17);
            }
            else if (GohighlevelCalendarAvailabilityCheck is { } __value18)
            {
                gohighlevelCalendarAvailabilityCheck?.Invoke(__value18);
            }
            else if (GohighlevelCalendarEventCreate is { } __value19)
            {
                gohighlevelCalendarEventCreate?.Invoke(__value19);
            }
            else if (GohighlevelContactCreate is { } __value20)
            {
                gohighlevelContactCreate?.Invoke(__value20);
            }
            else if (GohighlevelContactGet is { } __value21)
            {
                gohighlevelContactGet?.Invoke(__value21);
            }
            else if (SipRequest is { } __value22)
            {
                sipRequest?.Invoke(__value22);
            }
            else if (Voicemail is { } __value23)
            {
                voicemail?.Invoke(__value23);
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
                typeof(global::Vapi.UpdateApiRequestToolDTO),
                Code,
                typeof(global::Vapi.UpdateCodeToolDTO),
                Dtmf,
                typeof(global::Vapi.UpdateDtmfToolDTO),
                EndCall,
                typeof(global::Vapi.UpdateEndCallToolDTO),
                Function,
                typeof(global::Vapi.UpdateFunctionToolDTO),
                KnowledgeBase,
                typeof(global::Vapi.UpdateKnowledgeBaseToolDTO),
                TransferCall,
                typeof(global::Vapi.UpdateTransferCallToolDTO),
                Handoff,
                typeof(global::Vapi.UpdateHandoffToolDTO),
                Bash,
                typeof(global::Vapi.UpdateBashToolDTO),
                Computer,
                typeof(global::Vapi.UpdateComputerToolDTO),
                TextEditor,
                typeof(global::Vapi.UpdateTextEditorToolDTO),
                Query,
                typeof(global::Vapi.UpdateQueryToolDTO),
                GoogleCalendarEventCreate,
                typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO),
                GoogleSheetsRowAppend,
                typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO),
                GoogleCalendarAvailabilityCheck,
                typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO),
                SlackMessageSend,
                typeof(global::Vapi.UpdateSlackSendMessageToolDTO),
                Sms,
                typeof(global::Vapi.UpdateSmsToolDTO),
                Mcp,
                typeof(global::Vapi.UpdateMcpToolDTO),
                GohighlevelCalendarAvailabilityCheck,
                typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO),
                GohighlevelCalendarEventCreate,
                typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO),
                GohighlevelContactCreate,
                typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO),
                GohighlevelContactGet,
                typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO),
                SipRequest,
                typeof(global::Vapi.UpdateSipRequestToolDTO),
                Voicemail,
                typeof(global::Vapi.UpdateVoicemailToolDTO),
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
        public bool Equals(ToolControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateApiRequestToolDTO?>.Default.Equals(ApiRequest, other.ApiRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateCodeToolDTO?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateDtmfToolDTO?>.Default.Equals(Dtmf, other.Dtmf) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateEndCallToolDTO?>.Default.Equals(EndCall, other.EndCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateFunctionToolDTO?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateKnowledgeBaseToolDTO?>.Default.Equals(KnowledgeBase, other.KnowledgeBase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateTransferCallToolDTO?>.Default.Equals(TransferCall, other.TransferCall) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateHandoffToolDTO?>.Default.Equals(Handoff, other.Handoff) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateBashToolDTO?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateComputerToolDTO?>.Default.Equals(Computer, other.Computer) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateTextEditorToolDTO?>.Default.Equals(TextEditor, other.TextEditor) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateQueryToolDTO?>.Default.Equals(Query, other.Query) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO?>.Default.Equals(GoogleCalendarEventCreate, other.GoogleCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO?>.Default.Equals(GoogleSheetsRowAppend, other.GoogleSheetsRowAppend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO?>.Default.Equals(GoogleCalendarAvailabilityCheck, other.GoogleCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateSlackSendMessageToolDTO?>.Default.Equals(SlackMessageSend, other.SlackMessageSend) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateSmsToolDTO?>.Default.Equals(Sms, other.Sms) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateMcpToolDTO?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO?>.Default.Equals(GohighlevelCalendarAvailabilityCheck, other.GohighlevelCalendarAvailabilityCheck) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO?>.Default.Equals(GohighlevelCalendarEventCreate, other.GohighlevelCalendarEventCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoHighLevelContactCreateToolDTO?>.Default.Equals(GohighlevelContactCreate, other.GohighlevelContactCreate) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateGoHighLevelContactGetToolDTO?>.Default.Equals(GohighlevelContactGet, other.GohighlevelContactGet) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateSipRequestToolDTO?>.Default.Equals(SipRequest, other.SipRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateVoicemailToolDTO?>.Default.Equals(Voicemail, other.Voicemail)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolControllerUpdateRequest obj1, ToolControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolControllerUpdateRequest obj1, ToolControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolControllerUpdateRequest o && Equals(o);
        }
    }
}
