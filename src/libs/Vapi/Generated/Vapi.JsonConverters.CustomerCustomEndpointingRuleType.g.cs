#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CustomerCustomEndpointingRuleTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CustomerCustomEndpointingRuleType>
    {
        /// <inheritdoc />
        public override global::Vapi.CustomerCustomEndpointingRuleType Read(
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
                        return global::Vapi.CustomerCustomEndpointingRuleTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CustomerCustomEndpointingRuleType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CustomerCustomEndpointingRuleType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CustomerCustomEndpointingRuleType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.CustomerCustomEndpointingRuleTypeExtensions.ToValueString(value));
        }
    }
}
