
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClientMessageWorkflowNodeStarted
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "workflow.node.started" is sent when the active node changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ClientMessageWorkflowNodeStartedTypeJsonConverter))]
        public global::Vapi.ClientMessageWorkflowNodeStartedType Type { get; set; }

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
        /// This is the active node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Node { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageWorkflowNodeStarted" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "workflow.node.started" is sent when the active node changes.
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
        /// <param name="node">
        /// This is the active node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientMessageWorkflowNodeStarted(
            object node,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ClientMessageWorkflowNodeStartedType type,
            double? timestamp,
            global::Vapi.Call? call,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.CreateAssistantDTO? assistant)
        {
            this.Node = node ?? throw new global::System.ArgumentNullException(nameof(node));
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Timestamp = timestamp;
            this.Call = call;
            this.Customer = customer;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMessageWorkflowNodeStarted" /> class.
        /// </summary>
        public ClientMessageWorkflowNodeStarted()
        {
        }
    }
}