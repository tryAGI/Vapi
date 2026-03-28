
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberCallRingingHookFilter
    {
        /// <summary>
        /// This is the type of filter - matches when the specified field starts with any of the given prefixes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterTypeJsonConverter))]
        public global::Vapi.PhoneNumberCallRingingHookFilterType Type { get; set; }

        /// <summary>
        /// The field to check. Currently only "number" (the caller's phone number) is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.PhoneNumberCallRingingHookFilterKeyJsonConverter))]
        public global::Vapi.PhoneNumberCallRingingHookFilterKey Key { get; set; }

        /// <summary>
        /// Array of prefixes to match. Do not include the + prefix. Inbound calls from numbers starting with any of these prefixes will trigger the hook actions.<br/>
        /// Example: [91, 86, 7]
        /// </summary>
        /// <example>[91, 86, 7]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("startsWith")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> StartsWith { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallRingingHookFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of filter - matches when the specified field starts with any of the given prefixes
        /// </param>
        /// <param name="key">
        /// The field to check. Currently only "number" (the caller's phone number) is supported.
        /// </param>
        /// <param name="startsWith">
        /// Array of prefixes to match. Do not include the + prefix. Inbound calls from numbers starting with any of these prefixes will trigger the hook actions.<br/>
        /// Example: [91, 86, 7]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberCallRingingHookFilter(
            global::System.Collections.Generic.IList<string> startsWith,
            global::Vapi.PhoneNumberCallRingingHookFilterType type,
            global::Vapi.PhoneNumberCallRingingHookFilterKey key)
        {
            this.StartsWith = startsWith ?? throw new global::System.ArgumentNullException(nameof(startsWith));
            this.Type = type;
            this.Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberCallRingingHookFilter" /> class.
        /// </summary>
        public PhoneNumberCallRingingHookFilter()
        {
        }
    }
}