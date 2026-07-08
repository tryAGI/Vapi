#nullable enable

namespace Vapi
{
    public partial interface ICampaignsClient
    {
        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Campaign> CampaignControllerCreateAsync(

            global::Vapi.CreateCampaignDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Campaign>> CampaignControllerCreateAsResponseAsync(

            global::Vapi.CreateCampaignDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Campaign
        /// </summary>
        /// <param name="name">
        /// This is the name of the campaign. This is just for your own reference.<br/>
        /// Example: Q2 Sales Campaign
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="dialPlan">
        /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
        /// </param>
        /// <param name="schedulePlan">
        /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
        /// </param>
        /// <param name="customers">
        /// These are the customers that will be called in the campaign. Required if dialPlan is not provided. Maximum of 10000 customers per campaign.
        /// </param>
        /// <param name="maxConcurrency">
        /// This is the maximum number of concurrent calls that will be made for the campaign. Defaults to 10.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant's settings and template variables for the campaign. Use this when the campaign targets an `assistantId`.
        /// </param>
        /// <param name="squadOverrides">
        /// These are the overrides for the squad and template variables for the campaign. Use this when the campaign targets a `squadId`. Per-contact `squadOverrides` are deep-merged on top of this at dispatch time.
        /// </param>
        /// <param name="server">
        /// This is the server (URL, auth headers, timeout, etc.) for the campaign webhooks.
        /// </param>
        /// <param name="duplicateFromCampaignId">
        /// Optional campaign ID to duplicate config from. Provided fields in the request override the source. If `customers` is omitted, contacts are copied from the source.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Campaign> CampaignControllerCreateAsync(
            string name,
            string? assistantId = default,
            string? workflowId = default,
            string? squadId = default,
            string? phoneNumberId = default,
            global::System.Collections.Generic.IList<global::Vapi.DialPlanEntry>? dialPlan = default,
            global::Vapi.SchedulePlan? schedulePlan = default,
            global::System.Collections.Generic.IList<global::Vapi.CreateCustomerDTO>? customers = default,
            double? maxConcurrency = default,
            global::Vapi.AssistantOverrides? assistantOverrides = default,
            global::Vapi.AssistantOverrides? squadOverrides = default,
            global::Vapi.Server? server = default,
            string? duplicateFromCampaignId = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}