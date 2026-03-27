#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleCalendarOAuth2AuthorizationCredentialProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider>
    {
        /// <inheritdoc />
        public override global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider Read(
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
                        return global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.GoogleCalendarOAuth2AuthorizationCredentialProviderExtensions.ToValueString(value));
        }
    }
}
