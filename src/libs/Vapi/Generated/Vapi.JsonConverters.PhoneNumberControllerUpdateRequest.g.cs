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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.PhoneNumberControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.UpdateByoPhoneNumberDTO? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateByoPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.UpdateTwilioPhoneNumberDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateTwilioPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.UpdateVonagePhoneNumberDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateVonagePhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.UpdateVapiPhoneNumberDTO? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateVapiPhoneNumberDTO>(ref reader, options);
            }
            global::Vapi.UpdateTelnyxPhoneNumberDTO? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateTelnyxPhoneNumberDTO>(ref reader, options);
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

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::Vapi.UpdateByoPhoneNumberDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::Vapi.UpdateTwilioPhoneNumberDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::Vapi.UpdateVonagePhoneNumberDTO), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::Vapi.UpdateVapiPhoneNumberDTO), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO), options);
            }
        }
    }
}