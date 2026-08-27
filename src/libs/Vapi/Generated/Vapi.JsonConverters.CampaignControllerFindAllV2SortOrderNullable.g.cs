#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CampaignControllerFindAllV2SortOrderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CampaignControllerFindAllV2SortOrder?>
    {
        /// <inheritdoc />
        public override global::Vapi.CampaignControllerFindAllV2SortOrder? Read(
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
                        return global::Vapi.CampaignControllerFindAllV2SortOrderExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CampaignControllerFindAllV2SortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CampaignControllerFindAllV2SortOrder?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CampaignControllerFindAllV2SortOrder? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.CampaignControllerFindAllV2SortOrderExtensions.ToValueString(value.Value));
            }
        }
    }
}
