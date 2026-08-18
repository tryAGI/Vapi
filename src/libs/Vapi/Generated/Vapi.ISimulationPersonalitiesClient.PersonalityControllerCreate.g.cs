#nullable enable

namespace Vapi
{
    public partial interface ISimulationPersonalitiesClient
    {
        /// <summary>
        /// Create Personality
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Personality> PersonalityControllerCreateAsync(

            global::Vapi.CreatePersonalityDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Personality
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Personality>> PersonalityControllerCreateAsResponseAsync(

            global::Vapi.CreatePersonalityDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Personality
        /// </summary>
        /// <param name="name">
        /// This is the name of the personality (e.g., "Confused Carl", "Rude Rob").
        /// </param>
        /// <param name="assistant">
        /// This is the full assistant configuration for this personality.<br/>
        /// It defines the tester's voice, model, behavior via system prompt, and other settings.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Personality> PersonalityControllerCreateAsync(
            string name,
            global::Vapi.CreateAssistantDTO assistant,
            string? path = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}