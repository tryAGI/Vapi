
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantSaveResponseCredentialDiscriminatorProvider
    {
        /// <summary>
        ///
        /// </summary>
        x11labs,
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
        Reson8,
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
    public static class AssistantSaveResponseCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantSaveResponseCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                AssistantSaveResponseCredentialDiscriminatorProvider.x11labs => "11labs",
                AssistantSaveResponseCredentialDiscriminatorProvider.Anthropic => "anthropic",
                AssistantSaveResponseCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                AssistantSaveResponseCredentialDiscriminatorProvider.Anyscale => "anyscale",
                AssistantSaveResponseCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Azure => "azure",
                AssistantSaveResponseCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                AssistantSaveResponseCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                AssistantSaveResponseCredentialDiscriminatorProvider.Cartesia => "cartesia",
                AssistantSaveResponseCredentialDiscriminatorProvider.Cerebras => "cerebras",
                AssistantSaveResponseCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                AssistantSaveResponseCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                AssistantSaveResponseCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                AssistantSaveResponseCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                AssistantSaveResponseCredentialDiscriminatorProvider.Deepgram => "deepgram",
                AssistantSaveResponseCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                AssistantSaveResponseCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                AssistantSaveResponseCredentialDiscriminatorProvider.Email => "email",
                AssistantSaveResponseCredentialDiscriminatorProvider.Gcp => "gcp",
                AssistantSaveResponseCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                AssistantSaveResponseCredentialDiscriminatorProvider.Gladia => "gladia",
                AssistantSaveResponseCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                AssistantSaveResponseCredentialDiscriminatorProvider.Google => "google",
                AssistantSaveResponseCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                AssistantSaveResponseCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                AssistantSaveResponseCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                AssistantSaveResponseCredentialDiscriminatorProvider.Groq => "groq",
                AssistantSaveResponseCredentialDiscriminatorProvider.Hume => "hume",
                AssistantSaveResponseCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Inworld => "inworld",
                AssistantSaveResponseCredentialDiscriminatorProvider.Langfuse => "langfuse",
                AssistantSaveResponseCredentialDiscriminatorProvider.Lmnt => "lmnt",
                AssistantSaveResponseCredentialDiscriminatorProvider.Make => "make",
                AssistantSaveResponseCredentialDiscriminatorProvider.Microsoft => "microsoft",
                AssistantSaveResponseCredentialDiscriminatorProvider.Minimax => "minimax",
                AssistantSaveResponseCredentialDiscriminatorProvider.Mistral => "mistral",
                AssistantSaveResponseCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                AssistantSaveResponseCredentialDiscriminatorProvider.Openai => "openai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Openrouter => "openrouter",
                AssistantSaveResponseCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Playht => "playht",
                AssistantSaveResponseCredentialDiscriminatorProvider.Reson8 => "reson8",
                AssistantSaveResponseCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Runpod => "runpod",
                AssistantSaveResponseCredentialDiscriminatorProvider.S3 => "s3",
                AssistantSaveResponseCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                AssistantSaveResponseCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                AssistantSaveResponseCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                AssistantSaveResponseCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Soniox => "soniox",
                AssistantSaveResponseCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                AssistantSaveResponseCredentialDiscriminatorProvider.Supabase => "supabase",
                AssistantSaveResponseCredentialDiscriminatorProvider.Tavus => "tavus",
                AssistantSaveResponseCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                AssistantSaveResponseCredentialDiscriminatorProvider.Twilio => "twilio",
                AssistantSaveResponseCredentialDiscriminatorProvider.Vonage => "vonage",
                AssistantSaveResponseCredentialDiscriminatorProvider.Webhook => "webhook",
                AssistantSaveResponseCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                AssistantSaveResponseCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantSaveResponseCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "11labs" => AssistantSaveResponseCredentialDiscriminatorProvider.x11labs,
                "anthropic" => AssistantSaveResponseCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => AssistantSaveResponseCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => AssistantSaveResponseCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => AssistantSaveResponseCredentialDiscriminatorProvider.Azure,
                "azure-openai" => AssistantSaveResponseCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => AssistantSaveResponseCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => AssistantSaveResponseCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => AssistantSaveResponseCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => AssistantSaveResponseCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => AssistantSaveResponseCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => AssistantSaveResponseCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => AssistantSaveResponseCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => AssistantSaveResponseCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => AssistantSaveResponseCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => AssistantSaveResponseCredentialDiscriminatorProvider.Elevenlabs,
                "email" => AssistantSaveResponseCredentialDiscriminatorProvider.Email,
                "gcp" => AssistantSaveResponseCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => AssistantSaveResponseCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => AssistantSaveResponseCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => AssistantSaveResponseCredentialDiscriminatorProvider.Gohighlevel,
                "google" => AssistantSaveResponseCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => AssistantSaveResponseCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => AssistantSaveResponseCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => AssistantSaveResponseCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => AssistantSaveResponseCredentialDiscriminatorProvider.Groq,
                "hume" => AssistantSaveResponseCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => AssistantSaveResponseCredentialDiscriminatorProvider.Inworld,
                "langfuse" => AssistantSaveResponseCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => AssistantSaveResponseCredentialDiscriminatorProvider.Lmnt,
                "make" => AssistantSaveResponseCredentialDiscriminatorProvider.Make,
                "microsoft" => AssistantSaveResponseCredentialDiscriminatorProvider.Microsoft,
                "minimax" => AssistantSaveResponseCredentialDiscriminatorProvider.Minimax,
                "mistral" => AssistantSaveResponseCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => AssistantSaveResponseCredentialDiscriminatorProvider.Neuphonic,
                "openai" => AssistantSaveResponseCredentialDiscriminatorProvider.Openai,
                "openrouter" => AssistantSaveResponseCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => AssistantSaveResponseCredentialDiscriminatorProvider.Playht,
                "reson8" => AssistantSaveResponseCredentialDiscriminatorProvider.Reson8,
                "rime-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.RimeAi,
                "runpod" => AssistantSaveResponseCredentialDiscriminatorProvider.Runpod,
                "s3" => AssistantSaveResponseCredentialDiscriminatorProvider.S3,
                "s3-compatible" => AssistantSaveResponseCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => AssistantSaveResponseCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => AssistantSaveResponseCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => AssistantSaveResponseCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => AssistantSaveResponseCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => AssistantSaveResponseCredentialDiscriminatorProvider.Supabase,
                "tavus" => AssistantSaveResponseCredentialDiscriminatorProvider.Tavus,
                "together-ai" => AssistantSaveResponseCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => AssistantSaveResponseCredentialDiscriminatorProvider.Twilio,
                "vonage" => AssistantSaveResponseCredentialDiscriminatorProvider.Vonage,
                "webhook" => AssistantSaveResponseCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => AssistantSaveResponseCredentialDiscriminatorProvider.Wellsaid,
                "xai" => AssistantSaveResponseCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}