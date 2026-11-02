
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardWindowDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTimeGte")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallTimeGte { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTimeLt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallTimeLt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardWindowDTO" /> class.
        /// </summary>
        /// <param name="callTimeGte"></param>
        /// <param name="callTimeLt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardWindowDTO(
            global::System.DateTime callTimeGte,
            global::System.DateTime callTimeLt)
        {
            this.CallTimeGte = callTimeGte;
            this.CallTimeLt = callTimeLt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardWindowDTO" /> class.
        /// </summary>
        public CallHealthDashboardWindowDTO()
        {
        }

    }
}