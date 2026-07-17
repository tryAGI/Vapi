
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class S3CompatibleBucketPlan
    {
        /// <summary>
        /// S3-compatible endpoint URL, such as https://s3.us-west-004.backblazeb2.com. Must be public HTTPS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// SigV4 signing region expected by the object store. Most stores accept us-east-1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// S3 access key ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accessKeyId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessKeyId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="S3CompatibleBucketPlan" /> class.
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
        /// <param name="name">
        /// Bucket name.
        /// </param>
        /// <param name="secretAccessKey">
        /// S3 secret access key. This is not returned in the API.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="path">
        /// Optional key prefix inside the bucket, such as recordings/.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public S3CompatibleBucketPlan(
            string url,
            string region,
            string accessKeyId,
            string name,
            string? secretAccessKey,
            string? path)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.AccessKeyId = accessKeyId ?? throw new global::System.ArgumentNullException(nameof(accessKeyId));
            this.SecretAccessKey = secretAccessKey;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3CompatibleBucketPlan" /> class.
        /// </summary>
        public S3CompatibleBucketPlan()
        {
        }

    }
}