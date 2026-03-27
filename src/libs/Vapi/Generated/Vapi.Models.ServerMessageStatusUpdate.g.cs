
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageStatusUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateTypeJsonConverter))]
        public global::Vapi.ServerMessageStatusUpdateType Type { get; set; }

        /// <summary>
        /// This is the status of the call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ServerMessageStatusUpdateStatus Status { get; set; }

        /// <summary>
        /// This is the reason the call ended. This is only sent if the status is "ended".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageStatusUpdateEndedReasonJsonConverter))]
        public global::Vapi.ServerMessageStatusUpdateEndedReason? EndedReason { get; set; }

        /// <summary>
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? Messages { get; set; }

        /// <summary>
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messagesOpenAIFormatted")]
        public global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? MessagesOpenAIFormatted { get; set; }

        /// <summary>
        /// This is the destination the call is being transferred to. This is only sent if the status is "forwarding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Destination { get; set; }

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
        /// This is the transcript of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        public string? Transcript { get; set; }

        /// <summary>
        /// This is the summary of the call. This is only sent if the status is "forwarding".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.<br/>
        /// This will include any errors related to the "assistant-request" if one was made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inboundPhoneCallDebuggingArtifacts")]
        public object? InboundPhoneCallDebuggingArtifacts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageStatusUpdate" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "status-update" is sent whenever the `call.status` changes.
        /// </param>
        /// <param name="status">
        /// This is the status of the call.
        /// </param>
        /// <param name="endedReason">
        /// This is the reason the call ended. This is only sent if the status is "ended".
        /// </param>
        /// <param name="messages">
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="messagesOpenAIFormatted">
        /// These are the conversation messages of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="destination">
        /// This is the destination the call is being transferred to. This is only sent if the status is "forwarding".
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
        /// <param name="transcript">
        /// This is the transcript of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="summary">
        /// This is the summary of the call. This is only sent if the status is "forwarding".
        /// </param>
        /// <param name="inboundPhoneCallDebuggingArtifacts">
        /// This is the inbound phone call debugging artifacts. This is only sent if the status is "ended" and there was an error accepting the inbound phone call.<br/>
        /// This will include any errors related to the "assistant-request" if one was made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageStatusUpdate(
            global::Vapi.ServerMessageStatusUpdateStatus status,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ServerMessageStatusUpdateType type,
            global::Vapi.ServerMessageStatusUpdateEndedReason? endedReason,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.UserMessage, global::Vapi.SystemMessage, global::Vapi.BotMessage, global::Vapi.ToolCallMessage, global::Vapi.ToolCallResultMessage>>? messages,
            global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>? messagesOpenAIFormatted,
            global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? destination,
            double? timestamp,
            global::Vapi.Artifact? artifact,
            global::Vapi.CreateAssistantDTO? assistant,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.Call? call,
            global::Vapi.Chat? chat,
            string? transcript,
            string? summary,
            object? inboundPhoneCallDebuggingArtifacts)
        {
            this.Status = status;
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.EndedReason = endedReason;
            this.Messages = messages;
            this.MessagesOpenAIFormatted = messagesOpenAIFormatted;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Artifact = artifact;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.Transcript = transcript;
            this.Summary = summary;
            this.InboundPhoneCallDebuggingArtifacts = inboundPhoneCallDebuggingArtifacts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageStatusUpdate" /> class.
        /// </summary>
        public ServerMessageStatusUpdate()
        {
        }
    }
}