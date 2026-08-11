#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// Update Simulation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Simulation> SimulationControllerUpdateAsync(
            global::System.Guid id,

            global::Vapi.UpdateSimulationDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Simulation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Simulation>> SimulationControllerUpdateAsResponseAsync(
            global::System.Guid id,

            global::Vapi.UpdateSimulationDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Simulation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="name">
        /// This is an optional friendly name for the simulation.
        /// </param>
        /// <param name="scenarioId">
        /// This is the ID of the scenario to use for this simulation.
        /// </param>
        /// <param name="personalityId">
        /// This is the ID of the personality to use for this simulation.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulations.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Simulation> SimulationControllerUpdateAsync(
            global::System.Guid id,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            string? name = default,
            global::System.Guid? scenarioId = default,
            global::System.Guid? personalityId = default,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}