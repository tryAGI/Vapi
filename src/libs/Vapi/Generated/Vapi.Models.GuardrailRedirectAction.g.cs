
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailRedirectAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailRedirectActionTypeJsonConverter))]
        public global::Vapi.GuardrailRedirectActionType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailRedirectActionModeJsonConverter))]
        public global::Vapi.GuardrailRedirectActionMode Mode { get; set; }

        /// <summary>
        /// Steering instructions for generating a replacement candidate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRedirectAction" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Steering instructions for generating a replacement candidate.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailRedirectAction(
            string instructions,
            global::Vapi.GuardrailRedirectActionType type,
            global::Vapi.GuardrailRedirectActionMode mode)
        {
            this.Type = type;
            this.Mode = mode;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailRedirectAction" /> class.
        /// </summary>
        public GuardrailRedirectAction()
        {
        }

    }
}