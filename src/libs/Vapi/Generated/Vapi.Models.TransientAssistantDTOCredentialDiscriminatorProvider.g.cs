
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TransientAssistantDTOCredentialDiscriminatorProvider
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
    public static class TransientAssistantDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransientAssistantDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                TransientAssistantDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                TransientAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                TransientAssistantDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                TransientAssistantDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Azure => "azure",
                TransientAssistantDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                TransientAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                TransientAssistantDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                TransientAssistantDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                TransientAssistantDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                TransientAssistantDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                TransientAssistantDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                TransientAssistantDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                TransientAssistantDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                TransientAssistantDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                TransientAssistantDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                TransientAssistantDTOCredentialDiscriminatorProvider.Email => "email",
                TransientAssistantDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                TransientAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                TransientAssistantDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                TransientAssistantDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                TransientAssistantDTOCredentialDiscriminatorProvider.Google => "google",
                TransientAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                TransientAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                TransientAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                TransientAssistantDTOCredentialDiscriminatorProvider.Groq => "groq",
                TransientAssistantDTOCredentialDiscriminatorProvider.Hume => "hume",
                TransientAssistantDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                TransientAssistantDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                TransientAssistantDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                TransientAssistantDTOCredentialDiscriminatorProvider.Make => "make",
                TransientAssistantDTOCredentialDiscriminatorProvider.Microsoft => "microsoft",
                TransientAssistantDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                TransientAssistantDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                TransientAssistantDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                TransientAssistantDTOCredentialDiscriminatorProvider.Openai => "openai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                TransientAssistantDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Playht => "playht",
                TransientAssistantDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                TransientAssistantDTOCredentialDiscriminatorProvider.S3 => "s3",
                TransientAssistantDTOCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                TransientAssistantDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                TransientAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                TransientAssistantDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                TransientAssistantDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                TransientAssistantDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                TransientAssistantDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                TransientAssistantDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                TransientAssistantDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                TransientAssistantDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                TransientAssistantDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                TransientAssistantDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                TransientAssistantDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransientAssistantDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => TransientAssistantDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => TransientAssistantDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => TransientAssistantDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => TransientAssistantDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => TransientAssistantDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => TransientAssistantDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => TransientAssistantDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => TransientAssistantDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => TransientAssistantDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => TransientAssistantDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => TransientAssistantDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => TransientAssistantDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => TransientAssistantDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => TransientAssistantDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => TransientAssistantDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => TransientAssistantDTOCredentialDiscriminatorProvider.Email,
                "gcp" => TransientAssistantDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => TransientAssistantDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => TransientAssistantDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => TransientAssistantDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => TransientAssistantDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => TransientAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => TransientAssistantDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => TransientAssistantDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => TransientAssistantDTOCredentialDiscriminatorProvider.Groq,
                "hume" => TransientAssistantDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => TransientAssistantDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => TransientAssistantDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => TransientAssistantDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => TransientAssistantDTOCredentialDiscriminatorProvider.Make,
                "microsoft" => TransientAssistantDTOCredentialDiscriminatorProvider.Microsoft,
                "minimax" => TransientAssistantDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => TransientAssistantDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => TransientAssistantDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => TransientAssistantDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => TransientAssistantDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => TransientAssistantDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => TransientAssistantDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => TransientAssistantDTOCredentialDiscriminatorProvider.S3,
                "s3-compatible" => TransientAssistantDTOCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => TransientAssistantDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => TransientAssistantDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => TransientAssistantDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => TransientAssistantDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => TransientAssistantDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => TransientAssistantDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => TransientAssistantDTOCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => TransientAssistantDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => TransientAssistantDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => TransientAssistantDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => TransientAssistantDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => TransientAssistantDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}