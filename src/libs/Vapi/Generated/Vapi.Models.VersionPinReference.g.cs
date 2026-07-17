
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VersionPinReference
    {
        /// <summary>
        /// Kind of source row the pin originates from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.VersionPinReferenceSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.VersionPinReferenceSourceType SourceType { get; set; }

        /// <summary>
        /// UUID of the source row (polymorphic, not FK-enforced).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionPinReference" /> class.
        /// </summary>
        /// <param name="sourceType">
        /// Kind of source row the pin originates from.
        /// </param>
        /// <param name="sourceId">
        /// UUID of the source row (polymorphic, not FK-enforced).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionPinReference(
            global::Vapi.VersionPinReferenceSourceType sourceType,
            global::System.Guid sourceId)
        {
            this.SourceType = sourceType;
            this.SourceId = sourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionPinReference" /> class.
        /// </summary>
        public VersionPinReference()
        {
        }

    }
}