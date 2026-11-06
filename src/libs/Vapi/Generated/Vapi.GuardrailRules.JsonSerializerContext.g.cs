
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailFixedResponseAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailFixedResponseActionType), TypeInfoPropertyName = "GuardrailFixedResponseActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailFixedResponseActionMode), TypeInfoPropertyName = "GuardrailFixedResponseActionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRedirectAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRedirectActionType), TypeInfoPropertyName = "GuardrailRedirectActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRedirectActionMode), TypeInfoPropertyName = "GuardrailRedirectActionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailEscalateAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailEscalateActionType), TypeInfoPropertyName = "GuardrailEscalateActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailAuthoring))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailAuthoringMode), TypeInfoPropertyName = "GuardrailAuthoringMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRule))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRuleSensitivity), TypeInfoPropertyName = "GuardrailRuleSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>), TypeInfoPropertyName = "OneOfOneOfGuardrailFixedResponseActionGuardrailRedirectActionGuardrailEscalateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>), TypeInfoPropertyName = "OneOfGuardrailFixedResponseActionGuardrailRedirectAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRulesPage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.GuardrailRule>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy), TypeInfoPropertyName = "GuardrailRulesControllerPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder), TypeInfoPropertyName = "GuardrailRulesControllerPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailFixedResponseActionType?), TypeInfoPropertyName = "NullableGuardrailFixedResponseActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailFixedResponseActionMode?), TypeInfoPropertyName = "NullableGuardrailFixedResponseActionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRedirectActionType?), TypeInfoPropertyName = "NullableGuardrailRedirectActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRedirectActionMode?), TypeInfoPropertyName = "NullableGuardrailRedirectActionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailEscalateActionType?), TypeInfoPropertyName = "NullableGuardrailEscalateActionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailAuthoringMode?), TypeInfoPropertyName = "NullableGuardrailAuthoringMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRuleSensitivity?), TypeInfoPropertyName = "NullableGuardrailRuleSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>?), TypeInfoPropertyName = "NullableOneOfOneOfGuardrailFixedResponseActionGuardrailRedirectActionGuardrailEscalateAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?), TypeInfoPropertyName = "NullableOneOfGuardrailFixedResponseActionGuardrailRedirectAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy?), TypeInfoPropertyName = "NullableGuardrailRulesControllerPaginatedSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder?), TypeInfoPropertyName = "NullableGuardrailRulesControllerPaginatedSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.GuardrailRule>))]
    internal sealed partial class GuardrailRulesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailRulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GuardrailRulesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GuardrailRulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.OneOf<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>?, global::Vapi.GuardrailEscalateAction>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.GuardrailFixedResponseAction, global::Vapi.GuardrailRedirectAction>());
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

                    || typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionType)

                    || typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionType?)

                    || typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionMode)

                    || typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionMode?)

                    || typeToConvert == typeof(global::Vapi.GuardrailRedirectActionType)

                    || typeToConvert == typeof(global::Vapi.GuardrailRedirectActionType?)

                    || typeToConvert == typeof(global::Vapi.GuardrailRedirectActionMode)

                    || typeToConvert == typeof(global::Vapi.GuardrailRedirectActionMode?)

                    || typeToConvert == typeof(global::Vapi.GuardrailEscalateActionType)

                    || typeToConvert == typeof(global::Vapi.GuardrailEscalateActionType?)

                    || typeToConvert == typeof(global::Vapi.GuardrailAuthoringMode)

                    || typeToConvert == typeof(global::Vapi.GuardrailAuthoringMode?)

                    || typeToConvert == typeof(global::Vapi.GuardrailRuleSensitivity)

                    || typeToConvert == typeof(global::Vapi.GuardrailRuleSensitivity?)

                    || typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy)

                    || typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy?)

                    || typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder)

                    || typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder?);
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

                if (typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionType))
                {
                    return new global::Vapi.JsonConverters.GuardrailFixedResponseActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionType?))
                {
                    return new global::Vapi.JsonConverters.GuardrailFixedResponseActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionMode))
                {
                    return new global::Vapi.JsonConverters.GuardrailFixedResponseActionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailFixedResponseActionMode?))
                {
                    return new global::Vapi.JsonConverters.GuardrailFixedResponseActionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRedirectActionType))
                {
                    return new global::Vapi.JsonConverters.GuardrailRedirectActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRedirectActionType?))
                {
                    return new global::Vapi.JsonConverters.GuardrailRedirectActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRedirectActionMode))
                {
                    return new global::Vapi.JsonConverters.GuardrailRedirectActionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRedirectActionMode?))
                {
                    return new global::Vapi.JsonConverters.GuardrailRedirectActionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailEscalateActionType))
                {
                    return new global::Vapi.JsonConverters.GuardrailEscalateActionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailEscalateActionType?))
                {
                    return new global::Vapi.JsonConverters.GuardrailEscalateActionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailAuthoringMode))
                {
                    return new global::Vapi.JsonConverters.GuardrailAuthoringModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailAuthoringMode?))
                {
                    return new global::Vapi.JsonConverters.GuardrailAuthoringModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRuleSensitivity))
                {
                    return new global::Vapi.JsonConverters.GuardrailRuleSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRuleSensitivity?))
                {
                    return new global::Vapi.JsonConverters.GuardrailRuleSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy))
                {
                    return new global::Vapi.JsonConverters.GuardrailRulesControllerPaginatedSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortBy?))
                {
                    return new global::Vapi.JsonConverters.GuardrailRulesControllerPaginatedSortByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder))
                {
                    return new global::Vapi.JsonConverters.GuardrailRulesControllerPaginatedSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.GuardrailRulesControllerPaginatedSortOrder?))
                {
                    return new global::Vapi.JsonConverters.GuardrailRulesControllerPaginatedSortOrderNullableJsonConverter();
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
                    0 => new GuardrailRulesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}