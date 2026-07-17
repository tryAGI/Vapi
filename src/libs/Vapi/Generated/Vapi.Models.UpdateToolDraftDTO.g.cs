
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateToolDraftDTO
    {
        /// <summary>
        /// Messages spoken while the tool is running. Multiple request-start messages are variants. For request-response-delayed, same timing means variants and different timings mean staged updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>? Messages { get; set; }

        /// <summary>
        /// This is the type of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateToolDraftDTOTypeJsonConverter))]
        public global::Vapi.UpdateToolDraftDTOType? Type { get; set; }

        /// <summary>
        /// This is the function definition of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Vapi.OpenAIFunction? Function { get; set; }

        /// <summary>
        /// Provider-specific metadata. Polymorphic across tool variants with no shared<br/>
        /// discriminator, so it is validated as a plain object (mirrors how<br/>
        /// `ToolCallResult.metadata` is typed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// This is the unique identifier for the template this tool was created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server")]
        public global::Vapi.Server? Server { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? Async { get; set; }

        /// <summary>
        /// These are the destinations that the call can be transferred to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public global::System.Collections.Generic.IList<object>? Destinations { get; set; }

        /// <summary>
        /// This is the name of the tool. This will be passed to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the sub type of the tool (e.g. for computer, bash and text-editor tools).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        public string? SubType { get; set; }

        /// <summary>
        /// The display width in pixels (computer tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayWidthPx")]
        public double? DisplayWidthPx { get; set; }

        /// <summary>
        /// The display height in pixels (computer tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayHeightPx")]
        public double? DisplayHeightPx { get; set; }

        /// <summary>
        /// Optional display number (computer tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayNumber")]
        public double? DisplayNumber { get; set; }

        /// <summary>
        /// The knowledge bases to query (query tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBases")]
        public global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>? KnowledgeBases { get; set; }

        /// <summary>
        /// This is where the request will be sent (api-request tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// This is the HTTP method for the request (api-request tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateToolDraftDTOMethodJsonConverter))]
        public global::Vapi.UpdateToolDraftDTOMethod? Method { get; set; }

        /// <summary>
        /// These are the headers to send with the request (api-request / sip-request tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::Vapi.JsonSchema? Headers { get; set; }

        /// <summary>
        /// This is the body of the request. Either a JSON schema (api-request) or a<br/>
        /// literal string / schema (sip-request).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// This is the backoff plan if the request fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffPlan")]
        public global::Vapi.BackoffPlan? BackoffPlan { get; set; }

        /// <summary>
        /// This is the timeout in seconds for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// This is the description of the tool. This will be passed to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// This is the plan to extract variables from the tool's response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public global::Vapi.VariableExtractionPlan? VariableExtractionPlan { get; set; }

        /// <summary>
        /// This is the credential ID that will be used for authorization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentialId")]
        public string? CredentialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extendedDelayWhenPrecededByTextEnabled")]
        public bool? ExtendedDelayWhenPrecededByTextEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beepDetectionEnabled")]
        public bool? BeepDetectionEnabled { get; set; }

        /// <summary>
        /// This is the TypeScript code that will be executed when the tool is called (code tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// These are the environment variables available in the code via the `env` object (code tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>? EnvironmentVariables { get; set; }

        /// <summary>
        /// These are the static parameters to merge into the tool's request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::Vapi.ToolParameter>? Parameters { get; set; }

        /// <summary>
        /// This is the paths to encrypt in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedPaths")]
        public global::System.Collections.Generic.IList<string>? EncryptedPaths { get; set; }

        /// <summary>
        /// This enables sending DTMF tones via SIP INFO messages instead of RFC 2833.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipInfoDtmfEnabled")]
        public bool? SipInfoDtmfEnabled { get; set; }

        /// <summary>
        /// This is the SIP method to send (sip-request tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verb")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.UpdateToolDraftDTOVerbJsonConverter))]
        public global::Vapi.UpdateToolDraftDTOVerb? Verb { get; set; }

        /// <summary>
        /// This is the default local tool result message used when no runtime override is returned (handoff tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResult")]
        public string? DefaultResult { get; set; }

        /// <summary>
        /// Per-tool message overrides for individual tools loaded from the MCP server (mcp tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolMessages")]
        public global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>? ToolMessages { get; set; }

        /// <summary>
        /// This is the plan to reject a tool call based on the conversation state.<br/>
        /// // Example 1: Reject endCall if user didn't say goodbye<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',<br/>
        ///     target: { position: -1, role: 'user' },<br/>
        ///     negate: true  // Reject if pattern does NOT match<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 2: Reject transfer if user is actually asking a question<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '\\?',<br/>
        ///     target: { position: -1, role: 'user' }<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 3: Reject transfer if user didn't mention transfer recently<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 5 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' %}<br/>
        /// {% assign mentioned = false %}<br/>
        /// {% for msg in userMessages %}<br/>
        ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}<br/>
        ///     {% assign mentioned = true %}<br/>
        ///     {% break %}<br/>
        ///   {% endif %}<br/>
        /// {% endfor %}<br/>
        /// {% if mentioned %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   true<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 4: Reject endCall if the bot is looping and trying to exit<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 6 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}<br/>
        /// {% if userMessages.size &lt; 3 %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   {% assign msg1 = userMessages[0].content | downcase %}<br/>
        ///   {% assign msg2 = userMessages[1].content | downcase %}<br/>
        ///   {% assign msg3 = userMessages[2].content | downcase %}<br/>
        ///   {% comment %} Check for repetitive messages {% endcomment %}<br/>
        ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}<br/>
        ///     true<br/>
        ///   {% comment %} Check for common loop phrases {% endcomment %}<br/>
        ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}<br/>
        ///     true<br/>
        ///   {% else %}<br/>
        ///     false<br/>
        ///   {% endif %}<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionPlan")]
        public global::Vapi.ToolRejectionPlan? RejectionPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolDraftDTO" /> class.
        /// </summary>
        /// <param name="messages">
        /// Messages spoken while the tool is running. Multiple request-start messages are variants. For request-response-delayed, same timing means variants and different timings mean staged updates.
        /// </param>
        /// <param name="type">
        /// This is the type of the tool.
        /// </param>
        /// <param name="function">
        /// This is the function definition of the tool.
        /// </param>
        /// <param name="metadata">
        /// Provider-specific metadata. Polymorphic across tool variants with no shared<br/>
        /// discriminator, so it is validated as a plain object (mirrors how<br/>
        /// `ToolCallResult.metadata` is typed).
        /// </param>
        /// <param name="templateId">
        /// This is the unique identifier for the template this tool was created from.
        /// </param>
        /// <param name="server"></param>
        /// <param name="async"></param>
        /// <param name="destinations">
        /// These are the destinations that the call can be transferred to.
        /// </param>
        /// <param name="name">
        /// This is the name of the tool. This will be passed to the model.
        /// </param>
        /// <param name="subType">
        /// This is the sub type of the tool (e.g. for computer, bash and text-editor tools).
        /// </param>
        /// <param name="displayWidthPx">
        /// The display width in pixels (computer tool).
        /// </param>
        /// <param name="displayHeightPx">
        /// The display height in pixels (computer tool).
        /// </param>
        /// <param name="displayNumber">
        /// Optional display number (computer tool).
        /// </param>
        /// <param name="knowledgeBases">
        /// The knowledge bases to query (query tool).
        /// </param>
        /// <param name="url">
        /// This is where the request will be sent (api-request tool).
        /// </param>
        /// <param name="method">
        /// This is the HTTP method for the request (api-request tool).
        /// </param>
        /// <param name="headers">
        /// These are the headers to send with the request (api-request / sip-request tool).
        /// </param>
        /// <param name="body">
        /// This is the body of the request. Either a JSON schema (api-request) or a<br/>
        /// literal string / schema (sip-request).
        /// </param>
        /// <param name="backoffPlan">
        /// This is the backoff plan if the request fails.
        /// </param>
        /// <param name="timeoutSeconds">
        /// This is the timeout in seconds for the request.
        /// </param>
        /// <param name="description">
        /// This is the description of the tool. This will be passed to the model.
        /// </param>
        /// <param name="variableExtractionPlan">
        /// This is the plan to extract variables from the tool's response.
        /// </param>
        /// <param name="credentialId">
        /// This is the credential ID that will be used for authorization.
        /// </param>
        /// <param name="extendedDelayWhenPrecededByTextEnabled"></param>
        /// <param name="beepDetectionEnabled"></param>
        /// <param name="code">
        /// This is the TypeScript code that will be executed when the tool is called (code tool).
        /// </param>
        /// <param name="environmentVariables">
        /// These are the environment variables available in the code via the `env` object (code tool).
        /// </param>
        /// <param name="parameters">
        /// These are the static parameters to merge into the tool's request body.
        /// </param>
        /// <param name="encryptedPaths">
        /// This is the paths to encrypt in the request body.
        /// </param>
        /// <param name="sipInfoDtmfEnabled">
        /// This enables sending DTMF tones via SIP INFO messages instead of RFC 2833.
        /// </param>
        /// <param name="verb">
        /// This is the SIP method to send (sip-request tool).
        /// </param>
        /// <param name="defaultResult">
        /// This is the default local tool result message used when no runtime override is returned (handoff tool).
        /// </param>
        /// <param name="toolMessages">
        /// Per-tool message overrides for individual tools loaded from the MCP server (mcp tool).
        /// </param>
        /// <param name="rejectionPlan">
        /// This is the plan to reject a tool call based on the conversation state.<br/>
        /// // Example 1: Reject endCall if user didn't say goodbye<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',<br/>
        ///     target: { position: -1, role: 'user' },<br/>
        ///     negate: true  // Reject if pattern does NOT match<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 2: Reject transfer if user is actually asking a question<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'regex',<br/>
        ///     regex: '\\?',<br/>
        ///     target: { position: -1, role: 'user' }<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 3: Reject transfer if user didn't mention transfer recently<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 5 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' %}<br/>
        /// {% assign mentioned = false %}<br/>
        /// {% for msg in userMessages %}<br/>
        ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}<br/>
        ///     {% assign mentioned = true %}<br/>
        ///     {% break %}<br/>
        ///   {% endif %}<br/>
        /// {% endfor %}<br/>
        /// {% if mentioned %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   true<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```<br/>
        /// // Example 4: Reject endCall if the bot is looping and trying to exit<br/>
        /// ```json<br/>
        /// {<br/>
        ///   conditions: [{<br/>
        ///     type: 'liquid',<br/>
        ///     liquid: `{% assign recentMessages = messages | last: 6 %}<br/>
        /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}<br/>
        /// {% if userMessages.size &lt; 3 %}<br/>
        ///   false<br/>
        /// {% else %}<br/>
        ///   {% assign msg1 = userMessages[0].content | downcase %}<br/>
        ///   {% assign msg2 = userMessages[1].content | downcase %}<br/>
        ///   {% assign msg3 = userMessages[2].content | downcase %}<br/>
        ///   {% comment %} Check for repetitive messages {% endcomment %}<br/>
        ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}<br/>
        ///     true<br/>
        ///   {% comment %} Check for common loop phrases {% endcomment %}<br/>
        ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}<br/>
        ///     true<br/>
        ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}<br/>
        ///     true<br/>
        ///   {% else %}<br/>
        ///     false<br/>
        ///   {% endif %}<br/>
        /// {% endif %}`<br/>
        ///   }]<br/>
        /// }<br/>
        /// ```
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateToolDraftDTO(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.ToolMessageStart, global::Vapi.ToolMessageComplete, global::Vapi.ToolMessageFailed, global::Vapi.ToolMessageDelayed>>? messages,
            global::Vapi.UpdateToolDraftDTOType? type,
            global::Vapi.OpenAIFunction? function,
            object? metadata,
            string? templateId,
            global::Vapi.Server? server,
            bool? async,
            global::System.Collections.Generic.IList<object>? destinations,
            string? name,
            string? subType,
            double? displayWidthPx,
            double? displayHeightPx,
            double? displayNumber,
            global::System.Collections.Generic.IList<global::Vapi.KnowledgeBase>? knowledgeBases,
            string? url,
            global::Vapi.UpdateToolDraftDTOMethod? method,
            global::Vapi.JsonSchema? headers,
            object? body,
            global::Vapi.BackoffPlan? backoffPlan,
            double? timeoutSeconds,
            string? description,
            global::Vapi.VariableExtractionPlan? variableExtractionPlan,
            string? credentialId,
            bool? extendedDelayWhenPrecededByTextEnabled,
            bool? beepDetectionEnabled,
            string? code,
            global::System.Collections.Generic.IList<global::Vapi.CodeToolEnvironmentVariable>? environmentVariables,
            global::System.Collections.Generic.IList<global::Vapi.ToolParameter>? parameters,
            global::System.Collections.Generic.IList<string>? encryptedPaths,
            bool? sipInfoDtmfEnabled,
            global::Vapi.UpdateToolDraftDTOVerb? verb,
            string? defaultResult,
            global::System.Collections.Generic.IList<global::Vapi.McpToolMessages>? toolMessages,
            global::Vapi.ToolRejectionPlan? rejectionPlan)
        {
            this.Messages = messages;
            this.Type = type;
            this.Function = function;
            this.Metadata = metadata;
            this.TemplateId = templateId;
            this.Server = server;
            this.Async = async;
            this.Destinations = destinations;
            this.Name = name;
            this.SubType = subType;
            this.DisplayWidthPx = displayWidthPx;
            this.DisplayHeightPx = displayHeightPx;
            this.DisplayNumber = displayNumber;
            this.KnowledgeBases = knowledgeBases;
            this.Url = url;
            this.Method = method;
            this.Headers = headers;
            this.Body = body;
            this.BackoffPlan = backoffPlan;
            this.TimeoutSeconds = timeoutSeconds;
            this.Description = description;
            this.VariableExtractionPlan = variableExtractionPlan;
            this.CredentialId = credentialId;
            this.ExtendedDelayWhenPrecededByTextEnabled = extendedDelayWhenPrecededByTextEnabled;
            this.BeepDetectionEnabled = beepDetectionEnabled;
            this.Code = code;
            this.EnvironmentVariables = environmentVariables;
            this.Parameters = parameters;
            this.EncryptedPaths = encryptedPaths;
            this.SipInfoDtmfEnabled = sipInfoDtmfEnabled;
            this.Verb = verb;
            this.DefaultResult = defaultResult;
            this.ToolMessages = toolMessages;
            this.RejectionPlan = rejectionPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateToolDraftDTO" /> class.
        /// </summary>
        public UpdateToolDraftDTO()
        {
        }

    }
}