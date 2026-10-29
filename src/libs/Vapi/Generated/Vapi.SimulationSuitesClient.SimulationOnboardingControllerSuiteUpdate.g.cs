
#nullable enable

namespace Vapi
{
    public partial class SimulationSuitesClient
    {


        private static readonly global::Vapi.EndPointSecurityRequirement s_SimulationOnboardingControllerSuiteUpdateSecurityRequirement0 =
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
        private static readonly global::Vapi.EndPointSecurityRequirement[] s_SimulationOnboardingControllerSuiteUpdateSecurityRequirements =
            new global::Vapi.EndPointSecurityRequirement[]
            {                s_SimulationOnboardingControllerSuiteUpdateSecurityRequirement0,
            };
        partial void PrepareSimulationOnboardingControllerSuiteUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string suiteId,
            global::Vapi.SimulationOnboardingSuiteUpdateDTO request);
        partial void PrepareSimulationOnboardingControllerSuiteUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string suiteId,
            global::Vapi.SimulationOnboardingSuiteUpdateDTO request);
        partial void ProcessSimulationOnboardingControllerSuiteUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSimulationOnboardingControllerSuiteUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteUpdateAsync(
            string suiteId,

            global::Vapi.SimulationOnboardingSuiteUpdateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await SimulationOnboardingControllerSuiteUpdateAsResponseAsync(
                suiteId: suiteId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingSuiteViewDTO>> SimulationOnboardingControllerSuiteUpdateAsResponseAsync(
            string suiteId,

            global::Vapi.SimulationOnboardingSuiteUpdateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSimulationOnboardingControllerSuiteUpdateArguments(
                httpClient: HttpClient,
                suiteId: ref suiteId,
                request: request);


            var __authorizations = global::Vapi.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_SimulationOnboardingControllerSuiteUpdateSecurityRequirements,
                operationName: "SimulationOnboardingControllerSuiteUpdateAsync");

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
                                path: $"/eval/simulation/onboarding/suite/{suiteId}",
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
                PrepareSimulationOnboardingControllerSuiteUpdateRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    suiteId: suiteId,
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
                                operationId: "SimulationOnboardingControllerSuiteUpdate",
                                methodName: "SimulationOnboardingControllerSuiteUpdateAsync",
                                pathTemplate: "$\"/eval/simulation/onboarding/suite/{suiteId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "SimulationOnboardingControllerSuiteUpdate",
                                methodName: "SimulationOnboardingControllerSuiteUpdateAsync",
                                pathTemplate: "$\"/eval/simulation/onboarding/suite/{suiteId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "SimulationOnboardingControllerSuiteUpdate",
                                methodName: "SimulationOnboardingControllerSuiteUpdateAsync",
                                pathTemplate: "$\"/eval/simulation/onboarding/suite/{suiteId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                ProcessSimulationOnboardingControllerSuiteUpdateResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Vapi.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Vapi.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "SimulationOnboardingControllerSuiteUpdate",
                                methodName: "SimulationOnboardingControllerSuiteUpdateAsync",
                                pathTemplate: "$\"/eval/simulation/onboarding/suite/{suiteId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                                operationId: "SimulationOnboardingControllerSuiteUpdate",
                                methodName: "SimulationOnboardingControllerSuiteUpdateAsync",
                                pathTemplate: "$\"/eval/simulation/onboarding/suite/{suiteId}\"",
                                httpMethod: "PATCH",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
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
                            //
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    responseBody: __content_400,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`: the org made 60 edits today. Don't retry; the limit resets at 00:00 UTC.
                            if ((int)__response.StatusCode == 429)
                            {
                                string? __content_429 = null;
                                global::System.Exception? __exception_429 = null;
                                global::Vapi.SimulationOnboardingErrorDTO? __value_429 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_429 = global::Vapi.SimulationOnboardingErrorDTO.FromJson(__content_429, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_429 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_429 = global::Vapi.SimulationOnboardingErrorDTO.FromJson(__content_429, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_429 = __ex;
                                }


                                throw global::Vapi.ApiException<global::Vapi.SimulationOnboardingErrorDTO>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_429,
                                    responseBody: __content_429,
                                    responseObject: __value_429,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 502)
                            {
                                string? __content_502 = null;
                                global::System.Exception? __exception_502 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_502 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_502 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_502 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_502,
                                    responseBody: __content_502,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Simulation generation is paused, no caller personalities are configured, or the quota store is unavailable for a private-key request. Quota outages return SIMULATION_ONBOARDING_QUOTA_UNAVAILABLE with Retry-After; retry with the same key.
                            if ((int)__response.StatusCode == 503)
                            {
                                string? __content_503 = null;
                                global::System.Exception? __exception_503 = null;
                                global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>? __value_503 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_503 = global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>.FromJson(__content_503, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_503 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_503 = global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>.FromJson(__content_503, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_503 = __ex;
                                }


                                throw global::Vapi.ApiException<global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>?>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_503 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_503,
                                    responseBody: __content_503,
                                    responseObject: __value_503,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            //
                            if ((int)__response.StatusCode == 504)
                            {
                                string? __content_504 = null;
                                global::System.Exception? __exception_504 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_504 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_504 = __ex;
                                }


                                throw global::Vapi.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_504 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_504,
                                    responseBody: __content_504,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessSimulationOnboardingControllerSuiteUpdateResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Vapi.SimulationOnboardingSuiteViewDTO.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingSuiteViewDTO>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Vapi.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Vapi.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = await global::Vapi.SimulationOnboardingSuiteViewDTO.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingSuiteViewDTO>(
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

                                    throw global::Vapi.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="patchKey">
        /// A new key for each edit. Replaying an applied key changes nothing and returns the current suite. A suite remembers its last 50 keys, so never reuse one.
        /// </param>
        /// <param name="removeSimulationIds">
        /// Simulations to take out of the suite. They are unlinked, not deleted.
        /// </param>
        /// <param name="edits">
        /// Simulations to rewrite in place, at most one edit per simulation: put every change for a simulation in one instruction.
        /// </param>
        /// <param name="retryFailed">
        /// Regenerate the scenarios that failed or did not fit when the suite was generated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteUpdateAsync(
            string suiteId,
            string patchKey,
            global::System.Collections.Generic.IList<global::System.Guid>? removeSimulationIds = default,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteEditDTO>? edits = default,
            bool? retryFailed = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Vapi.SimulationOnboardingSuiteUpdateDTO
            {
                PatchKey = patchKey,
                RemoveSimulationIds = removeSimulationIds,
                Edits = edits,
                RetryFailed = retryFailed,
            };

            return await SimulationOnboardingControllerSuiteUpdateAsync(
                suiteId: suiteId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}