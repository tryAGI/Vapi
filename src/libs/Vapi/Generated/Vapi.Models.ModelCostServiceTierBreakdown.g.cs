
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelCostServiceTierBreakdown
    {
        /// <summary>
        /// This is the service tier OpenAI reported serving a request that asked for Fast mode, in Vapi's names: `fast` when Fast mode was served, otherwise the tier served, such as `default`. It is absent on the row for usage with no reported tier: requests that did not ask for Fast mode, requests that ended before OpenAI reported a tier, and other providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceTier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// This is the cost in USD of the usage at this tier, rounded to 8 decimal places.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used at this tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens generated at this tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used at this tier. This is a subset of `promptTokens`, not an addition to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedPromptTokens")]
        public double? CachedPromptTokens { get; set; }

        /// <summary>
        /// This is the number of reasoning tokens generated at this tier. This is a subset of `completionTokens`, not an addition to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        public double? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCostServiceTierBreakdown" /> class.
        /// </summary>
        /// <param name="cost">
        /// This is the cost in USD of the usage at this tier, rounded to 8 decimal places.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used at this tier.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated at this tier.
        /// </param>
        /// <param name="serviceTier">
        /// This is the service tier OpenAI reported serving a request that asked for Fast mode, in Vapi's names: `fast` when Fast mode was served, otherwise the tier served, such as `default`. It is absent on the row for usage with no reported tier: requests that did not ask for Fast mode, requests that ended before OpenAI reported a tier, and other providers.
        /// </param>
        /// <param name="cachedPromptTokens">
        /// This is the number of cached prompt tokens used at this tier. This is a subset of `promptTokens`, not an addition to it.
        /// </param>
        /// <param name="reasoningTokens">
        /// This is the number of reasoning tokens generated at this tier. This is a subset of `completionTokens`, not an addition to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelCostServiceTierBreakdown(
            double cost,
            double promptTokens,
            double completionTokens,
            string? serviceTier,
            double? cachedPromptTokens,
            double? reasoningTokens)
        {
            this.ServiceTier = serviceTier;
            this.Cost = cost;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedPromptTokens = cachedPromptTokens;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelCostServiceTierBreakdown" /> class.
        /// </summary>
        public ModelCostServiceTierBreakdown()
        {
        }

    }
}