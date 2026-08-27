
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantActivation
    {
        /// <summary>
        /// This is the version label (e.g. `v3`) of the assistant active when<br/>
        /// the activation row was recorded. `null` for inline assistants,<br/>
        /// orgs not on assistant versioning, and parent assistants that have<br/>
        /// not yet been published under it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        public string? AssistantVersion { get; set; }

        /// <summary>
        /// This is the name of the assistant that was active during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AssistantName { get; set; }

        /// <summary>
        /// This is the ID of the assistant that was active during the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantActivation" /> class.
        /// </summary>
        /// <param name="assistantName">
        /// This is the name of the assistant that was active during the call.
        /// </param>
        /// <param name="assistantVersion">
        /// This is the version label (e.g. `v3`) of the assistant active when<br/>
        /// the activation row was recorded. `null` for inline assistants,<br/>
        /// orgs not on assistant versioning, and parent assistants that have<br/>
        /// not yet been published under it.
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant that was active during the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantActivation(
            string assistantName,
            string? assistantVersion,
            string? assistantId)
        {
            this.AssistantVersion = assistantVersion;
            this.AssistantName = assistantName ?? throw new global::System.ArgumentNullException(nameof(assistantName));
            this.AssistantId = assistantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantActivation" /> class.
        /// </summary>
        public AssistantActivation()
        {
        }

    }
}