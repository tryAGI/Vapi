
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateS3CompatibleCredentialDTO
    {
        /// <summary>
        /// This is for S3-compatible storage such as MinIO, Garage, Ceph, or Backblaze B2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateS3CompatibleCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreateS3CompatibleCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketPlan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.S3CompatibleBucketPlan BucketPlan { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateS3CompatibleCredentialDTO" /> class.
        /// </summary>
        /// <param name="bucketPlan"></param>
        /// <param name="provider">
        /// This is for S3-compatible storage such as MinIO, Garage, Ceph, or Backblaze B2.
        /// </param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateS3CompatibleCredentialDTO(
            global::Vapi.S3CompatibleBucketPlan bucketPlan,
            global::Vapi.CreateS3CompatibleCredentialDTOProvider provider,
            double? fallbackIndex,
            string? name)
        {
            this.Provider = provider;
            this.BucketPlan = bucketPlan ?? throw new global::System.ArgumentNullException(nameof(bucketPlan));
            this.FallbackIndex = fallbackIndex;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateS3CompatibleCredentialDTO" /> class.
        /// </summary>
        public CreateS3CompatibleCredentialDTO()
        {
        }

    }
}