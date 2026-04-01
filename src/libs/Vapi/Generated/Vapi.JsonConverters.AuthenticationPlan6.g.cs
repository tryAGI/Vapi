#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class AuthenticationPlan6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AuthenticationPlan6>
    {
        /// <inheritdoc />
        public override global::Vapi.AuthenticationPlan6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.OAuth2AuthenticationPlan? oauth2 = default;
            if (discriminator?.Type == global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.OAuth2AuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.OAuth2AuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.OAuth2AuthenticationPlan)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.HMACAuthenticationPlan? hmac = default;
            if (discriminator?.Type == global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Hmac)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.HMACAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.HMACAuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.HMACAuthenticationPlan)}");
                hmac = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.BearerAuthenticationPlan? bearer = default;
            if (discriminator?.Type == global::Vapi.CreateCustomCredentialDTOAuthenticationPlanDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BearerAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BearerAuthenticationPlan> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.BearerAuthenticationPlan)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.AuthenticationPlan6(
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
            global::Vapi.AuthenticationPlan6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.OAuth2AuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.OAuth2AuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.OAuth2AuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsHmac)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.HMACAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.HMACAuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.HMACAuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hmac!, typeInfo);
            }
            else if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BearerAuthenticationPlan), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BearerAuthenticationPlan?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.BearerAuthenticationPlan).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
        }
    }
}