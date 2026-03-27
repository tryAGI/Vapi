
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTransferCallToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        TransferCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTransferCallToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTransferCallToolDTOType value)
        {
            return value switch
            {
                CreateTransferCallToolDTOType.TransferCall => "transferCall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTransferCallToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "transferCall" => CreateTransferCallToolDTOType.TransferCall,
                _ => null,
            };
        }
    }
}