
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicKeyEncryptionPlan
    {
        /// <summary>
        /// The type of encryption plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanTypeJsonConverter))]
        public global::Vapi.PublicKeyEncryptionPlanType Type { get; set; }

        /// <summary>
        /// The encryption algorithm to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("algorithm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PublicKeyEncryptionPlanAlgorithmJsonConverter))]
        public global::Vapi.PublicKeyEncryptionPlanAlgorithm Algorithm { get; set; }

        /// <summary>
        /// The public key configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SpkiPemPublicKeyConfig PublicKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlan" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of encryption plan.
        /// </param>
        /// <param name="algorithm">
        /// The encryption algorithm to use.
        /// </param>
        /// <param name="publicKey">
        /// The public key configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicKeyEncryptionPlan(
            global::Vapi.SpkiPemPublicKeyConfig publicKey,
            global::Vapi.PublicKeyEncryptionPlanType type,
            global::Vapi.PublicKeyEncryptionPlanAlgorithm algorithm)
        {
            this.PublicKey = publicKey ?? throw new global::System.ArgumentNullException(nameof(publicKey));
            this.Type = type;
            this.Algorithm = algorithm;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyEncryptionPlan" /> class.
        /// </summary>
        public PublicKeyEncryptionPlan()
        {
        }
    }
}