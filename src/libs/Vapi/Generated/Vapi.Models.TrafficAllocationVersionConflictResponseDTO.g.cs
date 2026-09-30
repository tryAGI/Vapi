
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationVersionConflictResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TrafficAllocationVersionConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.TrafficAllocationVersionConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Human-readable reason the delete was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The allocation currently using this version. Create a new allocation without it before deleting the version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("governingAllocationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GoverningAllocationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationVersionConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable reason the delete was rejected.
        /// </param>
        /// <param name="governingAllocationId">
        /// The allocation currently using this version. Create a new allocation without it before deleting the version.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficAllocationVersionConflictResponseDTO(
            string message,
            string governingAllocationId,
            global::Vapi.TrafficAllocationVersionConflictResponseDTOError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.GoverningAllocationId = governingAllocationId ?? throw new global::System.ArgumentNullException(nameof(governingAllocationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficAllocationVersionConflictResponseDTO" /> class.
        /// </summary>
        public TrafficAllocationVersionConflictResponseDTO()
        {
        }

    }
}