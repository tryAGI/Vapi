#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// List Simulations
        /// </summary>
        /// <param name="idAny"></param>
        /// <param name="standaloneOnly"></param>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Vapi.Simulation>> SimulationControllerFindAllAsync(
            global::System.Collections.Generic.IList<string>? idAny = default,
            bool? standaloneOnly = default,
            double? page = default,
            global::Vapi.SimulationControllerFindAllSortOrder? sortOrder = default,
            global::Vapi.SimulationControllerFindAllSortBy? sortBy = default,
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
        /// List Simulations
        /// </summary>
        /// <param name="idAny"></param>
        /// <param name="standaloneOnly"></param>
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
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Vapi.Simulation>>> SimulationControllerFindAllAsResponseAsync(
            global::System.Collections.Generic.IList<string>? idAny = default,
            bool? standaloneOnly = default,
            double? page = default,
            global::Vapi.SimulationControllerFindAllSortOrder? sortOrder = default,
            global::Vapi.SimulationControllerFindAllSortBy? sortBy = default,
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