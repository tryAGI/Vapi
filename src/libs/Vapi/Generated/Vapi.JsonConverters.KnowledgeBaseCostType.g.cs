#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeBaseCostTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.KnowledgeBaseCostType>
    {
        /// <inheritdoc />
        public override global::Vapi.KnowledgeBaseCostType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Vapi.KnowledgeBaseCostTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.KnowledgeBaseCostType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.KnowledgeBaseCostType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.KnowledgeBaseCostType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.KnowledgeBaseCostTypeExtensions.ToValueString(value));
        }
    }
}
