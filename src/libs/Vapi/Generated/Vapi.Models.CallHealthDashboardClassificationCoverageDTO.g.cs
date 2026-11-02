
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardClassificationCoverageDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pending")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Pending { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unavailable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Unavailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Skipped { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excluded")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Excluded { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complete")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Complete { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Partial { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardClassificationCoverageDTO" /> class.
        /// </summary>
        /// <param name="pending"></param>
        /// <param name="unavailable"></param>
        /// <param name="skipped"></param>
        /// <param name="error"></param>
        /// <param name="excluded"></param>
        /// <param name="complete"></param>
        /// <param name="partial"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardClassificationCoverageDTO(
            long pending,
            long unavailable,
            long skipped,
            long error,
            long excluded,
            long complete,
            long partial)
        {
            this.Pending = pending;
            this.Unavailable = unavailable;
            this.Skipped = skipped;
            this.Error = error;
            this.Excluded = excluded;
            this.Complete = complete;
            this.Partial = partial;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardClassificationCoverageDTO" /> class.
        /// </summary>
        public CallHealthDashboardClassificationCoverageDTO()
        {
        }

    }
}