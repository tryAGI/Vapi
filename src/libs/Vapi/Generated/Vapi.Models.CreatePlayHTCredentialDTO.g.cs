
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePlayHTCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreatePlayHTCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreatePlayHTCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

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
        /// Initializes a new instance of the <see cref="CreatePlayHTCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="apiKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="userId"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePlayHTCredentialDTO(
            string apiKey,
            string userId,
            global::Vapi.CreatePlayHTCredentialDTOProvider provider,
            string? name)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Provider = provider;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePlayHTCredentialDTO" /> class.
        /// </summary>
        public CreatePlayHTCredentialDTO()
        {
        }
    }
}