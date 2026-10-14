
#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public enum UserWithRoleRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        HipaaSpecial,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserWithRoleRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserWithRoleRole value)
        {
            return value switch
            {
                UserWithRoleRole.Admin => "admin",
                UserWithRoleRole.Editor => "editor",
                UserWithRoleRole.HipaaSpecial => "hipaa-special",
                UserWithRoleRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserWithRoleRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => UserWithRoleRole.Admin,
                "editor" => UserWithRoleRole.Editor,
                "hipaa-special" => UserWithRoleRole.HipaaSpecial,
                "viewer" => UserWithRoleRole.Viewer,
                _ => null,
            };
        }
    }
}