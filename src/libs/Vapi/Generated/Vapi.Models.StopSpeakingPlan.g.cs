
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopSpeakingPlan
    {
        /// <summary>
        /// This is the number of words that the customer has to say before the assistant will stop talking.<br/>
        /// Words like "stop", "actually", "no", etc. will always interrupt immediately regardless of this value.<br/>
        /// Words like "okay", "yeah", "right" will never interrupt.<br/>
        /// When set to 0, `voiceSeconds` is used in addition to the transcriptions to determine the customer has started speaking.<br/>
        /// Defaults to 0.<br/>
        /// @default 0<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numWords")]
        public double? NumWords { get; set; }

        /// <summary>
        /// This is the seconds customer has to speak before the assistant stops talking. This uses the VAD (Voice Activity Detection) spike to determine if the customer has started speaking.<br/>
        /// Considerations:<br/>
        /// - A lower value might be more responsive but could potentially pick up non-speech sounds.<br/>
        /// - A higher value reduces false positives but might slightly delay the detection of speech onset.<br/>
        /// This is only used if `numWords` is set to 0.<br/>
        /// Defaults to 0.2<br/>
        /// @default 0.2<br/>
        /// Example: 0.2F
        /// </summary>
        /// <example>0.2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceSeconds")]
        public double? VoiceSeconds { get; set; }

        /// <summary>
        /// This is the seconds to wait before the assistant will start talking again after being interrupted.<br/>
        /// Defaults to 1.<br/>
        /// @default 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffSeconds")]
        public double? BackoffSeconds { get; set; }

        /// <summary>
        /// These are the phrases that will never interrupt the assistant, even if numWords threshold is met.<br/>
        /// These are typically acknowledgement or backchanneling phrases.<br/>
        /// Default Value: [i understand, i see, i got it, i hear you, im listening, im with you, right, okay, ok, sure, alright, got it, understood, yeah, yes, uh-huh, mm-hmm, gotcha, mhmm, ah, yeah okay, yeah sure]<br/>
        /// Example: [i understand, i see, i got it, i hear you, im listening, im with you, right, okay, ok, sure, alright, got it, understood, yeah, yes, uh-huh, mm-hmm, gotcha, mhmm, ah, yeah okay, yeah sure]
        /// </summary>
        /// <example>[i understand, i see, i got it, i hear you, im listening, im with you, right, okay, ok, sure, alright, got it, understood, yeah, yes, uh-huh, mm-hmm, gotcha, mhmm, ah, yeah okay, yeah sure]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgementPhrases")]
        public global::System.Collections.Generic.IList<string>? AcknowledgementPhrases { get; set; }

        /// <summary>
        /// These are the phrases that will always interrupt the assistant immediately, regardless of numWords.<br/>
        /// These are typically phrases indicating disagreement or desire to stop.<br/>
        /// Default Value: [stop, shut, up, enough, quiet, silence, but, dont, not, no, hold, wait, cut, pause, nope, nah, nevermind, never, bad, actually]<br/>
        /// Example: [stop, shut, up, enough, quiet, silence, but, dont, not, no, hold, wait, cut, pause, nope, nah, nevermind, never, bad, actually]
        /// </summary>
        /// <example>[stop, shut, up, enough, quiet, silence, but, dont, not, no, hold, wait, cut, pause, nope, nah, nevermind, never, bad, actually]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruptionPhrases")]
        public global::System.Collections.Generic.IList<string>? InterruptionPhrases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopSpeakingPlan" /> class.
        /// </summary>
        /// <param name="numWords">
        /// This is the number of words that the customer has to say before the assistant will stop talking.<br/>
        /// Words like "stop", "actually", "no", etc. will always interrupt immediately regardless of this value.<br/>
        /// Words like "okay", "yeah", "right" will never interrupt.<br/>
        /// When set to 0, `voiceSeconds` is used in addition to the transcriptions to determine the customer has started speaking.<br/>
        /// Defaults to 0.<br/>
        /// @default 0<br/>
        /// Example: 0
        /// </param>
        /// <param name="voiceSeconds">
        /// This is the seconds customer has to speak before the assistant stops talking. This uses the VAD (Voice Activity Detection) spike to determine if the customer has started speaking.<br/>
        /// Considerations:<br/>
        /// - A lower value might be more responsive but could potentially pick up non-speech sounds.<br/>
        /// - A higher value reduces false positives but might slightly delay the detection of speech onset.<br/>
        /// This is only used if `numWords` is set to 0.<br/>
        /// Defaults to 0.2<br/>
        /// @default 0.2<br/>
        /// Example: 0.2F
        /// </param>
        /// <param name="backoffSeconds">
        /// This is the seconds to wait before the assistant will start talking again after being interrupted.<br/>
        /// Defaults to 1.<br/>
        /// @default 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="acknowledgementPhrases">
        /// These are the phrases that will never interrupt the assistant, even if numWords threshold is met.<br/>
        /// These are typically acknowledgement or backchanneling phrases.<br/>
        /// Default Value: [i understand, i see, i got it, i hear you, im listening, im with you, right, okay, ok, sure, alright, got it, understood, yeah, yes, uh-huh, mm-hmm, gotcha, mhmm, ah, yeah okay, yeah sure]<br/>
        /// Example: [i understand, i see, i got it, i hear you, im listening, im with you, right, okay, ok, sure, alright, got it, understood, yeah, yes, uh-huh, mm-hmm, gotcha, mhmm, ah, yeah okay, yeah sure]
        /// </param>
        /// <param name="interruptionPhrases">
        /// These are the phrases that will always interrupt the assistant immediately, regardless of numWords.<br/>
        /// These are typically phrases indicating disagreement or desire to stop.<br/>
        /// Default Value: [stop, shut, up, enough, quiet, silence, but, dont, not, no, hold, wait, cut, pause, nope, nah, nevermind, never, bad, actually]<br/>
        /// Example: [stop, shut, up, enough, quiet, silence, but, dont, not, no, hold, wait, cut, pause, nope, nah, nevermind, never, bad, actually]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopSpeakingPlan(
            double? numWords,
            double? voiceSeconds,
            double? backoffSeconds,
            global::System.Collections.Generic.IList<string>? acknowledgementPhrases,
            global::System.Collections.Generic.IList<string>? interruptionPhrases)
        {
            this.NumWords = numWords;
            this.VoiceSeconds = voiceSeconds;
            this.BackoffSeconds = backoffSeconds;
            this.AcknowledgementPhrases = acknowledgementPhrases;
            this.InterruptionPhrases = interruptionPhrases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopSpeakingPlan" /> class.
        /// </summary>
        public StopSpeakingPlan()
        {
        }
    }
}