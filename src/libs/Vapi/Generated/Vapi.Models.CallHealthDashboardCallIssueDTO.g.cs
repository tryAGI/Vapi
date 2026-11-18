
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardCallIssueDTO
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardCallIssueDTOStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardCallIssueDTOStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rowVersion")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RowVersion { get; set; }

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
        /// Initializes a new instance of the <see cref="CallHealthDashboardCallIssueDTO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="rowVersion"></param>
        /// <param name="categoryKey">
        /// The ranking category the issue belongs to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardCallIssueDTO(
            global::System.Guid id,
            string name,
            global::Vapi.CallHealthDashboardCallIssueDTOStatus status,
            long rowVersion,
            string categoryKey)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.RowVersion = rowVersion;
            this.CategoryKey = categoryKey ?? throw new global::System.ArgumentNullException(nameof(categoryKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardCallIssueDTO" /> class.
        /// </summary>
        public CallHealthDashboardCallIssueDTO()
        {
        }

    }
}