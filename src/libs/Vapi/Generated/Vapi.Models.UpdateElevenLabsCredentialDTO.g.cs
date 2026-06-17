
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateElevenLabsCredentialDTO
    {
        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is the ElevenLabs API environment the key belongs to — the global endpoint or the EU data residency endpoint. It is detected automatically while validating the key and is not honored from the request, so a rotated key is always re-homed to the environment that actually accepts it.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseUrl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateElevenLabsCredentialDTOBaseUrlJsonConverter))]
        public global::Vapi.UpdateElevenLabsCredentialDTOBaseUrl? BaseUrl { get; set; }

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
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="baseUrl">
        /// This is the ElevenLabs API environment the key belongs to — the global endpoint or the EU data residency endpoint. It is detected automatically while validating the key and is not honored from the request, so a rotated key is always re-homed to the environment that actually accepts it.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateElevenLabsCredentialDTO(
            string? apiKey,
            global::Vapi.UpdateElevenLabsCredentialDTOBaseUrl? baseUrl,
            string? name)
        {
            this.ApiKey = apiKey;
            this.BaseUrl = baseUrl;
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