#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureSpeechTranscriberProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AzureSpeechTranscriberProvider?>
    {
        /// <inheritdoc />
        public override global::Vapi.AzureSpeechTranscriberProvider? Read(
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
                        return global::Vapi.AzureSpeechTranscriberProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.AzureSpeechTranscriberProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.AzureSpeechTranscriberProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.AzureSpeechTranscriberProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.AzureSpeechTranscriberProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
