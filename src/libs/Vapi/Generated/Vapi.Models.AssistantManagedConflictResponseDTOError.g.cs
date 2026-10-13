
#nullable enable

namespace Vapi
{
    /// <summary>
    /// Vapi Agents manages the assistant. The lock refuses writes to the assistant itself (update, replace, delete, restore, version delete, traffic splits) and to outcomes, monitors and structured outputs that link or unlink it. It doesn't cover what changes a call without writing the assistant: call-level assistantOverrides or assistantVersion, squad member pins and overrides, which phone number points at it, edits to the tools or knowledge bases it references, or Vapi's own model-retirement sweep.
    /// </summary>
    public enum AssistantManagedConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        AssistantManagedByVapiAgents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssistantManagedConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssistantManagedConflictResponseDTOError value)
        {
            return value switch
            {
                AssistantManagedConflictResponseDTOError.AssistantManagedByVapiAgents => "assistant_managed_by_vapi_agents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssistantManagedConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "assistant_managed_by_vapi_agents" => AssistantManagedConflictResponseDTOError.AssistantManagedByVapiAgents,
                _ => null,
            };
        }
    }
}