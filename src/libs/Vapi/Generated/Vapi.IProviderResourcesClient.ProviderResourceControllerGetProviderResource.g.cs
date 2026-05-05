#nullable enable

namespace Vapi
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Get Provider Resource
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
            global::Vapi.ProviderResourceControllerGetProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerGetProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Provider Resource
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.ProviderResource>> ProviderResourceControllerGetProviderResourceAsResponseAsync(
            global::Vapi.ProviderResourceControllerGetProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerGetProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}