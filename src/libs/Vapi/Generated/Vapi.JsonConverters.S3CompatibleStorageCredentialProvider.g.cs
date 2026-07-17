#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class S3CompatibleStorageCredentialProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.S3CompatibleStorageCredentialProvider>
    {
        /// <inheritdoc />
        public override global::Vapi.S3CompatibleStorageCredentialProvider Read(
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
                        return global::Vapi.S3CompatibleStorageCredentialProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.S3CompatibleStorageCredentialProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.S3CompatibleStorageCredentialProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.S3CompatibleStorageCredentialProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.S3CompatibleStorageCredentialProviderExtensions.ToValueString(value));
        }
    }
}
