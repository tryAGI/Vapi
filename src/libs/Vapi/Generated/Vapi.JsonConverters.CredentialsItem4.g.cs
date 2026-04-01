#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class CredentialsItem4JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CredentialsItem4>
    {
        /// <inheritdoc />
        public override global::Vapi.CredentialsItem4 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.AssistantCredentialDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.AssistantCredentialDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.AssistantCredentialDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Vapi.CreateAnthropicCredentialDTO? anthropic = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Anthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnthropicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnthropicCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAnthropicCredentialDTO)}");
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateAnthropicBedrockCredentialDTO? anthropicBedrock = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.AnthropicBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnthropicBedrockCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAnthropicBedrockCredentialDTO)}");
                anthropicBedrock = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateAnyscaleCredentialDTO? anyscale = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Anyscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnyscaleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnyscaleCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAnyscaleCredentialDTO)}");
                anyscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateAssemblyAICredentialDTO? assemblyAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.AssemblyAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAssemblyAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAssemblyAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAssemblyAICredentialDTO)}");
                assemblyAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateAzureCredentialDTO? azure = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Azure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAzureCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAzureCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAzureCredentialDTO)}");
                azure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateAzureOpenAICredentialDTO? azureOpenai = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.AzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAzureOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAzureOpenAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateAzureOpenAICredentialDTO)}");
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateByoSipTrunkCredentialDTO? byoSipTrunk = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.ByoSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateByoSipTrunkCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateByoSipTrunkCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateByoSipTrunkCredentialDTO)}");
                byoSipTrunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCartesiaCredentialDTO? cartesia = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Cartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCartesiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCartesiaCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCartesiaCredentialDTO)}");
                cartesia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCerebrasCredentialDTO? cerebras = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Cerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCerebrasCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCerebrasCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCerebrasCredentialDTO)}");
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCloudflareCredentialDTO? cloudflare = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Cloudflare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCloudflareCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCloudflareCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCloudflareCredentialDTO)}");
                cloudflare = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCustomLLMCredentialDTO? customLlm = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.CustomLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCustomLLMCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCustomLLMCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCustomLLMCredentialDTO)}");
                customLlm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateDeepgramCredentialDTO? deepgram = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Deepgram)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepgramCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepgramCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateDeepgramCredentialDTO)}");
                deepgram = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateDeepInfraCredentialDTO? deepinfra = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Deepinfra)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepInfraCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepInfraCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateDeepInfraCredentialDTO)}");
                deepinfra = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateDeepSeekCredentialDTO? deepSeek = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.DeepSeek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepSeekCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepSeekCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateDeepSeekCredentialDTO)}");
                deepSeek = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateElevenLabsCredentialDTO? elevenlabs = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Elevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateElevenLabsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateElevenLabsCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateElevenLabsCredentialDTO)}");
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGcpCredentialDTO? gcp = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Gcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGcpCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGcpCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGcpCredentialDTO)}");
                gcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGladiaCredentialDTO? gladia = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Gladia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGladiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGladiaCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGladiaCredentialDTO)}");
                gladia = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelCredentialDTO? gohighlevel = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Gohighlevel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelCredentialDTO)}");
                gohighlevel = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleCredentialDTO? google = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Google)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleCredentialDTO)}");
                google = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGroqCredentialDTO? groq = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Groq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGroqCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGroqCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGroqCredentialDTO)}");
                groq = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateHumeCredentialDTO? hume = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Hume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateHumeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateHumeCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateHumeCredentialDTO)}");
                hume = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateInflectionAICredentialDTO? inflectionAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.InflectionAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateInflectionAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateInflectionAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateInflectionAICredentialDTO)}");
                inflectionAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateLangfuseCredentialDTO? langfuse = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Langfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLangfuseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLangfuseCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateLangfuseCredentialDTO)}");
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateLmntCredentialDTO? lmnt = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Lmnt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLmntCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLmntCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateLmntCredentialDTO)}");
                lmnt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateMakeCredentialDTO? make = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Make)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMakeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMakeCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateMakeCredentialDTO)}");
                make = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateMistralCredentialDTO? mistral = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Mistral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMistralCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMistralCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateMistralCredentialDTO)}");
                mistral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateNeuphonicCredentialDTO? neuphonic = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Neuphonic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateNeuphonicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateNeuphonicCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateNeuphonicCredentialDTO)}");
                neuphonic = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateOpenAICredentialDTO? openai = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Openai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateOpenAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateOpenAICredentialDTO)}");
                openai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateOpenRouterCredentialDTO? openrouter = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Openrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateOpenRouterCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateOpenRouterCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateOpenRouterCredentialDTO)}");
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreatePerplexityAICredentialDTO? perplexityAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.PerplexityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePerplexityAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePerplexityAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreatePerplexityAICredentialDTO)}");
                perplexityAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreatePlayHTCredentialDTO? playht = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Playht)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePlayHTCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePlayHTCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreatePlayHTCredentialDTO)}");
                playht = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateRimeAICredentialDTO? rimeAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.RimeAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateRimeAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateRimeAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateRimeAICredentialDTO)}");
                rimeAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateRunpodCredentialDTO? runpod = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Runpod)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateRunpodCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateRunpodCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateRunpodCredentialDTO)}");
                runpod = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateS3CredentialDTO? s3 = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.S3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateS3CredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateS3CredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateS3CredentialDTO)}");
                s3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSmallestAICredentialDTO? smallestAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.SmallestAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSmallestAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSmallestAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSmallestAICredentialDTO)}");
                smallestAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSpeechmaticsCredentialDTO? speechmatics = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Speechmatics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSpeechmaticsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSpeechmaticsCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSpeechmaticsCredentialDTO)}");
                speechmatics = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSonioxCredentialDTO? soniox = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Soniox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSonioxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSonioxCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSonioxCredentialDTO)}");
                soniox = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSupabaseCredentialDTO? supabase = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Supabase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSupabaseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSupabaseCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSupabaseCredentialDTO)}");
                supabase = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTavusCredentialDTO? tavus = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Tavus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTavusCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTavusCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTavusCredentialDTO)}");
                tavus = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTogetherAICredentialDTO? togetherAi = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.TogetherAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTogetherAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTogetherAICredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTogetherAICredentialDTO)}");
                togetherAi = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTrieveCredentialDTO? trieve = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Trieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTrieveCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTrieveCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTrieveCredentialDTO)}");
                trieve = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateTwilioCredentialDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Twilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTwilioCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTwilioCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateTwilioCredentialDTO)}");
                twilio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateVonageCredentialDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Vonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVonageCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVonageCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateVonageCredentialDTO)}");
                vonage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateWebhookCredentialDTO? webhook = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateWebhookCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateWebhookCredentialDTO)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateCustomCredentialDTO? customCredential = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.CustomCredential)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCustomCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCustomCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateCustomCredentialDTO)}");
                customCredential = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateXAiCredentialDTO? xai = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Xai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateXAiCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateXAiCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateXAiCredentialDTO)}");
                xai = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO)}");
                googleCalendarOauth2Client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO)}");
                googleCalendarOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO)}");
                googleSheetsOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.SlackOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO)}");
                slackOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.GhlOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelMCPCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateGoHighLevelMCPCredentialDTO)}");
                ghlOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateInworldCredentialDTO? inworld = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Inworld)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateInworldCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateInworldCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateInworldCredentialDTO)}");
                inworld = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateMinimaxCredentialDTO? minimax = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Minimax)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMinimaxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMinimaxCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateMinimaxCredentialDTO)}");
                minimax = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateWellSaidCredentialDTO? wellsaid = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Wellsaid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateWellSaidCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateWellSaidCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateWellSaidCredentialDTO)}");
                wellsaid = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateEmailCredentialDTO? email = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.Email)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateEmailCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateEmailCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateEmailCredentialDTO)}");
                email = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Vapi.CreateSlackWebhookCredentialDTO? slackWebhook = default;
            if (discriminator?.Provider == global::Vapi.AssistantCredentialDiscriminatorProvider.SlackWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackWebhookCredentialDTO> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Vapi.CreateSlackWebhookCredentialDTO)}");
                slackWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Vapi.CredentialsItem4(
                discriminator?.Provider,
                anthropic,

                anthropicBedrock,

                anyscale,

                assemblyAi,

                azure,

                azureOpenai,

                byoSipTrunk,

                cartesia,

                cerebras,

                cloudflare,

                customLlm,

                deepgram,

                deepinfra,

                deepSeek,

                elevenlabs,

                gcp,

                gladia,

                gohighlevel,

                google,

                groq,

                hume,

                inflectionAi,

                langfuse,

                lmnt,

                make,

                mistral,

                neuphonic,

                openai,

                openrouter,

                perplexityAi,

                playht,

                rimeAi,

                runpod,

                s3,

                smallestAi,

                speechmatics,

                soniox,

                supabase,

                tavus,

                togetherAi,

                trieve,

                twilio,

                vonage,

                webhook,

                customCredential,

                xai,

                googleCalendarOauth2Client,

                googleCalendarOauth2Authorization,

                googleSheetsOauth2Authorization,

                slackOauth2Authorization,

                ghlOauth2Authorization,

                inworld,

                minimax,

                wellsaid,

                email,

                slackWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Vapi.CredentialsItem4 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAnthropic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnthropicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnthropicCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAnthropicCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic!, typeInfo);
            }
            else if (value.IsAnthropicBedrock)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnthropicBedrockCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicBedrock!, typeInfo);
            }
            else if (value.IsAnyscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAnyscaleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAnyscaleCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAnyscaleCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anyscale!, typeInfo);
            }
            else if (value.IsAssemblyAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAssemblyAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAssemblyAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAssemblyAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssemblyAi!, typeInfo);
            }
            else if (value.IsAzure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAzureCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAzureCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAzureCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure!, typeInfo);
            }
            else if (value.IsAzureOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateAzureOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateAzureOpenAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateAzureOpenAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai!, typeInfo);
            }
            else if (value.IsByoSipTrunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateByoSipTrunkCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateByoSipTrunkCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateByoSipTrunkCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoSipTrunk!, typeInfo);
            }
            else if (value.IsCartesia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCartesiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCartesiaCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCartesiaCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cartesia!, typeInfo);
            }
            else if (value.IsCerebras)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCerebrasCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCerebrasCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCerebrasCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras!, typeInfo);
            }
            else if (value.IsCloudflare)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCloudflareCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCloudflareCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCloudflareCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cloudflare!, typeInfo);
            }
            else if (value.IsCustomLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCustomLLMCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCustomLLMCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCustomLLMCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomLlm!, typeInfo);
            }
            else if (value.IsDeepgram)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepgramCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepgramCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateDeepgramCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepgram!, typeInfo);
            }
            else if (value.IsDeepinfra)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepInfraCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepInfraCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateDeepInfraCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepinfra!, typeInfo);
            }
            else if (value.IsDeepSeek)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateDeepSeekCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateDeepSeekCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateDeepSeekCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeepSeek!, typeInfo);
            }
            else if (value.IsElevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateElevenLabsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateElevenLabsCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateElevenLabsCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs!, typeInfo);
            }
            else if (value.IsGcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGcpCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGcpCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGcpCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp!, typeInfo);
            }
            else if (value.IsGladia)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGladiaCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGladiaCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGladiaCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gladia!, typeInfo);
            }
            else if (value.IsGohighlevel)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gohighlevel!, typeInfo);
            }
            else if (value.IsGoogle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google!, typeInfo);
            }
            else if (value.IsGroq)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGroqCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGroqCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGroqCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq!, typeInfo);
            }
            else if (value.IsHume)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateHumeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateHumeCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateHumeCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hume!, typeInfo);
            }
            else if (value.IsInflectionAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateInflectionAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateInflectionAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateInflectionAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InflectionAi!, typeInfo);
            }
            else if (value.IsLangfuse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLangfuseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLangfuseCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateLangfuseCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse!, typeInfo);
            }
            else if (value.IsLmnt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateLmntCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateLmntCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateLmntCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lmnt!, typeInfo);
            }
            else if (value.IsMake)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMakeCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMakeCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateMakeCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Make!, typeInfo);
            }
            else if (value.IsMistral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMistralCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMistralCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateMistralCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mistral!, typeInfo);
            }
            else if (value.IsNeuphonic)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateNeuphonicCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateNeuphonicCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateNeuphonicCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Neuphonic!, typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateOpenAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateOpenAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateOpenAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsOpenrouter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateOpenRouterCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateOpenRouterCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateOpenRouterCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter!, typeInfo);
            }
            else if (value.IsPerplexityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePerplexityAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePerplexityAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreatePerplexityAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PerplexityAi!, typeInfo);
            }
            else if (value.IsPlayht)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreatePlayHTCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreatePlayHTCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreatePlayHTCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playht!, typeInfo);
            }
            else if (value.IsRimeAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateRimeAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateRimeAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateRimeAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RimeAi!, typeInfo);
            }
            else if (value.IsRunpod)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateRunpodCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateRunpodCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateRunpodCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Runpod!, typeInfo);
            }
            else if (value.IsS3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateS3CredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateS3CredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateS3CredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3!, typeInfo);
            }
            else if (value.IsSmallestAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSmallestAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSmallestAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSmallestAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmallestAi!, typeInfo);
            }
            else if (value.IsSpeechmatics)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSpeechmaticsCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSpeechmaticsCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSpeechmaticsCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Speechmatics!, typeInfo);
            }
            else if (value.IsSoniox)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSonioxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSonioxCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSonioxCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Soniox!, typeInfo);
            }
            else if (value.IsSupabase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSupabaseCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSupabaseCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSupabaseCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supabase!, typeInfo);
            }
            else if (value.IsTavus)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTavusCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTavusCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTavusCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tavus!, typeInfo);
            }
            else if (value.IsTogetherAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTogetherAICredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTogetherAICredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTogetherAICredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TogetherAi!, typeInfo);
            }
            else if (value.IsTrieve)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTrieveCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTrieveCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTrieveCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trieve!, typeInfo);
            }
            else if (value.IsTwilio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateTwilioCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateTwilioCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateTwilioCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio!, typeInfo);
            }
            else if (value.IsVonage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateVonageCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateVonageCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateVonageCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage!, typeInfo);
            }
            else if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateWebhookCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateWebhookCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsCustomCredential)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateCustomCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateCustomCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateCustomCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomCredential!, typeInfo);
            }
            else if (value.IsXai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateXAiCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateXAiCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateXAiCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai!, typeInfo);
            }
            else if (value.IsGoogleCalendarOauth2Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Client!, typeInfo);
            }
            else if (value.IsGoogleCalendarOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Authorization!, typeInfo);
            }
            else if (value.IsGoogleSheetsOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsOauth2Authorization!, typeInfo);
            }
            else if (value.IsSlackOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackOauth2Authorization!, typeInfo);
            }
            else if (value.IsGhlOauth2Authorization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateGoHighLevelMCPCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GhlOauth2Authorization!, typeInfo);
            }
            else if (value.IsInworld)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateInworldCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateInworldCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateInworldCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inworld!, typeInfo);
            }
            else if (value.IsMinimax)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateMinimaxCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateMinimaxCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateMinimaxCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Minimax!, typeInfo);
            }
            else if (value.IsWellsaid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateWellSaidCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateWellSaidCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateWellSaidCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wellsaid!, typeInfo);
            }
            else if (value.IsEmail)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateEmailCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateEmailCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateEmailCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email!, typeInfo);
            }
            else if (value.IsSlackWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Vapi.CreateSlackWebhookCredentialDTO), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Vapi.CreateSlackWebhookCredentialDTO?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Vapi.CreateSlackWebhookCredentialDTO).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackWebhook!, typeInfo);
            }
        }
    }
}