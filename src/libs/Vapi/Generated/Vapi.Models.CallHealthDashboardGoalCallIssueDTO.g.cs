
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardGoalCallIssueDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The ranking category the issue belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categoryKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CategoryKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallIssueDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="categoryKey">
        /// The ranking category the issue belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardGoalCallIssueDTO(
            global::System.Guid id,
            string categoryKey)
        {
            this.Id = id;
            this.CategoryKey = categoryKey ?? throw new global::System.ArgumentNullException(nameof(categoryKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardGoalCallIssueDTO" /> class.
        /// </summary>
        public CallHealthDashboardGoalCallIssueDTO()
        {
        }

    }
}