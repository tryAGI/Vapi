#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class MakeToolProviderDetailsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.MakeToolProviderDetailsType>
    {
        /// <inheritdoc />
        public override global::Vapi.MakeToolProviderDetailsType Read(
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
                        return global::Vapi.MakeToolProviderDetailsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.MakeToolProviderDetailsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.MakeToolProviderDetailsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.MakeToolProviderDetailsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.MakeToolProviderDetailsTypeExtensions.ToValueString(value));
        }
    }
}
