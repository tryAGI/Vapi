#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// Generate Scenarios with AI<br/>
        /// Uses AI to analyze an assistant or squad configuration and generate test scenarios
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.GenerateScenariosResponse> SimulationGenerateControllerGenerateAsync(

            global::Vapi.GenerateScenariosDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Scenarios with AI<br/>
        /// Uses AI to analyze an assistant or squad configuration and generate test scenarios
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.GenerateScenariosResponse>> SimulationGenerateControllerGenerateAsResponseAsync(

            global::Vapi.GenerateScenariosDTO request,
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate Scenarios with AI<br/>
        /// Uses AI to analyze an assistant or squad configuration and generate test scenarios
        /// </summary>
        /// <param name="xClientSource"></param>
        /// <param name="xSimulationEntryPoint"></param>
        /// <param name="assistantId">
        /// ID of the assistant to generate scenarios for
        /// </param>
        /// <param name="squadId">
        /// ID of the squad to generate scenarios for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.GenerateScenariosResponse> SimulationGenerateControllerGenerateAsync(
            string? xClientSource = default,
            string? xSimulationEntryPoint = default,
            string? assistantId = default,
            string? squadId = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}