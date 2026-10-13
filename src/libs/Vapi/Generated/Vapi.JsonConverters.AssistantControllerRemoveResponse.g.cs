#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class AssistantControllerRemoveResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.AssistantControllerRemoveResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.AssistantControllerRemoveResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantControllerRemoveResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantControllerRemoveResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantControllerRemoveResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.AssistantPinnedConflictResponseDTO? assistantPinned = default;
            if (discriminator?.Error == global::Vapi.AssistantControllerRemoveResponseDiscriminatorError.AssistantPinned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantPinnedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantPinnedConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantPinnedConflictResponseDTO)}");
                assistantPinned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.AssistantManagedConflictResponseDTO? assistantManagedByVapiAgents = default;
            if (discriminator?.Error == global::Vapi.AssistantControllerRemoveResponseDiscriminatorError.AssistantManagedByVapiAgents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantManagedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantManagedConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantManagedConflictResponseDTO)}");
                assistantManagedByVapiAgents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.AssistantControllerRemoveResponse(
                discriminator?.Error,
                assistantPinned,

                assistantManagedByVapiAgents
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.AssistantControllerRemoveResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssistantPinned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantPinnedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantPinnedConflictResponseDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantPinnedConflictResponseDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssistantPinned(), typeInfo);
            }
            else if (value.IsAssistantManagedByVapiAgents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantManagedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantManagedConflictResponseDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.AssistantManagedConflictResponseDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAssistantManagedByVapiAgents(), typeInfo);
            }
        }
    }
}