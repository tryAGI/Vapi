#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProviderResourceControllerGetProviderResourceProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ProviderResourceControllerGetProviderResourceProvider>
    {
        /// <inheritdoc />
        public override global::Vapi.ProviderResourceControllerGetProviderResourceProvider Read(
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
                        return global::Vapi.ProviderResourceControllerGetProviderResourceProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.ProviderResourceControllerGetProviderResourceProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.ProviderResourceControllerGetProviderResourceProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.ProviderResourceControllerGetProviderResourceProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.ProviderResourceControllerGetProviderResourceProviderExtensions.ToValueString(value));
        }
    }
}
