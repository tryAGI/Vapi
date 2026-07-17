
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAssistantVersionMetadataDTO
    {
        /// <summary>
        /// Optional human-readable label for this version. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Optional description for this version. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantVersionMetadataDTO" /> class.
        /// </summary>
        /// <param name="versionName">
        /// Optional human-readable label for this version. Pass `null` to clear.
        /// </param>
        /// <param name="versionDescription">
        /// Optional description for this version. Pass `null` to clear.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAssistantVersionMetadataDTO(
            string? versionName,
            string? versionDescription)
        {
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssistantVersionMetadataDTO" /> class.
        /// </summary>
        public UpdateAssistantVersionMetadataDTO()
        {
        }

    }
}