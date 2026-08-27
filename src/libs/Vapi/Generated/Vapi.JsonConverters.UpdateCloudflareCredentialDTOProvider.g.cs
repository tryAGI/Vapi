#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateCloudflareCredentialDTOProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.UpdateCloudflareCredentialDTOProvider>
    {
        /// <inheritdoc />
        public override global::Vapi.UpdateCloudflareCredentialDTOProvider Read(
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
                        return global::Vapi.UpdateCloudflareCredentialDTOProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.UpdateCloudflareCredentialDTOProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.UpdateCloudflareCredentialDTOProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.UpdateCloudflareCredentialDTOProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.UpdateCloudflareCredentialDTOProviderExtensions.ToValueString(value));
        }
    }
}
