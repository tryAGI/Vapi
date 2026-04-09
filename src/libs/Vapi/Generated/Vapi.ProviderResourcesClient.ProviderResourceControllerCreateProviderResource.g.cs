
#nullable enable

namespace Vapi
{
    public partial class ProviderResourcesClient
    {


        private static readonly global::Vapi.EndPointSecurityRequirement s_ProviderResourceControllerCreateProviderResourceSecurityRequirement0 =
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
        private static readonly global::Vapi.EndPointSecurityRequirement[] s_ProviderResourceControllerCreateProviderResourceSecurityRequirements =
            new global::Vapi.EndPointSecurityRequirement[]
            {                s_ProviderResourceControllerCreateProviderResourceSecurityRequirement0,
            };
        partial void PrepareProviderResourceControllerCreateProviderResourceArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string contentType,
            ref global::Vapi.ProviderResourceControllerCreateProviderResourceProvider provider,
            ref global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName resourceName);
        partial void PrepareProviderResourceControllerCreateProviderResourceRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string contentType,
            global::Vapi.ProviderResourceControllerCreateProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName resourceName);
        partial void ProcessProviderResourceControllerCreateProviderResourceResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProviderResourceControllerCreateProviderResourceResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Provider Resource
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Vapi.ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
            string contentType,
            global::Vapi.ProviderResourceControllerCreateProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName resourceName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareProviderResourceControllerCreateProviderResourceArguments(
                httpClient: HttpClient,
                contentType: ref contentType,
                provider: ref provider,
                resourceName: ref resourceName);


            var __authorizations = global::Vapi.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ProviderResourceControllerCreateProviderResourceSecurityRequirements,
                operationName: "ProviderResourceControllerCreateProviderResourceAsync");

            var __pathBuilder = new global::Vapi.PathBuilder(
                path: $"/provider/{provider}/{resourceName}",
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

            __httpRequest.Headers.TryAddWithoutValidation("content-type", contentType.ToString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareProviderResourceControllerCreateProviderResourceRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                contentType: contentType,
                provider: provider,
                resourceName: resourceName);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProviderResourceControllerCreateProviderResourceResponse(
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
                ProcessProviderResourceControllerCreateProviderResourceResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Vapi.ProviderResource.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Vapi.ProviderResource.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
    }
}