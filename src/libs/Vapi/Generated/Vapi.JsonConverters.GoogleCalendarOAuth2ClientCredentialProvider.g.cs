#nullable enable

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public sealed class GoogleCalendarOAuth2ClientCredentialProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider>
    {
        /// <inheritdoc />
        public override global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider Read(
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
                        return global::Vapi.GoogleCalendarOAuth2ClientCredentialProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.GoogleCalendarOAuth2ClientCredentialProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Vapi.GoogleCalendarOAuth2ClientCredentialProviderExtensions.ToValueString(value));
        }
    }
}
