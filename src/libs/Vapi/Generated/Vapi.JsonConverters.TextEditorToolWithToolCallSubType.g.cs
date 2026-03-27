#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextEditorToolWithToolCallSubTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.TextEditorToolWithToolCallSubType>
    {
        /// <inheritdoc />
        public override global::Vapi.TextEditorToolWithToolCallSubType Read(
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
                        return global::Vapi.TextEditorToolWithToolCallSubTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.TextEditorToolWithToolCallSubType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.TextEditorToolWithToolCallSubType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.TextEditorToolWithToolCallSubType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.TextEditorToolWithToolCallSubTypeExtensions.ToValueString(value));
        }
    }
}
