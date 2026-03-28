
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// For date type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "&gt;=" or "&lt;="
    /// </summary>
    public enum FilterDateTypeColumnOnCallTableOperator
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
    public static class FilterDateTypeColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterDateTypeColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterDateTypeColumnOnCallTableOperator.x__ => "!=",
                FilterDateTypeColumnOnCallTableOperator.x_3 => "<",
                FilterDateTypeColumnOnCallTableOperator.x__3 => "<=",
                FilterDateTypeColumnOnCallTableOperator.x_ => "=",
                FilterDateTypeColumnOnCallTableOperator.x_2 => ">",
                FilterDateTypeColumnOnCallTableOperator.x__2 => ">=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterDateTypeColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => FilterDateTypeColumnOnCallTableOperator.x__,
                "<" => FilterDateTypeColumnOnCallTableOperator.x_3,
                "<=" => FilterDateTypeColumnOnCallTableOperator.x__3,
                "=" => FilterDateTypeColumnOnCallTableOperator.x_,
                ">" => FilterDateTypeColumnOnCallTableOperator.x_2,
                ">=" => FilterDateTypeColumnOnCallTableOperator.x__2,
                _ => null,
            };
        }
    }
}