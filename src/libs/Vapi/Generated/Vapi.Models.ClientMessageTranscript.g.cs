
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageTranscript
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientMessageTranscriptType Type { get; set; }

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
        /// This is the role for which the transcript is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageTranscriptRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientMessageTranscriptRole Role { get; set; }

        /// <summary>
        /// This is the type of the transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriptType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageTranscriptTranscriptTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientMessageTranscriptTranscriptType TranscriptType { get; set; }

        /// <summary>
        /// This is the transcript content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Indicates if the transcript was filtered for security reasons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isFiltered")]
        public bool? IsFiltered { get; set; }

        /// <summary>
        /// List of detected security threats if the transcript was filtered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detectedThreats")]
        public global::System.Collections.Generic.IList<string>? DetectedThreats { get; set; }

        /// <summary>
        /// The original transcript before filtering (only included if content was filtered).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originalTranscript")]
        public string? OriginalTranscript { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTranscript" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
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
        /// <param name="role">
        /// This is the role for which the transcript is for.
        /// </param>
        /// <param name="transcriptType">
        /// This is the type of the transcript.
        /// </param>
        /// <param name="transcript">
        /// This is the transcript content.
        /// </param>
        /// <param name="isFiltered">
        /// Indicates if the transcript was filtered for security reasons.
        /// </param>
        /// <param name="detectedThreats">
        /// List of detected security threats if the transcript was filtered.
        /// </param>
        /// <param name="originalTranscript">
        /// The original transcript before filtering (only included if content was filtered).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientMessageTranscript(
            global::Vapi.ClientMessageTranscriptType type,
            global::Vapi.ClientMessageTranscriptRole role,
            global::Vapi.ClientMessageTranscriptTranscriptType transcriptType,
            string transcript,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            double? timestamp,
            global::Vapi.Call? call,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.CreateAssistantDTO? assistant,
            bool? isFiltered,
            global::System.Collections.Generic.IList<string>? detectedThreats,
            string? originalTranscript)
        {
            this.Type = type;
            this.Role = role;
            this.TranscriptType = transcriptType;
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.PhoneNumber = phoneNumber;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
            this.IsFiltered = isFiltered;
            this.DetectedThreats = detectedThreats;
            this.OriginalTranscript = originalTranscript;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTranscript" /> class.
        /// </summary>
        public ClientMessageTranscript()
        {
        }
    }
}