#nullable enable

namespace Vapi
{
    public partial interface ITrafficAllocationsClient
    {
        /// <summary>
        /// Get latest traffic allocation<br/>
        /// The allocation currently in effect for the assistant, with its targets. The response carries no allocation field when traffic splitting has never been configured. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.TrafficAllocationLatestResponseDTO> TrafficAllocationControllerLatestGetAsync(
            string assistantId,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get latest traffic allocation<br/>
        /// The allocation currently in effect for the assistant, with its targets. The response carries no allocation field when traffic splitting has never been configured. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.TrafficAllocationLatestResponseDTO>> TrafficAllocationControllerLatestGetAsResponseAsync(
            string assistantId,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}