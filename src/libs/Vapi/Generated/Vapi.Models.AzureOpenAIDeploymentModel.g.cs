
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the model the deployment serves. It must be one of the credential's `models`.
    /// </summary>
    public enum AzureOpenAIDeploymentModel
    {
        /// <summary>
        ///
        /// </summary>
        Gpt35Turbo0125,
        /// <summary>
        ///
        /// </summary>
        Gpt35Turbo1106,
        /// <summary>
        ///
        /// </summary>
        Gpt40125Preview,
        /// <summary>
        ///
        /// </summary>
        Gpt40613,
        /// <summary>
        ///
        /// </summary>
        Gpt41106Preview,
        /// <summary>
        ///
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        ///
        /// </summary>
        Gpt41,
        /// <summary>
        ///
        /// </summary>
        Gpt4120250414,
        /// <summary>
        ///
        /// </summary>
        Gpt41Mini20250414,
        /// <summary>
        ///
        /// </summary>
        Gpt41Nano20250414,
        /// <summary>
        ///
        /// </summary>
        Gpt4o,
        /// <summary>
        ///
        /// </summary>
        Gpt4o20240513,
        /// <summary>
        ///
        /// </summary>
        Gpt4o20240806,
        /// <summary>
        ///
        /// </summary>
        Gpt4o20241120,
        /// <summary>
        ///
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        ///
        /// </summary>
        Gpt5,
        /// <summary>
        ///
        /// </summary>
        Gpt5Mini,
        /// <summary>
        ///
        /// </summary>
        Gpt5Nano,
        /// <summary>
        ///
        /// </summary>
        Gpt51,
        /// <summary>
        ///
        /// </summary>
        Gpt51Chat,
        /// <summary>
        ///
        /// </summary>
        Gpt52,
        /// <summary>
        ///
        /// </summary>
        Gpt52Chat,
        /// <summary>
        ///
        /// </summary>
        Gpt54,
        /// <summary>
        ///
        /// </summary>
        Gpt54Mini,
        /// <summary>
        ///
        /// </summary>
        Gpt54Mini20260317,
        /// <summary>
        ///
        /// </summary>
        Gpt54Nano,
        /// <summary>
        ///
        /// </summary>
        Gpt55,
        /// <summary>
        ///
        /// </summary>
        Gpt56Luna20260709,
        /// <summary>
        ///
        /// </summary>
        Gpt56Sol20260709,
        /// <summary>
        ///
        /// </summary>
        Gpt56Terra20260709,
        /// <summary>
        ///
        /// </summary>
        Gpt6Luna,
        /// <summary>
        ///
        /// </summary>
        Gpt6Luna20260922,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureOpenAIDeploymentModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAIDeploymentModel value)
        {
            return value switch
            {
                AzureOpenAIDeploymentModel.Gpt35Turbo0125 => "gpt-35-turbo-0125",
                AzureOpenAIDeploymentModel.Gpt35Turbo1106 => "gpt-35-turbo-1106",
                AzureOpenAIDeploymentModel.Gpt40125Preview => "gpt-4-0125-preview",
                AzureOpenAIDeploymentModel.Gpt40613 => "gpt-4-0613",
                AzureOpenAIDeploymentModel.Gpt41106Preview => "gpt-4-1106-preview",
                AzureOpenAIDeploymentModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                AzureOpenAIDeploymentModel.Gpt41 => "gpt-4.1",
                AzureOpenAIDeploymentModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                AzureOpenAIDeploymentModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                AzureOpenAIDeploymentModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                AzureOpenAIDeploymentModel.Gpt4o => "gpt-4o",
                AzureOpenAIDeploymentModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                AzureOpenAIDeploymentModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                AzureOpenAIDeploymentModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                AzureOpenAIDeploymentModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                AzureOpenAIDeploymentModel.Gpt5 => "gpt-5",
                AzureOpenAIDeploymentModel.Gpt5Mini => "gpt-5-mini",
                AzureOpenAIDeploymentModel.Gpt5Nano => "gpt-5-nano",
                AzureOpenAIDeploymentModel.Gpt51 => "gpt-5.1",
                AzureOpenAIDeploymentModel.Gpt51Chat => "gpt-5.1-chat",
                AzureOpenAIDeploymentModel.Gpt52 => "gpt-5.2",
                AzureOpenAIDeploymentModel.Gpt52Chat => "gpt-5.2-chat",
                AzureOpenAIDeploymentModel.Gpt54 => "gpt-5.4",
                AzureOpenAIDeploymentModel.Gpt54Mini => "gpt-5.4-mini",
                AzureOpenAIDeploymentModel.Gpt54Mini20260317 => "gpt-5.4-mini-2026-03-17",
                AzureOpenAIDeploymentModel.Gpt54Nano => "gpt-5.4-nano",
                AzureOpenAIDeploymentModel.Gpt55 => "gpt-5.5",
                AzureOpenAIDeploymentModel.Gpt56Luna20260709 => "gpt-5.6-luna-2026-07-09",
                AzureOpenAIDeploymentModel.Gpt56Sol20260709 => "gpt-5.6-sol-2026-07-09",
                AzureOpenAIDeploymentModel.Gpt56Terra20260709 => "gpt-5.6-terra-2026-07-09",
                AzureOpenAIDeploymentModel.Gpt6Luna => "gpt-6-luna",
                AzureOpenAIDeploymentModel.Gpt6Luna20260922 => "gpt-6-luna-2026-09-22",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAIDeploymentModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-35-turbo-0125" => AzureOpenAIDeploymentModel.Gpt35Turbo0125,
                "gpt-35-turbo-1106" => AzureOpenAIDeploymentModel.Gpt35Turbo1106,
                "gpt-4-0125-preview" => AzureOpenAIDeploymentModel.Gpt40125Preview,
                "gpt-4-0613" => AzureOpenAIDeploymentModel.Gpt40613,
                "gpt-4-1106-preview" => AzureOpenAIDeploymentModel.Gpt41106Preview,
                "gpt-4-turbo-2024-04-09" => AzureOpenAIDeploymentModel.Gpt4Turbo20240409,
                "gpt-4.1" => AzureOpenAIDeploymentModel.Gpt41,
                "gpt-4.1-2025-04-14" => AzureOpenAIDeploymentModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => AzureOpenAIDeploymentModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => AzureOpenAIDeploymentModel.Gpt41Nano20250414,
                "gpt-4o" => AzureOpenAIDeploymentModel.Gpt4o,
                "gpt-4o-2024-05-13" => AzureOpenAIDeploymentModel.Gpt4o20240513,
                "gpt-4o-2024-08-06" => AzureOpenAIDeploymentModel.Gpt4o20240806,
                "gpt-4o-2024-11-20" => AzureOpenAIDeploymentModel.Gpt4o20241120,
                "gpt-4o-mini-2024-07-18" => AzureOpenAIDeploymentModel.Gpt4oMini20240718,
                "gpt-5" => AzureOpenAIDeploymentModel.Gpt5,
                "gpt-5-mini" => AzureOpenAIDeploymentModel.Gpt5Mini,
                "gpt-5-nano" => AzureOpenAIDeploymentModel.Gpt5Nano,
                "gpt-5.1" => AzureOpenAIDeploymentModel.Gpt51,
                "gpt-5.1-chat" => AzureOpenAIDeploymentModel.Gpt51Chat,
                "gpt-5.2" => AzureOpenAIDeploymentModel.Gpt52,
                "gpt-5.2-chat" => AzureOpenAIDeploymentModel.Gpt52Chat,
                "gpt-5.4" => AzureOpenAIDeploymentModel.Gpt54,
                "gpt-5.4-mini" => AzureOpenAIDeploymentModel.Gpt54Mini,
                "gpt-5.4-mini-2026-03-17" => AzureOpenAIDeploymentModel.Gpt54Mini20260317,
                "gpt-5.4-nano" => AzureOpenAIDeploymentModel.Gpt54Nano,
                "gpt-5.5" => AzureOpenAIDeploymentModel.Gpt55,
                "gpt-5.6-luna-2026-07-09" => AzureOpenAIDeploymentModel.Gpt56Luna20260709,
                "gpt-5.6-sol-2026-07-09" => AzureOpenAIDeploymentModel.Gpt56Sol20260709,
                "gpt-5.6-terra-2026-07-09" => AzureOpenAIDeploymentModel.Gpt56Terra20260709,
                "gpt-6-luna" => AzureOpenAIDeploymentModel.Gpt6Luna,
                "gpt-6-luna-2026-09-22" => AzureOpenAIDeploymentModel.Gpt6Luna20260922,
                _ => null,
            };
        }
    }
}