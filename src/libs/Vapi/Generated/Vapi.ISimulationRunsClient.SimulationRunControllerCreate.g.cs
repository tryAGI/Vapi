#nullable enable

namespace Vapi
{
    public partial interface ISimulationRunsClient
    {
        /// <summary>
        /// Create Simulation Run
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.CreateSimulationRunResponse> SimulationRunControllerCreateAsync(

            global::Vapi.CreateSimulationRunDTO request,
            string? userAgent = default,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation Run
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.CreateSimulationRunResponse>> SimulationRunControllerCreateAsResponseAsync(

            global::Vapi.CreateSimulationRunDTO request,
            string? userAgent = default,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation Run
        /// </summary>
        /// <param name="userAgent"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="simulations">
        /// Array of simulations and/or suites to run
        /// </param>
        /// <param name="target">
        /// Target to test against
        /// </param>
        /// <param name="iterations">
        /// Number of times to run each simulation (default: 1)<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="transport">
        /// Transport configuration for the simulation runs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.CreateSimulationRunResponse> SimulationRunControllerCreateAsync(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationRunSimulationEntry, global::Vapi.SimulationRunSuiteEntry>> simulations,
            global::Vapi.OneOf<global::Vapi.SimulationRunTargetAssistant, global::Vapi.SimulationRunTargetSquad> target,
            string? userAgent = default,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            double? iterations = default,
            global::Vapi.SimulationRunTransportConfiguration? transport = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}