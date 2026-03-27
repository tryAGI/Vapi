
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FallbackTranscriberPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcribers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>> Transcribers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTranscriberPlan" /> class.
        /// </summary>
        /// <param name="transcribers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FallbackTranscriberPlan(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FallbackAssemblyAITranscriber, global::Vapi.FallbackAzureSpeechTranscriber, global::Vapi.FallbackCustomTranscriber, global::Vapi.FallbackDeepgramTranscriber, global::Vapi.FallbackElevenLabsTranscriber, global::Vapi.FallbackGladiaTranscriber, global::Vapi.FallbackGoogleTranscriber, global::Vapi.FallbackTalkscriberTranscriber, global::Vapi.FallbackSpeechmaticsTranscriber, global::Vapi.FallbackOpenAITranscriber, global::Vapi.FallbackCartesiaTranscriber, global::Vapi.FallbackSonioxTranscriber>> transcribers)
        {
            this.Transcribers = transcribers ?? throw new global::System.ArgumentNullException(nameof(transcribers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FallbackTranscriberPlan" /> class.
        /// </summary>
        public FallbackTranscriberPlan()
        {
        }
    }
}