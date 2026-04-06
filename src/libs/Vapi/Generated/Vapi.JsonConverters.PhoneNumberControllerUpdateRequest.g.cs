#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.PhoneNumberControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.PhoneNumberControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.UpdateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateByoPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateByoPhoneNumberDTO)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTwilioPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateTwilioPhoneNumberDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVonagePhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateVonagePhoneNumberDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVapiPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateVapiPhoneNumberDTO)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTelnyxPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateTelnyxPhoneNumberDTO)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.PhoneNumberControllerUpdateRequest(
                discriminator?.Provider,
                byoPhoneNumber,

                twilio,

                vonage,

                vapi,

                telnyx
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.PhoneNumberControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateByoPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateByoPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber!, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTwilioPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTwilioPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVonagePhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVonagePhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage!, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateVapiPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateVapiPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi!, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTelnyxPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx!, typeInfo);
            }
        }
    }
}