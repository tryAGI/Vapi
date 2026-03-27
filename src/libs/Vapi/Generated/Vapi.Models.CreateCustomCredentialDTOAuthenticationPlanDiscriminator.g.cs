
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCustomCredentialDTOAuthenticationPlanDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter))]
        public global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomCredentialDTOAuthenticationPlanDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCustomCredentialDTOAuthenticationPlanDiscriminator(
            global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomCredentialDTOAuthenticationPlanDiscriminator" /> class.
        /// </summary>
        public CreateCustomCredentialDTOAuthenticationPlanDiscriminator()
        {
        }
    }
}