#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ToolControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.ToolControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ToolControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.UpdateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateApiRequestToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateCodeToolDTO? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateCodeToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateDtmfToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateEndCallToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateFunctionToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateTransferCallToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateHandoffToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateBashToolDTO? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateBashToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateComputerToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateTextEditorToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateQueryToolDTO? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateQueryToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateSlackSendMessageToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateSmsToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateMcpToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoHighLevelContactCreateToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateGoHighLevelContactGetToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateSipRequestToolDTO>(ref reader, options);
            }
            global::Vapi.UpdateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateVoicemailToolDTO>(ref reader, options);
            }

            var __value = new global::Vapi.ToolControllerUpdateRequest(
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
            global::Vapi.ToolControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::Vapi.UpdateApiRequestToolDTO), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::Vapi.UpdateCodeToolDTO), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::Vapi.UpdateDtmfToolDTO), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::Vapi.UpdateEndCallToolDTO), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Vapi.UpdateFunctionToolDTO), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::Vapi.UpdateTransferCallToolDTO), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::Vapi.UpdateHandoffToolDTO), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::Vapi.UpdateBashToolDTO), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::Vapi.UpdateComputerToolDTO), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::Vapi.UpdateTextEditorToolDTO), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::Vapi.UpdateQueryToolDTO), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::Vapi.UpdateSmsToolDTO), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::Vapi.UpdateMcpToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::Vapi.UpdateSipRequestToolDTO), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::Vapi.UpdateVoicemailToolDTO), options);
            }
        }
    }
}