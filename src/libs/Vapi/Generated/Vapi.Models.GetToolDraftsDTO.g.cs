
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetToolDraftsDTO
    {
        /// <summary>
        /// Opaque base64-encoded keyset cursor. Omit on first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Page size, defaults to 25, capped at 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public double? Limit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDraftsDTO" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque base64-encoded keyset cursor. Omit on first page.
        /// </param>
        /// <param name="limit">
        /// Page size, defaults to 25, capped at 100.
        /// </param>
        /// <param name="createdBy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolDraftsDTO(
            string? cursor,
            double? limit,
            string? createdBy)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDraftsDTO" /> class.
        /// </summary>
        public GetToolDraftsDTO()
        {
        }

    }
}