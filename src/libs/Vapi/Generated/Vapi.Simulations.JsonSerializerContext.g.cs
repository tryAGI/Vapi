
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenario))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenarioCategory), TypeInfoPropertyName = "GeneratedScenarioCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GenerateScenariosResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.GeneratedScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingErrorDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingErrorDTOCode), TypeInfoPropertyName = "SimulationOnboardingErrorDTOCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementDTOTag), TypeInfoPropertyName = "SimulationOnboardingRequirementDTOTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingOpenQuestionDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementsDraftDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingRequirementDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingOpenQuestionDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementsCreateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteCreateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteRefDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingCoverageGapDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason), TypeInfoPropertyName = "SimulationOnboardingCoverageGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteCoverageDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingCoverageGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteDocsDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingToolGapDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingToolGapDTOReason), TypeInfoPropertyName = "SimulationOnboardingToolGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteViewDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteSimulationDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingToolGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteEditDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingSuiteUpdateDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationOnboardingSuiteEditDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.Simulation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationConcurrencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationControllerFindAllSortOrder), TypeInfoPropertyName = "SimulationControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationControllerFindAllSortBy), TypeInfoPropertyName = "SimulationControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerRequirementsDraftResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteUpdateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.Simulation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GeneratedScenarioCategory?), TypeInfoPropertyName = "NullableGeneratedScenarioCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingErrorDTOCode?), TypeInfoPropertyName = "NullableSimulationOnboardingErrorDTOCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementDTOTag?), TypeInfoPropertyName = "NullableSimulationOnboardingRequirementDTOTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason?), TypeInfoPropertyName = "NullableSimulationOnboardingCoverageGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingToolGapDTOReason?), TypeInfoPropertyName = "NullableSimulationOnboardingToolGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationControllerFindAllSortOrder?), TypeInfoPropertyName = "NullableSimulationControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationControllerFindAllSortBy?), TypeInfoPropertyName = "NullableSimulationControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerRequirementsDraftResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteUpdateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.GeneratedScenario>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingRequirementDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingOpenQuestionDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingCoverageGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingSuiteSimulationDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingToolGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingSuiteEditDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.Simulation>))]
    internal sealed partial class SimulationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SimulationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SimulationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>());
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
                    typeToConvert == typeof(global::Vapi.GeneratedScenarioCategory)

                    || typeToConvert == typeof(global::Vapi.GeneratedScenarioCategory?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason?)

                    || typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortOrder)

                    || typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortOrder?)

                    || typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortBy)

                    || typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortBy?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Vapi.GeneratedScenarioCategory))
                {
                    return new global::Vapi.JsonConverters.GeneratedScenarioCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GeneratedScenarioCategory?))
                {
                    return new global::Vapi.JsonConverters.GeneratedScenarioCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingErrorDTOCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode?))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingErrorDTOCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingRequirementDTOTagJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag?))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingRequirementDTOTagNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingCoverageGapDTOReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason?))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingCoverageGapDTOReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingToolGapDTOReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason?))
                {
                    return new global::Vapi.JsonConverters.SimulationOnboardingToolGapDTOReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortOrder))
                {
                    return new global::Vapi.JsonConverters.SimulationControllerFindAllSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortOrder?))
                {
                    return new global::Vapi.JsonConverters.SimulationControllerFindAllSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortBy))
                {
                    return new global::Vapi.JsonConverters.SimulationControllerFindAllSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationControllerFindAllSortBy?))
                {
                    return new global::Vapi.JsonConverters.SimulationControllerFindAllSortByNullableJsonConverter();
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
                    0 => new SimulationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}