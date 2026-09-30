
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTrafficAllocationPaginatedDTO
    {
        /// <summary>
        /// Filter to allocations for this assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// The page number to return. Defaults to 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// The maximum number of items to return. Defaults to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The sort order for pagination. Defaults to 'DESC'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sortOrder")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.GetTrafficAllocationPaginatedDTOSortOrderJsonConverter))]
        public global::Vapi.GetTrafficAllocationPaginatedDTOSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrafficAllocationPaginatedDTO" /> class.
        /// </summary>
        /// <param name="assistantId">
        /// Filter to allocations for this assistant.
        /// </param>
        /// <param name="page">
        /// The page number to return. Defaults to 1.
        /// </param>
        /// <param name="limit">
        /// The maximum number of items to return. Defaults to 100.
        /// </param>
        /// <param name="sortOrder">
        /// The sort order for pagination. Defaults to 'DESC'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrafficAllocationPaginatedDTO(
            string? assistantId,
            int? page,
            int? limit,
            global::Vapi.GetTrafficAllocationPaginatedDTOSortOrder? sortOrder)
        {
            this.AssistantId = assistantId;
            this.Page = page;
            this.Limit = limit;
            this.SortOrder = sortOrder;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrafficAllocationPaginatedDTO" /> class.
        /// </summary>
        public GetTrafficAllocationPaginatedDTO()
        {
        }

    }
}