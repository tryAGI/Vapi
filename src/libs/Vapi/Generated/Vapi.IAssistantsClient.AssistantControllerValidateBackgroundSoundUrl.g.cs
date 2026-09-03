#nullable enable

namespace Vapi
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Validate Background Sound URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.BackgroundSoundUrlValidationResult> AssistantControllerValidateBackgroundSoundUrlAsync(

            global::Vapi.ValidateBackgroundSoundUrlDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Background Sound URL
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.BackgroundSoundUrlValidationResult>> AssistantControllerValidateBackgroundSoundUrlAsResponseAsync(

            global::Vapi.ValidateBackgroundSoundUrlDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate Background Sound URL
        /// </summary>
        /// <param name="url">
        /// This is the background sound URL to validate. The server performs a ranged request and checks that the URL serves a live media file.<br/>
        /// Example: https://example.com/my-sound.mp3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.BackgroundSoundUrlValidationResult> AssistantControllerValidateBackgroundSoundUrlAsync(
            string url,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}