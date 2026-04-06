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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.InsightControllerPreviewRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.InsightControllerPreviewRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.InsightControllerPreviewRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.CreateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateBarInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateBarInsightFromCallTableDTO)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePieInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreatePieInsightFromCallTableDTO)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLineInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateLineInsightFromCallTableDTO)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerPreviewRequestDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTextInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTextInsightFromCallTableDTO)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateBarInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateBarInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar!, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePieInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreatePieInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie!, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLineInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateLineInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTextInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTextInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}