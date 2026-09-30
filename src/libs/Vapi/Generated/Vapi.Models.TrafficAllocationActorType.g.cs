
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Who created this allocation. 'system' means Vapi created it automatically, for example when a publish advances a follow-latest allocation.
    /// </summary>
    public enum TrafficAllocationActorType
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationActorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationActorType value)
        {
            return value switch
            {
                TrafficAllocationActorType.ApiKey => "api-key",
                TrafficAllocationActorType.System => "system",
                TrafficAllocationActorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationActorType? ToEnum(string value)
        {
            return value switch
            {
                "api-key" => TrafficAllocationActorType.ApiKey,
                "system" => TrafficAllocationActorType.System,
                "user" => TrafficAllocationActorType.User,
                _ => null,
            };
        }
    }
}