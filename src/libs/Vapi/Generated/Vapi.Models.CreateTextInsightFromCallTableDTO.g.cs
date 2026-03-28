
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextInsightFromCallTableDTO
    {
        /// <summary>
        /// This is the name of the Insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the type of the Insight.<br/>
        /// It is required to be `text` to create a text insight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.CreateTextInsightFromCallTableDTOTypeJsonConverter))]
        public global::Vapi.CreateTextInsightFromCallTableDTOType Type { get; set; }

        /// <summary>
        /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.<br/>
        /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// A formula is created by using the query names as the variable.<br/>
        /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:<br/>
        /// ```<br/>
        /// {{['Query 1']}} / {{['Query 2']}} * 100<br/>
        /// ```<br/>
        /// ```<br/>
        /// ({{[Query 1]}} * 10) + {{[Query 2]}}<br/>
        /// ```<br/>
        /// This will take the<br/>
        /// You can also use the query names as the variable in the formula.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formula")]
        public object? Formula { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeRange")]
        public global::Vapi.InsightTimeRange? TimeRange { get; set; }

        /// <summary>
        /// These are the queries to run to generate the insight.<br/>
        /// For Text Insights, we only allow a single query, or require a formula if multiple queries are provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>> Queries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextInsightFromCallTableDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the Insight.
        /// </param>
        /// <param name="type">
        /// This is the type of the Insight.<br/>
        /// It is required to be `text` to create a text insight.
        /// </param>
        /// <param name="formula">
        /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.<br/>
        /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html<br/>
        /// A formula is created by using the query names as the variable.<br/>
        /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.<br/>
        /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:<br/>
        /// ```<br/>
        /// {{['Query 1']}} / {{['Query 2']}} * 100<br/>
        /// ```<br/>
        /// ```<br/>
        /// ({{[Query 1]}} * 10) + {{[Query 2]}}<br/>
        /// ```<br/>
        /// This will take the<br/>
        /// You can also use the query names as the variable in the formula.
        /// </param>
        /// <param name="timeRange"></param>
        /// <param name="queries">
        /// These are the queries to run to generate the insight.<br/>
        /// For Text Insights, we only allow a single query, or require a formula if multiple queries are provided
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextInsightFromCallTableDTO(
            global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.JSONQueryOnCallTableWithStringTypeColumn, global::Vapi.JSONQueryOnCallTableWithNumberTypeColumn, global::Vapi.JSONQueryOnCallTableWithStructuredOutputColumn>> queries,
            string? name,
            global::Vapi.CreateTextInsightFromCallTableDTOType type,
            object? formula,
            global::Vapi.InsightTimeRange? timeRange)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Name = name;
            this.Type = type;
            this.Formula = formula;
            this.TimeRange = timeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextInsightFromCallTableDTO" /> class.
        /// </summary>
        public CreateTextInsightFromCallTableDTO()
        {
        }
    }
}