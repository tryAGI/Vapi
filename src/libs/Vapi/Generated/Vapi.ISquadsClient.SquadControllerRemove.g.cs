#nullable enable

namespace Vapi
{
    public partial interface ISquadsClient
    {
        /// <summary>
        /// Delete Squad
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Squad> SquadControllerRemoveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}