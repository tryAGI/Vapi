#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class BoardControllerFindAllSortByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.BoardControllerFindAllSortBy?>
    {
        /// <inheritdoc />
        public override global::Vapi.BoardControllerFindAllSortBy? Read(
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
                        return global::Vapi.BoardControllerFindAllSortByExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.BoardControllerFindAllSortBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.BoardControllerFindAllSortBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.BoardControllerFindAllSortBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.BoardControllerFindAllSortByExtensions.ToValueString(value.Value));
            }
        }
    }
}
