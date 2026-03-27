
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnEventsTable
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTypeJsonConverter))]
        public global::Vapi.JSONQueryOnEventsTableType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.<br/>
        /// Must be "events" for event-based insights.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableTableJsonConverter))]
        public global::Vapi.JSONQueryOnEventsTableTable Table { get; set; }

        /// <summary>
        /// The event type to query<br/>
        /// Example: assistant.model.requestFailed
        /// </summary>
        /// <example>assistant.model.requestFailed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("on")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.JSONQueryOnEventsTableOn On { get; set; }

        /// <summary>
        /// This is the operation to perform on matching events.<br/>
        /// - "count": Returns the raw count of matching events<br/>
        /// - "percentage": Returns (count of matching events / total calls) * 100<br/>
        /// Example: count
        /// </summary>
        /// <example>count</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnEventsTableOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.JSONQueryOnEventsTableOperation Operation { get; set; }

        /// <summary>
        /// These are the filters to apply to the events query.<br/>
        /// Each filter filters on a field specific to the event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? Filters { get; set; }

        /// <summary>
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Model Failures
        /// </summary>
        /// <example>Model Failures</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnEventsTable" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </param>
        /// <param name="table">
        /// This is the table that will be queried.<br/>
        /// Must be "events" for event-based insights.
        /// </param>
        /// <param name="on">
        /// The event type to query<br/>
        /// Example: assistant.model.requestFailed
        /// </param>
        /// <param name="operation">
        /// This is the operation to perform on matching events.<br/>
        /// - "count": Returns the raw count of matching events<br/>
        /// - "percentage": Returns (count of matching events / total calls) * 100<br/>
        /// Example: count
        /// </param>
        /// <param name="filters">
        /// These are the filters to apply to the events query.<br/>
        /// Each filter filters on a field specific to the event type.
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Model Failures
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONQueryOnEventsTable(
            global::Vapi.JSONQueryOnEventsTableOn on,
            global::Vapi.JSONQueryOnEventsTableOperation operation,
            global::Vapi.JSONQueryOnEventsTableType type,
            global::Vapi.JSONQueryOnEventsTableTable table,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.EventsTableStringCondition, global::Vapi.EventsTableNumberCondition, global::Vapi.EventsTableBooleanCondition>>? filters,
            string? name)
        {
            this.On = on;
            this.Operation = operation;
            this.Type = type;
            this.Table = table;
            this.Filters = filters;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnEventsTable" /> class.
        /// </summary>
        public JSONQueryOnEventsTable()
        {
        }
    }
}