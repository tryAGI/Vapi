
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVapiPhoneNumberDTO
    {
        /// <summary>
        /// This is the fallback destination an inbound call will be transferred to if:<br/>
        /// 1. `assistantId` is not set<br/>
        /// 2. `squadId` is not set<br/>
        /// 3. and, `assistant-request` message to the `serverUrl` fails<br/>
        /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallbackDestination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>))]
        public global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? FallbackDestination { get; set; }

        /// <summary>
        /// This is the hooks that will be used for incoming calls to this phone number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? Hooks { get; set; }

        /// <summary>
        /// This is to create free SIP phone numbers on Vapi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateVapiPhoneNumberDTOProviderJsonConverter))]
        public global::Vapi.CreateVapiPhoneNumberDTOProvider Provider { get; set; }

        /// <summary>
        /// This is the area code of the phone number to purchase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberDesiredAreaCode")]
        public string? NumberDesiredAreaCode { get; set; }

        /// <summary>
        /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.<br/>
        /// This is case-insensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipUri")]
        public string? SipUri { get; set; }

        /// <summary>
        /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.<br/>
        /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authentication")]
        public global::Vapi.SipAuthentication? Authentication { get; set; }

        /// <summary>
        /// This is the name of the phone number. This is just for your own reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the assistant that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the workflow that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// This is the squad that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVapiPhoneNumberDTO" /> class.
        /// </summary>
        /// <param name="fallbackDestination">
        /// This is the fallback destination an inbound call will be transferred to if:<br/>
        /// 1. `assistantId` is not set<br/>
        /// 2. `squadId` is not set<br/>
        /// 3. and, `assistant-request` message to the `serverUrl` fails<br/>
        /// If this is not set and above conditions are met, the inbound call is hung up with an error message.
        /// </param>
        /// <param name="hooks">
        /// This is the hooks that will be used for incoming calls to this phone number.
        /// </param>
        /// <param name="provider">
        /// This is to create free SIP phone numbers on Vapi.
        /// </param>
        /// <param name="numberDesiredAreaCode">
        /// This is the area code of the phone number to purchase.
        /// </param>
        /// <param name="sipUri">
        /// This is the SIP URI of the phone number. You can SIP INVITE this. The assistant attached to this number will answer.<br/>
        /// This is case-insensitive.
        /// </param>
        /// <param name="authentication">
        /// This enables authentication for incoming SIP INVITE requests to the `sipUri`.<br/>
        /// If not set, any username/password to the 401 challenge of the SIP INVITE will be accepted.
        /// </param>
        /// <param name="name">
        /// This is the name of the phone number. This is just for your own reference.
        /// </param>
        /// <param name="assistantId">
        /// This is the assistant that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId` nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="workflowId">
        /// This is the workflow that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="squadId">
        /// This is the squad that will be used for incoming calls to this phone number.<br/>
        /// If neither `assistantId`, `squadId`, nor `workflowId` is set, `assistant-request` will be sent to your Server URL. Check `ServerMessage` and `ServerMessageResponse` for the shape of the message and response that is expected.
        /// </param>
        /// <param name="server">
        /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.<br/>
        /// The order of precedence is:<br/>
        /// 1. assistant.server<br/>
        /// 2. phoneNumber.server<br/>
        /// 3. org.server
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVapiPhoneNumberDTO(
            global::Vapi.OneOf<global::Vapi.TransferDestinationNumber, global::Vapi.TransferDestinationSip>? fallbackDestination,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.PhoneNumberHookCallRinging, global::Vapi.PhoneNumberHookCallEnding>>? hooks,
            global::Vapi.CreateVapiPhoneNumberDTOProvider provider,
            string? numberDesiredAreaCode,
            string? sipUri,
            global::Vapi.SipAuthentication? authentication,
            string? name,
            string? assistantId,
            string? workflowId,
            string? squadId,
            global::Vapi.Server? server)
        {
            this.FallbackDestination = fallbackDestination;
            this.Hooks = hooks;
            this.Provider = provider;
            this.NumberDesiredAreaCode = numberDesiredAreaCode;
            this.SipUri = sipUri;
            this.Authentication = authentication;
            this.Name = name;
            this.AssistantId = assistantId;
            this.WorkflowId = workflowId;
            this.SquadId = squadId;
            this.Server = server;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVapiPhoneNumberDTO" /> class.
        /// </summary>
        public CreateVapiPhoneNumberDTO()
        {
        }
    }
}