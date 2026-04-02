#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ToolControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.ToolControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ToolControllerRemoveResponseDiscriminator>(ref readerCopy, options);

            global::Vapi.ApiRequestTool? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.ApiRequest)
            {
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ApiRequestTool>(ref reader, options);
            }
            global::Vapi.CodeTool? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Code)
            {
                code = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CodeTool>(ref reader, options);
            }
            global::Vapi.DtmfTool? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Dtmf)
            {
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.DtmfTool>(ref reader, options);
            }
            global::Vapi.EndCallTool? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.EndCallTool>(ref reader, options);
            }
            global::Vapi.FunctionTool? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Function)
            {
                function = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.FunctionTool>(ref reader, options);
            }
            global::Vapi.GhlTool? ghl = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Ghl)
            {
                ghl = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GhlTool>(ref reader, options);
            }
            global::Vapi.TransferCallTool? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.TransferCall)
            {
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.TransferCallTool>(ref reader, options);
            }
            global::Vapi.HandoffTool? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Handoff)
            {
                handoff = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.HandoffTool>(ref reader, options);
            }
            global::Vapi.BashTool? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Bash)
            {
                bash = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.BashTool>(ref reader, options);
            }
            global::Vapi.ComputerTool? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Computer)
            {
                computer = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ComputerTool>(ref reader, options);
            }
            global::Vapi.TextEditorTool? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.TextEditor)
            {
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.TextEditorTool>(ref reader, options);
            }
            global::Vapi.QueryTool? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Query)
            {
                query = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.QueryTool>(ref reader, options);
            }
            global::Vapi.GoogleCalendarCreateEventTool? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarEventCreate)
            {
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoogleCalendarCreateEventTool>(ref reader, options);
            }
            global::Vapi.GoogleSheetsRowAppendTool? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GoogleSheetsRowAppend)
            {
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoogleSheetsRowAppendTool>(ref reader, options);
            }
            global::Vapi.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoogleCalendarCheckAvailabilityTool>(ref reader, options);
            }
            global::Vapi.SlackSendMessageTool? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.SlackMessageSend)
            {
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.SlackSendMessageTool>(ref reader, options);
            }
            global::Vapi.SmsTool? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Sms)
            {
                sms = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.SmsTool>(ref reader, options);
            }
            global::Vapi.McpTool? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.McpTool>(ref reader, options);
            }
            global::Vapi.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoHighLevelCalendarAvailabilityTool>(ref reader, options);
            }
            global::Vapi.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoHighLevelCalendarEventCreateTool>(ref reader, options);
            }
            global::Vapi.GoHighLevelContactCreateTool? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactCreate)
            {
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoHighLevelContactCreateTool>(ref reader, options);
            }
            global::Vapi.GoHighLevelContactGetTool? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.GohighlevelContactGet)
            {
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.GoHighLevelContactGetTool>(ref reader, options);
            }
            global::Vapi.SipRequestTool? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.SipRequest)
            {
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.SipRequestTool>(ref reader, options);
            }
            global::Vapi.VoicemailTool? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerRemoveResponseDiscriminatorType.Voicemail)
            {
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.VoicemailTool>(ref reader, options);
            }

            var __value = new global::Vapi.ToolControllerRemoveResponse(
                discriminator?.Type,
                apiRequest,

                code,

                dtmf,

                endCall,

                function,

                ghl,

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
            global::Vapi.ToolControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsApiRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeof(global::Vapi.ApiRequestTool), options);
            }
            else if (value.IsCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeof(global::Vapi.CodeTool), options);
            }
            else if (value.IsDtmf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeof(global::Vapi.DtmfTool), options);
            }
            else if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::Vapi.EndCallTool), options);
            }
            else if (value.IsFunction)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeof(global::Vapi.FunctionTool), options);
            }
            else if (value.IsGhl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ghl, typeof(global::Vapi.GhlTool), options);
            }
            else if (value.IsTransferCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeof(global::Vapi.TransferCallTool), options);
            }
            else if (value.IsHandoff)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeof(global::Vapi.HandoffTool), options);
            }
            else if (value.IsBash)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeof(global::Vapi.BashTool), options);
            }
            else if (value.IsComputer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeof(global::Vapi.ComputerTool), options);
            }
            else if (value.IsTextEditor)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeof(global::Vapi.TextEditorTool), options);
            }
            else if (value.IsQuery)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeof(global::Vapi.QueryTool), options);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeof(global::Vapi.GoogleCalendarCreateEventTool), options);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeof(global::Vapi.GoogleSheetsRowAppendTool), options);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool), options);
            }
            else if (value.IsSlackMessageSend)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeof(global::Vapi.SlackSendMessageTool), options);
            }
            else if (value.IsSms)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeof(global::Vapi.SmsTool), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::Vapi.McpTool), options);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool), options);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeof(global::Vapi.GoHighLevelCalendarEventCreateTool), options);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeof(global::Vapi.GoHighLevelContactCreateTool), options);
            }
            else if (value.IsGohighlevelContactGet)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeof(global::Vapi.GoHighLevelContactGetTool), options);
            }
            else if (value.IsSipRequest)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeof(global::Vapi.SipRequestTool), options);
            }
            else if (value.IsVoicemail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeof(global::Vapi.VoicemailTool), options);
            }
        }
    }
}