
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeepgramTranscriberRedactionItem
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
    public static class DeepgramTranscriberRedactionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeepgramTranscriberRedactionItem value)
        {
            return value switch
            {
                DeepgramTranscriberRedactionItem.Numbers => "numbers",
                DeepgramTranscriberRedactionItem.Pci => "pci",
                DeepgramTranscriberRedactionItem.Phi => "phi",
                DeepgramTranscriberRedactionItem.Pii => "pii",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeepgramTranscriberRedactionItem? ToEnum(string value)
        {
            return value switch
            {
                "numbers" => DeepgramTranscriberRedactionItem.Numbers,
                "pci" => DeepgramTranscriberRedactionItem.Pci,
                "phi" => DeepgramTranscriberRedactionItem.Phi,
                "pii" => DeepgramTranscriberRedactionItem.Pii,
                _ => null,
            };
        }
    }
}