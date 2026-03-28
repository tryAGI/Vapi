
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookCustomerSpeechInterrupted
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHookCustomerSpeechInterruptedOnJsonConverter))]
        public global::Vapi.CallHookCustomerSpeechInterruptedOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechInterrupted" /> class.
        /// </summary>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHookCustomerSpeechInterrupted(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SayHookAction, global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>> @do,
            global::Vapi.CallHookCustomerSpeechInterruptedOn on)
        {
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.On = on;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCustomerSpeechInterrupted" /> class.
        /// </summary>
        public CallHookCustomerSpeechInterrupted()
        {
        }
    }
}