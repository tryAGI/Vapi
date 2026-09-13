
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.BackoffPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Server))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType), TypeInfoPropertyName = "JsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vapi.JsonSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat), TypeInfoPropertyName = "JsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookInclude))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookActionType), TypeInfoPropertyName = "SimulationHookWebhookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStarted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStartedOn), TypeInfoPropertyName = "SimulationHookCallStartedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationHookWebhookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEnded))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEndedOn), TypeInfoPropertyName = "SimulationHookCallEndedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?>), TypeInfoPropertyName = "OneOfDoubleStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>), TypeInfoPropertyName = "OneOfSimulationHookCallStartedSimulationHookCallEnded2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfigurationProvider), TypeInfoPropertyName = "SimulationRunTransportConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMonitor))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemCallMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?, object>), TypeInfoPropertyName = "OneOfDoubleStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResultComparator), TypeInfoPropertyName = "StructuredOutputEvaluationResultComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.LatencyMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutputEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovementSuggestion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemImprovements))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationRunItemImprovementSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemStatus), TypeInfoPropertyName = "SimulationRunItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsStatus), TypeInfoPropertyName = "SimulationRunControllerFindItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder), TypeInfoPropertyName = "SimulationRunControllerFindItemsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsSortBy), TypeInfoPropertyName = "SimulationRunControllerFindItemsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationRunItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType?), TypeInfoPropertyName = "NullableJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat?), TypeInfoPropertyName = "NullableJsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookWebhookActionType?), TypeInfoPropertyName = "NullableSimulationHookWebhookActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallStartedOn?), TypeInfoPropertyName = "NullableSimulationHookCallStartedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationHookCallEndedOn?), TypeInfoPropertyName = "NullableSimulationHookCallEndedOn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?>?), TypeInfoPropertyName = "NullableOneOfDoubleStringBoolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>?), TypeInfoPropertyName = "NullableOneOfSimulationHookCallStartedSimulationHookCallEnded2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunTransportConfigurationProvider?), TypeInfoPropertyName = "NullableSimulationRunTransportConfigurationProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<double?, string, bool?, object>?), TypeInfoPropertyName = "NullableOneOfDoubleStringBooleanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputEvaluationResultComparator?), TypeInfoPropertyName = "NullableStructuredOutputEvaluationResultComparator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunItemStatus?), TypeInfoPropertyName = "NullableSimulationRunItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsStatus?), TypeInfoPropertyName = "NullableSimulationRunControllerFindItemsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder?), TypeInfoPropertyName = "NullableSimulationRunControllerFindItemsSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationRunControllerFindItemsSortBy?), TypeInfoPropertyName = "NullableSimulationRunControllerFindItemsSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationHookWebhookAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredOutputEvaluationResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationRunItemImprovementSuggestion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationRunItem>))]
    internal sealed partial class SimulationRunItemsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationRunItemsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SimulationRunItemsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SimulationRunItemsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationHookCallStarted, global::Vapi.SimulationHookCallEnded>());
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
                    typeToConvert == typeof(global::Vapi.JsonSchemaType)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaType?)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaFormat)

                    || typeToConvert == typeof(global::Vapi.JsonSchemaFormat?)

                    || typeToConvert == typeof(global::Vapi.SimulationHookWebhookActionType)

                    || typeToConvert == typeof(global::Vapi.SimulationHookWebhookActionType?)

                    || typeToConvert == typeof(global::Vapi.SimulationHookCallStartedOn)

                    || typeToConvert == typeof(global::Vapi.SimulationHookCallStartedOn?)

                    || typeToConvert == typeof(global::Vapi.SimulationHookCallEndedOn)

                    || typeToConvert == typeof(global::Vapi.SimulationHookCallEndedOn?)

                    || typeToConvert == typeof(global::Vapi.SimulationRunTransportConfigurationProvider)

                    || typeToConvert == typeof(global::Vapi.SimulationRunTransportConfigurationProvider?)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputEvaluationResultComparator)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputEvaluationResultComparator?)

                    || typeToConvert == typeof(global::Vapi.SimulationRunItemStatus)

                    || typeToConvert == typeof(global::Vapi.SimulationRunItemStatus?)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsStatus)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsStatus?)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder?)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortBy)

                    || typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.JsonSchemaType))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaType?))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaFormat))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.JsonSchemaFormat?))
                {
                    return new global::Vapi.JsonConverters.JsonSchemaFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookWebhookActionType))
                {
                    return new global::Vapi.JsonConverters.SimulationHookWebhookActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookWebhookActionType?))
                {
                    return new global::Vapi.JsonConverters.SimulationHookWebhookActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookCallStartedOn))
                {
                    return new global::Vapi.JsonConverters.SimulationHookCallStartedOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookCallStartedOn?))
                {
                    return new global::Vapi.JsonConverters.SimulationHookCallStartedOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookCallEndedOn))
                {
                    return new global::Vapi.JsonConverters.SimulationHookCallEndedOnJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationHookCallEndedOn?))
                {
                    return new global::Vapi.JsonConverters.SimulationHookCallEndedOnNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunTransportConfigurationProvider))
                {
                    return new global::Vapi.JsonConverters.SimulationRunTransportConfigurationProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunTransportConfigurationProvider?))
                {
                    return new global::Vapi.JsonConverters.SimulationRunTransportConfigurationProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputEvaluationResultComparator))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputEvaluationResultComparatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputEvaluationResultComparator?))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputEvaluationResultComparatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunItemStatus))
                {
                    return new global::Vapi.JsonConverters.SimulationRunItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunItemStatus?))
                {
                    return new global::Vapi.JsonConverters.SimulationRunItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsStatus))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsStatus?))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortOrder?))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortBy))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationRunControllerFindItemsSortBy?))
                {
                    return new global::Vapi.JsonConverters.SimulationRunControllerFindItemsSortByNullableJsonConverter();
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
                    0 => new SimulationRunItemsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}