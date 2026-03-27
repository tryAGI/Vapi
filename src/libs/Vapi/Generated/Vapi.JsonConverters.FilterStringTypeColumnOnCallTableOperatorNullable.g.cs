#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class FilterStringTypeColumnOnCallTableOperatorNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.FilterStringTypeColumnOnCallTableOperator?>
    {
        /// <inheritdoc />
        public override global::Vapi.FilterStringTypeColumnOnCallTableOperator? Read(
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
                        return global::Vapi.FilterStringTypeColumnOnCallTableOperatorExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.FilterStringTypeColumnOnCallTableOperator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.FilterStringTypeColumnOnCallTableOperator?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.FilterStringTypeColumnOnCallTableOperator? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.FilterStringTypeColumnOnCallTableOperatorExtensions.ToValueString(value.Value));
            }
        }
    }
}
