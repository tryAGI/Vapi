#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicModelReasoningEffortJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AnthropicModelReasoningEffort>
    {
        /// <inheritdoc />
        public override global::Vapi.AnthropicModelReasoningEffort Read(
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
                        return global::Vapi.AnthropicModelReasoningEffortExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.AnthropicModelReasoningEffort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.AnthropicModelReasoningEffort);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.AnthropicModelReasoningEffort value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.AnthropicModelReasoningEffortExtensions.ToValueString(value));
        }
    }
}
