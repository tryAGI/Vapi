#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType Read(
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
                        return global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
