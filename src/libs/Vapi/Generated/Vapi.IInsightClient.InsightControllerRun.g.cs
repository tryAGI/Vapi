#nullable enable

namespace Vapi
{
    public partial interface IInsightClient
    {
        /// <summary>
        /// Run Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightRunResponse> InsightControllerRunAsync(
            string id,

            global::Vapi.InsightRunDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run Insight
        /// </summary>
        /// <param name="id"></param>
        /// <param name="formatPlan"></param>
        /// <param name="timeRangeOverride">
        /// This is the optional time range override for the insight.<br/>
        /// If provided, overrides every field in the insight's timeRange.<br/>
        /// If this is provided with missing fields, defaults will be used, not the insight's timeRange.<br/>
        /// start default - "-7d"<br/>
        /// end default - "now"<br/>
        /// step default - "day"<br/>
        /// For Pie and Text Insights, step will be ignored even if provided.<br/>
        /// Example: { start: "2025-01-01", end: "2025-01-07", step: "day" }
        /// </param>
        /// <param name="assistantId">
        /// Optional runtime assistant scope for dashboards.<br/>
        /// This is applied to call-table queries without mutating the saved insight.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.InsightRunResponse> InsightControllerRunAsync(
            string id,
            global::Vapi.InsightRunFormatPlan? formatPlan = default,
            global::Vapi.InsightTimeRangeWithStep? timeRangeOverride = default,
            string? assistantId = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}