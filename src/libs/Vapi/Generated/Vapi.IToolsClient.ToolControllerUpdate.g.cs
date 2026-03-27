#nullable enable

namespace Vapi
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Update Tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ToolControllerUpdateResponse> ToolControllerUpdateAsync(
            string id,

            global::Vapi.ToolControllerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tool
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.ToolControllerUpdateResponse> ToolControllerUpdateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}