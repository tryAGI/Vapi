
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourcePaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ProviderResource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerCreateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerCreateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourcesPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerGetProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerDeleteProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerDeleteProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider), TypeInfoPropertyName = "ProviderResourceControllerUpdateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName), TypeInfoPropertyName = "ProviderResourceControllerUpdateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceProvider?), TypeInfoPropertyName = "NullableProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceResourceName?), TypeInfoPropertyName = "NullableProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider?), TypeInfoPropertyName = "NullableProviderResourceControllerCreateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName?), TypeInfoPropertyName = "NullableProviderResourceControllerCreateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourcesPaginatedProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourcesPaginatedResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourcesPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourcesPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName?), TypeInfoPropertyName = "NullableProviderResourceControllerGetProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider?), TypeInfoPropertyName = "NullableProviderResourceControllerDeleteProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName?), TypeInfoPropertyName = "NullableProviderResourceControllerDeleteProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider?), TypeInfoPropertyName = "NullableProviderResourceControllerUpdateProviderResourceProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName?), TypeInfoPropertyName = "NullableProviderResourceControllerUpdateProviderResourceResourceName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ProviderResource>))]
    internal sealed partial class ProviderResourcesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProviderResourcesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProviderResourcesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProviderResourcesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Vapi.ProviderResourceProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceResourceName?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider?)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName)

                    || typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName?);
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

                if (typeToConvert == typeof(global::Vapi.ProviderResourceProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceResourceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerCreateProviderResourceResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerCreateProviderResourceResourceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedResourceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortOrder?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourcesPaginatedSortBy?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourcesPaginatedSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerGetProviderResourceResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerGetProviderResourceResourceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerDeleteProviderResourceResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerDeleteProviderResourceResourceNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceProvider?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceResourceNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ProviderResourceControllerUpdateProviderResourceResourceName?))
                {
                    return new global::Vapi.JsonConverters.ProviderResourceControllerUpdateProviderResourceResourceNameNullableJsonConverter();
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
                    0 => new ProviderResourcesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}