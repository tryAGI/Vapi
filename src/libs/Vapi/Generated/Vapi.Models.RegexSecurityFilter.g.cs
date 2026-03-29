
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegexSecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RegexSecurityFilterTypeJsonConverter))]
        public global::Vapi.RegexSecurityFilterType Type { get; set; }

        /// <summary>
        /// The regex pattern to filter.<br/>
        /// Example: badword1|badword2
        /// </summary>
        /// <example>badword1|badword2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Regex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexSecurityFilter" /> class.
        /// </summary>
        /// <param name="regex">
        /// The regex pattern to filter.<br/>
        /// Example: badword1|badword2
        /// </param>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegexSecurityFilter(
            string regex,
            global::Vapi.RegexSecurityFilterType type)
        {
            this.Type = type;
            this.Regex = regex ?? throw new global::System.ArgumentNullException(nameof(regex));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegexSecurityFilter" /> class.
        /// </summary>
        public RegexSecurityFilter()
        {
        }
    }
}