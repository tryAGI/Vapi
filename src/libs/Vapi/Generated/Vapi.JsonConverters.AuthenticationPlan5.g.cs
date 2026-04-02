#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class AuthenticationPlan5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AuthenticationPlan5>
    {
        /// <inheritdoc />
        public override global::Vapi.AuthenticationPlan5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CustomCredentialAuthenticationPlanDiscriminator>(ref readerCopy, options);

            global::Vapi.OAuth2AuthenticationPlan? oauth2 = default;
            if (discriminator?.Type == global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.OAuth2AuthenticationPlan>(ref reader, options);
            }
            global::Vapi.HMACAuthenticationPlan? hmac = default;
            if (discriminator?.Type == global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType.Hmac)
            {
                hmac = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.HMACAuthenticationPlan>(ref reader, options);
            }
            global::Vapi.BearerAuthenticationPlan? bearer = default;
            if (discriminator?.Type == global::Vapi.CustomCredentialAuthenticationPlanDiscriminatorType.Bearer)
            {
                bearer = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.BearerAuthenticationPlan>(ref reader, options);
            }

            var __value = new global::Vapi.AuthenticationPlan5(
                discriminator?.Type,
                oauth2,

                hmac,

                bearer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.AuthenticationPlan5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::Vapi.OAuth2AuthenticationPlan), options);
            }
            else if (value.IsHmac)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hmac, typeof(global::Vapi.HMACAuthenticationPlan), options);
            }
            else if (value.IsBearer)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer, typeof(global::Vapi.BearerAuthenticationPlan), options);
            }
        }
    }
}