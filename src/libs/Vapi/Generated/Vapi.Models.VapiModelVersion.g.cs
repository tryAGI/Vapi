
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vapi-managed model version (update channel). When set, this is a Vapi-managed<br/>
    /// LLM routed by the registry; when absent, this is the legacy workflow form<br/>
    /// below (`steps` / `workflow`).
    /// </summary>
    public enum VapiModelVersion
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
    public static class VapiModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiModelVersion value)
        {
            return value switch
            {
                VapiModelVersion.x1 => "1",
                VapiModelVersion.Latest => "latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => VapiModelVersion.x1,
                "latest" => VapiModelVersion.Latest,
                _ => null,
            };
        }
    }
}