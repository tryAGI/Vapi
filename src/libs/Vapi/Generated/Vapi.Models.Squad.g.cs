
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Squad
    {
        /// <summary>
        /// This is the latest version label (e.g. `v3`) of the squad in the version<br/>
        /// history. `null` while the org is not yet onboarded to versioning, or for<br/>
        /// squads that have not yet been published under it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestVersion")]
        public string? LatestVersion { get; set; }

        /// <summary>
        /// Read-only. Present only when a model this configuration uses is deprecated or retired in Vapi's model deprecation registry, judged on the day of the response. Each entry names the slot that carries the model (for example `model` or `model.fallbackModels[1]`), the deprecation and retirement dates as `YYYY-MM-DD` in UTC, and the recommended replacement model: the registry's replacement, followed through any further retirements as of the response date, so it names a model that is alive on that day. Ignored if sent back in a create or update request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelDeprecations")]
        public global::System.Collections.Generic.IList<global::Vapi.ModelDeprecationNotice>? ModelDeprecations { get; set; }

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
        /// This is the unique identifier for the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this squad belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the squad was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the squad was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad" /> class.
        /// </summary>
        /// <param name="members">
        /// This is the list of assistants that make up the squad.<br/>
        /// The call will start with the first assistant in the list.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the squad.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this squad belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the squad was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the squad was last updated.
        /// </param>
        /// <param name="latestVersion">
        /// This is the latest version label (e.g. `v3`) of the squad in the version<br/>
        /// history. `null` while the org is not yet onboarded to versioning, or for<br/>
        /// squads that have not yet been published under it.
        /// </param>
        /// <param name="modelDeprecations">
        /// Read-only. Present only when a model this configuration uses is deprecated or retired in Vapi's model deprecation registry, judged on the day of the response. Each entry names the slot that carries the model (for example `model` or `model.fallbackModels[1]`), the deprecation and retirement dates as `YYYY-MM-DD` in UTC, and the recommended replacement model: the registry's replacement, followed through any further retirements as of the response date, so it names a model that is alive on that day. Ignored if sent back in a create or update request.
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
        public Squad(
            global::System.Collections.Generic.IList<global::Vapi.SquadMemberDTO> members,
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? latestVersion,
            global::System.Collections.Generic.IList<global::Vapi.ModelDeprecationNotice>? modelDeprecations,
            string? name,
            global::Vapi.AssistantOverrides? membersOverrides)
        {
            this.LatestVersion = latestVersion;
            this.ModelDeprecations = modelDeprecations;
            this.Name = name;
            this.Members = members ?? throw new global::System.ArgumentNullException(nameof(members));
            this.MembersOverrides = membersOverrides;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Squad" /> class.
        /// </summary>
        public Squad()
        {
        }

    }
}