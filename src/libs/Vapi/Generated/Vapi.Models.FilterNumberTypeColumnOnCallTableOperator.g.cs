
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// For number type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
    /// </summary>
    public enum FilterNumberTypeColumnOnCallTableOperator
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_3,
        /// <summary>
        /// 
        /// </summary>
        x__3,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        x_2,
        /// <summary>
        /// 
        /// </summary>
        x__2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterNumberTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterNumberTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterNumberTypeColumnOnCallTableOperator.x__ => "!=",
                FilterNumberTypeColumnOnCallTableOperator.x_3 => "<",
                FilterNumberTypeColumnOnCallTableOperator.x__3 => "<=",
                FilterNumberTypeColumnOnCallTableOperator.x_ => "=",
                FilterNumberTypeColumnOnCallTableOperator.x_2 => ">",
                FilterNumberTypeColumnOnCallTableOperator.x__2 => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterNumberTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => FilterNumberTypeColumnOnCallTableOperator.x__,
                "<" => FilterNumberTypeColumnOnCallTableOperator.x_3,
                "<=" => FilterNumberTypeColumnOnCallTableOperator.x__3,
                "=" => FilterNumberTypeColumnOnCallTableOperator.x_,
                ">" => FilterNumberTypeColumnOnCallTableOperator.x_2,
                ">=" => FilterNumberTypeColumnOnCallTableOperator.x__2,
                _ => null,
            };
        }
    }
}