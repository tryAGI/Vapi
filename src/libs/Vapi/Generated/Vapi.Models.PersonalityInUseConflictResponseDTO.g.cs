
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PersonalityInUseConflictResponseDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PersonalityInUseConflictResponseDTOErrorJsonConverter))]
        public global::Vapi.PersonalityInUseConflictResponseDTOError Error { get; set; }

        /// <summary>
        /// Human-readable reason the personality cannot be deleted.
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
        /// Initializes a new instance of the <see cref="PersonalityInUseConflictResponseDTO" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable reason the personality cannot be deleted.
        /// </param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersonalityInUseConflictResponseDTO(
            string message,
            global::Vapi.PersonalityInUseConflictResponseDTOError error)
        {
            this.Error = error;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonalityInUseConflictResponseDTO" /> class.
        /// </summary>
        public PersonalityInUseConflictResponseDTO()
        {
        }

    }
}