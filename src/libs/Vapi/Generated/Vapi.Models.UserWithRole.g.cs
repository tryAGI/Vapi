
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserWithRole
    {
        /// <summary>
        /// This is the user's role in the org: a built-in role, the HIPAA special role, or a custom WorkOS role slug prefixed with `org-`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.UserWithRoleRole?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.UserWithRoleRole?, string> Role { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of the user's most recent sign-in to the org's identity provider (WorkOS). It is a property of the user, not of this org membership, so a sign-in to another WorkOS org counts. Only returned to org admins; absent when the requester is not an admin, no sign-in has been recorded, or the org is not linked to WorkOS.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastActiveAt")]
        public global::System.DateTime? LastActiveAt { get; set; }

        /// <summary>
        /// This is the unique identifier for the profile or user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the profile was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the profile was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the email of the user that is associated with the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// This is the full name of the user that is associated with the profile.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fullName")]
        public string? FullName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithRole" /> class.
        /// </summary>
        /// <param name="role">
        /// This is the user's role in the org: a built-in role, the HIPAA special role, or a custom WorkOS role slug prefixed with `org-`.
        /// </param>
        /// <param name="id">
        /// This is the unique identifier for the profile or user.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the profile was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the profile was last updated.
        /// </param>
        /// <param name="email">
        /// This is the email of the user that is associated with the profile.
        /// </param>
        /// <param name="lastActiveAt">
        /// This is the ISO 8601 date-time string of the user's most recent sign-in to the org's identity provider (WorkOS). It is a property of the user, not of this org membership, so a sign-in to another WorkOS org counts. Only returned to org admins; absent when the requester is not an admin, no sign-in has been recorded, or the org is not linked to WorkOS.
        /// </param>
        /// <param name="fullName">
        /// This is the full name of the user that is associated with the profile.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserWithRole(
            global::Vapi.OneOf<global::Vapi.UserWithRoleRole?, string> role,
            string id,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string email,
            global::System.DateTime? lastActiveAt,
            string? fullName)
        {
            this.Role = role;
            this.LastActiveAt = lastActiveAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FullName = fullName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserWithRole" /> class.
        /// </summary>
        public UserWithRole()
        {
        }

    }
}