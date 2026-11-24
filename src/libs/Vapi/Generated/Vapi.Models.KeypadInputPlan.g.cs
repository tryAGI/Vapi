
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KeypadInputPlan
    {
        /// <summary>
        /// This is the call variable each completed keypad entry is stored in, as a string with leading zeros kept. A later entry replaces the earlier one.<br/>
        /// Reference it as `{{variableName}}` in a transfer destination, for example in `sipHeaders`, so the model never has to repeat the digits. A keypad value the caller entered wins over a same-named handoff or transfer tool argument. Other writes to a variable with this name, such as variable extraction, still replace it. The value also appears in the call's `artifact.variableValues`.<br/>
        /// In a squad, the active assistant's `variableName` is used when the entry completes. A variable already stored under a previous assistant's name keeps its value.<br/>
        /// Not supported on full-duplex (GPT-Live) assistants: the call starts with a warning in the call logs and no variable is stored.<br/>
        /// Rules:<br/>
        /// - Must start with a letter (a-z, A-Z).<br/>
        /// - Subsequent characters can be letters, numbers, or underscores.<br/>
        /// - Minimum length of 1 and maximum length of 40.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableName")]
        public string? VariableName { get; set; }

        /// <summary>
        /// This keeps track of whether the user has enabled keypad input.<br/>
        /// By default, it is off.<br/>
        /// @default false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the time in seconds to wait before processing the input.<br/>
        /// If the input is not received within this time, the input will be ignored.<br/>
        /// If set to "off", the input will be processed when the user enters a delimiter or immediately if no delimiter is used.<br/>
        /// @default 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the delimiter(s) that will be used to process the input.<br/>
        /// Can be '#', '*', or an empty array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delimiters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.KeypadInputPlanDelimitersJsonConverter))]
        public global::Vapi.KeypadInputPlanDelimiters? Delimiters { get; set; }

        /// <summary>
        /// This determines whether a completed keypad entry triggers an assistant response.<br/>
        /// Usage:<br/>
        /// - Use `true` to have the assistant respond to the entry.<br/>
        /// - Use `false` to add the entry to the conversation history silently. The model reads it on its next turn, for example to pass an ID to a tool. OpenAI Realtime and Gemini speech-to-speech models never receive keypad entries.<br/>
        /// In a squad, this follows the active assistant when the entry completes. A half-typed entry carries over and completes under the new assistant's setting. `enabled`, `timeoutSeconds` and `delimiters` come from the first assistant for the whole call.<br/>
        /// @default true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerResponseEnabled")]
        public bool? TriggerResponseEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypadInputPlan" /> class.
        /// </summary>
        /// <param name="variableName">
        /// This is the call variable each completed keypad entry is stored in, as a string with leading zeros kept. A later entry replaces the earlier one.<br/>
        /// Reference it as `{{variableName}}` in a transfer destination, for example in `sipHeaders`, so the model never has to repeat the digits. A keypad value the caller entered wins over a same-named handoff or transfer tool argument. Other writes to a variable with this name, such as variable extraction, still replace it. The value also appears in the call's `artifact.variableValues`.<br/>
        /// In a squad, the active assistant's `variableName` is used when the entry completes. A variable already stored under a previous assistant's name keeps its value.<br/>
        /// Not supported on full-duplex (GPT-Live) assistants: the call starts with a warning in the call logs and no variable is stored.<br/>
        /// Rules:<br/>
        /// - Must start with a letter (a-z, A-Z).<br/>
        /// - Subsequent characters can be letters, numbers, or underscores.<br/>
        /// - Minimum length of 1 and maximum length of 40.
        /// </param>
        /// <param name="enabled">
        /// This keeps track of whether the user has enabled keypad input.<br/>
        /// By default, it is off.<br/>
        /// @default false
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is the time in seconds to wait before processing the input.<br/>
        /// If the input is not received within this time, the input will be ignored.<br/>
        /// If set to "off", the input will be processed when the user enters a delimiter or immediately if no delimiter is used.<br/>
        /// @default 2
        /// </param>
        /// <param name="delimiters">
        /// This is the delimiter(s) that will be used to process the input.<br/>
        /// Can be '#', '*', or an empty array.
        /// </param>
        /// <param name="triggerResponseEnabled">
        /// This determines whether a completed keypad entry triggers an assistant response.<br/>
        /// Usage:<br/>
        /// - Use `true` to have the assistant respond to the entry.<br/>
        /// - Use `false` to add the entry to the conversation history silently. The model reads it on its next turn, for example to pass an ID to a tool. OpenAI Realtime and Gemini speech-to-speech models never receive keypad entries.<br/>
        /// In a squad, this follows the active assistant when the entry completes. A half-typed entry carries over and completes under the new assistant's setting. `enabled`, `timeoutSeconds` and `delimiters` come from the first assistant for the whole call.<br/>
        /// @default true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KeypadInputPlan(
            string? variableName,
            bool? enabled,
            double? timeoutSeconds,
            global::Vapi.KeypadInputPlanDelimiters? delimiters,
            bool? triggerResponseEnabled)
        {
            this.VariableName = variableName;
            this.Enabled = enabled;
            this.TimeoutSeconds = timeoutSeconds;
            this.Delimiters = delimiters;
            this.TriggerResponseEnabled = triggerResponseEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeypadInputPlan" /> class.
        /// </summary>
        public KeypadInputPlan()
        {
        }

    }
}