#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateDeepInfraCredentialDTOProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CreateDeepInfraCredentialDTOProvider?>
    {
        /// <inheritdoc />
        public override global::Vapi.CreateDeepInfraCredentialDTOProvider? Read(
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
                        return global::Vapi.CreateDeepInfraCredentialDTOProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CreateDeepInfraCredentialDTOProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CreateDeepInfraCredentialDTOProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CreateDeepInfraCredentialDTOProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Vapi.CreateDeepInfraCredentialDTOProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
