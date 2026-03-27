#nullable enable

namespace Vapi
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Create Analytics Queries
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>> AnalyticsControllerQueryAsync(

            global::Vapi.AnalyticsQueryDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Analytics Queries
        /// </summary>
        /// <param name="queries">
        /// This is the list of metric queries you want to perform.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.AnalyticsQueryResult>> AnalyticsControllerQueryAsync(
            global::System.Collections.Generic.IList<global::Vapi.AnalyticsQuery> queries,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}