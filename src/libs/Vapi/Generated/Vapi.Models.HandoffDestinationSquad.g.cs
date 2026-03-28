
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HandoffDestinationSquad
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.HandoffDestinationSquadTypeJsonConverter))]
        public global::Vapi.HandoffDestinationSquadType Type { get; set; }

        /// <summary>
        /// This is the plan for manipulating the message context before handing off the call to the squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextEngineeringPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>))]
        public global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>? ContextEngineeringPlan { get; set; }

        /// <summary>
        /// This is the squad id to transfer the call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is a transient squad to transfer the call to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::Vapi.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is the name of the entry assistant to start with when handing off to the squad.<br/>
        /// If not provided, the first member of the squad will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entryAssistantName")]
        public string? EntryAssistantName { get; set; }

        /// <summary>
        /// This is the variable extraction plan for the handoff tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::Vapi.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// These are the overrides to apply to the squad configuration.<br/>
        /// Maps to squad-level membersOverrides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadOverrides")]
        public global::Vapi.AssistantOverrides? SquadOverrides { get; set; }

        /// <summary>
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationSquad" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="contextEngineeringPlan">
        /// This is the plan for manipulating the message context before handing off the call to the squad.
        /// </param>
        /// <param name="squadId">
        /// This is the squad id to transfer the call to.
        /// </param>
        /// <param name="squad">
        /// This is a transient squad to transfer the call to.
        /// </param>
        /// <param name="entryAssistantName">
        /// This is the name of the entry assistant to start with when handing off to the squad.<br/>
        /// If not provided, the first member of the squad will be used.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the variable extraction plan for the handoff tool.
        /// </param>
        /// <param name="squadOverrides">
        /// These are the overrides to apply to the squad configuration.<br/>
        /// Maps to squad-level membersOverrides.
        /// </param>
        /// <param name="description">
        /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HandoffDestinationSquad(
            global::Vapi.HandoffDestinationSquadType type,
            global::Vapi.OneOf<global::Vapi.ContextEngineeringPlanLastNMessages, global::Vapi.ContextEngineeringPlanNone, global::Vapi.ContextEngineeringPlanAll, global::Vapi.ContextEngineeringPlanUserAndAssistantMessages>? contextEngineeringPlan,
            string? squadId,
            global::Vapi.CreateSquadDTO? squad,
            string? entryAssistantName,
            global::Vapi.VariableExtractionPlan? variableExtractionPlan,
            global::Vapi.AssistantOverrides? squadOverrides,
            string? description)
        {
            this.Type = type;
            this.ContextEngineeringPlan = contextEngineeringPlan;
            this.SquadId = squadId;
            this.Squad = squad;
            this.EntryAssistantName = entryAssistantName;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.SquadOverrides = squadOverrides;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HandoffDestinationSquad" /> class.
        /// </summary>
        public HandoffDestinationSquad()
        {
        }
    }
}