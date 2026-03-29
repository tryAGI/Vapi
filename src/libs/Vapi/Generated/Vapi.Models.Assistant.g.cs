
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Assistant
    {
        /// <summary>
        /// These are the options for the assistant's transcriber.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>))]
        public global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? Transcriber { get; set; }

        /// <summary>
        /// These are the options for the assistant's LLM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>))]
        public global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>? Model { get; set; }

        /// <summary>
        /// These are the options for the assistant's voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>))]
        public global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// This is the first message that the assistant will say. This can also be a URL to a containerized audio file (mp3, wav, etc.).<br/>
        /// If unspecified, assistant will wait for user to speak and use the model to respond once they speak.<br/>
        /// Example: Hello! How can I help you today?
        /// </summary>
        /// <example>Hello! How can I help you today?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessage")]
        public string? FirstMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessageInterruptionsEnabled")]
        public bool? FirstMessageInterruptionsEnabled { get; set; }

        /// <summary>
        /// This is the mode for the first message. Default is 'assistant-speaks-first'.<br/>
        /// Use:<br/>
        /// - 'assistant-speaks-first' to have the assistant speak first.<br/>
        /// - 'assistant-waits-for-user' to have the assistant wait for the user to speak first.<br/>
        /// - 'assistant-speaks-first-with-model-generated-message' to have the assistant speak first with a message generated by the model based on the conversation state. (`assistant.model.messages` at call start, `call.messages` at squad transfer points).<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Example: assistant-speaks-first
        /// </summary>
        /// <example>assistant-speaks-first</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessageMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AssistantFirstMessageModeJsonConverter))]
        public global::Vapi.AssistantFirstMessageMode? FirstMessageMode { get; set; }

        /// <summary>
        /// These are the settings to configure or disable voicemail detection. Alternatively, voicemail detection can be configured using the model.tools=[VoicemailTool].<br/>
        /// By default, voicemail detection is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemailDetection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
        public global::Vapi.OneOf<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>? VoicemailDetection { get; set; }

        /// <summary>
        /// These are the messages that will be sent to your Client SDKs. Default is conversation-update,function-call,hang,model-output,speech-update,status-update,transfer-update,transcript,tool-calls,user-interrupted,voice-input,workflow.node.started,assistant.started. You can check the shape of the messages in ClientMessage schema.<br/>
        /// Example: [assistant.started, conversation-update, function-call, hang, model-output, speech-update, status-update, tool-calls, transcript, transfer-update, user-interrupted, voice-input, workflow.node.started]
        /// </summary>
        /// <example>[assistant.started, conversation-update, function-call, hang, model-output, speech-update, status-update, tool-calls, transcript, transfer-update, user-interrupted, voice-input, workflow.node.started]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientMessages")]
        public global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>? ClientMessages { get; set; }

        /// <summary>
        /// These are the messages that will be sent to your Server URL. Default is conversation-update,end-of-call-report,function-call,hang,speech-update,status-update,tool-calls,transfer-destination-request,handoff-destination-request,user-interrupted,assistant.started. You can check the shape of the messages in ServerMessage schema.<br/>
        /// Example: [assistant.started, conversation-update, end-of-call-report, function-call, handoff-destination-request, hang, speech-update, status-update, tool-calls, transfer-destination-request, user-interrupted]
        /// </summary>
        /// <example>[assistant.started, conversation-update, end-of-call-report, function-call, handoff-destination-request, hang, speech-update, status-update, tool-calls, transfer-destination-request, user-interrupted]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverMessages")]
        public global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>? ServerMessages { get; set; }

        /// <summary>
        /// This is the maximum number of seconds that the call will last. When the call reaches this duration, it will be ended.<br/>
        /// @default 600 (10 minutes)<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDurationSeconds")]
        public double? MaxDurationSeconds { get; set; }

        /// <summary>
        /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssistantBackgroundSound?, string>))]
        public global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>? BackgroundSound { get; set; }

        /// <summary>
        /// This determines whether the model's output is used in conversation history rather than the transcription of assistant's speech.<br/>
        /// @default false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelOutputInMessagesEnabled")]
        public bool? ModelOutputInMessagesEnabled { get; set; }

        /// <summary>
        /// These are the configurations to be passed to the transport providers of assistant's calls, like Twilio. You can store multiple configurations for different transport providers. For a call, only the configuration matching the call transport provider is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transportConfigurations")]
        public global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? TransportConfigurations { get; set; }

        /// <summary>
        /// This is the plan for observability of assistant's calls.<br/>
        /// Currently, only Langfuse is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityPlan")]
        public global::Vapi.LangfuseObservabilityPlan? ObservabilityPlan { get; set; }

        /// <summary>
        /// These are dynamic credentials that will be used for the assistant calls. By default, all the credentials are available for use in the call but you can supplement an additional credentials using this. Dynamic credentials override existing credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>? Credentials { get; set; }

        /// <summary>
        /// This is a set of actions that will be performed on certain events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>? Hooks { get; set; }

        /// <summary>
        /// This is the name of the assistant.<br/>
        /// This is required when you want to transfer between assistants in a call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the message that the assistant will say if the call is forwarded to voicemail.<br/>
        /// If unspecified, it will hang up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemailMessage")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// This is the message that the assistant will say if it ends the call.<br/>
        /// If unspecified, it will hang up without saying anything.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCallMessage")]
        public string? EndCallMessage { get; set; }

        /// <summary>
        /// This list contains phrases that, if spoken by the assistant, will trigger the call to be hung up. Case insensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCallPhrases")]
        public global::System.Collections.Generic.IList<string>? EndCallPhrases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliancePlan")]
        public global::Vapi.CompliancePlan? CompliancePlan { get; set; }

        /// <summary>
        /// This is for metadata you want to store on the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Smart denoising can be combined with or used independently of Fourier denoising.<br/>
        /// Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSpeechDenoisingPlan")]
        public global::Vapi.BackgroundSpeechDenoisingPlan? BackgroundSpeechDenoisingPlan { get; set; }

        /// <summary>
        /// This is the plan for analysis of assistant's calls. Stored in `call.analysis`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisPlan")]
        public global::Vapi.AnalysisPlan? AnalysisPlan { get; set; }

        /// <summary>
        /// This is the plan for artifacts generated during assistant's calls. Stored in `call.artifact`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifactPlan")]
        public global::Vapi.ArtifactPlan? ArtifactPlan { get; set; }

        /// <summary>
        /// This is the plan for when the assistant should start talking.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to start talking after the customer is done speaking.<br/>
        /// - The assistant is too fast to start talking after the customer is done speaking.<br/>
        /// - The assistant is so fast that it's actually interrupting the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startSpeakingPlan")]
        public global::Vapi.StartSpeakingPlan? StartSpeakingPlan { get; set; }

        /// <summary>
        /// This is the plan for when assistant should stop talking on customer interruption.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to recognize customer's interruption.<br/>
        /// - The assistant is too fast to recognize customer's interruption.<br/>
        /// - The assistant is getting interrupted by phrases that are just acknowledgments.<br/>
        /// - The assistant is getting interrupted by background noises.<br/>
        /// - The assistant is not properly stopping -- it starts talking right after getting interrupted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopSpeakingPlan")]
        public global::Vapi.StopSpeakingPlan? StopSpeakingPlan { get; set; }

        /// <summary>
        /// This is the plan for real-time monitoring of the assistant's calls.<br/>
        /// Usage:<br/>
        /// - To enable live listening of the assistant's calls, set `monitorPlan.listenEnabled` to `true`.<br/>
        /// - To enable live control of the assistant's calls, set `monitorPlan.controlEnabled` to `true`.<br/>
        /// - To attach monitors to the assistant, set `monitorPlan.monitorIds` to the set of monitor ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitorPlan")]
        public global::Vapi.MonitorPlan? MonitorPlan { get; set; }

        /// <summary>
        /// These are the credentials that will be used for the assistant calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialIds")]
        public global::System.Collections.Generic.IList<string>? CredentialIds { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server.url<br/>
        /// 2. phoneNumber.serverUrl<br/>
        /// 3. org.serverUrl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypadInputPlan")]
        public global::Vapi.KeypadInputPlan? KeypadInputPlan { get; set; }

        /// <summary>
        /// This is the unique identifier for the assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this assistant belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the assistant.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this assistant belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the assistant was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
        /// <param name="transcriber">
        /// These are the options for the assistant's transcriber.
        /// </param>
        /// <param name="model">
        /// These are the options for the assistant's LLM.
        /// </param>
        /// <param name="voice">
        /// These are the options for the assistant's voice.
        /// </param>
        /// <param name="firstMessage">
        /// This is the first message that the assistant will say. This can also be a URL to a containerized audio file (mp3, wav, etc.).<br/>
        /// If unspecified, assistant will wait for user to speak and use the model to respond once they speak.<br/>
        /// Example: Hello! How can I help you today?
        /// </param>
        /// <param name="firstMessageInterruptionsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="firstMessageMode">
        /// This is the mode for the first message. Default is 'assistant-speaks-first'.<br/>
        /// Use:<br/>
        /// - 'assistant-speaks-first' to have the assistant speak first.<br/>
        /// - 'assistant-waits-for-user' to have the assistant wait for the user to speak first.<br/>
        /// - 'assistant-speaks-first-with-model-generated-message' to have the assistant speak first with a message generated by the model based on the conversation state. (`assistant.model.messages` at call start, `call.messages` at squad transfer points).<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Example: assistant-speaks-first
        /// </param>
        /// <param name="voicemailDetection">
        /// These are the settings to configure or disable voicemail detection. Alternatively, voicemail detection can be configured using the model.tools=[VoicemailTool].<br/>
        /// By default, voicemail detection is disabled.
        /// </param>
        /// <param name="clientMessages">
        /// These are the messages that will be sent to your Client SDKs. Default is conversation-update,function-call,hang,model-output,speech-update,status-update,transfer-update,transcript,tool-calls,user-interrupted,voice-input,workflow.node.started,assistant.started. You can check the shape of the messages in ClientMessage schema.<br/>
        /// Example: [assistant.started, conversation-update, function-call, hang, model-output, speech-update, status-update, tool-calls, transcript, transfer-update, user-interrupted, voice-input, workflow.node.started]
        /// </param>
        /// <param name="serverMessages">
        /// These are the messages that will be sent to your Server URL. Default is conversation-update,end-of-call-report,function-call,hang,speech-update,status-update,tool-calls,transfer-destination-request,handoff-destination-request,user-interrupted,assistant.started. You can check the shape of the messages in ServerMessage schema.<br/>
        /// Example: [assistant.started, conversation-update, end-of-call-report, function-call, handoff-destination-request, hang, speech-update, status-update, tool-calls, transfer-destination-request, user-interrupted]
        /// </param>
        /// <param name="maxDurationSeconds">
        /// This is the maximum number of seconds that the call will last. When the call reaches this duration, it will be ended.<br/>
        /// @default 600 (10 minutes)<br/>
        /// Example: 600
        /// </param>
        /// <param name="backgroundSound">
        /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </param>
        /// <param name="modelOutputInMessagesEnabled">
        /// This determines whether the model's output is used in conversation history rather than the transcription of assistant's speech.<br/>
        /// @default false<br/>
        /// Example: false
        /// </param>
        /// <param name="transportConfigurations">
        /// These are the configurations to be passed to the transport providers of assistant's calls, like Twilio. You can store multiple configurations for different transport providers. For a call, only the configuration matching the call transport provider is used.
        /// </param>
        /// <param name="observabilityPlan">
        /// This is the plan for observability of assistant's calls.<br/>
        /// Currently, only Langfuse is supported.
        /// </param>
        /// <param name="credentials">
        /// These are dynamic credentials that will be used for the assistant calls. By default, all the credentials are available for use in the call but you can supplement an additional credentials using this. Dynamic credentials override existing credentials.
        /// </param>
        /// <param name="hooks">
        /// This is a set of actions that will be performed on certain events.
        /// </param>
        /// <param name="name">
        /// This is the name of the assistant.<br/>
        /// This is required when you want to transfer between assistants in a call.
        /// </param>
        /// <param name="voicemailMessage">
        /// This is the message that the assistant will say if the call is forwarded to voicemail.<br/>
        /// If unspecified, it will hang up.
        /// </param>
        /// <param name="endCallMessage">
        /// This is the message that the assistant will say if it ends the call.<br/>
        /// If unspecified, it will hang up without saying anything.
        /// </param>
        /// <param name="endCallPhrases">
        /// This list contains phrases that, if spoken by the assistant, will trigger the call to be hung up. Case insensitive.
        /// </param>
        /// <param name="compliancePlan"></param>
        /// <param name="metadata">
        /// This is for metadata you want to store on the assistant.
        /// </param>
        /// <param name="backgroundSpeechDenoisingPlan">
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Smart denoising can be combined with or used independently of Fourier denoising.<br/>
        /// Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </param>
        /// <param name="artifactPlan">
        /// This is the plan for artifacts generated during assistant's calls. Stored in `call.artifact`.
        /// </param>
        /// <param name="startSpeakingPlan">
        /// This is the plan for when the assistant should start talking.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to start talking after the customer is done speaking.<br/>
        /// - The assistant is too fast to start talking after the customer is done speaking.<br/>
        /// - The assistant is so fast that it's actually interrupting the customer.
        /// </param>
        /// <param name="stopSpeakingPlan">
        /// This is the plan for when assistant should stop talking on customer interruption.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to recognize customer's interruption.<br/>
        /// - The assistant is too fast to recognize customer's interruption.<br/>
        /// - The assistant is getting interrupted by phrases that are just acknowledgments.<br/>
        /// - The assistant is getting interrupted by background noises.<br/>
        /// - The assistant is not properly stopping -- it starts talking right after getting interrupted.
        /// </param>
        /// <param name="monitorPlan">
        /// This is the plan for real-time monitoring of the assistant's calls.<br/>
        /// Usage:<br/>
        /// - To enable live listening of the assistant's calls, set `monitorPlan.listenEnabled` to `true`.<br/>
        /// - To enable live control of the assistant's calls, set `monitorPlan.controlEnabled` to `true`.<br/>
        /// - To attach monitors to the assistant, set `monitorPlan.monitorIds` to the set of monitor ids.
        /// </param>
        /// <param name="credentialIds">
        /// These are the credentials that will be used for the assistant calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
        /// </param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server.url<br/>
        /// 2. phoneNumber.serverUrl<br/>
        /// 3. org.serverUrl
        /// </param>
        /// <param name="keypadInputPlan"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Assistant(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? transcriber,
            global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>? model,
            global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? voice,
            string? firstMessage,
            bool? firstMessageInterruptionsEnabled,
            global::Vapi.AssistantFirstMessageMode? firstMessageMode,
            global::Vapi.OneOf<global::Vapi.AssistantVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>? voicemailDetection,
            global::System.Collections.Generic.IList<global::Vapi.AssistantClientMessage>? clientMessages,
            global::System.Collections.Generic.IList<global::Vapi.AssistantServerMessage>? serverMessages,
            double? maxDurationSeconds,
            global::Vapi.OneOf<global::Vapi.AssistantBackgroundSound?, string>? backgroundSound,
            bool? modelOutputInMessagesEnabled,
            global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? transportConfigurations,
            global::Vapi.LangfuseObservabilityPlan? observabilityPlan,
            global::System.Collections.Generic.IList<global::Vapi.CredentialsItem4>? credentials,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>? hooks,
            string? name,
            string? voicemailMessage,
            string? endCallMessage,
            global::System.Collections.Generic.IList<string>? endCallPhrases,
            global::Vapi.CompliancePlan? compliancePlan,
            object? metadata,
            global::Vapi.BackgroundSpeechDenoisingPlan? backgroundSpeechDenoisingPlan,
            global::Vapi.ArtifactPlan? artifactPlan,
            global::Vapi.StartSpeakingPlan? startSpeakingPlan,
            global::Vapi.StopSpeakingPlan? stopSpeakingPlan,
            global::Vapi.MonitorPlan? monitorPlan,
            global::System.Collections.Generic.IList<string>? credentialIds,
            global::Vapi.Server? server,
            global::Vapi.KeypadInputPlan? keypadInputPlan)
        {
            this.Transcriber = transcriber;
            this.Model = model;
            this.Voice = voice;
            this.FirstMessage = firstMessage;
            this.FirstMessageInterruptionsEnabled = firstMessageInterruptionsEnabled;
            this.FirstMessageMode = firstMessageMode;
            this.VoicemailDetection = voicemailDetection;
            this.ClientMessages = clientMessages;
            this.ServerMessages = serverMessages;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.BackgroundSound = backgroundSound;
            this.ModelOutputInMessagesEnabled = modelOutputInMessagesEnabled;
            this.TransportConfigurations = transportConfigurations;
            this.ObservabilityPlan = observabilityPlan;
            this.Credentials = credentials;
            this.Hooks = hooks;
            this.Name = name;
            this.VoicemailMessage = voicemailMessage;
            this.EndCallMessage = endCallMessage;
            this.EndCallPhrases = endCallPhrases;
            this.CompliancePlan = compliancePlan;
            this.Metadata = metadata;
            this.BackgroundSpeechDenoisingPlan = backgroundSpeechDenoisingPlan;
            this.ArtifactPlan = artifactPlan;
            this.StartSpeakingPlan = startSpeakingPlan;
            this.StopSpeakingPlan = stopSpeakingPlan;
            this.MonitorPlan = monitorPlan;
            this.CredentialIds = credentialIds;
            this.Server = server;
            this.KeypadInputPlan = keypadInputPlan;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Assistant" /> class.
        /// </summary>
        public Assistant()
        {
        }
    }
}