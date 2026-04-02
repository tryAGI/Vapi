#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.InsightControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.InsightControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.InsightControllerRemoveResponseDiscriminator>(ref readerCopy, options);

            global::Vapi.BarInsight? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerRemoveResponseDiscriminatorType.Bar)
            {
                bar = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.BarInsight>(ref reader, options);
            }
            global::Vapi.PieInsight? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerRemoveResponseDiscriminatorType.Pie)
            {
                pie = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.PieInsight>(ref reader, options);
            }
            global::Vapi.LineInsight? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerRemoveResponseDiscriminatorType.Line)
            {
                line = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.LineInsight>(ref reader, options);
            }
            global::Vapi.TextInsight? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerRemoveResponseDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.TextInsight>(ref reader, options);
            }

            var __value = new global::Vapi.InsightControllerRemoveResponse(
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
            global::Vapi.InsightControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBar)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeof(global::Vapi.BarInsight), options);
            }
            else if (value.IsPie)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeof(global::Vapi.PieInsight), options);
            }
            else if (value.IsLine)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeof(global::Vapi.LineInsight), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::Vapi.TextInsight), options);
            }
        }
    }
}