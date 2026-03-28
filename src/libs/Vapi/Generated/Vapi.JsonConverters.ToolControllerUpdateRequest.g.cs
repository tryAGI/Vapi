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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("backoffPlan")) __score0++;
            if (__jsonProps.Contains("body")) __score0++;
            if (__jsonProps.Contains("credentialId")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("encryptedPaths")) __score0++;
            if (__jsonProps.Contains("headers")) __score0++;
            if (__jsonProps.Contains("messages")) __score0++;
            if (__jsonProps.Contains("method")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("parameters")) __score0++;
            if (__jsonProps.Contains("rejectionPlan")) __score0++;
            if (__jsonProps.Contains("timeoutSeconds")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            if (__jsonProps.Contains("variableExtractionPlan")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("async")) __score1++;
            if (__jsonProps.Contains("code")) __score1++;
            if (__jsonProps.Contains("credentialId")) __score1++;
            if (__jsonProps.Contains("environmentVariables")) __score1++;
            if (__jsonProps.Contains("function")) __score1++;
            if (__jsonProps.Contains("messages")) __score1++;
            if (__jsonProps.Contains("rejectionPlan")) __score1++;
            if (__jsonProps.Contains("server")) __score1++;
            if (__jsonProps.Contains("timeoutSeconds")) __score1++;
            if (__jsonProps.Contains("variableExtractionPlan")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("messages")) __score2++;
            if (__jsonProps.Contains("rejectionPlan")) __score2++;
            if (__jsonProps.Contains("sipInfoDtmfEnabled")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("messages")) __score3++;
            if (__jsonProps.Contains("rejectionPlan")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("async")) __score4++;
            if (__jsonProps.Contains("function")) __score4++;
            if (__jsonProps.Contains("messages")) __score4++;
            if (__jsonProps.Contains("parameters")) __score4++;
            if (__jsonProps.Contains("rejectionPlan")) __score4++;
            if (__jsonProps.Contains("server")) __score4++;
            if (__jsonProps.Contains("variableExtractionPlan")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("destinations")) __score5++;
            if (__jsonProps.Contains("messages")) __score5++;
            if (__jsonProps.Contains("rejectionPlan")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("defaultResult")) __score6++;
            if (__jsonProps.Contains("destinations")) __score6++;
            if (__jsonProps.Contains("function")) __score6++;
            if (__jsonProps.Contains("messages")) __score6++;
            if (__jsonProps.Contains("rejectionPlan")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("messages")) __score7++;
            if (__jsonProps.Contains("name")) __score7++;
            if (__jsonProps.Contains("rejectionPlan")) __score7++;
            if (__jsonProps.Contains("server")) __score7++;
            if (__jsonProps.Contains("subType")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("displayHeightPx")) __score8++;
            if (__jsonProps.Contains("displayNumber")) __score8++;
            if (__jsonProps.Contains("displayWidthPx")) __score8++;
            if (__jsonProps.Contains("messages")) __score8++;
            if (__jsonProps.Contains("name")) __score8++;
            if (__jsonProps.Contains("rejectionPlan")) __score8++;
            if (__jsonProps.Contains("server")) __score8++;
            if (__jsonProps.Contains("subType")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("messages")) __score9++;
            if (__jsonProps.Contains("name")) __score9++;
            if (__jsonProps.Contains("rejectionPlan")) __score9++;
            if (__jsonProps.Contains("server")) __score9++;
            if (__jsonProps.Contains("subType")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("knowledgeBases")) __score10++;
            if (__jsonProps.Contains("messages")) __score10++;
            if (__jsonProps.Contains("rejectionPlan")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("messages")) __score11++;
            if (__jsonProps.Contains("rejectionPlan")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("messages")) __score12++;
            if (__jsonProps.Contains("rejectionPlan")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("messages")) __score13++;
            if (__jsonProps.Contains("rejectionPlan")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("messages")) __score14++;
            if (__jsonProps.Contains("rejectionPlan")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("messages")) __score15++;
            if (__jsonProps.Contains("rejectionPlan")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("messages")) __score16++;
            if (__jsonProps.Contains("metadata")) __score16++;
            if (__jsonProps.Contains("rejectionPlan")) __score16++;
            if (__jsonProps.Contains("server")) __score16++;
            if (__jsonProps.Contains("toolMessages")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("messages")) __score17++;
            if (__jsonProps.Contains("rejectionPlan")) __score17++;
            var __score18 = 0;
            if (__jsonProps.Contains("messages")) __score18++;
            if (__jsonProps.Contains("rejectionPlan")) __score18++;
            var __score19 = 0;
            if (__jsonProps.Contains("messages")) __score19++;
            if (__jsonProps.Contains("rejectionPlan")) __score19++;
            var __score20 = 0;
            if (__jsonProps.Contains("messages")) __score20++;
            if (__jsonProps.Contains("rejectionPlan")) __score20++;
            var __score21 = 0;
            if (__jsonProps.Contains("body")) __score21++;
            if (__jsonProps.Contains("headers")) __score21++;
            if (__jsonProps.Contains("messages")) __score21++;
            if (__jsonProps.Contains("rejectionPlan")) __score21++;
            if (__jsonProps.Contains("verb")) __score21++;
            var __score22 = 0;
            if (__jsonProps.Contains("beepDetectionEnabled")) __score22++;
            if (__jsonProps.Contains("messages")) __score22++;
            if (__jsonProps.Contains("rejectionPlan")) __score22++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }
            if (__score18 > __bestScore) { __bestScore = __score18; __bestIndex = 18; }
            if (__score19 > __bestScore) { __bestScore = __score19; __bestIndex = 19; }
            if (__score20 > __bestScore) { __bestScore = __score20; __bestIndex = 20; }
            if (__score21 > __bestScore) { __bestScore = __score21; __bestIndex = 21; }
            if (__score22 > __bestScore) { __bestScore = __score22; __bestIndex = 22; }

            global::Vapi.UpdateApiRequestToolDTO? apiRequest = default;
            global::Vapi.UpdateCodeToolDTO? codeDTO = default;
            global::Vapi.UpdateDtmfToolDTO? dtmf = default;
            global::Vapi.UpdateEndCallToolDTO? endCall = default;
            global::Vapi.UpdateFunctionToolDTO? function = default;
            global::Vapi.UpdateTransferCallToolDTO? transferCall = default;
            global::Vapi.UpdateHandoffToolDTO? handoff = default;
            global::Vapi.UpdateBashToolDTO? bash = default;
            global::Vapi.UpdateComputerToolDTO? computer = default;
            global::Vapi.UpdateTextEditorToolDTO? textEditor = default;
            global::Vapi.UpdateQueryToolDTO? query = default;
            global::Vapi.UpdateGoogleCalendarCreateEventToolDTO? googleCalendarEventCreate = default;
            global::Vapi.UpdateGoogleSheetsRowAppendToolDTO? googleSheetsRowAppend = default;
            global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO? googleCalendarAvailabilityCheck = default;
            global::Vapi.UpdateSlackSendMessageToolDTO? slackMessageSend = default;
            global::Vapi.UpdateSmsToolDTO? sms = default;
            global::Vapi.UpdateMcpToolDTO? mcp = default;
            global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO? gohighlevelCalendarAvailabilityCheck = default;
            global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO? gohighlevelCalendarEventCreate = default;
            global::Vapi.UpdateGoHighLevelContactCreateToolDTO? gohighlevelContactCreate = default;
            global::Vapi.UpdateGoHighLevelContactGetToolDTO? gohighlevelContactGet = default;
            global::Vapi.UpdateSipRequestToolDTO? sipRequest = default;
            global::Vapi.UpdateVoicemailToolDTO? voicemail = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateApiRequestToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateApiRequestToolDTO).Name}");
                        apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateCodeToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateCodeToolDTO).Name}");
                        codeDTO = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateDtmfToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateDtmfToolDTO).Name}");
                        dtmf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateEndCallToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateEndCallToolDTO).Name}");
                        endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateFunctionToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateFunctionToolDTO).Name}");
                        function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTransferCallToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTransferCallToolDTO).Name}");
                        transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateHandoffToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateHandoffToolDTO).Name}");
                        handoff = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBashToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateBashToolDTO).Name}");
                        bash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateComputerToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateComputerToolDTO).Name}");
                        computer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextEditorToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTextEditorToolDTO).Name}");
                        textEditor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateQueryToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateQueryToolDTO).Name}");
                        query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO).Name}");
                        googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO).Name}");
                        googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                        googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSlackSendMessageToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSlackSendMessageToolDTO).Name}");
                        slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSmsToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSmsToolDTO).Name}");
                        sms = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateMcpToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateMcpToolDTO).Name}");
                        mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                        gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 18)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO).Name}");
                        gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 19)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactCreateToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO).Name}");
                        gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 20)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactGetToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO).Name}");
                        gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 21)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSipRequestToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSipRequestToolDTO).Name}");
                        sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 22)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVoicemailToolDTO> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVoicemailToolDTO).Name}");
                        voicemail = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (apiRequest == null && codeDTO == null && dtmf == null && endCall == null && function == null && transferCall == null && handoff == null && bash == null && computer == null && textEditor == null && query == null && googleCalendarEventCreate == null && googleSheetsRowAppend == null && googleCalendarAvailabilityCheck == null && slackMessageSend == null && sms == null && mcp == null && gohighlevelCalendarAvailabilityCheck == null && gohighlevelCalendarEventCreate == null && gohighlevelContactCreate == null && gohighlevelContactGet == null && sipRequest == null && voicemail == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateApiRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateApiRequestToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateApiRequestToolDTO).Name}");
                    apiRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateCodeToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateCodeToolDTO).Name}");
                    codeDTO = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateDtmfToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateDtmfToolDTO).Name}");
                    dtmf = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateEndCallToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateEndCallToolDTO).Name}");
                    endCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateFunctionToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateFunctionToolDTO).Name}");
                    function = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTransferCallToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTransferCallToolDTO).Name}");
                    transferCall = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateHandoffToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateHandoffToolDTO).Name}");
                    handoff = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBashToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateBashToolDTO).Name}");
                    bash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateComputerToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateComputerToolDTO).Name}");
                    computer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextEditorToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTextEditorToolDTO).Name}");
                    textEditor = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateQueryToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateQueryToolDTO).Name}");
                    query = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO).Name}");
                    googleCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO).Name}");
                    googleSheetsRowAppend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                    googleCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSlackSendMessageToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSlackSendMessageToolDTO).Name}");
                    slackMessageSend = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSmsToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSmsToolDTO).Name}");
                    sms = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateMcpToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateMcpToolDTO).Name}");
                    mcp = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                    gohighlevelCalendarAvailabilityCheck = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO).Name}");
                    gohighlevelCalendarEventCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactCreateToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO).Name}");
                    gohighlevelContactCreate = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactGetToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO).Name}");
                    gohighlevelContactGet = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSipRequestToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSipRequestToolDTO).Name}");
                    sipRequest = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVoicemailToolDTO> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVoicemailToolDTO).Name}");
                    voicemail = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Vapi.ToolControllerUpdateRequest(
                apiRequest,

                codeDTO,

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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiRequest, typeInfo);
            }
            else if (value.IsCodeDTO)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateCodeToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateCodeToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateCodeToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeDTO, typeInfo);
            }
            else if (value.IsDtmf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateDtmfToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateDtmfToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateDtmfToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dtmf, typeInfo);
            }
            else if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateEndCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateEndCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateEndCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateFunctionToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateFunctionToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateFunctionToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
            else if (value.IsTransferCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTransferCallToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTransferCallToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTransferCallToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCall, typeInfo);
            }
            else if (value.IsHandoff)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateHandoffToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateHandoffToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateHandoffToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Handoff, typeInfo);
            }
            else if (value.IsBash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBashToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBashToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateBashToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bash, typeInfo);
            }
            else if (value.IsComputer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateComputerToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateComputerToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateComputerToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Computer, typeInfo);
            }
            else if (value.IsTextEditor)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextEditorToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextEditorToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTextEditorToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEditor, typeInfo);
            }
            else if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateQueryToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateQueryToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateQueryToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query, typeInfo);
            }
            else if (value.IsGoogleCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCreateEventToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarEventCreate, typeInfo);
            }
            else if (value.IsGoogleSheetsRowAppend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleSheetsRowAppendToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsRowAppend, typeInfo);
            }
            else if (value.IsGoogleCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsSlackMessageSend)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSlackSendMessageToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSlackSendMessageToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSlackSendMessageToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackMessageSend, typeInfo);
            }
            else if (value.IsSms)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSmsToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSmsToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSmsToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sms, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateMcpToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateMcpToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateMcpToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsGohighlevelCalendarAvailabilityCheck)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarAvailabilityCheck, typeInfo);
            }
            else if (value.IsGohighlevelCalendarEventCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelCalendarEventCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactCreateToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactCreate, typeInfo);
            }
            else if (value.IsGohighlevelContactGet)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateGoHighLevelContactGetToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GohighlevelContactGet, typeInfo);
            }
            else if (value.IsSipRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateSipRequestToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateSipRequestToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateSipRequestToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SipRequest, typeInfo);
            }
            else if (value.IsVoicemail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVoicemailToolDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVoicemailToolDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVoicemailToolDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voicemail, typeInfo);
            }
        }
    }
}