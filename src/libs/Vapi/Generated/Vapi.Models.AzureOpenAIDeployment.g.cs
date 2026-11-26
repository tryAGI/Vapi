
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AzureOpenAIDeployment
    {
        /// <summary>
        /// This is the model the deployment serves. It must be one of the credential's `models`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.AzureOpenAIDeploymentModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.AzureOpenAIDeploymentModel Model { get; set; }

        /// <summary>
        /// This is the name of the deployment in your Azure resource, exactly as Azure shows it.<br/>
        /// Example: gpt-5.4-clinic-a
        /// </summary>
        /// <example>gpt-5.4-clinic-a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIDeployment" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model the deployment serves. It must be one of the credential's `models`.
        /// </param>
        /// <param name="name">
        /// This is the name of the deployment in your Azure resource, exactly as Azure shows it.<br/>
        /// Example: gpt-5.4-clinic-a
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AzureOpenAIDeployment(
            global::Vapi.AzureOpenAIDeploymentModel model,
            string name)
        {
            this.Model = model;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIDeployment" /> class.
        /// </summary>
        public AzureOpenAIDeployment()
        {
        }

    }
}