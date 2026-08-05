
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StructuredOutputCostBreakdown
    {
        /// <summary>
        /// This is the unique identifier of the structured output that produced this cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structuredOutputId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StructuredOutputId { get; set; }

        /// <summary>
        /// This is the name of the structured output, so this breakdown is readable without looking the id up.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the cost in USD of evaluating this structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// This is the number of prompt tokens used to evaluate this structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// This is the number of completion tokens generated for this structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// This is the number of cached prompt tokens used to evaluate this structured output. This is a subset of `promptTokens`, not an addition to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedPromptTokens")]
        public double? CachedPromptTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputCostBreakdown" /> class.
        /// </summary>
        /// <param name="structuredOutputId">
        /// This is the unique identifier of the structured output that produced this cost.
        /// </param>
        /// <param name="name">
        /// This is the name of the structured output, so this breakdown is readable without looking the id up.
        /// </param>
        /// <param name="cost">
        /// This is the cost in USD of evaluating this structured output.
        /// </param>
        /// <param name="promptTokens">
        /// This is the number of prompt tokens used to evaluate this structured output.
        /// </param>
        /// <param name="completionTokens">
        /// This is the number of completion tokens generated for this structured output.
        /// </param>
        /// <param name="cachedPromptTokens">
        /// This is the number of cached prompt tokens used to evaluate this structured output. This is a subset of `promptTokens`, not an addition to it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputCostBreakdown(
            string structuredOutputId,
            string name,
            double cost,
            double promptTokens,
            double completionTokens,
            double? cachedPromptTokens)
        {
            this.StructuredOutputId = structuredOutputId ?? throw new global::System.ArgumentNullException(nameof(structuredOutputId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Cost = cost;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedPromptTokens = cachedPromptTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputCostBreakdown" /> class.
        /// </summary>
        public StructuredOutputCostBreakdown()
        {
        }

    }
}