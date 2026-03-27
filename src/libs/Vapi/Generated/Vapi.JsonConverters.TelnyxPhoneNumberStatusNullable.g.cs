#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class TelnyxPhoneNumberStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.TelnyxPhoneNumberStatus?>
    {
        /// <inheritdoc />
        public override global::Vapi.TelnyxPhoneNumberStatus? Read(
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
                        return global::Vapi.TelnyxPhoneNumberStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.TelnyxPhoneNumberStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.TelnyxPhoneNumberStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.TelnyxPhoneNumberStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.TelnyxPhoneNumberStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
