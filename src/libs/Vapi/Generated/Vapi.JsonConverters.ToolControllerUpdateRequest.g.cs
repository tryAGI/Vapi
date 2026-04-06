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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.UpdateApiRequestToolDTO? apiRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.ApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateApiRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateApiRequestToolDTO)}");
                apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateCodeToolDTO? code = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateCodeToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateCodeToolDTO)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateDtmfToolDTO? dtmf = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Dtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateDtmfToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateDtmfToolDTO)}");
                dtmf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateEndCallToolDTO? endCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateEndCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateEndCallToolDTO)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateFunctionToolDTO? function = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateFunctionToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateFunctionToolDTO)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateTransferCallToolDTO? transferCall = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.TransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTransferCallToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateTransferCallToolDTO)}");
                transferCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateHandoffToolDTO? handoff = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Handoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateHandoffToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateHandoffToolDTO)}");
                handoff = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateBashToolDTO? bash = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Bash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBashToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateBashToolDTO)}");
                bash = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateComputerToolDTO? computer = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Computer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateComputerToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateComputerToolDTO)}");
                computer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateTextEditorToolDTO? textEditor = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.TextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextEditorToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateTextEditorToolDTO)}");
                textEditor = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateQueryToolDTO? query = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateQueryToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateQueryToolDTO)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO)}");
                googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO)}");
                googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO)}");
                googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateSlackSendMessageToolDTO? slackMessageSend = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.SlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSlackSendMessageToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateSlackSendMessageToolDTO)}");
                slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateSmsToolDTO? sms = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Sms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSmsToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateSmsToolDTO)}");
                sms = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateMcpToolDTO? mcp = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateMcpToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateMcpToolDTO)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO)}");
                gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO)}");
                gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactCreateToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO)}");
                gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.GohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactGetToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateGoHighLevelContactGetToolDTO)}");
                gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateSipRequestToolDTO? sipRequest = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.SipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSipRequestToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateSipRequestToolDTO)}");
                sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateVoicemailToolDTO? voicemail = default;
            if (discriminator?.Type == global::Vapi.ToolControllerUpdateRequestDiscriminatorType.Voicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVoicemailToolDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateVoicemailToolDTO)}");
                voicemail = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsApiRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateApiRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateApiRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateCodeToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateCodeToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateDtmfToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateDtmfToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf!, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateEndCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateEndCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall!, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateFunctionToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateFunctionToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function!, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTransferCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTransferCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall!, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateHandoffToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateHandoffToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff!, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBashToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateBashToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash!, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateComputerToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateComputerToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer!, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextEditorToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTextEditorToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor!, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateQueryToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateQueryToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query!, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend!, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSlackSendMessageToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSlackSendMessageToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend!, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSmsToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSmsToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateMcpToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateMcpToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck!, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate!, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactGetToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet!, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSipRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSipRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest!, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVoicemailToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVoicemailToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail!, typeInfo);
            }
        }
    }
}