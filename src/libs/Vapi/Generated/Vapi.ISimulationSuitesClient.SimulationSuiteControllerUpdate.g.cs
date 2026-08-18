#nullable enable

namespace Vapi
{
    public partial interface ISimulationSuitesClient
    {
        /// <summary>
        /// Update Simulation Suite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationSuite> SimulationSuiteControllerUpdateAsync(
            global::System.Guid id,

            global::Vapi.UpdateSimulationSuiteDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Simulation Suite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationSuite>> SimulationSuiteControllerUpdateAsResponseAsync(
            global::System.Guid id,

            global::Vapi.UpdateSimulationSuiteDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Simulation Suite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// This is the name of the simulation suite.
        /// </param>
        /// <param name="slackWebhookUrl">
        /// This is the Slack webhook URL for notifications.
        /// </param>
        /// <param name="simulationIds">
        /// This is the list of simulation IDs to include in the suite (replaces existing).
        /// </param>
        /// <param name="targetAssignments">
        /// Optional assistant or squad assignments (replaces existing).
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationSuite> SimulationSuiteControllerUpdateAsync(
            global::System.Guid id,
            string? name = default,
            string? slackWebhookUrl = default,
            global::System.Collections.Generic.IList<string>? simulationIds = default,
            global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>? targetAssignments = default,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}