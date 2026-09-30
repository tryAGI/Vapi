
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 'explicit' splits calls across targets, and is inferred when targets is sent. 'follow-latest' sends every call to the newest published version and is how you stop splitting; it must be sent explicitly.
    /// </summary>
    public enum CreateTrafficAllocationDTOAllocationIntent
    {
        /// <summary>
        ///
        /// </summary>
        Explicit,
        /// <summary>
        ///
        /// </summary>
        FollowLatest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTrafficAllocationDTOAllocationIntentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTrafficAllocationDTOAllocationIntent value)
        {
            return value switch
            {
                CreateTrafficAllocationDTOAllocationIntent.Explicit => "explicit",
                CreateTrafficAllocationDTOAllocationIntent.FollowLatest => "follow-latest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTrafficAllocationDTOAllocationIntent? ToEnum(string value)
        {
            return value switch
            {
                "explicit" => CreateTrafficAllocationDTOAllocationIntent.Explicit,
                "follow-latest" => CreateTrafficAllocationDTOAllocationIntent.FollowLatest,
                _ => null,
            };
        }
    }
}