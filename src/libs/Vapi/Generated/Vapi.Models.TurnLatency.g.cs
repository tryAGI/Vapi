
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TurnLatency
    {
        /// <summary>
        /// These are the latency components that were not measured on this turn. A listed component's latency field is not a real measurement: it usually reads 0, which here means "not measured", not 0ms, but a `transcriber` value measured from a speech start keeps its nonzero value. Drop listed components when aggregating. Omitted when every component was measured.<br/>
        /// - `transcriber`: no VAD speech marker for the turn, the sample was dropped as stale, the VAD missed this utterance (its newest marker was already used by an earlier turn), the transcript's time predates this utterance, or the VAD had still not flagged the end of speech when the reply started, including when the user kept talking after a tentative stop (the value is then measured from a speech start, or from the stop the user talked through).<br/>
        /// - `endpointing`: no user transcript was committed this turn (for example the first message, or a tool-result turn), or the transcript's time predates this utterance (carried over from an earlier one).<br/>
        /// - `model`: the model sent no output token this turn (for example a static message).<br/>
        /// - `voice`: no voice timing from model output this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmeasured")]
        public global::System.Collections.Generic.IList<global::Vapi.TurnLatencyUnmeasuredItem>? Unmeasured { get; set; }

        /// <summary>
        /// This is the time in milliseconds from the start of the turn's model stage to the model's first output token.<br/>
        /// It includes knowledge-base retrieval and request routing before the provider request. 0 when it was not measured on this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelLatency")]
        public double? ModelLatency { get; set; }

        /// <summary>
        /// This is the time in milliseconds from the model's first output token to the first reply audio reaching Vapi's turn-taking buffer.<br/>
        /// It includes the wait to collect enough text for the first voice request (set by `voice.chunkPlan`), the voice provider's time to first audio, and any sample-rate conversion. 0 when it was not measured on this turn.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceLatency")]
        public double? VoiceLatency { get; set; }

        /// <summary>
        /// This is the time in milliseconds from the user's last voice activity signal, normally the end of speech, to the transcriber returning the words of that speech.<br/>
        /// 0 both when it was not measured (listed in `unmeasured`) and when the words arrived before that signal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriberLatency")]
        public double? TranscriberLatency { get; set; }

        /// <summary>
        /// This is the time in milliseconds from the transcriber returning the words to Vapi deciding the turn is over and sending it to the model.<br/>
        /// 0 when the reply was not triggered by sending a user transcript to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpointingLatency")]
        public double? EndpointingLatency { get; set; }

        /// <summary>
        /// This is the time in milliseconds from the user's last voice activity signal to Vapi starting to send the assistant's reply audio.<br/>
        /// It is computed as `transcriberLatency` + `endpointingLatency` + the time from that decision to the reply starting, so it is not a real measurement either when `unmeasured` lists `transcriber`: the total then leaves that interval out (0) or counts it from a speech start. `modelLatency` and `voiceLatency` fall inside the last part, so the fields do not add up to this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnLatency")]
        public double? TurnLatency1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnLatency" /> class.
        /// </summary>
        /// <param name="unmeasured">
        /// These are the latency components that were not measured on this turn. A listed component's latency field is not a real measurement: it usually reads 0, which here means "not measured", not 0ms, but a `transcriber` value measured from a speech start keeps its nonzero value. Drop listed components when aggregating. Omitted when every component was measured.<br/>
        /// - `transcriber`: no VAD speech marker for the turn, the sample was dropped as stale, the VAD missed this utterance (its newest marker was already used by an earlier turn), the transcript's time predates this utterance, or the VAD had still not flagged the end of speech when the reply started, including when the user kept talking after a tentative stop (the value is then measured from a speech start, or from the stop the user talked through).<br/>
        /// - `endpointing`: no user transcript was committed this turn (for example the first message, or a tool-result turn), or the transcript's time predates this utterance (carried over from an earlier one).<br/>
        /// - `model`: the model sent no output token this turn (for example a static message).<br/>
        /// - `voice`: no voice timing from model output this turn.
        /// </param>
        /// <param name="modelLatency">
        /// This is the time in milliseconds from the start of the turn's model stage to the model's first output token.<br/>
        /// It includes knowledge-base retrieval and request routing before the provider request. 0 when it was not measured on this turn.
        /// </param>
        /// <param name="voiceLatency">
        /// This is the time in milliseconds from the model's first output token to the first reply audio reaching Vapi's turn-taking buffer.<br/>
        /// It includes the wait to collect enough text for the first voice request (set by `voice.chunkPlan`), the voice provider's time to first audio, and any sample-rate conversion. 0 when it was not measured on this turn.
        /// </param>
        /// <param name="transcriberLatency">
        /// This is the time in milliseconds from the user's last voice activity signal, normally the end of speech, to the transcriber returning the words of that speech.<br/>
        /// 0 both when it was not measured (listed in `unmeasured`) and when the words arrived before that signal.
        /// </param>
        /// <param name="endpointingLatency">
        /// This is the time in milliseconds from the transcriber returning the words to Vapi deciding the turn is over and sending it to the model.<br/>
        /// 0 when the reply was not triggered by sending a user transcript to the model.
        /// </param>
        /// <param name="turnLatency1">
        /// This is the time in milliseconds from the user's last voice activity signal to Vapi starting to send the assistant's reply audio.<br/>
        /// It is computed as `transcriberLatency` + `endpointingLatency` + the time from that decision to the reply starting, so it is not a real measurement either when `unmeasured` lists `transcriber`: the total then leaves that interval out (0) or counts it from a speech start. `modelLatency` and `voiceLatency` fall inside the last part, so the fields do not add up to this value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnLatency(
            global::System.Collections.Generic.IList<global::Vapi.TurnLatencyUnmeasuredItem>? unmeasured,
            double? modelLatency,
            double? voiceLatency,
            double? transcriberLatency,
            double? endpointingLatency,
            double? turnLatency1)
        {
            this.Unmeasured = unmeasured;
            this.ModelLatency = modelLatency;
            this.VoiceLatency = voiceLatency;
            this.TranscriberLatency = transcriberLatency;
            this.EndpointingLatency = endpointingLatency;
            this.TurnLatency1 = turnLatency1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnLatency" /> class.
        /// </summary>
        public TurnLatency()
        {
        }

    }
}