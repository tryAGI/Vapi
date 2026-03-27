#nullable enable

namespace Vapi
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Update Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightControllerUpdateResponse> InsightControllerUpdateAsync(
            string id,

            global::Vapi.InsightControllerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightControllerUpdateResponse> InsightControllerUpdateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}