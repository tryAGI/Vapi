#nullable enable

namespace Vapi
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.File>> FileControllerFindAllAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}