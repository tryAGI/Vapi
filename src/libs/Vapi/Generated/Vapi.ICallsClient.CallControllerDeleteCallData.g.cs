#nullable enable

namespace Vapi
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Delete Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Call> CallControllerDeleteCallDataAsync(
            string id,

            global::Vapi.DeleteCallDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids">
        /// These are the Call IDs to be bulk deleted.<br/>
        /// If provided, the call ID if any in the request query will be ignored<br/>
        /// When requesting a bulk delete, updates when a call is deleted will be sent as a webhook to the server URL configured in the Org settings.<br/>
        /// It may take up to a few hours to complete the bulk delete, and will be asynchronous.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Call> CallControllerDeleteCallDataAsync(
            string id,
            global::System.Collections.Generic.IList<string>? ids = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}