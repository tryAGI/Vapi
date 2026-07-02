
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateRimeAICredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        RimeAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateRimeAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRimeAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateRimeAICredentialDTOProvider.RimeAi => "rime-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRimeAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "rime-ai" => UpdateRimeAICredentialDTOProvider.RimeAi,
                _ => null,
            };
        }
    }
}