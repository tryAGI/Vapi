
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePlayHTCredentialDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdatePlayHTCredentialDTOProviderJsonConverter))]
        public global::Vapi.UpdatePlayHTCredentialDTOProvider? Provider { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayHTCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePlayHTCredentialDTO(
            global::Vapi.UpdatePlayHTCredentialDTOProvider? provider,
            string? apiKey,
            string? name,
            string? userId)
        {
            this.Provider = provider;
            this.ApiKey = apiKey;
            this.Name = name;
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePlayHTCredentialDTO" /> class.
        /// </summary>
        public UpdatePlayHTCredentialDTO()
        {
        }

    }
}