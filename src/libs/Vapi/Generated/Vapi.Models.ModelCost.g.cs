
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelCost
    {
        /// <summary>
        /// This is the type of cost, always 'model' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ModelCostTypeJsonConverter))]
        public global::Vapi.ModelCostType Type { get; set; }

        /// <summary>
        /// Provider-reported billable duration in seconds. Currently supplied for GPT-Live; omitted for token-billed models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public double? Seconds { get; set; }

        /// <summary>
        /// Whether the reported usage is complete. False means the cost reflects missing or partial usage and may understate provider spend. Omitted when the provider integration does not report completeness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usageComplete")]
        public bool? UsageComplete { get; set; }

        /// <summary>
        /// This is the model that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.model`,<br/>
        /// - `call.assistantId-&gt;model`,<br/>
        /// - `call.squad[n].assistant.model`,<br/>
        /// - `call.squad[n].assistantId-&gt;model`,<br/>
        /// - `call.squadId-&gt;[n].assistant.model`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Model { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used in the call. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedPromptTokens")]
        public double? CachedPromptTokens { get; set; }

        /// <summary>
        /// This is the number of reasoning tokens generated in the call. This is only applicable to reasoning models (e.g., OpenAI o-series, GPT-5) on providers that report them.<br/>
        /// This is a **subset of `completionTokens`**, not an addition to it: reasoning tokens are already counted in `completionTokens` and are already billed at the output-token rate. It is reported separately for visibility only and does not affect `cost`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCost" /> class.
        /// </summary>
        /// <param name="model">
        /// This is the model that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.model`,<br/>
        /// - `call.assistantId-&gt;model`,<br/>
        /// - `call.squad[n].assistant.model`,<br/>
        /// - `call.squad[n].assistantId-&gt;model`,<br/>
        /// - `call.squadId-&gt;[n].assistant.model`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used in the call. These should be total prompt tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated in the call. These should be total completion tokens used in the call for single assistant calls, while squad calls will have multiple model costs one for each assistant that was used.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'model' for this class.
        /// </param>
        /// <param name="seconds">
        /// Provider-reported billable duration in seconds. Currently supplied for GPT-Live; omitted for token-billed models.
        /// </param>
        /// <param name="usageComplete">
        /// Whether the reported usage is complete. False means the cost reflects missing or partial usage and may understate provider spend. Omitted when the provider integration does not report completeness.
        /// </param>
        /// <param name="cachedPromptTokens">
        /// This is the number of cached prompt tokens used in the call. This is only applicable to certain providers (e.g., OpenAI, Azure OpenAI) that support prompt caching. Cached tokens are billed at a discounted rate.
        /// </param>
        /// <param name="reasoningTokens">
        /// This is the number of reasoning tokens generated in the call. This is only applicable to reasoning models (e.g., OpenAI o-series, GPT-5) on providers that report them.<br/>
        /// This is a **subset of `completionTokens`**, not an addition to it: reasoning tokens are already counted in `completionTokens` and are already billed at the output-token rate. It is reported separately for visibility only and does not affect `cost`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCost(
            object model,
            double promptTokens,
            double completionTokens,
            double cost,
            global::Vapi.ModelCostType type,
            double? seconds,
            bool? usageComplete,
            double? cachedPromptTokens,
            double? reasoningTokens)
        {
            this.Type = type;
            this.Seconds = seconds;
            this.UsageComplete = usageComplete;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedPromptTokens = cachedPromptTokens;
            this.ReasoningTokens = reasoningTokens;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCost" /> class.
        /// </summary>
        public ModelCost()
        {
        }

    }
}