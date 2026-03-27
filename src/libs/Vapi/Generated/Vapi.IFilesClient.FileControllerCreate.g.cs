#nullable enable

namespace Vapi
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Vapi.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.File> FileControllerCreateAsync(

            global::Vapi.CreateFileDTO request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="file">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        /// <param name="filename">
        /// This is the File you want to upload for use with the Knowledge Base.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Vapi.File> FileControllerCreateAsync(
            byte[] file,
            string filename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}