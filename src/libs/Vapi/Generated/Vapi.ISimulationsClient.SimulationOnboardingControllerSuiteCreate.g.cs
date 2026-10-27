#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// Generate a simulation suite<br/>
        /// Generates a simulation suite from requirements your user agreed to, saves it and assigns it to the assistant. Takes up to 3 minutes, so set a client timeout of at least 200 seconds.<br/>
        /// Send one `idempotencyKey` per agreed draft. Retrying with the same key never generates a second suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for other requirements. Send a new key.<br/>
        /// Then review the suite with your user, edit it with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, and run it with `POST /eval/simulation/run`.<br/>
        /// Each org can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite doesn't count. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30). On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: the limit resets at 00:00 UTC.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteCreateAsync(

            global::Vapi.SimulationOnboardingSuiteCreateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a simulation suite<br/>
        /// Generates a simulation suite from requirements your user agreed to, saves it and assigns it to the assistant. Takes up to 3 minutes, so set a client timeout of at least 200 seconds.<br/>
        /// Send one `idempotencyKey` per agreed draft. Retrying with the same key never generates a second suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for other requirements. Send a new key.<br/>
        /// Then review the suite with your user, edit it with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, and run it with `POST /eval/simulation/run`.<br/>
        /// Each org can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite doesn't count. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30). On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: the limit resets at 00:00 UTC.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingSuiteViewDTO>> SimulationOnboardingControllerSuiteCreateAsResponseAsync(

            global::Vapi.SimulationOnboardingSuiteCreateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate a simulation suite<br/>
        /// Generates a simulation suite from requirements your user agreed to, saves it and assigns it to the assistant. Takes up to 3 minutes, so set a client timeout of at least 200 seconds.<br/>
        /// Send one `idempotencyKey` per agreed draft. Retrying with the same key never generates a second suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for other requirements. Send a new key.<br/>
        /// Then review the suite with your user, edit it with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, and run it with `POST /eval/simulation/run`.<br/>
        /// Each org can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite doesn't count. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30). On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: the limit resets at 00:00 UTC.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant the suite tests and is assigned to.
        /// </param>
        /// <param name="idempotencyKey">
        /// One key per agreed draft. Retrying with the same key returns the suite already saved, or a 409 while it is still generating, instead of generating another.
        /// </param>
        /// <param name="requirements">
        /// The requirements your user agreed to, from the requirements draft. Each id at most once.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteCreateAsync(
            global::System.Guid assistantId,
            string idempotencyKey,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO> requirements,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}