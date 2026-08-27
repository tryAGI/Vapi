
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateTransferCallToolDTOType
    {
        /// <summary>
        ///
        /// </summary>
        TransferCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTransferCallToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTransferCallToolDTOType value)
        {
            return value switch
            {
                UpdateTransferCallToolDTOType.TransferCall => "transferCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTransferCallToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "transferCall" => UpdateTransferCallToolDTOType.TransferCall,
                _ => null,
            };
        }
    }
}