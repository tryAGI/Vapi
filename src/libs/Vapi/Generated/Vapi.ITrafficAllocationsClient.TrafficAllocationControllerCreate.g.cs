#nullable enable

namespace Vapi
{
    public partial interface ITrafficAllocationsClient
    {
        /// <summary>
        /// Create traffic allocation<br/>
        /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.TrafficAllocation> TrafficAllocationControllerCreateAsync(

            global::Vapi.CreateTrafficAllocationDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create traffic allocation<br/>
        /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.TrafficAllocation>> TrafficAllocationControllerCreateAsResponseAsync(

            global::Vapi.CreateTrafficAllocationDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create traffic allocation<br/>
        /// Creates a new traffic allocation for an assistant, replacing the one currently in effect. To start or adjust a split, send targets naming published versions (such as "v7") with percentages totaling 100; allocationIntent is inferred as 'explicit'. To stop splitting and send every call to the newest published version, send allocationIntent 'follow-latest' with no targets field; stopping always names its intent, so a dropped targets field can never end a split by accident. Traffic splitting is in beta, rolling out to select organizations; requests from organizations without access receive a 403.
        /// </summary>
        /// <param name="assistantId">
        /// The assistant whose calls this allocation splits.
        /// </param>
        /// <param name="allocationIntent">
        /// 'explicit' splits calls across targets, and is inferred when targets is sent. 'follow-latest' sends every call to the newest published version and is how you stop splitting; it must be sent explicitly.
        /// </param>
        /// <param name="targets">
        /// The versions to split calls across. Omit to stop splitting (with allocationIntent 'follow-latest'). Order in this array is the selection order (position).
        /// </param>
        /// <param name="expectedCurrentAllocationId">
        /// Optional concurrency guard. Omit it and the write applies unconditionally (last write wins, matching every other Vapi update surface). Provide the id of the allocation you last read and the write applies only while that allocation is still governing; any mismatch is a 409 carrying the actual current id.
        /// </param>
        /// <param name="description">
        /// An optional note explaining why you made this change.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "VAPI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::Vapi.TrafficAllocation> TrafficAllocationControllerCreateAsync(
            string assistantId,
            global::Vapi.CreateTrafficAllocationDTOAllocationIntent? allocationIntent = default,
            global::System.Collections.Generic.IList<global::Vapi.CreateTrafficAllocationTargetDTO>? targets = default,
            global::System.Guid? expectedCurrentAllocationId = default,
            string? description = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}