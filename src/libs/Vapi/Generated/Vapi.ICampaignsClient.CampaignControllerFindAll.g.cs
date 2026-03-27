#nullable enable

namespace Vapi
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// List Campaigns
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="page"></param>
        /// <param name="sortOrder"></param>
        /// <param name="limit"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="createdAtGe"></param>
        /// <param name="createdAtLe"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="updatedAtGe"></param>
        /// <param name="updatedAtLe"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.CampaignPaginatedResponse> CampaignControllerFindAllAsync(
            string? id = default,
            global::Vapi.CampaignControllerFindAllStatus? status = default,
            double? page = default,
            global::Vapi.CampaignControllerFindAllSortOrder? sortOrder = default,
            double? limit = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLt = default,
            global::System.DateTime? createdAtGe = default,
            global::System.DateTime? createdAtLe = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.DateTime? updatedAtGe = default,
            global::System.DateTime? updatedAtLe = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}