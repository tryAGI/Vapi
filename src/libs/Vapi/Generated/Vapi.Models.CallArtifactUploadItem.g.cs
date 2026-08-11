
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallArtifactUploadItem
    {
        /// <summary>
        /// The artifact this result refers to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallArtifactUploadItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallArtifactUploadItemType Type { get; set; }

        /// <summary>
        /// Whether this artifact was stored successfully in your own configured storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallArtifactUploadItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The artifact this result refers to.
        /// </param>
        /// <param name="success">
        /// Whether this artifact was stored successfully in your own configured storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallArtifactUploadItem(
            global::Vapi.CallArtifactUploadItemType type,
            bool success)
        {
            this.Type = type;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallArtifactUploadItem" /> class.
        /// </summary>
        public CallArtifactUploadItem()
        {
        }

    }
}