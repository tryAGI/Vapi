
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationOnboardingToolGapDTO
    {
        /// <summary>
        /// Function name of the tool, e.g. `handoff_to_group_1` or `transferCall`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Assistant the tool belongs to, when it is a handoff destination's tool. Unset for the assistant's own tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantName")]
        public string? AssistantName { get; set; }

        /// <summary>
        /// Why the path is not exercised: a reason the simulations mock the tool, or why a native path is never reached. New reasons may be added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationOnboardingToolGapDTOReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationOnboardingToolGapDTOReason Reason { get; set; }

        /// <summary>
        /// Static destinations the simulations do not reach through this tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationNames")]
        public global::System.Collections.Generic.IList<string>? DestinationNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingToolGapDTO" /> class.
        /// </summary>
        /// <param name="toolName">
        /// Function name of the tool, e.g. `handoff_to_group_1` or `transferCall`.
        /// </param>
        /// <param name="reason">
        /// Why the path is not exercised: a reason the simulations mock the tool, or why a native path is never reached. New reasons may be added.
        /// </param>
        /// <param name="assistantName">
        /// Assistant the tool belongs to, when it is a handoff destination's tool. Unset for the assistant's own tools.
        /// </param>
        /// <param name="destinationNames">
        /// Static destinations the simulations do not reach through this tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationOnboardingToolGapDTO(
            string toolName,
            global::Vapi.SimulationOnboardingToolGapDTOReason reason,
            string? assistantName,
            global::System.Collections.Generic.IList<string>? destinationNames)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.AssistantName = assistantName;
            this.Reason = reason;
            this.DestinationNames = destinationNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOnboardingToolGapDTO" /> class.
        /// </summary>
        public SimulationOnboardingToolGapDTO()
        {
        }

    }
}