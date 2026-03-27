#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerCreateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.PhoneNumberControllerCreateRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.PhoneNumberControllerCreateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.PhoneNumberControllerCreateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.PhoneNumberControllerCreateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.CreateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateByoPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateByoPhoneNumberDTO)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTwilioPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTwilioPhoneNumberDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVonagePhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateVonagePhoneNumberDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVapiPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateVapiPhoneNumberDTO)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTelnyxPhoneNumberDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTelnyxPhoneNumberDTO)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.PhoneNumberControllerCreateRequest(
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
            global::Vapi.PhoneNumberControllerCreateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateByoPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateByoPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateByoPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTwilioPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTwilioPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTwilioPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVonagePhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVonagePhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateVonagePhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVapiPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVapiPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateVapiPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTelnyxPhoneNumberDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTelnyxPhoneNumberDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTelnyxPhoneNumberDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeInfo);
            }
        }
    }
}