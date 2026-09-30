
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateTrafficAllocationDTO
    {
        /// <summary>
        /// The assistant whose calls this allocation splits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantId { get; set; }

        /// <summary>
        /// 'explicit' splits calls across targets, and is inferred when targets is sent. 'follow-latest' sends every call to the newest published version and is how you stop splitting; it must be sent explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocationIntent")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateTrafficAllocationDTOAllocationIntentJsonConverter))]
        public global::Vapi.CreateTrafficAllocationDTOAllocationIntent? AllocationIntent { get; set; }

        /// <summary>
        /// The versions to split calls across. Omit to stop splitting (with allocationIntent 'follow-latest'). Order in this array is the selection order (position).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        public global::System.Collections.Generic.IList<global::Vapi.CreateTrafficAllocationTargetDTO>? Targets { get; set; }

        /// <summary>
        /// Optional concurrency guard. Omit it and the write applies unconditionally (last write wins, matching every other Vapi update surface). Provide the id of the allocation you last read and the write applies only while that allocation is still governing; any mismatch is a 409 carrying the actual current id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expectedCurrentAllocationId")]
        public global::System.Guid? ExpectedCurrentAllocationId { get; set; }

        /// <summary>
        /// An optional note explaining why you made this change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrafficAllocationDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// The assistant whose calls this allocation splits.
        /// </param>
        /// <param name="allocationIntent">
        /// 'explicit' splits calls across targets, and is inferred when targets is sent. 'follow-latest' sends every call to the newest published version and is how you stop splitting; it must be sent explicitly.
        /// </param>
        /// <param name="targets">
        /// The versions to split calls across. Omit to stop splitting (with allocationIntent 'follow-latest'). Order in this array is the selection order (position).
        /// </param>
        /// <param name="expectedCurrentAllocationId">
        /// Optional concurrency guard. Omit it and the write applies unconditionally (last write wins, matching every other Vapi update surface). Provide the id of the allocation you last read and the write applies only while that allocation is still governing; any mismatch is a 409 carrying the actual current id.
        /// </param>
        /// <param name="description">
        /// An optional note explaining why you made this change.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrafficAllocationDTO(
            string assistantId,
            global::Vapi.CreateTrafficAllocationDTOAllocationIntent? allocationIntent,
            global::System.Collections.Generic.IList<global::Vapi.CreateTrafficAllocationTargetDTO>? targets,
            global::System.Guid? expectedCurrentAllocationId,
            string? description)
        {
            this.AssistantId = assistantId ?? throw new global::System.ArgumentNullException(nameof(assistantId));
            this.AllocationIntent = allocationIntent;
            this.Targets = targets;
            this.ExpectedCurrentAllocationId = expectedCurrentAllocationId;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrafficAllocationDTO" /> class.
        /// </summary>
        public CreateTrafficAllocationDTO()
        {
        }

    }
}