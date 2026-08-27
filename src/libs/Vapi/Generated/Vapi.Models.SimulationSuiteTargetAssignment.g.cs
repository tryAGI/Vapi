
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationSuiteTargetAssignment
    {
        /// <summary>
        /// This is the type of target assigned to the simulation suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SimulationSuiteTargetAssignmentTargetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.SimulationSuiteTargetAssignmentTargetType TargetType { get; set; }

        /// <summary>
        /// This is the unique identifier of the assigned assistant or squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TargetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSuiteTargetAssignment" /> class.
        /// </summary>
        /// <param name="targetType">
        /// This is the type of target assigned to the simulation suite.
        /// </param>
        /// <param name="targetId">
        /// This is the unique identifier of the assigned assistant or squad.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimulationSuiteTargetAssignment(
            global::Vapi.SimulationSuiteTargetAssignmentTargetType targetType,
            global::System.Guid targetId)
        {
            this.TargetType = targetType;
            this.TargetId = targetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSuiteTargetAssignment" /> class.
        /// </summary>
        public SimulationSuiteTargetAssignment()
        {
        }

    }
}