
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallHookCallEnding
    {
        /// <summary>
        /// This is the event that triggers this hook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CallHookCallEndingOnJsonConverter))]
        public global::Vapi.CallHookCallEndingOn On { get; set; }

        /// <summary>
        /// This is the set of actions to perform when the hook triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>> Do { get; set; }

        /// <summary>
        /// This is the set of filters that must match for the hook to trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCallEnding" /> class.
        /// </summary>
        /// <param name="on">
        /// This is the event that triggers this hook
        /// </param>
        /// <param name="do">
        /// This is the set of actions to perform when the hook triggers
        /// </param>
        /// <param name="filters">
        /// This is the set of filters that must match for the hook to trigger
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallHookCallEnding(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolCallHookAction, global::Vapi.MessageAddHookAction>> @do,
            global::Vapi.CallHookCallEndingOn on,
            global::System.Collections.Generic.IList<global::Vapi.CallHookFilter>? filters)
        {
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.On = on;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallHookCallEnding" /> class.
        /// </summary>
        public CallHookCallEnding()
        {
        }
    }
}