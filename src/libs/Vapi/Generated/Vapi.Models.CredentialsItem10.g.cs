#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CredentialsItem10 : global::System.IEquatable<CredentialsItem10>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.WorkflowCredentialDiscriminatorProvider? Provider { get; }

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
        public bool TryPickAnthropic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAnthropicCredentialDTO? value)
        {
            value = Anthropic;
            return IsAnthropic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicCredentialDTO PickAnthropic() => Anthropic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anthropic' but the value was {ToString()}.");

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
        public bool TryPickAnthropicBedrock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAnthropicBedrockCredentialDTO? value)
        {
            value = AnthropicBedrock;
            return IsAnthropicBedrock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnthropicBedrockCredentialDTO PickAnthropicBedrock() => AnthropicBedrock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicBedrock' but the value was {ToString()}.");

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
        public bool TryPickAnyscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAnyscaleCredentialDTO? value)
        {
            value = Anyscale;
            return IsAnyscale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAnyscaleCredentialDTO PickAnyscale() => Anyscale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Anyscale' but the value was {ToString()}.");

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
        public bool TryPickAssemblyAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAssemblyAICredentialDTO? value)
        {
            value = AssemblyAi;
            return IsAssemblyAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAssemblyAICredentialDTO PickAssemblyAi() => AssemblyAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssemblyAi' but the value was {ToString()}.");

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
        public bool TryPickAzure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAzureCredentialDTO? value)
        {
            value = Azure;
            return IsAzure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureCredentialDTO PickAzure() => Azure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Azure' but the value was {ToString()}.");

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
        public bool TryPickAzureOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateAzureOpenAICredentialDTO? value)
        {
            value = AzureOpenai;
            return IsAzureOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateAzureOpenAICredentialDTO PickAzureOpenai() => AzureOpenai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AzureOpenai' but the value was {ToString()}.");

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
        public bool TryPickByoSipTrunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateByoSipTrunkCredentialDTO? value)
        {
            value = ByoSipTrunk;
            return IsByoSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateByoSipTrunkCredentialDTO PickByoSipTrunk() => ByoSipTrunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ByoSipTrunk' but the value was {ToString()}.");

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
        public bool TryPickCartesia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateCartesiaCredentialDTO? value)
        {
            value = Cartesia;
            return IsCartesia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCartesiaCredentialDTO PickCartesia() => Cartesia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cartesia' but the value was {ToString()}.");

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
        public bool TryPickCerebras(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateCerebrasCredentialDTO? value)
        {
            value = Cerebras;
            return IsCerebras;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCerebrasCredentialDTO PickCerebras() => Cerebras is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cerebras' but the value was {ToString()}.");

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
        public bool TryPickCloudflare(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateCloudflareCredentialDTO? value)
        {
            value = Cloudflare;
            return IsCloudflare;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCloudflareCredentialDTO PickCloudflare() => Cloudflare is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Cloudflare' but the value was {ToString()}.");

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
        public bool TryPickCustomLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateCustomLLMCredentialDTO? value)
        {
            value = CustomLlm;
            return IsCustomLlm;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomLLMCredentialDTO PickCustomLlm() => CustomLlm is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomLlm' but the value was {ToString()}.");

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
        public bool TryPickDeepgram(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateDeepgramCredentialDTO? value)
        {
            value = Deepgram;
            return IsDeepgram;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepgramCredentialDTO PickDeepgram() => Deepgram is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deepgram' but the value was {ToString()}.");

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
        public bool TryPickDeepinfra(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateDeepInfraCredentialDTO? value)
        {
            value = Deepinfra;
            return IsDeepinfra;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepInfraCredentialDTO PickDeepinfra() => Deepinfra is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Deepinfra' but the value was {ToString()}.");

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
        public bool TryPickDeepSeek(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateDeepSeekCredentialDTO? value)
        {
            value = DeepSeek;
            return IsDeepSeek;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateDeepSeekCredentialDTO PickDeepSeek() => DeepSeek is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeepSeek' but the value was {ToString()}.");

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
        public bool TryPickElevenlabs(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateElevenLabsCredentialDTO? value)
        {
            value = Elevenlabs;
            return IsElevenlabs;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateElevenLabsCredentialDTO PickElevenlabs() => Elevenlabs is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Elevenlabs' but the value was {ToString()}.");

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
        public bool TryPickGcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGcpCredentialDTO? value)
        {
            value = Gcp;
            return IsGcp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGcpCredentialDTO PickGcp() => Gcp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gcp' but the value was {ToString()}.");

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
        public bool TryPickGladia(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGladiaCredentialDTO? value)
        {
            value = Gladia;
            return IsGladia;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGladiaCredentialDTO PickGladia() => Gladia is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gladia' but the value was {ToString()}.");

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
        public bool TryPickGohighlevel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoHighLevelCredentialDTO? value)
        {
            value = Gohighlevel;
            return IsGohighlevel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelCredentialDTO PickGohighlevel() => Gohighlevel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Gohighlevel' but the value was {ToString()}.");

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
        public bool TryPickGoogle(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoogleCredentialDTO? value)
        {
            value = Google;
            return IsGoogle;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCredentialDTO PickGoogle() => Google is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Google' but the value was {ToString()}.");

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
        public bool TryPickGroq(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGroqCredentialDTO? value)
        {
            value = Groq;
            return IsGroq;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGroqCredentialDTO PickGroq() => Groq is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Groq' but the value was {ToString()}.");

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
        public bool TryPickHume(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateHumeCredentialDTO? value)
        {
            value = Hume;
            return IsHume;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateHumeCredentialDTO PickHume() => Hume is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Hume' but the value was {ToString()}.");

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
        public bool TryPickInflectionAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateInflectionAICredentialDTO? value)
        {
            value = InflectionAi;
            return IsInflectionAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInflectionAICredentialDTO PickInflectionAi() => InflectionAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InflectionAi' but the value was {ToString()}.");

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
        public bool TryPickLangfuse(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateLangfuseCredentialDTO? value)
        {
            value = Langfuse;
            return IsLangfuse;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLangfuseCredentialDTO PickLangfuse() => Langfuse is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Langfuse' but the value was {ToString()}.");

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
        public bool TryPickLmnt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateLmntCredentialDTO? value)
        {
            value = Lmnt;
            return IsLmnt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateLmntCredentialDTO PickLmnt() => Lmnt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Lmnt' but the value was {ToString()}.");

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
        public bool TryPickMake(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateMakeCredentialDTO? value)
        {
            value = Make;
            return IsMake;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMakeCredentialDTO PickMake() => Make is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Make' but the value was {ToString()}.");

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
        public bool TryPickMistral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateMistralCredentialDTO? value)
        {
            value = Mistral;
            return IsMistral;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMistralCredentialDTO PickMistral() => Mistral is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mistral' but the value was {ToString()}.");

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
        public bool TryPickNeuphonic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateNeuphonicCredentialDTO? value)
        {
            value = Neuphonic;
            return IsNeuphonic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateNeuphonicCredentialDTO PickNeuphonic() => Neuphonic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Neuphonic' but the value was {ToString()}.");

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
        public bool TryPickOpenai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateOpenAICredentialDTO? value)
        {
            value = Openai;
            return IsOpenai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenAICredentialDTO PickOpenai() => Openai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openai' but the value was {ToString()}.");

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
        public bool TryPickOpenrouter(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateOpenRouterCredentialDTO? value)
        {
            value = Openrouter;
            return IsOpenrouter;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateOpenRouterCredentialDTO PickOpenrouter() => Openrouter is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Openrouter' but the value was {ToString()}.");

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
        public bool TryPickPerplexityAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreatePerplexityAICredentialDTO? value)
        {
            value = PerplexityAi;
            return IsPerplexityAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePerplexityAICredentialDTO PickPerplexityAi() => PerplexityAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PerplexityAi' but the value was {ToString()}.");

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
        public bool TryPickPlayht(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreatePlayHTCredentialDTO? value)
        {
            value = Playht;
            return IsPlayht;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreatePlayHTCredentialDTO PickPlayht() => Playht is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Playht' but the value was {ToString()}.");

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
        public bool TryPickRimeAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateRimeAICredentialDTO? value)
        {
            value = RimeAi;
            return IsRimeAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRimeAICredentialDTO PickRimeAi() => RimeAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RimeAi' but the value was {ToString()}.");

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
        public bool TryPickRunpod(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateRunpodCredentialDTO? value)
        {
            value = Runpod;
            return IsRunpod;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateRunpodCredentialDTO PickRunpod() => Runpod is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Runpod' but the value was {ToString()}.");

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
        public bool TryPickS3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateS3CredentialDTO? value)
        {
            value = S3;
            return IsS3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CredentialDTO PickS3() => S3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateS3CompatibleCredentialDTO? S3Compatible { get; init; }
#else
        public global::Vapi.CreateS3CompatibleCredentialDTO? S3Compatible { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(S3Compatible))]
#endif
        public bool IsS3Compatible => S3Compatible != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickS3Compatible(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateS3CompatibleCredentialDTO? value)
        {
            value = S3Compatible;
            return IsS3Compatible;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateS3CompatibleCredentialDTO PickS3Compatible() => S3Compatible is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'S3Compatible' but the value was {ToString()}.");

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
        public bool TryPickSmallestAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSmallestAICredentialDTO? value)
        {
            value = SmallestAi;
            return IsSmallestAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSmallestAICredentialDTO PickSmallestAi() => SmallestAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SmallestAi' but the value was {ToString()}.");

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
        public bool TryPickSpeechmatics(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSpeechmaticsCredentialDTO? value)
        {
            value = Speechmatics;
            return IsSpeechmatics;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSpeechmaticsCredentialDTO PickSpeechmatics() => Speechmatics is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Speechmatics' but the value was {ToString()}.");

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
        public bool TryPickSoniox(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSonioxCredentialDTO? value)
        {
            value = Soniox;
            return IsSoniox;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSonioxCredentialDTO PickSoniox() => Soniox is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Soniox' but the value was {ToString()}.");

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
        public bool TryPickSupabase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSupabaseCredentialDTO? value)
        {
            value = Supabase;
            return IsSupabase;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSupabaseCredentialDTO PickSupabase() => Supabase is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Supabase' but the value was {ToString()}.");

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
        public bool TryPickTavus(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateTavusCredentialDTO? value)
        {
            value = Tavus;
            return IsTavus;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTavusCredentialDTO PickTavus() => Tavus is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tavus' but the value was {ToString()}.");

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
        public bool TryPickTogetherAi(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateTogetherAICredentialDTO? value)
        {
            value = TogetherAi;
            return IsTogetherAi;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTogetherAICredentialDTO PickTogetherAi() => TogetherAi is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TogetherAi' but the value was {ToString()}.");

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
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateTwilioCredentialDTO? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateTwilioCredentialDTO PickTwilio() => Twilio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

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
        public bool TryPickVonage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateVonageCredentialDTO? value)
        {
            value = Vonage;
            return IsVonage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateVonageCredentialDTO PickVonage() => Vonage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Vonage' but the value was {ToString()}.");

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
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateWebhookCredentialDTO? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWebhookCredentialDTO PickWebhook() => Webhook is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

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
        public bool TryPickCustomCredential(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateCustomCredentialDTO? value)
        {
            value = CustomCredential;
            return IsCustomCredential;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateCustomCredentialDTO PickCustomCredential() => CustomCredential is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CustomCredential' but the value was {ToString()}.");

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
        public bool TryPickXai(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateXAiCredentialDTO? value)
        {
            value = Xai;
            return IsXai;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateXAiCredentialDTO PickXai() => Xai is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Xai' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateMicrosoftCredentialDTO? Microsoft { get; init; }
#else
        public global::Vapi.CreateMicrosoftCredentialDTO? Microsoft { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Microsoft))]
#endif
        public bool IsMicrosoft => Microsoft != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMicrosoft(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateMicrosoftCredentialDTO? value)
        {
            value = Microsoft;
            return IsMicrosoft;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMicrosoftCredentialDTO PickMicrosoft() => Microsoft is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Microsoft' but the value was {ToString()}.");

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
        public bool TryPickGoogleCalendarOauth2Client(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? value)
        {
            value = GoogleCalendarOauth2Client;
            return IsGoogleCalendarOauth2Client;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO PickGoogleCalendarOauth2Client() => GoogleCalendarOauth2Client is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarOauth2Client' but the value was {ToString()}.");

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
        public bool TryPickGoogleCalendarOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value)
        {
            value = GoogleCalendarOauth2Authorization;
            return IsGoogleCalendarOauth2Authorization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO PickGoogleCalendarOauth2Authorization() => GoogleCalendarOauth2Authorization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleCalendarOauth2Authorization' but the value was {ToString()}.");

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
        public bool TryPickGoogleSheetsOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value)
        {
            value = GoogleSheetsOauth2Authorization;
            return IsGoogleSheetsOauth2Authorization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO PickGoogleSheetsOauth2Authorization() => GoogleSheetsOauth2Authorization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GoogleSheetsOauth2Authorization' but the value was {ToString()}.");

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
        public bool TryPickSlackOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? value)
        {
            value = SlackOauth2Authorization;
            return IsSlackOauth2Authorization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO PickSlackOauth2Authorization() => SlackOauth2Authorization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackOauth2Authorization' but the value was {ToString()}.");

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
        public bool TryPickGhlOauth2Authorization(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateGoHighLevelMCPCredentialDTO? value)
        {
            value = GhlOauth2Authorization;
            return IsGhlOauth2Authorization;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateGoHighLevelMCPCredentialDTO PickGhlOauth2Authorization() => GhlOauth2Authorization is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GhlOauth2Authorization' but the value was {ToString()}.");

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
        public bool TryPickInworld(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateInworldCredentialDTO? value)
        {
            value = Inworld;
            return IsInworld;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateInworldCredentialDTO PickInworld() => Inworld is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Inworld' but the value was {ToString()}.");

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
        public bool TryPickMinimax(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateMinimaxCredentialDTO? value)
        {
            value = Minimax;
            return IsMinimax;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateMinimaxCredentialDTO PickMinimax() => Minimax is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Minimax' but the value was {ToString()}.");

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
        public bool TryPickWellsaid(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateWellSaidCredentialDTO? value)
        {
            value = Wellsaid;
            return IsWellsaid;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateWellSaidCredentialDTO PickWellsaid() => Wellsaid is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Wellsaid' but the value was {ToString()}.");

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
        public bool TryPickEmail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateEmailCredentialDTO? value)
        {
            value = Email;
            return IsEmail;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateEmailCredentialDTO PickEmail() => Email is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Email' but the value was {ToString()}.");

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
        public bool TryPickSlackWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.CreateSlackWebhookCredentialDTO? value)
        {
            value = SlackWebhook;
            return IsSlackWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.CreateSlackWebhookCredentialDTO PickSlackWebhook() => SlackWebhook is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SlackWebhook' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAnthropicCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAnthropicCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAnthropicCredentialDTO?(CredentialsItem10 @this) => @this.Anthropic;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAnthropicCredentialDTO? value)
        {
            Anthropic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAnthropic(global::Vapi.CreateAnthropicCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAnthropicBedrockCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAnthropicBedrockCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAnthropicBedrockCredentialDTO?(CredentialsItem10 @this) => @this.AnthropicBedrock;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAnthropicBedrockCredentialDTO? value)
        {
            AnthropicBedrock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAnthropicBedrock(global::Vapi.CreateAnthropicBedrockCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAnyscaleCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAnyscaleCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAnyscaleCredentialDTO?(CredentialsItem10 @this) => @this.Anyscale;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAnyscaleCredentialDTO? value)
        {
            Anyscale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAnyscale(global::Vapi.CreateAnyscaleCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAssemblyAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAssemblyAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAssemblyAICredentialDTO?(CredentialsItem10 @this) => @this.AssemblyAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAssemblyAICredentialDTO? value)
        {
            AssemblyAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAssemblyAi(global::Vapi.CreateAssemblyAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAzureCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAzureCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAzureCredentialDTO?(CredentialsItem10 @this) => @this.Azure;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAzureCredentialDTO? value)
        {
            Azure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAzure(global::Vapi.CreateAzureCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateAzureOpenAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateAzureOpenAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateAzureOpenAICredentialDTO?(CredentialsItem10 @this) => @this.AzureOpenai;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateAzureOpenAICredentialDTO? value)
        {
            AzureOpenai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromAzureOpenai(global::Vapi.CreateAzureOpenAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateByoSipTrunkCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateByoSipTrunkCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateByoSipTrunkCredentialDTO?(CredentialsItem10 @this) => @this.ByoSipTrunk;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateByoSipTrunkCredentialDTO? value)
        {
            ByoSipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromByoSipTrunk(global::Vapi.CreateByoSipTrunkCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateCartesiaCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateCartesiaCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateCartesiaCredentialDTO?(CredentialsItem10 @this) => @this.Cartesia;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateCartesiaCredentialDTO? value)
        {
            Cartesia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromCartesia(global::Vapi.CreateCartesiaCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateCerebrasCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateCerebrasCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateCerebrasCredentialDTO?(CredentialsItem10 @this) => @this.Cerebras;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateCerebrasCredentialDTO? value)
        {
            Cerebras = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromCerebras(global::Vapi.CreateCerebrasCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateCloudflareCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateCloudflareCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateCloudflareCredentialDTO?(CredentialsItem10 @this) => @this.Cloudflare;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateCloudflareCredentialDTO? value)
        {
            Cloudflare = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromCloudflare(global::Vapi.CreateCloudflareCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateCustomLLMCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateCustomLLMCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateCustomLLMCredentialDTO?(CredentialsItem10 @this) => @this.CustomLlm;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateCustomLLMCredentialDTO? value)
        {
            CustomLlm = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromCustomLlm(global::Vapi.CreateCustomLLMCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateDeepgramCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateDeepgramCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepgramCredentialDTO?(CredentialsItem10 @this) => @this.Deepgram;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateDeepgramCredentialDTO? value)
        {
            Deepgram = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromDeepgram(global::Vapi.CreateDeepgramCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateDeepInfraCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateDeepInfraCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepInfraCredentialDTO?(CredentialsItem10 @this) => @this.Deepinfra;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateDeepInfraCredentialDTO? value)
        {
            Deepinfra = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromDeepinfra(global::Vapi.CreateDeepInfraCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateDeepSeekCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateDeepSeekCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateDeepSeekCredentialDTO?(CredentialsItem10 @this) => @this.DeepSeek;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateDeepSeekCredentialDTO? value)
        {
            DeepSeek = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromDeepSeek(global::Vapi.CreateDeepSeekCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateElevenLabsCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateElevenLabsCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateElevenLabsCredentialDTO?(CredentialsItem10 @this) => @this.Elevenlabs;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateElevenLabsCredentialDTO? value)
        {
            Elevenlabs = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromElevenlabs(global::Vapi.CreateElevenLabsCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGcpCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGcpCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGcpCredentialDTO?(CredentialsItem10 @this) => @this.Gcp;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGcpCredentialDTO? value)
        {
            Gcp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGcp(global::Vapi.CreateGcpCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGladiaCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGladiaCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGladiaCredentialDTO?(CredentialsItem10 @this) => @this.Gladia;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGladiaCredentialDTO? value)
        {
            Gladia = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGladia(global::Vapi.CreateGladiaCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoHighLevelCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoHighLevelCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelCredentialDTO?(CredentialsItem10 @this) => @this.Gohighlevel;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoHighLevelCredentialDTO? value)
        {
            Gohighlevel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGohighlevel(global::Vapi.CreateGoHighLevelCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoogleCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoogleCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCredentialDTO?(CredentialsItem10 @this) => @this.Google;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoogleCredentialDTO? value)
        {
            Google = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGoogle(global::Vapi.CreateGoogleCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGroqCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGroqCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGroqCredentialDTO?(CredentialsItem10 @this) => @this.Groq;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGroqCredentialDTO? value)
        {
            Groq = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGroq(global::Vapi.CreateGroqCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateHumeCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateHumeCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateHumeCredentialDTO?(CredentialsItem10 @this) => @this.Hume;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateHumeCredentialDTO? value)
        {
            Hume = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromHume(global::Vapi.CreateHumeCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateInflectionAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateInflectionAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateInflectionAICredentialDTO?(CredentialsItem10 @this) => @this.InflectionAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateInflectionAICredentialDTO? value)
        {
            InflectionAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromInflectionAi(global::Vapi.CreateInflectionAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateLangfuseCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateLangfuseCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateLangfuseCredentialDTO?(CredentialsItem10 @this) => @this.Langfuse;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateLangfuseCredentialDTO? value)
        {
            Langfuse = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromLangfuse(global::Vapi.CreateLangfuseCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateLmntCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateLmntCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateLmntCredentialDTO?(CredentialsItem10 @this) => @this.Lmnt;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateLmntCredentialDTO? value)
        {
            Lmnt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromLmnt(global::Vapi.CreateLmntCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateMakeCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateMakeCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateMakeCredentialDTO?(CredentialsItem10 @this) => @this.Make;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateMakeCredentialDTO? value)
        {
            Make = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromMake(global::Vapi.CreateMakeCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateMistralCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateMistralCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateMistralCredentialDTO?(CredentialsItem10 @this) => @this.Mistral;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateMistralCredentialDTO? value)
        {
            Mistral = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromMistral(global::Vapi.CreateMistralCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateNeuphonicCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateNeuphonicCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateNeuphonicCredentialDTO?(CredentialsItem10 @this) => @this.Neuphonic;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateNeuphonicCredentialDTO? value)
        {
            Neuphonic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromNeuphonic(global::Vapi.CreateNeuphonicCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateOpenAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateOpenAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateOpenAICredentialDTO?(CredentialsItem10 @this) => @this.Openai;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateOpenAICredentialDTO? value)
        {
            Openai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromOpenai(global::Vapi.CreateOpenAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateOpenRouterCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateOpenRouterCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateOpenRouterCredentialDTO?(CredentialsItem10 @this) => @this.Openrouter;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateOpenRouterCredentialDTO? value)
        {
            Openrouter = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromOpenrouter(global::Vapi.CreateOpenRouterCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreatePerplexityAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreatePerplexityAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreatePerplexityAICredentialDTO?(CredentialsItem10 @this) => @this.PerplexityAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreatePerplexityAICredentialDTO? value)
        {
            PerplexityAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromPerplexityAi(global::Vapi.CreatePerplexityAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreatePlayHTCredentialDTO value) => new CredentialsItem10((global::Vapi.CreatePlayHTCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreatePlayHTCredentialDTO?(CredentialsItem10 @this) => @this.Playht;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreatePlayHTCredentialDTO? value)
        {
            Playht = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromPlayht(global::Vapi.CreatePlayHTCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateRimeAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateRimeAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateRimeAICredentialDTO?(CredentialsItem10 @this) => @this.RimeAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateRimeAICredentialDTO? value)
        {
            RimeAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromRimeAi(global::Vapi.CreateRimeAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateRunpodCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateRunpodCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateRunpodCredentialDTO?(CredentialsItem10 @this) => @this.Runpod;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateRunpodCredentialDTO? value)
        {
            Runpod = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromRunpod(global::Vapi.CreateRunpodCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateS3CredentialDTO value) => new CredentialsItem10((global::Vapi.CreateS3CredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateS3CredentialDTO?(CredentialsItem10 @this) => @this.S3;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateS3CredentialDTO? value)
        {
            S3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromS3(global::Vapi.CreateS3CredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateS3CompatibleCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateS3CompatibleCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateS3CompatibleCredentialDTO?(CredentialsItem10 @this) => @this.S3Compatible;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateS3CompatibleCredentialDTO? value)
        {
            S3Compatible = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromS3Compatible(global::Vapi.CreateS3CompatibleCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSmallestAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSmallestAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSmallestAICredentialDTO?(CredentialsItem10 @this) => @this.SmallestAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSmallestAICredentialDTO? value)
        {
            SmallestAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSmallestAi(global::Vapi.CreateSmallestAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSpeechmaticsCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSpeechmaticsCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSpeechmaticsCredentialDTO?(CredentialsItem10 @this) => @this.Speechmatics;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSpeechmaticsCredentialDTO? value)
        {
            Speechmatics = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSpeechmatics(global::Vapi.CreateSpeechmaticsCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSonioxCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSonioxCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSonioxCredentialDTO?(CredentialsItem10 @this) => @this.Soniox;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSonioxCredentialDTO? value)
        {
            Soniox = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSoniox(global::Vapi.CreateSonioxCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSupabaseCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSupabaseCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSupabaseCredentialDTO?(CredentialsItem10 @this) => @this.Supabase;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSupabaseCredentialDTO? value)
        {
            Supabase = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSupabase(global::Vapi.CreateSupabaseCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateTavusCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateTavusCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateTavusCredentialDTO?(CredentialsItem10 @this) => @this.Tavus;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateTavusCredentialDTO? value)
        {
            Tavus = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromTavus(global::Vapi.CreateTavusCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateTogetherAICredentialDTO value) => new CredentialsItem10((global::Vapi.CreateTogetherAICredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateTogetherAICredentialDTO?(CredentialsItem10 @this) => @this.TogetherAi;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateTogetherAICredentialDTO? value)
        {
            TogetherAi = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromTogetherAi(global::Vapi.CreateTogetherAICredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateTwilioCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateTwilioCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateTwilioCredentialDTO?(CredentialsItem10 @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateTwilioCredentialDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromTwilio(global::Vapi.CreateTwilioCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateVonageCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateVonageCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateVonageCredentialDTO?(CredentialsItem10 @this) => @this.Vonage;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateVonageCredentialDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromVonage(global::Vapi.CreateVonageCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateWebhookCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateWebhookCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateWebhookCredentialDTO?(CredentialsItem10 @this) => @this.Webhook;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateWebhookCredentialDTO? value)
        {
            Webhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromWebhook(global::Vapi.CreateWebhookCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateCustomCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateCustomCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateCustomCredentialDTO?(CredentialsItem10 @this) => @this.CustomCredential;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateCustomCredentialDTO? value)
        {
            CustomCredential = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromCustomCredential(global::Vapi.CreateCustomCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateXAiCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateXAiCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateXAiCredentialDTO?(CredentialsItem10 @this) => @this.Xai;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateXAiCredentialDTO? value)
        {
            Xai = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromXai(global::Vapi.CreateXAiCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateMicrosoftCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateMicrosoftCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateMicrosoftCredentialDTO?(CredentialsItem10 @this) => @this.Microsoft;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateMicrosoftCredentialDTO? value)
        {
            Microsoft = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromMicrosoft(global::Vapi.CreateMicrosoftCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO?(CredentialsItem10 @this) => @this.GoogleCalendarOauth2Client;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? value)
        {
            GoogleCalendarOauth2Client = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGoogleCalendarOauth2Client(global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO?(CredentialsItem10 @this) => @this.GoogleCalendarOauth2Authorization;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleCalendarOauth2Authorization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGoogleCalendarOauth2Authorization(global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO?(CredentialsItem10 @this) => @this.GoogleSheetsOauth2Authorization;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value)
        {
            GoogleSheetsOauth2Authorization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGoogleSheetsOauth2Authorization(global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO?(CredentialsItem10 @this) => @this.SlackOauth2Authorization;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? value)
        {
            SlackOauth2Authorization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSlackOauth2Authorization(global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateGoHighLevelMCPCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateGoHighLevelMCPCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateGoHighLevelMCPCredentialDTO?(CredentialsItem10 @this) => @this.GhlOauth2Authorization;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateGoHighLevelMCPCredentialDTO? value)
        {
            GhlOauth2Authorization = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromGhlOauth2Authorization(global::Vapi.CreateGoHighLevelMCPCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateInworldCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateInworldCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateInworldCredentialDTO?(CredentialsItem10 @this) => @this.Inworld;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateInworldCredentialDTO? value)
        {
            Inworld = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromInworld(global::Vapi.CreateInworldCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateMinimaxCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateMinimaxCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateMinimaxCredentialDTO?(CredentialsItem10 @this) => @this.Minimax;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateMinimaxCredentialDTO? value)
        {
            Minimax = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromMinimax(global::Vapi.CreateMinimaxCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateWellSaidCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateWellSaidCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateWellSaidCredentialDTO?(CredentialsItem10 @this) => @this.Wellsaid;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateWellSaidCredentialDTO? value)
        {
            Wellsaid = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromWellsaid(global::Vapi.CreateWellSaidCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateEmailCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateEmailCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateEmailCredentialDTO?(CredentialsItem10 @this) => @this.Email;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateEmailCredentialDTO? value)
        {
            Email = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromEmail(global::Vapi.CreateEmailCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CredentialsItem10(global::Vapi.CreateSlackWebhookCredentialDTO value) => new CredentialsItem10((global::Vapi.CreateSlackWebhookCredentialDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.CreateSlackWebhookCredentialDTO?(CredentialsItem10 @this) => @this.SlackWebhook;

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(global::Vapi.CreateSlackWebhookCredentialDTO? value)
        {
            SlackWebhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CredentialsItem10 FromSlackWebhook(global::Vapi.CreateSlackWebhookCredentialDTO? value) => new CredentialsItem10(value);

        /// <summary>
        ///
        /// </summary>
        public CredentialsItem10(
            global::Vapi.WorkflowCredentialDiscriminatorProvider? provider,
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
            global::Vapi.CreateS3CompatibleCredentialDTO? s3Compatible,
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
            global::Vapi.CreateMicrosoftCredentialDTO? microsoft,
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
            S3Compatible = s3Compatible;
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
            Microsoft = microsoft;
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
            Microsoft as object ??
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
            S3Compatible as object ??
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
            S3Compatible?.ToString() ??
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
            Microsoft?.ToString() ??
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
            return IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && IsMinimax && !IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && IsWellsaid && !IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && IsEmail && !IsSlackWebhook || !IsAnthropic && !IsAnthropicBedrock && !IsAnyscale && !IsAssemblyAi && !IsAzure && !IsAzureOpenai && !IsByoSipTrunk && !IsCartesia && !IsCerebras && !IsCloudflare && !IsCustomLlm && !IsDeepgram && !IsDeepinfra && !IsDeepSeek && !IsElevenlabs && !IsGcp && !IsGladia && !IsGohighlevel && !IsGoogle && !IsGroq && !IsHume && !IsInflectionAi && !IsLangfuse && !IsLmnt && !IsMake && !IsMistral && !IsNeuphonic && !IsOpenai && !IsOpenrouter && !IsPerplexityAi && !IsPlayht && !IsRimeAi && !IsRunpod && !IsS3 && !IsS3Compatible && !IsSmallestAi && !IsSpeechmatics && !IsSoniox && !IsSupabase && !IsTavus && !IsTogetherAi && !IsTwilio && !IsVonage && !IsWebhook && !IsCustomCredential && !IsXai && !IsMicrosoft && !IsGoogleCalendarOauth2Client && !IsGoogleCalendarOauth2Authorization && !IsGoogleSheetsOauth2Authorization && !IsSlackOauth2Authorization && !IsGhlOauth2Authorization && !IsInworld && !IsMinimax && !IsWellsaid && !IsEmail && IsSlackWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.CreateAnthropicCredentialDTO, TResult>? anthropic = null,
            global::System.Func<global::Vapi.CreateAnthropicBedrockCredentialDTO, TResult>? anthropicBedrock = null,
            global::System.Func<global::Vapi.CreateAnyscaleCredentialDTO, TResult>? anyscale = null,
            global::System.Func<global::Vapi.CreateAssemblyAICredentialDTO, TResult>? assemblyAi = null,
            global::System.Func<global::Vapi.CreateAzureCredentialDTO, TResult>? azure = null,
            global::System.Func<global::Vapi.CreateAzureOpenAICredentialDTO, TResult>? azureOpenai = null,
            global::System.Func<global::Vapi.CreateByoSipTrunkCredentialDTO, TResult>? byoSipTrunk = null,
            global::System.Func<global::Vapi.CreateCartesiaCredentialDTO, TResult>? cartesia = null,
            global::System.Func<global::Vapi.CreateCerebrasCredentialDTO, TResult>? cerebras = null,
            global::System.Func<global::Vapi.CreateCloudflareCredentialDTO, TResult>? cloudflare = null,
            global::System.Func<global::Vapi.CreateCustomLLMCredentialDTO, TResult>? customLlm = null,
            global::System.Func<global::Vapi.CreateDeepgramCredentialDTO, TResult>? deepgram = null,
            global::System.Func<global::Vapi.CreateDeepInfraCredentialDTO, TResult>? deepinfra = null,
            global::System.Func<global::Vapi.CreateDeepSeekCredentialDTO, TResult>? deepSeek = null,
            global::System.Func<global::Vapi.CreateElevenLabsCredentialDTO, TResult>? elevenlabs = null,
            global::System.Func<global::Vapi.CreateGcpCredentialDTO, TResult>? gcp = null,
            global::System.Func<global::Vapi.CreateGladiaCredentialDTO, TResult>? gladia = null,
            global::System.Func<global::Vapi.CreateGoHighLevelCredentialDTO, TResult>? gohighlevel = null,
            global::System.Func<global::Vapi.CreateGoogleCredentialDTO, TResult>? google = null,
            global::System.Func<global::Vapi.CreateGroqCredentialDTO, TResult>? groq = null,
            global::System.Func<global::Vapi.CreateHumeCredentialDTO, TResult>? hume = null,
            global::System.Func<global::Vapi.CreateInflectionAICredentialDTO, TResult>? inflectionAi = null,
            global::System.Func<global::Vapi.CreateLangfuseCredentialDTO, TResult>? langfuse = null,
            global::System.Func<global::Vapi.CreateLmntCredentialDTO, TResult>? lmnt = null,
            global::System.Func<global::Vapi.CreateMakeCredentialDTO, TResult>? make = null,
            global::System.Func<global::Vapi.CreateMistralCredentialDTO, TResult>? mistral = null,
            global::System.Func<global::Vapi.CreateNeuphonicCredentialDTO, TResult>? neuphonic = null,
            global::System.Func<global::Vapi.CreateOpenAICredentialDTO, TResult>? openai = null,
            global::System.Func<global::Vapi.CreateOpenRouterCredentialDTO, TResult>? openrouter = null,
            global::System.Func<global::Vapi.CreatePerplexityAICredentialDTO, TResult>? perplexityAi = null,
            global::System.Func<global::Vapi.CreatePlayHTCredentialDTO, TResult>? playht = null,
            global::System.Func<global::Vapi.CreateRimeAICredentialDTO, TResult>? rimeAi = null,
            global::System.Func<global::Vapi.CreateRunpodCredentialDTO, TResult>? runpod = null,
            global::System.Func<global::Vapi.CreateS3CredentialDTO, TResult>? s3 = null,
            global::System.Func<global::Vapi.CreateS3CompatibleCredentialDTO, TResult>? s3Compatible = null,
            global::System.Func<global::Vapi.CreateSmallestAICredentialDTO, TResult>? smallestAi = null,
            global::System.Func<global::Vapi.CreateSpeechmaticsCredentialDTO, TResult>? speechmatics = null,
            global::System.Func<global::Vapi.CreateSonioxCredentialDTO, TResult>? soniox = null,
            global::System.Func<global::Vapi.CreateSupabaseCredentialDTO, TResult>? supabase = null,
            global::System.Func<global::Vapi.CreateTavusCredentialDTO, TResult>? tavus = null,
            global::System.Func<global::Vapi.CreateTogetherAICredentialDTO, TResult>? togetherAi = null,
            global::System.Func<global::Vapi.CreateTwilioCredentialDTO, TResult>? twilio = null,
            global::System.Func<global::Vapi.CreateVonageCredentialDTO, TResult>? vonage = null,
            global::System.Func<global::Vapi.CreateWebhookCredentialDTO, TResult>? webhook = null,
            global::System.Func<global::Vapi.CreateCustomCredentialDTO, TResult>? customCredential = null,
            global::System.Func<global::Vapi.CreateXAiCredentialDTO, TResult>? xai = null,
            global::System.Func<global::Vapi.CreateMicrosoftCredentialDTO, TResult>? microsoft = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO, TResult>? googleCalendarOauth2Client = null,
            global::System.Func<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO, TResult>? googleCalendarOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO, TResult>? googleSheetsOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO, TResult>? slackOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateGoHighLevelMCPCredentialDTO, TResult>? ghlOauth2Authorization = null,
            global::System.Func<global::Vapi.CreateInworldCredentialDTO, TResult>? inworld = null,
            global::System.Func<global::Vapi.CreateMinimaxCredentialDTO, TResult>? minimax = null,
            global::System.Func<global::Vapi.CreateWellSaidCredentialDTO, TResult>? wellsaid = null,
            global::System.Func<global::Vapi.CreateEmailCredentialDTO, TResult>? email = null,
            global::System.Func<global::Vapi.CreateSlackWebhookCredentialDTO, TResult>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0 && anthropic != null)
            {
                return anthropic(__value0);
            }
            else if (AnthropicBedrock is { } __value1 && anthropicBedrock != null)
            {
                return anthropicBedrock(__value1);
            }
            else if (Anyscale is { } __value2 && anyscale != null)
            {
                return anyscale(__value2);
            }
            else if (AssemblyAi is { } __value3 && assemblyAi != null)
            {
                return assemblyAi(__value3);
            }
            else if (Azure is { } __value4 && azure != null)
            {
                return azure(__value4);
            }
            else if (AzureOpenai is { } __value5 && azureOpenai != null)
            {
                return azureOpenai(__value5);
            }
            else if (ByoSipTrunk is { } __value6 && byoSipTrunk != null)
            {
                return byoSipTrunk(__value6);
            }
            else if (Cartesia is { } __value7 && cartesia != null)
            {
                return cartesia(__value7);
            }
            else if (Cerebras is { } __value8 && cerebras != null)
            {
                return cerebras(__value8);
            }
            else if (Cloudflare is { } __value9 && cloudflare != null)
            {
                return cloudflare(__value9);
            }
            else if (CustomLlm is { } __value10 && customLlm != null)
            {
                return customLlm(__value10);
            }
            else if (Deepgram is { } __value11 && deepgram != null)
            {
                return deepgram(__value11);
            }
            else if (Deepinfra is { } __value12 && deepinfra != null)
            {
                return deepinfra(__value12);
            }
            else if (DeepSeek is { } __value13 && deepSeek != null)
            {
                return deepSeek(__value13);
            }
            else if (Elevenlabs is { } __value14 && elevenlabs != null)
            {
                return elevenlabs(__value14);
            }
            else if (Gcp is { } __value15 && gcp != null)
            {
                return gcp(__value15);
            }
            else if (Gladia is { } __value16 && gladia != null)
            {
                return gladia(__value16);
            }
            else if (Gohighlevel is { } __value17 && gohighlevel != null)
            {
                return gohighlevel(__value17);
            }
            else if (Google is { } __value18 && google != null)
            {
                return google(__value18);
            }
            else if (Groq is { } __value19 && groq != null)
            {
                return groq(__value19);
            }
            else if (Hume is { } __value20 && hume != null)
            {
                return hume(__value20);
            }
            else if (InflectionAi is { } __value21 && inflectionAi != null)
            {
                return inflectionAi(__value21);
            }
            else if (Langfuse is { } __value22 && langfuse != null)
            {
                return langfuse(__value22);
            }
            else if (Lmnt is { } __value23 && lmnt != null)
            {
                return lmnt(__value23);
            }
            else if (Make is { } __value24 && make != null)
            {
                return make(__value24);
            }
            else if (Mistral is { } __value25 && mistral != null)
            {
                return mistral(__value25);
            }
            else if (Neuphonic is { } __value26 && neuphonic != null)
            {
                return neuphonic(__value26);
            }
            else if (Openai is { } __value27 && openai != null)
            {
                return openai(__value27);
            }
            else if (Openrouter is { } __value28 && openrouter != null)
            {
                return openrouter(__value28);
            }
            else if (PerplexityAi is { } __value29 && perplexityAi != null)
            {
                return perplexityAi(__value29);
            }
            else if (Playht is { } __value30 && playht != null)
            {
                return playht(__value30);
            }
            else if (RimeAi is { } __value31 && rimeAi != null)
            {
                return rimeAi(__value31);
            }
            else if (Runpod is { } __value32 && runpod != null)
            {
                return runpod(__value32);
            }
            else if (S3 is { } __value33 && s3 != null)
            {
                return s3(__value33);
            }
            else if (S3Compatible is { } __value34 && s3Compatible != null)
            {
                return s3Compatible(__value34);
            }
            else if (SmallestAi is { } __value35 && smallestAi != null)
            {
                return smallestAi(__value35);
            }
            else if (Speechmatics is { } __value36 && speechmatics != null)
            {
                return speechmatics(__value36);
            }
            else if (Soniox is { } __value37 && soniox != null)
            {
                return soniox(__value37);
            }
            else if (Supabase is { } __value38 && supabase != null)
            {
                return supabase(__value38);
            }
            else if (Tavus is { } __value39 && tavus != null)
            {
                return tavus(__value39);
            }
            else if (TogetherAi is { } __value40 && togetherAi != null)
            {
                return togetherAi(__value40);
            }
            else if (Twilio is { } __value41 && twilio != null)
            {
                return twilio(__value41);
            }
            else if (Vonage is { } __value42 && vonage != null)
            {
                return vonage(__value42);
            }
            else if (Webhook is { } __value43 && webhook != null)
            {
                return webhook(__value43);
            }
            else if (CustomCredential is { } __value44 && customCredential != null)
            {
                return customCredential(__value44);
            }
            else if (Xai is { } __value45 && xai != null)
            {
                return xai(__value45);
            }
            else if (Microsoft is { } __value46 && microsoft != null)
            {
                return microsoft(__value46);
            }
            else if (GoogleCalendarOauth2Client is { } __value47 && googleCalendarOauth2Client != null)
            {
                return googleCalendarOauth2Client(__value47);
            }
            else if (GoogleCalendarOauth2Authorization is { } __value48 && googleCalendarOauth2Authorization != null)
            {
                return googleCalendarOauth2Authorization(__value48);
            }
            else if (GoogleSheetsOauth2Authorization is { } __value49 && googleSheetsOauth2Authorization != null)
            {
                return googleSheetsOauth2Authorization(__value49);
            }
            else if (SlackOauth2Authorization is { } __value50 && slackOauth2Authorization != null)
            {
                return slackOauth2Authorization(__value50);
            }
            else if (GhlOauth2Authorization is { } __value51 && ghlOauth2Authorization != null)
            {
                return ghlOauth2Authorization(__value51);
            }
            else if (Inworld is { } __value52 && inworld != null)
            {
                return inworld(__value52);
            }
            else if (Minimax is { } __value53 && minimax != null)
            {
                return minimax(__value53);
            }
            else if (Wellsaid is { } __value54 && wellsaid != null)
            {
                return wellsaid(__value54);
            }
            else if (Email is { } __value55 && email != null)
            {
                return email(__value55);
            }
            else if (SlackWebhook is { } __value56 && slackWebhook != null)
            {
                return slackWebhook(__value56);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.CreateAnthropicCredentialDTO>? anthropic = null,

            global::System.Action<global::Vapi.CreateAnthropicBedrockCredentialDTO>? anthropicBedrock = null,

            global::System.Action<global::Vapi.CreateAnyscaleCredentialDTO>? anyscale = null,

            global::System.Action<global::Vapi.CreateAssemblyAICredentialDTO>? assemblyAi = null,

            global::System.Action<global::Vapi.CreateAzureCredentialDTO>? azure = null,

            global::System.Action<global::Vapi.CreateAzureOpenAICredentialDTO>? azureOpenai = null,

            global::System.Action<global::Vapi.CreateByoSipTrunkCredentialDTO>? byoSipTrunk = null,

            global::System.Action<global::Vapi.CreateCartesiaCredentialDTO>? cartesia = null,

            global::System.Action<global::Vapi.CreateCerebrasCredentialDTO>? cerebras = null,

            global::System.Action<global::Vapi.CreateCloudflareCredentialDTO>? cloudflare = null,

            global::System.Action<global::Vapi.CreateCustomLLMCredentialDTO>? customLlm = null,

            global::System.Action<global::Vapi.CreateDeepgramCredentialDTO>? deepgram = null,

            global::System.Action<global::Vapi.CreateDeepInfraCredentialDTO>? deepinfra = null,

            global::System.Action<global::Vapi.CreateDeepSeekCredentialDTO>? deepSeek = null,

            global::System.Action<global::Vapi.CreateElevenLabsCredentialDTO>? elevenlabs = null,

            global::System.Action<global::Vapi.CreateGcpCredentialDTO>? gcp = null,

            global::System.Action<global::Vapi.CreateGladiaCredentialDTO>? gladia = null,

            global::System.Action<global::Vapi.CreateGoHighLevelCredentialDTO>? gohighlevel = null,

            global::System.Action<global::Vapi.CreateGoogleCredentialDTO>? google = null,

            global::System.Action<global::Vapi.CreateGroqCredentialDTO>? groq = null,

            global::System.Action<global::Vapi.CreateHumeCredentialDTO>? hume = null,

            global::System.Action<global::Vapi.CreateInflectionAICredentialDTO>? inflectionAi = null,

            global::System.Action<global::Vapi.CreateLangfuseCredentialDTO>? langfuse = null,

            global::System.Action<global::Vapi.CreateLmntCredentialDTO>? lmnt = null,

            global::System.Action<global::Vapi.CreateMakeCredentialDTO>? make = null,

            global::System.Action<global::Vapi.CreateMistralCredentialDTO>? mistral = null,

            global::System.Action<global::Vapi.CreateNeuphonicCredentialDTO>? neuphonic = null,

            global::System.Action<global::Vapi.CreateOpenAICredentialDTO>? openai = null,

            global::System.Action<global::Vapi.CreateOpenRouterCredentialDTO>? openrouter = null,

            global::System.Action<global::Vapi.CreatePerplexityAICredentialDTO>? perplexityAi = null,

            global::System.Action<global::Vapi.CreatePlayHTCredentialDTO>? playht = null,

            global::System.Action<global::Vapi.CreateRimeAICredentialDTO>? rimeAi = null,

            global::System.Action<global::Vapi.CreateRunpodCredentialDTO>? runpod = null,

            global::System.Action<global::Vapi.CreateS3CredentialDTO>? s3 = null,

            global::System.Action<global::Vapi.CreateS3CompatibleCredentialDTO>? s3Compatible = null,

            global::System.Action<global::Vapi.CreateSmallestAICredentialDTO>? smallestAi = null,

            global::System.Action<global::Vapi.CreateSpeechmaticsCredentialDTO>? speechmatics = null,

            global::System.Action<global::Vapi.CreateSonioxCredentialDTO>? soniox = null,

            global::System.Action<global::Vapi.CreateSupabaseCredentialDTO>? supabase = null,

            global::System.Action<global::Vapi.CreateTavusCredentialDTO>? tavus = null,

            global::System.Action<global::Vapi.CreateTogetherAICredentialDTO>? togetherAi = null,

            global::System.Action<global::Vapi.CreateTwilioCredentialDTO>? twilio = null,

            global::System.Action<global::Vapi.CreateVonageCredentialDTO>? vonage = null,

            global::System.Action<global::Vapi.CreateWebhookCredentialDTO>? webhook = null,

            global::System.Action<global::Vapi.CreateCustomCredentialDTO>? customCredential = null,

            global::System.Action<global::Vapi.CreateXAiCredentialDTO>? xai = null,

            global::System.Action<global::Vapi.CreateMicrosoftCredentialDTO>? microsoft = null,

            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO>? googleCalendarOauth2Client = null,

            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>? googleCalendarOauth2Authorization = null,

            global::System.Action<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>? googleSheetsOauth2Authorization = null,

            global::System.Action<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO>? slackOauth2Authorization = null,

            global::System.Action<global::Vapi.CreateGoHighLevelMCPCredentialDTO>? ghlOauth2Authorization = null,

            global::System.Action<global::Vapi.CreateInworldCredentialDTO>? inworld = null,

            global::System.Action<global::Vapi.CreateMinimaxCredentialDTO>? minimax = null,

            global::System.Action<global::Vapi.CreateWellSaidCredentialDTO>? wellsaid = null,

            global::System.Action<global::Vapi.CreateEmailCredentialDTO>? email = null,

            global::System.Action<global::Vapi.CreateSlackWebhookCredentialDTO>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0)
            {
                anthropic?.Invoke(__value0);
            }
            else if (AnthropicBedrock is { } __value1)
            {
                anthropicBedrock?.Invoke(__value1);
            }
            else if (Anyscale is { } __value2)
            {
                anyscale?.Invoke(__value2);
            }
            else if (AssemblyAi is { } __value3)
            {
                assemblyAi?.Invoke(__value3);
            }
            else if (Azure is { } __value4)
            {
                azure?.Invoke(__value4);
            }
            else if (AzureOpenai is { } __value5)
            {
                azureOpenai?.Invoke(__value5);
            }
            else if (ByoSipTrunk is { } __value6)
            {
                byoSipTrunk?.Invoke(__value6);
            }
            else if (Cartesia is { } __value7)
            {
                cartesia?.Invoke(__value7);
            }
            else if (Cerebras is { } __value8)
            {
                cerebras?.Invoke(__value8);
            }
            else if (Cloudflare is { } __value9)
            {
                cloudflare?.Invoke(__value9);
            }
            else if (CustomLlm is { } __value10)
            {
                customLlm?.Invoke(__value10);
            }
            else if (Deepgram is { } __value11)
            {
                deepgram?.Invoke(__value11);
            }
            else if (Deepinfra is { } __value12)
            {
                deepinfra?.Invoke(__value12);
            }
            else if (DeepSeek is { } __value13)
            {
                deepSeek?.Invoke(__value13);
            }
            else if (Elevenlabs is { } __value14)
            {
                elevenlabs?.Invoke(__value14);
            }
            else if (Gcp is { } __value15)
            {
                gcp?.Invoke(__value15);
            }
            else if (Gladia is { } __value16)
            {
                gladia?.Invoke(__value16);
            }
            else if (Gohighlevel is { } __value17)
            {
                gohighlevel?.Invoke(__value17);
            }
            else if (Google is { } __value18)
            {
                google?.Invoke(__value18);
            }
            else if (Groq is { } __value19)
            {
                groq?.Invoke(__value19);
            }
            else if (Hume is { } __value20)
            {
                hume?.Invoke(__value20);
            }
            else if (InflectionAi is { } __value21)
            {
                inflectionAi?.Invoke(__value21);
            }
            else if (Langfuse is { } __value22)
            {
                langfuse?.Invoke(__value22);
            }
            else if (Lmnt is { } __value23)
            {
                lmnt?.Invoke(__value23);
            }
            else if (Make is { } __value24)
            {
                make?.Invoke(__value24);
            }
            else if (Mistral is { } __value25)
            {
                mistral?.Invoke(__value25);
            }
            else if (Neuphonic is { } __value26)
            {
                neuphonic?.Invoke(__value26);
            }
            else if (Openai is { } __value27)
            {
                openai?.Invoke(__value27);
            }
            else if (Openrouter is { } __value28)
            {
                openrouter?.Invoke(__value28);
            }
            else if (PerplexityAi is { } __value29)
            {
                perplexityAi?.Invoke(__value29);
            }
            else if (Playht is { } __value30)
            {
                playht?.Invoke(__value30);
            }
            else if (RimeAi is { } __value31)
            {
                rimeAi?.Invoke(__value31);
            }
            else if (Runpod is { } __value32)
            {
                runpod?.Invoke(__value32);
            }
            else if (S3 is { } __value33)
            {
                s3?.Invoke(__value33);
            }
            else if (S3Compatible is { } __value34)
            {
                s3Compatible?.Invoke(__value34);
            }
            else if (SmallestAi is { } __value35)
            {
                smallestAi?.Invoke(__value35);
            }
            else if (Speechmatics is { } __value36)
            {
                speechmatics?.Invoke(__value36);
            }
            else if (Soniox is { } __value37)
            {
                soniox?.Invoke(__value37);
            }
            else if (Supabase is { } __value38)
            {
                supabase?.Invoke(__value38);
            }
            else if (Tavus is { } __value39)
            {
                tavus?.Invoke(__value39);
            }
            else if (TogetherAi is { } __value40)
            {
                togetherAi?.Invoke(__value40);
            }
            else if (Twilio is { } __value41)
            {
                twilio?.Invoke(__value41);
            }
            else if (Vonage is { } __value42)
            {
                vonage?.Invoke(__value42);
            }
            else if (Webhook is { } __value43)
            {
                webhook?.Invoke(__value43);
            }
            else if (CustomCredential is { } __value44)
            {
                customCredential?.Invoke(__value44);
            }
            else if (Xai is { } __value45)
            {
                xai?.Invoke(__value45);
            }
            else if (Microsoft is { } __value46)
            {
                microsoft?.Invoke(__value46);
            }
            else if (GoogleCalendarOauth2Client is { } __value47)
            {
                googleCalendarOauth2Client?.Invoke(__value47);
            }
            else if (GoogleCalendarOauth2Authorization is { } __value48)
            {
                googleCalendarOauth2Authorization?.Invoke(__value48);
            }
            else if (GoogleSheetsOauth2Authorization is { } __value49)
            {
                googleSheetsOauth2Authorization?.Invoke(__value49);
            }
            else if (SlackOauth2Authorization is { } __value50)
            {
                slackOauth2Authorization?.Invoke(__value50);
            }
            else if (GhlOauth2Authorization is { } __value51)
            {
                ghlOauth2Authorization?.Invoke(__value51);
            }
            else if (Inworld is { } __value52)
            {
                inworld?.Invoke(__value52);
            }
            else if (Minimax is { } __value53)
            {
                minimax?.Invoke(__value53);
            }
            else if (Wellsaid is { } __value54)
            {
                wellsaid?.Invoke(__value54);
            }
            else if (Email is { } __value55)
            {
                email?.Invoke(__value55);
            }
            else if (SlackWebhook is { } __value56)
            {
                slackWebhook?.Invoke(__value56);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vapi.CreateAnthropicCredentialDTO>? anthropic = null,
            global::System.Action<global::Vapi.CreateAnthropicBedrockCredentialDTO>? anthropicBedrock = null,
            global::System.Action<global::Vapi.CreateAnyscaleCredentialDTO>? anyscale = null,
            global::System.Action<global::Vapi.CreateAssemblyAICredentialDTO>? assemblyAi = null,
            global::System.Action<global::Vapi.CreateAzureCredentialDTO>? azure = null,
            global::System.Action<global::Vapi.CreateAzureOpenAICredentialDTO>? azureOpenai = null,
            global::System.Action<global::Vapi.CreateByoSipTrunkCredentialDTO>? byoSipTrunk = null,
            global::System.Action<global::Vapi.CreateCartesiaCredentialDTO>? cartesia = null,
            global::System.Action<global::Vapi.CreateCerebrasCredentialDTO>? cerebras = null,
            global::System.Action<global::Vapi.CreateCloudflareCredentialDTO>? cloudflare = null,
            global::System.Action<global::Vapi.CreateCustomLLMCredentialDTO>? customLlm = null,
            global::System.Action<global::Vapi.CreateDeepgramCredentialDTO>? deepgram = null,
            global::System.Action<global::Vapi.CreateDeepInfraCredentialDTO>? deepinfra = null,
            global::System.Action<global::Vapi.CreateDeepSeekCredentialDTO>? deepSeek = null,
            global::System.Action<global::Vapi.CreateElevenLabsCredentialDTO>? elevenlabs = null,
            global::System.Action<global::Vapi.CreateGcpCredentialDTO>? gcp = null,
            global::System.Action<global::Vapi.CreateGladiaCredentialDTO>? gladia = null,
            global::System.Action<global::Vapi.CreateGoHighLevelCredentialDTO>? gohighlevel = null,
            global::System.Action<global::Vapi.CreateGoogleCredentialDTO>? google = null,
            global::System.Action<global::Vapi.CreateGroqCredentialDTO>? groq = null,
            global::System.Action<global::Vapi.CreateHumeCredentialDTO>? hume = null,
            global::System.Action<global::Vapi.CreateInflectionAICredentialDTO>? inflectionAi = null,
            global::System.Action<global::Vapi.CreateLangfuseCredentialDTO>? langfuse = null,
            global::System.Action<global::Vapi.CreateLmntCredentialDTO>? lmnt = null,
            global::System.Action<global::Vapi.CreateMakeCredentialDTO>? make = null,
            global::System.Action<global::Vapi.CreateMistralCredentialDTO>? mistral = null,
            global::System.Action<global::Vapi.CreateNeuphonicCredentialDTO>? neuphonic = null,
            global::System.Action<global::Vapi.CreateOpenAICredentialDTO>? openai = null,
            global::System.Action<global::Vapi.CreateOpenRouterCredentialDTO>? openrouter = null,
            global::System.Action<global::Vapi.CreatePerplexityAICredentialDTO>? perplexityAi = null,
            global::System.Action<global::Vapi.CreatePlayHTCredentialDTO>? playht = null,
            global::System.Action<global::Vapi.CreateRimeAICredentialDTO>? rimeAi = null,
            global::System.Action<global::Vapi.CreateRunpodCredentialDTO>? runpod = null,
            global::System.Action<global::Vapi.CreateS3CredentialDTO>? s3 = null,
            global::System.Action<global::Vapi.CreateS3CompatibleCredentialDTO>? s3Compatible = null,
            global::System.Action<global::Vapi.CreateSmallestAICredentialDTO>? smallestAi = null,
            global::System.Action<global::Vapi.CreateSpeechmaticsCredentialDTO>? speechmatics = null,
            global::System.Action<global::Vapi.CreateSonioxCredentialDTO>? soniox = null,
            global::System.Action<global::Vapi.CreateSupabaseCredentialDTO>? supabase = null,
            global::System.Action<global::Vapi.CreateTavusCredentialDTO>? tavus = null,
            global::System.Action<global::Vapi.CreateTogetherAICredentialDTO>? togetherAi = null,
            global::System.Action<global::Vapi.CreateTwilioCredentialDTO>? twilio = null,
            global::System.Action<global::Vapi.CreateVonageCredentialDTO>? vonage = null,
            global::System.Action<global::Vapi.CreateWebhookCredentialDTO>? webhook = null,
            global::System.Action<global::Vapi.CreateCustomCredentialDTO>? customCredential = null,
            global::System.Action<global::Vapi.CreateXAiCredentialDTO>? xai = null,
            global::System.Action<global::Vapi.CreateMicrosoftCredentialDTO>? microsoft = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2ClientCredentialDTO>? googleCalendarOauth2Client = null,
            global::System.Action<global::Vapi.CreateGoogleCalendarOAuth2AuthorizationCredentialDTO>? googleCalendarOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateGoogleSheetsOAuth2AuthorizationCredentialDTO>? googleSheetsOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateSlackOAuth2AuthorizationCredentialDTO>? slackOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateGoHighLevelMCPCredentialDTO>? ghlOauth2Authorization = null,
            global::System.Action<global::Vapi.CreateInworldCredentialDTO>? inworld = null,
            global::System.Action<global::Vapi.CreateMinimaxCredentialDTO>? minimax = null,
            global::System.Action<global::Vapi.CreateWellSaidCredentialDTO>? wellsaid = null,
            global::System.Action<global::Vapi.CreateEmailCredentialDTO>? email = null,
            global::System.Action<global::Vapi.CreateSlackWebhookCredentialDTO>? slackWebhook = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Anthropic is { } __value0)
            {
                anthropic?.Invoke(__value0);
            }
            else if (AnthropicBedrock is { } __value1)
            {
                anthropicBedrock?.Invoke(__value1);
            }
            else if (Anyscale is { } __value2)
            {
                anyscale?.Invoke(__value2);
            }
            else if (AssemblyAi is { } __value3)
            {
                assemblyAi?.Invoke(__value3);
            }
            else if (Azure is { } __value4)
            {
                azure?.Invoke(__value4);
            }
            else if (AzureOpenai is { } __value5)
            {
                azureOpenai?.Invoke(__value5);
            }
            else if (ByoSipTrunk is { } __value6)
            {
                byoSipTrunk?.Invoke(__value6);
            }
            else if (Cartesia is { } __value7)
            {
                cartesia?.Invoke(__value7);
            }
            else if (Cerebras is { } __value8)
            {
                cerebras?.Invoke(__value8);
            }
            else if (Cloudflare is { } __value9)
            {
                cloudflare?.Invoke(__value9);
            }
            else if (CustomLlm is { } __value10)
            {
                customLlm?.Invoke(__value10);
            }
            else if (Deepgram is { } __value11)
            {
                deepgram?.Invoke(__value11);
            }
            else if (Deepinfra is { } __value12)
            {
                deepinfra?.Invoke(__value12);
            }
            else if (DeepSeek is { } __value13)
            {
                deepSeek?.Invoke(__value13);
            }
            else if (Elevenlabs is { } __value14)
            {
                elevenlabs?.Invoke(__value14);
            }
            else if (Gcp is { } __value15)
            {
                gcp?.Invoke(__value15);
            }
            else if (Gladia is { } __value16)
            {
                gladia?.Invoke(__value16);
            }
            else if (Gohighlevel is { } __value17)
            {
                gohighlevel?.Invoke(__value17);
            }
            else if (Google is { } __value18)
            {
                google?.Invoke(__value18);
            }
            else if (Groq is { } __value19)
            {
                groq?.Invoke(__value19);
            }
            else if (Hume is { } __value20)
            {
                hume?.Invoke(__value20);
            }
            else if (InflectionAi is { } __value21)
            {
                inflectionAi?.Invoke(__value21);
            }
            else if (Langfuse is { } __value22)
            {
                langfuse?.Invoke(__value22);
            }
            else if (Lmnt is { } __value23)
            {
                lmnt?.Invoke(__value23);
            }
            else if (Make is { } __value24)
            {
                make?.Invoke(__value24);
            }
            else if (Mistral is { } __value25)
            {
                mistral?.Invoke(__value25);
            }
            else if (Neuphonic is { } __value26)
            {
                neuphonic?.Invoke(__value26);
            }
            else if (Openai is { } __value27)
            {
                openai?.Invoke(__value27);
            }
            else if (Openrouter is { } __value28)
            {
                openrouter?.Invoke(__value28);
            }
            else if (PerplexityAi is { } __value29)
            {
                perplexityAi?.Invoke(__value29);
            }
            else if (Playht is { } __value30)
            {
                playht?.Invoke(__value30);
            }
            else if (RimeAi is { } __value31)
            {
                rimeAi?.Invoke(__value31);
            }
            else if (Runpod is { } __value32)
            {
                runpod?.Invoke(__value32);
            }
            else if (S3 is { } __value33)
            {
                s3?.Invoke(__value33);
            }
            else if (S3Compatible is { } __value34)
            {
                s3Compatible?.Invoke(__value34);
            }
            else if (SmallestAi is { } __value35)
            {
                smallestAi?.Invoke(__value35);
            }
            else if (Speechmatics is { } __value36)
            {
                speechmatics?.Invoke(__value36);
            }
            else if (Soniox is { } __value37)
            {
                soniox?.Invoke(__value37);
            }
            else if (Supabase is { } __value38)
            {
                supabase?.Invoke(__value38);
            }
            else if (Tavus is { } __value39)
            {
                tavus?.Invoke(__value39);
            }
            else if (TogetherAi is { } __value40)
            {
                togetherAi?.Invoke(__value40);
            }
            else if (Twilio is { } __value41)
            {
                twilio?.Invoke(__value41);
            }
            else if (Vonage is { } __value42)
            {
                vonage?.Invoke(__value42);
            }
            else if (Webhook is { } __value43)
            {
                webhook?.Invoke(__value43);
            }
            else if (CustomCredential is { } __value44)
            {
                customCredential?.Invoke(__value44);
            }
            else if (Xai is { } __value45)
            {
                xai?.Invoke(__value45);
            }
            else if (Microsoft is { } __value46)
            {
                microsoft?.Invoke(__value46);
            }
            else if (GoogleCalendarOauth2Client is { } __value47)
            {
                googleCalendarOauth2Client?.Invoke(__value47);
            }
            else if (GoogleCalendarOauth2Authorization is { } __value48)
            {
                googleCalendarOauth2Authorization?.Invoke(__value48);
            }
            else if (GoogleSheetsOauth2Authorization is { } __value49)
            {
                googleSheetsOauth2Authorization?.Invoke(__value49);
            }
            else if (SlackOauth2Authorization is { } __value50)
            {
                slackOauth2Authorization?.Invoke(__value50);
            }
            else if (GhlOauth2Authorization is { } __value51)
            {
                ghlOauth2Authorization?.Invoke(__value51);
            }
            else if (Inworld is { } __value52)
            {
                inworld?.Invoke(__value52);
            }
            else if (Minimax is { } __value53)
            {
                minimax?.Invoke(__value53);
            }
            else if (Wellsaid is { } __value54)
            {
                wellsaid?.Invoke(__value54);
            }
            else if (Email is { } __value55)
            {
                email?.Invoke(__value55);
            }
            else if (SlackWebhook is { } __value56)
            {
                slackWebhook?.Invoke(__value56);
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
                S3Compatible,
                typeof(global::Vapi.CreateS3CompatibleCredentialDTO),
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
                Microsoft,
                typeof(global::Vapi.CreateMicrosoftCredentialDTO),
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
        public bool Equals(CredentialsItem10 other)
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
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateS3CompatibleCredentialDTO?>.Default.Equals(S3Compatible, other.S3Compatible) &&
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
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateMicrosoftCredentialDTO?>.Default.Equals(Microsoft, other.Microsoft) &&
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
        public static bool operator ==(CredentialsItem10 obj1, CredentialsItem10 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CredentialsItem10>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CredentialsItem10 obj1, CredentialsItem10 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CredentialsItem10 o && Equals(o);
        }
    }
}
