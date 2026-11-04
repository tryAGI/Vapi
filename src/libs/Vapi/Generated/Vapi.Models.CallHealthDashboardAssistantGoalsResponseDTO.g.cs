
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallHealthDashboardAssistantGoalsResponseDTO
    {
        /// <summary>
        /// Complete requested visible assistant cohort, including assistants with no goal options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAssistantGoalsDTO> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantGoalsResponseDTO" /> class.
        /// </summary>
        /// <param name="results">
        /// Complete requested visible assistant cohort, including assistants with no goal options.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHealthDashboardAssistantGoalsResponseDTO(
            global::System.Collections.Generic.IList<global::Vapi.CallHealthDashboardAssistantGoalsDTO> results)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHealthDashboardAssistantGoalsResponseDTO" /> class.
        /// </summary>
        public CallHealthDashboardAssistantGoalsResponseDTO()
        {
        }

    }
}