#nullable enable

namespace Vapi
{
    public partial interface IKnowledgeBasesV2Client
    {
        /// <summary>
        /// List files in a Knowledge Base V2
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2File>> KnowledgeBaseV2ControllerFilesGetAsync(
            global::System.Guid id,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List files in a Knowledge Base V2
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2File>>> KnowledgeBaseV2ControllerFilesGetAsResponseAsync(
            global::System.Guid id,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}