
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantReferenceDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Current assistant.latest_version label; omitted when unavailable, never a goal revision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        public string? LatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantReferenceDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="latestVersion">
        /// Current assistant.latest_version label; omitted when unavailable, never a goal revision.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantReferenceDTO(
            global::System.Guid id,
            string? name,
            string? latestVersion)
        {
            this.Id = id;
            this.Name = name;
            this.LatestVersion = latestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantReferenceDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantReferenceDTO()
        {
        }

    }
}