
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGcpCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateGcpCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreateGcpCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackIndex")]
        public double? FallbackIndex { get; set; }

        /// <summary>
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcpKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GcpKey GcpKey { get; set; }

        /// <summary>
        /// This is the region of the GCP resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketPlan")]
        public global::Vapi.BucketPlan? BucketPlan { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateGcpCredentialDTO" /> class.
        /// </summary>
        /// <param name="gcpKey">
        /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.<br/>
        /// The schema is identical to the JSON that GCP outputs.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="fallbackIndex">
        /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
        /// </param>
        /// <param name="region">
        /// This is the region of the GCP resource.
        /// </param>
        /// <param name="bucketPlan"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGcpCredentialDTO(
            global::Vapi.GcpKey gcpKey,
            global::Vapi.CreateGcpCredentialDTOProvider provider,
            double? fallbackIndex,
            string? region,
            global::Vapi.BucketPlan? bucketPlan,
            string? name)
        {
            this.Provider = provider;
            this.FallbackIndex = fallbackIndex;
            this.GcpKey = gcpKey ?? throw new global::System.ArgumentNullException(nameof(gcpKey));
            this.Region = region;
            this.BucketPlan = bucketPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGcpCredentialDTO" /> class.
        /// </summary>
        public CreateGcpCredentialDTO()
        {
        }
    }
}