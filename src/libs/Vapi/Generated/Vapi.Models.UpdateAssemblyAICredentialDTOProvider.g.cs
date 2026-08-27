
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAssemblyAICredentialDTOProvider
    {
        /// <summary>
        ///
        /// </summary>
        AssemblyAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAssemblyAICredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAssemblyAICredentialDTOProvider value)
        {
            return value switch
            {
                UpdateAssemblyAICredentialDTOProvider.AssemblyAi => "assembly-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAssemblyAICredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "assembly-ai" => UpdateAssemblyAICredentialDTOProvider.AssemblyAi,
                _ => null,
            };
        }
    }
}