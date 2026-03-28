
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackPlan
    {
        /// <summary>
        /// This is the list of voices to fallback to in the event that the primary voice provider fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>> Voices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackPlan" /> class.
        /// </summary>
        /// <param name="voices">
        /// This is the list of voices to fallback to in the event that the primary voice provider fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackPlan(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAzureVoice, global::Vapi.FallbackCartesiaVoice, global::Vapi.FallbackHumeVoice, global::Vapi.FallbackCustomVoice, global::Vapi.FallbackDeepgramVoice, global::Vapi.FallbackElevenLabsVoice, global::Vapi.FallbackVapiVoice, global::Vapi.FallbackLMNTVoice, global::Vapi.FallbackOpenAIVoice, global::Vapi.FallbackPlayHTVoice, global::Vapi.FallbackWellSaidVoice, global::Vapi.FallbackRimeAIVoice, global::Vapi.FallbackSmallestAIVoice, global::Vapi.FallbackTavusVoice, global::Vapi.FallbackNeuphonicVoice, global::Vapi.FallbackSesameVoice, global::Vapi.FallbackInworldVoice>> voices)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackPlan" /> class.
        /// </summary>
        public FallbackPlan()
        {
        }
    }
}