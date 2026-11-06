
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailAuthoring
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailAuthoringModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.GuardrailAuthoringMode Mode { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Behavior { get; set; }

        /// <summary>
        /// Natural-language condition evaluated using the candidate and call history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailAuthoring" /> class.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="behavior"></param>
        /// <param name="condition">
        /// Natural-language condition evaluated using the candidate and call history.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailAuthoring(
            global::Vapi.GuardrailAuthoringMode mode,
            string behavior,
            string? condition)
        {
            this.Mode = mode;
            this.Behavior = behavior ?? throw new global::System.ArgumentNullException(nameof(behavior));
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailAuthoring" /> class.
        /// </summary>
        public GuardrailAuthoring()
        {
        }

    }
}