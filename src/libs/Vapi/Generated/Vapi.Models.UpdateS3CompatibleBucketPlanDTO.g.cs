
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateS3CompatibleBucketPlanDTO
    {
        /// <summary>
        /// S3-compatible endpoint URL, such as https://s3.us-west-004.backblazeb2.com. Must be public HTTPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// SigV4 signing region expected by the object store. Most stores accept us-east-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// S3 access key ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        public string? AccessKeyId { get; set; }

        /// <summary>
        /// S3 secret access key. This is not returned in the API.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secretAccessKey")]
        public string? SecretAccessKey { get; set; }

        /// <summary>
        /// Bucket name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional key prefix inside the bucket, such as recordings/.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateS3CompatibleBucketPlanDTO" /> class.
        /// </summary>
        /// <param name="url">
        /// S3-compatible endpoint URL, such as https://s3.us-west-004.backblazeb2.com. Must be public HTTPS.
        /// </param>
        /// <param name="region">
        /// SigV4 signing region expected by the object store. Most stores accept us-east-1.
        /// </param>
        /// <param name="accessKeyId">
        /// S3 access key ID.
        /// </param>
        /// <param name="secretAccessKey">
        /// S3 secret access key. This is not returned in the API.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="name">
        /// Bucket name.
        /// </param>
        /// <param name="path">
        /// Optional key prefix inside the bucket, such as recordings/.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateS3CompatibleBucketPlanDTO(
            string? url,
            string? region,
            string? accessKeyId,
            string? secretAccessKey,
            string? name,
            string? path)
        {
            this.Url = url;
            this.Region = region;
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.Name = name;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateS3CompatibleBucketPlanDTO" /> class.
        /// </summary>
        public UpdateS3CompatibleBucketPlanDTO()
        {
        }

    }
}