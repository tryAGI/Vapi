
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the version of the Vapi transcriber. Vapi manages the underlying<br/>
    /// model and routing. When omitted, the latest version is used.<br/>
    /// Managed version params are additive-only and `'latest'` is an auto-update<br/>
    /// channel — see the param-evolution INVARIANT in `vapiManaged/types.ts`.
    /// </summary>
    public enum VapiTranscriberVersion
    {
        /// <summary>
        ///
        /// </summary>
        x1,
        /// <summary>
        ///
        /// </summary>
        Latest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiTranscriberVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiTranscriberVersion value)
        {
            return value switch
            {
                VapiTranscriberVersion.x1 => "1",
                VapiTranscriberVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiTranscriberVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => VapiTranscriberVersion.x1,
                "latest" => VapiTranscriberVersion.Latest,
                _ => null,
            };
        }
    }
}