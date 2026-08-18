
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFileDTO
    {
        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Optional product flow that owns the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateFileDTOPurposeJsonConverter))]
        public global::Vapi.CreateFileDTOPurpose? Purpose { get; set; }

        /// <summary>
        /// Optional JSON-encoded metadata for multipart uploads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileDTO" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFileDTO(
            byte[] file,
            string filename,
            global::Vapi.CreateFileDTOPurpose? purpose,
            string? metadata)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileDTO" /> class.
        /// </summary>
        public CreateFileDTO()
        {
        }

    }
}