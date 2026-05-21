#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class Timing2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.Timing2>
    {
        /// <inheritdoc />
        public override global::Vapi.Timing2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ServerMessageAssistantSpeechTimingDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.AssistantSpeechWordAlignmentTiming? wordAlignment = default;
            if (discriminator?.Type == global::Vapi.ServerMessageAssistantSpeechTimingDiscriminatorType.WordAlignment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordAlignmentTiming> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantSpeechWordAlignmentTiming)}");
                wordAlignment = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.AssistantSpeechWordProgressTiming? wordProgress = default;
            if (discriminator?.Type == global::Vapi.ServerMessageAssistantSpeechTimingDiscriminatorType.WordProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordProgressTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordProgressTiming> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantSpeechWordProgressTiming)}");
                wordProgress = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.Timing2(
                discriminator?.Type,
                wordAlignment,

                wordProgress
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.Timing2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWordAlignment)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordAlignmentTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordAlignmentTiming?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordAlignmentTiming).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WordAlignment!, typeInfo);
            }
            else if (value.IsWordProgress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantSpeechWordProgressTiming), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantSpeechWordProgressTiming?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantSpeechWordProgressTiming).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WordProgress!, typeInfo);
            }
        }
    }
}