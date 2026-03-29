
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalRunDTO
    {
        /// <summary>
        /// This is the transient eval that will be run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval")]
        public global::Vapi.CreateEvalDTO? Eval { get; set; }

        /// <summary>
        /// This is the target that will be run against the eval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad> Target { get; set; }

        /// <summary>
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </summary>
        /// <example>eval</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateEvalRunDTOTypeJsonConverter))]
        public global::Vapi.CreateEvalRunDTOType Type { get; set; }

        /// <summary>
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("evalId")]
        public string? EvalId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunDTO" /> class.
        /// </summary>
        /// <param name="target">
        /// This is the target that will be run against the eval
        /// </param>
        /// <param name="eval">
        /// This is the transient eval that will be run
        /// </param>
        /// <param name="type">
        /// This is the type of the run.<br/>
        /// Currently it is fixed to `eval`.<br/>
        /// Example: eval
        /// </param>
        /// <param name="evalId">
        /// This is the id of the eval that will be run.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalRunDTO(
            global::Vapi.OneOf<global::Vapi.EvalRunTargetAssistant, global::Vapi.EvalRunTargetSquad> target,
            global::Vapi.CreateEvalDTO? eval,
            global::Vapi.CreateEvalRunDTOType type,
            string? evalId)
        {
            this.Eval = eval;
            this.Target = target;
            this.Type = type;
            this.EvalId = evalId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalRunDTO" /> class.
        /// </summary>
        public CreateEvalRunDTO()
        {
        }
    }
}