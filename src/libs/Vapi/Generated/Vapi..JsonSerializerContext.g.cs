
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberSpeechModelJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAITranscriberSpeechModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberSegmentationStrategyJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureSpeechTranscriberSegmentationStrategyNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguageBehaviourJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguageBehaviourNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguagesJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberLanguagesNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaTranscriberRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberOperatingPointJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberOperatingPointNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberNumeralStyleJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsTranscriberNumeralStyleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.TalkscriberTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAITranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberSpeechModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAssemblyAITranscriberSpeechModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberSegmentationStrategyJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberSegmentationStrategyNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCustomTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCustomTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageBehaviourJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageBehaviourNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguagesJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguagesNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGladiaTranscriberRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberOperatingPointJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberOperatingPointNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberNumeralStyleJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberNumeralStyleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTalkscriberTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackGoogleTranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAITranscriberLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LangfuseObservabilityPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.LangfuseObservabilityPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextContentTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextContentTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextContentLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.TextContentLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ConditionOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.ConditionOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageStartTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageStartTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageCompleteTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageCompleteTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageCompleteRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageCompleteRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageFailedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageFailedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageDelayedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageDelayedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MessageTargetRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.MessageTargetRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexConditionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexConditionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LiquidConditionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.LiquidConditionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GroupConditionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GroupConditionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GroupConditionOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.GroupConditionOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDtmfToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDtmfToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEndCallToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEndCallToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVoicemailToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVoicemailToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JsonSchemaTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.JsonSchemaTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JsonSchemaFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.JsonSchemaFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIFunctionParametersTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIFunctionParametersTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateFunctionToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateFunctionToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGhlToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGhlToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMakeToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMakeToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomMessageTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomMessageTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationAssistantTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationAssistantTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationAssistantTransferModeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationAssistantTransferModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexOptionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexOptionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantCustomEndpointingRuleTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantCustomEndpointingRuleTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomerCustomEndpointingRuleTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomerCustomEndpointingRuleTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BothCustomEndpointingRuleTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BothCustomEndpointingRuleTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSmartEndpointingPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSmartEndpointingPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LivekitSmartEndpointingPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.LivekitSmartEndpointingPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomEndpointingModelSmartEndpointingPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomEndpointingModelSmartEndpointingPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StartSpeakingPlanSmartEndpointingEnabledJsonConverter),

            typeof(global::Vapi.JsonConverters.StartSpeakingPlanSmartEndpointingEnabledNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantFirstMessageModeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferAssistantFirstMessageModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferCancelToolUserEditableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferCancelToolUserEditableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferSuccessfulToolUserEditableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferSuccessfulToolUserEditableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferPlanModeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferPlanModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationNumberTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationNumberTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationSipTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferDestinationSipTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTransferCallToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTransferCallToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanUserAndAssistantMessagesTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanUserAndAssistantMessagesTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationAssistantTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationAssistantTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationDynamicTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationDynamicTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationSquadTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffDestinationSquadTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateHandoffToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateHandoffToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomKnowledgeBaseDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomKnowledgeBaseDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseModelJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateQueryToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateQueryToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarCreateEventToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarCreateEventToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleSheetsRowAppendToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleSheetsRowAppendToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarCheckAvailabilityToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarCheckAvailabilityToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackSendMessageToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackSendMessageToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.McpToolMetadataProtocolJsonConverter),

            typeof(global::Vapi.JsonConverters.McpToolMetadataProtocolNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMcpToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMcpToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCalendarAvailabilityToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCalendarAvailabilityToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCalendarEventCreateToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCalendarEventCreateToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelContactCreateToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelContactCreateToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelContactGetToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelContactGetToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIMessageRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIMessageRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnyscaleModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnyscaleModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicThinkingConfigTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicThinkingConfigTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMModelMetadataSendModeJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMModelMetadataSendModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepInfraModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepInfraModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAIModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAIModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelFallbackModelJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelFallbackModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelToolStrictCompatibilityModeJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelToolStrictCompatibilityModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelPromptCacheRetentionJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIModelPromptCacheRetentionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenRouterModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenRouterModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PerplexityAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PerplexityAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TogetherAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TogetherAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HangupNodeTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HangupNodeTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowGoogleModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowGoogleModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowGoogleModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowGoogleModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCustomModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCustomModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ConversationNodeTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ConversationNodeTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolNodeTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolNodeTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanVoicemailDetectionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanVoicemailDetectionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoicemailDetectionPlanProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoicemailDetectionPlanProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoicemailDetectionPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoicemailDetectionPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionCallHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionCallHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SayHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SayHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MessageAddHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.MessageAddHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookCallEndingOnJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookCallEndingOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookAssistantSpeechInterruptedOnJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookAssistantSpeechInterruptedOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookCustomerSpeechInterruptedOnJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookCustomerSpeechInterruptedOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolCallHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolCallHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookModelResponseTimeoutOnJsonConverter),

            typeof(global::Vapi.JsonConverters.CallHookModelResponseTimeoutOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AIEdgeConditionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AIEdgeConditionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RecordingConsentPlanVerbalTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RecordingConsentPlanVerbalTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SecurityFilterPlanModeJsonConverter),

            typeof(global::Vapi.JsonConverters.SecurityFilterPlanModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CompliancePlanRecordingConsentPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CompliancePlanRecordingConsentPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SuccessEvaluationPlanRubricJsonConverter),

            typeof(global::Vapi.JsonConverters.SuccessEvaluationPlanRubricNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ArtifactPlanRecordingFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.ArtifactPlanRecordingFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.KeypadInputPlanDelimitersJsonConverter),

            typeof(global::Vapi.JsonConverters.KeypadInputPlanDelimitersNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowUserEditableVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.XaiModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.XaiModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.XaiModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.XaiModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExactReplacementTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ExactReplacementTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexReplacementTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexReplacementTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FormatPlanFormattersEnabledItemJsonConverter),

            typeof(global::Vapi.JsonConverters.FormatPlanFormattersEnabledItemNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChunkPlanPunctuationBoundarieJsonConverter),

            typeof(global::Vapi.JsonConverters.ChunkPlanPunctuationBoundarieNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaExperimentalControlsSpeedJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaExperimentalControlsSpeedNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaExperimentalControlsEmotionJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaExperimentalControlsEmotionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.LMNTVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceEmotionJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceEmotionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAIVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SesameVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SesameVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SesameVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.SesameVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceLanguageCodeJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldVoiceLanguageCodeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceLanguageBoostJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceLanguageBoostNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackWellSaidVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackWellSaidVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackWellSaidVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackWellSaidVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackAzureVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCartesiaVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCustomVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackCustomVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackElevenLabsVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackHumeVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackHumeVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackHumeVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackHumeVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackLMNTVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackNeuphonicVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackNeuphonicVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackNeuphonicVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackNeuphonicVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackOpenAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceEmotionJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceEmotionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackPlayHTVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceLanguageJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackRimeAIVoiceLanguageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSesameVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSesameVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSesameVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSesameVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackSmallestAIVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTavusVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTavusVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTavusVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackTavusVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackVapiVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackVapiVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackVapiVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackVapiVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceVoiceIdJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceVoiceIdNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceLanguageCodeJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackInworldVoiceLanguageCodeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportConfigurationTwilioProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportConfigurationTwilioProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportConfigurationTwilioRecordingChannelsJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportConfigurationTwilioRecordingChannelsNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnyscaleCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAnyscaleCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssemblyAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssemblyAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTOServiceJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTOServiceNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureCredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOModelJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SipTrunkGatewayOutboundProtocolJsonConverter),

            typeof(global::Vapi.JsonConverters.SipTrunkGatewayOutboundProtocolNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateByoSipTrunkCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateByoSipTrunkCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCartesiaCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCartesiaCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCloudflareCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCloudflareCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OAuth2AuthenticationPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.OAuth2AuthenticationPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomLLMCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomLLMCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepgramCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepgramCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepInfraCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepInfraCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepSeekCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateDeepSeekCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGcpCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGcpCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGladiaCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGladiaCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGroqCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGroqCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLangfuseCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLangfuseCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLmntCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLmntCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMakeCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMakeCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOpenAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOpenAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOpenRouterCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOpenRouterCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePerplexityAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePerplexityAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePlayHTCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePlayHTCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateRimeAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateRimeAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateRunpodCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateRunpodCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateS3CredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateS3CredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SupabaseBucketPlanRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.SupabaseBucketPlanRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSupabaseCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSupabaseCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSmallestAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSmallestAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTavusCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTavusCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTogetherAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTogetherAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTwilioCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTwilioCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVonageCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVonageCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWebhookCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWebhookCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateXAiCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateXAiCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2ClientCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2ClientCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackOAuth2AuthorizationCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMinimaxCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMinimaxCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionCreatedHookOnJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionCreatedHookOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SQLInjectionSecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SQLInjectionSecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.XSSSecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.XSSSecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SSRFSecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SSRFSecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RCESecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RCESecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PromptInjectionSecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PromptInjectionSecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexSecurityFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RegexSecurityFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesFirstMessageModeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesFirstMessageModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesClientMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesClientMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesServerMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesServerMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantOverridesCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOFirstMessageModeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOFirstMessageModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOClientMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOClientMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOServerMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOServerMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateAssistantDTOCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantFirstMessageModeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantFirstMessageModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantClientMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantClientMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantServerMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantServerMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOFirstMessageModeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOFirstMessageModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOClientMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOClientMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOServerMessageJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOServerMessageNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAssistantDTOCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.WorkflowVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWorkflowDTOVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOBackgroundSoundJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOBackgroundSoundNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOCredentialDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOCredentialDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOVoicemailDetectionJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWorkflowDTOVoicemailDetectionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferPhoneNumberHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferPhoneNumberHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SayPhoneNumberHookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SayPhoneNumberHookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterKeyJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterKeyNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberHookCallRingingOnJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberHookCallRingingOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterKeyJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterKeyNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterOneOfItemJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterOneOfItemNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberHookCallEndingOnJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberHookCallEndingOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallPhoneCallProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CallPhoneCallProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallPhoneCallTransportJsonConverter),

            typeof(global::Vapi.JsonConverters.CallPhoneCallTransportNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.CallStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CallEndedReasonJsonConverter),

            typeof(global::Vapi.JsonConverters.CallEndedReasonNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeveloperMessageRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.DeveloperMessageRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolMessageRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioSMSChatTransportConversationTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioSMSChatTransportConversationTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioSMSChatTransportTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioSMSChatTransportTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GetChatPaginatedDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.GetChatPaginatedDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOColumnsJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOColumnsNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputTextTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputTextTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseOutputMessageTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseObjectObjectJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseObjectObjectNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseObjectStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseObjectStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseTextDeltaEventTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseTextDeltaEventTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseTextDoneEventTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseTextDoneEventTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseCompletedEventTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseCompletedEventTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseErrorEventTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ResponseErrorEventTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignEndedReasonJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignEndedReasonNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCampaignDTOStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCampaignDTOStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetAssistantTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetAssistantTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetSquadTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetSquadTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetOptionsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayTargetOptionsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandSayTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandSayTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandNoteTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandNoteTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandOptionsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayCommandOptionsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayResponseStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.RelayResponseStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSessionDTOStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSessionDTOStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateSessionDTOStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateSessionDTOStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GetSessionPaginatedDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.GetSessionPaginatedDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOColumnsJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOColumnsNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoPhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoPhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoPhoneNumberStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoPhoneNumberStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioPhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioPhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioPhoneNumberStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioPhoneNumberStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VonagePhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VonagePhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VonagePhoneNumberStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.VonagePhoneNumberStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiPhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiPhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiPhoneNumberStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiPhoneNumberStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TelnyxPhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TelnyxPhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TelnyxPhoneNumberStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.TelnyxPhoneNumberStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateByoPhoneNumberDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateByoPhoneNumberDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTwilioPhoneNumberDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTwilioPhoneNumberDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVonagePhoneNumberDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVonagePhoneNumberDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVapiPhoneNumberDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateVapiPhoneNumberDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTelnyxPhoneNumberDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTelnyxPhoneNumberDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ApiRequestToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ApiRequestToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ApiRequestToolMethodJsonConverter),

            typeof(global::Vapi.JsonConverters.ApiRequestToolMethodNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CodeToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CodeToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DtmfToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.DtmfToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EndCallToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EndCallToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferCallToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransferCallToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HandoffToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OutputToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.OutputToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolNameJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolNameJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.QueryToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.QueryToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCheckAvailabilityToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCheckAvailabilityToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackSendMessageToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackSendMessageToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SmsToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SmsToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.McpToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.McpToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SipRequestToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SipRequestToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SipRequestToolVerbJsonConverter),

            typeof(global::Vapi.JsonConverters.SipRequestToolVerbNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailToolTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailToolTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateApiRequestToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateApiRequestToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateApiRequestToolDTOMethodJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateApiRequestToolDTOMethodNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCodeToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCodeToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOutputToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOutputToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBashToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateComputerToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextEditorToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSmsToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSmsToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSipRequestToolDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSipRequestToolDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSipRequestToolDTOVerbJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSipRequestToolDTOVerbNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateApiRequestToolDTOMethodJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateApiRequestToolDTOMethodNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBashToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBashToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBashToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBashToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateComputerToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateComputerToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateComputerToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateComputerToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextEditorToolDTOSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextEditorToolDTOSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextEditorToolDTONameJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextEditorToolDTONameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateSipRequestToolDTOVerbJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateSipRequestToolDTOVerbNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FileObjectJsonConverter),

            typeof(global::Vapi.JsonConverters.FileObjectNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FileStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.FileStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseSearchPlanSearchTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseSearchPlanSearchTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomKnowledgeBaseProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomKnowledgeBaseProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTrieveKnowledgeBaseDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTrieveKnowledgeBaseDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseCreateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseCreateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseImportTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveKnowledgeBaseImportTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateStructuredOutputDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateStructuredOutputDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuitePhoneNumberProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuitePhoneNumberProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestVoiceTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestVoiceTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestChatTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestChatTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTestSuiteTestVoiceDtoTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTestSuiteTestVoiceDtoTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTestSuiteTestChatDtoTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTestSuiteTestChatDtoTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTestSuiteTestVoiceDtoTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTestSuiteTestVoiceDtoTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTestSuiteTestChatDtoTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTestSuiteTestChatDtoTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestScorerAITypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteTestScorerAITypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAITypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAITypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAIResultJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunScorerAIResultNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.TestSuiteRunStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookWebhookActionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookWebhookActionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookCallStartedOnJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookCallStartedOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookCallEndedOnJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationHookCallEndedOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvaluationPlanItemComparatorJsonConverter),

            typeof(global::Vapi.JsonConverters.EvaluationPlanItemComparatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunSimulationEntryTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunSimulationEntryTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunSuiteEntryTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunSuiteEntryTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTargetAssistantTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTargetAssistantTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTargetSquadTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTargetSquadTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTransportConfigurationProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunTransportConfigurationProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputEvaluationResultComparatorJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputEvaluationResultComparatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunItemStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.SimulationRunItemStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GeneratedScenarioCategoryJsonConverter),

            typeof(global::Vapi.JsonConverters.GeneratedScenarioCategoryNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightTimeRangeWithStepStepJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightTimeRangeWithStepStepNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextInsightTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextInsightTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBarInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBarInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBarInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateBarInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdatePieInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdatePieInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdatePieInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdatePieInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateLineInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateLineInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateLineInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateLineInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTextInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBarInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBarInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBarInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateBarInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePieInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePieInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePieInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.CreatePieInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLineInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLineInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLineInsightFromCallTableDTOGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateLineInsightFromCallTableDTOGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextInsightFromCallTableDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTextInsightFromCallTableDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnTableNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStringTypeColumnOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTableNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnTableNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTableNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOnJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringTypeColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringTypeColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringTypeColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringTypeColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberTypeColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberTypeColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberTypeColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberTypeColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterDateTypeColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterDateTypeColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterDateTypeColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterDateTypeColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStructuredOutputColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStructuredOutputColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStructuredOutputColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStructuredOutputColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringArrayTypeColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringArrayTypeColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringArrayTypeColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterStringArrayTypeColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberArrayTypeColumnOnCallTableColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberArrayTypeColumnOnCallTableColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberArrayTypeColumnOnCallTableOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.FilterNumberArrayTypeColumnOnCallTableOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableStringConditionOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableStringConditionOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableNumberConditionOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableNumberConditionOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableBooleanConditionOperatorJsonConverter),

            typeof(global::Vapi.JsonConverters.EventsTableBooleanConditionOperatorNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightFromCallTableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightFromCallTableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightFromCallTableGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.BarInsightFromCallTableGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightFromCallTableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightFromCallTableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightFromCallTableGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.PieInsightFromCallTableGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightFromCallTableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightFromCallTableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightFromCallTableGroupByJsonConverter),

            typeof(global::Vapi.JsonConverters.LineInsightFromCallTableGroupByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextInsightFromCallTableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextInsightFromCallTableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightRunFormatPlanFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightRunFormatPlanFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEvalDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEvalDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalModelListOptionsProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalModelListOptionsProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalUserEditableTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalUserEditableTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageMockRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageMockRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalSystemMessageMockRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalSystemMessageMockRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageMockRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageMockRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalUserMessageMockRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalUserMessageMockRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageEvaluationRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalAssistantMessageEvaluationRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalOpenAIModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalOpenAIModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalOpenAIModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalOpenAIModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalAnthropicModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalAnthropicModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalAnthropicModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalAnthropicModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGoogleModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGoogleModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGoogleModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGoogleModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGroqModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGroqModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGroqModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalGroqModelModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalCustomModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalCustomModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanAITypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanAITypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageEvaluationRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatEvalToolResponseMessageEvaluationRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanExactTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanExactTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanRegexTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantMessageJudgePlanRegexTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalPaginatedDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalPaginatedDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateEvalDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateEvalDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEvalRunDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEvalRunDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunResultStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunResultStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunEndedReasonJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunEndedReasonNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalRunPaginatedDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalRunPaginatedDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTargetAssistantTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTargetAssistantTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTargetSquadTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalRunTargetSquadTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOrgDTOChannelJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateOrgDTOChannelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionMinutesIncludedResetFrequencyJsonConverter),

            typeof(global::Vapi.JsonConverters.SubscriptionMinutesIncludedResetFrequencyNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OrgChannelJsonConverter),

            typeof(global::Vapi.JsonConverters.OrgChannelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateOrgDTOChannelJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateOrgDTOChannelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InviteUserDTORoleJsonConverter),

            typeof(global::Vapi.JsonConverters.InviteUserDTORoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateUserRoleDTORoleJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateUserRoleDTORoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTokenDTOTagJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTokenDTOTagNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TokenTagJsonConverter),

            typeof(global::Vapi.JsonConverters.TokenTagNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTokenDTOTagJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateTokenDTOTagNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockCredentialRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.AnthropicBedrockCredentialRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnyscaleCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AnyscaleCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AssemblyAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialServiceJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialServiceNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureCredentialRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialModelJsonConverter),

            typeof(global::Vapi.JsonConverters.AzureOpenAICredentialModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoSipTrunkCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ByoSipTrunkCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CartesiaCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CerebrasCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CloudflareCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CloudflareCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomLLMCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepInfraCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepInfraCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepSeekCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GcpCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GcpCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GladiaCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GroqCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.HumeCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.InflectionAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LangfuseCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.LangfuseCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.LmntCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.LmntCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MistralCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.MistralCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.NeuphonicCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenRouterCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.OpenRouterCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PerplexityAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PerplexityAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PlayHTCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.RimeAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RunpodCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.RunpodCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WellSaidCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.S3CredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.S3CredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SmallestAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SonioxCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SpeechmaticsCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SupabaseCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SupabaseCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TavusCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TogetherAICredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TogetherAICredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TrieveCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VonageCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VonageCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WebhookCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.WebhookCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.WebhookCredentialAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.WebhookCredentialAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SpkiPemPublicKeyConfigFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.SpkiPemPublicKeyConfigFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanAlgorithmJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanAlgorithmNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialEncryptionPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomCredentialEncryptionPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.XAiCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.XAiCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarOAuth2ClientCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarOAuth2ClientCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarOAuth2AuthorizationCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarOAuth2AuthorizationCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsOAuth2AuthorizationCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsOAuth2AuthorizationCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackOAuth2AuthorizationCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackOAuth2AuthorizationCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelMCPCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelMCPCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.InworldCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EmailCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.EmailCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackWebhookCredentialProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SlackWebhookCredentialProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCerebrasCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCerebrasCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoogleCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateHumeCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateHumeCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateInflectionAICredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateInflectionAICredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMistralCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateMistralCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateNeuphonicCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateNeuphonicCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWellSaidCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateWellSaidCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSonioxCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSonioxCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSpeechmaticsCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSpeechmaticsCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTrieveCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateTrieveCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOEncryptionPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOEncryptionPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelMCPCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateGoHighLevelMCPCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateInworldCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateInworldCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEmailCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateEmailCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackWebhookCredentialDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateSlackWebhookCredentialDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAnthropicBedrockCredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAnthropicBedrockCredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureCredentialDTOServiceJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureCredentialDTOServiceNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureCredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureCredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTORegionJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTORegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTOModelJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTOModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOAuthModeJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialWebhookDTOAuthModeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanAlgorithmJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanAlgorithmNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanSignatureEncodingJsonConverter),

            typeof(global::Vapi.JsonConverters.HMACAuthenticationPlanSignatureEncodingNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BearerAuthenticationPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BearerAuthenticationPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AWSStsAuthenticationPlanTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AWSStsAuthenticationPlanTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolProviderDetailsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolProviderDetailsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOVisibilityJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOVisibilityNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CreateToolTemplateDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateVisibilityJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateVisibilityNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TemplateProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOVisibilityJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOVisibilityNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.UpdateToolTemplateDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VoiceLibraryGenderJsonConverter),

            typeof(global::Vapi.JsonConverters.VoiceLibraryGenderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SyncVoiceLibraryDTOProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.SyncVoiceLibraryDTOProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsPronunciationDictionaryPermissionOnResourceJsonConverter),

            typeof(global::Vapi.JsonConverters.ElevenLabsPronunciationDictionaryPermissionOnResourceNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TimeRangeStepJsonConverter),

            typeof(global::Vapi.JsonConverters.TimeRangeStepNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsOperationOperationJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsOperationOperationNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsOperationColumnJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsOperationColumnNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsQueryTableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsQueryTableNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsQueryGroupByItemJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalyticsQueryGroupByItemNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageWorkflowNodeStartedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageWorkflowNodeStartedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantStartedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantStartedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageConversationUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageConversationUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageHangTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageHangTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageMetadataTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageMetadataTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageModelOutputTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageModelOutputTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTranscriptTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTranscriptTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageToolCallsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageToolCallsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageToolCallsResultTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageToolCallsResultTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTransferUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageTransferUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageUserInterruptedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageUserInterruptedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageLanguageChangeDetectedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageLanguageChangeDetectedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageVoiceInputTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageVoiceInputTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageChatCreatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageChatCreatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageChatDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageChatDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionCreatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionCreatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionUpdatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionUpdatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageSessionDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageCallDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageCallDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageCallDeleteFailedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageCallDeleteFailedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageConversationUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageConversationUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportEndedReasonJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportEndedReasonNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageHandoffDestinationRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageHandoffDestinationRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageHangTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageHangTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageKnowledgeBaseRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageKnowledgeBaseRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageModelOutputTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageModelOutputTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessagePhoneCallControlTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessagePhoneCallControlTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessagePhoneCallControlRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessagePhoneCallControlRequestNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSpeechUpdateRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateEndedReasonJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateEndedReasonNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageToolCallsTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageToolCallsTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTransferDestinationRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTransferDestinationRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTransferUpdateTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTransferUpdateTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptRoleJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptRoleNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptTranscriptTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageTranscriptTranscriptTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageUserInterruptedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageUserInterruptedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageLanguageChangeDetectedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageLanguageChangeDetectedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageVoiceInputTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageVoiceInputTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageVoiceRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageVoiceRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallEndpointingRequestTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallEndpointingRequestTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageChatCreatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageChatCreatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageChatDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageChatDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionCreatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionCreatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionUpdatedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionUpdatedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageSessionDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallDeletedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallDeletedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallDeleteFailedTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageCallDeleteFailedTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageAddMessageTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageAddMessageTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageControlTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageControlTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageControlControlJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageControlControlNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageSayTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageSayTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageEndCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageEndCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageTransferTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageTransferTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageSendTransportMessageTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientInboundMessageSendTransportMessageTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportCostProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.TransportCostProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TranscriberCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TranscriberCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ModelCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ModelCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VoiceCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VoiceCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiCostSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiCostSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalysisCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalysisCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalysisCostAnalysisTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AnalysisCostAnalysisTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailDetectionCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailDetectionCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailDetectionCostProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.VoicemailDetectionCostProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.KnowledgeBaseCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionCostTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionCostTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.FunctionToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GhlToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.MakeToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallNameJsonConverter),

            typeof(global::Vapi.JsonConverters.BashToolWithToolCallNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ComputerToolWithToolCallNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallSubTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallSubTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallNameJsonConverter),

            typeof(global::Vapi.JsonConverters.TextEditorToolWithToolCallNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleCalendarCreateEventToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoogleSheetsRowAppendToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarAvailabilityToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelCalendarEventCreateToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactCreateToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolWithToolCallTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.GoHighLevelContactGetToolWithToolCallTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSipTransportMessageTransportJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSipTransportMessageTransportNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSipTransportMessageSipVerbJsonConverter),

            typeof(global::Vapi.JsonConverters.VapiSipTransportMessageSipVerbNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioTransportMessageTransportJsonConverter),

            typeof(global::Vapi.JsonConverters.TwilioTransportMessageTransportNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerPreviewRequestDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerPreviewRequestDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatControllerListChatsSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatControllerListChatsSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceResourceNameJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceResourceNameNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseDiscriminatorProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseDiscriminatorProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindAllResponseItemDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindAllResponseItemDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindOneResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindOneResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerRemoveResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerRemoveResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindOneResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindOneResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerRemoveResponseDiscriminatorTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerRemoveResponseDiscriminatorTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.RecordingConsentPlanJsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItemJsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan2JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem2JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem3JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem4JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem5JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem6JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem7JsonConverter),

            typeof(global::Vapi.JsonConverters.CredentialsItem8JsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan4JsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan5JsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan6JsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan8JsonConverter),

            typeof(global::Vapi.JsonConverters.AuthenticationPlan9JsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerPreviewRequestJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerCreateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllResponseItemJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindOneResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerUpdateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerRemoveResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerCreateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindAllResponseItemJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerFindOneResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerUpdateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.ToolControllerRemoveResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerCreateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerUpdateResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindOneResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerRemoveResponseJsonConverter),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.DeepgramTranscriberModel?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.GladiaVocabularyItemDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackDeepgramTranscriberModel?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferAssistantBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowUserEditableBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ElevenLabsVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.LMNTVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.OpenAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PlayHTVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RimeAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SmallestAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TavusVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAzureVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackLMNTVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackTavusVoiceVoiceId?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateAssistantDTOBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UpdateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UpdateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ModelCost, global::Vapi.ChatCost>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ClientInboundMessageAddMessage, global::Vapi.ClientInboundMessageControl, global::Vapi.ClientInboundMessageSay, global::Vapi.ClientInboundMessageEndCall, global::Vapi.ClientInboundMessageTransfer, global::Vapi.ClientInboundMessageSendTransportMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.Call, global::Vapi.CallBatchResponse>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>),

            typeof(global::Vapi.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTranscriberPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberSpeechModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Server))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.DeepgramTranscriberModel?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCustomVocabularyConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaVocabularyItemDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguageBehaviour))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCustomVocabularyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SpeechmaticsCustomVocabularyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackDeepgramTranscriberModel?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseObservabilityPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseObservabilityPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageStartType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageDelayed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageDelayedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageTargetRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LiquidCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LiquidConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolRejectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDtmfToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDtmfToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEndCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEndCallToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVoicemailToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVoicemailToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vapi.JsonSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableExtractionAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableExtractionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VariableExtractionAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, double?, bool?, object, byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunctionParametersType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFunctionToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFunctionToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGhlToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGhlToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantTransferMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferFallbackPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexOptionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCustomEndpointingRuleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.RegexOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerCustomEndpointingRuleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BothCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BothCustomEndpointingRuleType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSmartEndpointingPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LivekitSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LivekitSmartEndpointingPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptionEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmartDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FourierDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackgroundSpeechDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferAssistantBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantFirstMessageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCancelToolUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCancelToolUserEditableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferSuccessfulToolUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferSuccessfulToolUserEditableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SummaryPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlanMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumberType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSipType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTransferCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTransferCallToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNoneType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAllType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamicType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SquadMemberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSquadDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadataProtocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelMetadataSendMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveSpeechConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleRealtimeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelFallbackModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelPromptCacheRetention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HangupNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HangupNodeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GlobalNodePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNodeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNodeType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionBackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCallHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCallHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageAddHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageAddHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEndingOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerSpeechTimeoutOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeoutOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeConditionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Edge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbalType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterPlanMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredDataPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredDataMultiPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SuccessEvaluationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SuccessEvaluationPlanRubric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComplianceOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ArtifactPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ArtifactPlanRecordingFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateStructuredOutputDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateScorecardDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StopSpeakingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MonitorPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KeypadInputPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KeypadInputPlanDelimiters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnyscaleCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssemblyAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoSipTrunkCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCartesiaCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCerebrasCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCloudflareCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomLLMCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepgramCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepInfraCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepSeekCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGcpCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGladiaCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGroqCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHumeCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInflectionAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLangfuseCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLmntCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMistralCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateNeuphonicCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenRouterCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePerplexityAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePlayHTCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRimeAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRunpodCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmallestAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSpeechmaticsCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSonioxCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSupabaseCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTavusCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTogetherAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrieveCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonageCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateXAiCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInworldCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMinimaxCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWellSaidCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEmailCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackWebhookCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExactReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExactReplacementType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexReplacementType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FormatPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FormatPlanFormattersEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FormatPlanFormattersEnabledItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChunkPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ChunkPlanPunctuationBoundarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChunkPlanPunctuationBoundarie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTavusVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsSpeed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsEmotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaGenerationConfigExperimental))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ElevenLabsPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.OpenAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceEmotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusConversationProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TavusVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceLanguageCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceLanguageBoost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceLanguageBoost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceEmotion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTavusVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackTavusVoiceVoiceId?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTavusVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceVoiceId))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceLanguageCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureBlobStorageBucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkGateway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkGatewayOutboundProtocol))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkOutboundSipRegisterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkOutboundAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SipTrunkGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCartesiaCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareR2BucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCloudflareCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OAuth2AuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OAuth2AuthenticationPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepgramCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGcpCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGladiaCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGroqCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLangfuseCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLmntCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePlayHTCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRimeAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRunpodCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseBucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseBucketPlanRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSupabaseCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmallestAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTavusCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTogetherAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonageCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateXAiCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMinimaxCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndpointedSpeechLowConfidenceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookTranscriberEndpointedSpeechLowConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHookOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SQLInjectionSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SQLInjectionSecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XSSSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XSSSecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SSRFSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SSRFSecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RCESecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RCESecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PromptInjectionSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PromptInjectionSecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexSecurityFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesFirstMessageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOFirstMessageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateAssistantDTOBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Assistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantFirstMessageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantVersionPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOFirstMessageMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Squad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSquadDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Workflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOBackgroundSound))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOVoicemailDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionLimits))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCostBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CostBreakdown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Analysis))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MonitorResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Monitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.MonitorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Mono))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Recording))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NodeArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BotMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallResultMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantActivation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TurnLatency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerformanceMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TurnLatency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.NodeArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantActivation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Compliance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRinging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRingingOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEndingOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ImportTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomerDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SchedulePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Call))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriberCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ModelCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPhoneCallProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPhoneCallTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallEndedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallBatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Call>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CallBatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputFilterDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutboundCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeleteCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Chat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransportConversationType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransportType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateChatDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetChatPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetChatPaginatedDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Chat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateChatStreamResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatAssistantOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebCustomerDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebChatDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIWebChatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOColumns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputTextType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObjectObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObjectStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ResponseOutputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDeltaEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDoneEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseCompletedEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseErrorEventType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DialPlanEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCampaignDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Campaign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignEndedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Campaign>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCampaignDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCampaignDTOStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetSquadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetOptionsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandSay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandSayType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandNote))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandNoteType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandOptionsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSessionDTOStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSessionDTOStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetSessionPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetSessionPaginatedDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOColumns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ImportVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestToolMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeToolEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DtmfTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DtmfToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndCallToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCallToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OutputTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OutputToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.QueryTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.QueryToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCheckAvailabilityToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackSendMessageTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackSendMessageToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmsToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestToolVerb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.JsonSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailToolType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutputToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutputToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOVerb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateApiRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateApiRequestToolDTOMethod))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCodeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateDtmfToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEndCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateFunctionToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGhlToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateMakeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateHandoffToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTransferCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOutputToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBashToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBashToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBashToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTOSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTOName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateQueryToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleCalendarCreateEventToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleSheetsRowAppendToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleCalendarCheckAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSlackSendMessageToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSmsToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateMcpToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelCalendarAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelCalendarEventCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelContactCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelContactGetToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSipRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSipRequestToolDTOVerb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVoicemailToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFileDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FileObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FileStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateFileDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseSearchPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseSearchPlanSearchType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseImport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomKnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomKnowledgeBaseProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrieveKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrieveKnowledgeBaseDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTrieveKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseChunkPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseCreateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TrieveKnowledgeBaseChunkPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveKnowledgeBaseImportType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TesterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitePhoneNumberProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TargetPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitesPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteTestScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestScorerAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestVoiceType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestChatType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestVoiceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestVoiceDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestChatDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestChatDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestVoiceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestVoiceDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestChatDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestChatDtoType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestScorerAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAIResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttemptCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttemptMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteRunDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteRunDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePersonalityDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Personality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePersonalityDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookInclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookActionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStartedOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEnded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEndedOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvaluationPlanItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvaluationPlanItemComparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScenarioToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateScenarioDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Scenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateScenarioDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSimulationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSimulationEntryType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSuiteEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSuiteEntryType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetSquadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfigurationProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResultComparator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LatencyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovementSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationSuiteDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationSuiteDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenarioCategory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Simulation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRangeWithStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRangeWithStepStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.InsightFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightFormula))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTOGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextInsightFromCallTableDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableOn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableStringCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableNumberCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableBooleanCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTableColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTableOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableStringConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableNumberConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableBooleanConditionOperator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTableGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTableGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTableGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightFromCallTableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunFormatPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunFormatPlanFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Insight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Insight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalSystemMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalUserMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalModelListOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalModelListOptionsProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalUserEditableType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMockToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMockRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalSystemMessageMockRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageMockRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalUserMessageMockRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageEvaluationContinuePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageEvaluationRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanExact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanRegex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModelModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalCustomModelProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanAIType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageEvaluationRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanExactType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanRegexType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalPaginatedDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEvalDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEvalDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalRunDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunResultStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunEndedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvalRunResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvalRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalRunPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalRunPaginatedDTOSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetAssistantType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetSquadType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Scorecard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Scorecard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOrgDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOrgDTOChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AutoReloadPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InvoicePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionMinutesIncludedResetFrequency))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Org))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OrgChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOrgDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOrgDTOChannel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InviteUserDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InviteUserDTORole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateUserRoleDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateUserRoleDTORole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JwtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TokenRestrictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTokenDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTokenDTOTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TokenTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTokenDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTokenDTOTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAssumeRoleUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredentialRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialRegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AzureOpenAICredentialModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoSipTrunkCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoSipTrunkCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Oauth2AuthenticationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LmntCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LmntCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MistralCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MistralCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RunpodCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RunpodCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.S3Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.S3CredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAICredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrieveCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonageCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonageCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfigFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialEncryptionPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XAiCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XAiCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2ClientCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsOAuth2AuthorizationCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackOAuth2AuthorizationCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelMCPCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelMCPCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EmailCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EmailCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackWebhookCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackWebhookCredentialProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCerebrasCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHumeCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInflectionAICredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMistralCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWellSaidCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSonioxCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrieveCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInworldCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEmailCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicBedrockCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicBedrockCredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnyscaleCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssemblyAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTOService))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTORegion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTOModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoSipTrunkCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCartesiaCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCerebrasCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCloudflareCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomLLMCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateDeepgramCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateDeepInfraCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateDeepSeekCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateElevenLabsCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGcpCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGladiaCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGroqCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateHumeCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateInflectionAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLangfuseCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLmntCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateMakeCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateMistralCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateNeuphonicCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOpenAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOpenRouterCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePerplexityAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePlayHTCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateRimeAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateRunpodCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWellSaidCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateS3CredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTogetherAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTrieveCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonageCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateXAiCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleCalendarOAuth2ClientCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleCalendarOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoogleSheetsOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSlackOAuth2AuthorizationCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateGoHighLevelMCPCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateInworldCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEmailCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSlackWebhookCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSonioxCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialEndUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialSessionError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOAuthMode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialActionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanAlgorithm))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlanType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolTemplateSetup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolTemplateSetup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolProviderDetailsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolTemplateMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOVisibility))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibraryGender))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SyncVoiceLibraryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SyncVoiceLibraryDTOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SyncVoiceLibraryDTOProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSesameVoiceDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaPronunciationDictItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaPronunciationDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CartesiaPronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionaryPermissionOnResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourcePaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ProviderResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibraryVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AddVoiceToProviderDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloneVoiceDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableValueGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TimeRangeStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperationOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperationColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryGroupByItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VariableValueGroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageWorkflowNodeStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageWorkflowNodeStartedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantStartedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageConversationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageConversationUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageHang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageHangType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageMetadataType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageModelOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptTranscriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsResultType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTransferUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTransferUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageUserInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageUserInterruptedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageLanguageChangeDetected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageLanguageChangeDetectedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageVoiceInputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleteFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleteFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageConversationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageConversationUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReportType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReportEndedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHandoffDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHandoffDestinationRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHangType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageKnowledgeBaseRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageModelOutputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateEndedReason))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageToolCallsType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferDestinationRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferUpdateType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptRole))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptTranscriptType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageUserInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageUserInterruptedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageLanguageChangeDetected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageLanguageChangeDetectedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceInputType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallEndpointingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallEndpointingRequestType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionCreatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionUpdatedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeletedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleteFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleteFailedType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseHandoffDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseResponseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseTransferDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseCallEndpointingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageAddMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageAddMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControlType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControlControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSayType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageEndCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageEndCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageTransferType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSendTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSendTransportMessageType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ClientInboundMessageAddMessage, global::Vapi.ClientInboundMessageControl, global::Vapi.ClientInboundMessageSay, global::Vapi.ClientInboundMessageEndCall, global::Vapi.ClientInboundMessageTransfer, global::Vapi.ClientInboundMessageSendTransportMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCostProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriberCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ModelCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCostSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCostAnalysisType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCostProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCostType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallSubType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolWithToolCallType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessageTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessageSipVerb))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioTransportMessageTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequestDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatControllerListChatsSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignControllerFindAllStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignControllerFindAllSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionControllerFindAllPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindAllSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetRunsPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Squad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.Call, global::Vapi.CallBatchResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItemDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponseDiscriminatorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SpeechmaticsCustomVocabularyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VariableExtractionAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.RegexOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SquadMemberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.McpToolMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.UpdateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.MonitorResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TurnLatency>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.NodeArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantActivation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallRingingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberCallEndingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Call>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CallBatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateCustomerDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Chat>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ResponseOutputText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ResponseOutputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.DialPlanEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Campaign>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CodeToolEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TrieveKnowledgeBaseChunkPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuiteTestScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuiteRunScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuiteRunTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationHookWebhookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.EvaluationPlanItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ScenarioToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredOutputEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationRunItemImprovementSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.GeneratedScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.InsightFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Insight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ChatEvalAssistantMessageMockToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.EvalRunResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.EvalRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Scorecard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AzureOpenAICredentialModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.UpdateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolTemplateSetup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SyncVoiceLibraryDTOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CartesiaPronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ProviderResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VariableValueGroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AnalyticsOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AnalyticsQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.KnowledgeBaseResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Squad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.PhoneNumberControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AnalyticsQueryResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}