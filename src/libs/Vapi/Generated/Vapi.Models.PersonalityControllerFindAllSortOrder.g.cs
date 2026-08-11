
#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public enum PersonalityControllerFindAllSortOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersonalityControllerFindAllSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersonalityControllerFindAllSortOrder value)
        {
            return value switch
            {
                PersonalityControllerFindAllSortOrder.Asc => "ASC",
                PersonalityControllerFindAllSortOrder.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersonalityControllerFindAllSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => PersonalityControllerFindAllSortOrder.Asc,
                "DESC" => PersonalityControllerFindAllSortOrder.Desc,
                _ => null,
            };
        }
    }
}