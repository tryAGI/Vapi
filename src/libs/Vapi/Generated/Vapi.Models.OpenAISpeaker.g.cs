
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OpenAISpeaker
    {
        /// <summary>
        /// Omit to use legacy system messages. An explicit empty string is preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personalityPacks")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAISpeakerPersonalityPack>? PersonalityPacks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISpeaker" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Omit to use legacy system messages. An explicit empty string is preserved.
        /// </param>
        /// <param name="personalityPacks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAISpeaker(
            string? instructions,
            global::System.Collections.Generic.IList<global::Vapi.OpenAISpeakerPersonalityPack>? personalityPacks)
        {
            this.Instructions = instructions;
            this.PersonalityPacks = personalityPacks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAISpeaker" /> class.
        /// </summary>
        public OpenAISpeaker()
        {
        }

    }
}