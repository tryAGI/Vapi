
#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the operator to use for the filter.<br/>
    /// The operator depends on the value type of the structured output.<br/>
    /// If the structured output is a string or boolean, the operator must be "=", "!="<br/>
    /// If the structured output is a number, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="<br/>
    /// If the structured output is an array, the operator must be "in" or "not_in"<br/>
    /// Example: "=" or "&gt;" or "&lt;" or "in" or "not_in"
    /// </summary>
    public enum FilterStructuredOutputColumnOnCallTableOperator
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
        /// <summary>
        /// 
        /// </summary>
        Contains,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        IsEmpty,
        /// <summary>
        /// 
        /// </summary>
        IsNotEmpty,
        /// <summary>
        /// 
        /// </summary>
        NotContains,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilterStructuredOutputColumnOnCallTableOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStructuredOutputColumnOnCallTableOperator value)
        {
            return value switch
            {
                FilterStructuredOutputColumnOnCallTableOperator.x__ => "!=",
                FilterStructuredOutputColumnOnCallTableOperator.x_3 => "<",
                FilterStructuredOutputColumnOnCallTableOperator.x__3 => "<=",
                FilterStructuredOutputColumnOnCallTableOperator.x_ => "=",
                FilterStructuredOutputColumnOnCallTableOperator.x_2 => ">",
                FilterStructuredOutputColumnOnCallTableOperator.x__2 => ">=",
                FilterStructuredOutputColumnOnCallTableOperator.Contains => "contains",
                FilterStructuredOutputColumnOnCallTableOperator.In => "in",
                FilterStructuredOutputColumnOnCallTableOperator.IsEmpty => "is_empty",
                FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty => "is_not_empty",
                FilterStructuredOutputColumnOnCallTableOperator.NotContains => "not_contains",
                FilterStructuredOutputColumnOnCallTableOperator.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStructuredOutputColumnOnCallTableOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => FilterStructuredOutputColumnOnCallTableOperator.x__,
                "<" => FilterStructuredOutputColumnOnCallTableOperator.x_3,
                "<=" => FilterStructuredOutputColumnOnCallTableOperator.x__3,
                "=" => FilterStructuredOutputColumnOnCallTableOperator.x_,
                ">" => FilterStructuredOutputColumnOnCallTableOperator.x_2,
                ">=" => FilterStructuredOutputColumnOnCallTableOperator.x__2,
                "contains" => FilterStructuredOutputColumnOnCallTableOperator.Contains,
                "in" => FilterStructuredOutputColumnOnCallTableOperator.In,
                "is_empty" => FilterStructuredOutputColumnOnCallTableOperator.IsEmpty,
                "is_not_empty" => FilterStructuredOutputColumnOnCallTableOperator.IsNotEmpty,
                "not_contains" => FilterStructuredOutputColumnOnCallTableOperator.NotContains,
                "not_in" => FilterStructuredOutputColumnOnCallTableOperator.NotIn,
                _ => null,
            };
        }
    }
}