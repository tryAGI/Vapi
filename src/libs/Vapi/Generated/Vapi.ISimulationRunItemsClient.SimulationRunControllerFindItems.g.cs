#nullable enable

namespace Vapi
{
    public partial interface ISimulationRunItemsClient
    {
        /// <summary>
        /// List Simulation Run Items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="simulationId"></param>
        /// <param name="runId"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="sortBy"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>> SimulationRunControllerFindItemsAsync(
            global::System.Guid id,
            global::System.Guid? simulationId = default,
            global::System.Guid? runId = default,
            global::Vapi.SimulationRunControllerFindItemsStatus? status = default,
            double? page = default,
            global::Vapi.SimulationRunControllerFindItemsSortOrder? sortOrder = default,
            global::Vapi.SimulationRunControllerFindItemsSortBy? sortBy = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Simulation Run Items
        /// </summary>
        /// <param name="id"></param>
        /// <param name="simulationId"></param>
        /// <param name="runId"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="sortBy"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>>> SimulationRunControllerFindItemsAsResponseAsync(
            global::System.Guid id,
            global::System.Guid? simulationId = default,
            global::System.Guid? runId = default,
            global::Vapi.SimulationRunControllerFindItemsStatus? status = default,
            double? page = default,
            global::Vapi.SimulationRunControllerFindItemsSortOrder? sortOrder = default,
            global::Vapi.SimulationRunControllerFindItemsSortBy? sortBy = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}