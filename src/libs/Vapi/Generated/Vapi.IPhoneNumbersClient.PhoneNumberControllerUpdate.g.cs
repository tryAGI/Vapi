#nullable enable

namespace Vapi
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Update Phone Number
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.PhoneNumberControllerUpdateResponse> PhoneNumberControllerUpdateAsync(
            string id,

            global::Vapi.PhoneNumberControllerUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Phone Number
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.PhoneNumberControllerUpdateResponse> PhoneNumberControllerUpdateAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}