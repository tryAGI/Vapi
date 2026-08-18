
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KnowledgeBaseV2File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBaseV2Id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KnowledgeBaseV2Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimetype")]
        public string? Mimetype { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public double? Bytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.KnowledgeBaseV2FileStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.KnowledgeBaseV2FileStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseV2File" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="knowledgeBaseV2Id"></param>
        /// <param name="fileId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="fileName"></param>
        /// <param name="mimetype"></param>
        /// <param name="bytes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KnowledgeBaseV2File(
            string id,
            string knowledgeBaseV2Id,
            string fileId,
            global::Vapi.KnowledgeBaseV2FileStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? fileName,
            string? mimetype,
            double? bytes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KnowledgeBaseV2Id = knowledgeBaseV2Id ?? throw new global::System.ArgumentNullException(nameof(knowledgeBaseV2Id));
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.FileName = fileName;
            this.Mimetype = mimetype;
            this.Bytes = bytes;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KnowledgeBaseV2File" /> class.
        /// </summary>
        public KnowledgeBaseV2File()
        {
        }

    }
}