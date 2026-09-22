
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SquadVersion
    {
        /// <summary>
        /// Optional human-readable label for this version. Set when the version is published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Optional description for this version. Set when the version is published.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// This is the unique identifier for the version row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that owns this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// This is the unique identifier for the squad this version was snapshotted from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SquadId { get; set; }

        /// <summary>
        /// This is the public monotonic version label, e.g. "v1".<br/>
        /// System-owned and incremented per squad; never user-supplied.<br/>
        /// Example: v1
        /// </summary>
        /// <example>v1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigHash { get; set; }

        /// <summary>
        /// This is the prior version label (vN-1). Null on v1 or for branch roots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentVersion")]
        public string? ParentVersion { get; set; }

        /// <summary>
        /// The version this version was restored from. Null when it was not restored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restoredFromVersion")]
        public string? RestoredFromVersion { get; set; }

        /// <summary>
        /// This is the actor that wrote this version. Email when created via JWT; null<br/>
        /// when created via API key, and null for a baseline version authored by nobody.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// This is the soft-delete timestamp. Null when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the name of the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO> Members { get; set; }

        /// <summary>
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("membersOverrides")]
        public global::Vapi.AssistantOverrides? MembersOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SquadVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the version row.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that owns this version.
        /// </param>
        /// <param name="squadId">
        /// This is the unique identifier for the squad this version was snapshotted from.
        /// </param>
        /// <param name="version">
        /// This is the public monotonic version label, e.g. "v1".<br/>
        /// System-owned and incremented per squad; never user-supplied.<br/>
        /// Example: v1
        /// </param>
        /// <param name="configHash">
        /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the version was created.
        /// </param>
        /// <param name="members">
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </param>
        /// <param name="versionName">
        /// Optional human-readable label for this version. Set when the version is published.
        /// </param>
        /// <param name="versionDescription">
        /// Optional description for this version. Set when the version is published.
        /// </param>
        /// <param name="parentVersion">
        /// This is the prior version label (vN-1). Null on v1 or for branch roots.
        /// </param>
        /// <param name="restoredFromVersion">
        /// The version this version was restored from. Null when it was not restored.
        /// </param>
        /// <param name="createdBy">
        /// This is the actor that wrote this version. Email when created via JWT; null<br/>
        /// when created via API key, and null for a baseline version authored by nobody.
        /// </param>
        /// <param name="deletedAt">
        /// This is the soft-delete timestamp. Null when active.
        /// </param>
        /// <param name="name">
        /// This is the name of the squad.
        /// </param>
        /// <param name="membersOverrides">
        /// This can be used to override all the assistants' settings and provide values for their template variables.<br/>
        /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SquadVersion(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.Guid squadId,
            string version,
            string configHash,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO> members,
            string? versionName,
            string? versionDescription,
            string? parentVersion,
            string? restoredFromVersion,
            string? createdBy,
            global::System.DateTime? deletedAt,
            string? name,
            global::Vapi.AssistantOverrides? membersOverrides)
        {
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Id = id;
            this.OrgId = orgId;
            this.SquadId = squadId;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ConfigHash = configHash ?? throw new global::System.ArgumentNullException(nameof(configHash));
            this.ParentVersion = parentVersion;
            this.RestoredFromVersion = restoredFromVersion;
            this.CreatedBy = createdBy;
            this.DeletedAt = deletedAt;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.MembersOverrides = membersOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SquadVersion" /> class.
        /// </summary>
        public SquadVersion()
        {
        }

    }
}