
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantGoalCreateDTO
    {
        /// <summary>
        /// Success criteria. Trimmed before commit; blank or non-PostgreSQL-compatible text is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("succeedsWhen")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SucceedsWhen { get; set; }

        /// <summary>
        /// Optional trimmed exclusions. Omit or send null for no exclusions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leaveOut")]
        public string? LeaveOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantGoalCreateDTO" /> class.
        /// </summary>
        /// <param name="succeedsWhen">
        /// Success criteria. Trimmed before commit; blank or non-PostgreSQL-compatible text is rejected.
        /// </param>
        /// <param name="leaveOut">
        /// Optional trimmed exclusions. Omit or send null for no exclusions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantGoalCreateDTO(
            string succeedsWhen,
            string? leaveOut)
        {
            this.SucceedsWhen = succeedsWhen ?? throw new global::System.ArgumentNullException(nameof(succeedsWhen));
            this.LeaveOut = leaveOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantGoalCreateDTO" /> class.
        /// </summary>
        public AssistantGoalCreateDTO()
        {
        }

    }
}