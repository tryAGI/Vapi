#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class ToolControllerRemoveResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.ToolControllerRemoveResponse2>
    {
        /// <inheritdoc />
        public override global::Vapi.ToolControllerRemoveResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolControllerRemoveResponseDiscriminator2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolControllerRemoveResponseDiscriminator2> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolControllerRemoveResponseDiscriminator2)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.ToolPinnedConflictResponseDTO? toolPinned = default;
            if (discriminator?.Error == global::Vapi.ToolControllerRemoveResponseDiscriminator2Error.ToolPinned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolPinnedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolPinnedConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolPinnedConflictResponseDTO)}");
                toolPinned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.ToolWriteConflictResponseDTO? toolWriteConflict = default;
            if (discriminator?.Error == global::Vapi.ToolControllerRemoveResponseDiscriminator2Error.ToolWriteConflict)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolWriteConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolWriteConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.ToolWriteConflictResponseDTO)}");
                toolWriteConflict = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.ToolControllerRemoveResponse2(
                discriminator?.Error,
                toolPinned,

                toolWriteConflict
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.ToolControllerRemoveResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolPinned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolPinnedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolPinnedConflictResponseDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.ToolPinnedConflictResponseDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolPinned!, typeInfo);
            }
            else if (value.IsToolWriteConflict)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.ToolWriteConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.ToolWriteConflictResponseDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.ToolWriteConflictResponseDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolWriteConflict!, typeInfo);
            }
        }
    }
}