
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the HTTP method for the request (api-request tool).
    /// </summary>
    public enum UpdateToolDraftDTOMethod
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
    public static class UpdateToolDraftDTOMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateToolDraftDTOMethod value)
        {
            return value switch
            {
                UpdateToolDraftDTOMethod.Delete => "DELETE",
                UpdateToolDraftDTOMethod.Get => "GET",
                UpdateToolDraftDTOMethod.Patch => "PATCH",
                UpdateToolDraftDTOMethod.Post => "POST",
                UpdateToolDraftDTOMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateToolDraftDTOMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => UpdateToolDraftDTOMethod.Delete,
                "GET" => UpdateToolDraftDTOMethod.Get,
                "PATCH" => UpdateToolDraftDTOMethod.Patch,
                "POST" => UpdateToolDraftDTOMethod.Post,
                "PUT" => UpdateToolDraftDTOMethod.Put,
                _ => null,
            };
        }
    }
}