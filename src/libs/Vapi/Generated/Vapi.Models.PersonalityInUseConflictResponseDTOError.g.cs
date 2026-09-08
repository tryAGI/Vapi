
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum PersonalityInUseConflictResponseDTOError
    {
        /// <summary>
        ///
        /// </summary>
        PersonalityInUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonalityInUseConflictResponseDTOErrorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonalityInUseConflictResponseDTOError value)
        {
            return value switch
            {
                PersonalityInUseConflictResponseDTOError.PersonalityInUse => "personality_in_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonalityInUseConflictResponseDTOError? ToEnum(string value)
        {
            return value switch
            {
                "personality_in_use" => PersonalityInUseConflictResponseDTOError.PersonalityInUse,
                _ => null,
            };
        }
    }
}