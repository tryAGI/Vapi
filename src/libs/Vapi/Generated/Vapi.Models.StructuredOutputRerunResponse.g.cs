
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StructuredOutputRerunResponse
    {
        /// <summary>
        /// This is the id of the workflow processing the rerun.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="StructuredOutputRerunResponse" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="workflowId">
        /// This is the id of the workflow processing the rerun.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredOutputRerunResponse(
            string message,
            string? workflowId)
        {
            this.WorkflowId = workflowId;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputRerunResponse" /> class.
        /// </summary>
        public StructuredOutputRerunResponse()
        {
        }

    }
}