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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolControllerCreateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolControllerCreateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolControllerCreateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.CreateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateApiRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateApiRequestToolDTO)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCodeToolDTO? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCodeToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCodeToolDTO)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDtmfToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateDtmfToolDTO)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateEndCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateEndCallToolDTO)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateFunctionToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateFunctionToolDTO)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTransferCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTransferCallToolDTO)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateHandoffToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateHandoffToolDTO)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateBashToolDTO? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateBashToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateBashToolDTO)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateComputerToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateComputerToolDTO)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTextEditorToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTextEditorToolDTO)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateQueryToolDTO? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateQueryToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateQueryToolDTO)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarCreateEventToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleSheetsRowAppendToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackSendMessageToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSlackSendMessageToolDTO)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSmsToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSmsToolDTO)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMcpToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateMcpToolDTO)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelContactCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelContactCreateToolDTO)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelContactGetToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelContactGetToolDTO)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSipRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSipRequestToolDTO)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerCreateRequestDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVoicemailToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateVoicemailToolDTO)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateApiRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateApiRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCodeToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCodeToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDtmfToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateDtmfToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateEndCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateEndCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateFunctionToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateFunctionToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTransferCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTransferCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateHandoffToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateHandoffToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateBashToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateBashToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateComputerToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateComputerToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTextEditorToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTextEditorToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateQueryToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateQueryToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarCreateEventToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleSheetsRowAppendToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackSendMessageToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSlackSendMessageToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSmsToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSmsToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMcpToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateMcpToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelContactCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelContactGetToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSipRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSipRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVoicemailToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateVoicemailToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeInfo);
            }
        }
    }
}