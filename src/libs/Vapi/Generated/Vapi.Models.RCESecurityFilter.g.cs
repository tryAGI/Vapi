
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RCESecurityFilter
    {
        /// <summary>
        /// The type of security threat to filter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RCESecurityFilterTypeJsonConverter))]
        public global::Vapi.RCESecurityFilterType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RCESecurityFilter" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of security threat to filter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RCESecurityFilter(
            global::Vapi.RCESecurityFilterType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RCESecurityFilter" /> class.
        /// </summary>
        public RCESecurityFilter()
        {
        }
    }
}