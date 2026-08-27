#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class KnowledgeBaseV2FileStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.KnowledgeBaseV2FileStatus?>
    {
        /// <inheritdoc />
        public override global::Vapi.KnowledgeBaseV2FileStatus? Read(
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
                        return global::Vapi.KnowledgeBaseV2FileStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.KnowledgeBaseV2FileStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.KnowledgeBaseV2FileStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.KnowledgeBaseV2FileStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.KnowledgeBaseV2FileStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
