#nullable enable

namespace Vapi
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Create Insight
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightControllerCreateResponse> InsightControllerCreateAsync(

            global::Vapi.InsightControllerCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Insight
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightControllerCreateResponse> InsightControllerCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}