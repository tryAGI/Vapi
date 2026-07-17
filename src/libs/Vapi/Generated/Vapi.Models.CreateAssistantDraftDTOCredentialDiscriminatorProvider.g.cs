
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAssistantDraftDTOCredentialDiscriminatorProvider
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
    public static class CreateAssistantDraftDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantDraftDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Azure => "azure",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Email => "email",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Google => "google",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Groq => "groq",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Hume => "hume",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Make => "make",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Microsoft => "microsoft",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Openai => "openai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Playht => "playht",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.S3 => "s3",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                CreateAssistantDraftDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantDraftDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Email,
                "gcp" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Groq,
                "hume" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Make,
                "microsoft" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Microsoft,
                "minimax" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.S3,
                "s3-compatible" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => CreateAssistantDraftDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}