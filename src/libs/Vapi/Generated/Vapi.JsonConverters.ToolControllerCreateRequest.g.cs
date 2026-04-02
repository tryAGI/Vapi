#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ToolControllerCreateRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.ToolControllerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ToolControllerCreateRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.CreateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateApiRequestToolDTO>(ref reader, options);
            }
            global::Vapi.CreateCodeToolDTO? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCodeToolDTO>(ref reader, options);
            }
            global::Vapi.CreateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateDtmfToolDTO>(ref reader, options);
            }
            global::Vapi.CreateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateEndCallToolDTO>(ref reader, options);
            }
            global::Vapi.CreateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateFunctionToolDTO>(ref reader, options);
            }
            global::Vapi.CreateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTransferCallToolDTO>(ref reader, options);
            }
            global::Vapi.CreateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateHandoffToolDTO>(ref reader, options);
            }
            global::Vapi.CreateBashToolDTO? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateBashToolDTO>(ref reader, options);
            }
            global::Vapi.CreateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateComputerToolDTO>(ref reader, options);
            }
            global::Vapi.CreateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTextEditorToolDTO>(ref reader, options);
            }
            global::Vapi.CreateQueryToolDTO? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateQueryToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleCalendarCreateEventToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleSheetsRowAppendToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO>(ref reader, options);
            }
            global::Vapi.CreateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSlackSendMessageToolDTO>(ref reader, options);
            }
            global::Vapi.CreateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSmsToolDTO>(ref reader, options);
            }
            global::Vapi.CreateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateMcpToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelContactCreateToolDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelContactGetToolDTO>(ref reader, options);
            }
            global::Vapi.CreateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSipRequestToolDTO>(ref reader, options);
            }
            global::Vapi.CreateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateVoicemailToolDTO>(ref reader, options);
            }

            var __value = new global::Vapi.ToolControllerCreateRequest(
                discriminator?.Type,
                apiRequest,

                code,

                dtmf,

                endCall,

                function,

                transferCall,

                handoff,

                bash,

                computer,

                textEditor,

                query,

                googleCalendarEventCreate,

                googleSheetsRowAppend,

                googleCalendarAvailabilityCheck,

                slackMessageSend,

                sms,

                mcp,

                gohighlevelCalendarAvailabilityCheck,

                gohighlevelCalendarEventCreate,

                gohighlevelContactCreate,

                gohighlevelContactGet,

                sipRequest,

                voicemail
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.ToolControllerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::Vapi.CreateApiRequestToolDTO), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::Vapi.CreateCodeToolDTO), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::Vapi.CreateDtmfToolDTO), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::Vapi.CreateEndCallToolDTO), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Vapi.CreateFunctionToolDTO), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::Vapi.CreateTransferCallToolDTO), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::Vapi.CreateHandoffToolDTO), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::Vapi.CreateBashToolDTO), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::Vapi.CreateComputerToolDTO), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::Vapi.CreateTextEditorToolDTO), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::Vapi.CreateQueryToolDTO), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::Vapi.CreateSlackSendMessageToolDTO), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::Vapi.CreateSmsToolDTO), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::Vapi.CreateMcpToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::Vapi.CreateSipRequestToolDTO), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::Vapi.CreateVoicemailToolDTO), options);
            }
        }
    }
}