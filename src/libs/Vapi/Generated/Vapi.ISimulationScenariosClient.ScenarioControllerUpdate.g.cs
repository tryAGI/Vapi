#nullable enable

namespace Vapi
{
    public partial interface ISimulationScenariosClient
    {
        /// <summary>
        /// Update Scenario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Scenario> ScenarioControllerUpdateAsync(
            global::System.Guid id,

            global::Vapi.UpdateScenarioDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Scenario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Scenario>> ScenarioControllerUpdateAsResponseAsync(
            global::System.Guid id,

            global::Vapi.UpdateScenarioDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Scenario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="name">
        /// This is the name of the scenario.
        /// </param>
        /// <param name="instructions">
        /// This is the script/instructions for the tester to follow during the simulation.
        /// </param>
        /// <param name="evaluations">
        /// This is the structured output-based evaluation plan for the simulation.<br/>
        /// Each item defines a structured output to extract and evaluate against an expected value.
        /// </param>
        /// <param name="hooks">
        /// Hooks to run on simulation lifecycle events
        /// </param>
        /// <param name="targetOverrides">
        /// Overrides to inject into the simulated target assistant or squad<br/>
        /// Example: {"variableValues":{"customerName":"Alice","orderId":"12345"}}
        /// </param>
        /// <param name="toolMocks"></param>
        /// <param name="path">
        /// Optional folder path for organizing scenarios.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Scenario> ScenarioControllerUpdateAsync(
            global::System.Guid id,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            string? name = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::Vapi.EvaluationPlanItem>? evaluations = default,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>? hooks = default,
            global::Vapi.AssistantOverrides? targetOverrides = default,
            global::System.Collections.Generic.IList<global::Vapi.ScenarioToolMock>? toolMocks = default,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}