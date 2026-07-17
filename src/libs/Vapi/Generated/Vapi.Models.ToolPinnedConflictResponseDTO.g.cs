
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolPinnedConflictResponseDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ToolPinnedConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.ToolPinnedConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Human-readable reason the parent-tool delete was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPinnedConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable reason the parent-tool delete was rejected.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPinnedConflictResponseDTO(
            string message,
            global::Vapi.ToolPinnedConflictResponseDTOError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPinnedConflictResponseDTO" /> class.
        /// </summary>
        public ToolPinnedConflictResponseDTO()
        {
        }

    }
}