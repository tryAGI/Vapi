
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailFixedResponseAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailFixedResponseActionTypeJsonConverter))]
        public global::Vapi.GuardrailFixedResponseActionType Type { get; set; }

        /// <summary>
        /// Omitted legacy modes normalize to fixed when transformed.<br/>
        /// Default Value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailFixedResponseActionModeJsonConverter))]
        public global::Vapi.GuardrailFixedResponseActionMode? Mode { get; set; }

        /// <summary>
        /// Replacement speech; it must pass its own guardrail evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailFixedResponseAction" /> class.
        /// </summary>
        /// <param name="text">
        /// Replacement speech; it must pass its own guardrail evaluation.
        /// </param>
        /// <param name="type"></param>
        /// <param name="mode">
        /// Omitted legacy modes normalize to fixed when transformed.<br/>
        /// Default Value: fixed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailFixedResponseAction(
            string text,
            global::Vapi.GuardrailFixedResponseActionType type,
            global::Vapi.GuardrailFixedResponseActionMode? mode)
        {
            this.Type = type;
            this.Mode = mode;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailFixedResponseAction" /> class.
        /// </summary>
        public GuardrailFixedResponseAction()
        {
        }

    }
}