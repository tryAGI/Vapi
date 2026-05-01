
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallResultMessageWarning
    {
        /// <summary>
        /// The kind of warning. Currently:<br/>
        /// - `oversized-tool-response`: the tool's serialized response exceeded the<br/>
        ///   recommended size and is likely to bloat the model context, increasing<br/>
        ///   latency and risking truncation of earlier instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ToolCallResultMessageWarningTypeJsonConverter))]
        public global::Vapi.ToolCallResultMessageWarningType Type { get; set; }

        /// <summary>
        /// The estimated number of tokens in the serialized tool response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TokenCount { get; set; }

        /// <summary>
        /// The threshold (in tokens) above which the warning is raised.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessageWarning" /> class.
        /// </summary>
        /// <param name="tokenCount">
        /// The estimated number of tokens in the serialized tool response.
        /// </param>
        /// <param name="threshold">
        /// The threshold (in tokens) above which the warning is raised.
        /// </param>
        /// <param name="type">
        /// The kind of warning. Currently:<br/>
        /// - `oversized-tool-response`: the tool's serialized response exceeded the<br/>
        ///   recommended size and is likely to bloat the model context, increasing<br/>
        ///   latency and risking truncation of earlier instructions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallResultMessageWarning(
            double tokenCount,
            double threshold,
            global::Vapi.ToolCallResultMessageWarningType type)
        {
            this.Type = type;
            this.TokenCount = tokenCount;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallResultMessageWarning" /> class.
        /// </summary>
        public ToolCallResultMessageWarning()
        {
        }
    }
}