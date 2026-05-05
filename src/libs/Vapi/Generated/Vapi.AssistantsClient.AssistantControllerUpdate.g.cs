
#nullable enable

namespace Vapi
{
    public partial class AssistantsClient
    {


        private static readonly global::Vapi.EndPointSecurityRequirement s_AssistantControllerUpdateSecurityRequirement0 =
            new global::Vapi.EndPointSecurityRequirement
            {
                Authorizations = new global::Vapi.EndPointAuthorizationRequirement[]
                {                    new global::Vapi.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Vapi.EndPointSecurityRequirement[] s_AssistantControllerUpdateSecurityRequirements =
            new global::Vapi.EndPointSecurityRequirement[]
            {                s_AssistantControllerUpdateSecurityRequirement0,
            };
        partial void PrepareAssistantControllerUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::Vapi.UpdateAssistantDTO request);
        partial void PrepareAssistantControllerUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::Vapi.UpdateAssistantDTO request);
        partial void ProcessAssistantControllerUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAssistantControllerUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Assistant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.Assistant> AssistantControllerUpdateAsync(
            string id,

            global::Vapi.UpdateAssistantDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await AssistantControllerUpdateAsResponseAsync(
                id: id,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Update Assistant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Assistant>> AssistantControllerUpdateAsResponseAsync(
            string id,

            global::Vapi.UpdateAssistantDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareAssistantControllerUpdateArguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::Vapi.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AssistantControllerUpdateSecurityRequirements,
                operationName: "AssistantControllerUpdateAsync");

            using var __timeoutCancellationTokenSource = global::Vapi.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Vapi.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Vapi.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Vapi.PathBuilder(
                                path: $"/assistant/{id}",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Vapi.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: new global::System.Net.Http.HttpMethod("PATCH"),
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Vapi.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareAssistantControllerUpdateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    id: id!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Vapi.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AssistantControllerUpdate",
                                methodName: "AssistantControllerUpdateAsync",
                                pathTemplate: "$\"/assistant/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Vapi.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Vapi.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AssistantControllerUpdate",
                                methodName: "AssistantControllerUpdateAsync",
                                pathTemplate: "$\"/assistant/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Vapi.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Vapi.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Vapi.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Vapi.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AssistantControllerUpdate",
                                methodName: "AssistantControllerUpdateAsync",
                                pathTemplate: "$\"/assistant/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Vapi.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessAssistantControllerUpdateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Vapi.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AssistantControllerUpdate",
                                methodName: "AssistantControllerUpdateAsync",
                                pathTemplate: "$\"/assistant/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Vapi.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "AssistantControllerUpdate",
                                methodName: "AssistantControllerUpdateAsync",
                                pathTemplate: "$\"/assistant/{id}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessAssistantControllerUpdateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Vapi.Assistant.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Vapi.AutoSDKHttpResponse<global::Vapi.Assistant>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Vapi.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Vapi.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Vapi.Assistant.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Vapi.AutoSDKHttpResponse<global::Vapi.Assistant>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Vapi.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Vapi.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Update Assistant
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.Assistant> AssistantControllerUpdateAsync(
            string id,
            global::Vapi.OneOf<global::Vapi.AssemblyAITranscriber, global::Vapi.AzureSpeechTranscriber, global::Vapi.CustomTranscriber, global::Vapi.DeepgramTranscriber, global::Vapi.ElevenLabsTranscriber, global::Vapi.GladiaTranscriber, global::Vapi.GoogleTranscriber, global::Vapi.SpeechmaticsTranscriber, global::Vapi.TalkscriberTranscriber, global::Vapi.OpenAITranscriber, global::Vapi.CartesiaTranscriber, global::Vapi.SonioxTranscriber>? transcriber = default,
            global::Vapi.OneOf<global::Vapi.AnthropicModel, global::Vapi.AnthropicBedrockModel, global::Vapi.AnyscaleModel, global::Vapi.CerebrasModel, global::Vapi.CustomLLMModel, global::Vapi.DeepInfraModel, global::Vapi.DeepSeekModel, global::Vapi.GoogleModel, global::Vapi.GroqModel, global::Vapi.InflectionAIModel, global::Vapi.MinimaxLLMModel, global::Vapi.OpenAIModel, global::Vapi.OpenRouterModel, global::Vapi.PerplexityAIModel, global::Vapi.TogetherAIModel, global::Vapi.XaiModel>? model = default,
            global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? voice = default,
            string? firstMessage = default,
            bool? firstMessageInterruptionsEnabled = default,
            global::Vapi.UpdateAssistantDTOFirstMessageMode? firstMessageMode = default,
            global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOVoicemailDetection?, global::Vapi.GoogleVoicemailDetectionPlan, global::Vapi.OpenAIVoicemailDetectionPlan, global::Vapi.TwilioVoicemailDetectionPlan, global::Vapi.VapiVoicemailDetectionPlan>? voicemailDetection = default,
            global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOClientMessage>? clientMessages = default,
            global::System.Collections.Generic.IList<global::Vapi.UpdateAssistantDTOServerMessage>? serverMessages = default,
            double? maxDurationSeconds = default,
            global::Vapi.OneOf<global::Vapi.UpdateAssistantDTOBackgroundSound?, string>? backgroundSound = default,
            bool? modelOutputInMessagesEnabled = default,
            global::System.Collections.Generic.IList<global::Vapi.TransportConfigurationTwilio>? transportConfigurations = default,
            global::Vapi.LangfuseObservabilityPlan? observabilityPlan = default,
            global::System.Collections.Generic.IList<global::Vapi.CredentialsItem5>? credentials = default,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.CallHookCallEnding, global::Vapi.CallHookAssistantSpeechInterrupted, global::Vapi.CallHookCustomerSpeechInterrupted, global::Vapi.CallHookCustomerSpeechTimeout, global::Vapi.SessionCreatedHook>>? hooks = default,
            string? name = default,
            string? voicemailMessage = default,
            string? endCallMessage = default,
            global::System.Collections.Generic.IList<string>? endCallPhrases = default,
            global::Vapi.CompliancePlan? compliancePlan = default,
            object? metadata = default,
            global::Vapi.BackgroundSpeechDenoisingPlan? backgroundSpeechDenoisingPlan = default,
            global::Vapi.ArtifactPlan? artifactPlan = default,
            global::Vapi.StartSpeakingPlan? startSpeakingPlan = default,
            global::Vapi.StopSpeakingPlan? stopSpeakingPlan = default,
            global::Vapi.MonitorPlan? monitorPlan = default,
            global::System.Collections.Generic.IList<string>? credentialIds = default,
            global::Vapi.Server? server = default,
            global::Vapi.KeypadInputPlan? keypadInputPlan = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vapi.UpdateAssistantDTO
            {
                Transcriber = transcriber,
                Model = model,
                Voice = voice,
                FirstMessage = firstMessage,
                FirstMessageInterruptionsEnabled = firstMessageInterruptionsEnabled,
                FirstMessageMode = firstMessageMode,
                VoicemailDetection = voicemailDetection,
                ClientMessages = clientMessages,
                ServerMessages = serverMessages,
                MaxDurationSeconds = maxDurationSeconds,
                BackgroundSound = backgroundSound,
                ModelOutputInMessagesEnabled = modelOutputInMessagesEnabled,
                TransportConfigurations = transportConfigurations,
                ObservabilityPlan = observabilityPlan,
                Credentials = credentials,
                Hooks = hooks,
                Name = name,
                VoicemailMessage = voicemailMessage,
                EndCallMessage = endCallMessage,
                EndCallPhrases = endCallPhrases,
                CompliancePlan = compliancePlan,
                Metadata = metadata,
                BackgroundSpeechDenoisingPlan = backgroundSpeechDenoisingPlan,
                ArtifactPlan = artifactPlan,
                StartSpeakingPlan = startSpeakingPlan,
                StopSpeakingPlan = stopSpeakingPlan,
                MonitorPlan = monitorPlan,
                CredentialIds = credentialIds,
                Server = server,
                KeypadInputPlan = keypadInputPlan,
            };

            return await AssistantControllerUpdateAsync(
                id: id,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}