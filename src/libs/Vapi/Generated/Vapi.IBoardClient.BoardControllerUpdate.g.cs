#nullable enable

namespace Vapi
{
    public partial interface IBoardClient
    {
        /// <summary>
        /// Update Board
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Board> BoardControllerUpdateAsync(
            global::System.Guid id,

            global::Vapi.UpdateBoardDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Board
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.Board>> BoardControllerUpdateAsResponseAsync(
            global::System.Guid id,

            global::Vapi.UpdateBoardDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Board
        /// </summary>
        /// <param name="id"></param>
        /// <param name="items">
        /// This is the contents of the Board, which is an array of objects defining the type, contents, and position of the widgets on the Board.
        /// </param>
        /// <param name="name">
        /// This is the name of the Board.
        /// </param>
        /// <param name="layout">
        /// This is the layout of the Board.
        /// </param>
        /// <param name="timeRangeOverride">
        /// This is the timerange override for the board.<br/>
        /// By default, individual insights have their own timerange.<br/>
        /// This is a global override for the board which will be passed to all insights on the board.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.Board> BoardControllerUpdateAsync(
            global::System.Guid id,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.BoardInsightItem, global::Vapi.BoardMetricWidgetItem>>? items = default,
            string? name = default,
            global::Vapi.BoardLayout? layout = default,
            global::Vapi.InsightTimeRangeWithStep? timeRangeOverride = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}