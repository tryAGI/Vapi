
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberCallEndingHookFilter
    {
        /// <summary>
        /// This is the type of filter - currently only "oneOf" is supported
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterTypeJsonConverter))]
        public global::Vapi.PhoneNumberCallEndingHookFilterType Type { get; set; }

        /// <summary>
        /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberCallEndingHookFilterKeyJsonConverter))]
        public global::Vapi.PhoneNumberCallEndingHookFilterKey Key { get; set; }

        /// <summary>
        /// This is the array of assistant-request related ended reasons to match against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oneOf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem> OneOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallEndingHookFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of filter - currently only "oneOf" is supported
        /// </param>
        /// <param name="key">
        /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
        /// </param>
        /// <param name="oneOf">
        /// This is the array of assistant-request related ended reasons to match against
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberCallEndingHookFilter(
            global::System.Collections.Generic.IList<global::Vapi.PhoneNumberCallEndingHookFilterOneOfItem> oneOf,
            global::Vapi.PhoneNumberCallEndingHookFilterType type,
            global::Vapi.PhoneNumberCallEndingHookFilterKey key)
        {
            this.OneOf = oneOf ?? throw new global::System.ArgumentNullException(nameof(oneOf));
            this.Type = type;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallEndingHookFilter" /> class.
        /// </summary>
        public PhoneNumberCallEndingHookFilter()
        {
        }
    }
}