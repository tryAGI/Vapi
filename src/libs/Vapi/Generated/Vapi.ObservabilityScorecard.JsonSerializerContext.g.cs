
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionType), TypeInfoPropertyName = "NumberComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator), TypeInfoPropertyName = "NumberComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType), TypeInfoPropertyName = "BooleanComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator), TypeInfoPropertyName = "BooleanComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>), TypeInfoPropertyName = "OneOfNumberComparatorScorecardMetricConditionBooleanComparatorScorecardMetricCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Scorecard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Scorecard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateScorecardDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder), TypeInfoPropertyName = "ScorecardControllerGetPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy), TypeInfoPropertyName = "ScorecardControllerGetPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?), TypeInfoPropertyName = "NullableNumberComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?), TypeInfoPropertyName = "NullableNumberComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?), TypeInfoPropertyName = "NullableBooleanComparatorScorecardMetricConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?), TypeInfoPropertyName = "NullableBooleanComparatorScorecardMetricConditionComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>?), TypeInfoPropertyName = "NullableOneOfNumberComparatorScorecardMetricConditionBooleanComparatorScorecardMetricCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder?), TypeInfoPropertyName = "NullableScorecardControllerGetPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy?), TypeInfoPropertyName = "NullableScorecardControllerGetPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.ScorecardMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Scorecard>))]
    internal sealed partial class ObservabilityScorecardSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ObservabilityScorecardSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ObservabilityScorecardSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ObservabilityScorecardSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.NumberComparatorScorecardMetricCondition, global::Vapi.BooleanComparatorScorecardMetricCondition>());
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
                    typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator)

                    || typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator)

                    || typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?)

                    || typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder)

                    || typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder?)

                    || typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy)

                    || typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionType?))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.NumberComparatorScorecardMetricConditionComparator?))
                {
                    return new global::Vapi.JsonConverters.NumberComparatorScorecardMetricConditionComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionType?))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.BooleanComparatorScorecardMetricConditionComparator?))
                {
                    return new global::Vapi.JsonConverters.BooleanComparatorScorecardMetricConditionComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder))
                {
                    return new global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortOrder?))
                {
                    return new global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy))
                {
                    return new global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.ScorecardControllerGetPaginatedSortBy?))
                {
                    return new global::Vapi.JsonConverters.ScorecardControllerGetPaginatedSortByNullableJsonConverter();
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
                    0 => new ObservabilityScorecardSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}