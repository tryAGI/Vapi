
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkflowDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>> Nodes { get; set; }

        /// <summary>
        /// This is the model for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>))]
        public global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>? Model { get; set; }

        /// <summary>
        /// This is the transcriber for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].transcriber`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>))]
        public global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? Transcriber { get; set; }

        /// <summary>
        /// This is the voice for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].voice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>))]
        public global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// This is the plan for observability of workflow's calls.<br/>
        /// Currently, only Langfuse is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observabilityPlan")]
        public global::Vapi.LangfuseObservabilityPlan? ObservabilityPlan { get; set; }

        /// <summary>
        /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSound")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>))]
        public global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>? BackgroundSound { get; set; }

        /// <summary>
        /// This is a set of actions that will be performed on certain events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>? Hooks { get; set; }

        /// <summary>
        /// These are dynamic credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can supplement an additional credentials using this. Dynamic credentials override existing credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>? Credentials { get; set; }

        /// <summary>
        /// This is the voicemail detection plan for the workflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemailDetection")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>))]
        public global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>? VoicemailDetection { get; set; }

        /// <summary>
        /// This is the maximum duration of the call in seconds.<br/>
        /// After this duration, the call will automatically end.<br/>
        /// Default is 1800 (30 minutes), max is 43200 (12 hours), and min is 10 seconds.<br/>
        /// Example: 600
        /// </summary>
        /// <example>600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDurationSeconds")]
        public double? MaxDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.Edge> Edges { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("globalPrompt")]
        public string? GlobalPrompt { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. tool.server<br/>
        /// 2. workflow.server / assistant.server<br/>
        /// 3. phoneNumber.server<br/>
        /// 4. org.server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// This is the compliance plan for the workflow. It allows you to configure HIPAA and other compliance settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliancePlan")]
        public global::Vapi.CompliancePlan? CompliancePlan { get; set; }

        /// <summary>
        /// This is the plan for analysis of workflow's calls. Stored in `call.analysis`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysisPlan")]
        public global::Vapi.AnalysisPlan? AnalysisPlan { get; set; }

        /// <summary>
        /// This is the plan for artifacts generated during workflow's calls. Stored in `call.artifact`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifactPlan")]
        public global::Vapi.ArtifactPlan? ArtifactPlan { get; set; }

        /// <summary>
        /// This is the plan for when the workflow nodes should start talking.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to start talking after the customer is done speaking.<br/>
        /// - The assistant is too fast to start talking after the customer is done speaking.<br/>
        /// - The assistant is so fast that it's actually interrupting the customer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startSpeakingPlan")]
        public global::Vapi.StartSpeakingPlan? StartSpeakingPlan { get; set; }

        /// <summary>
        /// This is the plan for when workflow nodes should stop talking on customer interruption.<br/>
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
        /// This is the plan for real-time monitoring of the workflow's calls.<br/>
        /// Usage:<br/>
        /// - To enable live listening of the workflow's calls, set `monitorPlan.listenEnabled` to `true`.<br/>
        /// - To enable live control of the workflow's calls, set `monitorPlan.controlEnabled` to `true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitorPlan")]
        public global::Vapi.MonitorPlan? MonitorPlan { get; set; }

        /// <summary>
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Both can be used together. Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backgroundSpeechDenoisingPlan")]
        public global::Vapi.BackgroundSpeechDenoisingPlan? BackgroundSpeechDenoisingPlan { get; set; }

        /// <summary>
        /// These are the credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialIds")]
        public global::System.Collections.Generic.IList<string>? CredentialIds { get; set; }

        /// <summary>
        /// This is the plan for keypad input handling during workflow calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keypadInputPlan")]
        public global::Vapi.KeypadInputPlan? KeypadInputPlan { get; set; }

        /// <summary>
        /// This is the message that the assistant will say if the call is forwarded to voicemail.<br/>
        /// If unspecified, it will hang up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voicemailMessage")]
        public string? VoicemailMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowDTO" /> class.
        /// </summary>
        /// <param name="nodes"></param>
        /// <param name="name"></param>
        /// <param name="edges"></param>
        /// <param name="model">
        /// This is the model for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].model`.
        /// </param>
        /// <param name="transcriber">
        /// This is the transcriber for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].transcriber`.
        /// </param>
        /// <param name="voice">
        /// This is the voice for the workflow.<br/>
        /// This can be overridden at node level using `nodes[n].voice`.
        /// </param>
        /// <param name="observabilityPlan">
        /// This is the plan for observability of workflow's calls.<br/>
        /// Currently, only Langfuse is supported.
        /// </param>
        /// <param name="backgroundSound">
        /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.<br/>
        /// You can also provide a custom sound by providing a URL to an audio file.
        /// </param>
        /// <param name="hooks">
        /// This is a set of actions that will be performed on certain events.
        /// </param>
        /// <param name="credentials">
        /// These are dynamic credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can supplement an additional credentials using this. Dynamic credentials override existing credentials.
        /// </param>
        /// <param name="voicemailDetection">
        /// This is the voicemail detection plan for the workflow.
        /// </param>
        /// <param name="maxDurationSeconds">
        /// This is the maximum duration of the call in seconds.<br/>
        /// After this duration, the call will automatically end.<br/>
        /// Default is 1800 (30 minutes), max is 43200 (12 hours), and min is 10 seconds.<br/>
        /// Example: 600
        /// </param>
        /// <param name="globalPrompt"></param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. tool.server<br/>
        /// 2. workflow.server / assistant.server<br/>
        /// 3. phoneNumber.server<br/>
        /// 4. org.server
        /// </param>
        /// <param name="compliancePlan">
        /// This is the compliance plan for the workflow. It allows you to configure HIPAA and other compliance settings.
        /// </param>
        /// <param name="analysisPlan">
        /// This is the plan for analysis of workflow's calls. Stored in `call.analysis`.
        /// </param>
        /// <param name="artifactPlan">
        /// This is the plan for artifacts generated during workflow's calls. Stored in `call.artifact`.
        /// </param>
        /// <param name="startSpeakingPlan">
        /// This is the plan for when the workflow nodes should start talking.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to start talking after the customer is done speaking.<br/>
        /// - The assistant is too fast to start talking after the customer is done speaking.<br/>
        /// - The assistant is so fast that it's actually interrupting the customer.
        /// </param>
        /// <param name="stopSpeakingPlan">
        /// This is the plan for when workflow nodes should stop talking on customer interruption.<br/>
        /// You should configure this if you're running into these issues:<br/>
        /// - The assistant is too slow to recognize customer's interruption.<br/>
        /// - The assistant is too fast to recognize customer's interruption.<br/>
        /// - The assistant is getting interrupted by phrases that are just acknowledgments.<br/>
        /// - The assistant is getting interrupted by background noises.<br/>
        /// - The assistant is not properly stopping -- it starts talking right after getting interrupted.
        /// </param>
        /// <param name="monitorPlan">
        /// This is the plan for real-time monitoring of the workflow's calls.<br/>
        /// Usage:<br/>
        /// - To enable live listening of the workflow's calls, set `monitorPlan.listenEnabled` to `true`.<br/>
        /// - To enable live control of the workflow's calls, set `monitorPlan.controlEnabled` to `true`.
        /// </param>
        /// <param name="backgroundSpeechDenoisingPlan">
        /// This enables filtering of noise and background speech while the user is talking.<br/>
        /// Features:<br/>
        /// - Smart denoising using Krisp<br/>
        /// - Fourier denoising<br/>
        /// Both can be used together. Order of precedence:<br/>
        /// - Smart denoising<br/>
        /// - Fourier denoising
        /// </param>
        /// <param name="credentialIds">
        /// These are the credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
        /// </param>
        /// <param name="keypadInputPlan">
        /// This is the plan for keypad input handling during workflow calls.
        /// </param>
        /// <param name="voicemailMessage">
        /// This is the message that the assistant will say if the call is forwarded to voicemail.<br/>
        /// If unspecified, it will hang up.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowDTO(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ConversationNode, global::Vapi.ToolNode>> nodes,
            string name,
            global::System.Collections.Generic.IList<global::Vapi.Edge> edges,
            global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>? model,
            global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? transcriber,
            global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? voice,
            global::Vapi.LangfuseObservabilityPlan? observabilityPlan,
            global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOBackgroundSound?, string>? backgroundSound,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.CallHookModelResponseTimeout>>? hooks,
            global::System.Collections.Generic.IList<global::Vapi.CredentialsItem7>? credentials,
            global::Vapi.OneOf<global::Vapi.CreateWorkflowDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>? voicemailDetection,
            double? maxDurationSeconds,
            string? globalPrompt,
            global::Vapi.Server? server,
            global::Vapi.CompliancePlan? compliancePlan,
            global::Vapi.AnalysisPlan? analysisPlan,
            global::Vapi.ArtifactPlan? artifactPlan,
            global::Vapi.StartSpeakingPlan? startSpeakingPlan,
            global::Vapi.StopSpeakingPlan? stopSpeakingPlan,
            global::Vapi.MonitorPlan? monitorPlan,
            global::Vapi.BackgroundSpeechDenoisingPlan? backgroundSpeechDenoisingPlan,
            global::System.Collections.Generic.IList<string>? credentialIds,
            global::Vapi.KeypadInputPlan? keypadInputPlan,
            string? voicemailMessage)
        {
            this.Nodes = nodes ?? throw new global::System.ArgumentNullException(nameof(nodes));
            this.Model = model;
            this.Transcriber = transcriber;
            this.Voice = voice;
            this.ObservabilityPlan = observabilityPlan;
            this.BackgroundSound = backgroundSound;
            this.Hooks = hooks;
            this.Credentials = credentials;
            this.VoicemailDetection = voicemailDetection;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Edges = edges ?? throw new global::System.ArgumentNullException(nameof(edges));
            this.GlobalPrompt = globalPrompt;
            this.Server = server;
            this.CompliancePlan = compliancePlan;
            this.AnalysisPlan = analysisPlan;
            this.ArtifactPlan = artifactPlan;
            this.StartSpeakingPlan = startSpeakingPlan;
            this.StopSpeakingPlan = stopSpeakingPlan;
            this.MonitorPlan = monitorPlan;
            this.BackgroundSpeechDenoisingPlan = backgroundSpeechDenoisingPlan;
            this.CredentialIds = credentialIds;
            this.KeypadInputPlan = keypadInputPlan;
            this.VoicemailMessage = voicemailMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowDTO" /> class.
        /// </summary>
        public CreateWorkflowDTO()
        {
        }
    }
}