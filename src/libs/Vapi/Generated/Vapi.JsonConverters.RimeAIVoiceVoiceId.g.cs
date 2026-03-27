#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class RimeAIVoiceVoiceIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.RimeAIVoiceVoiceId>
    {
        /// <inheritdoc />
        public override global::Vapi.RimeAIVoiceVoiceId Read(
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
                        return global::Vapi.RimeAIVoiceVoiceIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.RimeAIVoiceVoiceId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.RimeAIVoiceVoiceId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.RimeAIVoiceVoiceId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.RimeAIVoiceVoiceIdExtensions.ToValueString(value));
        }
    }
}
