
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SonioxContextGeneralItem
    {
        /// <summary>
        /// The key describing the type of context (e.g., "domain", "topic", "doctor", "organization").<br/>
        /// Example: domain
        /// </summary>
        /// <example>domain</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value for the context key (e.g., "Healthcare", "Diabetes management consultation").<br/>
        /// Example: Healthcare
        /// </summary>
        /// <example>Healthcare</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxContextGeneralItem" /> class.
        /// </summary>
        /// <param name="key">
        /// The key describing the type of context (e.g., "domain", "topic", "doctor", "organization").<br/>
        /// Example: domain
        /// </param>
        /// <param name="value">
        /// The value for the context key (e.g., "Healthcare", "Diabetes management consultation").<br/>
        /// Example: Healthcare
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SonioxContextGeneralItem(
            string key,
            string value)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SonioxContextGeneralItem" /> class.
        /// </summary>
        public SonioxContextGeneralItem()
        {
        }
    }
}