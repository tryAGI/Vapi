#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class TrafficAllocationControllerCreateResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.TrafficAllocationControllerCreateResponse>
    {
        /// <inheritdoc />
        public override global::Vapi.TrafficAllocationControllerCreateResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TrafficAllocationControllerCreateResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TrafficAllocationControllerCreateResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TrafficAllocationControllerCreateResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.TrafficAllocationStaleConflictResponseDTO? staleAllocation = default;
            if (discriminator?.Error == global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError.StaleAllocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TrafficAllocationStaleConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.TrafficAllocationStaleConflictResponseDTO)}");
                staleAllocation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.AssistantManagedConflictResponseDTO? assistantManagedByVapiAgents = default;
            if (discriminator?.Error == global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError.AssistantManagedByVapiAgents)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantManagedConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantManagedConflictResponseDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantManagedConflictResponseDTO)}");
                assistantManagedByVapiAgents = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.TrafficAllocationControllerCreateResponse(
                discriminator?.Error,
                staleAllocation,

                assistantManagedByVapiAgents
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.TrafficAllocationControllerCreateResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStaleAllocation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.TrafficAllocationStaleConflictResponseDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStaleAllocation(), typeInfo);
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