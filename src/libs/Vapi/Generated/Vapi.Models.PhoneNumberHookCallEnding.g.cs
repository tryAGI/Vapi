
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberHookCallEnding
    {
        /// <summary>
        /// This is the event to trigger the hook on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberHookCallEndingOnJsonConverter))]
        public global::Vapi.PhoneNumberHookCallEndingOn On { get; set; }

        /// <summary>
        /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>? Filters { get; set; }

        /// <summary>
        /// This is the action to perform when the hook triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>))]
        public global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>? Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallEnding" /> class.
        /// </summary>
        /// <param name="on">
        /// This is the event to trigger the hook on
        /// </param>
        /// <param name="filters">
        /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
        /// </param>
        /// <param name="do">
        /// This is the action to perform when the hook triggers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberHookCallEnding(
            global::Vapi.PhoneNumberHookCallEndingOn on,
            global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilter>? filters,
            global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>? @do)
        {
            this.On = on;
            this.Filters = filters;
            this.Do = @do;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallEnding" /> class.
        /// </summary>
        public PhoneNumberHookCallEnding()
        {
        }
    }
}