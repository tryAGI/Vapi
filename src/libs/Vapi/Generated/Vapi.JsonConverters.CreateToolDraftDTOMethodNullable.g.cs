#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateToolDraftDTOMethodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CreateToolDraftDTOMethod?>
    {
        /// <inheritdoc />
        public override global::Vapi.CreateToolDraftDTOMethod? Read(
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
                        return global::Vapi.CreateToolDraftDTOMethodExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CreateToolDraftDTOMethod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CreateToolDraftDTOMethod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CreateToolDraftDTOMethod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.CreateToolDraftDTOMethodExtensions.ToValueString(value.Value));
            }
        }
    }
}
