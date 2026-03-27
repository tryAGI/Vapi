
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowOpenAIModel
    {
        /// <summary>
        /// This is the provider of the model (`openai`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelProviderJsonConverter))]
        public global::Vapi.WorkflowOpenAIModelProvider Provider { get; set; }

        /// <summary>
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.WorkflowOpenAIModelModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.WorkflowOpenAIModelModel Model { get; set; }

        /// <summary>
        /// This is the temperature of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// This is the max tokens of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider of the model (`openai`).
        /// </param>
        /// <param name="model">
        /// This is the OpenAI model that will be used.<br/>
        /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.<br/>
        /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
        /// </param>
        /// <param name="temperature">
        /// This is the temperature of the model.
        /// </param>
        /// <param name="maxTokens">
        /// This is the max tokens of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowOpenAIModel(
            global::Vapi.WorkflowOpenAIModelModel model,
            global::Vapi.WorkflowOpenAIModelProvider provider,
            double? temperature,
            double? maxTokens)
        {
            this.Model = model;
            this.Provider = provider;
            this.Temperature = temperature;
            this.MaxTokens = maxTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowOpenAIModel" /> class.
        /// </summary>
        public WorkflowOpenAIModel()
        {
        }
    }
}