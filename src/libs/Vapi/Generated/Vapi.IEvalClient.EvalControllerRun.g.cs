#nullable enable

namespace Vapi
{
    public partial interface IEvalClient
    {
        /// <summary>
        /// Create Eval Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EvalControllerRunAsync(

            global::Vapi.CreateEvalRunDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Eval Run
        /// </summary>
        /// <param name="eval">
        /// This is the transient eval that will be run
        /// </param>
        /// <param name="target">
        /// This is the target that will be run against the eval
        /// </param>
        /// <param name="type">
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </param>
        /// <param name="evalId">
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EvalControllerRunAsync(
            global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad> target,
            global::Vapi.CreateEvalDTO? eval = default,
            global::Vapi.CreateEvalRunDTOType type = default,
            string? evalId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}