
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class S3CompatibleStorageCredential
    {
        /// <summary>
        /// This is for S3-compatible storage such as MinIO, Garage, Ceph, or Backblaze B2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.S3CompatibleStorageCredentialProviderJsonConverter))]
        public global::Vapi.S3CompatibleStorageCredentialProvider Provider { get; set; }

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
        /// This is the unique identifier for the credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this credential belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="S3CompatibleStorageCredential" /> class.
        /// </summary>
        /// <param name="bucketPlan"></param>
        /// <param name="id">
        /// This is the unique identifier for the credential.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this credential belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the credential was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the assistant was last updated.
        /// </param>
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
        public S3CompatibleStorageCredential(
            global::Vapi.S3CompatibleBucketPlan bucketPlan,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Vapi.S3CompatibleStorageCredentialProvider provider,
            double? fallbackIndex,
            string? name)
        {
            this.Provider = provider;
            this.BucketPlan = bucketPlan ?? throw new global::System.ArgumentNullException(nameof(bucketPlan));
            this.FallbackIndex = fallbackIndex;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="S3CompatibleStorageCredential" /> class.
        /// </summary>
        public S3CompatibleStorageCredential()
        {
        }

    }
}