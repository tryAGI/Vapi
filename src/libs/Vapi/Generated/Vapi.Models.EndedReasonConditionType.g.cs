
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type discriminator for the endedReason condition.<br/>
    /// Example: endedReason
    /// </summary>
    public enum EndedReasonConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        EndedReason,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndedReasonConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndedReasonConditionType value)
        {
            return value switch
            {
                EndedReasonConditionType.EndedReason => "endedReason",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndedReasonConditionType? ToEnum(string value)
        {
            return value switch
            {
                "endedReason" => EndedReasonConditionType.EndedReason,
                _ => null,
            };
        }
    }
}