#nullable enable

namespace Vapi
{
    public partial interface ISimulationSuitesClient
    {
        /// <summary>
        /// Generate a simulation suite<br/>
        /// Generate and save a simulation suite from reviewed test requirements, and assign it to an assistant. First draft requirements with `POST /eval/simulation/onboarding/requirements`. The response includes the saved suite, its simulations, and requirement coverage, including any gaps.<br/>
        /// Requests can take up to 3 minutes. Set a client timeout of at least 200 seconds.<br/>
        /// Use a unique `idempotencyKey` for each suite generation request. Retrying with the same key does not create a duplicate suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for a different assistant or requirements. Send a new key.<br/>
        /// Review the generated simulations and coverage gaps. Revise the suite with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, then run it with `POST /eval/simulation/run`.<br/>
        /// Each organization can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite does not count toward these limits. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30) before retrying. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
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
        /// Generate and save a simulation suite from reviewed test requirements, and assign it to an assistant. First draft requirements with `POST /eval/simulation/onboarding/requirements`. The response includes the saved suite, its simulations, and requirement coverage, including any gaps.<br/>
        /// Requests can take up to 3 minutes. Set a client timeout of at least 200 seconds.<br/>
        /// Use a unique `idempotencyKey` for each suite generation request. Retrying with the same key does not create a duplicate suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for a different assistant or requirements. Send a new key.<br/>
        /// Review the generated simulations and coverage gaps. Revise the suite with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, then run it with `POST /eval/simulation/run`.<br/>
        /// Each organization can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite does not count toward these limits. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30) before retrying. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
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
        /// Generate and save a simulation suite from reviewed test requirements, and assign it to an assistant. First draft requirements with `POST /eval/simulation/onboarding/requirements`. The response includes the saved suite, its simulations, and requirement coverage, including any gaps.<br/>
        /// Requests can take up to 3 minutes. Set a client timeout of at least 200 seconds.<br/>
        /// Use a unique `idempotencyKey` for each suite generation request. Retrying with the same key does not create a duplicate suite:<br/>
        /// - On a timeout or a 5xx (502, 504, 524), retry with the same key. You get the saved suite, a 409 while it is still generating, or a fresh generation if the first one never saved.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_GENERATION_IN_PROGRESS`, the first request is still generating. Wait `Retry-After` seconds (15) and retry with the same key.<br/>
        /// - On a 409 `SIMULATION_ONBOARDING_IDEMPOTENCY_KEY_REUSED`, the key was used for a different assistant or requirements. Send a new key.<br/>
        /// Review the generated simulations and coverage gaps. Revise the suite with `PATCH /eval/simulation/onboarding/suite/{suiteId}`, then run it with `POST /eval/simulation/run`.<br/>
        /// Each organization can generate 20 suites per UTC day, shared with the dashboard, and 2 at a time. A retry that returns a saved suite does not count toward these limits. On a 429 `SIMULATION_ONBOARDING_CONCURRENCY_LIMITED`, wait `Retry-After` seconds (30) before retrying. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant the suite tests and is assigned to.
        /// </param>
        /// <param name="idempotencyKey">
        /// A unique key for this suite generation request. Retrying with the same key returns the saved suite, or a 409 while generation is in progress. Use a new key for a different assistant or requirements.
        /// </param>
        /// <param name="requirements">
        /// The reviewed test requirements to generate simulations for, from the requirements draft. Each requirement must have a unique id.
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