#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class PhoneNumberControllerCreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.PhoneNumberControllerCreateResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.PhoneNumberControllerCreateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.PhoneNumberControllerCreateResponseDiscriminator>(ref readerCopy, options);

            global::Vapi.ByoPhoneNumber? byoPhoneNumber = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider.ByoPhoneNumber)
            {
                byoPhoneNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.ByoPhoneNumber>(ref reader, options);
            }
            global::Vapi.TwilioPhoneNumber? twilio = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.TwilioPhoneNumber>(ref reader, options);
            }
            global::Vapi.VonagePhoneNumber? vonage = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.VonagePhoneNumber>(ref reader, options);
            }
            global::Vapi.VapiPhoneNumber? vapi = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider.Vapi)
            {
                vapi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.VapiPhoneNumber>(ref reader, options);
            }
            global::Vapi.TelnyxPhoneNumber? telnyx = default;
            if (discriminator?.Provider == global::Vapi.PhoneNumberControllerCreateResponseDiscriminatorProvider.Telnyx)
            {
                telnyx = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.TelnyxPhoneNumber>(ref reader, options);
            }

            var __value = new global::Vapi.PhoneNumberControllerCreateResponse(
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
            global::Vapi.PhoneNumberControllerCreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsByoPhoneNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoPhoneNumber, typeof(global::Vapi.ByoPhoneNumber), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::Vapi.TwilioPhoneNumber), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::Vapi.VonagePhoneNumber), options);
            }
            else if (value.IsVapi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vapi, typeof(global::Vapi.VapiPhoneNumber), options);
            }
            else if (value.IsTelnyx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Telnyx, typeof(global::Vapi.TelnyxPhoneNumber), options);
            }
        }
    }
}