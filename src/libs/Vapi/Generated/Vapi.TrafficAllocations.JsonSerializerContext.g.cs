
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationAllocationIntent), TypeInfoPropertyName = "TrafficAllocationAllocationIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationActorType), TypeInfoPropertyName = "TrafficAllocationActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TrafficAllocationTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrafficAllocationTargetDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrafficAllocationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent), TypeInfoPropertyName = "CreateTrafficAllocationDTOAllocationIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.CreateTrafficAllocationTargetDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.TrafficAllocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationLatestResponseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError), TypeInfoPropertyName = "TrafficAllocationStaleConflictResponseDTOError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder), TypeInfoPropertyName = "TrafficAllocationControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationAllocationIntent?), TypeInfoPropertyName = "NullableTrafficAllocationAllocationIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationActorType?), TypeInfoPropertyName = "NullableTrafficAllocationActorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent?), TypeInfoPropertyName = "NullableCreateTrafficAllocationDTOAllocationIntent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError?), TypeInfoPropertyName = "NullableTrafficAllocationStaleConflictResponseDTOError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder?), TypeInfoPropertyName = "NullableTrafficAllocationControllerFindAllPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TrafficAllocationTarget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.CreateTrafficAllocationTargetDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.TrafficAllocation>))]
    internal sealed partial class TrafficAllocationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrafficAllocationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TrafficAllocationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TrafficAllocationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationAllocationIntent)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationAllocationIntent?)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationActorType)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationActorType?)

                    || typeToConvert == typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent)

                    || typeToConvert == typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent?)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError?)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder)

                    || typeToConvert == typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationAllocationIntent))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationAllocationIntentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationAllocationIntent?))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationAllocationIntentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationActorType))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationActorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationActorType?))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationActorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent))
                {
                    return new global::Vapi.JsonConverters.CreateTrafficAllocationDTOAllocationIntentJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateTrafficAllocationDTOAllocationIntent?))
                {
                    return new global::Vapi.JsonConverters.CreateTrafficAllocationDTOAllocationIntentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationStaleConflictResponseDTOErrorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTOError?))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationStaleConflictResponseDTOErrorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationControllerFindAllPaginatedSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.TrafficAllocationControllerFindAllPaginatedSortOrder?))
                {
                    return new global::Vapi.JsonConverters.TrafficAllocationControllerFindAllPaginatedSortOrderNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new TrafficAllocationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}