
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerMessageEndOfCallReport
    {
        /// <summary>
        /// This is the phone number that the message is associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>))]
        public global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? PhoneNumber { get; set; }

        /// <summary>
        /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportTypeJsonConverter))]
        public global::Vapi.ServerMessageEndOfCallReportType Type { get; set; }

        /// <summary>
        /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedReason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.ServerMessageEndOfCallReportEndedReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.ServerMessageEndOfCallReportEndedReason EndedReason { get; set; }

        /// <summary>
        /// This is the cost of the call in USD. This can also be found at `call.cost` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// These are the costs of individual components of the call in USD. This can also be found at `call.costs` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costs")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>>? Costs { get; set; }

        /// <summary>
        /// This is the destination the call was transferred to, if the call was forwarded.<br/>
        /// This can also be found at `call.destination` on GET /call/:id.
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
        /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.Artifact Artifact { get; set; }

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
        /// This is the analysis of the call. This can also be found at `call.analysis` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.Analysis Analysis { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call started. This can also be found at `call.startedAt` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the call ended. This can also be found at `call.endedAt` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// This is the compliance result of the call. This can also be found at `call.compliance` on GET /call/:id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::Vapi.Compliance? Compliance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageEndOfCallReport" /> class.
        /// </summary>
        /// <param name="phoneNumber">
        /// This is the phone number that the message is associated with.
        /// </param>
        /// <param name="type">
        /// This is the type of the message. "end-of-call-report" is sent when the call ends and post-processing is complete.
        /// </param>
        /// <param name="endedReason">
        /// This is the reason the call ended. This can also be found at `call.endedReason` on GET /call/:id.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the call in USD. This can also be found at `call.cost` on GET /call/:id.
        /// </param>
        /// <param name="costs">
        /// These are the costs of individual components of the call in USD. This can also be found at `call.costs` on GET /call/:id.
        /// </param>
        /// <param name="destination">
        /// This is the destination the call was transferred to, if the call was forwarded.<br/>
        /// This can also be found at `call.destination` on GET /call/:id.
        /// </param>
        /// <param name="timestamp">
        /// This is the timestamp of the message.
        /// </param>
        /// <param name="artifact">
        /// These are the artifacts from the call. This can also be found at `call.artifact` on GET /call/:id.
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
        /// <param name="analysis">
        /// This is the analysis of the call. This can also be found at `call.analysis` on GET /call/:id.
        /// </param>
        /// <param name="startedAt">
        /// This is the ISO 8601 date-time string of when the call started. This can also be found at `call.startedAt` on GET /call/:id.
        /// </param>
        /// <param name="endedAt">
        /// This is the ISO 8601 date-time string of when the call ended. This can also be found at `call.endedAt` on GET /call/:id.
        /// </param>
        /// <param name="compliance">
        /// This is the compliance result of the call. This can also be found at `call.compliance` on GET /call/:id.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerMessageEndOfCallReport(
            global::Vapi.ServerMessageEndOfCallReportEndedReason endedReason,
            global::Vapi.Artifact artifact,
            global::Vapi.Analysis analysis,
            global::Vapi.OneOf<global::Vapi.CreateByoPhoneNumberDTO, global::Vapi.CreateTwilioPhoneNumberDTO, global::Vapi.CreateVonagePhoneNumberDTO, global::Vapi.CreateVapiPhoneNumberDTO, global::Vapi.CreateTelnyxPhoneNumberDTO>? phoneNumber,
            global::Vapi.ServerMessageEndOfCallReportType type,
            double? cost,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.TransportCost, global::Vapi.TranscriberCost, global::Vapi.ModelCost, global::Vapi.VoiceCost, global::Vapi.VapiCost, global::Vapi.VoicemailDetectionCost, global::Vapi.AnalysisCost, global::Vapi.KnowledgeBaseCost>>? costs,
            global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? destination,
            double? timestamp,
            global::Vapi.CreateAssistantDTO? assistant,
            global::Vapi.CreateCustomerDTO? customer,
            global::Vapi.Call? call,
            global::Vapi.Chat? chat,
            global::System.DateTime? startedAt,
            global::System.DateTime? endedAt,
            global::Vapi.Compliance? compliance)
        {
            this.EndedReason = endedReason;
            this.Artifact = artifact ?? throw new global::System.ArgumentNullException(nameof(artifact));
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
            this.PhoneNumber = phoneNumber;
            this.Type = type;
            this.Cost = cost;
            this.Costs = costs;
            this.Destination = destination;
            this.Timestamp = timestamp;
            this.Assistant = assistant;
            this.Customer = customer;
            this.Call = call;
            this.Chat = chat;
            this.StartedAt = startedAt;
            this.EndedAt = endedAt;
            this.Compliance = compliance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerMessageEndOfCallReport" /> class.
        /// </summary>
        public ServerMessageEndOfCallReport()
        {
        }
    }
}