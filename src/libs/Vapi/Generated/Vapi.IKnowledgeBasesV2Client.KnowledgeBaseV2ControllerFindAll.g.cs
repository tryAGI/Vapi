#nullable enable

namespace Vapi
{
    public partial interface IKnowledgeBasesV2Client
    {
        /// <summary>
        /// List Knowledge Bases V2
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2>> KnowledgeBaseV2ControllerFindAllAsync(
            double? limit = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Knowledge Bases V2
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Vapi.KnowledgeBaseV2>>> KnowledgeBaseV2ControllerFindAllAsResponseAsync(
            double? limit = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}