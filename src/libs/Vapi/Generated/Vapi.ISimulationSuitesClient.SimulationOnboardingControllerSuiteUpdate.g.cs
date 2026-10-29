#nullable enable

namespace Vapi
{
    public partial interface ISimulationSuitesClient
    {
        /// <summary>
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteUpdateAsync(
            string suiteId,

            global::Vapi.SimulationOnboardingSuiteUpdateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingSuiteViewDTO>> SimulationOnboardingControllerSuiteUpdateAsResponseAsync(
            string suiteId,

            global::Vapi.SimulationOnboardingSuiteUpdateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit a generated simulation suite<br/>
        /// Revise a suite created by `POST /eval/simulation/onboarding/suite`. Remove simulations, rewrite scenarios using natural-language instructions, or set `retryFailed` to regenerate scenarios that failed or exceeded generation limits. The response includes the updated suite and requirement coverage.<br/>
        /// Requests can take up to 2 minutes.<br/>
        /// Send a new `patchKey` for each edit. Replaying an applied key changes nothing and returns the current suite, with `failedEditSimulationIds` listing the simulations that edit could not rewrite, so retry a timeout or a 5xx with the same key. A suite remembers its last 50 keys, so never reuse one.<br/>
        /// Each organization can make 60 edits per UTC day, shared with the dashboard. Requests that only remove simulations and replays of applied edits do not count toward this limit. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, wait until the daily limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="suiteId"></param>
        /// <param name="patchKey">
        /// A new key for each edit. Replaying an applied key changes nothing and returns the current suite. A suite remembers its last 50 keys, so never reuse one.
        /// </param>
        /// <param name="removeSimulationIds">
        /// Simulations to take out of the suite. They are unlinked, not deleted.
        /// </param>
        /// <param name="edits">
        /// Simulations to rewrite in place, at most one edit per simulation: put every change for a simulation in one instruction.
        /// </param>
        /// <param name="retryFailed">
        /// Regenerate the scenarios that failed or did not fit when the suite was generated.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingSuiteViewDTO> SimulationOnboardingControllerSuiteUpdateAsync(
            string suiteId,
            string patchKey,
            global::System.Collections.Generic.IList<global::System.Guid>? removeSimulationIds = default,
            global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteEditDTO>? edits = default,
            bool? retryFailed = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}