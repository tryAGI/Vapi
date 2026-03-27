#nullable enable

namespace Vapi
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Create Provider Resource
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ProviderResource> ProviderResourceControllerCreateProviderResourceAsync(
            string contentType,
            global::Vapi.ProviderResourceControllerCreateProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName resourceName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}