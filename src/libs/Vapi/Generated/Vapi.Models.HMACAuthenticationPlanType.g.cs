
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum HMACAuthenticationPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        Hmac,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HMACAuthenticationPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HMACAuthenticationPlanType value)
        {
            return value switch
            {
                HMACAuthenticationPlanType.Hmac => "hmac",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HMACAuthenticationPlanType? ToEnum(string value)
        {
            return value switch
            {
                "hmac" => HMACAuthenticationPlanType.Hmac,
                _ => null,
            };
        }
    }
}