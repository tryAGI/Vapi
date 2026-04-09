
#nullable enable

namespace Vapi
{
    public partial class ChatsClient
    {


        private static readonly global::Vapi.EndPointSecurityRequirement s_ChatControllerCreateOpenAIChatSecurityRequirement0 =
            new global::Vapi.EndPointSecurityRequirement
            {
                Authorizations = new global::Vapi.EndPointAuthorizationRequirement[]
                {                    new global::Vapi.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Vapi.EndPointSecurityRequirement[] s_ChatControllerCreateOpenAIChatSecurityRequirements =
            new global::Vapi.EndPointSecurityRequirement[]
            {                s_ChatControllerCreateOpenAIChatSecurityRequirement0,
            };
        partial void PrepareChatControllerCreateOpenAIChatArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Vapi.OpenAIResponsesRequest request);
        partial void PrepareChatControllerCreateOpenAIChatRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Vapi.OpenAIResponsesRequest request);
        partial void ProcessChatControllerCreateOpenAIChatResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChatControllerCreateOpenAIChatResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Chat (OpenAI Compatible)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>> ChatControllerCreateOpenAIChatAsync(

            global::Vapi.OpenAIResponsesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChatControllerCreateOpenAIChatArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Vapi.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatControllerCreateOpenAIChatSecurityRequirements,
                operationName: "ChatControllerCreateOpenAIChatAsync");

            var __pathBuilder = new global::Vapi.PathBuilder(
                path: "/chat/responses",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatControllerCreateOpenAIChatRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatControllerCreateOpenAIChatResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessChatControllerCreateOpenAIChatResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
        /// <summary>
        /// Create Chat (OpenAI Compatible)
        /// </summary>
        /// <param name="assistantId">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that will be used for the chat. To use an existing assistant, use `assistantId` instead.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the variable values that will be used to replace template variables in the assistant messages.<br/>
        /// Only variable substitution is supported in chat contexts - other assistant properties cannot be overridden.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for the chat. To use a transient squad, use `squad` instead.
        /// </param>
        /// <param name="squad">
        /// This is the squad that will be used for the chat. To use an existing squad, use `squadId` instead.
        /// </param>
        /// <param name="name">
        /// This is the name of the chat. This is just for your own reference.
        /// </param>
        /// <param name="sessionId">
        /// This is the ID of the session that will be used for the chat.<br/>
        /// Mutually exclusive with previousChatId.
        /// </param>
        /// <param name="input">
        /// This is the input text for the chat.<br/>
        /// Can be a string or an array of chat messages.<br/>
        /// This field is REQUIRED for chat creation.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response or not.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="previousChatId">
        /// This is the ID of the chat that will be used as context for the new chat.<br/>
        /// The messages from the previous chat will be used as context.<br/>
        /// Mutually exclusive with sessionId.
        /// </param>
        /// <param name="transport">
        /// This is used to send the chat through a transport like SMS.<br/>
        /// If transport.phoneNumberId and transport.customer are provided, creates a new session.<br/>
        /// If sessionId is provided without transport fields, uses existing session data.<br/>
        /// Cannot specify both sessionId and transport fields (phoneNumberId/customer) together.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.OneOf<global::Vapi.ResponseObject, global::Vapi.ResponseTextDeltaEvent, global::Vapi.ResponseTextDoneEvent, global::Vapi.ResponseCompletedEvent, global::Vapi.ResponseErrorEvent>> ChatControllerCreateOpenAIChatAsync(
            global::Vapi.OneOf<string, global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>> input,
            string? assistantId = default,
            global::Vapi.CreateAssistantDTO? assistant = default,
            global::Vapi.AssistantOverrides? assistantOverrides = default,
            string? squadId = default,
            global::Vapi.CreateSquadDTO? squad = default,
            string? name = default,
            string? sessionId = default,
            bool? stream = default,
            string? previousChatId = default,
            global::Vapi.TwilioSMSChatTransport? transport = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vapi.OpenAIResponsesRequest
            {
                AssistantId = assistantId,
                Assistant = assistant,
                AssistantOverrides = assistantOverrides,
                SquadId = squadId,
                Squad = squad,
                Name = name,
                SessionId = sessionId,
                Input = input,
                Stream = stream,
                PreviousChatId = previousChatId,
                Transport = transport,
            };

            return await ChatControllerCreateOpenAIChatAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}