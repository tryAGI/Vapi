
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberHookCallRinging
    {
        /// <summary>
        /// This is the event to trigger the hook on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberHookCallRingingOnJsonConverter))]
        public global::Vapi.PhoneNumberHookCallRingingOn On { get; set; }

        /// <summary>
        /// Optional filters to decide when to trigger the hook. Currently supports filtering by caller country code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>? Filters { get; set; }

        /// <summary>
        /// Only the first action will be executed. Additional actions will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>> Do { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallRinging" /> class.
        /// </summary>
        /// <param name="on">
        /// This is the event to trigger the hook on
        /// </param>
        /// <param name="filters">
        /// Optional filters to decide when to trigger the hook. Currently supports filtering by caller country code.
        /// </param>
        /// <param name="do">
        /// Only the first action will be executed. Additional actions will be ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberHookCallRinging(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransferPhoneNumberHookAction, global::Vapi.SayPhoneNumberHookAction>> @do,
            global::Vapi.PhoneNumberHookCallRingingOn on,
            global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallRingingHookFilter>? filters)
        {
            this.Do = @do ?? throw new global::System.ArgumentNullException(nameof(@do));
            this.On = on;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberHookCallRinging" /> class.
        /// </summary>
        public PhoneNumberHookCallRinging()
        {
        }
    }
}