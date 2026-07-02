
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateElevenLabsCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateElevenLabsCredentialDTOProviderJsonConverter))]
        public global::Vapi.UpdateElevenLabsCredentialDTOProvider? Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// ElevenLabs-only API environment for this key: the global endpoint or the EU data residency endpoint. If omitted on create, Vapi detects it automatically. If set to null on update, Vapi clears the saved endpoint and re-detects it with the saved API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiUrl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateElevenLabsCredentialDTOApiUrlJsonConverter))]
        public global::Vapi.UpdateElevenLabsCredentialDTOApiUrl? ApiUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateElevenLabsCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiUrl">
        /// ElevenLabs-only API environment for this key: the global endpoint or the EU data residency endpoint. If omitted on create, Vapi detects it automatically. If set to null on update, Vapi clears the saved endpoint and re-detects it with the saved API key.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateElevenLabsCredentialDTO(
            global::Vapi.UpdateElevenLabsCredentialDTOProvider? provider,
            string? apiKey,
            global::Vapi.UpdateElevenLabsCredentialDTOApiUrl? apiUrl,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.ApiUrl = apiUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateElevenLabsCredentialDTO" /> class.
        /// </summary>
        public UpdateElevenLabsCredentialDTO()
        {
        }

    }
}