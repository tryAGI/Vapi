#nullable enable

namespace Vapi
{
    public partial interface IPhoneNumbersClient
    {
        /// <summary>
        /// Create Phone Number
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.PhoneNumberControllerCreateResponse> PhoneNumberControllerCreateAsync(

            global::Vapi.PhoneNumberControllerCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Phone Number
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.PhoneNumberControllerCreateResponse> PhoneNumberControllerCreateAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}