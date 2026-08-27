
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAssistantDraftDTOCredentialDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateAssistantDraftDTOCredentialDiscriminatorProviderJsonConverter))]
        public global::Vapi.CreateAssistantDraftDTOCredentialDiscriminatorProvider? Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantDraftDTOCredentialDiscriminator" /> class.
        /// </summary>
        /// <param name="provider"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssistantDraftDTOCredentialDiscriminator(
            global::Vapi.CreateAssistantDraftDTOCredentialDiscriminatorProvider? provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssistantDraftDTOCredentialDiscriminator" /> class.
        /// </summary>
        public CreateAssistantDraftDTOCredentialDiscriminator()
        {
        }

    }
}