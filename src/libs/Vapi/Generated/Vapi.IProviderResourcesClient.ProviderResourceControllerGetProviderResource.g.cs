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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ProviderResource> ProviderResourceControllerGetProviderResourceAsync(
            global::Vapi.ProviderResourceControllerGetProviderResourceProvider provider,
            global::Vapi.ProviderResourceControllerGetProviderResourceResourceName resourceName,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}