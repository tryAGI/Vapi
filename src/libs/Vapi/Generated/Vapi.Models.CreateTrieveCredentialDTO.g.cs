
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrieveCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateTrieveCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreateTrieveCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTrieveCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrieveCredentialDTO(
            string apiKey,
            global::Vapi.CreateTrieveCredentialDTOProvider provider,
            string? name)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Provider = provider;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrieveCredentialDTO" /> class.
        /// </summary>
        public CreateTrieveCredentialDTO()
        {
        }
    }
}