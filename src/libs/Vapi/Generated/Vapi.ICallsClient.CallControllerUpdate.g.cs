#nullable enable

namespace Vapi
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Update Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Call> CallControllerUpdateAsync(
            string id,

            global::Vapi.UpdateCallDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Call
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name">
        /// This is the name of the call. This is just for your own reference.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Call> CallControllerUpdateAsync(
            string id,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}