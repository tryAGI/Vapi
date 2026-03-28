
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JSONQueryOnCallTableWithNumberTypeColumn
    {
        /// <summary>
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </summary>
        /// <example>vapiql-json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTypeJsonConverter))]
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType Type { get; set; }

        /// <summary>
        /// This is the table that will be queried.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnTableJsonConverter))]
        public global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable Table { get; set; }

        /// <summary>
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>? Filters { get; set; }

        /// <summary>
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// Number Type columns are columns where the rows store Number data<br/>
        /// Example: duration
        /// </summary>
        /// <example>duration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnColumnJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn Column { get; set; }

        /// <summary>
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a number type, the operation must be one of the following:<br/>
        /// - average<br/>
        /// - sum<br/>
        /// - min<br/>
        /// - max<br/>
        /// Example: sum
        /// </summary>
        /// <example>sum</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.JSONQueryOnCallTableWithNumberTypeColumnOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation Operation { get; set; }

        /// <summary>
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </summary>
        /// <example>Total Calls</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithNumberTypeColumn" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of query. Only allowed type is "vapiql-json".<br/>
        /// Example: vapiql-json
        /// </param>
        /// <param name="table">
        /// This is the table that will be queried.
        /// </param>
        /// <param name="filters">
        /// This is the filters to apply to the insight.<br/>
        /// The discriminator automatically selects the correct filter type based on column and operator.
        /// </param>
        /// <param name="column">
        /// This is the column that will be queried in the selected table.<br/>
        /// Available columns depend on the selected table.<br/>
        /// Number Type columns are columns where the rows store Number data<br/>
        /// Example: duration
        /// </param>
        /// <param name="operation">
        /// This is the aggregation operation to perform on the column.<br/>
        /// When the column is a number type, the operation must be one of the following:<br/>
        /// - average<br/>
        /// - sum<br/>
        /// - min<br/>
        /// - max<br/>
        /// Example: sum
        /// </param>
        /// <param name="name">
        /// This is the name of the query.<br/>
        /// It will be used to label the query in the insight board on the UI.<br/>
        /// Example: Total Calls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JSONQueryOnCallTableWithNumberTypeColumn(
            global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnColumn column,
            global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnOperation operation,
            global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnType type,
            global::Vapi.JSONQueryOnCallTableWithNumberTypeColumnTable table,
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.FilterStringTypeColumnOnCallTable, global::Vapi.FilterStringArrayTypeColumnOnCallTable, global::Vapi.FilterNumberTypeColumnOnCallTable, global::Vapi.FilterNumberArrayTypeColumnOnCallTable, global::Vapi.FilterDateTypeColumnOnCallTable, global::Vapi.FilterStructuredOutputColumnOnCallTable>>? filters,
            string? name)
        {
            this.Column = column;
            this.Operation = operation;
            this.Type = type;
            this.Table = table;
            this.Filters = filters;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONQueryOnCallTableWithNumberTypeColumn" /> class.
        /// </summary>
        public JSONQueryOnCallTableWithNumberTypeColumn()
        {
        }
    }
}