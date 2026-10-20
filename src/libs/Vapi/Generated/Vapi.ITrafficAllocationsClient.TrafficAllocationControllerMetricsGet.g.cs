#nullable enable

namespace Vapi
{
    public partial interface ITrafficAllocationsClient
    {
        /// <summary>
        /// Get traffic split metrics<br/>
        /// Per-assistant-version call metrics over a time window: call counts, configured vs actual traffic share, duration, cost per minute, latency, ended reasons, a bucketed timeseries, and optional structured output aggregations. Calls with no assistant version are reported as an 'unversioned' row. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="bucket"></param>
        /// <param name="structuredOutputIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.TrafficTabMetricsDTO> TrafficAllocationControllerMetricsGetAsync(
            string assistantId,
            global::System.DateTime from,
            global::System.DateTime to,
            global::Vapi.TrafficAllocationControllerMetricsGetBucket? bucket = default,
            byte[]? structuredOutputIds = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get traffic split metrics<br/>
        /// Per-assistant-version call metrics over a time window: call counts, configured vs actual traffic share, duration, cost per minute, latency, ended reasons, a bucketed timeseries, and optional structured output aggregations. Calls with no assistant version are reported as an 'unversioned' row. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="bucket"></param>
        /// <param name="structuredOutputIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.TrafficTabMetricsDTO>> TrafficAllocationControllerMetricsGetAsResponseAsync(
            string assistantId,
            global::System.DateTime from,
            global::System.DateTime to,
            global::Vapi.TrafficAllocationControllerMetricsGetBucket? bucket = default,
            byte[]? structuredOutputIds = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}