
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageAssistantSpeech
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "assistant-speech" is sent as assistant audio is being played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechTypeJsonConverter))]
        public global::Vapi.ClientMessageAssistantSpeechType Type { get; set; }

        /// <summary>
        /// The full assistant text for the current turn. This is the complete text,<br/>
        /// not an incremental delta — consumers should use `timing` metadata (e.g.<br/>
        /// `wordsSpoken`) to determine which portion has been spoken so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// This is the turn number of the assistant speech event (0-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public double? Turn { get; set; }

        /// <summary>
        /// Indicates how the text was sourced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageAssistantSpeechSourceJsonConverter))]
        public global::Vapi.ClientMessageAssistantSpeechSource? Source { get; set; }

        /// <summary>
        /// Optional timing metadata. Shape depends on `timing.type`:<br/>
        /// - `word-alignment` (ElevenLabs): per-character timing at playback<br/>
        ///   cadence. words[] includes space entries. Best consumed by tracking<br/>
        ///   a running character count: join timing.words, add to a char cursor,<br/>
        ///   and highlight text up to that position. No interpolation needed.<br/>
        /// - `word-progress` (Minimax with voice.subtitleType: 'word'): cursor-<br/>
        ///   based word count per TTS segment. Use wordsSpoken as the anchor,<br/>
        ///   interpolate forward using segmentDurationMs or timing.words until<br/>
        ///   the next event arrives.<br/>
        /// When absent, the event is a text-only fallback for providers without<br/>
        /// word-level timing (e.g. Cartesia, Deepgram, Azure). Text emits once<br/>
        /// per TTS chunk when audio is playing. Optionally interpolate a word<br/>
        /// cursor at ~3.5 words/sec between events for approximate tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.TimingJsonConverter))]
        public global::Vapi.Timing? Timing { get; set; }

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call")]
        public global::Vapi.Call? Call { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer")]
        public global::Vapi.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::Vapi.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageAssistantSpeech" /> class.
        /// </summary>
        /// <param name="text">
        /// The full assistant text for the current turn. This is the complete text,<br/>
        /// not an incremental delta — consumers should use `timing` metadata (e.g.<br/>
        /// `wordsSpoken`) to determine which portion has been spoken so far.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "assistant-speech" is sent as assistant audio is being played.
        /// </param>
        /// <param name="turn">
        /// This is the turn number of the assistant speech event (0-indexed).
        /// </param>
        /// <param name="source">
        /// Indicates how the text was sourced.
        /// </param>
        /// <param name="timing">
        /// Optional timing metadata. Shape depends on `timing.type`:<br/>
        /// - `word-alignment` (ElevenLabs): per-character timing at playback<br/>
        ///   cadence. words[] includes space entries. Best consumed by tracking<br/>
        ///   a running character count: join timing.words, add to a char cursor,<br/>
        ///   and highlight text up to that position. No interpolation needed.<br/>
        /// - `word-progress` (Minimax with voice.subtitleType: 'word'): cursor-<br/>
        ///   based word count per TTS segment. Use wordsSpoken as the anchor,<br/>
        ///   interpolate forward using segmentDurationMs or timing.words until<br/>
        ///   the next event arrives.<br/>
        /// When absent, the event is a text-only fallback for providers without<br/>
        /// word-level timing (e.g. Cartesia, Deepgram, Azure). Text emits once<br/>
        /// per TTS chunk when audio is playing. Optionally interpolate a word<br/>
        /// cursor at ~3.5 words/sec between events for approximate tracking.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientMessageAssistantSpeech(
            string text,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ClientMessageAssistantSpeechType type,
            double? turn,
            global::Vapi.ClientMessageAssistantSpeechSource? source,
            global::Vapi.Timing? timing,
            double? timestamp,
            global::Vapi.Call? call,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.CreateAssistantDTO? assistant)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Turn = turn;
            this.Source = source;
            this.Timing = timing;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageAssistantSpeech" /> class.
        /// </summary>
        public ClientMessageAssistantSpeech()
        {
        }
    }
}