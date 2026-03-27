#nullable enable

namespace Vapi
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Preview Insight
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightRunResponse> InsightControllerPreviewAsync(

            global::Vapi.InsightControllerPreviewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Preview Insight
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightRunResponse> InsightControllerPreviewAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}