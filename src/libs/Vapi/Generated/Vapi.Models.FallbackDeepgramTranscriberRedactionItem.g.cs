
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackDeepgramTranscriberRedactionItem
    {
        /// <summary>
        /// 
        /// </summary>
        Numbers,
        /// <summary>
        /// 
        /// </summary>
        Pci,
        /// <summary>
        /// 
        /// </summary>
        Phi,
        /// <summary>
        /// 
        /// </summary>
        Pii,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackDeepgramTranscriberRedactionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackDeepgramTranscriberRedactionItem value)
        {
            return value switch
            {
                FallbackDeepgramTranscriberRedactionItem.Numbers => "numbers",
                FallbackDeepgramTranscriberRedactionItem.Pci => "pci",
                FallbackDeepgramTranscriberRedactionItem.Phi => "phi",
                FallbackDeepgramTranscriberRedactionItem.Pii => "pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackDeepgramTranscriberRedactionItem? ToEnum(string value)
        {
            return value switch
            {
                "numbers" => FallbackDeepgramTranscriberRedactionItem.Numbers,
                "pci" => FallbackDeepgramTranscriberRedactionItem.Pci,
                "phi" => FallbackDeepgramTranscriberRedactionItem.Phi,
                "pii" => FallbackDeepgramTranscriberRedactionItem.Pii,
                _ => null,
            };
        }
    }
}