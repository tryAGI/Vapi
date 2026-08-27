
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum PersonalityControllerFindAllSortBy
    {
        /// <summary>
        ///
        /// </summary>
        Cost,
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
        /// <summary>
        ///
        /// </summary>
        Duration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonalityControllerFindAllSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonalityControllerFindAllSortBy value)
        {
            return value switch
            {
                PersonalityControllerFindAllSortBy.Cost => "cost",
                PersonalityControllerFindAllSortBy.CreatedAt => "createdAt",
                PersonalityControllerFindAllSortBy.Duration => "duration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonalityControllerFindAllSortBy? ToEnum(string value)
        {
            return value switch
            {
                "cost" => PersonalityControllerFindAllSortBy.Cost,
                "createdAt" => PersonalityControllerFindAllSortBy.CreatedAt,
                "duration" => PersonalityControllerFindAllSortBy.Duration,
                _ => null,
            };
        }
    }
}