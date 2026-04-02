#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class RecordingConsentPlanJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.RecordingConsentPlan>
    {
        /// <inheritdoc />
        public override global::Vapi.RecordingConsentPlan Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator>(ref readerCopy, options);

            global::Vapi.RecordingConsentPlanStayOnLine? stayOnLine = default;
            if (discriminator?.Type == global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine)
            {
                stayOnLine = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.RecordingConsentPlanStayOnLine>(ref reader, options);
            }
            global::Vapi.RecordingConsentPlanVerbal? verbal = default;
            if (discriminator?.Type == global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal)
            {
                verbal = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.RecordingConsentPlanVerbal>(ref reader, options);
            }

            var __value = new global::Vapi.RecordingConsentPlan(
                discriminator?.Type,
                stayOnLine,

                verbal
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.RecordingConsentPlan value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStayOnLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StayOnLine, typeof(global::Vapi.RecordingConsentPlanStayOnLine), options);
            }
            else if (value.IsVerbal)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Verbal, typeof(global::Vapi.RecordingConsentPlanVerbal), options);
            }
        }
    }
}