#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class InsightControllerCreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.InsightControllerCreateResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.InsightControllerCreateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.InsightControllerCreateResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.InsightControllerCreateResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.InsightControllerCreateResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.BarInsight? bar = default;
            if (discriminator?.Type == global::Vapi.InsightControllerCreateResponseDiscriminatorType.Bar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BarInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BarInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.BarInsight)}");
                bar = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.PieInsight? pie = default;
            if (discriminator?.Type == global::Vapi.InsightControllerCreateResponseDiscriminatorType.Pie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.PieInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.PieInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.PieInsight)}");
                pie = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.LineInsight? line = default;
            if (discriminator?.Type == global::Vapi.InsightControllerCreateResponseDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.LineInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.LineInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.LineInsight)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.TextInsight? text = default;
            if (discriminator?.Type == global::Vapi.InsightControllerCreateResponseDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TextInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TextInsight> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TextInsight)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.InsightControllerCreateResponse(
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
            global::Vapi.InsightControllerCreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.BarInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.BarInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.BarInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bar, typeInfo);
            }
            else if (value.IsPie)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.PieInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.PieInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.PieInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pie, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.LineInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.LineInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.LineInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TextInsight), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TextInsight?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TextInsight).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}