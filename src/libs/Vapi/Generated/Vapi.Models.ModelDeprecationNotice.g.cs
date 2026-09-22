
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelDeprecationNotice
    {
        /// <summary>
        /// Path of the slot that carries the model, relative to the response root,<br/>
        /// e.g. `model`, `model.fallbackModels[1]`, `transcriber`, `voice`, or<br/>
        /// `members[2].assistantOverrides.model` on a squad.<br/>
        /// Example: model.fallbackModels[1]
        /// </summary>
        /// <example>model.fallbackModels[1]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slot")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slot { get; set; }

        /// <summary>
        /// Provider as stored on the slot.<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Model name as stored on the slot.<br/>
        /// Example: gpt-4-1106-preview
        /// </summary>
        /// <example>gpt-4-1106-preview</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Day the model became deprecated, `YYYY-MM-DD` in UTC.<br/>
        /// Example: 2025-09-26
        /// </summary>
        /// <example>2025-09-26</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecationDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeprecationDate { get; set; }

        /// <summary>
        /// Day the model is or was retired, `YYYY-MM-DD` in UTC. On and after this<br/>
        /// day Vapi no longer runs the model as configured.<br/>
        /// Example: 2026-03-26
        /// </summary>
        /// <example>2026-03-26</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retirementDate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RetirementDate { get; set; }

        /// <summary>
        /// The recommended migration target for the slot's model: the registry's<br/>
        /// replacement, followed through any further retirements as of the response<br/>
        /// date, so it names a model that is alive on that day. A `&lt;model&gt;:&lt;region&gt;`<br/>
        /// pin on the slot's model is kept on the target.<br/>
        /// Example: gpt-5
        /// </summary>
        /// <example>gpt-5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("replacementModel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplacementModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationNotice" /> class.
        /// </summary>
        /// <param name="slot">
        /// Path of the slot that carries the model, relative to the response root,<br/>
        /// e.g. `model`, `model.fallbackModels[1]`, `transcriber`, `voice`, or<br/>
        /// `members[2].assistantOverrides.model` on a squad.<br/>
        /// Example: model.fallbackModels[1]
        /// </param>
        /// <param name="provider">
        /// Provider as stored on the slot.<br/>
        /// Example: openai
        /// </param>
        /// <param name="model">
        /// Model name as stored on the slot.<br/>
        /// Example: gpt-4-1106-preview
        /// </param>
        /// <param name="deprecationDate">
        /// Day the model became deprecated, `YYYY-MM-DD` in UTC.<br/>
        /// Example: 2025-09-26
        /// </param>
        /// <param name="retirementDate">
        /// Day the model is or was retired, `YYYY-MM-DD` in UTC. On and after this<br/>
        /// day Vapi no longer runs the model as configured.<br/>
        /// Example: 2026-03-26
        /// </param>
        /// <param name="replacementModel">
        /// The recommended migration target for the slot's model: the registry's<br/>
        /// replacement, followed through any further retirements as of the response<br/>
        /// date, so it names a model that is alive on that day. A `&lt;model&gt;:&lt;region&gt;`<br/>
        /// pin on the slot's model is kept on the target.<br/>
        /// Example: gpt-5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelDeprecationNotice(
            string slot,
            string provider,
            string model,
            string deprecationDate,
            string retirementDate,
            string replacementModel)
        {
            this.Slot = slot ?? throw new global::System.ArgumentNullException(nameof(slot));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.DeprecationDate = deprecationDate ?? throw new global::System.ArgumentNullException(nameof(deprecationDate));
            this.RetirementDate = retirementDate ?? throw new global::System.ArgumentNullException(nameof(retirementDate));
            this.ReplacementModel = replacementModel ?? throw new global::System.ArgumentNullException(nameof(replacementModel));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDeprecationNotice" /> class.
        /// </summary>
        public ModelDeprecationNotice()
        {
        }

    }
}