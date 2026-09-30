#nullable enable

namespace Vapi
{
    public partial interface ITrafficAllocationsClient
    {
        /// <summary>
        /// List traffic allocations<br/>
        /// The append-only history of an assistant's allocations, newest first. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="sortOrder"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.TrafficAllocationPaginatedResponse> TrafficAllocationControllerFindAllPaginatedAsync(
            string? assistantId = default,
            int? page = default,
            int? limit = default,
            global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder? sortOrder = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List traffic allocations<br/>
        /// The append-only history of an assistant's allocations, newest first. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="sortOrder"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.TrafficAllocationPaginatedResponse>> TrafficAllocationControllerFindAllPaginatedAsResponseAsync(
            string? assistantId = default,
            int? page = default,
            int? limit = default,
            global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder? sortOrder = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}