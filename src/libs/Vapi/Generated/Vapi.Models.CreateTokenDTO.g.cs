
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTokenDTO
    {
        /// <summary>
        /// This is the tag for the token. It represents its scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateTokenDTOTagJsonConverter))]
        public global::Vapi.CreateTokenDTOTag? Tag { get; set; }

        /// <summary>
        /// This is the name of the token. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This are the restrictions for the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrictions")]
        public global::Vapi.TokenRestrictions? Restrictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDTO" /> class.
        /// </summary>
        /// <param name="tag">
        /// This is the tag for the token. It represents its scope.
        /// </param>
        /// <param name="name">
        /// This is the name of the token. This is just for your own reference.
        /// </param>
        /// <param name="restrictions">
        /// This are the restrictions for the token.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTokenDTO(
            global::Vapi.CreateTokenDTOTag? tag,
            string? name,
            global::Vapi.TokenRestrictions? restrictions)
        {
            this.Tag = tag;
            this.Name = name;
            this.Restrictions = restrictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTokenDTO" /> class.
        /// </summary>
        public CreateTokenDTO()
        {
        }
    }
}