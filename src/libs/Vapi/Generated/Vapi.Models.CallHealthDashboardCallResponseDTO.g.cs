
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardCallResponseDTO
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
        /// Selected goal identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GoalId { get; set; }

        /// <summary>
        /// The assistant version the call ran on; absent when it ran on none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersionId")]
        public global::System.Guid? AssistantVersionId { get; set; }

        /// <summary>
        /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantVersion")]
        public string? AssistantVersion { get; set; }

        /// <summary>
        /// Classification state, named as in the coverage `classification` counters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assessmentState")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHealthDashboardCallResponseDTOAssessmentStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.CallHealthDashboardCallResponseDTOAssessmentState AssessmentState { get; set; }

        /// <summary>
        /// The call's main failure category; absent when classification selected none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("primaryCategoryKey")]
        public string? PrimaryCategoryKey { get; set; }

        /// <summary>
        /// The other selected categories, in ascending key order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otherCategoryKeys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> OtherCategoryKeys { get; set; }

        /// <summary>
        /// Visible issues the call joined, in ascending ID order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardCallIssueDTO> Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardCallResponseDTO" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="assistantId"></param>
        /// <param name="goalId">
        /// Selected goal identity.
        /// </param>
        /// <param name="assessmentState">
        /// Classification state, named as in the coverage `classification` counters.
        /// </param>
        /// <param name="otherCategoryKeys">
        /// The other selected categories, in ascending key order.
        /// </param>
        /// <param name="issues">
        /// Visible issues the call joined, in ascending ID order.
        /// </param>
        /// <param name="assistantVersionId">
        /// The assistant version the call ran on; absent when it ran on none.
        /// </param>
        /// <param name="assistantVersion">
        /// That version's label, such as v3; absent when the call ran on none or the label was unavailable at registration.
        /// </param>
        /// <param name="primaryCategoryKey">
        /// The call's main failure category; absent when classification selected none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardCallResponseDTO(
            global::System.Guid callId,
            global::System.Guid assistantId,
            global::System.Guid goalId,
            global::Vapi.CallHealthDashboardCallResponseDTOAssessmentState assessmentState,
            global::System.Collections.Generic.IList<string> otherCategoryKeys,
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardCallIssueDTO> issues,
            global::System.Guid? assistantVersionId,
            string? assistantVersion,
            string? primaryCategoryKey)
        {
            this.CallId = callId;
            this.AssistantId = assistantId;
            this.GoalId = goalId;
            this.AssistantVersionId = assistantVersionId;
            this.AssistantVersion = assistantVersion;
            this.AssessmentState = assessmentState;
            this.PrimaryCategoryKey = primaryCategoryKey;
            this.OtherCategoryKeys = otherCategoryKeys ?? throw new global::System.ArgumentNullException(nameof(otherCategoryKeys));
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardCallResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardCallResponseDTO()
        {
        }

    }
}