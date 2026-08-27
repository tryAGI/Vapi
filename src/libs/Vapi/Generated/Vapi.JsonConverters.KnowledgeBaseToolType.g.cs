#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeBaseToolTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.KnowledgeBaseToolType>
    {
        /// <inheritdoc />
        public override global::Vapi.KnowledgeBaseToolType Read(
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
                        return global::Vapi.KnowledgeBaseToolTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.KnowledgeBaseToolType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.KnowledgeBaseToolType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.KnowledgeBaseToolType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.KnowledgeBaseToolTypeExtensions.ToValueString(value));
        }
    }
}
