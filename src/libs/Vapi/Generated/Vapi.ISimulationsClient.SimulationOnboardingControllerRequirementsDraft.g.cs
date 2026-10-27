#nullable enable

namespace Vapi
{
    public partial interface ISimulationsClient
    {
        /// <summary>
        /// Draft simulation requirements<br/>
        /// Drafts the behaviours an assistant must get right, as numbered requirements plus open questions, from its prompt, tools and handoffs. This is the first step of building a simulation suite.<br/>
        /// 1. Show the draft to your user and ask its open questions.<br/>
        /// 2. To revise it, call again with `previousDraft` set to the draft and `feedback` set to what the user said, verbatim. Repeat until they agree.<br/>
        /// 3. Generate the suite from the agreed requirements with `POST /eval/simulation/onboarding/suite`.<br/>
        /// Takes up to 2 minutes. Each org can draft 60 times per UTC day, shared with the dashboard. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: tell your user the limit resets at 00:00 UTC.
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
        /// Drafts the behaviours an assistant must get right, as numbered requirements plus open questions, from its prompt, tools and handoffs. This is the first step of building a simulation suite.<br/>
        /// 1. Show the draft to your user and ask its open questions.<br/>
        /// 2. To revise it, call again with `previousDraft` set to the draft and `feedback` set to what the user said, verbatim. Repeat until they agree.<br/>
        /// 3. Generate the suite from the agreed requirements with `POST /eval/simulation/onboarding/suite`.<br/>
        /// Takes up to 2 minutes. Each org can draft 60 times per UTC day, shared with the dashboard. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: tell your user the limit resets at 00:00 UTC.
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
        /// Drafts the behaviours an assistant must get right, as numbered requirements plus open questions, from its prompt, tools and handoffs. This is the first step of building a simulation suite.<br/>
        /// 1. Show the draft to your user and ask its open questions.<br/>
        /// 2. To revise it, call again with `previousDraft` set to the draft and `feedback` set to what the user said, verbatim. Repeat until they agree.<br/>
        /// 3. Generate the suite from the agreed requirements with `POST /eval/simulation/onboarding/suite`.<br/>
        /// Takes up to 2 minutes. Each org can draft 60 times per UTC day, shared with the dashboard. On a 429 `SIMULATION_ONBOARDING_QUOTA_EXCEEDED`, don't retry: tell your user the limit resets at 00:00 UTC.
        /// </summary>
        /// <param name="assistantId">
        /// Assistant to draft requirements for.
        /// </param>
        /// <param name="previousDraft">
        /// The draft being revised, exactly as this endpoint returned it. Send it with `feedback`.
        /// </param>
        /// <param name="feedback">
        /// What your user wants changed in `previousDraft`, in the user's own words. Send it with `previousDraft`.
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