#nullable enable

namespace Vapi
{
    public partial interface IProviderResourcesClient
    {
        /// <summary>
        /// Delete Provider Resource
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="resourceName"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ProviderResource> ProviderResourceControllerDeleteProviderResourceAsync(
            global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}