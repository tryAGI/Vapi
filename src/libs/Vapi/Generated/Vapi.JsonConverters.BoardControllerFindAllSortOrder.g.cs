#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class BoardControllerFindAllSortOrderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.BoardControllerFindAllSortOrder>
    {
        /// <inheritdoc />
        public override global::Vapi.BoardControllerFindAllSortOrder Read(
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
                        return global::Vapi.BoardControllerFindAllSortOrderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.BoardControllerFindAllSortOrder)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.BoardControllerFindAllSortOrder);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.BoardControllerFindAllSortOrder value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.BoardControllerFindAllSortOrderExtensions.ToValueString(value));
        }
    }
}
