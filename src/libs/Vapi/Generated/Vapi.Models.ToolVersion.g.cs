
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolVersion
    {
        /// <summary>
        /// Optional human-readable label for this version. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionName")]
        public string? VersionName { get; set; }

        /// <summary>
        /// Optional description for this version. Pass `null` to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versionDescription")]
        public string? VersionDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public object? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public object? Function { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<object>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinations")]
        public global::System.Collections.Generic.IList<object>? Destinations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subType")]
        public string? SubType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayWidthPx")]
        public double? DisplayWidthPx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayHeightPx")]
        public double? DisplayHeightPx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayNumber")]
        public double? DisplayNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("knowledgeBases")]
        public global::System.Collections.Generic.IList<object>? KnowledgeBases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backoffPlan")]
        public object? BackoffPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeoutSeconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableExtractionPlan")]
        public object? VariableExtractionPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rejectionPlan")]
        public object? RejectionPlan { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentVariables")]
        public global::System.Collections.Generic.IList<object>? EnvironmentVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<object>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedPaths")]
        public global::System.Collections.Generic.IList<string>? EncryptedPaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sipInfoDtmfEnabled")]
        public bool? SipInfoDtmfEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verb")]
        public string? Verb { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultResult")]
        public string? DefaultResult { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolMessages")]
        public global::System.Collections.Generic.IList<object>? ToolMessages { get; set; }

        /// <summary>
        /// This is the unique identifier for the version row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that owns this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the unique identifier for the tool this version was snapshotted from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolId { get; set; }

        /// <summary>
        /// This is the public monotonic version label, e.g. "v1".<br/>
        /// System-owned and incremented per tool; never user-supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configHash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigHash { get; set; }

        /// <summary>
        /// This is the prior version label (vN-1). Null on v1 or for branch roots.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentVersion")]
        public string? ParentVersion { get; set; }

        /// <summary>
        /// This is the actor that wrote this version. Email when created via JWT, null when created via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// This is the soft-delete timestamp. Null when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public global::System.DateTime? DeletedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the version row.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that owns this version.
        /// </param>
        /// <param name="toolId">
        /// This is the unique identifier for the tool this version was snapshotted from.
        /// </param>
        /// <param name="version">
        /// This is the public monotonic version label, e.g. "v1".<br/>
        /// System-owned and incremented per tool; never user-supplied.
        /// </param>
        /// <param name="configHash">
        /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the version was created.
        /// </param>
        /// <param name="versionName">
        /// Optional human-readable label for this version. Pass `null` to clear.
        /// </param>
        /// <param name="versionDescription">
        /// Optional description for this version. Pass `null` to clear.
        /// </param>
        /// <param name="type"></param>
        /// <param name="function"></param>
        /// <param name="messages"></param>
        /// <param name="metadata"></param>
        /// <param name="templateId"></param>
        /// <param name="server"></param>
        /// <param name="async"></param>
        /// <param name="destinations"></param>
        /// <param name="name"></param>
        /// <param name="subType"></param>
        /// <param name="displayWidthPx"></param>
        /// <param name="displayHeightPx"></param>
        /// <param name="displayNumber"></param>
        /// <param name="knowledgeBases"></param>
        /// <param name="url"></param>
        /// <param name="method"></param>
        /// <param name="headers"></param>
        /// <param name="body"></param>
        /// <param name="backoffPlan"></param>
        /// <param name="timeoutSeconds"></param>
        /// <param name="description"></param>
        /// <param name="variableExtractionPlan"></param>
        /// <param name="rejectionPlan"></param>
        /// <param name="credentialId"></param>
        /// <param name="extendedDelayWhenPrecededByTextEnabled"></param>
        /// <param name="beepDetectionEnabled"></param>
        /// <param name="code"></param>
        /// <param name="environmentVariables"></param>
        /// <param name="parameters"></param>
        /// <param name="encryptedPaths"></param>
        /// <param name="sipInfoDtmfEnabled"></param>
        /// <param name="verb"></param>
        /// <param name="defaultResult"></param>
        /// <param name="toolMessages"></param>
        /// <param name="parentVersion">
        /// This is the prior version label (vN-1). Null on v1 or for branch roots.
        /// </param>
        /// <param name="createdBy">
        /// This is the actor that wrote this version. Email when created via JWT, null when created via API.
        /// </param>
        /// <param name="deletedAt">
        /// This is the soft-delete timestamp. Null when active.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolVersion(
            string id,
            string orgId,
            string toolId,
            string version,
            string configHash,
            global::System.DateTime createdAt,
            string? versionName,
            string? versionDescription,
            object? type,
            object? function,
            global::System.Collections.Generic.IList<object>? messages,
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
            global::System.Collections.Generic.IList<object>? knowledgeBases,
            string? url,
            string? method,
            object? headers,
            object? body,
            object? backoffPlan,
            double? timeoutSeconds,
            string? description,
            object? variableExtractionPlan,
            object? rejectionPlan,
            string? credentialId,
            bool? extendedDelayWhenPrecededByTextEnabled,
            bool? beepDetectionEnabled,
            string? code,
            global::System.Collections.Generic.IList<object>? environmentVariables,
            global::System.Collections.Generic.IList<object>? parameters,
            global::System.Collections.Generic.IList<string>? encryptedPaths,
            bool? sipInfoDtmfEnabled,
            string? verb,
            string? defaultResult,
            global::System.Collections.Generic.IList<object>? toolMessages,
            string? parentVersion,
            string? createdBy,
            global::System.DateTime? deletedAt)
        {
            this.VersionName = versionName;
            this.VersionDescription = versionDescription;
            this.Type = type;
            this.Function = function;
            this.Messages = messages;
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
            this.RejectionPlan = rejectionPlan;
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
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.ToolId = toolId ?? throw new global::System.ArgumentNullException(nameof(toolId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ConfigHash = configHash ?? throw new global::System.ArgumentNullException(nameof(configHash));
            this.ParentVersion = parentVersion;
            this.CreatedBy = createdBy;
            this.DeletedAt = deletedAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolVersion" /> class.
        /// </summary>
        public ToolVersion()
        {
        }

    }
}