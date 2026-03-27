#nullable enable

namespace Vapi
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Create Tool
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ToolControllerCreateResponse> ToolControllerCreateAsync(

            global::Vapi.ToolControllerCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Tool
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ToolControllerCreateResponse> ToolControllerCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}