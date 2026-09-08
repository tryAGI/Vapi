
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdatePersonalityDTO
    {
        /// <summary>
        /// This is the name of the personality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Complete assistant replacement. Omitted credentials and redacted server secrets are preserved when their endpoint URL is unchanged. Send credentials: [] to clear credentials; omit a server container to remove it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::Vapi.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePersonalityDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the personality.
        /// </param>
        /// <param name="assistant">
        /// Complete assistant replacement. Omitted credentials and redacted server secrets are preserved when their endpoint URL is unchanged. Send credentials: [] to clear credentials; omit a server container to remove it.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing personalities.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePersonalityDTO(
            string? name,
            global::Vapi.CreateAssistantDTO? assistant,
            string? path)
        {
            this.Name = name;
            this.Assistant = assistant;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePersonalityDTO" /> class.
        /// </summary>
        public UpdatePersonalityDTO()
        {
        }

    }
}