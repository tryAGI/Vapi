
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageSpeechUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateTypeJsonConverter))]
        public global::Vapi.ClientMessageSpeechUpdateType Type { get; set; }

        /// <summary>
        /// This is the status of the speech update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientMessageSpeechUpdateStatus Status { get; set; }

        /// <summary>
        /// This is the role which the speech update is for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageSpeechUpdateRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ClientMessageSpeechUpdateRole Role { get; set; }

        /// <summary>
        /// This is the turn number of the speech update (0-indexed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn")]
        public double? Turn { get; set; }

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
        /// Initializes a new instance of the <see cref="ClientMessageSpeechUpdate" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
        /// </param>
        /// <param name="status">
        /// This is the status of the speech update.
        /// </param>
        /// <param name="role">
        /// This is the role which the speech update is for.
        /// </param>
        /// <param name="turn">
        /// This is the turn number of the speech update (0-indexed).
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
        public ClientMessageSpeechUpdate(
            global::Vapi.ClientMessageSpeechUpdateStatus status,
            global::Vapi.ClientMessageSpeechUpdateRole role,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ClientMessageSpeechUpdateType type,
            double? turn,
            double? timestamp,
            global::Vapi.Call? call,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.CreateAssistantDTO? assistant)
        {
            this.Status = status;
            this.Role = role;
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Turn = turn;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageSpeechUpdate" /> class.
        /// </summary>
        public ClientMessageSpeechUpdate()
        {
        }
    }
}