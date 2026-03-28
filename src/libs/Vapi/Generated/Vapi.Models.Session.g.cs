
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Session
    {
        /// <summary>
        /// This is the unique identifier for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization that owns this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 timestamp indicating when the session was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 timestamp indicating when the session was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the cost of the session in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// These are the costs of individual components of the session in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costs")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? Costs { get; set; }

        /// <summary>
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SessionStatusJsonConverter))]
        public global::Vapi.SessionStatus? Status { get; set; }

        /// <summary>
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </summary>
        /// <example>86400</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expirationSeconds")]
        public double? ExpirationSeconds { get; set; }

        /// <summary>
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistant")]
        public global::Vapi.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantOverrides")]
        public global::Vapi.AssistantOverrides? AssistantOverrides { get; set; }

        /// <summary>
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squadId")]
        public string? SquadId { get; set; }

        /// <summary>
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("squad")]
        public global::Vapi.CreateSquadDTO? Squad { get; set; }

        /// <summary>
        /// This is an array of chat messages in the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? Messages { get; set; }

        /// <summary>
        /// This is the customer information associated with this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer")]
        public global::Vapi.CreateCustomerDTO? Customer { get; set; }

        /// <summary>
        /// This is the customerId of the customer associated with this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerId")]
        public string? CustomerId { get; set; }

        /// <summary>
        /// This is the ID of the phone number associated with this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumberId")]
        public string? PhoneNumberId { get; set; }

        /// <summary>
        /// This is the phone number configuration for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumber")]
        public global::Vapi.ImportTwilioPhoneNumberDTO? PhoneNumber { get; set; }

        /// <summary>
        /// These are the artifacts that were extracted from the session messages.<br/>
        /// They are only available after the session has completed.<br/>
        /// The artifact plan from the assistant or active assistant of squad is used to generate the artifact.<br/>
        /// Currently the only supported fields of assistant artifact plan are:<br/>
        /// - structuredOutputIds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact")]
        public global::Vapi.Artifact? Artifact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the session.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization that owns this session.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 timestamp indicating when the session was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 timestamp indicating when the session was last updated.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the session in USD.
        /// </param>
        /// <param name="costs">
        /// These are the costs of individual components of the session in USD.
        /// </param>
        /// <param name="name">
        /// This is a user-defined name for the session. Maximum length is 40 characters.
        /// </param>
        /// <param name="status">
        /// This is the current status of the session. Can be either 'active' or 'completed'.
        /// </param>
        /// <param name="expirationSeconds">
        /// Session expiration time in seconds. Defaults to 24 hours (86400 seconds) if not set.<br/>
        /// Example: 86400
        /// </param>
        /// <param name="assistantId">
        /// This is the ID of the assistant associated with this session. Use this when referencing an existing assistant.
        /// </param>
        /// <param name="assistant">
        /// This is the assistant configuration for this session. Use this when creating a new assistant configuration.<br/>
        /// If assistantId is provided, this will be ignored.
        /// </param>
        /// <param name="assistantOverrides">
        /// These are the overrides for the assistant configuration.<br/>
        /// Use this to provide variable values and other overrides when using assistantId.<br/>
        /// Variable substitution will be applied to the assistant's messages and other text-based fields.
        /// </param>
        /// <param name="squadId">
        /// This is the squad ID associated with this session. Use this when referencing an existing squad.
        /// </param>
        /// <param name="squad">
        /// This is the squad configuration for this session. Use this when creating a new squad configuration.<br/>
        /// If squadId is provided, this will be ignored.
        /// </param>
        /// <param name="messages">
        /// This is an array of chat messages in the session.
        /// </param>
        /// <param name="customer">
        /// This is the customer information associated with this session.
        /// </param>
        /// <param name="customerId">
        /// This is the customerId of the customer associated with this session.
        /// </param>
        /// <param name="phoneNumberId">
        /// This is the ID of the phone number associated with this session.
        /// </param>
        /// <param name="phoneNumber">
        /// This is the phone number configuration for this session.
        /// </param>
        /// <param name="artifact">
        /// These are the artifacts that were extracted from the session messages.<br/>
        /// They are only available after the session has completed.<br/>
        /// The artifact plan from the assistant or active assistant of squad is used to generate the artifact.<br/>
        /// Currently the only supported fields of assistant artifact plan are:<br/>
        /// - structuredOutputIds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Session(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            double? cost,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ModelCost, global::Vapi.AnalysisCost, global::Vapi.SessionCost>>? costs,
            string? name,
            global::Vapi.SessionStatus? status,
            double? expirationSeconds,
            string? assistantId,
            global::Vapi.CreateAssistantDTO? assistant,
            global::Vapi.AssistantOverrides? assistantOverrides,
            string? squadId,
            global::Vapi.CreateSquadDTO? squad,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SystemMessage, global::Vapi.UserMessage, global::Vapi.AssistantMessage, global::Vapi.ToolMessage, global::Vapi.DeveloperMessage>>? messages,
            global::Vapi.CreateCustomerDTO? customer,
            string? customerId,
            string? phoneNumberId,
            global::Vapi.ImportTwilioPhoneNumberDTO? phoneNumber,
            global::Vapi.Artifact? artifact)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Cost = cost;
            this.Costs = costs;
            this.Name = name;
            this.Status = status;
            this.ExpirationSeconds = expirationSeconds;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
            this.AssistantOverrides = assistantOverrides;
            this.SquadId = squadId;
            this.Squad = squad;
            this.Messages = messages;
            this.Customer = customer;
            this.CustomerId = customerId;
            this.PhoneNumberId = phoneNumberId;
            this.PhoneNumber = phoneNumber;
            this.Artifact = artifact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        public Session()
        {
        }
    }
}