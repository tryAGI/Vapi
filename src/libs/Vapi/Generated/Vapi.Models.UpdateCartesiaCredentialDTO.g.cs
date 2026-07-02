
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateCartesiaCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateCartesiaCredentialDTOProviderJsonConverter))]
        public global::Vapi.UpdateCartesiaCredentialDTOProvider? Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This can be used to point to an onprem Cartesia instance. Defaults to api.cartesia.ai.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCartesiaCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="apiUrl">
        /// This can be used to point to an onprem Cartesia instance. Defaults to api.cartesia.ai.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCartesiaCredentialDTO(
            global::Vapi.UpdateCartesiaCredentialDTOProvider? provider,
            string? apiKey,
            string? name,
            string? apiUrl)
        {
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.Name = name;
            this.ApiUrl = apiUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCartesiaCredentialDTO" /> class.
        /// </summary>
        public UpdateCartesiaCredentialDTO()
        {
        }

    }
}