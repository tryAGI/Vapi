#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Vapi.JsonConverters
{
    /// <inheritdoc />
    public class CredentialsItem8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Vapi.CredentialsItem8>
    {
        /// <inheritdoc />
        public override global::Vapi.CredentialsItem8 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.UpdateWorkflowDTOCredentialDiscriminator>(ref readerCopy, options);

            global::Vapi.CreateAnthropicCredentialDTO? anthropic = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Anthropic)
            {
                anthropic = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAnthropicCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateAnthropicBedrockCredentialDTO? anthropicBedrock = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.AnthropicBedrock)
            {
                anthropicBedrock = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAnthropicBedrockCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateAnyscaleCredentialDTO? anyscale = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Anyscale)
            {
                anyscale = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAnyscaleCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateAssemblyAICredentialDTO? assemblyAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.AssemblyAi)
            {
                assemblyAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAssemblyAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateAzureCredentialDTO? azure = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Azure)
            {
                azure = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAzureCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateAzureOpenAICredentialDTO? azureOpenai = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.AzureOpenai)
            {
                azureOpenai = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateAzureOpenAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateByoSipTrunkCredentialDTO? byoSipTrunk = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.ByoSipTrunk)
            {
                byoSipTrunk = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateByoSipTrunkCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateCartesiaCredentialDTO? cartesia = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Cartesia)
            {
                cartesia = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCartesiaCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateCerebrasCredentialDTO? cerebras = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Cerebras)
            {
                cerebras = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCerebrasCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateCloudflareCredentialDTO? cloudflare = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Cloudflare)
            {
                cloudflare = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCloudflareCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateCustomLLMCredentialDTO? customLlm = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomLlm)
            {
                customLlm = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCustomLLMCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateDeepgramCredentialDTO? deepgram = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepgram)
            {
                deepgram = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateDeepgramCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateDeepInfraCredentialDTO? deepinfra = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Deepinfra)
            {
                deepinfra = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateDeepInfraCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateDeepSeekCredentialDTO? deepSeek = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.DeepSeek)
            {
                deepSeek = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateDeepSeekCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateElevenLabsCredentialDTO? elevenlabs = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Elevenlabs)
            {
                elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateElevenLabsCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGcpCredentialDTO? gcp = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Gcp)
            {
                gcp = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGcpCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGladiaCredentialDTO? gladia = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Gladia)
            {
                gladia = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGladiaCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelCredentialDTO? gohighlevel = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Gohighlevel)
            {
                gohighlevel = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleCredentialDTO? google = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Google)
            {
                google = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGroqCredentialDTO? groq = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Groq)
            {
                groq = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGroqCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateHumeCredentialDTO? hume = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Hume)
            {
                hume = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateHumeCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateInflectionAICredentialDTO? inflectionAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.InflectionAi)
            {
                inflectionAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateInflectionAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateLangfuseCredentialDTO? langfuse = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Langfuse)
            {
                langfuse = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateLangfuseCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateLmntCredentialDTO? lmnt = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Lmnt)
            {
                lmnt = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateLmntCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateMakeCredentialDTO? make = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Make)
            {
                make = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateMakeCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateMistralCredentialDTO? mistral = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Mistral)
            {
                mistral = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateMistralCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateNeuphonicCredentialDTO? neuphonic = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Neuphonic)
            {
                neuphonic = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateNeuphonicCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateOpenAICredentialDTO? openai = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Openai)
            {
                openai = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateOpenAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateOpenRouterCredentialDTO? openrouter = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Openrouter)
            {
                openrouter = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateOpenRouterCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreatePerplexityAICredentialDTO? perplexityAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.PerplexityAi)
            {
                perplexityAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreatePerplexityAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreatePlayHTCredentialDTO? playht = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Playht)
            {
                playht = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreatePlayHTCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateRimeAICredentialDTO? rimeAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.RimeAi)
            {
                rimeAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateRimeAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateRunpodCredentialDTO? runpod = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Runpod)
            {
                runpod = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateRunpodCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateS3CredentialDTO? s3 = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.S3)
            {
                s3 = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateS3CredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSmallestAICredentialDTO? smallestAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.SmallestAi)
            {
                smallestAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSmallestAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSpeechmaticsCredentialDTO? speechmatics = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Speechmatics)
            {
                speechmatics = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSpeechmaticsCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSonioxCredentialDTO? soniox = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Soniox)
            {
                soniox = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSonioxCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSupabaseCredentialDTO? supabase = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Supabase)
            {
                supabase = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSupabaseCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateTavusCredentialDTO? tavus = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Tavus)
            {
                tavus = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTavusCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateTogetherAICredentialDTO? togetherAi = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.TogetherAi)
            {
                togetherAi = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTogetherAICredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateTrieveCredentialDTO? trieve = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Trieve)
            {
                trieve = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTrieveCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateTwilioCredentialDTO? twilio = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Twilio)
            {
                twilio = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateTwilioCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateVonageCredentialDTO? vonage = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Vonage)
            {
                vonage = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateVonageCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateWebhookCredentialDTO? webhook = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateWebhookCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateCustomCredentialDTO? customCredential = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.CustomCredential)
            {
                customCredential = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateCustomCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateXAiCredentialDTO? xai = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Xai)
            {
                xai = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateXAiCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client)
            {
                googleCalendarOauth2Client = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization)
            {
                googleCalendarOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization)
            {
                googleSheetsOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackOauth2Authorization)
            {
                slackOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.GhlOauth2Authorization)
            {
                ghlOauth2Authorization = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateGoHighLevelMCPCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateInworldCredentialDTO? inworld = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Inworld)
            {
                inworld = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateInworldCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateMinimaxCredentialDTO? minimax = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Minimax)
            {
                minimax = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateMinimaxCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateWellSaidCredentialDTO? wellsaid = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Wellsaid)
            {
                wellsaid = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateWellSaidCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateEmailCredentialDTO? email = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.Email)
            {
                email = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateEmailCredentialDTO>(ref reader, options);
            }
            global::Vapi.CreateSlackWebhookCredentialDTO? slackWebhook = default;
            if (discriminator?.Provider == global::Vapi.UpdateWorkflowDTOCredentialDiscriminatorProvider.SlackWebhook)
            {
                slackWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::Vapi.CreateSlackWebhookCredentialDTO>(ref reader, options);
            }

            var __value = new global::Vapi.CredentialsItem8(
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
            global::Vapi.CredentialsItem8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAnthropic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anthropic, typeof(global::Vapi.CreateAnthropicCredentialDTO), options);
            }
            else if (value.IsAnthropicBedrock)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AnthropicBedrock, typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO), options);
            }
            else if (value.IsAnyscale)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anyscale, typeof(global::Vapi.CreateAnyscaleCredentialDTO), options);
            }
            else if (value.IsAssemblyAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssemblyAi, typeof(global::Vapi.CreateAssemblyAICredentialDTO), options);
            }
            else if (value.IsAzure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Azure, typeof(global::Vapi.CreateAzureCredentialDTO), options);
            }
            else if (value.IsAzureOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AzureOpenai, typeof(global::Vapi.CreateAzureOpenAICredentialDTO), options);
            }
            else if (value.IsByoSipTrunk)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ByoSipTrunk, typeof(global::Vapi.CreateByoSipTrunkCredentialDTO), options);
            }
            else if (value.IsCartesia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cartesia, typeof(global::Vapi.CreateCartesiaCredentialDTO), options);
            }
            else if (value.IsCerebras)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cerebras, typeof(global::Vapi.CreateCerebrasCredentialDTO), options);
            }
            else if (value.IsCloudflare)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cloudflare, typeof(global::Vapi.CreateCloudflareCredentialDTO), options);
            }
            else if (value.IsCustomLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomLlm, typeof(global::Vapi.CreateCustomLLMCredentialDTO), options);
            }
            else if (value.IsDeepgram)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepgram, typeof(global::Vapi.CreateDeepgramCredentialDTO), options);
            }
            else if (value.IsDeepinfra)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Deepinfra, typeof(global::Vapi.CreateDeepInfraCredentialDTO), options);
            }
            else if (value.IsDeepSeek)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DeepSeek, typeof(global::Vapi.CreateDeepSeekCredentialDTO), options);
            }
            else if (value.IsElevenlabs)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs, typeof(global::Vapi.CreateElevenLabsCredentialDTO), options);
            }
            else if (value.IsGcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gcp, typeof(global::Vapi.CreateGcpCredentialDTO), options);
            }
            else if (value.IsGladia)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gladia, typeof(global::Vapi.CreateGladiaCredentialDTO), options);
            }
            else if (value.IsGohighlevel)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gohighlevel, typeof(global::Vapi.CreateGoHighLevelCredentialDTO), options);
            }
            else if (value.IsGoogle)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Google, typeof(global::Vapi.CreateGoogleCredentialDTO), options);
            }
            else if (value.IsGroq)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Groq, typeof(global::Vapi.CreateGroqCredentialDTO), options);
            }
            else if (value.IsHume)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Hume, typeof(global::Vapi.CreateHumeCredentialDTO), options);
            }
            else if (value.IsInflectionAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InflectionAi, typeof(global::Vapi.CreateInflectionAICredentialDTO), options);
            }
            else if (value.IsLangfuse)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Langfuse, typeof(global::Vapi.CreateLangfuseCredentialDTO), options);
            }
            else if (value.IsLmnt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lmnt, typeof(global::Vapi.CreateLmntCredentialDTO), options);
            }
            else if (value.IsMake)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Make, typeof(global::Vapi.CreateMakeCredentialDTO), options);
            }
            else if (value.IsMistral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mistral, typeof(global::Vapi.CreateMistralCredentialDTO), options);
            }
            else if (value.IsNeuphonic)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Neuphonic, typeof(global::Vapi.CreateNeuphonicCredentialDTO), options);
            }
            else if (value.IsOpenai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai, typeof(global::Vapi.CreateOpenAICredentialDTO), options);
            }
            else if (value.IsOpenrouter)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openrouter, typeof(global::Vapi.CreateOpenRouterCredentialDTO), options);
            }
            else if (value.IsPerplexityAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PerplexityAi, typeof(global::Vapi.CreatePerplexityAICredentialDTO), options);
            }
            else if (value.IsPlayht)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Playht, typeof(global::Vapi.CreatePlayHTCredentialDTO), options);
            }
            else if (value.IsRimeAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RimeAi, typeof(global::Vapi.CreateRimeAICredentialDTO), options);
            }
            else if (value.IsRunpod)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Runpod, typeof(global::Vapi.CreateRunpodCredentialDTO), options);
            }
            else if (value.IsS3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.S3, typeof(global::Vapi.CreateS3CredentialDTO), options);
            }
            else if (value.IsSmallestAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SmallestAi, typeof(global::Vapi.CreateSmallestAICredentialDTO), options);
            }
            else if (value.IsSpeechmatics)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Speechmatics, typeof(global::Vapi.CreateSpeechmaticsCredentialDTO), options);
            }
            else if (value.IsSoniox)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Soniox, typeof(global::Vapi.CreateSonioxCredentialDTO), options);
            }
            else if (value.IsSupabase)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Supabase, typeof(global::Vapi.CreateSupabaseCredentialDTO), options);
            }
            else if (value.IsTavus)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tavus, typeof(global::Vapi.CreateTavusCredentialDTO), options);
            }
            else if (value.IsTogetherAi)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TogetherAi, typeof(global::Vapi.CreateTogetherAICredentialDTO), options);
            }
            else if (value.IsTrieve)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Trieve, typeof(global::Vapi.CreateTrieveCredentialDTO), options);
            }
            else if (value.IsTwilio)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Twilio, typeof(global::Vapi.CreateTwilioCredentialDTO), options);
            }
            else if (value.IsVonage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Vonage, typeof(global::Vapi.CreateVonageCredentialDTO), options);
            }
            else if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::Vapi.CreateWebhookCredentialDTO), options);
            }
            else if (value.IsCustomCredential)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomCredential, typeof(global::Vapi.CreateCustomCredentialDTO), options);
            }
            else if (value.IsXai)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Xai, typeof(global::Vapi.CreateXAiCredentialDTO), options);
            }
            else if (value.IsGoogleCalendarOauth2Client)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Client, typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO), options);
            }
            else if (value.IsGoogleCalendarOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleCalendarOauth2Authorization, typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsGoogleSheetsOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GoogleSheetsOauth2Authorization, typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsSlackOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackOauth2Authorization, typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO), options);
            }
            else if (value.IsGhlOauth2Authorization)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GhlOauth2Authorization, typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO), options);
            }
            else if (value.IsInworld)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Inworld, typeof(global::Vapi.CreateInworldCredentialDTO), options);
            }
            else if (value.IsMinimax)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Minimax, typeof(global::Vapi.CreateMinimaxCredentialDTO), options);
            }
            else if (value.IsWellsaid)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wellsaid, typeof(global::Vapi.CreateWellSaidCredentialDTO), options);
            }
            else if (value.IsEmail)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Email, typeof(global::Vapi.CreateEmailCredentialDTO), options);
            }
            else if (value.IsSlackWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SlackWebhook, typeof(global::Vapi.CreateSlackWebhookCredentialDTO), options);
            }
        }
    }
}