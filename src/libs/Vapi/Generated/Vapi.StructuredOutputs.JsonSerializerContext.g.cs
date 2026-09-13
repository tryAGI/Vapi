
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>?), TypeInfoPropertyName = "WorkflowCustomModel_4fcb5a07f61b51b5")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType), TypeInfoPropertyName = "JsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vapi.JsonSchema>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat), TypeInfoPropertyName = "JsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, double?, bool?, object, byte[]>), TypeInfoPropertyName = "OneOfStringDoubleBooleanObjectByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole), TypeInfoPropertyName = "OpenAIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType), TypeInfoPropertyName = "AnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider), TypeInfoPropertyName = "WorkflowOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel), TypeInfoPropertyName = "WorkflowOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider), TypeInfoPropertyName = "WorkflowAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel), TypeInfoPropertyName = "WorkflowAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel), TypeInfoPropertyName = "WorkflowAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider), TypeInfoPropertyName = "WorkflowGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel), TypeInfoPropertyName = "WorkflowGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider), TypeInfoPropertyName = "WorkflowCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode), TypeInfoPropertyName = "WorkflowCustomModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>), TypeInfoPropertyName = "OneOfWorkflowOpenAIModelWorkflowAnthropicModelWorkflowAnthropicBedrockModelWorkflowGoogleModelWorkflowCustomModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesConditionType), TypeInfoPropertyName = "MinMessagesConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationConditionType), TypeInfoPropertyName = "MinCallDurationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonCondition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionType), TypeInfoPropertyName = "EndedReasonConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionOperator), TypeInfoPropertyName = "EndedReasonConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.ComplianceOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType), TypeInfoPropertyName = "CreateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>), TypeInfoPropertyName = "OneOfMinMessagesConditionMinCallDurationConditionEndedReasonCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder), TypeInfoPropertyName = "PaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.SkippedStructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Vapi.SkippedStructuredOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRunPreviewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRerunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputType), TypeInfoPropertyName = "StructuredOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputPaginatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Vapi.StructuredOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTOType), TypeInfoPropertyName = "UpdateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputRunDTO))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder), TypeInfoPropertyName = "StructuredOutputControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortBy), TypeInfoPropertyName = "StructuredOutputControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>), TypeInfoPropertyName = "OneOfAllOfStructuredOutputRunPreviewResponseObjectStructuredOutputRerunResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>), TypeInfoPropertyName = "AllOfStructuredOutputRunPreviewResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaType?), TypeInfoPropertyName = "NullableJsonSchemaType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.JsonSchemaFormat?), TypeInfoPropertyName = "NullableJsonSchemaFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<string, double?, bool?, object, byte[]>?), TypeInfoPropertyName = "NullableOneOfStringDoubleBooleanObjectByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OpenAIMessageRole?), TypeInfoPropertyName = "NullableOpenAIMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AnthropicThinkingConfigType?), TypeInfoPropertyName = "NullableAnthropicThinkingConfigType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelProvider?), TypeInfoPropertyName = "NullableWorkflowOpenAIModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowOpenAIModelModel?), TypeInfoPropertyName = "NullableWorkflowOpenAIModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelProvider?), TypeInfoPropertyName = "NullableWorkflowAnthropicModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicModelModel?), TypeInfoPropertyName = "NullableWorkflowAnthropicModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?), TypeInfoPropertyName = "NullableWorkflowAnthropicBedrockModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?), TypeInfoPropertyName = "NullableWorkflowAnthropicBedrockModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelProvider?), TypeInfoPropertyName = "NullableWorkflowGoogleModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowGoogleModelModel?), TypeInfoPropertyName = "NullableWorkflowGoogleModelModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelProvider?), TypeInfoPropertyName = "NullableWorkflowCustomModelProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?), TypeInfoPropertyName = "NullableWorkflowCustomModelMetadataSendMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinMessagesConditionType?), TypeInfoPropertyName = "NullableMinMessagesConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.MinCallDurationConditionType?), TypeInfoPropertyName = "NullableMinCallDurationConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionType?), TypeInfoPropertyName = "NullableEndedReasonConditionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.EndedReasonConditionOperator?), TypeInfoPropertyName = "NullableEndedReasonConditionOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.CreateStructuredOutputDTOType?), TypeInfoPropertyName = "NullableCreateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>?), TypeInfoPropertyName = "NullableOneOfMinMessagesConditionMinCallDurationConditionEndedReasonCondition2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.PaginationMetaSortOrder?), TypeInfoPropertyName = "NullablePaginationMetaSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputType?), TypeInfoPropertyName = "NullableStructuredOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.UpdateStructuredOutputDTOType?), TypeInfoPropertyName = "NullableUpdateStructuredOutputDTOType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder?), TypeInfoPropertyName = "NullableStructuredOutputControllerFindAllSortOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.StructuredOutputControllerFindAllSortBy?), TypeInfoPropertyName = "NullableStructuredOutputControllerFindAllSortBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.OneOf<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>?), TypeInfoPropertyName = "NullableOneOfAllOfStructuredOutputRunPreviewResponseObjectStructuredOutputRerunResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?), TypeInfoPropertyName = "NullableAllOfStructuredOutputRunPreviewResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OpenAIMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.OneOf<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Vapi.StructuredOutput>))]
    internal sealed partial class StructuredOutputsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class StructuredOutputsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static StructuredOutputsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private StructuredOutputsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, global::Vapi.JsonSchema>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?, bool?, object, byte[]>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.WorkflowOpenAIModel, global::Vapi.WorkflowAnthropicModel, global::Vapi.WorkflowAnthropicBedrockModel, global::Vapi.WorkflowGoogleModel, global::Vapi.WorkflowCustomModel>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.MinMessagesCondition, global::Vapi.MinCallDurationCondition, global::Vapi.EndedReasonCondition>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?, object>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<double?, string, bool?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<string, double?>());
            options.Converters.Add(new global::Vapi.JsonConverters.OneOfJsonConverter<global::Vapi.AllOf<global::Vapi.StructuredOutputRunPreviewResponse, object>?, global::Vapi.StructuredOutputRerunResponse>());
            options.Converters.Add(new global::Vapi.JsonConverters.AllOfJsonConverter<global::Vapi.StructuredOutputRunPreviewResponse, object>());
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

                    || typeToConvert == typeof(global::Vapi.OpenAIMessageRole)

                    || typeToConvert == typeof(global::Vapi.OpenAIMessageRole?)

                    || typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType)

                    || typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType?)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel)

                    || typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel?)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider?)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode)

                    || typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?)

                    || typeToConvert == typeof(global::Vapi.MinMessagesConditionType)

                    || typeToConvert == typeof(global::Vapi.MinMessagesConditionType?)

                    || typeToConvert == typeof(global::Vapi.MinCallDurationConditionType)

                    || typeToConvert == typeof(global::Vapi.MinCallDurationConditionType?)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionType)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionType?)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator)

                    || typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator?)

                    || typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType)

                    || typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType?)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder)

                    || typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputType)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputType?)

                    || typeToConvert == typeof(global::Vapi.UpdateStructuredOutputDTOType)

                    || typeToConvert == typeof(global::Vapi.UpdateStructuredOutputDTOType?)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder?)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortBy)

                    || typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortBy?);
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

                if (typeToConvert == typeof(global::Vapi.OpenAIMessageRole))
                {
                    return new global::Vapi.JsonConverters.OpenAIMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.OpenAIMessageRole?))
                {
                    return new global::Vapi.JsonConverters.OpenAIMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType))
                {
                    return new global::Vapi.JsonConverters.AnthropicThinkingConfigTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.AnthropicThinkingConfigType?))
                {
                    return new global::Vapi.JsonConverters.AnthropicThinkingConfigTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowOpenAIModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowOpenAIModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowAnthropicBedrockModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowAnthropicBedrockModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowGoogleModelModel?))
                {
                    return new global::Vapi.JsonConverters.WorkflowGoogleModelModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelProvider?))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.WorkflowCustomModelMetadataSendMode?))
                {
                    return new global::Vapi.JsonConverters.WorkflowCustomModelMetadataSendModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinMessagesConditionType))
                {
                    return new global::Vapi.JsonConverters.MinMessagesConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinMessagesConditionType?))
                {
                    return new global::Vapi.JsonConverters.MinMessagesConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinCallDurationConditionType))
                {
                    return new global::Vapi.JsonConverters.MinCallDurationConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.MinCallDurationConditionType?))
                {
                    return new global::Vapi.JsonConverters.MinCallDurationConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionType))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionType?))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.EndedReasonConditionOperator?))
                {
                    return new global::Vapi.JsonConverters.EndedReasonConditionOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType))
                {
                    return new global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.CreateStructuredOutputDTOType?))
                {
                    return new global::Vapi.JsonConverters.CreateStructuredOutputDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.PaginationMetaSortOrder?))
                {
                    return new global::Vapi.JsonConverters.PaginationMetaSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputType))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputType?))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateStructuredOutputDTOType))
                {
                    return new global::Vapi.JsonConverters.UpdateStructuredOutputDTOTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.UpdateStructuredOutputDTOType?))
                {
                    return new global::Vapi.JsonConverters.UpdateStructuredOutputDTOTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortOrder?))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortOrderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortBy))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortByJsonConverter();
                }

                if (typeToConvert == typeof(global::Vapi.StructuredOutputControllerFindAllSortBy?))
                {
                    return new global::Vapi.JsonConverters.StructuredOutputControllerFindAllSortByNullableJsonConverter();
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
                    0 => new StructuredOutputsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}