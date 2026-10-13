
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum AssistantControllerRemoveResponseDiscriminatorError
    {
        /// <summary>
        ///
        /// </summary>
        AssistantManagedByVapiAgents,
        /// <summary>
        ///
        /// </summary>
        AssistantPinned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantControllerRemoveResponseDiscriminatorErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantControllerRemoveResponseDiscriminatorError value)
        {
            return value switch
            {
                AssistantControllerRemoveResponseDiscriminatorError.AssistantManagedByVapiAgents => "assistant_managed_by_vapi_agents",
                AssistantControllerRemoveResponseDiscriminatorError.AssistantPinned => "assistant_pinned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantControllerRemoveResponseDiscriminatorError? ToEnum(string value)
        {
            return value switch
            {
                "assistant_managed_by_vapi_agents" => AssistantControllerRemoveResponseDiscriminatorError.AssistantManagedByVapiAgents,
                "assistant_pinned" => AssistantControllerRemoveResponseDiscriminatorError.AssistantPinned,
                _ => null,
            };
        }
    }
}