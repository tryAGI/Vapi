
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAzureOpenAICredentialDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTOProviderJsonConverter))]
        public global::Vapi.UpdateAzureOpenAICredentialDTOProvider? Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateAzureOpenAICredentialDTORegionJsonConverter))]
        public global::Vapi.UpdateAzureOpenAICredentialDTORegion? Region { get; set; }

        /// <summary>
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </summary>
        /// <example>[gpt-4-0125-preview, gpt-4-0613]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? Models { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIKey")]
        public string? OpenAIKey { get; set; }

        /// <summary>
        /// This is not returned in the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocpApimSubscriptionKey")]
        public string? OcpApimSubscriptionKey { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// These are the names of your Azure deployments, one entry for every model in `models`. Omit the field when every deployment is named after its model; once it has any entry, a model with no entry is rejected, so a deployment named after its model takes `{ "model": "&lt;model&gt;", "name": "&lt;model&gt;" }`. Requests use the first of the org's keys that matches the region (on a live call, also the model), so an org holding two keys for the same region and model should pin `credentialIds` on its assistants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployments")]
        public global::System.Collections.Generic.IList<global::Vapi.AzureOpenAIDeployment>? Deployments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openAIEndpoint")]
        public string? OpenAIEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="region"></param>
        /// <param name="models">
        /// Example: [gpt-4-0125-preview, gpt-4-0613]
        /// </param>
        /// <param name="openAIKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="ocpApimSubscriptionKey">
        /// This is not returned in the API.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        /// <param name="deployments">
        /// These are the names of your Azure deployments, one entry for every model in `models`. Omit the field when every deployment is named after its model; once it has any entry, a model with no entry is rejected, so a deployment named after its model takes `{ "model": "&lt;model&gt;", "name": "&lt;model&gt;" }`. Requests use the first of the org's keys that matches the region (on a live call, also the model), so an org holding two keys for the same region and model should pin `credentialIds` on its assistants.
        /// </param>
        /// <param name="openAIEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAzureOpenAICredentialDTO(
            global::Vapi.UpdateAzureOpenAICredentialDTOProvider? provider,
            global::Vapi.UpdateAzureOpenAICredentialDTORegion? region,
            global::System.Collections.Generic.IList<global::Vapi.UpdateAzureOpenAICredentialDTOModel>? models,
            string? openAIKey,
            string? ocpApimSubscriptionKey,
            string? name,
            global::System.Collections.Generic.IList<global::Vapi.AzureOpenAIDeployment>? deployments,
            string? openAIEndpoint)
        {
            this.Provider = provider;
            this.Region = region;
            this.Models = models;
            this.OpenAIKey = openAIKey;
            this.OcpApimSubscriptionKey = ocpApimSubscriptionKey;
            this.Name = name;
            this.Deployments = deployments;
            this.OpenAIEndpoint = openAIEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureOpenAICredentialDTO" /> class.
        /// </summary>
        public UpdateAzureOpenAICredentialDTO()
        {
        }

    }
}