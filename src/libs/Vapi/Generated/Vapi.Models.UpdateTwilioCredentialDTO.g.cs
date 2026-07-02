
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTwilioCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateTwilioCredentialDTOProviderJsonConverter))]
        public global::Vapi.UpdateTwilioCredentialDTOProvider? Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authToken")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSecret")]
        public string? ApiSecret { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountSid")]
        public string? AccountSid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="authToken">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="apiSecret">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="accountSid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTwilioCredentialDTO(
            global::Vapi.UpdateTwilioCredentialDTOProvider? provider,
            string? authToken,
            string? apiKey,
            string? apiSecret,
            string? name,
            string? accountSid)
        {
            this.Provider = provider;
            this.AuthToken = authToken;
            this.ApiKey = apiKey;
            this.ApiSecret = apiSecret;
            this.Name = name;
            this.AccountSid = accountSid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTwilioCredentialDTO" /> class.
        /// </summary>
        public UpdateTwilioCredentialDTO()
        {
        }

    }
}