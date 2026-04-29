
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RecordingConsentPlanStayOnLine
    {
        /// <summary>
        /// This is the message asking for consent to record the call.<br/>
        /// If the type is `stay-on-line`, the message should ask the user to hang up if they do not consent.<br/>
        /// If the type is `verbal`, the message should ask the user to verbally consent or decline.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// This is the voice to use for the consent message. If not specified, inherits from the assistant's voice.<br/>
        /// Use a different voice for the consent message for a better user experience.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>))]
        public global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? Voice { get; set; }

        /// <summary>
        /// This controls whether the consent assistant speaks first or waits for the caller to speak first.<br/>
        /// Use:<br/>
        /// - `assistant-speaks-first` (default) to have the consent assistant play the consent message as soon as the call is answered.<br/>
        /// - `assistant-waits-for-user` to have the consent assistant wait for the caller to speak before playing the consent message.<br/>
        /// We strongly recommend `assistant-waits-for-user` for outbound calls. Some telephony providers signal "answered" while the line is still ringing, which can cause the consent message to play into a ringing line and be missed by the caller. Waiting for the caller to speak first guarantees they hear the full consent message.<br/>
        /// Note: when combined with `type: 'stay-on-line'`, silence only counts toward consent after the caller has spoken at least once.<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Default Value: assistant-speaks-first<br/>
        /// Example: assistant-speaks-first
        /// </summary>
        /// <example>assistant-speaks-first</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstMessageMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineFirstMessageModeJsonConverter))]
        public global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode? FirstMessageMode { get; set; }

        /// <summary>
        /// This is the type of recording consent plan. This type assumes consent is granted if the user stays on the line.<br/>
        /// Example: stay-on-line
        /// </summary>
        /// <example>stay-on-line</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.RecordingConsentPlanStayOnLineTypeJsonConverter))]
        public global::Vapi.RecordingConsentPlanStayOnLineType Type { get; set; }

        /// <summary>
        /// Number of seconds to wait before transferring to the assistant if user stays on the call<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("waitSeconds")]
        public double? WaitSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsentPlanStayOnLine" /> class.
        /// </summary>
        /// <param name="message">
        /// This is the message asking for consent to record the call.<br/>
        /// If the type is `stay-on-line`, the message should ask the user to hang up if they do not consent.<br/>
        /// If the type is `verbal`, the message should ask the user to verbally consent or decline.
        /// </param>
        /// <param name="voice">
        /// This is the voice to use for the consent message. If not specified, inherits from the assistant's voice.<br/>
        /// Use a different voice for the consent message for a better user experience.
        /// </param>
        /// <param name="firstMessageMode">
        /// This controls whether the consent assistant speaks first or waits for the caller to speak first.<br/>
        /// Use:<br/>
        /// - `assistant-speaks-first` (default) to have the consent assistant play the consent message as soon as the call is answered.<br/>
        /// - `assistant-waits-for-user` to have the consent assistant wait for the caller to speak before playing the consent message.<br/>
        /// We strongly recommend `assistant-waits-for-user` for outbound calls. Some telephony providers signal "answered" while the line is still ringing, which can cause the consent message to play into a ringing line and be missed by the caller. Waiting for the caller to speak first guarantees they hear the full consent message.<br/>
        /// Note: when combined with `type: 'stay-on-line'`, silence only counts toward consent after the caller has spoken at least once.<br/>
        /// @default 'assistant-speaks-first'<br/>
        /// Default Value: assistant-speaks-first<br/>
        /// Example: assistant-speaks-first
        /// </param>
        /// <param name="type">
        /// This is the type of recording consent plan. This type assumes consent is granted if the user stays on the line.<br/>
        /// Example: stay-on-line
        /// </param>
        /// <param name="waitSeconds">
        /// Number of seconds to wait before transferring to the assistant if user stays on the call<br/>
        /// Default Value: 3<br/>
        /// Example: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecordingConsentPlanStayOnLine(
            string message,
            global::Vapi.OneOf<global::Vapi.AzureVoice, global::Vapi.CartesiaVoice, global::Vapi.CustomVoice, global::Vapi.DeepgramVoice, global::Vapi.ElevenLabsVoice, global::Vapi.HumeVoice, global::Vapi.LMNTVoice, global::Vapi.NeuphonicVoice, global::Vapi.OpenAIVoice, global::Vapi.PlayHTVoice, global::Vapi.WellSaidVoice, global::Vapi.RimeAIVoice, global::Vapi.SmallestAIVoice, global::Vapi.TavusVoice, global::Vapi.VapiVoice, global::Vapi.SesameVoice, global::Vapi.InworldVoice, global::Vapi.MinimaxVoice>? voice,
            global::Vapi.RecordingConsentPlanStayOnLineFirstMessageMode? firstMessageMode,
            global::Vapi.RecordingConsentPlanStayOnLineType type,
            double? waitSeconds)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Voice = voice;
            this.FirstMessageMode = firstMessageMode;
            this.Type = type;
            this.WaitSeconds = waitSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingConsentPlanStayOnLine" /> class.
        /// </summary>
        public RecordingConsentPlanStayOnLine()
        {
        }
    }
}