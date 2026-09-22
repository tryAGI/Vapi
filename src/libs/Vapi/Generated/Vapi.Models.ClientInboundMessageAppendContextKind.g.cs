
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Commentary is spoken in the model's own words; thinking is silent context;<br/>
    /// instructions steer the speaker, including requests to try saying something.<br/>
    /// Acceptance does not guarantee exact wording or speech completion.
    /// </summary>
    public enum ClientInboundMessageAppendContextKind
    {
        /// <summary>
        ///
        /// </summary>
        Commentary,
        /// <summary>
        ///
        /// </summary>
        Instructions,
        /// <summary>
        ///
        /// </summary>
        Thinking,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageAppendContextKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageAppendContextKind value)
        {
            return value switch
            {
                ClientInboundMessageAppendContextKind.Commentary => "commentary",
                ClientInboundMessageAppendContextKind.Instructions => "instructions",
                ClientInboundMessageAppendContextKind.Thinking => "thinking",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageAppendContextKind? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => ClientInboundMessageAppendContextKind.Commentary,
                "instructions" => ClientInboundMessageAppendContextKind.Instructions,
                "thinking" => ClientInboundMessageAppendContextKind.Thinking,
                _ => null,
            };
        }
    }
}