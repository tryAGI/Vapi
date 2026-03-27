#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerUpdateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.PhoneNumberControllerUpdateResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.PhoneNumberControllerUpdateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.PhoneNumberControllerUpdateResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.ByoPhoneNumber? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider.ByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ByoPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ByoPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ByoPhoneNumber)}");
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.TwilioPhoneNumber? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TwilioPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TwilioPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TwilioPhoneNumber)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.VonagePhoneNumber? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VonagePhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VonagePhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.VonagePhoneNumber)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.VapiPhoneNumber? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Vapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VapiPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VapiPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.VapiPhoneNumber)}");
                vapi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.TelnyxPhoneNumber? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateResponseDiscriminatorProvider.Telnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TelnyxPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TelnyxPhoneNumber> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TelnyxPhoneNumber)}");
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.PhoneNumberControllerUpdateResponse(
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
            global::Vapi.PhoneNumberControllerUpdateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsByoPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ByoPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ByoPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.ByoPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TwilioPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TwilioPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TwilioPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VonagePhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VonagePhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.VonagePhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeInfo);
            }
            else if (value.IsVapi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.VapiPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.VapiPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.VapiPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeInfo);
            }
            else if (value.IsTelnyx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TelnyxPhoneNumber), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TelnyxPhoneNumber?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TelnyxPhoneNumber).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeInfo);
            }
        }
    }
}