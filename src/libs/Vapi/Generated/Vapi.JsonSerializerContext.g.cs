
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

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberRedactionItemJsonConverter),

            typeof(global::Vapi.JsonConverters.DeepgramTranscriberRedactionItemNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberRedactionItemJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackDeepgramTranscriberRedactionItemNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanPreviousAssistantMessagesTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ContextEngineeringPlanPreviousAssistantMessagesTypeNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.MinimaxLLMModelProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxLLMModelProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxLLMModelModelJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxLLMModelModelNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.MinimaxVoiceSubtitleTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceSubtitleTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceRegionJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceRegionNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostJsonConverter),

            typeof(global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceProviderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceModelJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceModelNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceSubtitleTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.FallbackMinimaxVoiceSubtitleTypeNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.AssistantSpeechWordAlignmentTimingTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantSpeechWordAlignmentTimingTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantSpeechWordProgressTimingTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.AssistantSpeechWordProgressTimingTypeNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.GetChatPaginatedDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.GetChatPaginatedDTOSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOColumnsJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOColumnsNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportChatDTOSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.GetSessionPaginatedDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.GetSessionPaginatedDTOSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOColumnsJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOColumnsNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOFormatJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOFormatNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.ExportSessionDTOSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.CustomKnowledgeBaseProviderJsonConverter),

            typeof(global::Vapi.JsonConverters.CustomKnowledgeBaseProviderNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.GetEvalPaginatedDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalPaginatedDTOSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.GetEvalRunPaginatedDTOSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.GetEvalRunPaginatedDTOSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechSourceJsonConverter),

            typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechSourceNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechTypeJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechTypeNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechSourceJsonConverter),

            typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechSourceNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.ChatControllerListChatsSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.ChatControllerListChatsSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllStatusJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllStatusNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.CampaignControllerFindAllSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.SessionControllerFindAllPaginatedSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.PhoneNumberControllerFindAllPaginatedSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.InsightControllerFindAllSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetPaginatedSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.EvalControllerGetRunsPaginatedSortByNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderNullableJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortByJsonConverter),

            typeof(global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortByNullableJsonConverter),

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

            typeof(global::Vapi.JsonConverters.TimingJsonConverter),

            typeof(global::Vapi.JsonConverters.Timing2JsonConverter),

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

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>),

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

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateAssistantDTOBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantBackgroundSound?, string>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>),

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

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageAssistantSpeech, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed>),

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

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>),

            typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageAssistantSpeech, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>>), TypeInfoPropertyName = "FallbackSonioxTranscriber_4c6f909973c83392")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>), TypeInfoPropertyName = "FallbackSonioxTranscriber_09c80b2a18506206")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberProvider), TypeInfoPropertyName = "AssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguage), TypeInfoPropertyName = "AssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberSpeechModel), TypeInfoPropertyName = "AssemblyAITranscriberSpeechModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberProvider), TypeInfoPropertyName = "AzureSpeechTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberLanguage), TypeInfoPropertyName = "AzureSpeechTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy), TypeInfoPropertyName = "AzureSpeechTranscriberSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberProvider), TypeInfoPropertyName = "CartesiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberModel), TypeInfoPropertyName = "CartesiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberLanguage), TypeInfoPropertyName = "CartesiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Server))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomTranscriberProvider), TypeInfoPropertyName = "CustomTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberProvider), TypeInfoPropertyName = "DeepgramTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.DeepgramTranscriberModel?, string>), TypeInfoPropertyName = "OneOfDeepgramTranscriberModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberModel), TypeInfoPropertyName = "DeepgramTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberLanguage), TypeInfoPropertyName = "DeepgramTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.DeepgramTranscriberRedactionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberRedactionItem), TypeInfoPropertyName = "DeepgramTranscriberRedactionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberProvider), TypeInfoPropertyName = "ElevenLabsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberModel), TypeInfoPropertyName = "ElevenLabsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberLanguage), TypeInfoPropertyName = "ElevenLabsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCustomVocabularyConfigDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>), TypeInfoPropertyName = "OneOfStringGladiaVocabularyItemDTO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaVocabularyItemDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberProvider), TypeInfoPropertyName = "GladiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberModel), TypeInfoPropertyName = "GladiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguageBehaviour), TypeInfoPropertyName = "GladiaTranscriberLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage), TypeInfoPropertyName = "GladiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguages), TypeInfoPropertyName = "GladiaTranscriberLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberRegion), TypeInfoPropertyName = "GladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberProvider), TypeInfoPropertyName = "SonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberModel), TypeInfoPropertyName = "SonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage), TypeInfoPropertyName = "SonioxTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCustomVocabularyItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberProvider), TypeInfoPropertyName = "SpeechmaticsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberModel), TypeInfoPropertyName = "SpeechmaticsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberLanguage), TypeInfoPropertyName = "SpeechmaticsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint), TypeInfoPropertyName = "SpeechmaticsTranscriberOperatingPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberRegion), TypeInfoPropertyName = "SpeechmaticsTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SpeechmaticsCustomVocabularyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle), TypeInfoPropertyName = "SpeechmaticsTranscriberNumeralStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberProvider), TypeInfoPropertyName = "TalkscriberTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberModel), TypeInfoPropertyName = "TalkscriberTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberLanguage), TypeInfoPropertyName = "TalkscriberTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberProvider), TypeInfoPropertyName = "GoogleTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberModel), TypeInfoPropertyName = "GoogleTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberLanguage), TypeInfoPropertyName = "GoogleTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberProvider), TypeInfoPropertyName = "OpenAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberModel), TypeInfoPropertyName = "OpenAITranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberLanguage), TypeInfoPropertyName = "OpenAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberProvider), TypeInfoPropertyName = "FallbackAssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage), TypeInfoPropertyName = "FallbackAssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel), TypeInfoPropertyName = "FallbackAssemblyAITranscriberSpeechModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider), TypeInfoPropertyName = "FallbackAzureSpeechTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage), TypeInfoPropertyName = "FallbackAzureSpeechTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy), TypeInfoPropertyName = "FallbackAzureSpeechTranscriberSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberProvider), TypeInfoPropertyName = "FallbackCartesiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberModel), TypeInfoPropertyName = "FallbackCartesiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberLanguage), TypeInfoPropertyName = "FallbackCartesiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomTranscriberProvider), TypeInfoPropertyName = "FallbackCustomTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberProvider), TypeInfoPropertyName = "FallbackDeepgramTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackDeepgramTranscriberModel?, string>), TypeInfoPropertyName = "OneOfFallbackDeepgramTranscriberModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberModel), TypeInfoPropertyName = "FallbackDeepgramTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberLanguage), TypeInfoPropertyName = "FallbackDeepgramTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FallbackDeepgramTranscriberRedactionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem), TypeInfoPropertyName = "FallbackDeepgramTranscriberRedactionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberProvider), TypeInfoPropertyName = "FallbackElevenLabsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberModel), TypeInfoPropertyName = "FallbackElevenLabsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage), TypeInfoPropertyName = "FallbackElevenLabsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberProvider), TypeInfoPropertyName = "FallbackGladiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberModel), TypeInfoPropertyName = "FallbackGladiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour), TypeInfoPropertyName = "FallbackGladiaTranscriberLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage), TypeInfoPropertyName = "FallbackGladiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguages), TypeInfoPropertyName = "FallbackGladiaTranscriberLanguages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberRegion), TypeInfoPropertyName = "FallbackGladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberProvider), TypeInfoPropertyName = "FallbackSonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberModel), TypeInfoPropertyName = "FallbackSonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage), TypeInfoPropertyName = "FallbackSonioxTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberOperatingPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle), TypeInfoPropertyName = "FallbackSpeechmaticsTranscriberNumeralStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberProvider), TypeInfoPropertyName = "FallbackTalkscriberTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberModel), TypeInfoPropertyName = "FallbackTalkscriberTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage), TypeInfoPropertyName = "FallbackTalkscriberTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberProvider), TypeInfoPropertyName = "FallbackGoogleTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberModel), TypeInfoPropertyName = "FallbackGoogleTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberLanguage), TypeInfoPropertyName = "FallbackGoogleTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberProvider), TypeInfoPropertyName = "FallbackOpenAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberModel), TypeInfoPropertyName = "FallbackOpenAITranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberLanguage), TypeInfoPropertyName = "FallbackOpenAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseObservabilityPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseObservabilityPlanProvider), TypeInfoPropertyName = "LangfuseObservabilityPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentType), TypeInfoPropertyName = "TextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentLanguage), TypeInfoPropertyName = "TextContentLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Condition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConditionOperator), TypeInfoPropertyName = "ConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageStart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageStartType), TypeInfoPropertyName = "ToolMessageStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageComplete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteType), TypeInfoPropertyName = "ToolMessageCompleteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteRole), TypeInfoPropertyName = "ToolMessageCompleteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailedType), TypeInfoPropertyName = "ToolMessageFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageDelayed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageDelayedType), TypeInfoPropertyName = "ToolMessageDelayedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageTargetRole), TypeInfoPropertyName = "MessageTargetRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexConditionType), TypeInfoPropertyName = "RegexConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LiquidCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LiquidConditionType), TypeInfoPropertyName = "LiquidConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionType), TypeInfoPropertyName = "GroupConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionOperator), TypeInfoPropertyName = "GroupConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>), TypeInfoPropertyName = "OneOfRegexConditionLiquidConditionGroupCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolRejectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDtmfToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>), TypeInfoPropertyName = "OneOfToolMessageStartToolMessageCompleteToolMessageFailedToolMessageDelayed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDtmfToolDTOType), TypeInfoPropertyName = "CreateDtmfToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEndCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEndCallToolDTOType), TypeInfoPropertyName = "CreateEndCallToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVoicemailToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVoicemailToolDTOType), TypeInfoPropertyName = "CreateVoicemailToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType), TypeInfoPropertyName = "JsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vapi.JsonSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat), TypeInfoPropertyName = "JsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableExtractionAlias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableExtractionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VariableExtractionAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, double?, bool?, object, byte[]>), TypeInfoPropertyName = "OneOfStringDoubleBooleanObjectByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunctionParametersType), TypeInfoPropertyName = "OpenAIFunctionParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFunctionToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFunctionToolDTOType), TypeInfoPropertyName = "CreateFunctionToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGhlToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGhlToolDTOType), TypeInfoPropertyName = "CreateGhlToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeToolDTOType), TypeInfoPropertyName = "CreateMakeToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType), TypeInfoPropertyName = "CustomMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>), TypeInfoPropertyName = "OneOfStringCustomMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantType), TypeInfoPropertyName = "TransferDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantTransferMode), TypeInfoPropertyName = "TransferDestinationAssistantTransferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferFallbackPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantModelProvider), TypeInfoPropertyName = "TransferAssistantModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexOptionType), TypeInfoPropertyName = "RegexOptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCustomEndpointingRuleType), TypeInfoPropertyName = "AssistantCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.RegexOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerCustomEndpointingRuleType), TypeInfoPropertyName = "CustomerCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BothCustomEndpointingRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BothCustomEndpointingRuleType), TypeInfoPropertyName = "BothCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSmartEndpointingPlanProvider), TypeInfoPropertyName = "VapiSmartEndpointingPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LivekitSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LivekitSmartEndpointingPlanProvider), TypeInfoPropertyName = "LivekitSmartEndpointingPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider), TypeInfoPropertyName = "CustomEndpointingModelSmartEndpointingPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptionEndpointingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>), TypeInfoPropertyName = "OneOfBooleanStartSpeakingPlanSmartEndpointingEnabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled), TypeInfoPropertyName = "StartSpeakingPlanSmartEndpointingEnabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>), TypeInfoPropertyName = "OneOfVapiSmartEndpointingPlanLivekitSmartEndpointingPlanCustomEndpointingModelSmartEndpointingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>), TypeInfoPropertyName = "OneOfAssistantCustomEndpointingRuleCustomerCustomEndpointingRuleBothCustomEndpointingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmartDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FourierDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackgroundSpeechDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>), TypeInfoPropertyName = "MinimaxVoice_5c3b3f0db00a1392")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>), TypeInfoPropertyName = "SonioxTranscriber_c55ae6127e3167d1")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferAssistantBackgroundSound?, string>), TypeInfoPropertyName = "OneOfTransferAssistantBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantBackgroundSound), TypeInfoPropertyName = "TransferAssistantBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferAssistantFirstMessageMode), TypeInfoPropertyName = "TransferAssistantFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCancelToolUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCancelToolUserEditableType), TypeInfoPropertyName = "TransferCancelToolUserEditableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferSuccessfulToolUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferSuccessfulToolUserEditableType), TypeInfoPropertyName = "TransferSuccessfulToolUserEditableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SummaryPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlanMode), TypeInfoPropertyName = "TransferPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>), TypeInfoPropertyName = "OneOfContextEngineeringPlanLastNMessagesContextEngineeringPlanNoneContextEngineeringPlanAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNone))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumberType), TypeInfoPropertyName = "TransferDestinationNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSip))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSipType), TypeInfoPropertyName = "TransferDestinationSipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTransferCallToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTransferCallToolDTOType), TypeInfoPropertyName = "CreateTransferCallToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>), TypeInfoPropertyName = "OneOfTransferDestinationAssistantTransferDestinationNumberTransferDestinationSip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType), TypeInfoPropertyName = "ContextEngineeringPlanLastNMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNoneType), TypeInfoPropertyName = "ContextEngineeringPlanNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAllType), TypeInfoPropertyName = "ContextEngineeringPlanAllType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType), TypeInfoPropertyName = "ContextEngineeringPlanUserAndAssistantMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistantType), TypeInfoPropertyName = "HandoffDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_125e53ec9b202456")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamicType), TypeInfoPropertyName = "HandoffDestinationDynamicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SquadMemberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>), TypeInfoPropertyName = "OneOfTransferDestinationAssistantHandoffDestinationAssistant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSquadDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquadType), TypeInfoPropertyName = "HandoffDestinationSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTOType), TypeInfoPropertyName = "CreateHandoffToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>), TypeInfoPropertyName = "OneOfHandoffDestinationAssistantHandoffDestinationDynamicHandoffDestinationSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider), TypeInfoPropertyName = "CreateCustomKnowledgeBaseDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseProvider), TypeInfoPropertyName = "KnowledgeBaseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseModel), TypeInfoPropertyName = "KnowledgeBaseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTOType), TypeInfoPropertyName = "CreateQueryToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType), TypeInfoPropertyName = "CreateGoogleCalendarCreateEventToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType), TypeInfoPropertyName = "CreateGoogleSheetsRowAppendToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType), TypeInfoPropertyName = "CreateGoogleCalendarCheckAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTOType), TypeInfoPropertyName = "CreateSlackSendMessageToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadataProtocol), TypeInfoPropertyName = "McpToolMetadataProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTOType), TypeInfoPropertyName = "CreateMcpToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelCalendarAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelCalendarEventCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelContactCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelContactGetToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole), TypeInfoPropertyName = "OpenAIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_ce07bd1a43aafc35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f4c4631be3aca304")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModelProvider), TypeInfoPropertyName = "AnyscaleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType), TypeInfoPropertyName = "AnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelModel), TypeInfoPropertyName = "AnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelProvider), TypeInfoPropertyName = "AnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelProvider), TypeInfoPropertyName = "AnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelModel), TypeInfoPropertyName = "AnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelModel), TypeInfoPropertyName = "CerebrasModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelProvider), TypeInfoPropertyName = "CerebrasModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelProvider), TypeInfoPropertyName = "CustomLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelMetadataSendMode), TypeInfoPropertyName = "CustomLLMModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModelProvider), TypeInfoPropertyName = "DeepInfraModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelModel), TypeInfoPropertyName = "DeepSeekModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelProvider), TypeInfoPropertyName = "DeepSeekModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName), TypeInfoPropertyName = "GeminiMultimodalLivePrebuiltVoiceConfigVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveSpeechConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleRealtimeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelModel), TypeInfoPropertyName = "GoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelProvider), TypeInfoPropertyName = "GoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelModel), TypeInfoPropertyName = "GroqModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelProvider), TypeInfoPropertyName = "GroqModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelModel), TypeInfoPropertyName = "InflectionAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelProvider), TypeInfoPropertyName = "InflectionAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelProvider), TypeInfoPropertyName = "MinimaxLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelModel), TypeInfoPropertyName = "MinimaxLLMModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelProvider), TypeInfoPropertyName = "OpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelModel), TypeInfoPropertyName = "OpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelFallbackModel), TypeInfoPropertyName = "OpenAIModelFallbackModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode), TypeInfoPropertyName = "OpenAIModelToolStrictCompatibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelPromptCacheRetention), TypeInfoPropertyName = "OpenAIModelPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModelProvider), TypeInfoPropertyName = "OpenRouterModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModelProvider), TypeInfoPropertyName = "PerplexityAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModelProvider), TypeInfoPropertyName = "TogetherAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HangupNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HangupNodeType), TypeInfoPropertyName = "HangupNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider), TypeInfoPropertyName = "WorkflowOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel), TypeInfoPropertyName = "WorkflowOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider), TypeInfoPropertyName = "WorkflowAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel), TypeInfoPropertyName = "WorkflowAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider), TypeInfoPropertyName = "WorkflowGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel), TypeInfoPropertyName = "WorkflowGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider), TypeInfoPropertyName = "WorkflowCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode), TypeInfoPropertyName = "WorkflowCustomModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GlobalNodePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNodeType), TypeInfoPropertyName = "ConversationNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>), TypeInfoPropertyName = "OneOfWorkflowOpenAIModelWorkflowAnthropicModelWorkflowAnthropicBedrockModelWorkflowGoogleModelWorkflowCustomModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNodeType), TypeInfoPropertyName = "ToolNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionBackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider), TypeInfoPropertyName = "GoogleVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanType), TypeInfoPropertyName = "GoogleVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider), TypeInfoPropertyName = "OpenAIVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanType), TypeInfoPropertyName = "OpenAIVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider), TypeInfoPropertyName = "TwilioVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType), TypeInfoPropertyName = "TwilioVoicemailDetectionPlanVoicemailDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanProvider), TypeInfoPropertyName = "VapiVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanType), TypeInfoPropertyName = "VapiVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferHookActionType), TypeInfoPropertyName = "TransferHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>), TypeInfoPropertyName = "OneOfTransferDestinationNumberTransferDestinationSip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCallHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCallHookActionType), TypeInfoPropertyName = "FunctionCallHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookActionType), TypeInfoPropertyName = "SayHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>), TypeInfoPropertyName = "OneOfStringIListOneOfSystemMessageUserMessageAssistantMessageToolMessageDeveloperMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>), TypeInfoPropertyName = "OneOfSystemMessageUserMessageAssistantMessageToolMessageDeveloperMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SystemMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UserMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageAddHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageAddHookActionType), TypeInfoPropertyName = "MessageAddHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookFilterType), TypeInfoPropertyName = "CallHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEndingOn), TypeInfoPropertyName = "CallHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>), TypeInfoPropertyName = "OneOfToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn), TypeInfoPropertyName = "CallHookAssistantSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>), TypeInfoPropertyName = "OneOfSayHookActionToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn), TypeInfoPropertyName = "CallHookCustomerSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookActionType), TypeInfoPropertyName = "ToolCallHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerSpeechTimeoutOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeoutOn), TypeInfoPropertyName = "CallHookModelResponseTimeoutOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeConditionType), TypeInfoPropertyName = "AIEdgeConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Edge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineType), TypeInfoPropertyName = "RecordingConsentPlanStayOnLineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbalType), TypeInfoPropertyName = "RecordingConsentPlanVerbalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SecurityFilterBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterPlanMode), TypeInfoPropertyName = "SecurityFilterPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlan), TypeInfoPropertyName = "RecordingConsentPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType), TypeInfoPropertyName = "CompliancePlanRecordingConsentPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredDataPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredDataMultiPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SuccessEvaluationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SuccessEvaluationPlanRubric), TypeInfoPropertyName = "SuccessEvaluationPlanRubric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComplianceOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType), TypeInfoPropertyName = "CreateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ArtifactPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ArtifactPlanRecordingFormat), TypeInfoPropertyName = "ArtifactPlanRecordingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateStructuredOutputDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateScorecardDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StopSpeakingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MonitorPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KeypadInputPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KeypadInputPlanDelimiters), TypeInfoPropertyName = "KeypadInputPlanDelimiters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>), TypeInfoPropertyName = "OneOfConversationNodeToolNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>), TypeInfoPropertyName = "OneOfWorkflowUserEditableBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableBackgroundSound), TypeInfoPropertyName = "WorkflowUserEditableBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_98afb529f903d70b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>), TypeInfoPropertyName = "CallHookModelResponseTimeout_f9cffc445e112054")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem), TypeInfoPropertyName = "CredentialsItem2_3")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider), TypeInfoPropertyName = "WorkflowUserEditableCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_cde2be735c2dd2b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableVoicemailDetection), TypeInfoPropertyName = "WorkflowUserEditableVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelProvider), TypeInfoPropertyName = "VapiModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelModel), TypeInfoPropertyName = "XaiModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelProvider), TypeInfoPropertyName = "XaiModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExactReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExactReplacementType), TypeInfoPropertyName = "ExactReplacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexReplacementType), TypeInfoPropertyName = "RegexReplacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FormatPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>), TypeInfoPropertyName = "OneOfExactReplacementRegexReplacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FormatPlanFormattersEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FormatPlanFormattersEnabledItem), TypeInfoPropertyName = "FormatPlanFormattersEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChunkPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ChunkPlanPunctuationBoundarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChunkPlanPunctuationBoundarie), TypeInfoPropertyName = "ChunkPlanPunctuationBoundarie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>>), TypeInfoPropertyName = "FallbackInworldVoice_883df0fa5ae9f6f5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>), TypeInfoPropertyName = "FallbackInworldVoice_e2d29acc9c7b0c6a")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceProvider), TypeInfoPropertyName = "AzureVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfAzureVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceVoiceId), TypeInfoPropertyName = "AzureVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>), TypeInfoPropertyName = "OneOfCartesiaExperimentalControlsSpeedDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsSpeed), TypeInfoPropertyName = "CartesiaExperimentalControlsSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsEmotion), TypeInfoPropertyName = "CartesiaExperimentalControlsEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaGenerationConfigExperimental))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaGenerationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceProvider), TypeInfoPropertyName = "CartesiaVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceModel), TypeInfoPropertyName = "CartesiaVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceLanguage), TypeInfoPropertyName = "CartesiaVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomVoiceProvider), TypeInfoPropertyName = "CustomVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceProvider), TypeInfoPropertyName = "DeepgramVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceVoiceId), TypeInfoPropertyName = "DeepgramVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceModel), TypeInfoPropertyName = "DeepgramVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceProvider), TypeInfoPropertyName = "ElevenLabsVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfElevenLabsVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceVoiceId), TypeInfoPropertyName = "ElevenLabsVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceModel), TypeInfoPropertyName = "ElevenLabsVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ElevenLabsPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceProvider), TypeInfoPropertyName = "WellSaidVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceModel), TypeInfoPropertyName = "WellSaidVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceProvider), TypeInfoPropertyName = "HumeVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceModel), TypeInfoPropertyName = "HumeVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceProvider), TypeInfoPropertyName = "LMNTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfLMNTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceVoiceId), TypeInfoPropertyName = "LMNTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceLanguage), TypeInfoPropertyName = "LMNTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceProvider), TypeInfoPropertyName = "NeuphonicVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceModel), TypeInfoPropertyName = "NeuphonicVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceProvider), TypeInfoPropertyName = "OpenAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.OpenAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfOpenAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceVoiceId), TypeInfoPropertyName = "OpenAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceModel), TypeInfoPropertyName = "OpenAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceProvider), TypeInfoPropertyName = "PlayHTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfPlayHTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceVoiceId), TypeInfoPropertyName = "PlayHTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceEmotion), TypeInfoPropertyName = "PlayHTVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceModel), TypeInfoPropertyName = "PlayHTVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceLanguage), TypeInfoPropertyName = "PlayHTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceProvider), TypeInfoPropertyName = "RimeAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfRimeAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceVoiceId), TypeInfoPropertyName = "RimeAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceModel), TypeInfoPropertyName = "RimeAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceLanguage), TypeInfoPropertyName = "RimeAIVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceProvider), TypeInfoPropertyName = "SesameVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceModel), TypeInfoPropertyName = "SesameVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceProvider), TypeInfoPropertyName = "SmallestAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfSmallestAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceVoiceId), TypeInfoPropertyName = "SmallestAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceModel), TypeInfoPropertyName = "SmallestAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusConversationProperties))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusVoiceProvider), TypeInfoPropertyName = "TavusVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TavusVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfTavusVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusVoiceVoiceId), TypeInfoPropertyName = "TavusVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceProvider), TypeInfoPropertyName = "VapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceVoiceId), TypeInfoPropertyName = "VapiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VapiPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceProvider), TypeInfoPropertyName = "InworldVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceVoiceId), TypeInfoPropertyName = "InworldVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceModel), TypeInfoPropertyName = "InworldVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceLanguageCode), TypeInfoPropertyName = "InworldVoiceLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceProvider), TypeInfoPropertyName = "MinimaxVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceModel), TypeInfoPropertyName = "MinimaxVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceSubtitleType), TypeInfoPropertyName = "MinimaxVoiceSubtitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceRegion), TypeInfoPropertyName = "MinimaxVoiceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceLanguageBoost), TypeInfoPropertyName = "MinimaxVoiceLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceProvider), TypeInfoPropertyName = "FallbackMinimaxVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceModel), TypeInfoPropertyName = "FallbackMinimaxVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceSubtitleType), TypeInfoPropertyName = "FallbackMinimaxVoiceSubtitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceRegion), TypeInfoPropertyName = "FallbackMinimaxVoiceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMinimaxVoiceLanguageBoost), TypeInfoPropertyName = "FallbackMinimaxVoiceLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceProvider), TypeInfoPropertyName = "FallbackWellSaidVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceModel), TypeInfoPropertyName = "FallbackWellSaidVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceProvider), TypeInfoPropertyName = "FallbackAzureVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackAzureVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceVoiceId), TypeInfoPropertyName = "FallbackAzureVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceProvider), TypeInfoPropertyName = "FallbackCartesiaVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceModel), TypeInfoPropertyName = "FallbackCartesiaVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceLanguage), TypeInfoPropertyName = "FallbackCartesiaVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomVoiceProvider), TypeInfoPropertyName = "FallbackCustomVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceProvider), TypeInfoPropertyName = "FallbackDeepgramVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceVoiceId), TypeInfoPropertyName = "FallbackDeepgramVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceModel), TypeInfoPropertyName = "FallbackDeepgramVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceProvider), TypeInfoPropertyName = "FallbackElevenLabsVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackElevenLabsVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId), TypeInfoPropertyName = "FallbackElevenLabsVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceModel), TypeInfoPropertyName = "FallbackElevenLabsVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceProvider), TypeInfoPropertyName = "FallbackHumeVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceModel), TypeInfoPropertyName = "FallbackHumeVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceProvider), TypeInfoPropertyName = "FallbackLMNTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackLMNTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceVoiceId), TypeInfoPropertyName = "FallbackLMNTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceLanguage), TypeInfoPropertyName = "FallbackLMNTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceProvider), TypeInfoPropertyName = "FallbackNeuphonicVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceModel), TypeInfoPropertyName = "FallbackNeuphonicVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceProvider), TypeInfoPropertyName = "FallbackOpenAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackOpenAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceVoiceId), TypeInfoPropertyName = "FallbackOpenAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceModel), TypeInfoPropertyName = "FallbackOpenAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceProvider), TypeInfoPropertyName = "FallbackPlayHTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackPlayHTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceVoiceId), TypeInfoPropertyName = "FallbackPlayHTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceEmotion), TypeInfoPropertyName = "FallbackPlayHTVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceModel), TypeInfoPropertyName = "FallbackPlayHTVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceLanguage), TypeInfoPropertyName = "FallbackPlayHTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceProvider), TypeInfoPropertyName = "FallbackRimeAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackRimeAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceVoiceId), TypeInfoPropertyName = "FallbackRimeAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceModel), TypeInfoPropertyName = "FallbackRimeAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceLanguage), TypeInfoPropertyName = "FallbackRimeAIVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceProvider), TypeInfoPropertyName = "FallbackSesameVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceModel), TypeInfoPropertyName = "FallbackSesameVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceProvider), TypeInfoPropertyName = "FallbackSmallestAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackSmallestAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId), TypeInfoPropertyName = "FallbackSmallestAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceModel), TypeInfoPropertyName = "FallbackSmallestAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTavusVoiceProvider), TypeInfoPropertyName = "FallbackTavusVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackTavusVoiceVoiceId?, string>), TypeInfoPropertyName = "OneOfFallbackTavusVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTavusVoiceVoiceId), TypeInfoPropertyName = "FallbackTavusVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceProvider), TypeInfoPropertyName = "FallbackVapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceVoiceId), TypeInfoPropertyName = "FallbackVapiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceProvider), TypeInfoPropertyName = "FallbackInworldVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceVoiceId), TypeInfoPropertyName = "FallbackInworldVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceModel), TypeInfoPropertyName = "FallbackInworldVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceLanguageCode), TypeInfoPropertyName = "FallbackInworldVoiceLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioProvider), TypeInfoPropertyName = "TransportConfigurationTwilioProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels), TypeInfoPropertyName = "TransportConfigurationTwilioRecordingChannels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicCredentialDTOProvider), TypeInfoPropertyName = "CreateAnthropicCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider), TypeInfoPropertyName = "CreateAnthropicBedrockCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion), TypeInfoPropertyName = "CreateAnthropicBedrockCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>), TypeInfoPropertyName = "OneOfAWSIAMCredentialsAuthenticationPlanAWSStsAuthenticationPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider), TypeInfoPropertyName = "CreateAnyscaleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider), TypeInfoPropertyName = "CreateAssemblyAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureBlobStorageBucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOProvider), TypeInfoPropertyName = "CreateAzureCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOService), TypeInfoPropertyName = "CreateAzureCredentialDTOService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTORegion), TypeInfoPropertyName = "CreateAzureCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider), TypeInfoPropertyName = "CreateAzureOpenAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion), TypeInfoPropertyName = "CreateAzureOpenAICredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel), TypeInfoPropertyName = "CreateAzureOpenAICredentialDTOModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkGateway))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkGatewayOutboundProtocol), TypeInfoPropertyName = "SipTrunkGatewayOutboundProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkOutboundSipRegisterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkOutboundAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SbcConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider), TypeInfoPropertyName = "CreateByoSipTrunkCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SipTrunkGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCartesiaCredentialDTOProvider), TypeInfoPropertyName = "CreateCartesiaCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareR2BucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCloudflareCredentialDTOProvider), TypeInfoPropertyName = "CreateCloudflareCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OAuth2AuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OAuth2AuthenticationPlanType), TypeInfoPropertyName = "OAuth2AuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider), TypeInfoPropertyName = "CreateCustomLLMCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepgramCredentialDTOProvider), TypeInfoPropertyName = "CreateDeepgramCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider), TypeInfoPropertyName = "CreateDeepInfraCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider), TypeInfoPropertyName = "CreateDeepSeekCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider), TypeInfoPropertyName = "CreateElevenLabsCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGcpCredentialDTOProvider), TypeInfoPropertyName = "CreateGcpCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGladiaCredentialDTOProvider), TypeInfoPropertyName = "CreateGladiaCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider), TypeInfoPropertyName = "CreateGoHighLevelCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGroqCredentialDTOProvider), TypeInfoPropertyName = "CreateGroqCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLangfuseCredentialDTOProvider), TypeInfoPropertyName = "CreateLangfuseCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLmntCredentialDTOProvider), TypeInfoPropertyName = "CreateLmntCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeCredentialDTOProvider), TypeInfoPropertyName = "CreateMakeCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenAICredentialDTOProvider), TypeInfoPropertyName = "CreateOpenAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider), TypeInfoPropertyName = "CreateOpenRouterCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider), TypeInfoPropertyName = "CreatePerplexityAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePlayHTCredentialDTOProvider), TypeInfoPropertyName = "CreatePlayHTCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRimeAICredentialDTOProvider), TypeInfoPropertyName = "CreateRimeAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRunpodCredentialDTOProvider), TypeInfoPropertyName = "CreateRunpodCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CredentialDTOProvider), TypeInfoPropertyName = "CreateS3CredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseBucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseBucketPlanRegion), TypeInfoPropertyName = "SupabaseBucketPlanRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSupabaseCredentialDTOProvider), TypeInfoPropertyName = "CreateSupabaseCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmallestAICredentialDTOProvider), TypeInfoPropertyName = "CreateSmallestAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTavusCredentialDTOProvider), TypeInfoPropertyName = "CreateTavusCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTogetherAICredentialDTOProvider), TypeInfoPropertyName = "CreateTogetherAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioCredentialDTOProvider), TypeInfoPropertyName = "CreateTwilioCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonageCredentialDTOProvider), TypeInfoPropertyName = "CreateVonageCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOProvider), TypeInfoPropertyName = "CreateWebhookCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan2), TypeInfoPropertyName = "AuthenticationPlan22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateXAiCredentialDTOProvider), TypeInfoPropertyName = "CreateXAiCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider), TypeInfoPropertyName = "CreateGoogleCalendarOAuth2ClientCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider), TypeInfoPropertyName = "CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider), TypeInfoPropertyName = "CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider), TypeInfoPropertyName = "CreateSlackOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMinimaxCredentialDTOProvider), TypeInfoPropertyName = "CreateMinimaxCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndpointedSpeechLowConfidenceOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookTranscriberEndpointedSpeechLowConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHookOn), TypeInfoPropertyName = "SessionCreatedHookOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SQLInjectionSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SQLInjectionSecurityFilterType), TypeInfoPropertyName = "SQLInjectionSecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XSSSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XSSSecurityFilterType), TypeInfoPropertyName = "XSSSecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SSRFSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SSRFSecurityFilterType), TypeInfoPropertyName = "SSRFSecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RCESecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RCESecurityFilterType), TypeInfoPropertyName = "RCESecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PromptInjectionSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PromptInjectionSecurityFilterType), TypeInfoPropertyName = "PromptInjectionSecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexSecurityFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexSecurityFilterType), TypeInfoPropertyName = "RegexSecurityFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>), TypeInfoPropertyName = "XaiModel_4412bb1f9df13d62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesFirstMessageMode), TypeInfoPropertyName = "AssistantOverridesFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_40aab5fbf952716b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesVoicemailDetection), TypeInfoPropertyName = "AssistantOverridesVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesClientMessage), TypeInfoPropertyName = "AssistantOverridesClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesServerMessage), TypeInfoPropertyName = "AssistantOverridesServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>), TypeInfoPropertyName = "OneOfAssistantOverridesBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesBackgroundSound), TypeInfoPropertyName = "AssistantOverridesBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem2), TypeInfoPropertyName = "CredentialsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider), TypeInfoPropertyName = "AssistantOverridesCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_929e4b5bda008e83")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>), TypeInfoPropertyName = "SessionCreatedHook_2fbeaab55b62844d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOFirstMessageMode), TypeInfoPropertyName = "CreateAssistantDTOFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_e1db2a7da54afeb3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOVoicemailDetection), TypeInfoPropertyName = "CreateAssistantDTOVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOClientMessage), TypeInfoPropertyName = "CreateAssistantDTOClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOServerMessage), TypeInfoPropertyName = "CreateAssistantDTOServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateAssistantDTOBackgroundSound?, string>), TypeInfoPropertyName = "OneOfCreateAssistantDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOBackgroundSound), TypeInfoPropertyName = "CreateAssistantDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem3), TypeInfoPropertyName = "CredentialsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssistantDTOCredentialDiscriminatorProvider), TypeInfoPropertyName = "CreateAssistantDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Assistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantFirstMessageMode), TypeInfoPropertyName = "AssistantFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_5ea6be4364d98ee0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantVoicemailDetection), TypeInfoPropertyName = "AssistantVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantClientMessage), TypeInfoPropertyName = "AssistantClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantServerMessage), TypeInfoPropertyName = "AssistantServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>), TypeInfoPropertyName = "OneOfAssistantBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantBackgroundSound), TypeInfoPropertyName = "AssistantBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem4), TypeInfoPropertyName = "CredentialsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCredentialDiscriminatorProvider), TypeInfoPropertyName = "AssistantCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Assistant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantVersionPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOFirstMessageMode), TypeInfoPropertyName = "UpdateAssistantDTOFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_fed6dd3f311e149b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOVoicemailDetection), TypeInfoPropertyName = "UpdateAssistantDTOVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOClientMessage), TypeInfoPropertyName = "UpdateAssistantDTOClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOServerMessage), TypeInfoPropertyName = "UpdateAssistantDTOServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>), TypeInfoPropertyName = "OneOfUpdateAssistantDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOBackgroundSound), TypeInfoPropertyName = "UpdateAssistantDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem5), TypeInfoPropertyName = "CredentialsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssistantDTOCredentialDiscriminatorProvider), TypeInfoPropertyName = "UpdateAssistantDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Squad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSquadDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Workflow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowBackgroundSound?, string>), TypeInfoPropertyName = "OneOfWorkflowBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowBackgroundSound), TypeInfoPropertyName = "WorkflowBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem6>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem6), TypeInfoPropertyName = "CredentialsItem62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCredentialDiscriminatorProvider), TypeInfoPropertyName = "WorkflowCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_528082a31b8c97e5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowVoicemailDetection), TypeInfoPropertyName = "WorkflowVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>), TypeInfoPropertyName = "OneOfCreateWorkflowDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOBackgroundSound), TypeInfoPropertyName = "CreateWorkflowDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem7), TypeInfoPropertyName = "CredentialsItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider), TypeInfoPropertyName = "CreateWorkflowDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_1f400c141931bc20")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWorkflowDTOVoicemailDetection), TypeInfoPropertyName = "CreateWorkflowDTOVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOBackgroundSound?, string>), TypeInfoPropertyName = "OneOfUpdateWorkflowDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOBackgroundSound), TypeInfoPropertyName = "UpdateWorkflowDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem8>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem8), TypeInfoPropertyName = "CredentialsItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider), TypeInfoPropertyName = "UpdateWorkflowDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UpdateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_29d121cee54e7bc7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWorkflowDTOVoicemailDetection), TypeInfoPropertyName = "UpdateWorkflowDTOVoicemailDetection2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>), TypeInfoPropertyName = "OneOfUserMessageSystemMessageBotMessageToolCallMessageToolCallResultMessage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPhoneNumberHookActionType), TypeInfoPropertyName = "TransferPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayPhoneNumberHookActionType), TypeInfoPropertyName = "SayPhoneNumberHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterType), TypeInfoPropertyName = "PhoneNumberCallRingingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallRingingHookFilterKey), TypeInfoPropertyName = "PhoneNumberCallRingingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRinging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallRingingOn), TypeInfoPropertyName = "PhoneNumberHookCallRingingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>), TypeInfoPropertyName = "OneOfTransferPhoneNumberHookActionSayPhoneNumberHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterType), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterKey), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterKey2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem), TypeInfoPropertyName = "PhoneNumberCallEndingHookFilterOneOfItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberHookCallEndingOn), TypeInfoPropertyName = "PhoneNumberHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ImportTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>), TypeInfoPropertyName = "OneOfPhoneNumberHookCallRingingPhoneNumberHookCallEnding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomerDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SchedulePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Call))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallType), TypeInfoPropertyName = "CallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>), TypeInfoPropertyName = "OneOfTransportCostTranscriberCostModelCostVoiceCostVapiCostVoicemailDetectionCostAnalysisCostKnowledgeBaseCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriberCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ModelCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPhoneCallProvider), TypeInfoPropertyName = "CallPhoneCallProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPhoneCallTransport), TypeInfoPropertyName = "CallPhoneCallTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallStatus), TypeInfoPropertyName = "CallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallEndedReason), TypeInfoPropertyName = "CallEndedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallBatchError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Call>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CallBatchError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantSpeechWordAlignmentTimingType), TypeInfoPropertyName = "AssistantSpeechWordAlignmentTimingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantSpeechWordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantSpeechWordProgressTiming))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantSpeechWordProgressTimingType), TypeInfoPropertyName = "AssistantSpeechWordProgressTimingType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantSpeechWordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputFilterDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutboundCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeleteCallDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessageRole), TypeInfoPropertyName = "DeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageRole), TypeInfoPropertyName = "ToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Chat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.ChatCost>), TypeInfoPropertyName = "OneOfModelCostChatCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransportConversationType), TypeInfoPropertyName = "TwilioSMSChatTransportConversationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioSMSChatTransportType), TypeInfoPropertyName = "TwilioSMSChatTransportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateChatDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetChatPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetChatPaginatedDTOSortOrder), TypeInfoPropertyName = "GetChatPaginatedDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetChatPaginatedDTOSortBy), TypeInfoPropertyName = "GetChatPaginatedDTOSortBy2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOColumns), TypeInfoPropertyName = "ExportChatDTOColumns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOFormat), TypeInfoPropertyName = "ExportChatDTOFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOSortOrder), TypeInfoPropertyName = "ExportChatDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportChatDTOSortBy), TypeInfoPropertyName = "ExportChatDTOSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputTextType), TypeInfoPropertyName = "ResponseOutputTextType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ResponseOutputText>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageRole), TypeInfoPropertyName = "ResponseOutputMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageStatus), TypeInfoPropertyName = "ResponseOutputMessageStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseOutputMessageType), TypeInfoPropertyName = "ResponseOutputMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObjectObject), TypeInfoPropertyName = "ResponseObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseObjectStatus), TypeInfoPropertyName = "ResponseObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ResponseOutputMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDeltaEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDeltaEventType), TypeInfoPropertyName = "ResponseTextDeltaEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDoneEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseTextDoneEventType), TypeInfoPropertyName = "ResponseTextDoneEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseCompletedEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseCompletedEventType), TypeInfoPropertyName = "ResponseCompletedEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseErrorEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ResponseErrorEventType), TypeInfoPropertyName = "ResponseErrorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DialPlanEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCampaignDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Campaign))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignStatus), TypeInfoPropertyName = "CampaignStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignEndedReason), TypeInfoPropertyName = "CampaignEndedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Campaign>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCampaignDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCampaignDTOStatus), TypeInfoPropertyName = "UpdateCampaignDTOStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetAssistantType), TypeInfoPropertyName = "RelayTargetAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetSquadType), TypeInfoPropertyName = "RelayTargetSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayTargetOptionsType), TypeInfoPropertyName = "RelayTargetOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandSay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandSayType), TypeInfoPropertyName = "RelayCommandSayType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandNote))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandNoteType), TypeInfoPropertyName = "RelayCommandNoteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayCommandOptionsType), TypeInfoPropertyName = "RelayCommandOptionsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RelayTargetAssistant, global::Vapi.RelayTargetSquad>), TypeInfoPropertyName = "OneOfRelayTargetAssistantRelayTargetSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RelayCommandSay, global::Vapi.RelayCommandNote>), TypeInfoPropertyName = "OneOfRelayCommandSayRelayCommandNote2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RelayResponseStatus), TypeInfoPropertyName = "RelayResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Session))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>), TypeInfoPropertyName = "OneOfModelCostAnalysisCostSessionCost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionStatus), TypeInfoPropertyName = "SessionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSessionDTOStatus), TypeInfoPropertyName = "CreateSessionDTOStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSessionDTOStatus), TypeInfoPropertyName = "UpdateSessionDTOStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetSessionPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetSessionPaginatedDTOSortOrder), TypeInfoPropertyName = "GetSessionPaginatedDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetSessionPaginatedDTOSortBy), TypeInfoPropertyName = "GetSessionPaginatedDTOSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Session>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOColumns), TypeInfoPropertyName = "ExportSessionDTOColumns2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOFormat), TypeInfoPropertyName = "ExportSessionDTOFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOSortOrder), TypeInfoPropertyName = "ExportSessionDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExportSessionDTOSortBy), TypeInfoPropertyName = "ExportSessionDTOSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberProvider), TypeInfoPropertyName = "ByoPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoPhoneNumberStatus), TypeInfoPropertyName = "ByoPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberProvider), TypeInfoPropertyName = "TwilioPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioPhoneNumberStatus), TypeInfoPropertyName = "TwilioPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberProvider), TypeInfoPropertyName = "VonagePhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonagePhoneNumberStatus), TypeInfoPropertyName = "VonagePhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipAuthentication))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberProvider), TypeInfoPropertyName = "VapiPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPhoneNumberStatus), TypeInfoPropertyName = "VapiPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberProvider), TypeInfoPropertyName = "TelnyxPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TelnyxPhoneNumberStatus), TypeInfoPropertyName = "TelnyxPhoneNumberStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateByoPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateTwilioPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonagePhoneNumberDTOProvider), TypeInfoPropertyName = "CreateVonagePhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVapiPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateVapiPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTelnyxPhoneNumberDTOProvider), TypeInfoPropertyName = "CreateTelnyxPhoneNumberDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateByoPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVapiPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ImportVonagePhoneNumberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ByoPhoneNumber, global::Vapi.TwilioPhoneNumber, global::Vapi.VonagePhoneNumber, global::Vapi.VapiPhoneNumber, global::Vapi.TelnyxPhoneNumber>), TypeInfoPropertyName = "OneOfByoPhoneNumberTwilioPhoneNumberVonagePhoneNumberVapiPhoneNumberTelnyxPhoneNumber2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestToolType), TypeInfoPropertyName = "ApiRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ApiRequestToolMethod), TypeInfoPropertyName = "ApiRequestToolMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeToolEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeToolType), TypeInfoPropertyName = "CodeToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DtmfTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DtmfToolType), TypeInfoPropertyName = "DtmfToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndCallToolType), TypeInfoPropertyName = "EndCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolType), TypeInfoPropertyName = "FunctionToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolType), TypeInfoPropertyName = "GhlToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolType), TypeInfoPropertyName = "MakeToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCallTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferCallToolType), TypeInfoPropertyName = "TransferCallToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffToolType), TypeInfoPropertyName = "HandoffToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OutputTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OutputToolType), TypeInfoPropertyName = "OutputToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolType), TypeInfoPropertyName = "BashToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolSubType), TypeInfoPropertyName = "BashToolSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolName), TypeInfoPropertyName = "BashToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolType), TypeInfoPropertyName = "ComputerToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolSubType), TypeInfoPropertyName = "ComputerToolSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolName), TypeInfoPropertyName = "ComputerToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolType), TypeInfoPropertyName = "TextEditorToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolSubType), TypeInfoPropertyName = "TextEditorToolSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolName), TypeInfoPropertyName = "TextEditorToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.QueryTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.QueryToolType), TypeInfoPropertyName = "QueryToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolType), TypeInfoPropertyName = "GoogleCalendarCreateEventToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolType), TypeInfoPropertyName = "GoogleSheetsRowAppendToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCheckAvailabilityTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCheckAvailabilityToolType), TypeInfoPropertyName = "GoogleCalendarCheckAvailabilityToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackSendMessageTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackSendMessageToolType), TypeInfoPropertyName = "SlackSendMessageToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmsToolType), TypeInfoPropertyName = "SmsToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolType), TypeInfoPropertyName = "McpToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolType), TypeInfoPropertyName = "GoHighLevelCalendarAvailabilityToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolType), TypeInfoPropertyName = "GoHighLevelCalendarEventCreateToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolType), TypeInfoPropertyName = "GoHighLevelContactCreateToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolType), TypeInfoPropertyName = "GoHighLevelContactGetToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestToolType), TypeInfoPropertyName = "SipRequestToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipRequestToolVerb), TypeInfoPropertyName = "SipRequestToolVerb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.JsonSchema>), TypeInfoPropertyName = "OneOfStringJsonSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailToolType), TypeInfoPropertyName = "VoicemailToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOType), TypeInfoPropertyName = "CreateApiRequestToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOMethod), TypeInfoPropertyName = "CreateApiRequestToolDTOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTOType), TypeInfoPropertyName = "CreateCodeToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutputToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOutputToolDTOType), TypeInfoPropertyName = "CreateOutputToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOType), TypeInfoPropertyName = "CreateBashToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOSubType), TypeInfoPropertyName = "CreateBashToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOName), TypeInfoPropertyName = "CreateBashToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOType), TypeInfoPropertyName = "CreateComputerToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOSubType), TypeInfoPropertyName = "CreateComputerToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOName), TypeInfoPropertyName = "CreateComputerToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOType), TypeInfoPropertyName = "CreateTextEditorToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOSubType), TypeInfoPropertyName = "CreateTextEditorToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOName), TypeInfoPropertyName = "CreateTextEditorToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTOType), TypeInfoPropertyName = "CreateSmsToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOType), TypeInfoPropertyName = "CreateSipRequestToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOVerb), TypeInfoPropertyName = "CreateSipRequestToolDTOVerb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateApiRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateApiRequestToolDTOMethod), TypeInfoPropertyName = "UpdateApiRequestToolDTOMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBashToolDTOSubType), TypeInfoPropertyName = "UpdateBashToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBashToolDTOName), TypeInfoPropertyName = "UpdateBashToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTOSubType), TypeInfoPropertyName = "UpdateComputerToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateComputerToolDTOName), TypeInfoPropertyName = "UpdateComputerToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTOSubType), TypeInfoPropertyName = "UpdateTextEditorToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextEditorToolDTOName), TypeInfoPropertyName = "UpdateTextEditorToolDTOName2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSipRequestToolDTOVerb), TypeInfoPropertyName = "UpdateSipRequestToolDTOVerb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVoicemailToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFileDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FileObject), TypeInfoPropertyName = "FileObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FileStatus), TypeInfoPropertyName = "FileStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateFileDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomKnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomKnowledgeBaseProvider), TypeInfoPropertyName = "CustomKnowledgeBaseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputType), TypeInfoPropertyName = "StructuredOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTOType), TypeInfoPropertyName = "UpdateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TesterPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitePhoneNumberProvider), TypeInfoPropertyName = "TestSuitePhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TargetPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuitesPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteTestScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestScorerAI), TypeInfoPropertyName = "TestSuiteTestScorerAI2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestVoiceType), TypeInfoPropertyName = "TestSuiteTestVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestChat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestChatType), TypeInfoPropertyName = "TestSuiteTestChatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestVoiceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestVoiceDtoType), TypeInfoPropertyName = "CreateTestSuiteTestVoiceDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestChatDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTestSuiteTestChatDtoType), TypeInfoPropertyName = "CreateTestSuiteTestChatDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestVoiceDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestVoiceDtoType), TypeInfoPropertyName = "UpdateTestSuiteTestVoiceDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestChatDto))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTestSuiteTestChatDtoType), TypeInfoPropertyName = "UpdateTestSuiteTestChatDtoType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestScorerAIType), TypeInfoPropertyName = "TestSuiteTestScorerAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteTestsPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TestSuiteTestVoice, global::Vapi.TestSuiteTestChat>), TypeInfoPropertyName = "OneOfTestSuiteTestVoiceTestSuiteTestChat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAIType), TypeInfoPropertyName = "TestSuiteRunScorerAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunScorerAIResult), TypeInfoPropertyName = "TestSuiteRunScorerAIResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttemptCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttemptMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestAttempt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunScorerAI>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunTestResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TestSuiteRunTestAttempt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TestSuiteRunStatus), TypeInfoPropertyName = "TestSuiteRunStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookActionType), TypeInfoPropertyName = "SimulationHookWebhookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStartedOn), TypeInfoPropertyName = "SimulationHookCallStartedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEnded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEndedOn), TypeInfoPropertyName = "SimulationHookCallEndedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvaluationPlanItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvaluationPlanItemComparator), TypeInfoPropertyName = "EvaluationPlanItemComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?>), TypeInfoPropertyName = "OneOfDoubleStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScenarioToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateScenarioDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>), TypeInfoPropertyName = "OneOfSimulationHookCallStartedSimulationHookCallEnded2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Scenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateScenarioDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSimulationEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSimulationEntryType), TypeInfoPropertyName = "SimulationRunSimulationEntryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSuiteEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunSuiteEntryType), TypeInfoPropertyName = "SimulationRunSuiteEntryType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetAssistantType), TypeInfoPropertyName = "SimulationRunTargetAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTargetSquadType), TypeInfoPropertyName = "SimulationRunTargetSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfigurationProvider), TypeInfoPropertyName = "SimulationRunTransportConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>), TypeInfoPropertyName = "OneOfSimulationRunSimulationEntrySimulationRunSuiteEntry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad>), TypeInfoPropertyName = "OneOfSimulationRunTargetAssistantSimulationRunTargetSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunStatus), TypeInfoPropertyName = "SimulationRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?, object>), TypeInfoPropertyName = "OneOfDoubleStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResultComparator), TypeInfoPropertyName = "StructuredOutputEvaluationResultComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LatencyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovementSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemStatus), TypeInfoPropertyName = "SimulationRunItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationSuiteDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationSuiteDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenarioCategory), TypeInfoPropertyName = "GeneratedScenarioCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Simulation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRangeWithStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRangeWithStepStep), TypeInfoPropertyName = "InsightTimeRangeWithStepStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightType), TypeInfoPropertyName = "BarInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.InsightFormula>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightFormula))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightGroupBy), TypeInfoPropertyName = "BarInsightGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>>), TypeInfoPropertyName = "JSONQueryOnEventsTable_2fe08885d7d10f9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>), TypeInfoPropertyName = "JSONQueryOnEventsTable_453699d266424d39")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightType), TypeInfoPropertyName = "PieInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightGroupBy), TypeInfoPropertyName = "PieInsightGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>>), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumn_e946a20b4e1d81a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumn_fac8b48283ca97c0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightType), TypeInfoPropertyName = "LineInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightGroupBy), TypeInfoPropertyName = "LineInsightGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightType), TypeInfoPropertyName = "TextInsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTOType), TypeInfoPropertyName = "UpdateBarInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateBarInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "UpdateBarInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTOType), TypeInfoPropertyName = "UpdatePieInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePieInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "UpdatePieInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTOType), TypeInfoPropertyName = "UpdateLineInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateLineInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "UpdateLineInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTextInsightFromCallTableDTOType), TypeInfoPropertyName = "UpdateTextInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTOType), TypeInfoPropertyName = "CreateBarInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBarInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "CreateBarInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTOType), TypeInfoPropertyName = "CreatePieInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePieInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "CreatePieInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTOType), TypeInfoPropertyName = "CreateLineInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLineInsightFromCallTableDTOGroupBy), TypeInfoPropertyName = "CreateLineInsightFromCallTableDTOGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextInsightFromCallTableDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextInsightFromCallTableDTOType), TypeInfoPropertyName = "CreateTextInsightFromCallTableDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnType), TypeInfoPropertyName = "JSONQueryOnCallTableWithStringTypeColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnTable), TypeInfoPropertyName = "JSONQueryOnCallTableWithStringTypeColumnTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>), TypeInfoPropertyName = "FilterStructuredOutputColumnOnCallTable_0d76f408775bd34b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>), TypeInfoPropertyName = "FilterStructuredOutputColumnOnCallTable_813092fb06040e41")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnColumn), TypeInfoPropertyName = "JSONQueryOnCallTableWithStringTypeColumnColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStringTypeColumnOperation), TypeInfoPropertyName = "JSONQueryOnCallTableWithStringTypeColumnOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType), TypeInfoPropertyName = "JSONQueryOnCallTableWithNumberTypeColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable), TypeInfoPropertyName = "JSONQueryOnCallTableWithNumberTypeColumnTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn), TypeInfoPropertyName = "JSONQueryOnCallTableWithNumberTypeColumnColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation), TypeInfoPropertyName = "JSONQueryOnCallTableWithNumberTypeColumnOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnType), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnTable), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumnTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnColumn), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumnColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumnOperation), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumnOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableType), TypeInfoPropertyName = "JSONQueryOnEventsTableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableTable), TypeInfoPropertyName = "JSONQueryOnEventsTableTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableOn), TypeInfoPropertyName = "JSONQueryOnEventsTableOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JSONQueryOnEventsTableOperation), TypeInfoPropertyName = "JSONQueryOnEventsTableOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>), TypeInfoPropertyName = "OneOfEventsTableStringConditionEventsTableNumberConditionEventsTableBooleanCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableStringCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableNumberCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableBooleanCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTableColumn), TypeInfoPropertyName = "FilterStringTypeColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringTypeColumnOnCallTableOperator), TypeInfoPropertyName = "FilterStringTypeColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTableColumn), TypeInfoPropertyName = "FilterNumberTypeColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberTypeColumnOnCallTableOperator), TypeInfoPropertyName = "FilterNumberTypeColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTableColumn), TypeInfoPropertyName = "FilterDateTypeColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterDateTypeColumnOnCallTableOperator), TypeInfoPropertyName = "FilterDateTypeColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTableColumn), TypeInfoPropertyName = "FilterStructuredOutputColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStructuredOutputColumnOnCallTableOperator), TypeInfoPropertyName = "FilterStructuredOutputColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTableColumn), TypeInfoPropertyName = "FilterStringArrayTypeColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterStringArrayTypeColumnOnCallTableOperator), TypeInfoPropertyName = "FilterStringArrayTypeColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTableColumn), TypeInfoPropertyName = "FilterNumberArrayTypeColumnOnCallTableColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FilterNumberArrayTypeColumnOnCallTableOperator), TypeInfoPropertyName = "FilterNumberArrayTypeColumnOnCallTableOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableStringConditionOperator), TypeInfoPropertyName = "EventsTableStringConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableNumberConditionOperator), TypeInfoPropertyName = "EventsTableNumberConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EventsTableBooleanConditionOperator), TypeInfoPropertyName = "EventsTableBooleanConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTableType), TypeInfoPropertyName = "BarInsightFromCallTableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BarInsightFromCallTableGroupBy), TypeInfoPropertyName = "BarInsightFromCallTableGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTableType), TypeInfoPropertyName = "PieInsightFromCallTableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PieInsightFromCallTableGroupBy), TypeInfoPropertyName = "PieInsightFromCallTableGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTableType), TypeInfoPropertyName = "LineInsightFromCallTableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LineInsightFromCallTableGroupBy), TypeInfoPropertyName = "LineInsightFromCallTableGroupBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightFromCallTable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextInsightFromCallTableType), TypeInfoPropertyName = "TextInsightFromCallTableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunFormatPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunFormatPlanFormat), TypeInfoPropertyName = "InsightRunFormatPlanFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Insight))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightType), TypeInfoPropertyName = "InsightType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Insight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>>), TypeInfoPropertyName = "ChatEvalAssistantMessageEvaluation_e6c6355747b60b2e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>), TypeInfoPropertyName = "ChatEvalAssistantMessageEvaluation_3dfc6c3b26777399")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalSystemMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalUserMessageMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalDTOType), TypeInfoPropertyName = "CreateEvalDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Eval))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalType), TypeInfoPropertyName = "EvalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalModelListOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalModelListOptionsProvider), TypeInfoPropertyName = "EvalModelListOptionsProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalUserEditableType), TypeInfoPropertyName = "EvalUserEditableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMockToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageMockRole), TypeInfoPropertyName = "ChatEvalAssistantMessageMockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ChatEvalAssistantMessageMockToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalSystemMessageMockRole), TypeInfoPropertyName = "ChatEvalSystemMessageMockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageMockRole), TypeInfoPropertyName = "ChatEvalToolResponseMessageMockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalUserMessageMockRole), TypeInfoPropertyName = "ChatEvalUserMessageMockRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageEvaluationContinuePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalAssistantMessageEvaluationRole), TypeInfoPropertyName = "ChatEvalAssistantMessageEvaluationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantMessageJudgePlanExact, global::Vapi.AssistantMessageJudgePlanRegex, global::Vapi.AssistantMessageJudgePlanAI>), TypeInfoPropertyName = "OneOfAssistantMessageJudgePlanExactAssistantMessageJudgePlanRegexAssistantMessageJudgePlanAI2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanExact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanRegex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanAI))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModelProvider), TypeInfoPropertyName = "EvalOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalOpenAIModelModel), TypeInfoPropertyName = "EvalOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModelProvider), TypeInfoPropertyName = "EvalAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalAnthropicModelModel), TypeInfoPropertyName = "EvalAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModelProvider), TypeInfoPropertyName = "EvalGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGoogleModelModel), TypeInfoPropertyName = "EvalGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModelProvider), TypeInfoPropertyName = "EvalGroqModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalGroqModelModel), TypeInfoPropertyName = "EvalGroqModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalCustomModelProvider), TypeInfoPropertyName = "EvalCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EvalOpenAIModel, global::Vapi.EvalAnthropicModel, global::Vapi.EvalGoogleModel, global::Vapi.EvalCustomModel>), TypeInfoPropertyName = "OneOfEvalOpenAIModelEvalAnthropicModelEvalGoogleModelEvalCustomModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanAIType), TypeInfoPropertyName = "AssistantMessageJudgePlanAIType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatEvalToolResponseMessageEvaluationRole), TypeInfoPropertyName = "ChatEvalToolResponseMessageEvaluationRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanExactType), TypeInfoPropertyName = "AssistantMessageJudgePlanExactType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageJudgePlanRegexType), TypeInfoPropertyName = "AssistantMessageJudgePlanRegexType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalPaginatedDTOSortOrder), TypeInfoPropertyName = "GetEvalPaginatedDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalPaginatedDTOSortBy), TypeInfoPropertyName = "GetEvalPaginatedDTOSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Eval>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEvalDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateEvalDTOType), TypeInfoPropertyName = "UpdateEvalDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>), TypeInfoPropertyName = "OneOfEvalRunTargetAssistantEvalRunTargetSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEvalRunDTOType), TypeInfoPropertyName = "CreateEvalRunDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunResultStatus), TypeInfoPropertyName = "EvalRunResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalAssistantMessageMock>), TypeInfoPropertyName = "OneOfChatEvalUserMessageMockChatEvalSystemMessageMockChatEvalToolResponseMessageMockChatEvalAssistantMessageMock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunStatus), TypeInfoPropertyName = "EvalRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunEndedReason), TypeInfoPropertyName = "EvalRunEndedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvalRunResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunType), TypeInfoPropertyName = "EvalRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.EvalRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalRunPaginatedDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalRunPaginatedDTOSortOrder), TypeInfoPropertyName = "GetEvalRunPaginatedDTOSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GetEvalRunPaginatedDTOSortBy), TypeInfoPropertyName = "GetEvalRunPaginatedDTOSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetAssistantType), TypeInfoPropertyName = "EvalRunTargetAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalRunTargetSquadType), TypeInfoPropertyName = "EvalRunTargetSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Scorecard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Scorecard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOrgDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOrgDTOChannel), TypeInfoPropertyName = "CreateOrgDTOChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AutoReloadPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InvoicePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Subscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionType), TypeInfoPropertyName = "SubscriptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionStatus), TypeInfoPropertyName = "SubscriptionStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SubscriptionMinutesIncludedResetFrequency), TypeInfoPropertyName = "SubscriptionMinutesIncludedResetFrequency2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Org))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OrgChannel), TypeInfoPropertyName = "OrgChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOrgDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateOrgDTOChannel), TypeInfoPropertyName = "UpdateOrgDTOChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InviteUserDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InviteUserDTORole), TypeInfoPropertyName = "InviteUserDTORole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateUserRoleDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateUserRoleDTORole), TypeInfoPropertyName = "UpdateUserRoleDTORole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JwtResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TokenRestrictions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTokenDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTokenDTOTag), TypeInfoPropertyName = "CreateTokenDTOTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Token))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TokenTag), TypeInfoPropertyName = "TokenTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTokenDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTokenDTOTag), TypeInfoPropertyName = "UpdateTokenDTOTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicCredentialProvider), TypeInfoPropertyName = "AnthropicCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationArtifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAssumeRoleUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredentialProvider), TypeInfoPropertyName = "AnthropicBedrockCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockCredentialRegion), TypeInfoPropertyName = "AnthropicBedrockCredentialRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleCredentialProvider), TypeInfoPropertyName = "AnyscaleCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAICredentialProvider), TypeInfoPropertyName = "AssemblyAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialProvider), TypeInfoPropertyName = "AzureCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialService), TypeInfoPropertyName = "AzureCredentialService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureCredentialRegion), TypeInfoPropertyName = "AzureCredentialRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialProvider), TypeInfoPropertyName = "AzureOpenAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialRegion), TypeInfoPropertyName = "AzureOpenAICredentialRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AzureOpenAICredentialModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureOpenAICredentialModel), TypeInfoPropertyName = "AzureOpenAICredentialModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoSipTrunkCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ByoSipTrunkCredentialProvider), TypeInfoPropertyName = "ByoSipTrunkCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaCredentialProvider), TypeInfoPropertyName = "CartesiaCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasCredentialProvider), TypeInfoPropertyName = "CerebrasCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloudflareCredentialProvider), TypeInfoPropertyName = "CloudflareCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Oauth2AuthenticationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMCredentialProvider), TypeInfoPropertyName = "CustomLLMCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramCredentialProvider), TypeInfoPropertyName = "DeepgramCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraCredentialProvider), TypeInfoPropertyName = "DeepInfraCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekCredentialProvider), TypeInfoPropertyName = "DeepSeekCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsCredentialProvider), TypeInfoPropertyName = "ElevenLabsCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GcpCredentialProvider), TypeInfoPropertyName = "GcpCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaCredentialProvider), TypeInfoPropertyName = "GladiaCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCredentialProvider), TypeInfoPropertyName = "GoHighLevelCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCredentialProvider), TypeInfoPropertyName = "GoogleCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqCredentialProvider), TypeInfoPropertyName = "GroqCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeCredentialProvider), TypeInfoPropertyName = "HumeCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAICredentialProvider), TypeInfoPropertyName = "InflectionAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseCredentialProvider), TypeInfoPropertyName = "LangfuseCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LmntCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LmntCredentialProvider), TypeInfoPropertyName = "LmntCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeCredentialProvider), TypeInfoPropertyName = "MakeCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MistralCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MistralCredentialProvider), TypeInfoPropertyName = "MistralCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicCredentialProvider), TypeInfoPropertyName = "NeuphonicCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAICredentialProvider), TypeInfoPropertyName = "OpenAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterCredentialProvider), TypeInfoPropertyName = "OpenRouterCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAICredentialProvider), TypeInfoPropertyName = "PerplexityAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTCredentialProvider), TypeInfoPropertyName = "PlayHTCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAICredentialProvider), TypeInfoPropertyName = "RimeAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RunpodCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RunpodCredentialProvider), TypeInfoPropertyName = "RunpodCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidCredentialProvider), TypeInfoPropertyName = "WellSaidCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.S3Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.S3CredentialProvider), TypeInfoPropertyName = "S3CredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAICredentialProvider), TypeInfoPropertyName = "SmallestAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxCredentialProvider), TypeInfoPropertyName = "SonioxCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsCredentialProvider), TypeInfoPropertyName = "SpeechmaticsCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseCredentialProvider), TypeInfoPropertyName = "SupabaseCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TavusCredentialProvider), TypeInfoPropertyName = "TavusCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAICredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAICredentialProvider), TypeInfoPropertyName = "TogetherAICredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioCredentialProvider), TypeInfoPropertyName = "TwilioCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonageCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VonageCredentialProvider), TypeInfoPropertyName = "VonageCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialProvider), TypeInfoPropertyName = "WebhookCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan4), TypeInfoPropertyName = "AuthenticationPlan42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WebhookCredentialAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "WebhookCredentialAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfigFormat), TypeInfoPropertyName = "SpkiPemPublicKeyConfigFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanType), TypeInfoPropertyName = "PublicKeyEncryptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm), TypeInfoPropertyName = "PublicKeyEncryptionPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat), TypeInfoPropertyName = "PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialProvider), TypeInfoPropertyName = "CustomCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan5), TypeInfoPropertyName = "AuthenticationPlan52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "CustomCredentialAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomCredentialEncryptionPlanDiscriminatorType), TypeInfoPropertyName = "CustomCredentialEncryptionPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XAiCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XAiCredentialProvider), TypeInfoPropertyName = "XAiCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2ClientCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider), TypeInfoPropertyName = "GoogleCalendarOAuth2ClientCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider), TypeInfoPropertyName = "GoogleCalendarOAuth2AuthorizationCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsOAuth2AuthorizationCredentialProvider), TypeInfoPropertyName = "GoogleSheetsOAuth2AuthorizationCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackOAuth2AuthorizationCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackOAuth2AuthorizationCredentialProvider), TypeInfoPropertyName = "SlackOAuth2AuthorizationCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelMCPCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelMCPCredentialProvider), TypeInfoPropertyName = "GoHighLevelMCPCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldCredentialProvider), TypeInfoPropertyName = "InworldCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EmailCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EmailCredentialProvider), TypeInfoPropertyName = "EmailCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackWebhookCredential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SlackWebhookCredentialProvider), TypeInfoPropertyName = "SlackWebhookCredentialProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCerebrasCredentialDTOProvider), TypeInfoPropertyName = "CreateCerebrasCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCredentialDTOProvider), TypeInfoPropertyName = "CreateGoogleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHumeCredentialDTOProvider), TypeInfoPropertyName = "CreateHumeCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInflectionAICredentialDTOProvider), TypeInfoPropertyName = "CreateInflectionAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMistralCredentialDTOProvider), TypeInfoPropertyName = "CreateMistralCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider), TypeInfoPropertyName = "CreateNeuphonicCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWellSaidCredentialDTOProvider), TypeInfoPropertyName = "CreateWellSaidCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSonioxCredentialDTOProvider), TypeInfoPropertyName = "CreateSonioxCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider), TypeInfoPropertyName = "CreateSpeechmaticsCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOProvider), TypeInfoPropertyName = "CreateCustomCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan6), TypeInfoPropertyName = "AuthenticationPlan62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType), TypeInfoPropertyName = "CreateCustomCredentialDTOEncryptionPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider), TypeInfoPropertyName = "CreateGoHighLevelMCPCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInworldCredentialDTOProvider), TypeInfoPropertyName = "CreateInworldCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEmailCredentialDTOProvider), TypeInfoPropertyName = "CreateEmailCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider), TypeInfoPropertyName = "CreateSlackWebhookCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicBedrockCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnthropicBedrockCredentialDTORegion), TypeInfoPropertyName = "UpdateAnthropicBedrockCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAnyscaleCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAssemblyAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTOService), TypeInfoPropertyName = "UpdateAzureCredentialDTOService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureCredentialDTORegion), TypeInfoPropertyName = "UpdateAzureCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTORegion), TypeInfoPropertyName = "UpdateAzureOpenAICredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateAzureOpenAICredentialDTOModel), TypeInfoPropertyName = "UpdateAzureOpenAICredentialDTOModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateTwilioCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateVonageCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan8), TypeInfoPropertyName = "AuthenticationPlan82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan9), TypeInfoPropertyName = "AuthenticationPlan92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType), TypeInfoPropertyName = "UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType), TypeInfoPropertyName = "UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOType), TypeInfoPropertyName = "CredentialWebhookDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOOperation), TypeInfoPropertyName = "CredentialWebhookDTOOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialWebhookDTOAuthMode), TypeInfoPropertyName = "CredentialWebhookDTOAuthMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialActionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanType), TypeInfoPropertyName = "HMACAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanAlgorithm), TypeInfoPropertyName = "HMACAuthenticationPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding), TypeInfoPropertyName = "HMACAuthenticationPlanSignatureEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlanType), TypeInfoPropertyName = "BearerAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType), TypeInfoPropertyName = "AWSIAMCredentialsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlanType), TypeInfoPropertyName = "AWSStsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolTemplateSetup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolTemplateSetup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolProviderDetailsType), TypeInfoPropertyName = "MakeToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolProviderDetailsType), TypeInfoPropertyName = "GhlToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolProviderDetailsType), TypeInfoPropertyName = "FunctionToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolProviderDetailsType), TypeInfoPropertyName = "GoogleCalendarCreateEventToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolProviderDetailsType), TypeInfoPropertyName = "GoogleSheetsRowAppendToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetailsType), TypeInfoPropertyName = "GoHighLevelCalendarAvailabilityToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetailsType), TypeInfoPropertyName = "GoHighLevelCalendarEventCreateToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolProviderDetailsType), TypeInfoPropertyName = "GoHighLevelContactCreateToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolProviderDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolProviderDetailsType), TypeInfoPropertyName = "GoHighLevelContactGetToolProviderDetailsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolTemplateMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MakeToolProviderDetails, global::Vapi.GhlToolProviderDetails, global::Vapi.FunctionToolProviderDetails, global::Vapi.GoogleCalendarCreateEventToolProviderDetails, global::Vapi.GoogleSheetsRowAppendToolProviderDetails, global::Vapi.GoHighLevelCalendarAvailabilityToolProviderDetails, global::Vapi.GoHighLevelCalendarEventCreateToolProviderDetails, global::Vapi.GoHighLevelContactCreateToolProviderDetails, global::Vapi.GoHighLevelContactGetToolProviderDetails>), TypeInfoPropertyName = "GoHighLevelContactGetToolProviderDetails_e6742b001d758191")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOVisibility), TypeInfoPropertyName = "CreateToolTemplateDTOVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOType), TypeInfoPropertyName = "CreateToolTemplateDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateToolTemplateDTOProvider), TypeInfoPropertyName = "CreateToolTemplateDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Template))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateVisibility), TypeInfoPropertyName = "TemplateVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateType), TypeInfoPropertyName = "TemplateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TemplateProvider), TypeInfoPropertyName = "TemplateProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOVisibility), TypeInfoPropertyName = "UpdateToolTemplateDTOVisibility2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOType), TypeInfoPropertyName = "UpdateToolTemplateDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateToolTemplateDTOProvider), TypeInfoPropertyName = "UpdateToolTemplateDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibrary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibraryGender), TypeInfoPropertyName = "VoiceLibraryGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SyncVoiceLibraryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SyncVoiceLibraryDTOProvider>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SyncVoiceLibraryDTOProvider), TypeInfoPropertyName = "SyncVoiceLibraryDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSesameVoiceDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaPronunciationDictItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaPronunciationDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CartesiaPronunciationDictItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsPronunciationDictionaryPermissionOnResource), TypeInfoPropertyName = "ElevenLabsPronunciationDictionaryPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourcePaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ProviderResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceLibraryVoiceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AddVoiceToProviderDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CloneVoiceDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VariableValueGroupBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TimeRangeStep), TypeInfoPropertyName = "TimeRangeStep2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperationOperation), TypeInfoPropertyName = "AnalyticsOperationOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsOperationColumn), TypeInfoPropertyName = "AnalyticsOperationColumn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQuery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryTable), TypeInfoPropertyName = "AnalyticsQueryTable2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryGroupByItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryGroupByItem), TypeInfoPropertyName = "AnalyticsQueryGroupByItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VariableValueGroupBy>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalyticsQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageWorkflowNodeStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>), TypeInfoPropertyName = "CreateTelnyxPhoneNumberDTO_592013a42be1db26")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageWorkflowNodeStartedType), TypeInfoPropertyName = "ClientMessageWorkflowNodeStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantStartedType), TypeInfoPropertyName = "ClientMessageAssistantStartedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageConversationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageConversationUpdateType), TypeInfoPropertyName = "ClientMessageConversationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageHang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageHangType), TypeInfoPropertyName = "ClientMessageHangType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageMetadataType), TypeInfoPropertyName = "ClientMessageMetadataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageModelOutputType), TypeInfoPropertyName = "ClientMessageModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateType), TypeInfoPropertyName = "ClientMessageSpeechUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateStatus), TypeInfoPropertyName = "ClientMessageSpeechUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSpeechUpdateRole), TypeInfoPropertyName = "ClientMessageSpeechUpdateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptType), TypeInfoPropertyName = "ClientMessageTranscriptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptRole), TypeInfoPropertyName = "ClientMessageTranscriptRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTranscriptTranscriptType), TypeInfoPropertyName = "ClientMessageTranscriptTranscriptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsType), TypeInfoPropertyName = "ClientMessageToolCallsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>>), TypeInfoPropertyName = "GoogleCalendarCreateEventToolWithToolCall_d46a10ae188d5372")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>), TypeInfoPropertyName = "GoogleCalendarCreateEventToolWithToolCall_ff4ae45b448d6c0f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageToolCallsResultType), TypeInfoPropertyName = "ClientMessageToolCallsResultType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTransferUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageTransferUpdateType), TypeInfoPropertyName = "ClientMessageTransferUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageUserInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageUserInterruptedType), TypeInfoPropertyName = "ClientMessageUserInterruptedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageLanguageChangeDetected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageLanguageChangeDetectedType), TypeInfoPropertyName = "ClientMessageLanguageChangeDetectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageVoiceInputType), TypeInfoPropertyName = "ClientMessageVoiceInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantSpeechType), TypeInfoPropertyName = "ClientMessageAssistantSpeechType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantSpeechSource), TypeInfoPropertyName = "ClientMessageAssistantSpeechSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Timing), TypeInfoPropertyName = "Timing2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageAssistantSpeechTimingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatCreatedType), TypeInfoPropertyName = "ClientMessageChatCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageChatDeletedType), TypeInfoPropertyName = "ClientMessageChatDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionCreatedType), TypeInfoPropertyName = "ClientMessageSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionUpdatedType), TypeInfoPropertyName = "ClientMessageSessionUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageSessionDeletedType), TypeInfoPropertyName = "ClientMessageSessionDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeletedType), TypeInfoPropertyName = "ClientMessageCallDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleteFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessageCallDeleteFailedType), TypeInfoPropertyName = "ClientMessageCallDeleteFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ClientMessageWorkflowNodeStarted, global::Vapi.ClientMessageAssistantStarted, global::Vapi.ClientMessageConversationUpdate, global::Vapi.ClientMessageHang, global::Vapi.ClientMessageMetadata, global::Vapi.ClientMessageModelOutput, global::Vapi.ClientMessageSpeechUpdate, global::Vapi.ClientMessageTranscript, global::Vapi.ClientMessageToolCalls, global::Vapi.ClientMessageToolCallsResult, global::Vapi.ClientMessageTransferUpdate, global::Vapi.ClientMessageUserInterrupted, global::Vapi.ClientMessageLanguageChangeDetected, global::Vapi.ClientMessageVoiceInput, global::Vapi.ClientMessageAssistantSpeech, global::Vapi.ClientMessageChatCreated, global::Vapi.ClientMessageChatDeleted, global::Vapi.ClientMessageSessionCreated, global::Vapi.ClientMessageSessionUpdated, global::Vapi.ClientMessageSessionDeleted, global::Vapi.ClientMessageCallDeleted, global::Vapi.ClientMessageCallDeleteFailed>), TypeInfoPropertyName = "ClientMessageCallDeleteFailed_74e414cf350ecd8d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantRequestType), TypeInfoPropertyName = "ServerMessageAssistantRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageConversationUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageConversationUpdateType), TypeInfoPropertyName = "ServerMessageConversationUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReport))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReportType), TypeInfoPropertyName = "ServerMessageEndOfCallReportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageEndOfCallReportEndedReason), TypeInfoPropertyName = "ServerMessageEndOfCallReportEndedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHandoffDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHandoffDestinationRequestType), TypeInfoPropertyName = "ServerMessageHandoffDestinationRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHang))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageHangType), TypeInfoPropertyName = "ServerMessageHangType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageKnowledgeBaseRequestType), TypeInfoPropertyName = "ServerMessageKnowledgeBaseRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageModelOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageModelOutputType), TypeInfoPropertyName = "ServerMessageModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControlType), TypeInfoPropertyName = "ServerMessagePhoneCallControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessagePhoneCallControlRequest), TypeInfoPropertyName = "ServerMessagePhoneCallControlRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateType), TypeInfoPropertyName = "ServerMessageSpeechUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateStatus), TypeInfoPropertyName = "ServerMessageSpeechUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSpeechUpdateRole), TypeInfoPropertyName = "ServerMessageSpeechUpdateRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateType), TypeInfoPropertyName = "ServerMessageStatusUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateStatus), TypeInfoPropertyName = "ServerMessageStatusUpdateStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageStatusUpdateEndedReason), TypeInfoPropertyName = "ServerMessageStatusUpdateEndedReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageToolCallsType), TypeInfoPropertyName = "ServerMessageToolCallsType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferDestinationRequestType), TypeInfoPropertyName = "ServerMessageTransferDestinationRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferUpdate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTransferUpdateType), TypeInfoPropertyName = "ServerMessageTransferUpdateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptType), TypeInfoPropertyName = "ServerMessageTranscriptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptRole), TypeInfoPropertyName = "ServerMessageTranscriptRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageTranscriptTranscriptType), TypeInfoPropertyName = "ServerMessageTranscriptTranscriptType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageUserInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageUserInterruptedType), TypeInfoPropertyName = "ServerMessageUserInterruptedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageLanguageChangeDetected))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageLanguageChangeDetectedType), TypeInfoPropertyName = "ServerMessageLanguageChangeDetectedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceInputType), TypeInfoPropertyName = "ServerMessageVoiceInputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantSpeech))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantSpeechType), TypeInfoPropertyName = "ServerMessageAssistantSpeechType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantSpeechSource), TypeInfoPropertyName = "ServerMessageAssistantSpeechSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Timing2), TypeInfoPropertyName = "Timing22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageVoiceRequestType), TypeInfoPropertyName = "ServerMessageVoiceRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallEndpointingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallEndpointingRequestType), TypeInfoPropertyName = "ServerMessageCallEndpointingRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatCreatedType), TypeInfoPropertyName = "ServerMessageChatCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageChatDeletedType), TypeInfoPropertyName = "ServerMessageChatDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionCreatedType), TypeInfoPropertyName = "ServerMessageSessionCreatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionUpdated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionUpdatedType), TypeInfoPropertyName = "ServerMessageSessionUpdatedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageSessionDeletedType), TypeInfoPropertyName = "ServerMessageSessionDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeletedType), TypeInfoPropertyName = "ServerMessageCallDeletedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleteFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageCallDeleteFailedType), TypeInfoPropertyName = "ServerMessageCallDeleteFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ServerMessageAssistantRequest, global::Vapi.ServerMessageConversationUpdate, global::Vapi.ServerMessageEndOfCallReport, global::Vapi.ServerMessageHandoffDestinationRequest, global::Vapi.ServerMessageHang, global::Vapi.ServerMessageKnowledgeBaseRequest, global::Vapi.ServerMessageModelOutput, global::Vapi.ServerMessagePhoneCallControl, global::Vapi.ServerMessageSpeechUpdate, global::Vapi.ServerMessageStatusUpdate, global::Vapi.ServerMessageToolCalls, global::Vapi.ServerMessageTransferDestinationRequest, global::Vapi.ServerMessageTransferUpdate, global::Vapi.ServerMessageTranscript, global::Vapi.ServerMessageUserInterrupted, global::Vapi.ServerMessageLanguageChangeDetected, global::Vapi.ServerMessageVoiceInput, global::Vapi.ServerMessageAssistantSpeech, global::Vapi.ServerMessageVoiceRequest, global::Vapi.ServerMessageCallEndpointingRequest, global::Vapi.ServerMessageChatCreated, global::Vapi.ServerMessageChatDeleted, global::Vapi.ServerMessageSessionCreated, global::Vapi.ServerMessageSessionUpdated, global::Vapi.ServerMessageSessionDeleted, global::Vapi.ServerMessageCallDeleted, global::Vapi.ServerMessageCallDeleteFailed>), TypeInfoPropertyName = "ServerMessageCallDeleteFailed_e5c1825986de93d7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseAssistantRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseHandoffDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseResponseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseResponseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>), TypeInfoPropertyName = "OneOfToolMessageCompleteToolMessageFailed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseToolCalls))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCallResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseTransferDestinationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseVoiceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponseCallEndpointingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ServerMessageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ServerMessageResponseAssistantRequest, global::Vapi.ServerMessageResponseHandoffDestinationRequest, global::Vapi.ServerMessageResponseKnowledgeBaseRequest, global::Vapi.ServerMessageResponseToolCalls, global::Vapi.ServerMessageResponseTransferDestinationRequest, global::Vapi.ServerMessageResponseVoiceRequest, global::Vapi.ServerMessageResponseCallEndpointingRequest>), TypeInfoPropertyName = "ServerMessageResponseCallEndpointingRequest_30307aeb3c1861ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageAddMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageAddMessageType), TypeInfoPropertyName = "ClientInboundMessageAddMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControlType), TypeInfoPropertyName = "ClientInboundMessageControlType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageControlControl), TypeInfoPropertyName = "ClientInboundMessageControlControl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSayType), TypeInfoPropertyName = "ClientInboundMessageSayType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageEndCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageEndCallType), TypeInfoPropertyName = "ClientInboundMessageEndCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageTransfer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageTransferType), TypeInfoPropertyName = "ClientInboundMessageTransferType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSendTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessageSendTransportMessageType), TypeInfoPropertyName = "ClientInboundMessageSendTransportMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSipTransportMessage, global::Vapi.TwilioTransportMessage>), TypeInfoPropertyName = "OneOfVapiSipTransportMessageTwilioTransportMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioTransportMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ClientInboundMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ClientInboundMessageAddMessage, global::Vapi.ClientInboundMessageControl, global::Vapi.ClientInboundMessageSay, global::Vapi.ClientInboundMessageEndCall, global::Vapi.ClientInboundMessageTransfer, global::Vapi.ClientInboundMessageSendTransportMessage>), TypeInfoPropertyName = "ClientInboundMessageSendTransportMessage_b60833b95aa0836f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCostType), TypeInfoPropertyName = "TransportCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportCostProvider), TypeInfoPropertyName = "TransportCostProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriberCostType), TypeInfoPropertyName = "TranscriberCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ModelCostType), TypeInfoPropertyName = "ModelCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoiceCostType), TypeInfoPropertyName = "VoiceCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCostType), TypeInfoPropertyName = "VapiCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiCostSubType), TypeInfoPropertyName = "VapiCostSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCostType), TypeInfoPropertyName = "AnalysisCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnalysisCostAnalysisType), TypeInfoPropertyName = "AnalysisCostAnalysisType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCostType), TypeInfoPropertyName = "VoicemailDetectionCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionCostProvider), TypeInfoPropertyName = "VoicemailDetectionCostProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseCostType), TypeInfoPropertyName = "KnowledgeBaseCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatCostType), TypeInfoPropertyName = "ChatCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCostType), TypeInfoPropertyName = "SessionCostType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FunctionToolWithToolCallType), TypeInfoPropertyName = "FunctionToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GhlToolWithToolCallType), TypeInfoPropertyName = "GhlToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MakeToolWithToolCallType), TypeInfoPropertyName = "MakeToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallType), TypeInfoPropertyName = "BashToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallSubType), TypeInfoPropertyName = "BashToolWithToolCallSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BashToolWithToolCallName), TypeInfoPropertyName = "BashToolWithToolCallName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallType), TypeInfoPropertyName = "ComputerToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallSubType), TypeInfoPropertyName = "ComputerToolWithToolCallSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComputerToolWithToolCallName), TypeInfoPropertyName = "ComputerToolWithToolCallName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallType), TypeInfoPropertyName = "TextEditorToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallSubType), TypeInfoPropertyName = "TextEditorToolWithToolCallSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextEditorToolWithToolCallName), TypeInfoPropertyName = "TextEditorToolWithToolCallName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleCalendarCreateEventToolWithToolCallType), TypeInfoPropertyName = "GoogleCalendarCreateEventToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleSheetsRowAppendToolWithToolCallType), TypeInfoPropertyName = "GoogleSheetsRowAppendToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarAvailabilityToolWithToolCallType), TypeInfoPropertyName = "GoHighLevelCalendarAvailabilityToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelCalendarEventCreateToolWithToolCallType), TypeInfoPropertyName = "GoHighLevelCalendarEventCreateToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactCreateToolWithToolCallType), TypeInfoPropertyName = "GoHighLevelContactCreateToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolWithToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoHighLevelContactGetToolWithToolCallType), TypeInfoPropertyName = "GoHighLevelContactGetToolWithToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessageTransport), TypeInfoPropertyName = "VapiSipTransportMessageTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSipTransportMessageSipVerb), TypeInfoPropertyName = "VapiSipTransportMessageSipVerb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioTransportMessageTransport), TypeInfoPropertyName = "TwilioTransportMessageTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequest), TypeInfoPropertyName = "PhoneNumberControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerCreateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequest), TypeInfoPropertyName = "PhoneNumberControllerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerUpdateRequestDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequest), TypeInfoPropertyName = "ToolControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequestDiscriminatorType), TypeInfoPropertyName = "ToolControllerCreateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequest), TypeInfoPropertyName = "ToolControllerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateRequestDiscriminatorType), TypeInfoPropertyName = "ToolControllerUpdateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequest), TypeInfoPropertyName = "InsightControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateRequestDiscriminatorType), TypeInfoPropertyName = "InsightControllerCreateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequest), TypeInfoPropertyName = "InsightControllerUpdateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateRequestDiscriminatorType), TypeInfoPropertyName = "InsightControllerUpdateRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequest), TypeInfoPropertyName = "InsightControllerPreviewRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerPreviewRequestDiscriminatorType), TypeInfoPropertyName = "InsightControllerPreviewRequestDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatControllerListChatsSortOrder), TypeInfoPropertyName = "ChatControllerListChatsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChatControllerListChatsSortBy), TypeInfoPropertyName = "ChatControllerListChatsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignControllerFindAllStatus), TypeInfoPropertyName = "CampaignControllerFindAllStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignControllerFindAllSortOrder), TypeInfoPropertyName = "CampaignControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CampaignControllerFindAllSortBy), TypeInfoPropertyName = "CampaignControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionControllerFindAllPaginatedSortOrder), TypeInfoPropertyName = "SessionControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionControllerFindAllPaginatedSortBy), TypeInfoPropertyName = "SessionControllerFindAllPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortOrder), TypeInfoPropertyName = "PhoneNumberControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllPaginatedSortBy), TypeInfoPropertyName = "PhoneNumberControllerFindAllPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder), TypeInfoPropertyName = "StructuredOutputControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortBy), TypeInfoPropertyName = "StructuredOutputControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindAllSortOrder), TypeInfoPropertyName = "InsightControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindAllSortBy), TypeInfoPropertyName = "InsightControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetPaginatedSortOrder), TypeInfoPropertyName = "EvalControllerGetPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetPaginatedSortBy), TypeInfoPropertyName = "EvalControllerGetPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetRunsPaginatedSortOrder), TypeInfoPropertyName = "EvalControllerGetRunsPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EvalControllerGetRunsPaginatedSortBy), TypeInfoPropertyName = "EvalControllerGetRunsPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder), TypeInfoPropertyName = "ScorecardControllerGetPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy), TypeInfoPropertyName = "ScorecardControllerGetPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerCreateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerCreateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerDeleteProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerDeleteProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerUpdateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerUpdateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Squad>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.Call, global::Vapi.CallBatchResponse>), TypeInfoPropertyName = "OneOfCallCallBatchResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.Chat, global::Vapi.CreateChatStreamResponse>), TypeInfoPropertyName = "OneOfChatCreateChatStreamResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>), TypeInfoPropertyName = "OneOfResponseObjectResponseTextDeltaEventResponseTextDoneEventResponseCompletedEventResponseErrorEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponse), TypeInfoPropertyName = "PhoneNumberControllerCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerCreateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.PhoneNumberControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItem), TypeInfoPropertyName = "PhoneNumberControllerFindAllResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindAllResponseItemDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerFindAllResponseItemDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponse), TypeInfoPropertyName = "PhoneNumberControllerFindOneResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerFindOneResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerFindOneResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponse), TypeInfoPropertyName = "PhoneNumberControllerUpdateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerUpdateResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponse), TypeInfoPropertyName = "PhoneNumberControllerRemoveResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PhoneNumberControllerRemoveResponseDiscriminatorProvider), TypeInfoPropertyName = "PhoneNumberControllerRemoveResponseDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponse), TypeInfoPropertyName = "ToolControllerCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateResponseDiscriminatorType), TypeInfoPropertyName = "ToolControllerCreateResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolControllerFindAllResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItem), TypeInfoPropertyName = "ToolControllerFindAllResponseItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItemDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindAllResponseItemDiscriminatorType), TypeInfoPropertyName = "ToolControllerFindAllResponseItemDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponse), TypeInfoPropertyName = "ToolControllerFindOneResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerFindOneResponseDiscriminatorType), TypeInfoPropertyName = "ToolControllerFindOneResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponse), TypeInfoPropertyName = "ToolControllerUpdateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerUpdateResponseDiscriminatorType), TypeInfoPropertyName = "ToolControllerUpdateResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponse), TypeInfoPropertyName = "ToolControllerRemoveResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerRemoveResponseDiscriminatorType), TypeInfoPropertyName = "ToolControllerRemoveResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponse), TypeInfoPropertyName = "InsightControllerCreateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerCreateResponseDiscriminatorType), TypeInfoPropertyName = "InsightControllerCreateResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponse), TypeInfoPropertyName = "InsightControllerUpdateResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerUpdateResponseDiscriminatorType), TypeInfoPropertyName = "InsightControllerUpdateResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponse), TypeInfoPropertyName = "InsightControllerFindOneResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerFindOneResponseDiscriminatorType), TypeInfoPropertyName = "InsightControllerFindOneResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponse), TypeInfoPropertyName = "InsightControllerRemoveResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InsightControllerRemoveResponseDiscriminatorType), TypeInfoPropertyName = "InsightControllerRemoveResponseDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>>), TypeInfoPropertyName = "FallbackSonioxTranscriber_a4fb477f863abd5e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.DeepgramTranscriberRedactionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SpeechmaticsCustomVocabularyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FallbackDeepgramTranscriberRedactionItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f60800cf21404901")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SecurityFilterBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_235a3fd1a6b3743f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>>), TypeInfoPropertyName = "FallbackInworldVoice_81aa5feb007bdf4b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_27f3eef97b8854a6")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantSpeechWordTimestamp>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn, global::Vapi.JSONQueryOnEventsTable>>), TypeInfoPropertyName = "JSONQueryOnEventsTable_571f39493ce546d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>>), TypeInfoPropertyName = "JSONQueryOnCallTableWithStructuredOutputColumn_bcbb0865fc5fd9bd")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>), TypeInfoPropertyName = "FilterStructuredOutputColumnOnCallTable_514172078c50ed6e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Insight>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ChatEvalAssistantMessageMock, global::Vapi.ChatEvalSystemMessageMock, global::Vapi.ChatEvalToolResponseMessageMock, global::Vapi.ChatEvalToolResponseMessageEvaluation, global::Vapi.ChatEvalUserMessageMock, global::Vapi.ChatEvalAssistantMessageEvaluation>>), TypeInfoPropertyName = "ChatEvalAssistantMessageEvaluation_e520bbe5e5889e56")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FunctionToolWithToolCall, global::Vapi.GhlToolWithToolCall, global::Vapi.MakeToolWithToolCall, global::Vapi.BashToolWithToolCall, global::Vapi.ComputerToolWithToolCall, global::Vapi.TextEditorToolWithToolCall, global::Vapi.GoogleCalendarCreateEventToolWithToolCall>>), TypeInfoPropertyName = "GoogleCalendarCreateEventToolWithToolCall_4ee6ec9da9c1f25a")]
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