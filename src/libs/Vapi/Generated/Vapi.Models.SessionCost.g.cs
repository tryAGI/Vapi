
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionCost
    {
        /// <summary>
        /// This is the type of cost, always 'session' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Vapi.JsonConverters.SessionCostTypeJsonConverter))]
        public global::Vapi.SessionCostType Type { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCost" /> class.
        /// </summary>
        /// <param name="type">
        /// This is the type of cost, always 'session' for this class.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionCost(
            double cost,
            global::Vapi.SessionCostType type)
        {
            this.Cost = cost;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionCost" /> class.
        /// </summary>
        public SessionCost()
        {
        }
    }
}