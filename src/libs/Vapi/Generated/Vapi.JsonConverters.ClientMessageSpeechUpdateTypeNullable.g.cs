#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class ClientMessageSpeechUpdateTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ClientMessageSpeechUpdateType?>
    {
        /// <inheritdoc />
        public override global::Vapi.ClientMessageSpeechUpdateType? Read(
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
                        return global::Vapi.ClientMessageSpeechUpdateTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.ClientMessageSpeechUpdateType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.ClientMessageSpeechUpdateType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.ClientMessageSpeechUpdateType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.ClientMessageSpeechUpdateTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
