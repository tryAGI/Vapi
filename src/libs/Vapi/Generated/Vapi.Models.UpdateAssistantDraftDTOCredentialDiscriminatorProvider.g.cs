
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAssistantDraftDTOCredentialDiscriminatorProvider
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
    public static class UpdateAssistantDraftDTOCredentialDiscriminatorProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssistantDraftDTOCredentialDiscriminatorProvider value)
        {
            return value switch
            {
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Anthropic => "anthropic",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AnthropicBedrock => "anthropic-bedrock",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Anyscale => "anyscale",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AssemblyAi => "assembly-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Azure => "azure",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AzureOpenai => "azure-openai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.ByoSipTrunk => "byo-sip-trunk",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cartesia => "cartesia",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cerebras => "cerebras",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cloudflare => "cloudflare",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.CustomCredential => "custom-credential",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.CustomLlm => "custom-llm",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.DeepSeek => "deep-seek",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Deepgram => "deepgram",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Deepinfra => "deepinfra",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Elevenlabs => "elevenlabs",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Email => "email",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gcp => "gcp",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GhlOauth2Authorization => "ghl.oauth2-authorization",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gladia => "gladia",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gohighlevel => "gohighlevel",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Google => "google",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization => "google.calendar.oauth2-authorization",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client => "google.calendar.oauth2-client",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization => "google.sheets.oauth2-authorization",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Groq => "groq",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Hume => "hume",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.InflectionAi => "inflection-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Inworld => "inworld",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Langfuse => "langfuse",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Lmnt => "lmnt",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Make => "make",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Microsoft => "microsoft",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Minimax => "minimax",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Mistral => "mistral",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Neuphonic => "neuphonic",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Openai => "openai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Openrouter => "openrouter",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.PerplexityAi => "perplexity-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Playht => "playht",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.RimeAi => "rime-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Runpod => "runpod",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.S3 => "s3",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.S3Compatible => "s3-compatible",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SlackWebhook => "slack-webhook",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SlackOauth2Authorization => "slack.oauth2-authorization",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SmallestAi => "smallest-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Soniox => "soniox",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Speechmatics => "speechmatics",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Supabase => "supabase",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Tavus => "tavus",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.TogetherAi => "together-ai",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Twilio => "twilio",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Vonage => "vonage",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Webhook => "webhook",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Wellsaid => "wellsaid",
                UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssistantDraftDTOCredentialDiscriminatorProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Anthropic,
                "anthropic-bedrock" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AnthropicBedrock,
                "anyscale" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Anyscale,
                "assembly-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AssemblyAi,
                "azure" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Azure,
                "azure-openai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.AzureOpenai,
                "byo-sip-trunk" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.ByoSipTrunk,
                "cartesia" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cartesia,
                "cerebras" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cerebras,
                "cloudflare" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Cloudflare,
                "custom-credential" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.CustomCredential,
                "custom-llm" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.CustomLlm,
                "deep-seek" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.DeepSeek,
                "deepgram" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Deepgram,
                "deepinfra" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Deepinfra,
                "elevenlabs" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Elevenlabs,
                "email" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Email,
                "gcp" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gcp,
                "ghl.oauth2-authorization" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GhlOauth2Authorization,
                "gladia" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gladia,
                "gohighlevel" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Gohighlevel,
                "google" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Google,
                "google.calendar.oauth2-authorization" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Authorization,
                "google.calendar.oauth2-client" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleCalendarOauth2Client,
                "google.sheets.oauth2-authorization" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.GoogleSheetsOauth2Authorization,
                "groq" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Groq,
                "hume" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Hume,
                "inflection-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.InflectionAi,
                "inworld" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Inworld,
                "langfuse" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Langfuse,
                "lmnt" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Lmnt,
                "make" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Make,
                "microsoft" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Microsoft,
                "minimax" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Minimax,
                "mistral" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Mistral,
                "neuphonic" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Neuphonic,
                "openai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Openai,
                "openrouter" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Openrouter,
                "perplexity-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.PerplexityAi,
                "playht" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Playht,
                "rime-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.RimeAi,
                "runpod" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Runpod,
                "s3" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.S3,
                "s3-compatible" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.S3Compatible,
                "slack-webhook" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SlackWebhook,
                "slack.oauth2-authorization" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SlackOauth2Authorization,
                "smallest-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.SmallestAi,
                "soniox" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Soniox,
                "speechmatics" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Speechmatics,
                "supabase" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Supabase,
                "tavus" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Tavus,
                "together-ai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.TogetherAi,
                "twilio" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Twilio,
                "vonage" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Vonage,
                "webhook" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Webhook,
                "wellsaid" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Wellsaid,
                "xai" => UpdateAssistantDraftDTOCredentialDiscriminatorProvider.Xai,
                _ => null,
            };
        }
    }
}