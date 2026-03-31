
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageAssistantSpeech
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechTypeJsonConverter))]
        public global::Vapi.ServerMessageAssistantSpeechType Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageAssistantSpeechSourceJsonConverter))]
        public global::Vapi.ServerMessageAssistantSpeechSource? Source { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.Timing2JsonConverter))]
        public global::Vapi.Timing2? Timing { get; set; }

        /// <summary>
        /// This is the timestamp of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public global::Vapi.Artifact? Artifact { get; set; }

        /// <summary>
        /// This is the assistant that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::Vapi.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// This is the customer that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer")]
        public global::Vapi.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the call that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call")]
        public global::Vapi.Call? Call { get; set; }

        /// <summary>
        /// This is the chat object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        public global::Vapi.Chat? Chat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageAssistantSpeech" /> class.
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
        /// <param name="artifact">
        /// This is a live version of the `call.artifact`.<br/>
        /// This matches what is stored on `call.artifact` after the call.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant that the message is associated with.
        /// </param>
        /// <param name="customer">
        /// This is the customer that the message is associated with.
        /// </param>
        /// <param name="call">
        /// This is the call that the message is associated with.
        /// </param>
        /// <param name="chat">
        /// This is the chat object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageAssistantSpeech(
            string text,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ServerMessageAssistantSpeechType type,
            double? turn,
            global::Vapi.ServerMessageAssistantSpeechSource? source,
            global::Vapi.Timing2? timing,
            double? timestamp,
            global::Vapi.Artifact? artifact,
            global::Vapi.CreateAssistantDTO? assistant,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.Call? call,
            global::Vapi.Chat? chat)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Turn = turn;
            this.Source = source;
            this.Timing = timing;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageAssistantSpeech" /> class.
        /// </summary>
        public ServerMessageAssistantSpeech()
        {
        }
    }
}