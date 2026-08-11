#nullable enable

namespace Vapi
{
    public partial interface ISimulationRunItemsClient
    {
        /// <summary>
        /// Generate Improvement Suggestions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="force"></param>
        /// <param name="persist"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task SimulationRunControllerGenerateSuggestionsAsync(
            string id,
            string itemId,
            string force,
            string? persist = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Improvement Suggestions
        /// </summary>
        /// <param name="id"></param>
        /// <param name="itemId"></param>
        /// <param name="force"></param>
        /// <param name="persist"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse> SimulationRunControllerGenerateSuggestionsAsResponseAsync(
            string id,
            string itemId,
            string force,
            string? persist = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}