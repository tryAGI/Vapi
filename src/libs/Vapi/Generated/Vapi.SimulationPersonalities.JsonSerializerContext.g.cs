
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_2b8861a9903db755")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>), TypeInfoPropertyName = "FallbackXaiTranscriber_b66004a379de702e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>), TypeInfoPropertyName = "MicrosoftVoice_4a6e00781b101687")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>), TypeInfoPropertyName = "VapiTranscriber_08a174827361a4d7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>), TypeInfoPropertyName = "VapiModel_0c39ac057634aa9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_337944e3626dd50f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_929e4b5bda008e83")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>), TypeInfoPropertyName = "SessionCreatedHook_2fbeaab55b62844d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_40aab5fbf952716b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_ce07bd1a43aafc35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f4c4631be3aca304")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_125e53ec9b202456")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_406be3ea61580964")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>), TypeInfoPropertyName = "CreateTransferCallToolDTO_c9140097ba8f2e27")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_98afb529f903d70b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>), TypeInfoPropertyName = "CallHookModelResponseTimeout_f9cffc445e112054")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_cde2be735c2dd2b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_8b29c57f08840c03")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>), TypeInfoPropertyName = "FallbackMicrosoftVoice_53f3167bfd8a4206")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>?), TypeInfoPropertyName = "FallbackXaiTranscriber_8e7ba8da847c1e2f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>?), TypeInfoPropertyName = "MicrosoftVoice_31f1d8eb96f7f194")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>?), TypeInfoPropertyName = "VapiTranscriber_4286e861e67fc77e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>?), TypeInfoPropertyName = "WorkflowCustomModel_4fcb5a07f61b51b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>?), TypeInfoPropertyName = "VapiModel_5e260c2c0d56730d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_7113b13dcd4f00d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>?), TypeInfoPropertyName = "SessionCreatedHook_c03dd4becfe9e6f2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_d5c02b16b5ac8354")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>?), TypeInfoPropertyName = "CreateVoicemailToolDTO_555b3a5e46354c56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>?), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_e17e5092dbcded2d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>?), TypeInfoPropertyName = "CreateTransferCallToolDTO_70f865af830d9b9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>?), TypeInfoPropertyName = "CallHookModelResponseTimeout_8be94521dbca1bec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_1a05329dfc971e6d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>?), TypeInfoPropertyName = "FallbackMicrosoftVoice_fc5b25d43e7f09ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_48521cd6623da15b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_27f3eef97b8854a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f60800cf21404901")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_ba4dd0081de0d426")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_235a3fd1a6b3743f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_2d7edea1f9d77cbe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTranscriberPlan))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberProvider), TypeInfoPropertyName = "AssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguage), TypeInfoPropertyName = "AssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberMode), TypeInfoPropertyName = "AssemblyAITranscriberMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssemblyAITranscriberLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguageCode), TypeInfoPropertyName = "AssemblyAITranscriberLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberSpeechModel), TypeInfoPropertyName = "AssemblyAITranscriberSpeechModel2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage), TypeInfoPropertyName = "GladiaTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.GladiaTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage2), TypeInfoPropertyName = "GladiaTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberRegion), TypeInfoPropertyName = "GladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxContextGeneralItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberProvider), TypeInfoPropertyName = "SonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberModel), TypeInfoPropertyName = "SonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage), TypeInfoPropertyName = "SonioxTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SonioxTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage2), TypeInfoPropertyName = "SonioxTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SonioxContextGeneralItem>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberProvider), TypeInfoPropertyName = "XaiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberModel), TypeInfoPropertyName = "XaiTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberLanguage), TypeInfoPropertyName = "XaiTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberProvider), TypeInfoPropertyName = "VapiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberVersion), TypeInfoPropertyName = "VapiTranscriberVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberLanguage), TypeInfoPropertyName = "VapiTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.VapiTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberLanguage2), TypeInfoPropertyName = "VapiTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberTurnTaking), TypeInfoPropertyName = "VapiTranscriberTurnTaking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberProvider), TypeInfoPropertyName = "FallbackAssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage), TypeInfoPropertyName = "FallbackAssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberMode), TypeInfoPropertyName = "FallbackAssemblyAITranscriberMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FallbackAssemblyAITranscriberLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode), TypeInfoPropertyName = "FallbackAssemblyAITranscriberLanguageCode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage), TypeInfoPropertyName = "FallbackGladiaTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FallbackGladiaTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage2), TypeInfoPropertyName = "FallbackGladiaTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberRegion), TypeInfoPropertyName = "FallbackGladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberProvider), TypeInfoPropertyName = "FallbackSonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberModel), TypeInfoPropertyName = "FallbackSonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage), TypeInfoPropertyName = "FallbackSonioxTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.FallbackSonioxTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage2), TypeInfoPropertyName = "FallbackSonioxTranscriberLanguage22")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberProvider), TypeInfoPropertyName = "FallbackXaiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberModel), TypeInfoPropertyName = "FallbackXaiTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberLanguage), TypeInfoPropertyName = "FallbackXaiTranscriberLanguage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailedRole), TypeInfoPropertyName = "ToolMessageFailedRole2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType), TypeInfoPropertyName = "CustomMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>), TypeInfoPropertyName = "OneOfStringCustomMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantType), TypeInfoPropertyName = "TransferDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantTransferMode), TypeInfoPropertyName = "TransferDestinationAssistantTransferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferFallbackPlan))]
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
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>), TypeInfoPropertyName = "OneOfBooleanStartSpeakingPlanSmartEndpointingEnabled2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled), TypeInfoPropertyName = "StartSpeakingPlanSmartEndpointingEnabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>), TypeInfoPropertyName = "OneOfVapiSmartEndpointingPlanLivekitSmartEndpointingPlanCustomEndpointingModelSmartEndpointingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>), TypeInfoPropertyName = "OneOfAssistantCustomEndpointingRuleCustomerCustomEndpointingRuleBothCustomEndpointingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmartDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FourierDenoisingPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackgroundSpeechDenoisingPlan))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterrupted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechTimeout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeout))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLine))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode), TypeInfoPropertyName = "RecordingConsentPlanStayOnLineFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineType), TypeInfoPropertyName = "RecordingConsentPlanStayOnLineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbal))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode), TypeInfoPropertyName = "RecordingConsentPlanVerbalFirstMessageMode2")]
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
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredDataMultiPlan>))]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesConditionType), TypeInfoPropertyName = "MinMessagesConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationConditionType), TypeInfoPropertyName = "MinCallDurationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionType), TypeInfoPropertyName = "EndedReasonConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionOperator), TypeInfoPropertyName = "EndedReasonConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComplianceOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType), TypeInfoPropertyName = "CreateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>), TypeInfoPropertyName = "OneOfWorkflowOpenAIModelWorkflowAnthropicModelWorkflowAnthropicBedrockModelWorkflowGoogleModelWorkflowCustomModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>), TypeInfoPropertyName = "OneOfMinMessagesConditionMinCallDurationConditionEndedReasonCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionType), TypeInfoPropertyName = "NumberComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator), TypeInfoPropertyName = "NumberComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType), TypeInfoPropertyName = "BooleanComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator), TypeInfoPropertyName = "BooleanComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>), TypeInfoPropertyName = "OneOfNumberComparatorScorecardMetricConditionBooleanComparatorScorecardMetricCondition2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOFirstMessageMode), TypeInfoPropertyName = "TransientAssistantDTOFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOVoicemailDetection), TypeInfoPropertyName = "TransientAssistantDTOVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TransientAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOClientMessage), TypeInfoPropertyName = "TransientAssistantDTOClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TransientAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOServerMessage), TypeInfoPropertyName = "TransientAssistantDTOServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOBackgroundSound?, string>), TypeInfoPropertyName = "OneOfTransientAssistantDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOBackgroundSound), TypeInfoPropertyName = "TransientAssistantDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilio))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CompatibleCredentialDTO))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMicrosoftCredentialDTO))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider), TypeInfoPropertyName = "TransientAssistantDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEnding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHook))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesFirstMessageMode), TypeInfoPropertyName = "AssistantOverridesFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesVoicemailDetection), TypeInfoPropertyName = "AssistantOverridesVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesClientMessage), TypeInfoPropertyName = "AssistantOverridesClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesServerMessage), TypeInfoPropertyName = "AssistantOverridesServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>), TypeInfoPropertyName = "OneOfAssistantOverridesBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesBackgroundSound), TypeInfoPropertyName = "AssistantOverridesBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem2), TypeInfoPropertyName = "CredentialsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider), TypeInfoPropertyName = "AssistantOverridesCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTO))]
    internal sealed partial class SimulationPersonalitiesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_2b8861a9903db755")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>), TypeInfoPropertyName = "FallbackXaiTranscriber_b66004a379de702e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>), TypeInfoPropertyName = "MicrosoftVoice_4a6e00781b101687")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>), TypeInfoPropertyName = "VapiTranscriber_08a174827361a4d7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>), TypeInfoPropertyName = "VapiModel_0c39ac057634aa9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_337944e3626dd50f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_929e4b5bda008e83")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>), TypeInfoPropertyName = "SessionCreatedHook_2fbeaab55b62844d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_40aab5fbf952716b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_ce07bd1a43aafc35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f4c4631be3aca304")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_125e53ec9b202456")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_406be3ea61580964")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>), TypeInfoPropertyName = "CreateTransferCallToolDTO_c9140097ba8f2e27")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_98afb529f903d70b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>), TypeInfoPropertyName = "CallHookModelResponseTimeout_f9cffc445e112054")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_cde2be735c2dd2b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_8b29c57f08840c03")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>), TypeInfoPropertyName = "FallbackMicrosoftVoice_53f3167bfd8a4206")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>?), TypeInfoPropertyName = "FallbackXaiTranscriber_8e7ba8da847c1e2f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>?), TypeInfoPropertyName = "MicrosoftVoice_31f1d8eb96f7f194")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>?), TypeInfoPropertyName = "VapiTranscriber_4286e861e67fc77e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>?), TypeInfoPropertyName = "WorkflowCustomModel_4fcb5a07f61b51b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>?), TypeInfoPropertyName = "VapiModel_5e260c2c0d56730d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_7113b13dcd4f00d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>?), TypeInfoPropertyName = "SessionCreatedHook_c03dd4becfe9e6f2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_d5c02b16b5ac8354")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>?), TypeInfoPropertyName = "CreateVoicemailToolDTO_555b3a5e46354c56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>?), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_e17e5092dbcded2d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>?), TypeInfoPropertyName = "CreateTransferCallToolDTO_70f865af830d9b9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>?), TypeInfoPropertyName = "CallHookModelResponseTimeout_8be94521dbca1bec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_1a05329dfc971e6d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>?), TypeInfoPropertyName = "FallbackMicrosoftVoice_fc5b25d43e7f09ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_48521cd6623da15b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_27f3eef97b8854a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f60800cf21404901")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_ba4dd0081de0d426")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_235a3fd1a6b3743f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_2d7edea1f9d77cbe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistantType), TypeInfoPropertyName = "HandoffDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamicType), TypeInfoPropertyName = "HandoffDestinationDynamicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SquadMemberDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>), TypeInfoPropertyName = "OneOfTransferDestinationAssistantHandoffDestinationAssistant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSquadDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquad))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquadType), TypeInfoPropertyName = "HandoffDestinationSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTOType), TypeInfoPropertyName = "CreateHandoffToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>), TypeInfoPropertyName = "OneOfHandoffDestinationAssistantHandoffDestinationDynamicHandoffDestinationSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider), TypeInfoPropertyName = "CreateCustomKnowledgeBaseDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseProvider), TypeInfoPropertyName = "KnowledgeBaseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseModel), TypeInfoPropertyName = "KnowledgeBaseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTOType), TypeInfoPropertyName = "CreateQueryToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType), TypeInfoPropertyName = "CreateGoogleCalendarCreateEventToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType), TypeInfoPropertyName = "CreateGoogleSheetsRowAppendToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType), TypeInfoPropertyName = "CreateGoogleCalendarCheckAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTOType), TypeInfoPropertyName = "CreateSlackSendMessageToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMessages))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadataProtocol), TypeInfoPropertyName = "McpToolMetadataProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTOType), TypeInfoPropertyName = "CreateMcpToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelCalendarAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelCalendarEventCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelContactCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType), TypeInfoPropertyName = "CreateGoHighLevelContactGetToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole), TypeInfoPropertyName = "OpenAIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolRef))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModelProvider), TypeInfoPropertyName = "AnyscaleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType), TypeInfoPropertyName = "AnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelModel), TypeInfoPropertyName = "AnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelReasoningEffort), TypeInfoPropertyName = "AnthropicModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelProvider), TypeInfoPropertyName = "AnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelProvider), TypeInfoPropertyName = "AnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelModel), TypeInfoPropertyName = "AnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.AnthropicBedrockModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelFallbackModel), TypeInfoPropertyName = "AnthropicBedrockModelFallbackModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelReasoningEffort), TypeInfoPropertyName = "AnthropicBedrockModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelModel), TypeInfoPropertyName = "CerebrasModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelProvider), TypeInfoPropertyName = "CerebrasModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelProvider), TypeInfoPropertyName = "CustomLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelMetadataSendMode), TypeInfoPropertyName = "CustomLLMModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModelProvider), TypeInfoPropertyName = "DeepInfraModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelModel), TypeInfoPropertyName = "DeepSeekModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelProvider), TypeInfoPropertyName = "DeepSeekModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName), TypeInfoPropertyName = "GeminiMultimodalLivePrebuiltVoiceConfigVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveVoiceConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLiveSpeechConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleRealtimeConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelModel), TypeInfoPropertyName = "GoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelProvider), TypeInfoPropertyName = "GoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelModel), TypeInfoPropertyName = "GroqModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelProvider), TypeInfoPropertyName = "GroqModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelModel), TypeInfoPropertyName = "InflectionAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelProvider), TypeInfoPropertyName = "InflectionAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelProvider), TypeInfoPropertyName = "MinimaxLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelModel), TypeInfoPropertyName = "MinimaxLLMModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAISpeaker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAISpeakerPersonalityPack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAISpeakerPersonalityPack), TypeInfoPropertyName = "OpenAISpeakerPersonalityPack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerSkill))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasoner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerProvider), TypeInfoPropertyName = "OpenAIReasonerProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerModel), TypeInfoPropertyName = "OpenAIReasonerModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerReasoningEffort), TypeInfoPropertyName = "OpenAIReasonerReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIReasonerSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelProvider), TypeInfoPropertyName = "OpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelModel), TypeInfoPropertyName = "OpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelFallbackModel), TypeInfoPropertyName = "OpenAIModelFallbackModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode), TypeInfoPropertyName = "OpenAIModelToolStrictCompatibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelPromptCacheRetention), TypeInfoPropertyName = "OpenAIModelPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelServiceTier), TypeInfoPropertyName = "OpenAIModelServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelReasoningEffort), TypeInfoPropertyName = "OpenAIModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModelProvider), TypeInfoPropertyName = "OpenRouterModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModelProvider), TypeInfoPropertyName = "PerplexityAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModelProvider), TypeInfoPropertyName = "TogetherAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider), TypeInfoPropertyName = "WorkflowOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel), TypeInfoPropertyName = "WorkflowOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort), TypeInfoPropertyName = "WorkflowOpenAIModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider), TypeInfoPropertyName = "WorkflowAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel), TypeInfoPropertyName = "WorkflowAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider), TypeInfoPropertyName = "WorkflowGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel), TypeInfoPropertyName = "WorkflowGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider), TypeInfoPropertyName = "WorkflowCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode), TypeInfoPropertyName = "WorkflowCustomModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GlobalNodePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNodeType), TypeInfoPropertyName = "ConversationNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNodeType), TypeInfoPropertyName = "ToolNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VoicemailDetectionBackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider), TypeInfoPropertyName = "GoogleVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanType), TypeInfoPropertyName = "GoogleVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider), TypeInfoPropertyName = "OpenAIVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanType), TypeInfoPropertyName = "OpenAIVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider), TypeInfoPropertyName = "TwilioVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType), TypeInfoPropertyName = "TwilioVoicemailDetectionPlanVoicemailDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanProvider), TypeInfoPropertyName = "VapiVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanType), TypeInfoPropertyName = "VapiVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookActionType), TypeInfoPropertyName = "SayHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEndingOn), TypeInfoPropertyName = "CallHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>), TypeInfoPropertyName = "OneOfToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn), TypeInfoPropertyName = "CallHookAssistantSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>), TypeInfoPropertyName = "OneOfSayHookActionToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn), TypeInfoPropertyName = "CallHookCustomerSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookActionType), TypeInfoPropertyName = "ToolCallHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerSpeechTimeoutOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode), TypeInfoPropertyName = "CustomerSpeechTimeoutOptionsTriggerResetMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeoutOn), TypeInfoPropertyName = "CallHookModelResponseTimeoutOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeConditionType), TypeInfoPropertyName = "AIEdgeConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Edge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>), TypeInfoPropertyName = "OneOfConversationNodeToolNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>), TypeInfoPropertyName = "OneOfWorkflowUserEditableBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableBackgroundSound), TypeInfoPropertyName = "WorkflowUserEditableBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CredentialsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem3), TypeInfoPropertyName = "CredentialsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider), TypeInfoPropertyName = "WorkflowUserEditableCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableVoicemailDetection), TypeInfoPropertyName = "WorkflowUserEditableVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelVersion), TypeInfoPropertyName = "VapiModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelProvider), TypeInfoPropertyName = "VapiModelProvider2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoice))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyOf<global::Vapi.OpenAIVoiceVoiceId?, string>), TypeInfoPropertyName = "AnyOfOpenAIVoiceVoiceIdString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPronunciationDictionaryLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider), TypeInfoPropertyName = "VapiPronunciationDictionaryLocatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceProvider), TypeInfoPropertyName = "VapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiVoiceVersion2?, double?>), TypeInfoPropertyName = "OneOfVapiVoiceVersion2Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceVersion2), TypeInfoPropertyName = "VapiVoiceVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceLanguage), TypeInfoPropertyName = "VapiVoiceLanguage2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceProvider), TypeInfoPropertyName = "FallbackWellSaidVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceModel), TypeInfoPropertyName = "FallbackWellSaidVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceProvider), TypeInfoPropertyName = "XaiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceVoiceId), TypeInfoPropertyName = "XaiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceLanguage), TypeInfoPropertyName = "XaiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceProvider), TypeInfoPropertyName = "MicrosoftVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceVoiceId), TypeInfoPropertyName = "MicrosoftVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceStyle), TypeInfoPropertyName = "MicrosoftVoiceStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceRole), TypeInfoPropertyName = "MicrosoftVoiceRole2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>), TypeInfoPropertyName = "AnyOfFallbackOpenAIVoiceVoiceIdString2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceProvider), TypeInfoPropertyName = "FallbackVapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackVapiVoiceVersion2?, double?>), TypeInfoPropertyName = "OneOfFallbackVapiVoiceVersion2Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceVersion2), TypeInfoPropertyName = "FallbackVapiVoiceVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceLanguage), TypeInfoPropertyName = "FallbackVapiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceProvider), TypeInfoPropertyName = "FallbackInworldVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceVoiceId), TypeInfoPropertyName = "FallbackInworldVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceModel), TypeInfoPropertyName = "FallbackInworldVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceLanguageCode), TypeInfoPropertyName = "FallbackInworldVoiceLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceProvider), TypeInfoPropertyName = "FallbackXaiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceVoiceId), TypeInfoPropertyName = "FallbackXaiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceLanguage), TypeInfoPropertyName = "FallbackXaiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceProvider), TypeInfoPropertyName = "FallbackMicrosoftVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId), TypeInfoPropertyName = "FallbackMicrosoftVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceStyle), TypeInfoPropertyName = "FallbackMicrosoftVoiceStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceRole), TypeInfoPropertyName = "FallbackMicrosoftVoiceRole2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl), TypeInfoPropertyName = "CreateElevenLabsCredentialDTOApiUrl2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHookOn), TypeInfoPropertyName = "SessionCreatedHookOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem4), TypeInfoPropertyName = "CredentialsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem5), TypeInfoPropertyName = "CredentialsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem6), TypeInfoPropertyName = "CredentialsItem62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem7), TypeInfoPropertyName = "CredentialsItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem8), TypeInfoPropertyName = "CredentialsItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem9), TypeInfoPropertyName = "CredentialsItem92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem10), TypeInfoPropertyName = "CredentialsItem102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem11), TypeInfoPropertyName = "CredentialsItem112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem12), TypeInfoPropertyName = "CredentialsItem122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem13), TypeInfoPropertyName = "CredentialsItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TranscriptWordConfidence))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UserMessageMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TranscriptWordConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UserMessageConfidenceSource), TypeInfoPropertyName = "UserMessageConfidenceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessageRole), TypeInfoPropertyName = "DeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageRole), TypeInfoPropertyName = "AssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageRole), TypeInfoPropertyName = "ToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CodeToolEnvironmentVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.JsonSchema>), TypeInfoPropertyName = "OneOfStringJsonSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOType), TypeInfoPropertyName = "CreateApiRequestToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOMethod), TypeInfoPropertyName = "CreateApiRequestToolDTOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTOType), TypeInfoPropertyName = "CreateCodeToolDTOType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePersonalityDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Personality))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdatePersonalityDTO))]
    internal sealed partial class SimulationPersonalitiesSourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_2b8861a9903db755")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>), TypeInfoPropertyName = "FallbackXaiTranscriber_b66004a379de702e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>), TypeInfoPropertyName = "MicrosoftVoice_4a6e00781b101687")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>), TypeInfoPropertyName = "VapiTranscriber_08a174827361a4d7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>), TypeInfoPropertyName = "VapiModel_0c39ac057634aa9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_337944e3626dd50f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_929e4b5bda008e83")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>), TypeInfoPropertyName = "SessionCreatedHook_2fbeaab55b62844d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_40aab5fbf952716b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_ce07bd1a43aafc35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f4c4631be3aca304")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_125e53ec9b202456")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_406be3ea61580964")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>), TypeInfoPropertyName = "CreateTransferCallToolDTO_c9140097ba8f2e27")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_98afb529f903d70b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>), TypeInfoPropertyName = "CallHookModelResponseTimeout_f9cffc445e112054")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_cde2be735c2dd2b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_8b29c57f08840c03")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>), TypeInfoPropertyName = "FallbackMicrosoftVoice_53f3167bfd8a4206")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>?), TypeInfoPropertyName = "FallbackXaiTranscriber_8e7ba8da847c1e2f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>?), TypeInfoPropertyName = "MicrosoftVoice_31f1d8eb96f7f194")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>?), TypeInfoPropertyName = "VapiTranscriber_4286e861e67fc77e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>?), TypeInfoPropertyName = "WorkflowCustomModel_4fcb5a07f61b51b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>?), TypeInfoPropertyName = "VapiModel_5e260c2c0d56730d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_7113b13dcd4f00d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>?), TypeInfoPropertyName = "SessionCreatedHook_c03dd4becfe9e6f2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_d5c02b16b5ac8354")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>?), TypeInfoPropertyName = "CreateVoicemailToolDTO_555b3a5e46354c56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>?), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_e17e5092dbcded2d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>?), TypeInfoPropertyName = "CreateTransferCallToolDTO_70f865af830d9b9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>?), TypeInfoPropertyName = "CallHookModelResponseTimeout_8be94521dbca1bec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_1a05329dfc971e6d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>?), TypeInfoPropertyName = "FallbackMicrosoftVoice_fc5b25d43e7f09ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_48521cd6623da15b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_27f3eef97b8854a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f60800cf21404901")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_ba4dd0081de0d426")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_235a3fd1a6b3743f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_2d7edea1f9d77cbe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityInUseConflictResponseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityInUseConflictResponseDTOError), TypeInfoPropertyName = "PersonalityInUseConflictResponseDTOError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Oauth2AuthenticationSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.S3CompatibleBucketPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan4), TypeInfoPropertyName = "AuthenticationPlan42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfigFormat), TypeInfoPropertyName = "SpkiPemPublicKeyConfigFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanType), TypeInfoPropertyName = "PublicKeyEncryptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm), TypeInfoPropertyName = "PublicKeyEncryptionPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat), TypeInfoPropertyName = "PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan5), TypeInfoPropertyName = "AuthenticationPlan52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCerebrasCredentialDTOProvider), TypeInfoPropertyName = "CreateCerebrasCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCredentialDTOProvider), TypeInfoPropertyName = "CreateGoogleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHumeCredentialDTOProvider), TypeInfoPropertyName = "CreateHumeCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInflectionAICredentialDTOProvider), TypeInfoPropertyName = "CreateInflectionAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider), TypeInfoPropertyName = "CreateMicrosoftCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMistralCredentialDTOProvider), TypeInfoPropertyName = "CreateMistralCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider), TypeInfoPropertyName = "CreateNeuphonicCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWellSaidCredentialDTOProvider), TypeInfoPropertyName = "CreateWellSaidCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider), TypeInfoPropertyName = "CreateS3CompatibleCredentialDTOProvider2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan8), TypeInfoPropertyName = "AuthenticationPlan82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan9), TypeInfoPropertyName = "AuthenticationPlan92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanType), TypeInfoPropertyName = "HMACAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanAlgorithm), TypeInfoPropertyName = "HMACAuthenticationPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding), TypeInfoPropertyName = "HMACAuthenticationPlanSignatureEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlanType), TypeInfoPropertyName = "BearerAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType), TypeInfoPropertyName = "AWSIAMCredentialsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlanType), TypeInfoPropertyName = "AWSStsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequest), TypeInfoPropertyName = "ToolControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityControllerFindAllSortOrder), TypeInfoPropertyName = "PersonalityControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityControllerFindAllSortBy), TypeInfoPropertyName = "PersonalityControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Personality>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberProvider?), TypeInfoPropertyName = "NullableAssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguage?), TypeInfoPropertyName = "NullableAssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberMode?), TypeInfoPropertyName = "NullableAssemblyAITranscriberMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberLanguageCode?), TypeInfoPropertyName = "NullableAssemblyAITranscriberLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssemblyAITranscriberSpeechModel?), TypeInfoPropertyName = "NullableAssemblyAITranscriberSpeechModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberProvider?), TypeInfoPropertyName = "NullableAzureSpeechTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberLanguage?), TypeInfoPropertyName = "NullableAzureSpeechTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy?), TypeInfoPropertyName = "NullableAzureSpeechTranscriberSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberProvider?), TypeInfoPropertyName = "NullableCartesiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberModel?), TypeInfoPropertyName = "NullableCartesiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaTranscriberLanguage?), TypeInfoPropertyName = "NullableCartesiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomTranscriberProvider?), TypeInfoPropertyName = "NullableCustomTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberProvider?), TypeInfoPropertyName = "NullableDeepgramTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.DeepgramTranscriberModel?, string>?), TypeInfoPropertyName = "NullableOneOfDeepgramTranscriberModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberModel?), TypeInfoPropertyName = "NullableDeepgramTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberLanguage?), TypeInfoPropertyName = "NullableDeepgramTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramTranscriberRedactionItem?), TypeInfoPropertyName = "NullableDeepgramTranscriberRedactionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberProvider?), TypeInfoPropertyName = "NullableElevenLabsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberModel?), TypeInfoPropertyName = "NullableElevenLabsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsTranscriberLanguage?), TypeInfoPropertyName = "NullableElevenLabsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>?), TypeInfoPropertyName = "NullableOneOfStringGladiaVocabularyItemDTO2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberProvider?), TypeInfoPropertyName = "NullableGladiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberModel?), TypeInfoPropertyName = "NullableGladiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguageBehaviour?), TypeInfoPropertyName = "NullableGladiaTranscriberLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage?), TypeInfoPropertyName = "NullableGladiaTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberLanguage2?), TypeInfoPropertyName = "NullableGladiaTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GladiaTranscriberRegion?), TypeInfoPropertyName = "NullableGladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberProvider?), TypeInfoPropertyName = "NullableSonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberModel?), TypeInfoPropertyName = "NullableSonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage?), TypeInfoPropertyName = "NullableSonioxTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SonioxTranscriberLanguage2?), TypeInfoPropertyName = "NullableSonioxTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberProvider?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberModel?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberLanguage?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberOperatingPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberRegion?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle?), TypeInfoPropertyName = "NullableSpeechmaticsTranscriberNumeralStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberProvider?), TypeInfoPropertyName = "NullableTalkscriberTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberModel?), TypeInfoPropertyName = "NullableTalkscriberTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TalkscriberTranscriberLanguage?), TypeInfoPropertyName = "NullableTalkscriberTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberProvider?), TypeInfoPropertyName = "NullableGoogleTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberModel?), TypeInfoPropertyName = "NullableGoogleTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleTranscriberLanguage?), TypeInfoPropertyName = "NullableGoogleTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberProvider?), TypeInfoPropertyName = "NullableOpenAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberModel?), TypeInfoPropertyName = "NullableOpenAITranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAITranscriberLanguage?), TypeInfoPropertyName = "NullableOpenAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberProvider?), TypeInfoPropertyName = "NullableXaiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberModel?), TypeInfoPropertyName = "NullableXaiTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiTranscriberLanguage?), TypeInfoPropertyName = "NullableXaiTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberProvider?), TypeInfoPropertyName = "NullableVapiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberVersion?), TypeInfoPropertyName = "NullableVapiTranscriberVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberLanguage?), TypeInfoPropertyName = "NullableVapiTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberLanguage2?), TypeInfoPropertyName = "NullableVapiTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiTranscriberTurnTaking?), TypeInfoPropertyName = "NullableVapiTranscriberTurnTaking2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberProvider?), TypeInfoPropertyName = "NullableFallbackAssemblyAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackAssemblyAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberMode?), TypeInfoPropertyName = "NullableFallbackAssemblyAITranscriberMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode?), TypeInfoPropertyName = "NullableFallbackAssemblyAITranscriberLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel?), TypeInfoPropertyName = "NullableFallbackAssemblyAITranscriberSpeechModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackAzureSpeechTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackAzureSpeechTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy?), TypeInfoPropertyName = "NullableFallbackAzureSpeechTranscriberSegmentationStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackCartesiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberModel?), TypeInfoPropertyName = "NullableFallbackCartesiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackCartesiaTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackCustomTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackDeepgramTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackDeepgramTranscriberModel?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackDeepgramTranscriberModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberModel?), TypeInfoPropertyName = "NullableFallbackDeepgramTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackDeepgramTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem?), TypeInfoPropertyName = "NullableFallbackDeepgramTranscriberRedactionItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackElevenLabsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberModel?), TypeInfoPropertyName = "NullableFallbackElevenLabsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackElevenLabsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberModel?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberLanguageBehaviour2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberLanguage2?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGladiaTranscriberRegion?), TypeInfoPropertyName = "NullableFallbackGladiaTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackSonioxTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberModel?), TypeInfoPropertyName = "NullableFallbackSonioxTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackSonioxTranscriberLanguage2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSonioxTranscriberLanguage2?), TypeInfoPropertyName = "NullableFallbackSonioxTranscriberLanguage22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberOperatingPoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle?), TypeInfoPropertyName = "NullableFallbackSpeechmaticsTranscriberNumeralStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackTalkscriberTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberModel?), TypeInfoPropertyName = "NullableFallbackTalkscriberTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackTalkscriberTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackGoogleTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberModel?), TypeInfoPropertyName = "NullableFallbackGoogleTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackGoogleTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackGoogleTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberProvider?), TypeInfoPropertyName = "NullableFallbackOpenAITranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberModel?), TypeInfoPropertyName = "NullableFallbackOpenAITranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAITranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackOpenAITranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberProvider?), TypeInfoPropertyName = "NullableFallbackXaiTranscriberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberModel?), TypeInfoPropertyName = "NullableFallbackXaiTranscriberModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiTranscriberLanguage?), TypeInfoPropertyName = "NullableFallbackXaiTranscriberLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LangfuseObservabilityPlanProvider?), TypeInfoPropertyName = "NullableLangfuseObservabilityPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentType?), TypeInfoPropertyName = "NullableTextContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TextContentLanguage?), TypeInfoPropertyName = "NullableTextContentLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConditionOperator?), TypeInfoPropertyName = "NullableConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageStartType?), TypeInfoPropertyName = "NullableToolMessageStartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteType?), TypeInfoPropertyName = "NullableToolMessageCompleteType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageCompleteRole?), TypeInfoPropertyName = "NullableToolMessageCompleteRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailedType?), TypeInfoPropertyName = "NullableToolMessageFailedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageFailedRole?), TypeInfoPropertyName = "NullableToolMessageFailedRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageDelayedType?), TypeInfoPropertyName = "NullableToolMessageDelayedType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageTargetRole?), TypeInfoPropertyName = "NullableMessageTargetRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexConditionType?), TypeInfoPropertyName = "NullableRegexConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LiquidConditionType?), TypeInfoPropertyName = "NullableLiquidConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionType?), TypeInfoPropertyName = "NullableGroupConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroupConditionOperator?), TypeInfoPropertyName = "NullableGroupConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>?), TypeInfoPropertyName = "NullableOneOfRegexConditionLiquidConditionGroupCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>?), TypeInfoPropertyName = "NullableOneOfToolMessageStartToolMessageCompleteToolMessageFailedToolMessageDelayed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDtmfToolDTOType?), TypeInfoPropertyName = "NullableCreateDtmfToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEndCallToolDTOType?), TypeInfoPropertyName = "NullableCreateEndCallToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVoicemailToolDTOType?), TypeInfoPropertyName = "NullableCreateVoicemailToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType?), TypeInfoPropertyName = "NullableJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat?), TypeInfoPropertyName = "NullableJsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, double?, bool?, object, byte[]>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIFunctionParametersType?), TypeInfoPropertyName = "NullableOpenAIFunctionParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateFunctionToolDTOType?), TypeInfoPropertyName = "NullableCreateFunctionToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomMessageType?), TypeInfoPropertyName = "NullableCustomMessageType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.CustomMessage>?), TypeInfoPropertyName = "NullableOneOfStringCustomMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantType?), TypeInfoPropertyName = "NullableTransferDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationAssistantTransferMode?), TypeInfoPropertyName = "NullableTransferDestinationAssistantTransferMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexOptionType?), TypeInfoPropertyName = "NullableRegexOptionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantCustomEndpointingRuleType?), TypeInfoPropertyName = "NullableAssistantCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerCustomEndpointingRuleType?), TypeInfoPropertyName = "NullableCustomerCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BothCustomEndpointingRuleType?), TypeInfoPropertyName = "NullableBothCustomEndpointingRuleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiSmartEndpointingPlanProvider?), TypeInfoPropertyName = "NullableVapiSmartEndpointingPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LivekitSmartEndpointingPlanProvider?), TypeInfoPropertyName = "NullableLivekitSmartEndpointingPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider?), TypeInfoPropertyName = "NullableCustomEndpointingModelSmartEndpointingPlanProvider2")]
    #pragma warning disable CS0618 // This registration names a deprecated API model.
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>?), TypeInfoPropertyName = "NullableOneOfBooleanStartSpeakingPlanSmartEndpointingEnabled2")]
    #pragma warning restore CS0618
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?), TypeInfoPropertyName = "NullableStartSpeakingPlanSmartEndpointingEnabled2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>?), TypeInfoPropertyName = "NullableOneOfVapiSmartEndpointingPlanLivekitSmartEndpointingPlanCustomEndpointingModelSmartEndpointingPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>?), TypeInfoPropertyName = "NullableOneOfAssistantCustomEndpointingRuleCustomerCustomEndpointingRuleBothCustomEndpointingRule2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferPlanMode?), TypeInfoPropertyName = "NullableTransferPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>?), TypeInfoPropertyName = "NullableOneOfContextEngineeringPlanLastNMessagesContextEngineeringPlanNoneContextEngineeringPlanAll2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationNumberType?), TypeInfoPropertyName = "NullableTransferDestinationNumberType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransferDestinationSipType?), TypeInfoPropertyName = "NullableTransferDestinationSipType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTransferCallToolDTOType?), TypeInfoPropertyName = "NullableCreateTransferCallToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>?), TypeInfoPropertyName = "NullableOneOfTransferDestinationAssistantTransferDestinationNumberTransferDestinationSip2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?), TypeInfoPropertyName = "NullableContextEngineeringPlanLastNMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanNoneType?), TypeInfoPropertyName = "NullableContextEngineeringPlanNoneType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanAllType?), TypeInfoPropertyName = "NullableContextEngineeringPlanAllType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType?), TypeInfoPropertyName = "NullableContextEngineeringPlanUserAndAssistantMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType?), TypeInfoPropertyName = "NullableContextEngineeringPlanPreviousAssistantMessagesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode?), TypeInfoPropertyName = "NullableRecordingConsentPlanStayOnLineFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanStayOnLineType?), TypeInfoPropertyName = "NullableRecordingConsentPlanStayOnLineType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode?), TypeInfoPropertyName = "NullableRecordingConsentPlanVerbalFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlanVerbalType?), TypeInfoPropertyName = "NullableRecordingConsentPlanVerbalType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SecurityFilterPlanMode?), TypeInfoPropertyName = "NullableSecurityFilterPlanMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RecordingConsentPlan?), TypeInfoPropertyName = "NullableRecordingConsentPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType?), TypeInfoPropertyName = "NullableCompliancePlanRecordingConsentPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SuccessEvaluationPlanRubric?), TypeInfoPropertyName = "NullableSuccessEvaluationPlanRubric2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesConditionType?), TypeInfoPropertyName = "NullableMinMessagesConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationConditionType?), TypeInfoPropertyName = "NullableMinCallDurationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionType?), TypeInfoPropertyName = "NullableEndedReasonConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionOperator?), TypeInfoPropertyName = "NullableEndedReasonConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType?), TypeInfoPropertyName = "NullableCreateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>?), TypeInfoPropertyName = "NullableOneOfMinMessagesConditionMinCallDurationConditionEndedReasonCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?), TypeInfoPropertyName = "NullableNumberComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?), TypeInfoPropertyName = "NullableNumberComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?), TypeInfoPropertyName = "NullableBooleanComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?), TypeInfoPropertyName = "NullableBooleanComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>?), TypeInfoPropertyName = "NullableOneOfNumberComparatorScorecardMetricConditionBooleanComparatorScorecardMetricCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ArtifactPlanRecordingFormat?), TypeInfoPropertyName = "NullableArtifactPlanRecordingFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KeypadInputPlanDelimiters?), TypeInfoPropertyName = "NullableKeypadInputPlanDelimiters2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOFirstMessageMode?), TypeInfoPropertyName = "NullableTransientAssistantDTOFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOVoicemailDetection?), TypeInfoPropertyName = "NullableTransientAssistantDTOVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOClientMessage?), TypeInfoPropertyName = "NullableTransientAssistantDTOClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOServerMessage?), TypeInfoPropertyName = "NullableTransientAssistantDTOServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOBackgroundSound?, string>?), TypeInfoPropertyName = "NullableOneOfTransientAssistantDTOBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOBackgroundSound?), TypeInfoPropertyName = "NullableTransientAssistantDTOBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem?), TypeInfoPropertyName = "NullableCredentialsItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider?), TypeInfoPropertyName = "NullableTransientAssistantDTOCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesFirstMessageMode?), TypeInfoPropertyName = "NullableAssistantOverridesFirstMessageMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesVoicemailDetection?), TypeInfoPropertyName = "NullableAssistantOverridesVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesClientMessage?), TypeInfoPropertyName = "NullableAssistantOverridesClientMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesServerMessage?), TypeInfoPropertyName = "NullableAssistantOverridesServerMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesBackgroundSound?, string>?), TypeInfoPropertyName = "NullableOneOfAssistantOverridesBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesBackgroundSound?), TypeInfoPropertyName = "NullableAssistantOverridesBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem2?), TypeInfoPropertyName = "NullableCredentialsItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider?), TypeInfoPropertyName = "NullableAssistantOverridesCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationAssistantType?), TypeInfoPropertyName = "NullableHandoffDestinationAssistantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationDynamicType?), TypeInfoPropertyName = "NullableHandoffDestinationDynamicType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>?), TypeInfoPropertyName = "NullableOneOfTransferDestinationAssistantHandoffDestinationAssistant2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HandoffDestinationSquadType?), TypeInfoPropertyName = "NullableHandoffDestinationSquadType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHandoffToolDTOType?), TypeInfoPropertyName = "NullableCreateHandoffToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>?), TypeInfoPropertyName = "NullableOneOfHandoffDestinationAssistantHandoffDestinationDynamicHandoffDestinationSquad2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider?), TypeInfoPropertyName = "NullableCreateCustomKnowledgeBaseDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseProvider?), TypeInfoPropertyName = "NullableKnowledgeBaseProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.KnowledgeBaseModel?), TypeInfoPropertyName = "NullableKnowledgeBaseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateQueryToolDTOType?), TypeInfoPropertyName = "NullableCreateQueryToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType?), TypeInfoPropertyName = "NullableCreateGoogleCalendarCreateEventToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType?), TypeInfoPropertyName = "NullableCreateGoogleSheetsRowAppendToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType?), TypeInfoPropertyName = "NullableCreateGoogleCalendarCheckAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackSendMessageToolDTOType?), TypeInfoPropertyName = "NullableCreateSlackSendMessageToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.McpToolMetadataProtocol?), TypeInfoPropertyName = "NullableMcpToolMetadataProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMcpToolDTOType?), TypeInfoPropertyName = "NullableCreateMcpToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType?), TypeInfoPropertyName = "NullableCreateGoHighLevelCalendarAvailabilityToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType?), TypeInfoPropertyName = "NullableCreateGoHighLevelCalendarEventCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType?), TypeInfoPropertyName = "NullableCreateGoHighLevelContactCreateToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType?), TypeInfoPropertyName = "NullableCreateGoHighLevelContactGetToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole?), TypeInfoPropertyName = "NullableOpenAIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyscaleModelProvider?), TypeInfoPropertyName = "NullableAnyscaleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType?), TypeInfoPropertyName = "NullableAnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelModel?), TypeInfoPropertyName = "NullableAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelReasoningEffort?), TypeInfoPropertyName = "NullableAnthropicModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicModelProvider?), TypeInfoPropertyName = "NullableAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelProvider?), TypeInfoPropertyName = "NullableAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelModel?), TypeInfoPropertyName = "NullableAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelFallbackModel?), TypeInfoPropertyName = "NullableAnthropicBedrockModelFallbackModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicBedrockModelReasoningEffort?), TypeInfoPropertyName = "NullableAnthropicBedrockModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelModel?), TypeInfoPropertyName = "NullableCerebrasModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CerebrasModelProvider?), TypeInfoPropertyName = "NullableCerebrasModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelProvider?), TypeInfoPropertyName = "NullableCustomLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomLLMModelMetadataSendMode?), TypeInfoPropertyName = "NullableCustomLLMModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepInfraModelProvider?), TypeInfoPropertyName = "NullableDeepInfraModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelModel?), TypeInfoPropertyName = "NullableDeepSeekModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepSeekModelProvider?), TypeInfoPropertyName = "NullableDeepSeekModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName?), TypeInfoPropertyName = "NullableGeminiMultimodalLivePrebuiltVoiceConfigVoiceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelModel?), TypeInfoPropertyName = "NullableGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleModelProvider?), TypeInfoPropertyName = "NullableGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelModel?), TypeInfoPropertyName = "NullableGroqModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GroqModelProvider?), TypeInfoPropertyName = "NullableGroqModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelModel?), TypeInfoPropertyName = "NullableInflectionAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InflectionAIModelProvider?), TypeInfoPropertyName = "NullableInflectionAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelProvider?), TypeInfoPropertyName = "NullableMinimaxLLMModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxLLMModelModel?), TypeInfoPropertyName = "NullableMinimaxLLMModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAISpeakerPersonalityPack?), TypeInfoPropertyName = "NullableOpenAISpeakerPersonalityPack2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerProvider?), TypeInfoPropertyName = "NullableOpenAIReasonerProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerModel?), TypeInfoPropertyName = "NullableOpenAIReasonerModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIReasonerReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIReasonerReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelProvider?), TypeInfoPropertyName = "NullableOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelModel?), TypeInfoPropertyName = "NullableOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelFallbackModel?), TypeInfoPropertyName = "NullableOpenAIModelFallbackModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode?), TypeInfoPropertyName = "NullableOpenAIModelToolStrictCompatibilityMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelPromptCacheRetention?), TypeInfoPropertyName = "NullableOpenAIModelPromptCacheRetention2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelServiceTier?), TypeInfoPropertyName = "NullableOpenAIModelServiceTier2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIModelReasoningEffort?), TypeInfoPropertyName = "NullableOpenAIModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenRouterModelProvider?), TypeInfoPropertyName = "NullableOpenRouterModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PerplexityAIModelProvider?), TypeInfoPropertyName = "NullablePerplexityAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TogetherAIModelProvider?), TypeInfoPropertyName = "NullableTogetherAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider?), TypeInfoPropertyName = "NullableWorkflowOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel?), TypeInfoPropertyName = "NullableWorkflowOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort?), TypeInfoPropertyName = "NullableWorkflowOpenAIModelReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider?), TypeInfoPropertyName = "NullableWorkflowAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel?), TypeInfoPropertyName = "NullableWorkflowAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?), TypeInfoPropertyName = "NullableWorkflowAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?), TypeInfoPropertyName = "NullableWorkflowAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider?), TypeInfoPropertyName = "NullableWorkflowGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel?), TypeInfoPropertyName = "NullableWorkflowGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider?), TypeInfoPropertyName = "NullableWorkflowCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?), TypeInfoPropertyName = "NullableWorkflowCustomModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ConversationNodeType?), TypeInfoPropertyName = "NullableConversationNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolNodeType?), TypeInfoPropertyName = "NullableToolNodeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider?), TypeInfoPropertyName = "NullableGoogleVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GoogleVoicemailDetectionPlanType?), TypeInfoPropertyName = "NullableGoogleVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider?), TypeInfoPropertyName = "NullableOpenAIVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoicemailDetectionPlanType?), TypeInfoPropertyName = "NullableOpenAIVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider?), TypeInfoPropertyName = "NullableTwilioVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType?), TypeInfoPropertyName = "NullableTwilioVoicemailDetectionPlanVoicemailDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanProvider?), TypeInfoPropertyName = "NullableVapiVoicemailDetectionPlanProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoicemailDetectionPlanType?), TypeInfoPropertyName = "NullableVapiVoicemailDetectionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SayHookActionType?), TypeInfoPropertyName = "NullableSayHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.IList<string>>?), TypeInfoPropertyName = "NullableOneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>?), TypeInfoPropertyName = "NullableOneOfStringIListOneOfSystemMessageUserMessageAssistantMessageToolMessageDeveloperMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>?), TypeInfoPropertyName = "NullableOneOfSystemMessageUserMessageAssistantMessageToolMessageDeveloperMessage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MessageAddHookActionType?), TypeInfoPropertyName = "NullableMessageAddHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookFilterType?), TypeInfoPropertyName = "NullableCallHookFilterType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCallEndingOn?), TypeInfoPropertyName = "NullableCallHookCallEndingOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>?), TypeInfoPropertyName = "NullableOneOfToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn?), TypeInfoPropertyName = "NullableCallHookAssistantSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>?), TypeInfoPropertyName = "NullableOneOfSayHookActionToolCallHookActionMessageAddHookAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn?), TypeInfoPropertyName = "NullableCallHookCustomerSpeechInterruptedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolCallHookActionType?), TypeInfoPropertyName = "NullableToolCallHookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode?), TypeInfoPropertyName = "NullableCustomerSpeechTimeoutOptionsTriggerResetMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CallHookModelResponseTimeoutOn?), TypeInfoPropertyName = "NullableCallHookModelResponseTimeoutOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AIEdgeConditionType?), TypeInfoPropertyName = "NullableAIEdgeConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>?), TypeInfoPropertyName = "NullableOneOfConversationNodeToolNode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableBackgroundSound?, string>?), TypeInfoPropertyName = "NullableOneOfWorkflowUserEditableBackgroundSoundString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableBackgroundSound?), TypeInfoPropertyName = "NullableWorkflowUserEditableBackgroundSound2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem3?), TypeInfoPropertyName = "NullableCredentialsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider?), TypeInfoPropertyName = "NullableWorkflowUserEditableCredentialDiscriminatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowUserEditableVoicemailDetection?), TypeInfoPropertyName = "NullableWorkflowUserEditableVoicemailDetection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelVersion?), TypeInfoPropertyName = "NullableVapiModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiModelProvider?), TypeInfoPropertyName = "NullableVapiModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelModel?), TypeInfoPropertyName = "NullableXaiModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiModelProvider?), TypeInfoPropertyName = "NullableXaiModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ExactReplacementType?), TypeInfoPropertyName = "NullableExactReplacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RegexReplacementType?), TypeInfoPropertyName = "NullableRegexReplacementType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>?), TypeInfoPropertyName = "NullableOneOfExactReplacementRegexReplacement2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FormatPlanFormattersEnabledItem?), TypeInfoPropertyName = "NullableFormatPlanFormattersEnabledItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ChunkPlanPunctuationBoundarie?), TypeInfoPropertyName = "NullableChunkPlanPunctuationBoundarie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceProvider?), TypeInfoPropertyName = "NullableAzureVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfAzureVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AzureVoiceVoiceId?), TypeInfoPropertyName = "NullableAzureVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>?), TypeInfoPropertyName = "NullableOneOfCartesiaExperimentalControlsSpeedDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsSpeed?), TypeInfoPropertyName = "NullableCartesiaExperimentalControlsSpeed2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaExperimentalControlsEmotion?), TypeInfoPropertyName = "NullableCartesiaExperimentalControlsEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceProvider?), TypeInfoPropertyName = "NullableCartesiaVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceModel?), TypeInfoPropertyName = "NullableCartesiaVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CartesiaVoiceLanguage?), TypeInfoPropertyName = "NullableCartesiaVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CustomVoiceProvider?), TypeInfoPropertyName = "NullableCustomVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceProvider?), TypeInfoPropertyName = "NullableDeepgramVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceVoiceId?), TypeInfoPropertyName = "NullableDeepgramVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeepgramVoiceModel?), TypeInfoPropertyName = "NullableDeepgramVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceProvider?), TypeInfoPropertyName = "NullableElevenLabsVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ElevenLabsVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfElevenLabsVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceVoiceId?), TypeInfoPropertyName = "NullableElevenLabsVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ElevenLabsVoiceModel?), TypeInfoPropertyName = "NullableElevenLabsVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceProvider?), TypeInfoPropertyName = "NullableWellSaidVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WellSaidVoiceModel?), TypeInfoPropertyName = "NullableWellSaidVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceProvider?), TypeInfoPropertyName = "NullableHumeVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HumeVoiceModel?), TypeInfoPropertyName = "NullableHumeVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceProvider?), TypeInfoPropertyName = "NullableLMNTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.LMNTVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfLMNTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceVoiceId?), TypeInfoPropertyName = "NullableLMNTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LMNTVoiceLanguage?), TypeInfoPropertyName = "NullableLMNTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceProvider?), TypeInfoPropertyName = "NullableNeuphonicVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NeuphonicVoiceModel?), TypeInfoPropertyName = "NullableNeuphonicVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceProvider?), TypeInfoPropertyName = "NullableOpenAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyOf<global::Vapi.OpenAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableAnyOfOpenAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceVoiceId?), TypeInfoPropertyName = "NullableOpenAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIVoiceModel?), TypeInfoPropertyName = "NullableOpenAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceProvider?), TypeInfoPropertyName = "NullablePlayHTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.PlayHTVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfPlayHTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceVoiceId?), TypeInfoPropertyName = "NullablePlayHTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceEmotion?), TypeInfoPropertyName = "NullablePlayHTVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceModel?), TypeInfoPropertyName = "NullablePlayHTVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PlayHTVoiceLanguage?), TypeInfoPropertyName = "NullablePlayHTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceProvider?), TypeInfoPropertyName = "NullableRimeAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.RimeAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfRimeAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceVoiceId?), TypeInfoPropertyName = "NullableRimeAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceModel?), TypeInfoPropertyName = "NullableRimeAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.RimeAIVoiceLanguage?), TypeInfoPropertyName = "NullableRimeAIVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceProvider?), TypeInfoPropertyName = "NullableSesameVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SesameVoiceModel?), TypeInfoPropertyName = "NullableSesameVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceProvider?), TypeInfoPropertyName = "NullableSmallestAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SmallestAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfSmallestAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceVoiceId?), TypeInfoPropertyName = "NullableSmallestAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SmallestAIVoiceModel?), TypeInfoPropertyName = "NullableSmallestAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider?), TypeInfoPropertyName = "NullableVapiPronunciationDictionaryLocatorProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceProvider?), TypeInfoPropertyName = "NullableVapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.VapiVoiceVersion2?, double?>?), TypeInfoPropertyName = "NullableOneOfVapiVoiceVersion2Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceVersion2?), TypeInfoPropertyName = "NullableVapiVoiceVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.VapiVoiceLanguage?), TypeInfoPropertyName = "NullableVapiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceProvider?), TypeInfoPropertyName = "NullableInworldVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceVoiceId?), TypeInfoPropertyName = "NullableInworldVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceModel?), TypeInfoPropertyName = "NullableInworldVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.InworldVoiceLanguageCode?), TypeInfoPropertyName = "NullableInworldVoiceLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceProvider?), TypeInfoPropertyName = "NullableMinimaxVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceModel?), TypeInfoPropertyName = "NullableMinimaxVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceSubtitleType?), TypeInfoPropertyName = "NullableMinimaxVoiceSubtitleType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceRegion?), TypeInfoPropertyName = "NullableMinimaxVoiceRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinimaxVoiceLanguageBoost?), TypeInfoPropertyName = "NullableMinimaxVoiceLanguageBoost2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceProvider?), TypeInfoPropertyName = "NullableFallbackWellSaidVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackWellSaidVoiceModel?), TypeInfoPropertyName = "NullableFallbackWellSaidVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceProvider?), TypeInfoPropertyName = "NullableXaiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceVoiceId?), TypeInfoPropertyName = "NullableXaiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.XaiVoiceLanguage?), TypeInfoPropertyName = "NullableXaiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceProvider?), TypeInfoPropertyName = "NullableMicrosoftVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceVoiceId?), TypeInfoPropertyName = "NullableMicrosoftVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceStyle?), TypeInfoPropertyName = "NullableMicrosoftVoiceStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MicrosoftVoiceRole?), TypeInfoPropertyName = "NullableMicrosoftVoiceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceProvider?), TypeInfoPropertyName = "NullableFallbackAzureVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackAzureVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackAzureVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackAzureVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceProvider?), TypeInfoPropertyName = "NullableFallbackCartesiaVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceModel?), TypeInfoPropertyName = "NullableFallbackCartesiaVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCartesiaVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackCartesiaVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackCustomVoiceProvider?), TypeInfoPropertyName = "NullableFallbackCustomVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceProvider?), TypeInfoPropertyName = "NullableFallbackDeepgramVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackDeepgramVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackDeepgramVoiceModel?), TypeInfoPropertyName = "NullableFallbackDeepgramVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceProvider?), TypeInfoPropertyName = "NullableFallbackElevenLabsVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackElevenLabsVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackElevenLabsVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackElevenLabsVoiceModel?), TypeInfoPropertyName = "NullableFallbackElevenLabsVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceProvider?), TypeInfoPropertyName = "NullableFallbackHumeVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackHumeVoiceModel?), TypeInfoPropertyName = "NullableFallbackHumeVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceProvider?), TypeInfoPropertyName = "NullableFallbackLMNTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackLMNTVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackLMNTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackLMNTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackLMNTVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackLMNTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceProvider?), TypeInfoPropertyName = "NullableFallbackNeuphonicVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackNeuphonicVoiceModel?), TypeInfoPropertyName = "NullableFallbackNeuphonicVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceProvider?), TypeInfoPropertyName = "NullableFallbackOpenAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnyOf<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableAnyOfFallbackOpenAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackOpenAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackOpenAIVoiceModel?), TypeInfoPropertyName = "NullableFallbackOpenAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceProvider?), TypeInfoPropertyName = "NullableFallbackPlayHTVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackPlayHTVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackPlayHTVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceEmotion?), TypeInfoPropertyName = "NullableFallbackPlayHTVoiceEmotion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceModel?), TypeInfoPropertyName = "NullableFallbackPlayHTVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackPlayHTVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackPlayHTVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceProvider?), TypeInfoPropertyName = "NullableFallbackRimeAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackRimeAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackRimeAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceModel?), TypeInfoPropertyName = "NullableFallbackRimeAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackRimeAIVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackRimeAIVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceProvider?), TypeInfoPropertyName = "NullableFallbackSesameVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSesameVoiceModel?), TypeInfoPropertyName = "NullableFallbackSesameVoiceModel2")]
    internal sealed partial class SimulationPersonalitiesSourceGenerationContextChunk2 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_2b8861a9903db755")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>), TypeInfoPropertyName = "FallbackXaiTranscriber_b66004a379de702e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>), TypeInfoPropertyName = "MicrosoftVoice_4a6e00781b101687")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>), TypeInfoPropertyName = "VapiTranscriber_08a174827361a4d7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>), TypeInfoPropertyName = "VapiModel_0c39ac057634aa9c")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_337944e3626dd50f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_929e4b5bda008e83")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>), TypeInfoPropertyName = "SessionCreatedHook_2fbeaab55b62844d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_40aab5fbf952716b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_ce07bd1a43aafc35")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f4c4631be3aca304")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_125e53ec9b202456")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_406be3ea61580964")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>), TypeInfoPropertyName = "CreateTransferCallToolDTO_c9140097ba8f2e27")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_98afb529f903d70b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>), TypeInfoPropertyName = "CallHookModelResponseTimeout_f9cffc445e112054")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_cde2be735c2dd2b7")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_8b29c57f08840c03")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>), TypeInfoPropertyName = "FallbackMicrosoftVoice_53f3167bfd8a4206")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>?), TypeInfoPropertyName = "FallbackXaiTranscriber_8e7ba8da847c1e2f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>?), TypeInfoPropertyName = "MicrosoftVoice_31f1d8eb96f7f194")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>?), TypeInfoPropertyName = "VapiTranscriber_4286e861e67fc77e")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>?), TypeInfoPropertyName = "WorkflowCustomModel_4fcb5a07f61b51b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>?), TypeInfoPropertyName = "VapiModel_5e260c2c0d56730d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_7113b13dcd4f00d0")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>?), TypeInfoPropertyName = "SessionCreatedHook_c03dd4becfe9e6f2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_d5c02b16b5ac8354")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>?), TypeInfoPropertyName = "CreateVoicemailToolDTO_555b3a5e46354c56")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>?), TypeInfoPropertyName = "ContextEngineeringPlanPreviousAssistantMessages_e17e5092dbcded2d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>?), TypeInfoPropertyName = "CreateTransferCallToolDTO_70f865af830d9b9f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>?), TypeInfoPropertyName = "CallHookModelResponseTimeout_8be94521dbca1bec")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>?), TypeInfoPropertyName = "VapiVoicemailDetectionPlan_1a05329dfc971e6d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>?), TypeInfoPropertyName = "FallbackMicrosoftVoice_fc5b25d43e7f09ef")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>>), TypeInfoPropertyName = "FallbackXaiTranscriber_48521cd6623da15b")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>), TypeInfoPropertyName = "SessionCreatedHook_27f3eef97b8854a6")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>>), TypeInfoPropertyName = "CreateVoicemailToolDTO_f60800cf21404901")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>>), TypeInfoPropertyName = "CreateTransferCallToolDTO_ba4dd0081de0d426")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>), TypeInfoPropertyName = "CallHookModelResponseTimeout_235a3fd1a6b3743f")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>>), TypeInfoPropertyName = "FallbackMicrosoftVoice_2d7edea1f9d77cbe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceProvider?), TypeInfoPropertyName = "NullableFallbackSmallestAIVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>?), TypeInfoPropertyName = "NullableOneOfFallbackSmallestAIVoiceVoiceIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackSmallestAIVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackSmallestAIVoiceModel?), TypeInfoPropertyName = "NullableFallbackSmallestAIVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceProvider?), TypeInfoPropertyName = "NullableFallbackVapiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.FallbackVapiVoiceVersion2?, double?>?), TypeInfoPropertyName = "NullableOneOfFallbackVapiVoiceVersion2Double2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceVersion2?), TypeInfoPropertyName = "NullableFallbackVapiVoiceVersion22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackVapiVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackVapiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceProvider?), TypeInfoPropertyName = "NullableFallbackInworldVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackInworldVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceModel?), TypeInfoPropertyName = "NullableFallbackInworldVoiceModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackInworldVoiceLanguageCode?), TypeInfoPropertyName = "NullableFallbackInworldVoiceLanguageCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceProvider?), TypeInfoPropertyName = "NullableFallbackXaiVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackXaiVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackXaiVoiceLanguage?), TypeInfoPropertyName = "NullableFallbackXaiVoiceLanguage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceProvider?), TypeInfoPropertyName = "NullableFallbackMicrosoftVoiceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId?), TypeInfoPropertyName = "NullableFallbackMicrosoftVoiceVoiceId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceStyle?), TypeInfoPropertyName = "NullableFallbackMicrosoftVoiceStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.FallbackMicrosoftVoiceRole?), TypeInfoPropertyName = "NullableFallbackMicrosoftVoiceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioProvider?), TypeInfoPropertyName = "NullableTransportConfigurationTwilioProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels?), TypeInfoPropertyName = "NullableTransportConfigurationTwilioRecordingChannels2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAnthropicCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAnthropicBedrockCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion?), TypeInfoPropertyName = "NullableCreateAnthropicBedrockCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>?), TypeInfoPropertyName = "NullableOneOfAWSIAMCredentialsAuthenticationPlanAWSStsAuthenticationPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAnyscaleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAssemblyAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAzureCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTOService?), TypeInfoPropertyName = "NullableCreateAzureCredentialDTOService2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureCredentialDTORegion?), TypeInfoPropertyName = "NullableCreateAzureCredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateAzureOpenAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion?), TypeInfoPropertyName = "NullableCreateAzureOpenAICredentialDTORegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel?), TypeInfoPropertyName = "NullableCreateAzureOpenAICredentialDTOModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SipTrunkGatewayOutboundProtocol?), TypeInfoPropertyName = "NullableSipTrunkGatewayOutboundProtocol2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateByoSipTrunkCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCartesiaCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateCartesiaCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCloudflareCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateCloudflareCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OAuth2AuthenticationPlanType?), TypeInfoPropertyName = "NullableOAuth2AuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateCustomLLMCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepgramCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateDeepgramCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateDeepInfraCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateDeepSeekCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateElevenLabsCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl?), TypeInfoPropertyName = "NullableCreateElevenLabsCredentialDTOApiUrl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGcpCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGcpCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGladiaCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGladiaCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoHighLevelCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGroqCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGroqCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLangfuseCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateLangfuseCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateLmntCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateLmntCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMakeCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateMakeCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateOpenAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateOpenRouterCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreatePerplexityAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreatePlayHTCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreatePlayHTCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRimeAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateRimeAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateRunpodCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateRunpodCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateS3CredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SupabaseBucketPlanRegion?), TypeInfoPropertyName = "NullableSupabaseBucketPlanRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSupabaseCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSupabaseCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmallestAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSmallestAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTavusCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateTavusCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTogetherAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateTogetherAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTwilioCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateTwilioCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateVonageCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateVonageCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateWebhookCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan2?), TypeInfoPropertyName = "NullableAuthenticationPlan22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType?), TypeInfoPropertyName = "NullableCreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateXAiCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateXAiCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoogleCalendarOAuth2ClientCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSlackOAuth2AuthorizationCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMinimaxCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateMinimaxCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SessionCreatedHookOn?), TypeInfoPropertyName = "NullableSessionCreatedHookOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem4?), TypeInfoPropertyName = "NullableCredentialsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem5?), TypeInfoPropertyName = "NullableCredentialsItem52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem6?), TypeInfoPropertyName = "NullableCredentialsItem62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem7?), TypeInfoPropertyName = "NullableCredentialsItem72")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem8?), TypeInfoPropertyName = "NullableCredentialsItem82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem9?), TypeInfoPropertyName = "NullableCredentialsItem92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem10?), TypeInfoPropertyName = "NullableCredentialsItem102")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem11?), TypeInfoPropertyName = "NullableCredentialsItem112")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem12?), TypeInfoPropertyName = "NullableCredentialsItem122")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CredentialsItem13?), TypeInfoPropertyName = "NullableCredentialsItem132")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UserMessageConfidenceSource?), TypeInfoPropertyName = "NullableUserMessageConfidenceSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.DeveloperMessageRole?), TypeInfoPropertyName = "NullableDeveloperMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AssistantMessageRole?), TypeInfoPropertyName = "NullableAssistantMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolMessageRole?), TypeInfoPropertyName = "NullableToolMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::Vapi.JsonSchema>?), TypeInfoPropertyName = "NullableOneOfStringJsonSchema2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOType?), TypeInfoPropertyName = "NullableCreateApiRequestToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateApiRequestToolDTOMethod?), TypeInfoPropertyName = "NullableCreateApiRequestToolDTOMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCodeToolDTOType?), TypeInfoPropertyName = "NullableCreateCodeToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOType?), TypeInfoPropertyName = "NullableCreateBashToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOSubType?), TypeInfoPropertyName = "NullableCreateBashToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateBashToolDTOName?), TypeInfoPropertyName = "NullableCreateBashToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOType?), TypeInfoPropertyName = "NullableCreateComputerToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOSubType?), TypeInfoPropertyName = "NullableCreateComputerToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateComputerToolDTOName?), TypeInfoPropertyName = "NullableCreateComputerToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOType?), TypeInfoPropertyName = "NullableCreateTextEditorToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOSubType?), TypeInfoPropertyName = "NullableCreateTextEditorToolDTOSubType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTextEditorToolDTOName?), TypeInfoPropertyName = "NullableCreateTextEditorToolDTOName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSmsToolDTOType?), TypeInfoPropertyName = "NullableCreateSmsToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOType?), TypeInfoPropertyName = "NullableCreateSipRequestToolDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSipRequestToolDTOVerb?), TypeInfoPropertyName = "NullableCreateSipRequestToolDTOVerb2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityInUseConflictResponseDTOError?), TypeInfoPropertyName = "NullablePersonalityInUseConflictResponseDTOError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan4?), TypeInfoPropertyName = "NullableAuthenticationPlan42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SpkiPemPublicKeyConfigFormat?), TypeInfoPropertyName = "NullableSpkiPemPublicKeyConfigFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanType?), TypeInfoPropertyName = "NullablePublicKeyEncryptionPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm?), TypeInfoPropertyName = "NullablePublicKeyEncryptionPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat?), TypeInfoPropertyName = "NullablePublicKeyEncryptionPlanPublicKeyDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan5?), TypeInfoPropertyName = "NullableAuthenticationPlan52")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCerebrasCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateCerebrasCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoogleCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoogleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateHumeCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateHumeCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInflectionAICredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateInflectionAICredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateMicrosoftCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateMistralCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateMistralCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateNeuphonicCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateWellSaidCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateWellSaidCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateS3CompatibleCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSonioxCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSonioxCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSpeechmaticsCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateCustomCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan6?), TypeInfoPropertyName = "NullableAuthenticationPlan62")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType?), TypeInfoPropertyName = "NullableCreateCustomCredentialDTOAuthenticationPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType?), TypeInfoPropertyName = "NullableCreateCustomCredentialDTOEncryptionPlanDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateGoHighLevelMCPCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateInworldCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateInworldCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateEmailCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateEmailCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider?), TypeInfoPropertyName = "NullableCreateSlackWebhookCredentialDTOProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan8?), TypeInfoPropertyName = "NullableAuthenticationPlan82")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AuthenticationPlan9?), TypeInfoPropertyName = "NullableAuthenticationPlan92")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanType?), TypeInfoPropertyName = "NullableHMACAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanAlgorithm?), TypeInfoPropertyName = "NullableHMACAuthenticationPlanAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding?), TypeInfoPropertyName = "NullableHMACAuthenticationPlanSignatureEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BearerAuthenticationPlanType?), TypeInfoPropertyName = "NullableBearerAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType?), TypeInfoPropertyName = "NullableAWSIAMCredentialsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AWSStsAuthenticationPlanType?), TypeInfoPropertyName = "NullableAWSStsAuthenticationPlanType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ToolControllerCreateRequest?), TypeInfoPropertyName = "NullableToolControllerCreateRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityControllerFindAllSortOrder?), TypeInfoPropertyName = "NullablePersonalityControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PersonalityControllerFindAllSortBy?), TypeInfoPropertyName = "NullablePersonalityControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssemblyAITranscriberLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.DeepgramTranscriberRedactionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<string, global::Vapi.GladiaVocabularyItemDTO>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.GladiaTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SonioxTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SonioxContextGeneralItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SpeechmaticsCustomVocabularyItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VapiTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FallbackAssemblyAITranscriberLanguageCode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FallbackDeepgramTranscriberRedactionItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FallbackGladiaTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FallbackSonioxTranscriberLanguage2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TextContent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Condition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VariableExtractionAlias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolParameter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.RegexOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SecurityFilterBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredDataMultiPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateStructuredOutputDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateScorecardDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TransientAssistantDTOClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TransientAssistantDTOServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TransportConfigurationTwilio>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesClientMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AssistantOverridesServerMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SquadMemberDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.McpToolMessages>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolRef>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.AnthropicBedrockModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAISpeakerPersonalityPack>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIReasonerSkill>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIModelFallbackModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CallHookFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CredentialsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Edge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.FormatPlanFormattersEnabledItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ChunkPlanPunctuationBoundarie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ElevenLabsPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.VapiPronunciationDictionaryLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateAzureOpenAICredentialDTOModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SipTrunkGateway>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCallHookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TranscriptWordConfidence>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CodeToolEnvironmentVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Personality>))]
    internal sealed partial class SimulationPersonalitiesSourceGenerationContextChunk3 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationPersonalitiesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SimulationPersonalitiesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SimulationPersonalitiesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vapi.JsonConverters.RecordingConsentPlanJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItemJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem2JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem3JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan2JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem4JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem5JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem6JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem7JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem8JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem9JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem10JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem11JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem12JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.CredentialsItem13JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan4JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan5JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan6JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan8JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.AuthenticationPlan9JsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.ToolControllerCreateRequestJsonConverter());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber, global::Vapi.FallbackXaiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.DeepgramTranscriberModel?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.GladiaVocabularyItemDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackDeepgramTranscriberModel?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RegexCondition, global::Vapi.LiquidCondition, global::Vapi.GroupCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<bool?, global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.VapiSmartEndpointingPlan, global::Vapi.LivekitSmartEndpointingPlan, global::Vapi.CustomEndpointingModelSmartEndpointingPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantCustomEndpointingRule, global::Vapi.CustomerCustomEndpointingRule, global::Vapi.BothCustomEndpointingRule>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.CustomMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransientAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransientAssistantDTOBackgroundSound?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantOverridesBackgroundSound?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.HandoffDestinationAssistant>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages, global::Vapi.ContextEngineeringPlanPreviousAssistantMessages>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateTransferCallToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowUserEditableBackgroundSound?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowUserEditableVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ExactReplacement, global::Vapi.RegexReplacement>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice, global::Vapi.FallbackXaiVoice, global::Vapi.FallbackMicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CartesiaExperimentalControlsSpeed?, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ElevenLabsVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.LMNTVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.AnyOfJsonConverter<global::Vapi.OpenAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.PlayHTVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.RimeAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SmallestAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.VapiVoiceVersion2?, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackAzureVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackElevenLabsVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackLMNTVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.AnyOfJsonConverter<global::Vapi.FallbackOpenAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackPlayHTVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackRimeAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackSmallestAIVoiceVoiceId?, string>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.FallbackVapiVoiceVersion2?, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel, global::Vapi.VapiModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ConversationNode, global::Vapi.ToolNode>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber, global::Vapi.XaiTranscriber, global::Vapi.VapiTranscriber>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice, global::Vapi.XaiVoice, global::Vapi.MicrosoftVoice>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.HandoffDestinationAssistant, global::Vapi.HandoffDestinationDynamic, global::Vapi.HandoffDestinationSquad>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AWSIAMCredentialsAuthenticationPlan, global::Vapi.AWSStsAuthenticationPlan>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateApiRequestToolDTO, global::Vapi.CreateBashToolDTO, global::Vapi.CreateCodeToolDTO, global::Vapi.CreateComputerToolDTO, global::Vapi.CreateDtmfToolDTO, global::Vapi.CreateEndCallToolDTO, global::Vapi.CreateFunctionToolDTO, global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTO, global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTO, global::Vapi.CreateGoHighLevelContactCreateToolDTO, global::Vapi.CreateGoHighLevelContactGetToolDTO, global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTO, global::Vapi.CreateGoogleCalendarCreateEventToolDTO, global::Vapi.CreateGoogleSheetsRowAppendToolDTO, global::Vapi.CreateHandoffToolDTO, global::Vapi.CreateMcpToolDTO, global::Vapi.CreateQueryToolDTO, global::Vapi.CreateSlackSendMessageToolDTO, global::Vapi.CreateSmsToolDTO, global::Vapi.CreateTextEditorToolDTO, global::Vapi.CreateTransferCallToolDTO, global::Vapi.CreateSipRequestToolDTO, global::Vapi.CreateVoicemailToolDTO>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>());
            options.Converters.Add(new global::Vapi.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vapi.AssemblyAITranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberMode)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberMode?)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguageCode)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguageCode?)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberSpeechModel)

                    || typeToConvert == typeof(global::Vapi.AssemblyAITranscriberSpeechModel?)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy)

                    || typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy?)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.CartesiaTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.CustomTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.CustomTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberRedactionItem)

                    || typeToConvert == typeof(global::Vapi.DeepgramTranscriberRedactionItem?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguageBehaviour)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguageBehaviour?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage2)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage2?)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberRegion)

                    || typeToConvert == typeof(global::Vapi.GladiaTranscriberRegion?)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage2)

                    || typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage2?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberRegion)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberRegion?)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle)

                    || typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle?)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.TalkscriberTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.GoogleTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberModel)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.OpenAITranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.XaiTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberVersion)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberVersion?)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage2)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage2?)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberTurnTaking)

                    || typeToConvert == typeof(global::Vapi.VapiTranscriberTurnTaking?)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberMode)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberMode?)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode?)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel)

                    || typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackCustomTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackCustomTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage2)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage2?)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberRegion)

                    || typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberRegion?)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage2)

                    || typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage2?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion?)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle)

                    || typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle?)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberModel)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberLanguage?)

                    || typeToConvert == typeof(global::Vapi.LangfuseObservabilityPlanProvider)

                    || typeToConvert == typeof(global::Vapi.LangfuseObservabilityPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.TextContentType)

                    || typeToConvert == typeof(global::Vapi.TextContentType?)

                    || typeToConvert == typeof(global::Vapi.TextContentLanguage)

                    || typeToConvert == typeof(global::Vapi.TextContentLanguage?)

                    || typeToConvert == typeof(global::Vapi.ConditionOperator)

                    || typeToConvert == typeof(global::Vapi.ConditionOperator?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageStartType)

                    || typeToConvert == typeof(global::Vapi.ToolMessageStartType?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageCompleteType)

                    || typeToConvert == typeof(global::Vapi.ToolMessageCompleteType?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageCompleteRole)

                    || typeToConvert == typeof(global::Vapi.ToolMessageCompleteRole?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageFailedType)

                    || typeToConvert == typeof(global::Vapi.ToolMessageFailedType?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageFailedRole)

                    || typeToConvert == typeof(global::Vapi.ToolMessageFailedRole?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageDelayedType)

                    || typeToConvert == typeof(global::Vapi.ToolMessageDelayedType?)

                    || typeToConvert == typeof(global::Vapi.MessageTargetRole)

                    || typeToConvert == typeof(global::Vapi.MessageTargetRole?)

                    || typeToConvert == typeof(global::Vapi.RegexConditionType)

                    || typeToConvert == typeof(global::Vapi.RegexConditionType?)

                    || typeToConvert == typeof(global::Vapi.LiquidConditionType)

                    || typeToConvert == typeof(global::Vapi.LiquidConditionType?)

                    || typeToConvert == typeof(global::Vapi.GroupConditionType)

                    || typeToConvert == typeof(global::Vapi.GroupConditionType?)

                    || typeToConvert == typeof(global::Vapi.GroupConditionOperator)

                    || typeToConvert == typeof(global::Vapi.GroupConditionOperator?)

                    || typeToConvert == typeof(global::Vapi.CreateDtmfToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateDtmfToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateEndCallToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateEndCallToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateVoicemailToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateVoicemailToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaType)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaType?)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaFormat)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaFormat?)

                    || typeToConvert == typeof(global::Vapi.OpenAIFunctionParametersType)

                    || typeToConvert == typeof(global::Vapi.OpenAIFunctionParametersType?)

                    || typeToConvert == typeof(global::Vapi.CreateFunctionToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateFunctionToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CustomMessageType)

                    || typeToConvert == typeof(global::Vapi.CustomMessageType?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationAssistantType)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationAssistantType?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationAssistantTransferMode)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationAssistantTransferMode?)

                    || typeToConvert == typeof(global::Vapi.RegexOptionType)

                    || typeToConvert == typeof(global::Vapi.RegexOptionType?)

                    || typeToConvert == typeof(global::Vapi.AssistantCustomEndpointingRuleType)

                    || typeToConvert == typeof(global::Vapi.AssistantCustomEndpointingRuleType?)

                    || typeToConvert == typeof(global::Vapi.CustomerCustomEndpointingRuleType)

                    || typeToConvert == typeof(global::Vapi.CustomerCustomEndpointingRuleType?)

                    || typeToConvert == typeof(global::Vapi.BothCustomEndpointingRuleType)

                    || typeToConvert == typeof(global::Vapi.BothCustomEndpointingRuleType?)

                    || typeToConvert == typeof(global::Vapi.VapiSmartEndpointingPlanProvider)

                    || typeToConvert == typeof(global::Vapi.VapiSmartEndpointingPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.LivekitSmartEndpointingPlanProvider)

                    || typeToConvert == typeof(global::Vapi.LivekitSmartEndpointingPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider)

                    || typeToConvert == typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled)

                    || typeToConvert == typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?)

                    || typeToConvert == typeof(global::Vapi.TransferPlanMode)

                    || typeToConvert == typeof(global::Vapi.TransferPlanMode?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationNumberType)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationNumberType?)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationSipType)

                    || typeToConvert == typeof(global::Vapi.TransferDestinationSipType?)

                    || typeToConvert == typeof(global::Vapi.CreateTransferCallToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateTransferCallToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType?)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType)

                    || typeToConvert == typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType?)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode?)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineType)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineType?)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode?)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalType)

                    || typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalType?)

                    || typeToConvert == typeof(global::Vapi.SecurityFilterPlanMode)

                    || typeToConvert == typeof(global::Vapi.SecurityFilterPlanMode?)

                    || typeToConvert == typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType)

                    || typeToConvert == typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType?)

                    || typeToConvert == typeof(global::Vapi.SuccessEvaluationPlanRubric)

                    || typeToConvert == typeof(global::Vapi.SuccessEvaluationPlanRubric?)

                    || typeToConvert == typeof(global::Vapi.MinMessagesConditionType)

                    || typeToConvert == typeof(global::Vapi.MinMessagesConditionType?)

                    || typeToConvert == typeof(global::Vapi.MinCallDurationConditionType)

                    || typeToConvert == typeof(global::Vapi.MinCallDurationConditionType?)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionType)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionType?)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator?)

                    || typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType?)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?)

                    || typeToConvert == typeof(global::Vapi.ArtifactPlanRecordingFormat)

                    || typeToConvert == typeof(global::Vapi.ArtifactPlanRecordingFormat?)

                    || typeToConvert == typeof(global::Vapi.KeypadInputPlanDelimiters)

                    || typeToConvert == typeof(global::Vapi.KeypadInputPlanDelimiters?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOFirstMessageMode)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOFirstMessageMode?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOVoicemailDetection)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOVoicemailDetection?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOClientMessage)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOClientMessage?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOServerMessage)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOServerMessage?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOBackgroundSound)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOBackgroundSound?)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesFirstMessageMode)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesFirstMessageMode?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesVoicemailDetection)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesVoicemailDetection?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesClientMessage)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesClientMessage?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesServerMessage)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesServerMessage?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesBackgroundSound)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesBackgroundSound?)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationAssistantType)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationAssistantType?)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationDynamicType)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationDynamicType?)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationSquadType)

                    || typeToConvert == typeof(global::Vapi.HandoffDestinationSquadType?)

                    || typeToConvert == typeof(global::Vapi.CreateHandoffToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateHandoffToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.KnowledgeBaseProvider)

                    || typeToConvert == typeof(global::Vapi.KnowledgeBaseProvider?)

                    || typeToConvert == typeof(global::Vapi.KnowledgeBaseModel)

                    || typeToConvert == typeof(global::Vapi.KnowledgeBaseModel?)

                    || typeToConvert == typeof(global::Vapi.CreateQueryToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateQueryToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateSlackSendMessageToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateSlackSendMessageToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.McpToolMetadataProtocol)

                    || typeToConvert == typeof(global::Vapi.McpToolMetadataProtocol?)

                    || typeToConvert == typeof(global::Vapi.CreateMcpToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateMcpToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.OpenAIMessageRole)

                    || typeToConvert == typeof(global::Vapi.OpenAIMessageRole?)

                    || typeToConvert == typeof(global::Vapi.AnyscaleModelProvider)

                    || typeToConvert == typeof(global::Vapi.AnyscaleModelProvider?)

                    || typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType)

                    || typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType?)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelModel)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelModel?)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelReasoningEffort)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelReasoningEffort?)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelProvider)

                    || typeToConvert == typeof(global::Vapi.AnthropicModelProvider?)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelProvider)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelProvider?)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelModel)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelModel?)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelFallbackModel)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelFallbackModel?)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelReasoningEffort)

                    || typeToConvert == typeof(global::Vapi.AnthropicBedrockModelReasoningEffort?)

                    || typeToConvert == typeof(global::Vapi.CerebrasModelModel)

                    || typeToConvert == typeof(global::Vapi.CerebrasModelModel?)

                    || typeToConvert == typeof(global::Vapi.CerebrasModelProvider)

                    || typeToConvert == typeof(global::Vapi.CerebrasModelProvider?)

                    || typeToConvert == typeof(global::Vapi.CustomLLMModelProvider)

                    || typeToConvert == typeof(global::Vapi.CustomLLMModelProvider?)

                    || typeToConvert == typeof(global::Vapi.CustomLLMModelMetadataSendMode)

                    || typeToConvert == typeof(global::Vapi.CustomLLMModelMetadataSendMode?)

                    || typeToConvert == typeof(global::Vapi.DeepInfraModelProvider)

                    || typeToConvert == typeof(global::Vapi.DeepInfraModelProvider?)

                    || typeToConvert == typeof(global::Vapi.DeepSeekModelModel)

                    || typeToConvert == typeof(global::Vapi.DeepSeekModelModel?)

                    || typeToConvert == typeof(global::Vapi.DeepSeekModelProvider)

                    || typeToConvert == typeof(global::Vapi.DeepSeekModelProvider?)

                    || typeToConvert == typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName)

                    || typeToConvert == typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName?)

                    || typeToConvert == typeof(global::Vapi.GoogleModelModel)

                    || typeToConvert == typeof(global::Vapi.GoogleModelModel?)

                    || typeToConvert == typeof(global::Vapi.GoogleModelProvider)

                    || typeToConvert == typeof(global::Vapi.GoogleModelProvider?)

                    || typeToConvert == typeof(global::Vapi.GroqModelModel)

                    || typeToConvert == typeof(global::Vapi.GroqModelModel?)

                    || typeToConvert == typeof(global::Vapi.GroqModelProvider)

                    || typeToConvert == typeof(global::Vapi.GroqModelProvider?)

                    || typeToConvert == typeof(global::Vapi.InflectionAIModelModel)

                    || typeToConvert == typeof(global::Vapi.InflectionAIModelModel?)

                    || typeToConvert == typeof(global::Vapi.InflectionAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.InflectionAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.MinimaxLLMModelProvider)

                    || typeToConvert == typeof(global::Vapi.MinimaxLLMModelProvider?)

                    || typeToConvert == typeof(global::Vapi.MinimaxLLMModelModel)

                    || typeToConvert == typeof(global::Vapi.MinimaxLLMModelModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAISpeakerPersonalityPack)

                    || typeToConvert == typeof(global::Vapi.OpenAISpeakerPersonalityPack?)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerProvider)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerProvider?)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerModel)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerReasoningEffort)

                    || typeToConvert == typeof(global::Vapi.OpenAIReasonerReasoningEffort?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelModel)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelFallbackModel)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelFallbackModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelPromptCacheRetention)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelPromptCacheRetention?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelServiceTier)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelServiceTier?)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelReasoningEffort)

                    || typeToConvert == typeof(global::Vapi.OpenAIModelReasoningEffort?)

                    || typeToConvert == typeof(global::Vapi.OpenRouterModelProvider)

                    || typeToConvert == typeof(global::Vapi.OpenRouterModelProvider?)

                    || typeToConvert == typeof(global::Vapi.PerplexityAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.PerplexityAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.TogetherAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.TogetherAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?)

                    || typeToConvert == typeof(global::Vapi.ConversationNodeType)

                    || typeToConvert == typeof(global::Vapi.ConversationNodeType?)

                    || typeToConvert == typeof(global::Vapi.ToolNodeType)

                    || typeToConvert == typeof(global::Vapi.ToolNodeType?)

                    || typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider)

                    || typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanType)

                    || typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanType?)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanType)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanType?)

                    || typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider)

                    || typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType)

                    || typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType?)

                    || typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanProvider)

                    || typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanProvider?)

                    || typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanType)

                    || typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanType?)

                    || typeToConvert == typeof(global::Vapi.SayHookActionType)

                    || typeToConvert == typeof(global::Vapi.SayHookActionType?)

                    || typeToConvert == typeof(global::Vapi.MessageAddHookActionType)

                    || typeToConvert == typeof(global::Vapi.MessageAddHookActionType?)

                    || typeToConvert == typeof(global::Vapi.CallHookFilterType)

                    || typeToConvert == typeof(global::Vapi.CallHookFilterType?)

                    || typeToConvert == typeof(global::Vapi.CallHookCallEndingOn)

                    || typeToConvert == typeof(global::Vapi.CallHookCallEndingOn?)

                    || typeToConvert == typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn)

                    || typeToConvert == typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn?)

                    || typeToConvert == typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn)

                    || typeToConvert == typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn?)

                    || typeToConvert == typeof(global::Vapi.ToolCallHookActionType)

                    || typeToConvert == typeof(global::Vapi.ToolCallHookActionType?)

                    || typeToConvert == typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode)

                    || typeToConvert == typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode?)

                    || typeToConvert == typeof(global::Vapi.CallHookModelResponseTimeoutOn)

                    || typeToConvert == typeof(global::Vapi.CallHookModelResponseTimeoutOn?)

                    || typeToConvert == typeof(global::Vapi.AIEdgeConditionType)

                    || typeToConvert == typeof(global::Vapi.AIEdgeConditionType?)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableBackgroundSound)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableBackgroundSound?)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableVoicemailDetection)

                    || typeToConvert == typeof(global::Vapi.WorkflowUserEditableVoicemailDetection?)

                    || typeToConvert == typeof(global::Vapi.VapiModelVersion)

                    || typeToConvert == typeof(global::Vapi.VapiModelVersion?)

                    || typeToConvert == typeof(global::Vapi.VapiModelProvider)

                    || typeToConvert == typeof(global::Vapi.VapiModelProvider?)

                    || typeToConvert == typeof(global::Vapi.XaiModelModel)

                    || typeToConvert == typeof(global::Vapi.XaiModelModel?)

                    || typeToConvert == typeof(global::Vapi.XaiModelProvider)

                    || typeToConvert == typeof(global::Vapi.XaiModelProvider?)

                    || typeToConvert == typeof(global::Vapi.ExactReplacementType)

                    || typeToConvert == typeof(global::Vapi.ExactReplacementType?)

                    || typeToConvert == typeof(global::Vapi.RegexReplacementType)

                    || typeToConvert == typeof(global::Vapi.RegexReplacementType?)

                    || typeToConvert == typeof(global::Vapi.FormatPlanFormattersEnabledItem)

                    || typeToConvert == typeof(global::Vapi.FormatPlanFormattersEnabledItem?)

                    || typeToConvert == typeof(global::Vapi.ChunkPlanPunctuationBoundarie)

                    || typeToConvert == typeof(global::Vapi.ChunkPlanPunctuationBoundarie?)

                    || typeToConvert == typeof(global::Vapi.AzureVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.AzureVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.AzureVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.AzureVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsSpeed)

                    || typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsSpeed?)

                    || typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsEmotion)

                    || typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsEmotion?)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceModel)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.CartesiaVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.CustomVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.CustomVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceModel)

                    || typeToConvert == typeof(global::Vapi.DeepgramVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceModel)

                    || typeToConvert == typeof(global::Vapi.ElevenLabsVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.WellSaidVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.WellSaidVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.WellSaidVoiceModel)

                    || typeToConvert == typeof(global::Vapi.WellSaidVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.HumeVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.HumeVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.HumeVoiceModel)

                    || typeToConvert == typeof(global::Vapi.HumeVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.LMNTVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.NeuphonicVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.NeuphonicVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.NeuphonicVoiceModel)

                    || typeToConvert == typeof(global::Vapi.NeuphonicVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.OpenAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceEmotion)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceEmotion?)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceModel)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.PlayHTVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.RimeAIVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.SesameVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.SesameVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.SesameVoiceModel)

                    || typeToConvert == typeof(global::Vapi.SesameVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.SmallestAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider)

                    || typeToConvert == typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider?)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceVersion2)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceVersion2?)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.VapiVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceModel)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceLanguageCode)

                    || typeToConvert == typeof(global::Vapi.InworldVoiceLanguageCode?)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceModel)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceSubtitleType)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceSubtitleType?)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceRegion)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceRegion?)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceLanguageBoost)

                    || typeToConvert == typeof(global::Vapi.MinimaxVoiceLanguageBoost?)

                    || typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.XaiVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceStyle)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceStyle?)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceRole)

                    || typeToConvert == typeof(global::Vapi.MicrosoftVoiceRole?)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackAzureVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackCustomVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackCustomVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackHumeVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackHumeVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackHumeVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackHumeVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceEmotion)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceEmotion?)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackSesameVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackSesameVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackSesameVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackSesameVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceVersion2)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceVersion2?)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackVapiVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceModel)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceModel?)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceLanguageCode)

                    || typeToConvert == typeof(global::Vapi.FallbackInworldVoiceLanguageCode?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceLanguage)

                    || typeToConvert == typeof(global::Vapi.FallbackXaiVoiceLanguage?)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceProvider)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceProvider?)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId?)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceStyle)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceStyle?)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceRole)

                    || typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceRole?)

                    || typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioProvider)

                    || typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioProvider?)

                    || typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels)

                    || typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels?)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion)

                    || typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion?)

                    || typeToConvert == typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOService)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOService?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTORegion)

                    || typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTORegion?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion?)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel)

                    || typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel?)

                    || typeToConvert == typeof(global::Vapi.SipTrunkGatewayOutboundProtocol)

                    || typeToConvert == typeof(global::Vapi.SipTrunkGatewayOutboundProtocol?)

                    || typeToConvert == typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateCartesiaCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCartesiaCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateCloudflareCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCloudflareCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.OAuth2AuthenticationPlanType)

                    || typeToConvert == typeof(global::Vapi.OAuth2AuthenticationPlanType?)

                    || typeToConvert == typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateDeepgramCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateDeepgramCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl)

                    || typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl?)

                    || typeToConvert == typeof(global::Vapi.CreateGcpCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGcpCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGladiaCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGladiaCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGroqCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGroqCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateLangfuseCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateLangfuseCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateLmntCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateLmntCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateMakeCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateMakeCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateOpenAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateOpenAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreatePlayHTCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreatePlayHTCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateRimeAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateRimeAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateRunpodCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateRunpodCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateS3CredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateS3CredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.SupabaseBucketPlanRegion)

                    || typeToConvert == typeof(global::Vapi.SupabaseBucketPlanRegion?)

                    || typeToConvert == typeof(global::Vapi.CreateSupabaseCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSupabaseCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateSmallestAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSmallestAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateTavusCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateTavusCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateTogetherAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateTogetherAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateTwilioCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateTwilioCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateVonageCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateVonageCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType)

                    || typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType?)

                    || typeToConvert == typeof(global::Vapi.CreateXAiCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateXAiCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateMinimaxCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateMinimaxCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.SessionCreatedHookOn)

                    || typeToConvert == typeof(global::Vapi.SessionCreatedHookOn?)

                    || typeToConvert == typeof(global::Vapi.UserMessageConfidenceSource)

                    || typeToConvert == typeof(global::Vapi.UserMessageConfidenceSource?)

                    || typeToConvert == typeof(global::Vapi.DeveloperMessageRole)

                    || typeToConvert == typeof(global::Vapi.DeveloperMessageRole?)

                    || typeToConvert == typeof(global::Vapi.AssistantMessageRole)

                    || typeToConvert == typeof(global::Vapi.AssistantMessageRole?)

                    || typeToConvert == typeof(global::Vapi.ToolMessageRole)

                    || typeToConvert == typeof(global::Vapi.ToolMessageRole?)

                    || typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOMethod)

                    || typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOMethod?)

                    || typeToConvert == typeof(global::Vapi.CreateCodeToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateCodeToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOSubType)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOSubType?)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOName)

                    || typeToConvert == typeof(global::Vapi.CreateBashToolDTOName?)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOSubType)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOSubType?)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOName)

                    || typeToConvert == typeof(global::Vapi.CreateComputerToolDTOName?)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOSubType)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOSubType?)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOName)

                    || typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOName?)

                    || typeToConvert == typeof(global::Vapi.CreateSmsToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateSmsToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOType?)

                    || typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOVerb)

                    || typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOVerb?)

                    || typeToConvert == typeof(global::Vapi.PersonalityInUseConflictResponseDTOError)

                    || typeToConvert == typeof(global::Vapi.PersonalityInUseConflictResponseDTOError?)

                    || typeToConvert == typeof(global::Vapi.SpkiPemPublicKeyConfigFormat)

                    || typeToConvert == typeof(global::Vapi.SpkiPemPublicKeyConfigFormat?)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanType)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanType?)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm?)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat)

                    || typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat?)

                    || typeToConvert == typeof(global::Vapi.CreateCerebrasCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCerebrasCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoogleCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateHumeCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateHumeCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateInflectionAICredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateInflectionAICredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateMistralCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateMistralCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateWellSaidCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateWellSaidCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateSonioxCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSonioxCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType?)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType)

                    || typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType?)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateInworldCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateInworldCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateEmailCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateEmailCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider)

                    || typeToConvert == typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider?)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanType)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanType?)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanAlgorithm)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanAlgorithm?)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding)

                    || typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding?)

                    || typeToConvert == typeof(global::Vapi.BearerAuthenticationPlanType)

                    || typeToConvert == typeof(global::Vapi.BearerAuthenticationPlanType?)

                    || typeToConvert == typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType)

                    || typeToConvert == typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType?)

                    || typeToConvert == typeof(global::Vapi.AWSStsAuthenticationPlanType)

                    || typeToConvert == typeof(global::Vapi.AWSStsAuthenticationPlanType?)

                    || typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortOrder)

                    || typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortOrder?)

                    || typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortBy)

                    || typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberMode))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberMode?))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguageCode))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberLanguageCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberLanguageCode?))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberLanguageCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberSpeechModel))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberSpeechModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssemblyAITranscriberSpeechModel?))
                {
                    return new global::Vapi.JsonConverters.AssemblyAITranscriberSpeechModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberSegmentationStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureSpeechTranscriberSegmentationStrategy?))
                {
                    return new global::Vapi.JsonConverters.AzureSpeechTranscriberSegmentationStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.CartesiaTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.CustomTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.CustomTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberRedactionItem))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberRedactionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramTranscriberRedactionItem?))
                {
                    return new global::Vapi.JsonConverters.DeepgramTranscriberRedactionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguageBehaviour))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguageBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguageBehaviour?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguageBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage2))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberLanguage2?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberRegion))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GladiaTranscriberRegion?))
                {
                    return new global::Vapi.JsonConverters.GladiaTranscriberRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage2))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SonioxTranscriberLanguage2?))
                {
                    return new global::Vapi.JsonConverters.SonioxTranscriberLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberOperatingPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberOperatingPoint?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberOperatingPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberRegion))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberRegion?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberNumeralStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpeechmaticsTranscriberNumeralStyle?))
                {
                    return new global::Vapi.JsonConverters.SpeechmaticsTranscriberNumeralStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TalkscriberTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.TalkscriberTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.GoogleTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberModel))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAITranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.OpenAITranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.XaiTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberVersion))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberVersion?))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage2))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberLanguage2?))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberTurnTaking))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberTurnTakingJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiTranscriberTurnTaking?))
                {
                    return new global::Vapi.JsonConverters.VapiTranscriberTurnTakingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberMode))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberMode?))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberLanguageCode?))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberLanguageCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberSpeechModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAssemblyAITranscriberSpeechModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackAssemblyAITranscriberSpeechModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberSegmentationStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureSpeechTranscriberSegmentationStrategy?))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureSpeechTranscriberSegmentationStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCustomTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackCustomTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCustomTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackCustomTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberRedactionItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramTranscriberRedactionItem?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramTranscriberRedactionItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageBehaviourJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguageBehaviour?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageBehaviourNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage2))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberLanguage2?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberRegion))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGladiaTranscriberRegion?))
                {
                    return new global::Vapi.JsonConverters.FallbackGladiaTranscriberRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage2))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguage2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSonioxTranscriberLanguage2?))
                {
                    return new global::Vapi.JsonConverters.FallbackSonioxTranscriberLanguage2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberOperatingPointJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberOperatingPoint?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberOperatingPointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberRegion?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberNumeralStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSpeechmaticsTranscriberNumeralStyle?))
                {
                    return new global::Vapi.JsonConverters.FallbackSpeechmaticsTranscriberNumeralStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackTalkscriberTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackTalkscriberTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackGoogleTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackGoogleTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAITranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAITranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberModel))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiTranscriberLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiTranscriberLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LangfuseObservabilityPlanProvider))
                {
                    return new global::Vapi.JsonConverters.LangfuseObservabilityPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LangfuseObservabilityPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.LangfuseObservabilityPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentType))
                {
                    return new global::Vapi.JsonConverters.TextContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentType?))
                {
                    return new global::Vapi.JsonConverters.TextContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentLanguage))
                {
                    return new global::Vapi.JsonConverters.TextContentLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TextContentLanguage?))
                {
                    return new global::Vapi.JsonConverters.TextContentLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ConditionOperator))
                {
                    return new global::Vapi.JsonConverters.ConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ConditionOperator?))
                {
                    return new global::Vapi.JsonConverters.ConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageStartType))
                {
                    return new global::Vapi.JsonConverters.ToolMessageStartTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageStartType?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageStartTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageCompleteType))
                {
                    return new global::Vapi.JsonConverters.ToolMessageCompleteTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageCompleteType?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageCompleteTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageCompleteRole))
                {
                    return new global::Vapi.JsonConverters.ToolMessageCompleteRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageCompleteRole?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageCompleteRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageFailedType))
                {
                    return new global::Vapi.JsonConverters.ToolMessageFailedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageFailedType?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageFailedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageFailedRole))
                {
                    return new global::Vapi.JsonConverters.ToolMessageFailedRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageFailedRole?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageFailedRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageDelayedType))
                {
                    return new global::Vapi.JsonConverters.ToolMessageDelayedTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageDelayedType?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageDelayedTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MessageTargetRole))
                {
                    return new global::Vapi.JsonConverters.MessageTargetRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MessageTargetRole?))
                {
                    return new global::Vapi.JsonConverters.MessageTargetRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexConditionType))
                {
                    return new global::Vapi.JsonConverters.RegexConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexConditionType?))
                {
                    return new global::Vapi.JsonConverters.RegexConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LiquidConditionType))
                {
                    return new global::Vapi.JsonConverters.LiquidConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LiquidConditionType?))
                {
                    return new global::Vapi.JsonConverters.LiquidConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroupConditionType))
                {
                    return new global::Vapi.JsonConverters.GroupConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroupConditionType?))
                {
                    return new global::Vapi.JsonConverters.GroupConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroupConditionOperator))
                {
                    return new global::Vapi.JsonConverters.GroupConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroupConditionOperator?))
                {
                    return new global::Vapi.JsonConverters.GroupConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDtmfToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateDtmfToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDtmfToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateDtmfToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateEndCallToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateEndCallToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateEndCallToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateEndCallToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVoicemailToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateVoicemailToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVoicemailToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateVoicemailToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaType))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaType?))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaFormat))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaFormat?))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIFunctionParametersType))
                {
                    return new global::Vapi.JsonConverters.OpenAIFunctionParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIFunctionParametersType?))
                {
                    return new global::Vapi.JsonConverters.OpenAIFunctionParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateFunctionToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateFunctionToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateFunctionToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateFunctionToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomMessageType))
                {
                    return new global::Vapi.JsonConverters.CustomMessageTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomMessageType?))
                {
                    return new global::Vapi.JsonConverters.CustomMessageTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationAssistantType))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationAssistantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationAssistantType?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationAssistantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationAssistantTransferMode))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationAssistantTransferModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationAssistantTransferMode?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationAssistantTransferModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexOptionType))
                {
                    return new global::Vapi.JsonConverters.RegexOptionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexOptionType?))
                {
                    return new global::Vapi.JsonConverters.RegexOptionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantCustomEndpointingRuleType))
                {
                    return new global::Vapi.JsonConverters.AssistantCustomEndpointingRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantCustomEndpointingRuleType?))
                {
                    return new global::Vapi.JsonConverters.AssistantCustomEndpointingRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomerCustomEndpointingRuleType))
                {
                    return new global::Vapi.JsonConverters.CustomerCustomEndpointingRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomerCustomEndpointingRuleType?))
                {
                    return new global::Vapi.JsonConverters.CustomerCustomEndpointingRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BothCustomEndpointingRuleType))
                {
                    return new global::Vapi.JsonConverters.BothCustomEndpointingRuleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BothCustomEndpointingRuleType?))
                {
                    return new global::Vapi.JsonConverters.BothCustomEndpointingRuleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiSmartEndpointingPlanProvider))
                {
                    return new global::Vapi.JsonConverters.VapiSmartEndpointingPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiSmartEndpointingPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiSmartEndpointingPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LivekitSmartEndpointingPlanProvider))
                {
                    return new global::Vapi.JsonConverters.LivekitSmartEndpointingPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LivekitSmartEndpointingPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.LivekitSmartEndpointingPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider))
                {
                    return new global::Vapi.JsonConverters.CustomEndpointingModelSmartEndpointingPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomEndpointingModelSmartEndpointingPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.CustomEndpointingModelSmartEndpointingPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled))
                {
                    return new global::Vapi.JsonConverters.StartSpeakingPlanSmartEndpointingEnabledJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StartSpeakingPlanSmartEndpointingEnabled?))
                {
                    return new global::Vapi.JsonConverters.StartSpeakingPlanSmartEndpointingEnabledNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPlanMode))
                {
                    return new global::Vapi.JsonConverters.TransferPlanModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferPlanMode?))
                {
                    return new global::Vapi.JsonConverters.TransferPlanModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationNumberType))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationNumberTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationNumberType?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationNumberTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationSipType))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationSipTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransferDestinationSipType?))
                {
                    return new global::Vapi.JsonConverters.TransferDestinationSipTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTransferCallToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateTransferCallToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTransferCallToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateTransferCallToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanLastNMessagesType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanLastNMessagesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanNoneType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanNoneTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanAllType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanAllTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanUserAndAssistantMessagesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanUserAndAssistantMessagesType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanUserAndAssistantMessagesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanPreviousAssistantMessagesTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ContextEngineeringPlanPreviousAssistantMessagesType?))
                {
                    return new global::Vapi.JsonConverters.ContextEngineeringPlanPreviousAssistantMessagesTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode?))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineType))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanStayOnLineType?))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanVerbalFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalFirstMessageMode?))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanVerbalFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalType))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanVerbalTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RecordingConsentPlanVerbalType?))
                {
                    return new global::Vapi.JsonConverters.RecordingConsentPlanVerbalTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SecurityFilterPlanMode))
                {
                    return new global::Vapi.JsonConverters.SecurityFilterPlanModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SecurityFilterPlanMode?))
                {
                    return new global::Vapi.JsonConverters.SecurityFilterPlanModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType))
                {
                    return new global::Vapi.JsonConverters.CompliancePlanRecordingConsentPlanDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType?))
                {
                    return new global::Vapi.JsonConverters.CompliancePlanRecordingConsentPlanDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SuccessEvaluationPlanRubric))
                {
                    return new global::Vapi.JsonConverters.SuccessEvaluationPlanRubricJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SuccessEvaluationPlanRubric?))
                {
                    return new global::Vapi.JsonConverters.SuccessEvaluationPlanRubricNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinMessagesConditionType))
                {
                    return new global::Vapi.JsonConverters.MinMessagesConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinMessagesConditionType?))
                {
                    return new global::Vapi.JsonConverters.MinMessagesConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinCallDurationConditionType))
                {
                    return new global::Vapi.JsonConverters.MinCallDurationConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinCallDurationConditionType?))
                {
                    return new global::Vapi.JsonConverters.MinCallDurationConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionType))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionType?))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator?))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ArtifactPlanRecordingFormat))
                {
                    return new global::Vapi.JsonConverters.ArtifactPlanRecordingFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ArtifactPlanRecordingFormat?))
                {
                    return new global::Vapi.JsonConverters.ArtifactPlanRecordingFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KeypadInputPlanDelimiters))
                {
                    return new global::Vapi.JsonConverters.KeypadInputPlanDelimitersJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KeypadInputPlanDelimiters?))
                {
                    return new global::Vapi.JsonConverters.KeypadInputPlanDelimitersNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOFirstMessageMode))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOFirstMessageMode?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOVoicemailDetection))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOVoicemailDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOVoicemailDetection?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOVoicemailDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOClientMessage))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOClientMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOClientMessage?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOClientMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOServerMessage))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOServerMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOServerMessage?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOServerMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOBackgroundSound))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOBackgroundSoundJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOBackgroundSound?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOBackgroundSoundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOCredentialDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransientAssistantDTOCredentialDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.TransientAssistantDTOCredentialDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesFirstMessageMode))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesFirstMessageModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesFirstMessageMode?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesFirstMessageModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesVoicemailDetection))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesVoicemailDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesVoicemailDetection?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesVoicemailDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesClientMessage))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesClientMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesClientMessage?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesClientMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesServerMessage))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesServerMessageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesServerMessage?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesServerMessageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesBackgroundSound))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesBackgroundSoundJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesBackgroundSound?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesBackgroundSoundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesCredentialDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantOverridesCredentialDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.AssistantOverridesCredentialDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationAssistantType))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationAssistantTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationAssistantType?))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationAssistantTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationDynamicType))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationDynamicTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationDynamicType?))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationDynamicTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationSquadType))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationSquadTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HandoffDestinationSquadType?))
                {
                    return new global::Vapi.JsonConverters.HandoffDestinationSquadTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateHandoffToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateHandoffToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateHandoffToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateHandoffToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCustomKnowledgeBaseDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomKnowledgeBaseDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCustomKnowledgeBaseDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KnowledgeBaseProvider))
                {
                    return new global::Vapi.JsonConverters.KnowledgeBaseProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KnowledgeBaseProvider?))
                {
                    return new global::Vapi.JsonConverters.KnowledgeBaseProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KnowledgeBaseModel))
                {
                    return new global::Vapi.JsonConverters.KnowledgeBaseModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.KnowledgeBaseModel?))
                {
                    return new global::Vapi.JsonConverters.KnowledgeBaseModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateQueryToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateQueryToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateQueryToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateQueryToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarCreateEventToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCreateEventToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarCreateEventToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleSheetsRowAppendToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleSheetsRowAppendToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleSheetsRowAppendToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarCheckAvailabilityToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarCheckAvailabilityToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarCheckAvailabilityToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackSendMessageToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateSlackSendMessageToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackSendMessageToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateSlackSendMessageToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.McpToolMetadataProtocol))
                {
                    return new global::Vapi.JsonConverters.McpToolMetadataProtocolJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.McpToolMetadataProtocol?))
                {
                    return new global::Vapi.JsonConverters.McpToolMetadataProtocolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMcpToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateMcpToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMcpToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateMcpToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCalendarAvailabilityToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarAvailabilityToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCalendarAvailabilityToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCalendarEventCreateToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCalendarEventCreateToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCalendarEventCreateToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelContactCreateToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactCreateToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelContactCreateToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelContactGetToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelContactGetToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelContactGetToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIMessageRole))
                {
                    return new global::Vapi.JsonConverters.OpenAIMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIMessageRole?))
                {
                    return new global::Vapi.JsonConverters.OpenAIMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnyscaleModelProvider))
                {
                    return new global::Vapi.JsonConverters.AnyscaleModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnyscaleModelProvider?))
                {
                    return new global::Vapi.JsonConverters.AnyscaleModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType))
                {
                    return new global::Vapi.JsonConverters.AnthropicThinkingConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType?))
                {
                    return new global::Vapi.JsonConverters.AnthropicThinkingConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelModel))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelModel?))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelReasoningEffort))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelReasoningEffort?))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelProvider))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicModelProvider?))
                {
                    return new global::Vapi.JsonConverters.AnthropicModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelProvider))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelProvider?))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelModel))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelModel?))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelFallbackModel))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelFallbackModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelFallbackModel?))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelFallbackModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelReasoningEffort))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicBedrockModelReasoningEffort?))
                {
                    return new global::Vapi.JsonConverters.AnthropicBedrockModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CerebrasModelModel))
                {
                    return new global::Vapi.JsonConverters.CerebrasModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CerebrasModelModel?))
                {
                    return new global::Vapi.JsonConverters.CerebrasModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CerebrasModelProvider))
                {
                    return new global::Vapi.JsonConverters.CerebrasModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CerebrasModelProvider?))
                {
                    return new global::Vapi.JsonConverters.CerebrasModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomLLMModelProvider))
                {
                    return new global::Vapi.JsonConverters.CustomLLMModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomLLMModelProvider?))
                {
                    return new global::Vapi.JsonConverters.CustomLLMModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomLLMModelMetadataSendMode))
                {
                    return new global::Vapi.JsonConverters.CustomLLMModelMetadataSendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomLLMModelMetadataSendMode?))
                {
                    return new global::Vapi.JsonConverters.CustomLLMModelMetadataSendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepInfraModelProvider))
                {
                    return new global::Vapi.JsonConverters.DeepInfraModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepInfraModelProvider?))
                {
                    return new global::Vapi.JsonConverters.DeepInfraModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepSeekModelModel))
                {
                    return new global::Vapi.JsonConverters.DeepSeekModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepSeekModelModel?))
                {
                    return new global::Vapi.JsonConverters.DeepSeekModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepSeekModelProvider))
                {
                    return new global::Vapi.JsonConverters.DeepSeekModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepSeekModelProvider?))
                {
                    return new global::Vapi.JsonConverters.DeepSeekModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName))
                {
                    return new global::Vapi.JsonConverters.GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName?))
                {
                    return new global::Vapi.JsonConverters.GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleModelModel))
                {
                    return new global::Vapi.JsonConverters.GoogleModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleModelModel?))
                {
                    return new global::Vapi.JsonConverters.GoogleModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleModelProvider))
                {
                    return new global::Vapi.JsonConverters.GoogleModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleModelProvider?))
                {
                    return new global::Vapi.JsonConverters.GoogleModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroqModelModel))
                {
                    return new global::Vapi.JsonConverters.GroqModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroqModelModel?))
                {
                    return new global::Vapi.JsonConverters.GroqModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroqModelProvider))
                {
                    return new global::Vapi.JsonConverters.GroqModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GroqModelProvider?))
                {
                    return new global::Vapi.JsonConverters.GroqModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InflectionAIModelModel))
                {
                    return new global::Vapi.JsonConverters.InflectionAIModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InflectionAIModelModel?))
                {
                    return new global::Vapi.JsonConverters.InflectionAIModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InflectionAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.InflectionAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InflectionAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.InflectionAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxLLMModelProvider))
                {
                    return new global::Vapi.JsonConverters.MinimaxLLMModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxLLMModelProvider?))
                {
                    return new global::Vapi.JsonConverters.MinimaxLLMModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxLLMModelModel))
                {
                    return new global::Vapi.JsonConverters.MinimaxLLMModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxLLMModelModel?))
                {
                    return new global::Vapi.JsonConverters.MinimaxLLMModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAISpeakerPersonalityPack))
                {
                    return new global::Vapi.JsonConverters.OpenAISpeakerPersonalityPackJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAISpeakerPersonalityPack?))
                {
                    return new global::Vapi.JsonConverters.OpenAISpeakerPersonalityPackNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerProvider))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerModel))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerModel?))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerReasoningEffort))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIReasonerReasoningEffort?))
                {
                    return new global::Vapi.JsonConverters.OpenAIReasonerReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelModel))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelModel?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelFallbackModel))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelFallbackModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelFallbackModel?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelFallbackModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelToolStrictCompatibilityModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelToolStrictCompatibilityMode?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelToolStrictCompatibilityModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelPromptCacheRetention))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelPromptCacheRetentionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelPromptCacheRetention?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelPromptCacheRetentionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelServiceTier))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelServiceTierJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelServiceTier?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelServiceTierNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelReasoningEffort))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIModelReasoningEffort?))
                {
                    return new global::Vapi.JsonConverters.OpenAIModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenRouterModelProvider))
                {
                    return new global::Vapi.JsonConverters.OpenRouterModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenRouterModelProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenRouterModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PerplexityAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.PerplexityAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PerplexityAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.PerplexityAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TogetherAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.TogetherAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TogetherAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.TogetherAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelReasoningEffort?))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ConversationNodeType))
                {
                    return new global::Vapi.JsonConverters.ConversationNodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ConversationNodeType?))
                {
                    return new global::Vapi.JsonConverters.ConversationNodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolNodeType))
                {
                    return new global::Vapi.JsonConverters.ToolNodeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolNodeType?))
                {
                    return new global::Vapi.JsonConverters.ToolNodeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider))
                {
                    return new global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanType))
                {
                    return new global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GoogleVoicemailDetectionPlanType?))
                {
                    return new global::Vapi.JsonConverters.GoogleVoicemailDetectionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanType))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoicemailDetectionPlanType?))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoicemailDetectionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider))
                {
                    return new global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType))
                {
                    return new global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanVoicemailDetectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TwilioVoicemailDetectionPlanVoicemailDetectionType?))
                {
                    return new global::Vapi.JsonConverters.TwilioVoicemailDetectionPlanVoicemailDetectionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanProvider))
                {
                    return new global::Vapi.JsonConverters.VapiVoicemailDetectionPlanProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiVoicemailDetectionPlanProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanType))
                {
                    return new global::Vapi.JsonConverters.VapiVoicemailDetectionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoicemailDetectionPlanType?))
                {
                    return new global::Vapi.JsonConverters.VapiVoicemailDetectionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SayHookActionType))
                {
                    return new global::Vapi.JsonConverters.SayHookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SayHookActionType?))
                {
                    return new global::Vapi.JsonConverters.SayHookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MessageAddHookActionType))
                {
                    return new global::Vapi.JsonConverters.MessageAddHookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MessageAddHookActionType?))
                {
                    return new global::Vapi.JsonConverters.MessageAddHookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookFilterType))
                {
                    return new global::Vapi.JsonConverters.CallHookFilterTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookFilterType?))
                {
                    return new global::Vapi.JsonConverters.CallHookFilterTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookCallEndingOn))
                {
                    return new global::Vapi.JsonConverters.CallHookCallEndingOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookCallEndingOn?))
                {
                    return new global::Vapi.JsonConverters.CallHookCallEndingOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn))
                {
                    return new global::Vapi.JsonConverters.CallHookAssistantSpeechInterruptedOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookAssistantSpeechInterruptedOn?))
                {
                    return new global::Vapi.JsonConverters.CallHookAssistantSpeechInterruptedOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn))
                {
                    return new global::Vapi.JsonConverters.CallHookCustomerSpeechInterruptedOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookCustomerSpeechInterruptedOn?))
                {
                    return new global::Vapi.JsonConverters.CallHookCustomerSpeechInterruptedOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolCallHookActionType))
                {
                    return new global::Vapi.JsonConverters.ToolCallHookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolCallHookActionType?))
                {
                    return new global::Vapi.JsonConverters.ToolCallHookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode))
                {
                    return new global::Vapi.JsonConverters.CustomerSpeechTimeoutOptionsTriggerResetModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomerSpeechTimeoutOptionsTriggerResetMode?))
                {
                    return new global::Vapi.JsonConverters.CustomerSpeechTimeoutOptionsTriggerResetModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookModelResponseTimeoutOn))
                {
                    return new global::Vapi.JsonConverters.CallHookModelResponseTimeoutOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CallHookModelResponseTimeoutOn?))
                {
                    return new global::Vapi.JsonConverters.CallHookModelResponseTimeoutOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AIEdgeConditionType))
                {
                    return new global::Vapi.JsonConverters.AIEdgeConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AIEdgeConditionType?))
                {
                    return new global::Vapi.JsonConverters.AIEdgeConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableBackgroundSound))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableBackgroundSoundJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableBackgroundSound?))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableBackgroundSoundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableCredentialDiscriminatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableCredentialDiscriminatorProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableCredentialDiscriminatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableVoicemailDetection))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableVoicemailDetectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowUserEditableVoicemailDetection?))
                {
                    return new global::Vapi.JsonConverters.WorkflowUserEditableVoicemailDetectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiModelVersion))
                {
                    return new global::Vapi.JsonConverters.VapiModelVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiModelVersion?))
                {
                    return new global::Vapi.JsonConverters.VapiModelVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiModelProvider))
                {
                    return new global::Vapi.JsonConverters.VapiModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiModelProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiModelModel))
                {
                    return new global::Vapi.JsonConverters.XaiModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiModelModel?))
                {
                    return new global::Vapi.JsonConverters.XaiModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiModelProvider))
                {
                    return new global::Vapi.JsonConverters.XaiModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiModelProvider?))
                {
                    return new global::Vapi.JsonConverters.XaiModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ExactReplacementType))
                {
                    return new global::Vapi.JsonConverters.ExactReplacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ExactReplacementType?))
                {
                    return new global::Vapi.JsonConverters.ExactReplacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexReplacementType))
                {
                    return new global::Vapi.JsonConverters.RegexReplacementTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RegexReplacementType?))
                {
                    return new global::Vapi.JsonConverters.RegexReplacementTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FormatPlanFormattersEnabledItem))
                {
                    return new global::Vapi.JsonConverters.FormatPlanFormattersEnabledItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FormatPlanFormattersEnabledItem?))
                {
                    return new global::Vapi.JsonConverters.FormatPlanFormattersEnabledItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ChunkPlanPunctuationBoundarie))
                {
                    return new global::Vapi.JsonConverters.ChunkPlanPunctuationBoundarieJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ChunkPlanPunctuationBoundarie?))
                {
                    return new global::Vapi.JsonConverters.ChunkPlanPunctuationBoundarieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.AzureVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.AzureVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.AzureVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AzureVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.AzureVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsSpeed))
                {
                    return new global::Vapi.JsonConverters.CartesiaExperimentalControlsSpeedJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsSpeed?))
                {
                    return new global::Vapi.JsonConverters.CartesiaExperimentalControlsSpeedNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsEmotion))
                {
                    return new global::Vapi.JsonConverters.CartesiaExperimentalControlsEmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaExperimentalControlsEmotion?))
                {
                    return new global::Vapi.JsonConverters.CartesiaExperimentalControlsEmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceModel))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CartesiaVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.CartesiaVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.CustomVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CustomVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.CustomVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceModel))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeepgramVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.DeepgramVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceModel))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ElevenLabsVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.ElevenLabsVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WellSaidVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.WellSaidVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WellSaidVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.WellSaidVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WellSaidVoiceModel))
                {
                    return new global::Vapi.JsonConverters.WellSaidVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WellSaidVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.WellSaidVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HumeVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.HumeVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HumeVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.HumeVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HumeVoiceModel))
                {
                    return new global::Vapi.JsonConverters.HumeVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HumeVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.HumeVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.LMNTVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.LMNTVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NeuphonicVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.NeuphonicVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NeuphonicVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.NeuphonicVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NeuphonicVoiceModel))
                {
                    return new global::Vapi.JsonConverters.NeuphonicVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NeuphonicVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.NeuphonicVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.OpenAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceEmotion))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceEmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceEmotion?))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceEmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceModel))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PlayHTVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.PlayHTVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.RimeAIVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.RimeAIVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SesameVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.SesameVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SesameVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.SesameVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SesameVoiceModel))
                {
                    return new global::Vapi.JsonConverters.SesameVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SesameVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.SesameVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SmallestAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.SmallestAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider))
                {
                    return new global::Vapi.JsonConverters.VapiPronunciationDictionaryLocatorProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiPronunciationDictionaryLocatorProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiPronunciationDictionaryLocatorProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceVersion2))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceVersion2?))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceVersion2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.VapiVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.VapiVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceModel))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceLanguageCode))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceLanguageCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.InworldVoiceLanguageCode?))
                {
                    return new global::Vapi.JsonConverters.InworldVoiceLanguageCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceModel))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceSubtitleType))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceSubtitleTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceSubtitleType?))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceSubtitleTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceRegion))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceRegion?))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceLanguageBoost))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinimaxVoiceLanguageBoost?))
                {
                    return new global::Vapi.JsonConverters.MinimaxVoiceLanguageBoostNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackWellSaidVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackWellSaidVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackWellSaidVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackWellSaidVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackWellSaidVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.XaiVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.XaiVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceStyle))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceStyle?))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceRole))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MicrosoftVoiceRole?))
                {
                    return new global::Vapi.JsonConverters.MicrosoftVoiceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackAzureVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackAzureVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCartesiaVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackCartesiaVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCustomVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackCustomVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackCustomVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackCustomVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackDeepgramVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackDeepgramVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackElevenLabsVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackElevenLabsVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackHumeVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackHumeVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackHumeVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackHumeVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackHumeVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackHumeVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackHumeVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackHumeVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackLMNTVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackLMNTVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackNeuphonicVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackNeuphonicVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackNeuphonicVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackNeuphonicVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackNeuphonicVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackOpenAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackOpenAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceEmotion))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceEmotionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceEmotion?))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceEmotionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackPlayHTVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackPlayHTVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackRimeAIVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackRimeAIVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSesameVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackSesameVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSesameVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackSesameVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSesameVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackSesameVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSesameVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackSesameVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackSmallestAIVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackSmallestAIVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceVersion2))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceVersion2JsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceVersion2?))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceVersion2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackVapiVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackVapiVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceModel))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceModel?))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceLanguageCode))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceLanguageCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackInworldVoiceLanguageCode?))
                {
                    return new global::Vapi.JsonConverters.FallbackInworldVoiceLanguageCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceLanguage))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceLanguageJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackXaiVoiceLanguage?))
                {
                    return new global::Vapi.JsonConverters.FallbackXaiVoiceLanguageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceProvider))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceProvider?))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceVoiceIdJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceVoiceId?))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceVoiceIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceStyle))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceStyle?))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceRole))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.FallbackMicrosoftVoiceRole?))
                {
                    return new global::Vapi.JsonConverters.FallbackMicrosoftVoiceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioProvider))
                {
                    return new global::Vapi.JsonConverters.TransportConfigurationTwilioProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioProvider?))
                {
                    return new global::Vapi.JsonConverters.TransportConfigurationTwilioProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels))
                {
                    return new global::Vapi.JsonConverters.TransportConfigurationTwilioRecordingChannelsJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TransportConfigurationTwilioRecordingChannels?))
                {
                    return new global::Vapi.JsonConverters.TransportConfigurationTwilioRecordingChannelsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTORegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnthropicBedrockCredentialDTORegion?))
                {
                    return new global::Vapi.JsonConverters.CreateAnthropicBedrockCredentialDTORegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAnyscaleCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAnyscaleCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAnyscaleCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAssemblyAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAssemblyAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAssemblyAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOService))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTOServiceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTOService?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTOServiceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTORegion))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTORegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureCredentialDTORegion?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureCredentialDTORegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTORegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTORegion?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTORegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateAzureOpenAICredentialDTOModel?))
                {
                    return new global::Vapi.JsonConverters.CreateAzureOpenAICredentialDTOModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SipTrunkGatewayOutboundProtocol))
                {
                    return new global::Vapi.JsonConverters.SipTrunkGatewayOutboundProtocolJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SipTrunkGatewayOutboundProtocol?))
                {
                    return new global::Vapi.JsonConverters.SipTrunkGatewayOutboundProtocolNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateByoSipTrunkCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateByoSipTrunkCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateByoSipTrunkCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCartesiaCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCartesiaCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCartesiaCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCartesiaCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCloudflareCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCloudflareCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCloudflareCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCloudflareCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OAuth2AuthenticationPlanType))
                {
                    return new global::Vapi.JsonConverters.OAuth2AuthenticationPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OAuth2AuthenticationPlanType?))
                {
                    return new global::Vapi.JsonConverters.OAuth2AuthenticationPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCustomLLMCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomLLMCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCustomLLMCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepgramCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateDeepgramCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepgramCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateDeepgramCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateDeepInfraCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepInfraCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateDeepInfraCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateDeepSeekCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateDeepSeekCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateDeepSeekCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl))
                {
                    return new global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOApiUrlJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateElevenLabsCredentialDTOApiUrl?))
                {
                    return new global::Vapi.JsonConverters.CreateElevenLabsCredentialDTOApiUrlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGcpCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGcpCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGcpCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGcpCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGladiaCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGladiaCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGladiaCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGladiaCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGroqCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGroqCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGroqCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGroqCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateLangfuseCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateLangfuseCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateLangfuseCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateLangfuseCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateLmntCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateLmntCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateLmntCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateLmntCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMakeCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateMakeCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMakeCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateMakeCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateOpenAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateOpenAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateOpenAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateOpenAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateOpenRouterCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateOpenRouterCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateOpenRouterCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreatePerplexityAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreatePerplexityAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreatePerplexityAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreatePlayHTCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreatePlayHTCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreatePlayHTCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreatePlayHTCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateRimeAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateRimeAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateRimeAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateRimeAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateRunpodCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateRunpodCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateRunpodCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateRunpodCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateS3CredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateS3CredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateS3CredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateS3CredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SupabaseBucketPlanRegion))
                {
                    return new global::Vapi.JsonConverters.SupabaseBucketPlanRegionJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SupabaseBucketPlanRegion?))
                {
                    return new global::Vapi.JsonConverters.SupabaseBucketPlanRegionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSupabaseCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSupabaseCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSupabaseCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSupabaseCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSmallestAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSmallestAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSmallestAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSmallestAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTavusCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateTavusCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTavusCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateTavusCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTogetherAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateTogetherAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTogetherAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateTogetherAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTwilioCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateTwilioCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTwilioCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateTwilioCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVonageCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateVonageCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateVonageCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateVonageCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateWebhookCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateWebhookCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType))
                {
                    return new global::Vapi.JsonConverters.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorType?))
                {
                    return new global::Vapi.JsonConverters.CreateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateXAiCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateXAiCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateXAiCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateXAiCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2ClientCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2ClientCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCalendarOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSlackOAuth2AuthorizationCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSlackOAuth2AuthorizationCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMinimaxCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateMinimaxCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMinimaxCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateMinimaxCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SessionCreatedHookOn))
                {
                    return new global::Vapi.JsonConverters.SessionCreatedHookOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SessionCreatedHookOn?))
                {
                    return new global::Vapi.JsonConverters.SessionCreatedHookOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UserMessageConfidenceSource))
                {
                    return new global::Vapi.JsonConverters.UserMessageConfidenceSourceJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UserMessageConfidenceSource?))
                {
                    return new global::Vapi.JsonConverters.UserMessageConfidenceSourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeveloperMessageRole))
                {
                    return new global::Vapi.JsonConverters.DeveloperMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.DeveloperMessageRole?))
                {
                    return new global::Vapi.JsonConverters.DeveloperMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantMessageRole))
                {
                    return new global::Vapi.JsonConverters.AssistantMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AssistantMessageRole?))
                {
                    return new global::Vapi.JsonConverters.AssistantMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageRole))
                {
                    return new global::Vapi.JsonConverters.ToolMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ToolMessageRole?))
                {
                    return new global::Vapi.JsonConverters.ToolMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateApiRequestToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateApiRequestToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOMethod))
                {
                    return new global::Vapi.JsonConverters.CreateApiRequestToolDTOMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateApiRequestToolDTOMethod?))
                {
                    return new global::Vapi.JsonConverters.CreateApiRequestToolDTOMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCodeToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateCodeToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCodeToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateCodeToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOSubType))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTOSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOSubType?))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTOSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOName))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTONameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateBashToolDTOName?))
                {
                    return new global::Vapi.JsonConverters.CreateBashToolDTONameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOSubType))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTOSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOSubType?))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTOSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOName))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTONameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateComputerToolDTOName?))
                {
                    return new global::Vapi.JsonConverters.CreateComputerToolDTONameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOSubType))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTOSubTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOSubType?))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTOSubTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOName))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTONameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTextEditorToolDTOName?))
                {
                    return new global::Vapi.JsonConverters.CreateTextEditorToolDTONameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSmsToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateSmsToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSmsToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateSmsToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateSipRequestToolDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateSipRequestToolDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOVerb))
                {
                    return new global::Vapi.JsonConverters.CreateSipRequestToolDTOVerbJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSipRequestToolDTOVerb?))
                {
                    return new global::Vapi.JsonConverters.CreateSipRequestToolDTOVerbNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityInUseConflictResponseDTOError))
                {
                    return new global::Vapi.JsonConverters.PersonalityInUseConflictResponseDTOErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityInUseConflictResponseDTOError?))
                {
                    return new global::Vapi.JsonConverters.PersonalityInUseConflictResponseDTOErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpkiPemPublicKeyConfigFormat))
                {
                    return new global::Vapi.JsonConverters.SpkiPemPublicKeyConfigFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SpkiPemPublicKeyConfigFormat?))
                {
                    return new global::Vapi.JsonConverters.SpkiPemPublicKeyConfigFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanType))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanType?))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanAlgorithm?))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat?))
                {
                    return new global::Vapi.JsonConverters.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCerebrasCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCerebrasCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCerebrasCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCerebrasCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoogleCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoogleCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateHumeCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateHumeCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateHumeCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateHumeCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateInflectionAICredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateInflectionAICredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateInflectionAICredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateInflectionAICredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateMicrosoftCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMicrosoftCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateMicrosoftCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMistralCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateMistralCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateMistralCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateMistralCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateNeuphonicCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateNeuphonicCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateNeuphonicCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWellSaidCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateWellSaidCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateWellSaidCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateWellSaidCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateS3CompatibleCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateS3CompatibleCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateS3CompatibleCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSonioxCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSonioxCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSonioxCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSonioxCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSpeechmaticsCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSpeechmaticsCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSpeechmaticsCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType?))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOEncryptionPlanDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType?))
                {
                    return new global::Vapi.JsonConverters.CreateCustomCredentialDTOEncryptionPlanDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelMCPCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateGoHighLevelMCPCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateInworldCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateInworldCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateInworldCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateInworldCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateEmailCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateEmailCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateEmailCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateEmailCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider))
                {
                    return new global::Vapi.JsonConverters.CreateSlackWebhookCredentialDTOProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateSlackWebhookCredentialDTOProvider?))
                {
                    return new global::Vapi.JsonConverters.CreateSlackWebhookCredentialDTOProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanType))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanType?))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanAlgorithm))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanAlgorithm?))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanSignatureEncodingJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.HMACAuthenticationPlanSignatureEncoding?))
                {
                    return new global::Vapi.JsonConverters.HMACAuthenticationPlanSignatureEncodingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BearerAuthenticationPlanType))
                {
                    return new global::Vapi.JsonConverters.BearerAuthenticationPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BearerAuthenticationPlanType?))
                {
                    return new global::Vapi.JsonConverters.BearerAuthenticationPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType))
                {
                    return new global::Vapi.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AWSIAMCredentialsAuthenticationPlanType?))
                {
                    return new global::Vapi.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AWSStsAuthenticationPlanType))
                {
                    return new global::Vapi.JsonConverters.AWSStsAuthenticationPlanTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AWSStsAuthenticationPlanType?))
                {
                    return new global::Vapi.JsonConverters.AWSStsAuthenticationPlanTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortOrder))
                {
                    return new global::Vapi.JsonConverters.PersonalityControllerFindAllSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PersonalityControllerFindAllSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortBy))
                {
                    return new global::Vapi.JsonConverters.PersonalityControllerFindAllSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PersonalityControllerFindAllSortBy?))
                {
                    return new global::Vapi.JsonConverters.PersonalityControllerFindAllSortByNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[4];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SimulationPersonalitiesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SimulationPersonalitiesSourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),

                    2 => new SimulationPersonalitiesSourceGenerationContextChunk2(new global::System.Text.Json.JsonSerializerOptions()),

                    3 => new SimulationPersonalitiesSourceGenerationContextChunk3(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}