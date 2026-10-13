
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum TrafficAllocationControllerCreateResponseDiscriminatorError
    {
        /// <summary>
        ///
        /// </summary>
        AssistantManagedByVapiAgents,
        /// <summary>
        ///
        /// </summary>
        StaleAllocation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrafficAllocationControllerCreateResponseDiscriminatorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrafficAllocationControllerCreateResponseDiscriminatorError value)
        {
            return value switch
            {
                TrafficAllocationControllerCreateResponseDiscriminatorError.AssistantManagedByVapiAgents => "assistant_managed_by_vapi_agents",
                TrafficAllocationControllerCreateResponseDiscriminatorError.StaleAllocation => "stale_allocation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrafficAllocationControllerCreateResponseDiscriminatorError? ToEnum(string value)
        {
            return value switch
            {
                "assistant_managed_by_vapi_agents" => TrafficAllocationControllerCreateResponseDiscriminatorError.AssistantManagedByVapiAgents,
                "stale_allocation" => TrafficAllocationControllerCreateResponseDiscriminatorError.StaleAllocation,
                _ => null,
            };
        }
    }
}