
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCerebrasCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCerebrasCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCerebrasCredentialDTOProvider value)
        {
            return value switch
            {
                UpdateCerebrasCredentialDTOProvider.Cerebras => "cerebras",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCerebrasCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "cerebras" => UpdateCerebrasCredentialDTOProvider.Cerebras,
                _ => null,
            };
        }
    }
}