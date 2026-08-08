#nullable enable

namespace Vapi
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Get Campaign V2 Contacts
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.CampaignContactPaginatedResponse> CampaignControllerGetCampaignV2ContactsAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? status = default,
            double? limit = default,
            double? page = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Campaign V2 Contacts
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.CampaignContactPaginatedResponse>> CampaignControllerGetCampaignV2ContactsAsResponseAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Vapi.CampaignControllerGetCampaignV2ContactsStatu>? status = default,
            double? limit = default,
            double? page = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}