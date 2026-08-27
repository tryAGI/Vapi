
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the type discriminator for the minCallDuration condition.<br/>
    /// Example: minCallDuration
    /// </summary>
    public enum MinCallDurationConditionType
    {
        /// <summary>
        ///
        /// </summary>
        MinCallDuration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MinCallDurationConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MinCallDurationConditionType value)
        {
            return value switch
            {
                MinCallDurationConditionType.MinCallDuration => "minCallDuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MinCallDurationConditionType? ToEnum(string value)
        {
            return value switch
            {
                "minCallDuration" => MinCallDurationConditionType.MinCallDuration,
                _ => null,
            };
        }
    }
}