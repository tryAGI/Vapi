
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum EvalControllerGetRunsPaginatedSortBy
    {
        /// <summary>
        ///
        /// </summary>
        CreatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvalControllerGetRunsPaginatedSortByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvalControllerGetRunsPaginatedSortBy value)
        {
            return value switch
            {
                EvalControllerGetRunsPaginatedSortBy.CreatedAt => "createdAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvalControllerGetRunsPaginatedSortBy? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => EvalControllerGetRunsPaginatedSortBy.CreatedAt,
                _ => null,
            };
        }
    }
}