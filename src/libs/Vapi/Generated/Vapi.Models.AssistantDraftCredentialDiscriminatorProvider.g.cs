
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssistantDraftCredentialDiscriminatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AssemblyAi,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        ByoSipTrunk,
        /// <summary>
        /// 
        /// </summary>
        Cartesia,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        CustomCredential,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        DeepSeek,
        /// <summary>
        /// 
        /// </summary>
        Deepgram,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        Gcp,
        /// <summary>
        /// 
        /// </summary>
        GhlOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Gladia,
        /// <summary>
        /// 
        /// </summary>
        Gohighlevel,
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        GoogleCalendarOauth2Client,
        /// <summary>
        /// 
        /// </summary>
        GoogleSheetsOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Hume,
        /// <summary>
        /// 
        /// </summary>
        InflectionAi,
        /// <summary>
        /// 
        /// </summary>
        Inworld,
        /// <summary>
        /// 
        /// </summary>
        Langfuse,
        /// <summary>
        /// 
        /// </summary>
        Lmnt,
        /// <summary>
        /// 
        /// </summary>
        Make,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Neuphonic,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        Playht,
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
        /// <summary>
        /// 
        /// </summary>
        Runpod,
        /// <summary>
        /// 
        /// </summary>
        S3,
        /// <summary>
        /// 
        /// </summary>
        S3Compatible,
        /// <summary>
        /// 
        /// </summary>
        SlackWebhook,
        /// <summary>
        /// 
        /// </summary>
        SlackOauth2Authorization,
        /// <summary>
        /// 
        /// </summary>
        SmallestAi,
        /// <summary>
        /// 
        /// </summary>
        Soniox,
        /// <summary>
        /// 
        /// </summary>
        Speechmatics,
        /// <summary>
        /// 
        /// </summary>
        Supabase,
        /// <summary>
        /// 
        /// </summary>
        Tavus,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vonage,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Wellsaid,
        /// <summary>
        /// 
        /// </summary>
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantDraftCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantDraftCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                AssistantDraftCredentialDiscriminatorProvider.Anthropic => "anthropic",
                AssistantDraftCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                AssistantDraftCredentialDiscriminatorProvider.Anyscale => "anyscale",
                AssistantDraftCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                AssistantDraftCredentialDiscriminatorProvider.Azure => "azure",
                AssistantDraftCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                AssistantDraftCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                AssistantDraftCredentialDiscriminatorProvider.Cartesia => "cartesia",
                AssistantDraftCredentialDiscriminatorProvider.Cerebras => "cerebras",
                AssistantDraftCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                AssistantDraftCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                AssistantDraftCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                AssistantDraftCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                AssistantDraftCredentialDiscriminatorProvider.Deepgram => "deepgram",
                AssistantDraftCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                AssistantDraftCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                AssistantDraftCredentialDiscriminatorProvider.Email => "email",
                AssistantDraftCredentialDiscriminatorProvider.Gcp => "gcp",
                AssistantDraftCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                AssistantDraftCredentialDiscriminatorProvider.Gladia => "gladia",
                AssistantDraftCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                AssistantDraftCredentialDiscriminatorProvider.Google => "google",
                AssistantDraftCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                AssistantDraftCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                AssistantDraftCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                AssistantDraftCredentialDiscriminatorProvider.Groq => "groq",
                AssistantDraftCredentialDiscriminatorProvider.Hume => "hume",
                AssistantDraftCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                AssistantDraftCredentialDiscriminatorProvider.Inworld => "inworld",
                AssistantDraftCredentialDiscriminatorProvider.Langfuse => "langfuse",
                AssistantDraftCredentialDiscriminatorProvider.Lmnt => "lmnt",
                AssistantDraftCredentialDiscriminatorProvider.Make => "make",
                AssistantDraftCredentialDiscriminatorProvider.Microsoft => "microsoft",
                AssistantDraftCredentialDiscriminatorProvider.Minimax => "minimax",
                AssistantDraftCredentialDiscriminatorProvider.Mistral => "mistral",
                AssistantDraftCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                AssistantDraftCredentialDiscriminatorProvider.Openai => "openai",
                AssistantDraftCredentialDiscriminatorProvider.Openrouter => "openrouter",
                AssistantDraftCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                AssistantDraftCredentialDiscriminatorProvider.Playht => "playht",
                AssistantDraftCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                AssistantDraftCredentialDiscriminatorProvider.Runpod => "runpod",
                AssistantDraftCredentialDiscriminatorProvider.S3 => "s3",
                AssistantDraftCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                AssistantDraftCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                AssistantDraftCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                AssistantDraftCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                AssistantDraftCredentialDiscriminatorProvider.Soniox => "soniox",
                AssistantDraftCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                AssistantDraftCredentialDiscriminatorProvider.Supabase => "supabase",
                AssistantDraftCredentialDiscriminatorProvider.Tavus => "tavus",
                AssistantDraftCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                AssistantDraftCredentialDiscriminatorProvider.Twilio => "twilio",
                AssistantDraftCredentialDiscriminatorProvider.Vonage => "vonage",
                AssistantDraftCredentialDiscriminatorProvider.Webhook => "webhook",
                AssistantDraftCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                AssistantDraftCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantDraftCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AssistantDraftCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => AssistantDraftCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => AssistantDraftCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => AssistantDraftCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => AssistantDraftCredentialDiscriminatorProvider.Azure,
                "azure-openai" => AssistantDraftCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => AssistantDraftCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => AssistantDraftCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => AssistantDraftCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => AssistantDraftCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => AssistantDraftCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => AssistantDraftCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => AssistantDraftCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => AssistantDraftCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => AssistantDraftCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => AssistantDraftCredentialDiscriminatorProvider.Elevenlabs,
                "email" => AssistantDraftCredentialDiscriminatorProvider.Email,
                "gcp" => AssistantDraftCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => AssistantDraftCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => AssistantDraftCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => AssistantDraftCredentialDiscriminatorProvider.Gohighlevel,
                "google" => AssistantDraftCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => AssistantDraftCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => AssistantDraftCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => AssistantDraftCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => AssistantDraftCredentialDiscriminatorProvider.Groq,
                "hume" => AssistantDraftCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => AssistantDraftCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => AssistantDraftCredentialDiscriminatorProvider.Inworld,
                "langfuse" => AssistantDraftCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => AssistantDraftCredentialDiscriminatorProvider.Lmnt,
                "make" => AssistantDraftCredentialDiscriminatorProvider.Make,
                "microsoft" => AssistantDraftCredentialDiscriminatorProvider.Microsoft,
                "minimax" => AssistantDraftCredentialDiscriminatorProvider.Minimax,
                "mistral" => AssistantDraftCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => AssistantDraftCredentialDiscriminatorProvider.Neuphonic,
                "openai" => AssistantDraftCredentialDiscriminatorProvider.Openai,
                "openrouter" => AssistantDraftCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => AssistantDraftCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => AssistantDraftCredentialDiscriminatorProvider.Playht,
                "rime-ai" => AssistantDraftCredentialDiscriminatorProvider.RimeAi,
                "runpod" => AssistantDraftCredentialDiscriminatorProvider.Runpod,
                "s3" => AssistantDraftCredentialDiscriminatorProvider.S3,
                "s3-compatible" => AssistantDraftCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => AssistantDraftCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => AssistantDraftCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => AssistantDraftCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => AssistantDraftCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => AssistantDraftCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => AssistantDraftCredentialDiscriminatorProvider.Supabase,
                "tavus" => AssistantDraftCredentialDiscriminatorProvider.Tavus,
                "together-ai" => AssistantDraftCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => AssistantDraftCredentialDiscriminatorProvider.Twilio,
                "vonage" => AssistantDraftCredentialDiscriminatorProvider.Vonage,
                "webhook" => AssistantDraftCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => AssistantDraftCredentialDiscriminatorProvider.Wellsaid,
                "xai" => AssistantDraftCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}