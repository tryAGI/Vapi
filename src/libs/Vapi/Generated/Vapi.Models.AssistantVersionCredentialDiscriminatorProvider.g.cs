
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantVersionCredentialDiscriminatorProvider
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
    public static class AssistantVersionCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantVersionCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                AssistantVersionCredentialDiscriminatorProvider.Anthropic => "anthropic",
                AssistantVersionCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                AssistantVersionCredentialDiscriminatorProvider.Anyscale => "anyscale",
                AssistantVersionCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                AssistantVersionCredentialDiscriminatorProvider.Azure => "azure",
                AssistantVersionCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                AssistantVersionCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                AssistantVersionCredentialDiscriminatorProvider.Cartesia => "cartesia",
                AssistantVersionCredentialDiscriminatorProvider.Cerebras => "cerebras",
                AssistantVersionCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                AssistantVersionCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                AssistantVersionCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                AssistantVersionCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                AssistantVersionCredentialDiscriminatorProvider.Deepgram => "deepgram",
                AssistantVersionCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                AssistantVersionCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                AssistantVersionCredentialDiscriminatorProvider.Email => "email",
                AssistantVersionCredentialDiscriminatorProvider.Gcp => "gcp",
                AssistantVersionCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                AssistantVersionCredentialDiscriminatorProvider.Gladia => "gladia",
                AssistantVersionCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                AssistantVersionCredentialDiscriminatorProvider.Google => "google",
                AssistantVersionCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                AssistantVersionCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                AssistantVersionCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                AssistantVersionCredentialDiscriminatorProvider.Groq => "groq",
                AssistantVersionCredentialDiscriminatorProvider.Hume => "hume",
                AssistantVersionCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                AssistantVersionCredentialDiscriminatorProvider.Inworld => "inworld",
                AssistantVersionCredentialDiscriminatorProvider.Langfuse => "langfuse",
                AssistantVersionCredentialDiscriminatorProvider.Lmnt => "lmnt",
                AssistantVersionCredentialDiscriminatorProvider.Make => "make",
                AssistantVersionCredentialDiscriminatorProvider.Microsoft => "microsoft",
                AssistantVersionCredentialDiscriminatorProvider.Minimax => "minimax",
                AssistantVersionCredentialDiscriminatorProvider.Mistral => "mistral",
                AssistantVersionCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                AssistantVersionCredentialDiscriminatorProvider.Openai => "openai",
                AssistantVersionCredentialDiscriminatorProvider.Openrouter => "openrouter",
                AssistantVersionCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                AssistantVersionCredentialDiscriminatorProvider.Playht => "playht",
                AssistantVersionCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                AssistantVersionCredentialDiscriminatorProvider.Runpod => "runpod",
                AssistantVersionCredentialDiscriminatorProvider.S3 => "s3",
                AssistantVersionCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                AssistantVersionCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                AssistantVersionCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                AssistantVersionCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                AssistantVersionCredentialDiscriminatorProvider.Soniox => "soniox",
                AssistantVersionCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                AssistantVersionCredentialDiscriminatorProvider.Supabase => "supabase",
                AssistantVersionCredentialDiscriminatorProvider.Tavus => "tavus",
                AssistantVersionCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                AssistantVersionCredentialDiscriminatorProvider.Twilio => "twilio",
                AssistantVersionCredentialDiscriminatorProvider.Vonage => "vonage",
                AssistantVersionCredentialDiscriminatorProvider.Webhook => "webhook",
                AssistantVersionCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                AssistantVersionCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantVersionCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AssistantVersionCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => AssistantVersionCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => AssistantVersionCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => AssistantVersionCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => AssistantVersionCredentialDiscriminatorProvider.Azure,
                "azure-openai" => AssistantVersionCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => AssistantVersionCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => AssistantVersionCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => AssistantVersionCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => AssistantVersionCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => AssistantVersionCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => AssistantVersionCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => AssistantVersionCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => AssistantVersionCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => AssistantVersionCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => AssistantVersionCredentialDiscriminatorProvider.Elevenlabs,
                "email" => AssistantVersionCredentialDiscriminatorProvider.Email,
                "gcp" => AssistantVersionCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => AssistantVersionCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => AssistantVersionCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => AssistantVersionCredentialDiscriminatorProvider.Gohighlevel,
                "google" => AssistantVersionCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => AssistantVersionCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => AssistantVersionCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => AssistantVersionCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => AssistantVersionCredentialDiscriminatorProvider.Groq,
                "hume" => AssistantVersionCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => AssistantVersionCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => AssistantVersionCredentialDiscriminatorProvider.Inworld,
                "langfuse" => AssistantVersionCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => AssistantVersionCredentialDiscriminatorProvider.Lmnt,
                "make" => AssistantVersionCredentialDiscriminatorProvider.Make,
                "microsoft" => AssistantVersionCredentialDiscriminatorProvider.Microsoft,
                "minimax" => AssistantVersionCredentialDiscriminatorProvider.Minimax,
                "mistral" => AssistantVersionCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => AssistantVersionCredentialDiscriminatorProvider.Neuphonic,
                "openai" => AssistantVersionCredentialDiscriminatorProvider.Openai,
                "openrouter" => AssistantVersionCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => AssistantVersionCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => AssistantVersionCredentialDiscriminatorProvider.Playht,
                "rime-ai" => AssistantVersionCredentialDiscriminatorProvider.RimeAi,
                "runpod" => AssistantVersionCredentialDiscriminatorProvider.Runpod,
                "s3" => AssistantVersionCredentialDiscriminatorProvider.S3,
                "s3-compatible" => AssistantVersionCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => AssistantVersionCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => AssistantVersionCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => AssistantVersionCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => AssistantVersionCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => AssistantVersionCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => AssistantVersionCredentialDiscriminatorProvider.Supabase,
                "tavus" => AssistantVersionCredentialDiscriminatorProvider.Tavus,
                "together-ai" => AssistantVersionCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => AssistantVersionCredentialDiscriminatorProvider.Twilio,
                "vonage" => AssistantVersionCredentialDiscriminatorProvider.Vonage,
                "webhook" => AssistantVersionCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => AssistantVersionCredentialDiscriminatorProvider.Wellsaid,
                "xai" => AssistantVersionCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}