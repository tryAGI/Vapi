#nullable enable

namespace Vapi
{
    public partial interface ISimulationSuitesClient
    {
        /// <summary>
        /// Create Simulation Suite
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationSuite> SimulationSuiteControllerCreateAsync(

            global::Vapi.CreateSimulationSuiteDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation Suite
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationSuite>> SimulationSuiteControllerCreateAsResponseAsync(

            global::Vapi.CreateSimulationSuiteDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Simulation Suite
        /// </summary>
        /// <param name="name">
        /// This is the name of the simulation suite.<br/>
        /// Example: Checkout Flow Tests
        /// </param>
        /// <param name="slackWebhookUrl">
        /// This is the Slack webhook URL for notifications.
        /// </param>
        /// <param name="simulationIds">
        /// This is the list of simulation IDs to include in the suite.
        /// </param>
        /// <param name="targetAssignments">
        /// Optional assistant or squad assignments for the suite.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationSuite> SimulationSuiteControllerCreateAsync(
            string name,
            global::System.Collections.Generic.IList<string> simulationIds,
            string? slackWebhookUrl = default,
            global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>? targetAssignments = default,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}