#nullable enable

namespace Vapi
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.File> FileControllerCreateAsync(

            global::Vapi.CreateFileDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.File>> FileControllerCreateAsResponseAsync(

            global::Vapi.CreateFileDTO request,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// Optional product flow that owns the uploaded file.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON-encoded metadata for multipart uploads.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.File> FileControllerCreateAsync(
            byte[] file,
            string filename,
            global::Vapi.CreateFileDTOPurpose? purpose = default,
            string? metadata = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// Optional product flow that owns the uploaded file.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON-encoded metadata for multipart uploads.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.File> FileControllerCreateAsync(
            global::System.IO.Stream file,
            string filename,
            global::Vapi.CreateFileDTOPurpose? purpose = default,
            string? metadata = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="purpose">
        /// Optional product flow that owns the uploaded file.
        /// </param>
        /// <param name="metadata">
        /// Optional JSON-encoded metadata for multipart uploads.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.AutoSDKHttpResponse<global::Vapi.File>> FileControllerCreateAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Vapi.CreateFileDTOPurpose? purpose = default,
            string? metadata = default,
            global::Vapi.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}