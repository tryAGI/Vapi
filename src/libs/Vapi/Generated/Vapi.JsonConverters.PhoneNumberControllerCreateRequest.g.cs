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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.PhoneNumberControllerCreateRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.CreateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateByoPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.CreateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTwilioPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.CreateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateVonagePhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.CreateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateVapiPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.CreateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTelnyxPhoneNumberDTO>(ref reader, options);
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

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::Vapi.CreateByoPhoneNumberDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::Vapi.CreateTwilioPhoneNumberDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::Vapi.CreateVonagePhoneNumberDTO), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::Vapi.CreateVapiPhoneNumberDTO), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::Vapi.CreateTelnyxPhoneNumberDTO), options);
            }
        }
    }
}