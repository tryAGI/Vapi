#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicBedrockModelModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AnthropicBedrockModelModel?>
    {
        /// <inheritdoc />
        public override global::Vapi.AnthropicBedrockModelModel? Read(
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
                        return global::Vapi.AnthropicBedrockModelModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.AnthropicBedrockModelModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.AnthropicBedrockModelModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.AnthropicBedrockModelModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.AnthropicBedrockModelModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
