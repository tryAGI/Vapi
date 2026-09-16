
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OrgApiLimitsDTO
    {
        /// <summary>
        /// Approximate number of API requests counted against the rate limit in the current minute, in the region that served this request. The count lives in a tumbling one-minute window aligned to the UTC clock (unix seconds / 60), so it resets to zero at the top of every minute; there is no reset header — the next boundary is (floor(now / 60) + 1) * 60.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimitUsage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RateLimitUsage { get; set; }

        /// <summary>
        /// Maximum number of standard API requests allowed per minute, in the region that served this request. Live call media traffic is limited separately and is not reflected here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimitMax")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RateLimitMax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiLimitsDTO" /> class.
        /// </summary>
        /// <param name="rateLimitUsage">
        /// Approximate number of API requests counted against the rate limit in the current minute, in the region that served this request. The count lives in a tumbling one-minute window aligned to the UTC clock (unix seconds / 60), so it resets to zero at the top of every minute; there is no reset header — the next boundary is (floor(now / 60) + 1) * 60.
        /// </param>
        /// <param name="rateLimitMax">
        /// Maximum number of standard API requests allowed per minute, in the region that served this request. Live call media traffic is limited separately and is not reflected here.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgApiLimitsDTO(
            double rateLimitUsage,
            double rateLimitMax)
        {
            this.RateLimitUsage = rateLimitUsage;
            this.RateLimitMax = rateLimitMax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiLimitsDTO" /> class.
        /// </summary>
        public OrgApiLimitsDTO()
        {
        }

    }
}