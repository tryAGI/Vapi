
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMicrosoftCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateMicrosoftCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreateMicrosoftCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// Azure region for the Speech resource. Defaults to `eastus` when omitted. MAI-Voice-2 is preview and region-limited.<br/>
        /// Example: eastus
        /// </summary>
        /// <example>eastus</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateMicrosoftCredentialDTO" /> class.
        /// </summary>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="region">
        /// Azure region for the Speech resource. Defaults to `eastus` when omitted. MAI-Voice-2 is preview and region-limited.<br/>
        /// Example: eastus
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMicrosoftCredentialDTO(
            string apiKey,
            global::Vapi.CreateMicrosoftCredentialDTOProvider provider,
            string? region,
            string? name)
        {
            this.Provider = provider;
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Region = region;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMicrosoftCredentialDTO" /> class.
        /// </summary>
        public CreateMicrosoftCredentialDTO()
        {
        }

    }
}