#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CredentialsItem7 : global::System.IEquatable<CredentialsItem7>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAnthropicCredentialDTO? Anthropic { get; init; }
#else
        public global::Vapi.CreateAnthropicCredentialDTO? Anthropic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anthropic))]
#endif
        public bool IsAnthropic => Anthropic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAnthropicBedrockCredentialDTO? AnthropicBedrock { get; init; }
#else
        public global::Vapi.CreateAnthropicBedrockCredentialDTO? AnthropicBedrock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicBedrock))]
#endif
        public bool IsAnthropicBedrock => AnthropicBedrock != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAnyscaleCredentialDTO? Anyscale { get; init; }
#else
        public global::Vapi.CreateAnyscaleCredentialDTO? Anyscale { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anyscale))]
#endif
        public bool IsAnyscale => Anyscale != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAssemblyAICredentialDTO? AssemblyAi { get; init; }
#else
        public global::Vapi.CreateAssemblyAICredentialDTO? AssemblyAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssemblyAi))]
#endif
        public bool IsAssemblyAi => AssemblyAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAzureCredentialDTO? Azure { get; init; }
#else
        public global::Vapi.CreateAzureCredentialDTO? Azure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Azure))]
#endif
        public bool IsAzure => Azure != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateAzureOpenAICredentialDTO? AzureOpenai { get; init; }
#else
        public global::Vapi.CreateAzureOpenAICredentialDTO? AzureOpenai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AzureOpenai))]
#endif
        public bool IsAzureOpenai => AzureOpenai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateByoSipTrunkCredentialDTO? ByoSipTrunk { get; init; }
#else
        public global::Vapi.CreateByoSipTrunkCredentialDTO? ByoSipTrunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ByoSipTrunk))]
#endif
        public bool IsByoSipTrunk => ByoSipTrunk != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateCartesiaCredentialDTO? Cartesia { get; init; }
#else
        public global::Vapi.CreateCartesiaCredentialDTO? Cartesia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cartesia))]
#endif
        public bool IsCartesia => Cartesia != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateCerebrasCredentialDTO? Cerebras { get; init; }
#else
        public global::Vapi.CreateCerebrasCredentialDTO? Cerebras { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cerebras))]
#endif
        public bool IsCerebras => Cerebras != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateCloudflareCredentialDTO? Cloudflare { get; init; }
#else
        public global::Vapi.CreateCloudflareCredentialDTO? Cloudflare { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Cloudflare))]
#endif
        public bool IsCloudflare => Cloudflare != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateCustomLLMCredentialDTO? CustomLlm { get; init; }
#else
        public global::Vapi.CreateCustomLLMCredentialDTO? CustomLlm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomLlm))]
#endif
        public bool IsCustomLlm => CustomLlm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateDeepgramCredentialDTO? Deepgram { get; init; }
#else
        public global::Vapi.CreateDeepgramCredentialDTO? Deepgram { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepgram))]
#endif
        public bool IsDeepgram => Deepgram != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateDeepInfraCredentialDTO? Deepinfra { get; init; }
#else
        public global::Vapi.CreateDeepInfraCredentialDTO? Deepinfra { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Deepinfra))]
#endif
        public bool IsDeepinfra => Deepinfra != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateDeepSeekCredentialDTO? DeepSeek { get; init; }
#else
        public global::Vapi.CreateDeepSeekCredentialDTO? DeepSeek { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeepSeek))]
#endif
        public bool IsDeepSeek => DeepSeek != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateElevenLabsCredentialDTO? Elevenlabs { get; init; }
#else
        public global::Vapi.CreateElevenLabsCredentialDTO? Elevenlabs { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Elevenlabs))]
#endif
        public bool IsElevenlabs => Elevenlabs != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGcpCredentialDTO? Gcp { get; init; }
#else
        public global::Vapi.CreateGcpCredentialDTO? Gcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gcp))]
#endif
        public bool IsGcp => Gcp != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGladiaCredentialDTO? Gladia { get; init; }
#else
        public global::Vapi.CreateGladiaCredentialDTO? Gladia { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gladia))]
#endif
        public bool IsGladia => Gladia != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoHighLevelCredentialDTO? Gohighlevel { get; init; }
#else
        public global::Vapi.CreateGoHighLevelCredentialDTO? Gohighlevel { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Gohighlevel))]
#endif
        public bool IsGohighlevel => Gohighlevel != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoogleCredentialDTO? Google { get; init; }
#else
        public global::Vapi.CreateGoogleCredentialDTO? Google { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Google))]
#endif
        public bool IsGoogle => Google != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGroqCredentialDTO? Groq { get; init; }
#else
        public global::Vapi.CreateGroqCredentialDTO? Groq { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Groq))]
#endif
        public bool IsGroq => Groq != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateHumeCredentialDTO? Hume { get; init; }
#else
        public global::Vapi.CreateHumeCredentialDTO? Hume { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hume))]
#endif
        public bool IsHume => Hume != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateInflectionAICredentialDTO? InflectionAi { get; init; }
#else
        public global::Vapi.CreateInflectionAICredentialDTO? InflectionAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InflectionAi))]
#endif
        public bool IsInflectionAi => InflectionAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateLangfuseCredentialDTO? Langfuse { get; init; }
#else
        public global::Vapi.CreateLangfuseCredentialDTO? Langfuse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Langfuse))]
#endif
        public bool IsLangfuse => Langfuse != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateLmntCredentialDTO? Lmnt { get; init; }
#else
        public global::Vapi.CreateLmntCredentialDTO? Lmnt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Lmnt))]
#endif
        public bool IsLmnt => Lmnt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateMakeCredentialDTO? Make { get; init; }
#else
        public global::Vapi.CreateMakeCredentialDTO? Make { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Make))]
#endif
        public bool IsMake => Make != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateMistralCredentialDTO? Mistral { get; init; }
#else
        public global::Vapi.CreateMistralCredentialDTO? Mistral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mistral))]
#endif
        public bool IsMistral => Mistral != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateNeuphonicCredentialDTO? Neuphonic { get; init; }
#else
        public global::Vapi.CreateNeuphonicCredentialDTO? Neuphonic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Neuphonic))]
#endif
        public bool IsNeuphonic => Neuphonic != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateOpenAICredentialDTO? Openai { get; init; }
#else
        public global::Vapi.CreateOpenAICredentialDTO? Openai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openai))]
#endif
        public bool IsOpenai => Openai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateOpenRouterCredentialDTO? Openrouter { get; init; }
#else
        public global::Vapi.CreateOpenRouterCredentialDTO? Openrouter { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Openrouter))]
#endif
        public bool IsOpenrouter => Openrouter != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreatePerplexityAICredentialDTO? PerplexityAi { get; init; }
#else
        public global::Vapi.CreatePerplexityAICredentialDTO? PerplexityAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PerplexityAi))]
#endif
        public bool IsPerplexityAi => PerplexityAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreatePlayHTCredentialDTO? Playht { get; init; }
#else
        public global::Vapi.CreatePlayHTCredentialDTO? Playht { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Playht))]
#endif
        public bool IsPlayht => Playht != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateRimeAICredentialDTO? RimeAi { get; init; }
#else
        public global::Vapi.CreateRimeAICredentialDTO? RimeAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RimeAi))]
#endif
        public bool IsRimeAi => RimeAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateRunpodCredentialDTO? Runpod { get; init; }
#else
        public global::Vapi.CreateRunpodCredentialDTO? Runpod { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Runpod))]
#endif
        public bool IsRunpod => Runpod != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateS3CredentialDTO? S3 { get; init; }
#else
        public global::Vapi.CreateS3CredentialDTO? S3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3))]
#endif
        public bool IsS3 => S3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSmallestAICredentialDTO? SmallestAi { get; init; }
#else
        public global::Vapi.CreateSmallestAICredentialDTO? SmallestAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmallestAi))]
#endif
        public bool IsSmallestAi => SmallestAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSpeechmaticsCredentialDTO? Speechmatics { get; init; }
#else
        public global::Vapi.CreateSpeechmaticsCredentialDTO? Speechmatics { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Speechmatics))]
#endif
        public bool IsSpeechmatics => Speechmatics != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSonioxCredentialDTO? Soniox { get; init; }
#else
        public global::Vapi.CreateSonioxCredentialDTO? Soniox { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Soniox))]
#endif
        public bool IsSoniox => Soniox != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSupabaseCredentialDTO? Supabase { get; init; }
#else
        public global::Vapi.CreateSupabaseCredentialDTO? Supabase { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Supabase))]
#endif
        public bool IsSupabase => Supabase != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateTavusCredentialDTO? Tavus { get; init; }
#else
        public global::Vapi.CreateTavusCredentialDTO? Tavus { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tavus))]
#endif
        public bool IsTavus => Tavus != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateTogetherAICredentialDTO? TogetherAi { get; init; }
#else
        public global::Vapi.CreateTogetherAICredentialDTO? TogetherAi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TogetherAi))]
#endif
        public bool IsTogetherAi => TogetherAi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateTwilioCredentialDTO? Twilio { get; init; }
#else
        public global::Vapi.CreateTwilioCredentialDTO? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateVonageCredentialDTO? Vonage { get; init; }
#else
        public global::Vapi.CreateVonageCredentialDTO? Vonage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vonage))]
#endif
        public bool IsVonage => Vonage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateWebhookCredentialDTO? Webhook { get; init; }
#else
        public global::Vapi.CreateWebhookCredentialDTO? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateCustomCredentialDTO? CustomCredential { get; init; }
#else
        public global::Vapi.CreateCustomCredentialDTO? CustomCredential { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomCredential))]
#endif
        public bool IsCustomCredential => CustomCredential != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateXAiCredentialDTO? Xai { get; init; }
#else
        public global::Vapi.CreateXAiCredentialDTO? Xai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Xai))]
#endif
        public bool IsXai => Xai != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? GoogleCalendarOauth2Client { get; init; }
#else
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? GoogleCalendarOauth2Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarOauth2Client))]
#endif
        public bool IsGoogleCalendarOauth2Client => GoogleCalendarOauth2Client != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? GoogleCalendarOauth2Authorization { get; init; }
#else
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? GoogleCalendarOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleCalendarOauth2Authorization))]
#endif
        public bool IsGoogleCalendarOauth2Authorization => GoogleCalendarOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? GoogleSheetsOauth2Authorization { get; init; }
#else
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? GoogleSheetsOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GoogleSheetsOauth2Authorization))]
#endif
        public bool IsGoogleSheetsOauth2Authorization => GoogleSheetsOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? SlackOauth2Authorization { get; init; }
#else
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? SlackOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackOauth2Authorization))]
#endif
        public bool IsSlackOauth2Authorization => SlackOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO? GhlOauth2Authorization { get; init; }
#else
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO? GhlOauth2Authorization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GhlOauth2Authorization))]
#endif
        public bool IsGhlOauth2Authorization => GhlOauth2Authorization != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateInworldCredentialDTO? Inworld { get; init; }
#else
        public global::Vapi.CreateInworldCredentialDTO? Inworld { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Inworld))]
#endif
        public bool IsInworld => Inworld != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateMinimaxCredentialDTO? Minimax { get; init; }
#else
        public global::Vapi.CreateMinimaxCredentialDTO? Minimax { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Minimax))]
#endif
        public bool IsMinimax => Minimax != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateWellSaidCredentialDTO? Wellsaid { get; init; }
#else
        public global::Vapi.CreateWellSaidCredentialDTO? Wellsaid { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Wellsaid))]
#endif
        public bool IsWellsaid => Wellsaid != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateEmailCredentialDTO? Email { get; init; }
#else
        public global::Vapi.CreateEmailCredentialDTO? Email { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Email))]
#endif
        public bool IsEmail => Email != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateSlackWebhookCredentialDTO? SlackWebhook { get; init; }
#else
        public global::Vapi.CreateSlackWebhookCredentialDTO? SlackWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SlackWebhook))]
#endif
        public bool IsSlackWebhook => SlackWebhook != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAnthropicCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAnthropicCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAnthropicCredentialDTO?(CredentialsItem7 @this) => @this.Anthropic;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAnthropicCredentialDTO? value)
        {
            Anthropic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAnthropicBedrockCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAnthropicBedrockCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAnthropicBedrockCredentialDTO?(CredentialsItem7 @this) => @this.AnthropicBedrock;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAnthropicBedrockCredentialDTO? value)
        {
            AnthropicBedrock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAnyscaleCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAnyscaleCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAnyscaleCredentialDTO?(CredentialsItem7 @this) => @this.Anyscale;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAnyscaleCredentialDTO? value)
        {
            Anyscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAssemblyAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAssemblyAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAssemblyAICredentialDTO?(CredentialsItem7 @this) => @this.AssemblyAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAssemblyAICredentialDTO? value)
        {
            AssemblyAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAzureCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAzureCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAzureCredentialDTO?(CredentialsItem7 @this) => @this.Azure;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAzureCredentialDTO? value)
        {
            Azure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateAzureOpenAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateAzureOpenAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateAzureOpenAICredentialDTO?(CredentialsItem7 @this) => @this.AzureOpenai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateAzureOpenAICredentialDTO? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateByoSipTrunkCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateByoSipTrunkCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateByoSipTrunkCredentialDTO?(CredentialsItem7 @this) => @this.ByoSipTrunk;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateByoSipTrunkCredentialDTO? value)
        {
            ByoSipTrunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateCartesiaCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateCartesiaCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCartesiaCredentialDTO?(CredentialsItem7 @this) => @this.Cartesia;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateCartesiaCredentialDTO? value)
        {
            Cartesia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateCerebrasCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateCerebrasCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCerebrasCredentialDTO?(CredentialsItem7 @this) => @this.Cerebras;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateCerebrasCredentialDTO? value)
        {
            Cerebras = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateCloudflareCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateCloudflareCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCloudflareCredentialDTO?(CredentialsItem7 @this) => @this.Cloudflare;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateCloudflareCredentialDTO? value)
        {
            Cloudflare = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateCustomLLMCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateCustomLLMCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCustomLLMCredentialDTO?(CredentialsItem7 @this) => @this.CustomLlm;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateCustomLLMCredentialDTO? value)
        {
            CustomLlm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateDeepgramCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateDeepgramCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepgramCredentialDTO?(CredentialsItem7 @this) => @this.Deepgram;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateDeepgramCredentialDTO? value)
        {
            Deepgram = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateDeepInfraCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateDeepInfraCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepInfraCredentialDTO?(CredentialsItem7 @this) => @this.Deepinfra;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateDeepInfraCredentialDTO? value)
        {
            Deepinfra = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateDeepSeekCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateDeepSeekCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepSeekCredentialDTO?(CredentialsItem7 @this) => @this.DeepSeek;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateDeepSeekCredentialDTO? value)
        {
            DeepSeek = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateElevenLabsCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateElevenLabsCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateElevenLabsCredentialDTO?(CredentialsItem7 @this) => @this.Elevenlabs;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateElevenLabsCredentialDTO? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGcpCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGcpCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGcpCredentialDTO?(CredentialsItem7 @this) => @this.Gcp;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGcpCredentialDTO? value)
        {
            Gcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGladiaCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGladiaCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGladiaCredentialDTO?(CredentialsItem7 @this) => @this.Gladia;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGladiaCredentialDTO? value)
        {
            Gladia = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoHighLevelCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoHighLevelCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelCredentialDTO?(CredentialsItem7 @this) => @this.Gohighlevel;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoHighLevelCredentialDTO? value)
        {
            Gohighlevel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoogleCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoogleCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCredentialDTO?(CredentialsItem7 @this) => @this.Google;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoogleCredentialDTO? value)
        {
            Google = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGroqCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGroqCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGroqCredentialDTO?(CredentialsItem7 @this) => @this.Groq;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGroqCredentialDTO? value)
        {
            Groq = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateHumeCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateHumeCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateHumeCredentialDTO?(CredentialsItem7 @this) => @this.Hume;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateHumeCredentialDTO? value)
        {
            Hume = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateInflectionAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateInflectionAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateInflectionAICredentialDTO?(CredentialsItem7 @this) => @this.InflectionAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateInflectionAICredentialDTO? value)
        {
            InflectionAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateLangfuseCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateLangfuseCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateLangfuseCredentialDTO?(CredentialsItem7 @this) => @this.Langfuse;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateLangfuseCredentialDTO? value)
        {
            Langfuse = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateLmntCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateLmntCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateLmntCredentialDTO?(CredentialsItem7 @this) => @this.Lmnt;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateLmntCredentialDTO? value)
        {
            Lmnt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateMakeCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateMakeCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateMakeCredentialDTO?(CredentialsItem7 @this) => @this.Make;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateMakeCredentialDTO? value)
        {
            Make = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateMistralCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateMistralCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateMistralCredentialDTO?(CredentialsItem7 @this) => @this.Mistral;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateMistralCredentialDTO? value)
        {
            Mistral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateNeuphonicCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateNeuphonicCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateNeuphonicCredentialDTO?(CredentialsItem7 @this) => @this.Neuphonic;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateNeuphonicCredentialDTO? value)
        {
            Neuphonic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateOpenAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateOpenAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateOpenAICredentialDTO?(CredentialsItem7 @this) => @this.Openai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateOpenAICredentialDTO? value)
        {
            Openai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateOpenRouterCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateOpenRouterCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateOpenRouterCredentialDTO?(CredentialsItem7 @this) => @this.Openrouter;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateOpenRouterCredentialDTO? value)
        {
            Openrouter = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreatePerplexityAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreatePerplexityAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreatePerplexityAICredentialDTO?(CredentialsItem7 @this) => @this.PerplexityAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreatePerplexityAICredentialDTO? value)
        {
            PerplexityAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreatePlayHTCredentialDTO value) => new CredentialsItem7((global::Vapi.CreatePlayHTCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreatePlayHTCredentialDTO?(CredentialsItem7 @this) => @this.Playht;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreatePlayHTCredentialDTO? value)
        {
            Playht = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateRimeAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateRimeAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateRimeAICredentialDTO?(CredentialsItem7 @this) => @this.RimeAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateRimeAICredentialDTO? value)
        {
            RimeAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateRunpodCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateRunpodCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateRunpodCredentialDTO?(CredentialsItem7 @this) => @this.Runpod;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateRunpodCredentialDTO? value)
        {
            Runpod = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateS3CredentialDTO value) => new CredentialsItem7((global::Vapi.CreateS3CredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateS3CredentialDTO?(CredentialsItem7 @this) => @this.S3;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateS3CredentialDTO? value)
        {
            S3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSmallestAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSmallestAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSmallestAICredentialDTO?(CredentialsItem7 @this) => @this.SmallestAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSmallestAICredentialDTO? value)
        {
            SmallestAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSpeechmaticsCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSpeechmaticsCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSpeechmaticsCredentialDTO?(CredentialsItem7 @this) => @this.Speechmatics;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSpeechmaticsCredentialDTO? value)
        {
            Speechmatics = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSonioxCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSonioxCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSonioxCredentialDTO?(CredentialsItem7 @this) => @this.Soniox;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSonioxCredentialDTO? value)
        {
            Soniox = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSupabaseCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSupabaseCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSupabaseCredentialDTO?(CredentialsItem7 @this) => @this.Supabase;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSupabaseCredentialDTO? value)
        {
            Supabase = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateTavusCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateTavusCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTavusCredentialDTO?(CredentialsItem7 @this) => @this.Tavus;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateTavusCredentialDTO? value)
        {
            Tavus = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateTogetherAICredentialDTO value) => new CredentialsItem7((global::Vapi.CreateTogetherAICredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTogetherAICredentialDTO?(CredentialsItem7 @this) => @this.TogetherAi;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateTogetherAICredentialDTO? value)
        {
            TogetherAi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateTwilioCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateTwilioCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTwilioCredentialDTO?(CredentialsItem7 @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateTwilioCredentialDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateVonageCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateVonageCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateVonageCredentialDTO?(CredentialsItem7 @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateVonageCredentialDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateWebhookCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateWebhookCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateWebhookCredentialDTO?(CredentialsItem7 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateWebhookCredentialDTO? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateCustomCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateCustomCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateCustomCredentialDTO?(CredentialsItem7 @this) => @this.CustomCredential;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateCustomCredentialDTO? value)
        {
            CustomCredential = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateXAiCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateXAiCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateXAiCredentialDTO?(CredentialsItem7 @this) => @this.Xai;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateXAiCredentialDTO? value)
        {
            Xai = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?(CredentialsItem7 @this) => @this.GoogleCalendarOauth2Client;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? value)
        {
            GoogleCalendarOauth2Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?(CredentialsItem7 @this) => @this.GoogleCalendarOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleCalendarOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?(CredentialsItem7 @this) => @this.GoogleSheetsOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleSheetsOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?(CredentialsItem7 @this) => @this.SlackOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? value)
        {
            SlackOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateGoHighLevelMCPCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateGoHighLevelMCPCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelMCPCredentialDTO?(CredentialsItem7 @this) => @this.GhlOauth2Authorization;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateGoHighLevelMCPCredentialDTO? value)
        {
            GhlOauth2Authorization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateInworldCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateInworldCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateInworldCredentialDTO?(CredentialsItem7 @this) => @this.Inworld;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateInworldCredentialDTO? value)
        {
            Inworld = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateMinimaxCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateMinimaxCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateMinimaxCredentialDTO?(CredentialsItem7 @this) => @this.Minimax;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateMinimaxCredentialDTO? value)
        {
            Minimax = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateWellSaidCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateWellSaidCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateWellSaidCredentialDTO?(CredentialsItem7 @this) => @this.Wellsaid;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateWellSaidCredentialDTO? value)
        {
            Wellsaid = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateEmailCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateEmailCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateEmailCredentialDTO?(CredentialsItem7 @this) => @this.Email;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateEmailCredentialDTO? value)
        {
            Email = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CredentialsItem7(global::Vapi.CreateSlackWebhookCredentialDTO value) => new CredentialsItem7((global::Vapi.CreateSlackWebhookCredentialDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateSlackWebhookCredentialDTO?(CredentialsItem7 @this) => @this.SlackWebhook;

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(global::Vapi.CreateSlackWebhookCredentialDTO? value)
        {
            SlackWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CredentialsItem7(
            global::Vapi.CreateWorkflowDTOCredentialDiscriminatorProvider? provider,
            global::Vapi.CreateAnthropicCredentialDTO? anthropic,
            global::Vapi.CreateAnthropicBedrockCredentialDTO? anthropicBedrock,
            global::Vapi.CreateAnyscaleCredentialDTO? anyscale,
            global::Vapi.CreateAssemblyAICredentialDTO? assemblyAi,
            global::Vapi.CreateAzureCredentialDTO? azure,
            global::Vapi.CreateAzureOpenAICredentialDTO? azureOpenai,
            global::Vapi.CreateByoSipTrunkCredentialDTO? byoSipTrunk,
            global::Vapi.CreateCartesiaCredentialDTO? cartesia,
            global::Vapi.CreateCerebrasCredentialDTO? cerebras,
            global::Vapi.CreateCloudflareCredentialDTO? cloudflare,
            global::Vapi.CreateCustomLLMCredentialDTO? customLlm,
            global::Vapi.CreateDeepgramCredentialDTO? deepgram,
            global::Vapi.CreateDeepInfraCredentialDTO? deepinfra,
            global::Vapi.CreateDeepSeekCredentialDTO? deepSeek,
            global::Vapi.CreateElevenLabsCredentialDTO? elevenlabs,
            global::Vapi.CreateGcpCredentialDTO? gcp,
            global::Vapi.CreateGladiaCredentialDTO? gladia,
            global::Vapi.CreateGoHighLevelCredentialDTO? gohighlevel,
            global::Vapi.CreateGoogleCredentialDTO? google,
            global::Vapi.CreateGroqCredentialDTO? groq,
            global::Vapi.CreateHumeCredentialDTO? hume,
            global::Vapi.CreateInflectionAICredentialDTO? inflectionAi,
            global::Vapi.CreateLangfuseCredentialDTO? langfuse,
            global::Vapi.CreateLmntCredentialDTO? lmnt,
            global::Vapi.CreateMakeCredentialDTO? make,
            global::Vapi.CreateMistralCredentialDTO? mistral,
            global::Vapi.CreateNeuphonicCredentialDTO? neuphonic,
            global::Vapi.CreateOpenAICredentialDTO? openai,
            global::Vapi.CreateOpenRouterCredentialDTO? openrouter,
            global::Vapi.CreatePerplexityAICredentialDTO? perplexityAi,
            global::Vapi.CreatePlayHTCredentialDTO? playht,
            global::Vapi.CreateRimeAICredentialDTO? rimeAi,
            global::Vapi.CreateRunpodCredentialDTO? runpod,
            global::Vapi.CreateS3CredentialDTO? s3,
            global::Vapi.CreateSmallestAICredentialDTO? smallestAi,
            global::Vapi.CreateSpeechmaticsCredentialDTO? speechmatics,
            global::Vapi.CreateSonioxCredentialDTO? soniox,
            global::Vapi.CreateSupabaseCredentialDTO? supabase,
            global::Vapi.CreateTavusCredentialDTO? tavus,
            global::Vapi.CreateTogetherAICredentialDTO? togetherAi,
            global::Vapi.CreateTwilioCredentialDTO? twilio,
            global::Vapi.CreateVonageCredentialDTO? vonage,
            global::Vapi.CreateWebhookCredentialDTO? webhook,
            global::Vapi.CreateCustomCredentialDTO? customCredential,
            global::Vapi.CreateXAiCredentialDTO? xai,
            global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? googleCalendarOauth2Client,
            global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? googleCalendarOauth2Authorization,
            global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? googleSheetsOauth2Authorization,
            global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? slackOauth2Authorization,
            global::Vapi.CreateGoHighLevelMCPCredentialDTO? ghlOauth2Authorization,
            global::Vapi.CreateInworldCredentialDTO? inworld,
            global::Vapi.CreateMinimaxCredentialDTO? minimax,
            global::Vapi.CreateWellSaidCredentialDTO? wellsaid,
            global::Vapi.CreateEmailCredentialDTO? email,
            global::Vapi.CreateSlackWebhookCredentialDTO? slackWebhook
            )
        {
            Provider = provider;

            Anthropic = anthropic;
            AnthropicBedrock = anthropicBedrock;
            Anyscale = anyscale;
            AssemblyAi = assemblyAi;
            Azure = azure;
            AzureOpenai = azureOpenai;
            ByoSipTrunk = byoSipTrunk;
            Cartesia = cartesia;
            Cerebras = cerebras;
            Cloudflare = cloudflare;
            CustomLlm = customLlm;
            Deepgram = deepgram;
            Deepinfra = deepinfra;
            DeepSeek = deepSeek;
            Elevenlabs = elevenlabs;
            Gcp = gcp;
            Gladia = gladia;
            Gohighlevel = gohighlevel;
            Google = google;
            Groq = groq;
            Hume = hume;
            InflectionAi = inflectionAi;
            Langfuse = langfuse;
            Lmnt = lmnt;
            Make = make;
            Mistral = mistral;
            Neuphonic = neuphonic;
            Openai = openai;
            Openrouter = openrouter;
            PerplexityAi = perplexityAi;
            Playht = playht;
            RimeAi = rimeAi;
            Runpod = runpod;
            S3 = s3;
            SmallestAi = smallestAi;
            Speechmatics = speechmatics;
            Soniox = soniox;
            Supabase = supabase;
            Tavus = tavus;
            TogetherAi = togetherAi;
            Twilio = twilio;
            Vonage = vonage;
            Webhook = webhook;
            CustomCredential = customCredential;
            Xai = xai;
            GoogleCalendarOauth2Client = googleCalendarOauth2Client;
            GoogleCalendarOauth2Authorization = googleCalendarOauth2Authorization;
            GoogleSheetsOauth2Authorization = googleSheetsOauth2Authorization;
            SlackOauth2Authorization = slackOauth2Authorization;
            GhlOauth2Authorization = ghlOauth2Authorization;
            Inworld = inworld;
            Minimax = minimax;
            Wellsaid = wellsaid;
            Email = email;
            SlackWebhook = slackWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SlackWebhook as object ??
            Email as object ??
            Wellsaid as object ??
            Minimax as object ??
            Inworld as object ??
            GhlOauth2Authorization as object ??
            SlackOauth2Authorization as object ??
            GoogleSheetsOauth2Authorization as object ??
            GoogleCalendarOauth2Authorization as object ??
            GoogleCalendarOauth2Client as object ??
            Xai as object ??
            CustomCredential as object ??
            Webhook as object ??
            Vonage as object ??
            Twilio as object ??
            TogetherAi as object ??
            Tavus as object ??
            Supabase as object ??
            Soniox as object ??
            Speechmatics as object ??
            SmallestAi as object ??
            S3 as object ??
            Runpod as object ??
            RimeAi as object ??
            Playht as object ??
            PerplexityAi as object ??
            Openrouter as object ??
            Openai as object ??
            Neuphonic as object ??
            Mistral as object ??
            Make as object ??
            Lmnt as object ??
            Langfuse as object ??
            InflectionAi as object ??
            Hume as object ??
            Groq as object ??
            Google as object ??
            Gohighlevel as object ??
            Gladia as object ??
            Gcp as object ??
            Elevenlabs as object ??
            DeepSeek as object ??
            Deepinfra as object ??
            Deepgram as object ??
            CustomLlm as object ??
            Cloudflare as object ??
            Cerebras as object ??
            Cartesia as object ??
            ByoSipTrunk as object ??
            AzureOpenai as object ??
            Azure as object ??
            AssemblyAi as object ??
            Anyscale as object ??
            AnthropicBedrock as object ??
            Anthropic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Anthropic?.ToString() ??
            AnthropicBedrock?.ToString() ??
            Anyscale?.ToString() ??
            AssemblyAi?.ToString() ??
            Azure?.ToString() ??
            AzureOpenai?.ToString() ??
            ByoSipTrunk?.ToString() ??
            Cartesia?.ToString() ??
            Cerebras?.ToString() ??
            Cloudflare?.ToString() ??
            CustomLlm?.ToString() ??
            Deepgram?.ToString() ??
            Deepinfra?.ToString() ??
            DeepSeek?.ToString() ??
            Elevenlabs?.ToString() ??
            Gcp?.ToString() ??
            Gladia?.ToString() ??
            Gohighlevel?.ToString() ??
            Google?.ToString() ??
            Groq?.ToString() ??
            Hume?.ToString() ??
            InflectionAi?.ToString() ??
            Langfuse?.ToString() ??
            Lmnt?.ToString() ??
            Make?.ToString() ??
            Mistral?.ToString() ??
            Neuphonic?.ToString() ??
            Openai?.ToString() ??
            Openrouter?.ToString() ??
            PerplexityAi?.ToString() ??
            Playht?.ToString() ??
            RimeAi?.ToString() ??
            Runpod?.ToString() ??
            S3?.ToString() ??
            SmallestAi?.ToString() ??
            Speechmatics?.ToString() ??
            Soniox?.ToString() ??
            Supabase?.ToString() ??
            Tavus?.ToString() ??
            TogetherAi?.ToString() ??
            Twilio?.ToString() ??
            Vonage?.ToString() ??
            Webhook?.ToString() ??
            CustomCredential?.ToString() ??
            Xai?.ToString() ??
            GoogleCalendarOauth2Client?.ToString() ??
            GoogleCalendarOauth2Authorization?.ToString() ??
            GoogleSheetsOauth2Authorization?.ToString() ??
            SlackOauth2Authorization?.ToString() ??
            GhlOauth2Authorization?.ToString() ??
            Inworld?.ToString() ??
            Minimax?.ToString() ??
            Wellsaid?.ToString() ??
            Email?.ToString() ??
            SlackWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && IsSlackWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.CreateAnthropicCredentialDTO?, TResult>? anthropic = null,
            global::System.Func<global::Vapi.CreateAnthropicBedrockCredentialDTO?, TResult>? anthropicBedrock = null,
            global::System.Func<global::Vapi.CreateAnyscaleCredentialDTO?, TResult>? anyscale = null,
            global::System.Func<global::Vapi.CreateAssemblyAICredentialDTO?, TResult>? assemblyAi = null,
            global::System.Func<global::Vapi.CreateAzureCredentialDTO?, TResult>? azure = null,
            global::System.Func<global::Vapi.CreateAzureOpenAICredentialDTO?, TResult>? azureOpenai = null,
            global::System.Func<global::Vapi.CreateByoSipTrunkCredentialDTO?, TResult>? byoSipTrunk = null,
            global::System.Func<global::Vapi.CreateCartesiaCredentialDTO?, TResult>? cartesia = null,
            global::System.Func<global::Vapi.CreateCerebrasCredentialDTO?, TResult>? cerebras = null,
            global::System.Func<global::Vapi.CreateCloudflareCredentialDTO?, TResult>? cloudflare = null,
            global::System.Func<global::Vapi.CreateCustomLLMCredentialDTO?, TResult>? customLlm = null,
            global::System.Func<global::Vapi.CreateDeepgramCredentialDTO?, TResult>? deepgram = null,
            global::System.Func<global::Vapi.CreateDeepInfraCredentialDTO?, TResult>? deepinfra = null,
            global::System.Func<global::Vapi.CreateDeepSeekCredentialDTO?, TResult>? deepSeek = null,
            global::System.Func<global::Vapi.CreateElevenLabsCredentialDTO?, TResult>? elevenlabs = null,
            global::System.Func<global::Vapi.CreateGcpCredentialDTO?, TResult>? gcp = null,
            global::System.Func<global::Vapi.CreateGladiaCredentialDTO?, TResult>? gladia = null,
            global::System.Func<global::Vapi.CreateGoHighLevelCredentialDTO?, TResult>? gohighlevel = null,
            global::System.Func<global::Vapi.CreateGoogleCredentialDTO?, TResult>? google = null,
            global::System.Func<global::Vapi.CreateGroqCredentialDTO?, TResult>? groq = null,
            global::System.Func<global::Vapi.CreateHumeCredentialDTO?, TResult>? hume = null,
            global::System.Func<global::Vapi.CreateInflectionAICredentialDTO?, TResult>? inflectionAi = null,
            global::System.Func<global::Vapi.CreateLangfuseCredentialDTO?, TResult>? langfuse = null,
            global::System.Func<global::Vapi.CreateLmntCredentialDTO?, TResult>? lmnt = null,
            global::System.Func<global::Vapi.CreateMakeCredentialDTO?, TResult>? make = null,
            global::System.Func<global::Vapi.CreateMistralCredentialDTO?, TResult>? mistral = null,
            global::System.Func<global::Vapi.CreateNeuphonicCredentialDTO?, TResult>? neuphonic = null,
            global::System.Func<global::Vapi.CreateOpenAICredentialDTO?, TResult>? openai = null,
            global::System.Func<global::Vapi.CreateOpenRouterCredentialDTO?, TResult>? openrouter = null,
            global::System.Func<global::Vapi.CreatePerplexityAICredentialDTO?, TResult>? perplexityAi = null,
            global::System.Func<global::Vapi.CreatePlayHTCredentialDTO?, TResult>? playht = null,
            global::System.Func<global::Vapi.CreateRimeAICredentialDTO?, TResult>? rimeAi = null,
            global::System.Func<global::Vapi.CreateRunpodCredentialDTO?, TResult>? runpod = null,
            global::System.Func<global::Vapi.CreateS3CredentialDTO?, TResult>? s3 = null,
            global::System.Func<global::Vapi.CreateSmallestAICredentialDTO?, TResult>? smallestAi = null,
            global::System.Func<global::Vapi.CreateSpeechmaticsCredentialDTO?, TResult>? speechmatics = null,
            global::System.Func<global::Vapi.CreateSonioxCredentialDTO?, TResult>? soniox = null,
            global::System.Func<global::Vapi.CreateSupabaseCredentialDTO?, TResult>? supabase = null,
            global::System.Func<global::Vapi.CreateTavusCredentialDTO?, TResult>? tavus = null,
            global::System.Func<global::Vapi.CreateTogetherAICredentialDTO?, TResult>? togetherAi = null,
            global::System.Func<global::Vapi.CreateTwilioCredentialDTO?, TResult>? twilio = null,
            global::System.Func<global::Vapi.CreateVonageCredentialDTO?, TResult>? vonage = null,
            global::System.Func<global::Vapi.CreateWebhookCredentialDTO?, TResult>? webhook = null,
            global::System.Func<global::Vapi.CreateCustomCredentialDTO?, TResult>? customCredential = null,
            global::System.Func<global::Vapi.CreateXAiCredentialDTO?, TResult>? xai = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?, TResult>? googleCalendarOauth2Client = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?, TResult>? googleCalendarOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?, TResult>? googleSheetsOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?, TResult>? slackOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateGoHighLevelMCPCredentialDTO?, TResult>? ghlOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateInworldCredentialDTO?, TResult>? inworld = null,
            global::System.Func<global::Vapi.CreateMinimaxCredentialDTO?, TResult>? minimax = null,
            global::System.Func<global::Vapi.CreateWellSaidCredentialDTO?, TResult>? wellsaid = null,
            global::System.Func<global::Vapi.CreateEmailCredentialDTO?, TResult>? email = null,
            global::System.Func<global::Vapi.CreateSlackWebhookCredentialDTO?, TResult>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic && anthropic != null)
            {
                return anthropic(Anthropic!);
            }
            else if (IsAnthropicBedrock && anthropicBedrock != null)
            {
                return anthropicBedrock(AnthropicBedrock!);
            }
            else if (IsAnyscale && anyscale != null)
            {
                return anyscale(Anyscale!);
            }
            else if (IsAssemblyAi && assemblyAi != null)
            {
                return assemblyAi(AssemblyAi!);
            }
            else if (IsAzure && azure != null)
            {
                return azure(Azure!);
            }
            else if (IsAzureOpenai && azureOpenai != null)
            {
                return azureOpenai(AzureOpenai!);
            }
            else if (IsByoSipTrunk && byoSipTrunk != null)
            {
                return byoSipTrunk(ByoSipTrunk!);
            }
            else if (IsCartesia && cartesia != null)
            {
                return cartesia(Cartesia!);
            }
            else if (IsCerebras && cerebras != null)
            {
                return cerebras(Cerebras!);
            }
            else if (IsCloudflare && cloudflare != null)
            {
                return cloudflare(Cloudflare!);
            }
            else if (IsCustomLlm && customLlm != null)
            {
                return customLlm(CustomLlm!);
            }
            else if (IsDeepgram && deepgram != null)
            {
                return deepgram(Deepgram!);
            }
            else if (IsDeepinfra && deepinfra != null)
            {
                return deepinfra(Deepinfra!);
            }
            else if (IsDeepSeek && deepSeek != null)
            {
                return deepSeek(DeepSeek!);
            }
            else if (IsElevenlabs && elevenlabs != null)
            {
                return elevenlabs(Elevenlabs!);
            }
            else if (IsGcp && gcp != null)
            {
                return gcp(Gcp!);
            }
            else if (IsGladia && gladia != null)
            {
                return gladia(Gladia!);
            }
            else if (IsGohighlevel && gohighlevel != null)
            {
                return gohighlevel(Gohighlevel!);
            }
            else if (IsGoogle && google != null)
            {
                return google(Google!);
            }
            else if (IsGroq && groq != null)
            {
                return groq(Groq!);
            }
            else if (IsHume && hume != null)
            {
                return hume(Hume!);
            }
            else if (IsInflectionAi && inflectionAi != null)
            {
                return inflectionAi(InflectionAi!);
            }
            else if (IsLangfuse && langfuse != null)
            {
                return langfuse(Langfuse!);
            }
            else if (IsLmnt && lmnt != null)
            {
                return lmnt(Lmnt!);
            }
            else if (IsMake && make != null)
            {
                return make(Make!);
            }
            else if (IsMistral && mistral != null)
            {
                return mistral(Mistral!);
            }
            else if (IsNeuphonic && neuphonic != null)
            {
                return neuphonic(Neuphonic!);
            }
            else if (IsOpenai && openai != null)
            {
                return openai(Openai!);
            }
            else if (IsOpenrouter && openrouter != null)
            {
                return openrouter(Openrouter!);
            }
            else if (IsPerplexityAi && perplexityAi != null)
            {
                return perplexityAi(PerplexityAi!);
            }
            else if (IsPlayht && playht != null)
            {
                return playht(Playht!);
            }
            else if (IsRimeAi && rimeAi != null)
            {
                return rimeAi(RimeAi!);
            }
            else if (IsRunpod && runpod != null)
            {
                return runpod(Runpod!);
            }
            else if (IsS3 && s3 != null)
            {
                return s3(S3!);
            }
            else if (IsSmallestAi && smallestAi != null)
            {
                return smallestAi(SmallestAi!);
            }
            else if (IsSpeechmatics && speechmatics != null)
            {
                return speechmatics(Speechmatics!);
            }
            else if (IsSoniox && soniox != null)
            {
                return soniox(Soniox!);
            }
            else if (IsSupabase && supabase != null)
            {
                return supabase(Supabase!);
            }
            else if (IsTavus && tavus != null)
            {
                return tavus(Tavus!);
            }
            else if (IsTogetherAi && togetherAi != null)
            {
                return togetherAi(TogetherAi!);
            }
            else if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsVonage && vonage != null)
            {
                return vonage(Vonage!);
            }
            else if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsCustomCredential && customCredential != null)
            {
                return customCredential(CustomCredential!);
            }
            else if (IsXai && xai != null)
            {
                return xai(Xai!);
            }
            else if (IsGoogleCalendarOauth2Client && googleCalendarOauth2Client != null)
            {
                return googleCalendarOauth2Client(GoogleCalendarOauth2Client!);
            }
            else if (IsGoogleCalendarOauth2Authorization && googleCalendarOauth2Authorization != null)
            {
                return googleCalendarOauth2Authorization(GoogleCalendarOauth2Authorization!);
            }
            else if (IsGoogleSheetsOauth2Authorization && googleSheetsOauth2Authorization != null)
            {
                return googleSheetsOauth2Authorization(GoogleSheetsOauth2Authorization!);
            }
            else if (IsSlackOauth2Authorization && slackOauth2Authorization != null)
            {
                return slackOauth2Authorization(SlackOauth2Authorization!);
            }
            else if (IsGhlOauth2Authorization && ghlOauth2Authorization != null)
            {
                return ghlOauth2Authorization(GhlOauth2Authorization!);
            }
            else if (IsInworld && inworld != null)
            {
                return inworld(Inworld!);
            }
            else if (IsMinimax && minimax != null)
            {
                return minimax(Minimax!);
            }
            else if (IsWellsaid && wellsaid != null)
            {
                return wellsaid(Wellsaid!);
            }
            else if (IsEmail && email != null)
            {
                return email(Email!);
            }
            else if (IsSlackWebhook && slackWebhook != null)
            {
                return slackWebhook(SlackWebhook!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.CreateAnthropicCredentialDTO?>? anthropic = null,
            global::System.Action<global::Vapi.CreateAnthropicBedrockCredentialDTO?>? anthropicBedrock = null,
            global::System.Action<global::Vapi.CreateAnyscaleCredentialDTO?>? anyscale = null,
            global::System.Action<global::Vapi.CreateAssemblyAICredentialDTO?>? assemblyAi = null,
            global::System.Action<global::Vapi.CreateAzureCredentialDTO?>? azure = null,
            global::System.Action<global::Vapi.CreateAzureOpenAICredentialDTO?>? azureOpenai = null,
            global::System.Action<global::Vapi.CreateByoSipTrunkCredentialDTO?>? byoSipTrunk = null,
            global::System.Action<global::Vapi.CreateCartesiaCredentialDTO?>? cartesia = null,
            global::System.Action<global::Vapi.CreateCerebrasCredentialDTO?>? cerebras = null,
            global::System.Action<global::Vapi.CreateCloudflareCredentialDTO?>? cloudflare = null,
            global::System.Action<global::Vapi.CreateCustomLLMCredentialDTO?>? customLlm = null,
            global::System.Action<global::Vapi.CreateDeepgramCredentialDTO?>? deepgram = null,
            global::System.Action<global::Vapi.CreateDeepInfraCredentialDTO?>? deepinfra = null,
            global::System.Action<global::Vapi.CreateDeepSeekCredentialDTO?>? deepSeek = null,
            global::System.Action<global::Vapi.CreateElevenLabsCredentialDTO?>? elevenlabs = null,
            global::System.Action<global::Vapi.CreateGcpCredentialDTO?>? gcp = null,
            global::System.Action<global::Vapi.CreateGladiaCredentialDTO?>? gladia = null,
            global::System.Action<global::Vapi.CreateGoHighLevelCredentialDTO?>? gohighlevel = null,
            global::System.Action<global::Vapi.CreateGoogleCredentialDTO?>? google = null,
            global::System.Action<global::Vapi.CreateGroqCredentialDTO?>? groq = null,
            global::System.Action<global::Vapi.CreateHumeCredentialDTO?>? hume = null,
            global::System.Action<global::Vapi.CreateInflectionAICredentialDTO?>? inflectionAi = null,
            global::System.Action<global::Vapi.CreateLangfuseCredentialDTO?>? langfuse = null,
            global::System.Action<global::Vapi.CreateLmntCredentialDTO?>? lmnt = null,
            global::System.Action<global::Vapi.CreateMakeCredentialDTO?>? make = null,
            global::System.Action<global::Vapi.CreateMistralCredentialDTO?>? mistral = null,
            global::System.Action<global::Vapi.CreateNeuphonicCredentialDTO?>? neuphonic = null,
            global::System.Action<global::Vapi.CreateOpenAICredentialDTO?>? openai = null,
            global::System.Action<global::Vapi.CreateOpenRouterCredentialDTO?>? openrouter = null,
            global::System.Action<global::Vapi.CreatePerplexityAICredentialDTO?>? perplexityAi = null,
            global::System.Action<global::Vapi.CreatePlayHTCredentialDTO?>? playht = null,
            global::System.Action<global::Vapi.CreateRimeAICredentialDTO?>? rimeAi = null,
            global::System.Action<global::Vapi.CreateRunpodCredentialDTO?>? runpod = null,
            global::System.Action<global::Vapi.CreateS3CredentialDTO?>? s3 = null,
            global::System.Action<global::Vapi.CreateSmallestAICredentialDTO?>? smallestAi = null,
            global::System.Action<global::Vapi.CreateSpeechmaticsCredentialDTO?>? speechmatics = null,
            global::System.Action<global::Vapi.CreateSonioxCredentialDTO?>? soniox = null,
            global::System.Action<global::Vapi.CreateSupabaseCredentialDTO?>? supabase = null,
            global::System.Action<global::Vapi.CreateTavusCredentialDTO?>? tavus = null,
            global::System.Action<global::Vapi.CreateTogetherAICredentialDTO?>? togetherAi = null,
            global::System.Action<global::Vapi.CreateTwilioCredentialDTO?>? twilio = null,
            global::System.Action<global::Vapi.CreateVonageCredentialDTO?>? vonage = null,
            global::System.Action<global::Vapi.CreateWebhookCredentialDTO?>? webhook = null,
            global::System.Action<global::Vapi.CreateCustomCredentialDTO?>? customCredential = null,
            global::System.Action<global::Vapi.CreateXAiCredentialDTO?>? xai = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?>? googleCalendarOauth2Client = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?>? googleCalendarOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?>? googleSheetsOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?>? slackOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateGoHighLevelMCPCredentialDTO?>? ghlOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateInworldCredentialDTO?>? inworld = null,
            global::System.Action<global::Vapi.CreateMinimaxCredentialDTO?>? minimax = null,
            global::System.Action<global::Vapi.CreateWellSaidCredentialDTO?>? wellsaid = null,
            global::System.Action<global::Vapi.CreateEmailCredentialDTO?>? email = null,
            global::System.Action<global::Vapi.CreateSlackWebhookCredentialDTO?>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropic)
            {
                anthropic?.Invoke(Anthropic!);
            }
            else if (IsAnthropicBedrock)
            {
                anthropicBedrock?.Invoke(AnthropicBedrock!);
            }
            else if (IsAnyscale)
            {
                anyscale?.Invoke(Anyscale!);
            }
            else if (IsAssemblyAi)
            {
                assemblyAi?.Invoke(AssemblyAi!);
            }
            else if (IsAzure)
            {
                azure?.Invoke(Azure!);
            }
            else if (IsAzureOpenai)
            {
                azureOpenai?.Invoke(AzureOpenai!);
            }
            else if (IsByoSipTrunk)
            {
                byoSipTrunk?.Invoke(ByoSipTrunk!);
            }
            else if (IsCartesia)
            {
                cartesia?.Invoke(Cartesia!);
            }
            else if (IsCerebras)
            {
                cerebras?.Invoke(Cerebras!);
            }
            else if (IsCloudflare)
            {
                cloudflare?.Invoke(Cloudflare!);
            }
            else if (IsCustomLlm)
            {
                customLlm?.Invoke(CustomLlm!);
            }
            else if (IsDeepgram)
            {
                deepgram?.Invoke(Deepgram!);
            }
            else if (IsDeepinfra)
            {
                deepinfra?.Invoke(Deepinfra!);
            }
            else if (IsDeepSeek)
            {
                deepSeek?.Invoke(DeepSeek!);
            }
            else if (IsElevenlabs)
            {
                elevenlabs?.Invoke(Elevenlabs!);
            }
            else if (IsGcp)
            {
                gcp?.Invoke(Gcp!);
            }
            else if (IsGladia)
            {
                gladia?.Invoke(Gladia!);
            }
            else if (IsGohighlevel)
            {
                gohighlevel?.Invoke(Gohighlevel!);
            }
            else if (IsGoogle)
            {
                google?.Invoke(Google!);
            }
            else if (IsGroq)
            {
                groq?.Invoke(Groq!);
            }
            else if (IsHume)
            {
                hume?.Invoke(Hume!);
            }
            else if (IsInflectionAi)
            {
                inflectionAi?.Invoke(InflectionAi!);
            }
            else if (IsLangfuse)
            {
                langfuse?.Invoke(Langfuse!);
            }
            else if (IsLmnt)
            {
                lmnt?.Invoke(Lmnt!);
            }
            else if (IsMake)
            {
                make?.Invoke(Make!);
            }
            else if (IsMistral)
            {
                mistral?.Invoke(Mistral!);
            }
            else if (IsNeuphonic)
            {
                neuphonic?.Invoke(Neuphonic!);
            }
            else if (IsOpenai)
            {
                openai?.Invoke(Openai!);
            }
            else if (IsOpenrouter)
            {
                openrouter?.Invoke(Openrouter!);
            }
            else if (IsPerplexityAi)
            {
                perplexityAi?.Invoke(PerplexityAi!);
            }
            else if (IsPlayht)
            {
                playht?.Invoke(Playht!);
            }
            else if (IsRimeAi)
            {
                rimeAi?.Invoke(RimeAi!);
            }
            else if (IsRunpod)
            {
                runpod?.Invoke(Runpod!);
            }
            else if (IsS3)
            {
                s3?.Invoke(S3!);
            }
            else if (IsSmallestAi)
            {
                smallestAi?.Invoke(SmallestAi!);
            }
            else if (IsSpeechmatics)
            {
                speechmatics?.Invoke(Speechmatics!);
            }
            else if (IsSoniox)
            {
                soniox?.Invoke(Soniox!);
            }
            else if (IsSupabase)
            {
                supabase?.Invoke(Supabase!);
            }
            else if (IsTavus)
            {
                tavus?.Invoke(Tavus!);
            }
            else if (IsTogetherAi)
            {
                togetherAi?.Invoke(TogetherAi!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsCustomCredential)
            {
                customCredential?.Invoke(CustomCredential!);
            }
            else if (IsXai)
            {
                xai?.Invoke(Xai!);
            }
            else if (IsGoogleCalendarOauth2Client)
            {
                googleCalendarOauth2Client?.Invoke(GoogleCalendarOauth2Client!);
            }
            else if (IsGoogleCalendarOauth2Authorization)
            {
                googleCalendarOauth2Authorization?.Invoke(GoogleCalendarOauth2Authorization!);
            }
            else if (IsGoogleSheetsOauth2Authorization)
            {
                googleSheetsOauth2Authorization?.Invoke(GoogleSheetsOauth2Authorization!);
            }
            else if (IsSlackOauth2Authorization)
            {
                slackOauth2Authorization?.Invoke(SlackOauth2Authorization!);
            }
            else if (IsGhlOauth2Authorization)
            {
                ghlOauth2Authorization?.Invoke(GhlOauth2Authorization!);
            }
            else if (IsInworld)
            {
                inworld?.Invoke(Inworld!);
            }
            else if (IsMinimax)
            {
                minimax?.Invoke(Minimax!);
            }
            else if (IsWellsaid)
            {
                wellsaid?.Invoke(Wellsaid!);
            }
            else if (IsEmail)
            {
                email?.Invoke(Email!);
            }
            else if (IsSlackWebhook)
            {
                slackWebhook?.Invoke(SlackWebhook!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Anthropic,
                typeof(global::Vapi.CreateAnthropicCredentialDTO),
                AnthropicBedrock,
                typeof(global::Vapi.CreateAnthropicBedrockCredentialDTO),
                Anyscale,
                typeof(global::Vapi.CreateAnyscaleCredentialDTO),
                AssemblyAi,
                typeof(global::Vapi.CreateAssemblyAICredentialDTO),
                Azure,
                typeof(global::Vapi.CreateAzureCredentialDTO),
                AzureOpenai,
                typeof(global::Vapi.CreateAzureOpenAICredentialDTO),
                ByoSipTrunk,
                typeof(global::Vapi.CreateByoSipTrunkCredentialDTO),
                Cartesia,
                typeof(global::Vapi.CreateCartesiaCredentialDTO),
                Cerebras,
                typeof(global::Vapi.CreateCerebrasCredentialDTO),
                Cloudflare,
                typeof(global::Vapi.CreateCloudflareCredentialDTO),
                CustomLlm,
                typeof(global::Vapi.CreateCustomLLMCredentialDTO),
                Deepgram,
                typeof(global::Vapi.CreateDeepgramCredentialDTO),
                Deepinfra,
                typeof(global::Vapi.CreateDeepInfraCredentialDTO),
                DeepSeek,
                typeof(global::Vapi.CreateDeepSeekCredentialDTO),
                Elevenlabs,
                typeof(global::Vapi.CreateElevenLabsCredentialDTO),
                Gcp,
                typeof(global::Vapi.CreateGcpCredentialDTO),
                Gladia,
                typeof(global::Vapi.CreateGladiaCredentialDTO),
                Gohighlevel,
                typeof(global::Vapi.CreateGoHighLevelCredentialDTO),
                Google,
                typeof(global::Vapi.CreateGoogleCredentialDTO),
                Groq,
                typeof(global::Vapi.CreateGroqCredentialDTO),
                Hume,
                typeof(global::Vapi.CreateHumeCredentialDTO),
                InflectionAi,
                typeof(global::Vapi.CreateInflectionAICredentialDTO),
                Langfuse,
                typeof(global::Vapi.CreateLangfuseCredentialDTO),
                Lmnt,
                typeof(global::Vapi.CreateLmntCredentialDTO),
                Make,
                typeof(global::Vapi.CreateMakeCredentialDTO),
                Mistral,
                typeof(global::Vapi.CreateMistralCredentialDTO),
                Neuphonic,
                typeof(global::Vapi.CreateNeuphonicCredentialDTO),
                Openai,
                typeof(global::Vapi.CreateOpenAICredentialDTO),
                Openrouter,
                typeof(global::Vapi.CreateOpenRouterCredentialDTO),
                PerplexityAi,
                typeof(global::Vapi.CreatePerplexityAICredentialDTO),
                Playht,
                typeof(global::Vapi.CreatePlayHTCredentialDTO),
                RimeAi,
                typeof(global::Vapi.CreateRimeAICredentialDTO),
                Runpod,
                typeof(global::Vapi.CreateRunpodCredentialDTO),
                S3,
                typeof(global::Vapi.CreateS3CredentialDTO),
                SmallestAi,
                typeof(global::Vapi.CreateSmallestAICredentialDTO),
                Speechmatics,
                typeof(global::Vapi.CreateSpeechmaticsCredentialDTO),
                Soniox,
                typeof(global::Vapi.CreateSonioxCredentialDTO),
                Supabase,
                typeof(global::Vapi.CreateSupabaseCredentialDTO),
                Tavus,
                typeof(global::Vapi.CreateTavusCredentialDTO),
                TogetherAi,
                typeof(global::Vapi.CreateTogetherAICredentialDTO),
                Twilio,
                typeof(global::Vapi.CreateTwilioCredentialDTO),
                Vonage,
                typeof(global::Vapi.CreateVonageCredentialDTO),
                Webhook,
                typeof(global::Vapi.CreateWebhookCredentialDTO),
                CustomCredential,
                typeof(global::Vapi.CreateCustomCredentialDTO),
                Xai,
                typeof(global::Vapi.CreateXAiCredentialDTO),
                GoogleCalendarOauth2Client,
                typeof(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO),
                GoogleCalendarOauth2Authorization,
                typeof(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO),
                GoogleSheetsOauth2Authorization,
                typeof(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO),
                SlackOauth2Authorization,
                typeof(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO),
                GhlOauth2Authorization,
                typeof(global::Vapi.CreateGoHighLevelMCPCredentialDTO),
                Inworld,
                typeof(global::Vapi.CreateInworldCredentialDTO),
                Minimax,
                typeof(global::Vapi.CreateMinimaxCredentialDTO),
                Wellsaid,
                typeof(global::Vapi.CreateWellSaidCredentialDTO),
                Email,
                typeof(global::Vapi.CreateEmailCredentialDTO),
                SlackWebhook,
                typeof(global::Vapi.CreateSlackWebhookCredentialDTO),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CredentialsItem7 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAnthropicCredentialDTO?>.Default.Equals(Anthropic, other.Anthropic) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAnthropicBedrockCredentialDTO?>.Default.Equals(AnthropicBedrock, other.AnthropicBedrock) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAnyscaleCredentialDTO?>.Default.Equals(Anyscale, other.Anyscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAssemblyAICredentialDTO?>.Default.Equals(AssemblyAi, other.AssemblyAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAzureCredentialDTO?>.Default.Equals(Azure, other.Azure) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateAzureOpenAICredentialDTO?>.Default.Equals(AzureOpenai, other.AzureOpenai) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateByoSipTrunkCredentialDTO?>.Default.Equals(ByoSipTrunk, other.ByoSipTrunk) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCartesiaCredentialDTO?>.Default.Equals(Cartesia, other.Cartesia) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCerebrasCredentialDTO?>.Default.Equals(Cerebras, other.Cerebras) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCloudflareCredentialDTO?>.Default.Equals(Cloudflare, other.Cloudflare) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCustomLLMCredentialDTO?>.Default.Equals(CustomLlm, other.CustomLlm) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateDeepgramCredentialDTO?>.Default.Equals(Deepgram, other.Deepgram) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateDeepInfraCredentialDTO?>.Default.Equals(Deepinfra, other.Deepinfra) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateDeepSeekCredentialDTO?>.Default.Equals(DeepSeek, other.DeepSeek) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateElevenLabsCredentialDTO?>.Default.Equals(Elevenlabs, other.Elevenlabs) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGcpCredentialDTO?>.Default.Equals(Gcp, other.Gcp) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGladiaCredentialDTO?>.Default.Equals(Gladia, other.Gladia) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelCredentialDTO?>.Default.Equals(Gohighlevel, other.Gohighlevel) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleCredentialDTO?>.Default.Equals(Google, other.Google) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGroqCredentialDTO?>.Default.Equals(Groq, other.Groq) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateHumeCredentialDTO?>.Default.Equals(Hume, other.Hume) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateInflectionAICredentialDTO?>.Default.Equals(InflectionAi, other.InflectionAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateLangfuseCredentialDTO?>.Default.Equals(Langfuse, other.Langfuse) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateLmntCredentialDTO?>.Default.Equals(Lmnt, other.Lmnt) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateMakeCredentialDTO?>.Default.Equals(Make, other.Make) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateMistralCredentialDTO?>.Default.Equals(Mistral, other.Mistral) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateNeuphonicCredentialDTO?>.Default.Equals(Neuphonic, other.Neuphonic) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateOpenAICredentialDTO?>.Default.Equals(Openai, other.Openai) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateOpenRouterCredentialDTO?>.Default.Equals(Openrouter, other.Openrouter) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreatePerplexityAICredentialDTO?>.Default.Equals(PerplexityAi, other.PerplexityAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreatePlayHTCredentialDTO?>.Default.Equals(Playht, other.Playht) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateRimeAICredentialDTO?>.Default.Equals(RimeAi, other.RimeAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateRunpodCredentialDTO?>.Default.Equals(Runpod, other.Runpod) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateS3CredentialDTO?>.Default.Equals(S3, other.S3) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSmallestAICredentialDTO?>.Default.Equals(SmallestAi, other.SmallestAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSpeechmaticsCredentialDTO?>.Default.Equals(Speechmatics, other.Speechmatics) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSonioxCredentialDTO?>.Default.Equals(Soniox, other.Soniox) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSupabaseCredentialDTO?>.Default.Equals(Supabase, other.Supabase) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTavusCredentialDTO?>.Default.Equals(Tavus, other.Tavus) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTogetherAICredentialDTO?>.Default.Equals(TogetherAi, other.TogetherAi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTwilioCredentialDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateVonageCredentialDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateWebhookCredentialDTO?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateCustomCredentialDTO?>.Default.Equals(CustomCredential, other.CustomCredential) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateXAiCredentialDTO?>.Default.Equals(Xai, other.Xai) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?>.Default.Equals(GoogleCalendarOauth2Client, other.GoogleCalendarOauth2Client) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?>.Default.Equals(GoogleCalendarOauth2Authorization, other.GoogleCalendarOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?>.Default.Equals(GoogleSheetsOauth2Authorization, other.GoogleSheetsOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?>.Default.Equals(SlackOauth2Authorization, other.SlackOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateGoHighLevelMCPCredentialDTO?>.Default.Equals(GhlOauth2Authorization, other.GhlOauth2Authorization) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateInworldCredentialDTO?>.Default.Equals(Inworld, other.Inworld) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateMinimaxCredentialDTO?>.Default.Equals(Minimax, other.Minimax) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateWellSaidCredentialDTO?>.Default.Equals(Wellsaid, other.Wellsaid) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateEmailCredentialDTO?>.Default.Equals(Email, other.Email) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateSlackWebhookCredentialDTO?>.Default.Equals(SlackWebhook, other.SlackWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CredentialsItem7 obj1, CredentialsItem7 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CredentialsItem7>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CredentialsItem7 obj1, CredentialsItem7 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CredentialsItem7 o && Equals(o);
        }
    }
}
