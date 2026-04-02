#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerPreviewRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.InsightControllerPreviewRequest>
    {
        /// <inheritdoc />
        public override global::Vapi.InsightControllerPreviewRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.InsightControllerPreviewRequestDiscriminator>(ref readerCopy, options);

            global::Vapi.CreateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateBarInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.CreatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreatePieInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.CreateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateLineInsightFromCallTableDTO>(ref reader, options);
            }
            global::Vapi.CreateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTextInsightFromCallTableDTO>(ref reader, options);
            }

            var __value = new global::Vapi.InsightControllerPreviewRequest(
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
            global::Vapi.InsightControllerPreviewRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::Vapi.CreateBarInsightFromCallTableDTO), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::Vapi.CreatePieInsightFromCallTableDTO), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::Vapi.CreateLineInsightFromCallTableDTO), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Vapi.CreateTextInsightFromCallTableDTO), options);
            }
        }
    }
}