
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageTransferUpdate
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageTransferUpdateTypeJsonConverter))]
        public global::Vapi.ClientMessageTransferUpdateType Type { get; set; }

        /// <summary>
        /// This is the destination of the transfer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        public global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? Destination { get; set; }

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
        /// This is the assistant that the call is being transferred to. This is only sent if `destination.type` is "assistant".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toAssistant")]
        public global::Vapi.CreateAssistantDTO? ToAssistant { get; set; }

        /// <summary>
        /// This is the assistant that the call is being transferred from. This is only sent if `destination.type` is "assistant".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromAssistant")]
        public global::Vapi.CreateAssistantDTO? FromAssistant { get; set; }

        /// <summary>
        /// This is the step that the conversation moved to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toStepRecord")]
        public object? ToStepRecord { get; set; }

        /// <summary>
        /// This is the step that the conversation moved from. =
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fromStepRecord")]
        public object? FromStepRecord { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTransferUpdate" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
        /// </param>
        /// <param name="destination">
        /// This is the destination of the transfer.
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
        /// <param name="toAssistant">
        /// This is the assistant that the call is being transferred to. This is only sent if `destination.type` is "assistant".
        /// </param>
        /// <param name="fromAssistant">
        /// This is the assistant that the call is being transferred from. This is only sent if `destination.type` is "assistant".
        /// </param>
        /// <param name="toStepRecord">
        /// This is the step that the conversation moved to.
        /// </param>
        /// <param name="fromStepRecord">
        /// This is the step that the conversation moved from. =
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientMessageTransferUpdate(
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ClientMessageTransferUpdateType type,
            global::Vapi.OneOf<global::Vapi.TransferDestinationAssistant, global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? destination,
            double? timestamp,
            global::Vapi.Call? call,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.CreateAssistantDTO? assistant,
            global::Vapi.CreateAssistantDTO? toAssistant,
            global::Vapi.CreateAssistantDTO? fromAssistant,
            object? toStepRecord,
            object? fromStepRecord)
        {
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
            this.ToAssistant = toAssistant;
            this.FromAssistant = fromAssistant;
            this.ToStepRecord = toStepRecord;
            this.FromStepRecord = fromStepRecord;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageTransferUpdate" /> class.
        /// </summary>
        public ClientMessageTransferUpdate()
        {
        }
    }
}