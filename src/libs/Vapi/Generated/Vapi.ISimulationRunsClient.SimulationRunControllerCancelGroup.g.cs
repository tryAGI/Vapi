#nullable enable

namespace Vapi
{
    public partial interface ISimulationRunsClient
    {
        /// <summary>
        /// Cancel Simulation Run
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationRun> SimulationRunControllerCancelGroupAsync(
            global::System.Guid id,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Simulation Run
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationRun>> SimulationRunControllerCancelGroupAsResponseAsync(
            global::System.Guid id,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}