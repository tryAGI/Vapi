
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteTargetAssignment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType), TypeInfoPropertyName = "SimulationSuiteTargetAssignmentTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateSimulationSuiteDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationSuiteTargetAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuitesPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateSimulationSuiteDTO))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder), TypeInfoPropertyName = "SimulationSuiteControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy), TypeInfoPropertyName = "SimulationSuiteControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>, global::Vapi.SimulationSuitesPaginatedResponse>), TypeInfoPropertyName = "OneOfIListSimulationSuiteSimulationSuitesPaginatedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerRequirementsDraftResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>), TypeInfoPropertyName = "OneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteUpdateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType?), TypeInfoPropertyName = "NullableSimulationSuiteTargetAssignmentTargetType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingErrorDTOCode?), TypeInfoPropertyName = "NullableSimulationOnboardingErrorDTOCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingRequirementDTOTag?), TypeInfoPropertyName = "NullableSimulationOnboardingRequirementDTOTag2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason?), TypeInfoPropertyName = "NullableSimulationOnboardingCoverageGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationOnboardingToolGapDTOReason?), TypeInfoPropertyName = "NullableSimulationOnboardingToolGapDTOReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder?), TypeInfoPropertyName = "NullableSimulationSuiteControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy?), TypeInfoPropertyName = "NullableSimulationSuiteControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>, global::Vapi.SimulationSuitesPaginatedResponse>?), TypeInfoPropertyName = "NullableOneOfIListSimulationSuiteSimulationSuitesPaginatedResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerRequirementsDraftResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerRequirementsDraftResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteCreateResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteCreateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.SimulationOnboardingErrorDTO, global::Vapi.SimulationOnboardingControllerSuiteUpdateResponse2>?), TypeInfoPropertyName = "NullableOneOfSimulationOnboardingErrorDTOSimulationOnboardingControllerSuiteUpdateResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationSuiteTargetAssignment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationSuite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingRequirementDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingOpenQuestionDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingCoverageGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingSuiteSimulationDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingToolGapDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.SimulationOnboardingSuiteEditDTO>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::System.Collections.Generic.List<global::Vapi.SimulationSuite>, global::Vapi.SimulationSuitesPaginatedResponse>))]
    internal sealed partial class SimulationSuitesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SimulationSuitesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SimulationSuitesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SimulationSuitesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::System.Collections.Generic.IList<global::Vapi.SimulationSuite>, global::Vapi.SimulationSuitesPaginatedResponse>());
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
                    typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingErrorDTOCode?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingRequirementDTOTag?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingCoverageGapDTOReason?)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason)

                    || typeToConvert == typeof(global::Vapi.SimulationOnboardingToolGapDTOReason?)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder?)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy)

                    || typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy?);
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

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteTargetAssignmentTargetTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteTargetAssignmentTargetType?))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteTargetAssignmentTargetTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteControllerFindAllSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortOrder?))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteControllerFindAllSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteControllerFindAllSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.SimulationSuiteControllerFindAllSortBy?))
                {
                    return new global::Vapi.JsonConverters.SimulationSuiteControllerFindAllSortByNullableJsonConverter();
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
                    0 => new SimulationSuitesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}