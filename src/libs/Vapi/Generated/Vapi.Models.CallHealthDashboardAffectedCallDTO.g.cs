
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAffectedCallDTO
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AssistantId { get; set; }

        /// <summary>
        /// Call completion time (endedAt), never startedAt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CallTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callAvailability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardAffectedCallDTOCallAvailabilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardAffectedCallDTOCallAvailability CallAvailability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAffectedCallDTO" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="assistantId"></param>
        /// <param name="callTime">
        /// Call completion time (endedAt), never startedAt.
        /// </param>
        /// <param name="callAvailability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAffectedCallDTO(
            global::System.Guid callId,
            global::System.Guid assistantId,
            global::System.DateTime callTime,
            global::Vapi.CallHealthDashboardAffectedCallDTOCallAvailability callAvailability)
        {
            this.CallId = callId;
            this.AssistantId = assistantId;
            this.CallTime = callTime;
            this.CallAvailability = callAvailability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAffectedCallDTO" /> class.
        /// </summary>
        public CallHealthDashboardAffectedCallDTO()
        {
        }

    }
}