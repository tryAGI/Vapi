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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.InsightControllerUpdateRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.InsightControllerUpdateRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.InsightControllerUpdateRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.UpdateBarInsightFromCallTableDTO? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBarInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateBarInsightFromCallTableDTO)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdatePieInsightFromCallTableDTO? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdatePieInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdatePieInsightFromCallTableDTO)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateLineInsightFromCallTableDTO? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateLineInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateLineInsightFromCallTableDTO)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.UpdateTextInsightFromCallTableDTO? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerUpdateRequestDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextInsightFromCallTableDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.UpdateTextInsightFromCallTableDTO)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateBarInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateBarInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateBarInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar!, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdatePieInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdatePieInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdatePieInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie!, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateLineInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateLineInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateLineInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.UpdateTextInsightFromCallTableDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.UpdateTextInsightFromCallTableDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.UpdateTextInsightFromCallTableDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
        }
    }
}