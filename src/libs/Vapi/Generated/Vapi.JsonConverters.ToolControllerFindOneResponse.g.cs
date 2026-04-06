#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerFindOneResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ToolControllerFindOneResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.ToolControllerFindOneResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolControllerFindOneResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolControllerFindOneResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolControllerFindOneResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.ApiRequestTool? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ApiRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ApiRequestTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ApiRequestTool)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CodeTool? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CodeTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CodeTool)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.DtmfTool? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.DtmfTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.DtmfTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.DtmfTool)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.EndCallTool? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.EndCallTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.EndCallTool)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.FunctionTool? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.FunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.FunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GhlTool? ghl = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Ghl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GhlTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GhlTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GhlTool)}");
                ghl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.TransferCallTool? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TransferCallTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TransferCallTool)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.HandoffTool? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.HandoffTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.HandoffTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.HandoffTool)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.BashTool? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BashTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BashTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.BashTool)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.ComputerTool? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ComputerTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ComputerTool)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.TextEditorTool? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TextEditorTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TextEditorTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TextEditorTool)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.QueryTool? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.QueryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.QueryTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.QueryTool)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoogleCalendarCreateEventTool? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleCalendarCreateEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleCalendarCreateEventTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoogleCalendarCreateEventTool)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoogleSheetsRowAppendTool? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleSheetsRowAppendTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleSheetsRowAppendTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoogleSheetsRowAppendTool)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoogleCalendarCheckAvailabilityTool? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleCalendarCheckAvailabilityTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoogleCalendarCheckAvailabilityTool)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.SlackSendMessageTool? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SlackSendMessageTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SlackSendMessageTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.SlackSendMessageTool)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.SmsTool? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SmsTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SmsTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.SmsTool)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.McpTool? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.McpTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.McpTool)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoHighLevelCalendarAvailabilityTool? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelCalendarAvailabilityTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoHighLevelCalendarAvailabilityTool)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoHighLevelCalendarEventCreateTool? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelCalendarEventCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelCalendarEventCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoHighLevelCalendarEventCreateTool)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoHighLevelContactCreateTool? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelContactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelContactCreateTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoHighLevelContactCreateTool)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.GoHighLevelContactGetTool? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelContactGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelContactGetTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.GoHighLevelContactGetTool)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.SipRequestTool? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SipRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SipRequestTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.SipRequestTool)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.VoicemailTool? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerFindOneResponseDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VoicemailTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VoicemailTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.VoicemailTool)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.ToolControllerFindOneResponse(
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
            global::Vapi.ToolControllerFindOneResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ApiRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ApiRequestTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.ApiRequestTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CodeTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CodeTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CodeTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.DtmfTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.DtmfTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.DtmfTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf!, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.EndCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.EndCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.EndCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.FunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.FunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.FunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsGhl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GhlTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GhlTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GhlTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ghl!, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TransferCallTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TransferCallTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TransferCallTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.HandoffTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.HandoffTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.HandoffTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff!, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BashTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BashTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.BashTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash!, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ComputerTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ComputerTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.ComputerTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer!, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TextEditorTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TextEditorTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TextEditorTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor!, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.QueryTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.QueryTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.QueryTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query!, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleCalendarCreateEventTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleCalendarCreateEventTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoogleCalendarCreateEventTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleSheetsRowAppendTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleSheetsRowAppendTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoogleSheetsRowAppendTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend!, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoogleCalendarCheckAvailabilityTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SlackSendMessageTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SlackSendMessageTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.SlackSendMessageTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend!, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SmsTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SmsTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.SmsTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.McpTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.McpTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.McpTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelCalendarAvailabilityTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelCalendarEventCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelCalendarEventCreateTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoHighLevelCalendarEventCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelContactCreateTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelContactCreateTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoHighLevelContactCreateTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.GoHighLevelContactGetTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.GoHighLevelContactGetTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.GoHighLevelContactGetTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet!, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.SipRequestTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.SipRequestTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.SipRequestTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest!, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VoicemailTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VoicemailTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.VoicemailTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail!, typeInfo);
            }
        }
    }
}