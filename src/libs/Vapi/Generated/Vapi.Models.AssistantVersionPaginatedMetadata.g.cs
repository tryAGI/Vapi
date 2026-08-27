
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssistantVersionPaginatedMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasNextPage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantVersionPaginatedMetadata" /> class.
        /// </summary>
        /// <param name="hasNextPage"></param>
        /// <param name="limit"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantVersionPaginatedMetadata(
            bool hasNextPage,
            double limit,
            string? nextCursor)
        {
            this.NextCursor = nextCursor;
            this.HasNextPage = hasNextPage;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantVersionPaginatedMetadata" /> class.
        /// </summary>
        public AssistantVersionPaginatedMetadata()
        {
        }

    }
}