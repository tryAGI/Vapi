
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSlackWebhookCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateSlackWebhookCredentialDTOProviderJsonConverter))]
        public global::Vapi.CreateSlackWebhookCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="webhookUrl">
        /// Slack incoming webhook URL. See https://api.slack.com/messaging/webhooks for setup instructions. This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSlackWebhookCredentialDTO(
            string webhookUrl,
            global::Vapi.CreateSlackWebhookCredentialDTOProvider provider,
            string? name)
        {
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Provider = provider;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSlackWebhookCredentialDTO" /> class.
        /// </summary>
        public CreateSlackWebhookCredentialDTO()
        {
        }
    }
}