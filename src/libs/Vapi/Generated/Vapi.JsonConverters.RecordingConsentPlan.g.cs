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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CompliancePlanRecordingConsentPlanDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.RecordingConsentPlanStayOnLine? stayOnLine = default;
            if (discriminator?.Type == global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType.StayOnLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.RecordingConsentPlanStayOnLine), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.RecordingConsentPlanStayOnLine> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.RecordingConsentPlanStayOnLine)}");
                stayOnLine = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.RecordingConsentPlanVerbal? verbal = default;
            if (discriminator?.Type == global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType.Verbal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.RecordingConsentPlanVerbal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.RecordingConsentPlanVerbal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.RecordingConsentPlanVerbal)}");
                verbal = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStayOnLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.RecordingConsentPlanStayOnLine), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.RecordingConsentPlanStayOnLine?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.RecordingConsentPlanStayOnLine).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StayOnLine, typeInfo);
            }
            else if (value.IsVerbal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.RecordingConsentPlanVerbal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.RecordingConsentPlanVerbal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.RecordingConsentPlanVerbal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Verbal, typeInfo);
            }
        }
    }
}