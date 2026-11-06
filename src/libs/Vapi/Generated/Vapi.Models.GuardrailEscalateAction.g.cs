
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailEscalateAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GuardrailEscalateActionTypeJsonConverter))]
        public global::Vapi.GuardrailEscalateActionType Type { get; set; }

        /// <summary>
        /// Existing same-organization tool; attachment is checked at assignment. Tool edits/deletion can invalidate the action: activation must revalidate the current tool and arguments, and use failurePolicy on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ToolId { get; set; }

        /// <summary>
        /// Parameter names follow the normalized tool schema (SMS uses body/to).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailEscalateAction" /> class.
        /// </summary>
        /// <param name="toolId">
        /// Existing same-organization tool; attachment is checked at assignment. Tool edits/deletion can invalidate the action: activation must revalidate the current tool and arguments, and use failurePolicy on failure.
        /// </param>
        /// <param name="arguments">
        /// Parameter names follow the normalized tool schema (SMS uses body/to).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailEscalateAction(
            global::System.Guid toolId,
            object arguments,
            global::Vapi.GuardrailEscalateActionType type)
        {
            this.Type = type;
            this.ToolId = toolId;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailEscalateAction" /> class.
        /// </summary>
        public GuardrailEscalateAction()
        {
        }

    }
}