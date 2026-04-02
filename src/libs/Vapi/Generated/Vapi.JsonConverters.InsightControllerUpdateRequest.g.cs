#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerUpdateRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.InsightControllerUpdateRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.InsightControllerUpdateRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.InsightControllerUpdateRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.UpdateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateBarInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.UpdatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdatePieInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.UpdateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateLineInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.UpdateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateTextInsightFromCallTableDTO>(ref reader, options);
            }

            var __value = new global::Vapi.InsightControllerUpdateRequest(
                discriminator?.Type,
                bar,

                pie,

                line,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.InsightControllerUpdateRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::Vapi.UpdateBarInsightFromCallTableDTO), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::Vapi.UpdatePieInsightFromCallTableDTO), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::Vapi.UpdateLineInsightFromCallTableDTO), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Vapi.UpdateTextInsightFromCallTableDTO), options);
            }
        }
    }
}