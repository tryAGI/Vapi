
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VersionPinConflictResponseDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VersionPinConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.VersionPinConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Human-readable reason the delete was rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Pins that block the delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pinnedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.VersionPinReference> PinnedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionPinConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable reason the delete was rejected.
        /// </param>
        /// <param name="pinnedBy">
        /// Pins that block the delete.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionPinConflictResponseDTO(
            string message,
            global::System.Collections.Generic.IList<global::Vapi.VersionPinReference> pinnedBy,
            global::Vapi.VersionPinConflictResponseDTOError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.PinnedBy = pinnedBy ?? throw new global::System.ArgumentNullException(nameof(pinnedBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionPinConflictResponseDTO" /> class.
        /// </summary>
        public VersionPinConflictResponseDTO()
        {
        }

    }
}