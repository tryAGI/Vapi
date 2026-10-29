#nullable enable

namespace Vapi
{
    public partial interface ISimulationSuitesClient
    {
        /// <summary>
        /// Draft simulation requirements<br/>
        /// Generate draft test requirements from an assistant's prompt, tools, and handoff configuration. The response includes numbered requirements describing expected behavior and open questions about behavior that needs clarification. Use this endpoint before generating a simulation suite.<br/>
        /// Review the requirements and resolve any open questions. To revise a draft, send it as `previousDraft` together with natural-language `feedback` describing the changes or answers. Once the requirements are ready, pass them to `POST /eval/simulation/onboarding/suite`.<br/>
        /// Requests can take up to 2 minutes. Each organization can draft requirements 60 times per UTC day, shared with the dashboard. A 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED` response means the daily limit has been reached. Wait until the limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingRequirementsDraftDTO> SimulationOnboardingControllerRequirementsDraftAsync(

            global::Vapi.SimulationOnboardingRequirementsCreateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Draft simulation requirements<br/>
        /// Generate draft test requirements from an assistant's prompt, tools, and handoff configuration. The response includes numbered requirements describing expected behavior and open questions about behavior that needs clarification. Use this endpoint before generating a simulation suite.<br/>
        /// Review the requirements and resolve any open questions. To revise a draft, send it as `previousDraft` together with natural-language `feedback` describing the changes or answers. Once the requirements are ready, pass them to `POST /eval/simulation/onboarding/suite`.<br/>
        /// Requests can take up to 2 minutes. Each organization can draft requirements 60 times per UTC day, shared with the dashboard. A 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED` response means the daily limit has been reached. Wait until the limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.SimulationOnboardingRequirementsDraftDTO>> SimulationOnboardingControllerRequirementsDraftAsResponseAsync(

            global::Vapi.SimulationOnboardingRequirementsCreateDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Draft simulation requirements<br/>
        /// Generate draft test requirements from an assistant's prompt, tools, and handoff configuration. The response includes numbered requirements describing expected behavior and open questions about behavior that needs clarification. Use this endpoint before generating a simulation suite.<br/>
        /// Review the requirements and resolve any open questions. To revise a draft, send it as `previousDraft` together with natural-language `feedback` describing the changes or answers. Once the requirements are ready, pass them to `POST /eval/simulation/onboarding/suite`.<br/>
        /// Requests can take up to 2 minutes. Each organization can draft requirements 60 times per UTC day, shared with the dashboard. A 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED` response means the daily limit has been reached. Wait until the limit resets at 00:00 UTC before retrying.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant to draft requirements for.
        /// </param>
        /// <param name="previousDraft">
        /// The draft being revised, exactly as this endpoint returned it. Send it with `feedback`.
        /// </param>
        /// <param name="feedback">
        /// Natural-language instructions for revising the requirements in `previousDraft`, including answers to open questions. Required when `previousDraft` is provided.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.SimulationOnboardingRequirementsDraftDTO> SimulationOnboardingControllerRequirementsDraftAsync(
            global::System.Guid assistantId,
            global::Vapi.SimulationOnboardingRequirementsDraftDTO? previousDraft = default,
            string? feedback = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}