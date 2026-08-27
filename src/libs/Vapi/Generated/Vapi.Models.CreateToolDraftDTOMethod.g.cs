
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the HTTP method for the request (api-request tool).
    /// </summary>
    public enum CreateToolDraftDTOMethod
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
        /// <summary>
        ///
        /// </summary>
        Get,
        /// <summary>
        ///
        /// </summary>
        Patch,
        /// <summary>
        ///
        /// </summary>
        Post,
        /// <summary>
        ///
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolDraftDTOMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolDraftDTOMethod value)
        {
            return value switch
            {
                CreateToolDraftDTOMethod.Delete => "DELETE",
                CreateToolDraftDTOMethod.Get => "GET",
                CreateToolDraftDTOMethod.Patch => "PATCH",
                CreateToolDraftDTOMethod.Post => "POST",
                CreateToolDraftDTOMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolDraftDTOMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => CreateToolDraftDTOMethod.Delete,
                "GET" => CreateToolDraftDTOMethod.Get,
                "PATCH" => CreateToolDraftDTOMethod.Patch,
                "POST" => CreateToolDraftDTOMethod.Post,
                "PUT" => CreateToolDraftDTOMethod.Put,
                _ => null,
            };
        }
    }
}