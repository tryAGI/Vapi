#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class ServerMessageChatDeletedTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ServerMessageChatDeletedType?>
    {
        /// <inheritdoc />
        public override global::Vapi.ServerMessageChatDeletedType? Read(
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
                        return global::Vapi.ServerMessageChatDeletedTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.ServerMessageChatDeletedType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.ServerMessageChatDeletedType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.ServerMessageChatDeletedType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.ServerMessageChatDeletedTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
