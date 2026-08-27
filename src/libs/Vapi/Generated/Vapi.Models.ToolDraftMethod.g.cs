
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the HTTP method for the request (api-request tool).
    /// </summary>
    public enum ToolDraftMethod
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
    public static class ToolDraftMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolDraftMethod value)
        {
            return value switch
            {
                ToolDraftMethod.Delete => "DELETE",
                ToolDraftMethod.Get => "GET",
                ToolDraftMethod.Patch => "PATCH",
                ToolDraftMethod.Post => "POST",
                ToolDraftMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolDraftMethod? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => ToolDraftMethod.Delete,
                "GET" => ToolDraftMethod.Get,
                "PATCH" => ToolDraftMethod.Patch,
                "POST" => ToolDraftMethod.Post,
                "PUT" => ToolDraftMethod.Put,
                _ => null,
            };
        }
    }
}