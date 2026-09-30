
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationStaleConflictResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficAllocationStaleConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.TrafficAllocationStaleConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Human-readable reason the create was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The allocation currently in effect. Null if none exists yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currentAllocationId")]
        public global::System.Guid? CurrentAllocationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationStaleConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable reason the create was rejected.
        /// </param>
        /// <param name="error"></param>
        /// <param name="currentAllocationId">
        /// The allocation currently in effect. Null if none exists yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocationStaleConflictResponseDTO(
            string message,
            global::Vapi.TrafficAllocationStaleConflictResponseDTOError error,
            global::System.Guid? currentAllocationId)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.CurrentAllocationId = currentAllocationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationStaleConflictResponseDTO" /> class.
        /// </summary>
        public TrafficAllocationStaleConflictResponseDTO()
        {
        }

    }
}