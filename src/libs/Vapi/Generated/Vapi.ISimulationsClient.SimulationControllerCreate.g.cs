#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// Create Simulation
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Simulation> SimulationControllerCreateAsync(

            global::Vapi.CreateSimulationDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Simulation>> SimulationControllerCreateAsResponseAsync(

            global::Vapi.CreateSimulationDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="name">
        /// This is an optional friendly name for the simulation.<br/>
        /// Example: Eligible Path with Confused User
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
        /// Maps to GitOps resource folder structure.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Simulation> SimulationControllerCreateAsync(
            global::System.Guid scenarioId,
            global::System.Guid personalityId,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            string? name = default,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}