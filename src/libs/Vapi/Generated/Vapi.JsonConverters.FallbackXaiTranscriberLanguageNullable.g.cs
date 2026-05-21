#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class FallbackXaiTranscriberLanguageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.FallbackXaiTranscriberLanguage?>
    {
        /// <inheritdoc />
        public override global::Vapi.FallbackXaiTranscriberLanguage? Read(
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
                        return global::Vapi.FallbackXaiTranscriberLanguageExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.FallbackXaiTranscriberLanguage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.FallbackXaiTranscriberLanguage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.FallbackXaiTranscriberLanguage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.FallbackXaiTranscriberLanguageExtensions.ToValueString(value.Value));
            }
        }
    }
}
