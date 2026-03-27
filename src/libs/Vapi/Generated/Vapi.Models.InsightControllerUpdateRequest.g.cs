#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerUpdateRequest : global::System.IEquatable<InsightControllerUpdateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.InsightControllerUpdateRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateBarInsightFromCallTableDTO? Bar { get; init; }
#else
        public global::Vapi.UpdateBarInsightFromCallTableDTO? Bar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bar))]
#endif
        public bool IsBar => Bar != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdatePieInsightFromCallTableDTO? Pie { get; init; }
#else
        public global::Vapi.UpdatePieInsightFromCallTableDTO? Pie { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pie))]
#endif
        public bool IsPie => Pie != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateLineInsightFromCallTableDTO? Line { get; init; }
#else
        public global::Vapi.UpdateLineInsightFromCallTableDTO? Line { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Line))]
#endif
        public bool IsLine => Line != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateTextInsightFromCallTableDTO? Text { get; init; }
#else
        public global::Vapi.UpdateTextInsightFromCallTableDTO? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::Vapi.UpdateBarInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::Vapi.UpdateBarInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateBarInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::Vapi.UpdateBarInsightFromCallTableDTO? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::Vapi.UpdatePieInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::Vapi.UpdatePieInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdatePieInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::Vapi.UpdatePieInsightFromCallTableDTO? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::Vapi.UpdateLineInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::Vapi.UpdateLineInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateLineInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::Vapi.UpdateLineInsightFromCallTableDTO? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerUpdateRequest(global::Vapi.UpdateTextInsightFromCallTableDTO value) => new InsightControllerUpdateRequest((global::Vapi.UpdateTextInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateTextInsightFromCallTableDTO?(InsightControllerUpdateRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(global::Vapi.UpdateTextInsightFromCallTableDTO? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerUpdateRequest(
            global::Vapi.InsightControllerUpdateRequestDiscriminatorType? type,
            global::Vapi.UpdateBarInsightFromCallTableDTO? bar,
            global::Vapi.UpdatePieInsightFromCallTableDTO? pie,
            global::Vapi.UpdateLineInsightFromCallTableDTO? line,
            global::Vapi.UpdateTextInsightFromCallTableDTO? text
            )
        {
            Type = type;

            Bar = bar;
            Pie = pie;
            Line = line;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            Line as object ??
            Pie as object ??
            Bar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Bar?.ToString() ??
            Pie?.ToString() ??
            Line?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBar && !IsPie && !IsLine && !IsText || !IsBar && IsPie && !IsLine && !IsText || !IsBar && !IsPie && IsLine && !IsText || !IsBar && !IsPie && !IsLine && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.UpdateBarInsightFromCallTableDTO?, TResult>? bar = null,
            global::System.Func<global::Vapi.UpdatePieInsightFromCallTableDTO?, TResult>? pie = null,
            global::System.Func<global::Vapi.UpdateLineInsightFromCallTableDTO?, TResult>? line = null,
            global::System.Func<global::Vapi.UpdateTextInsightFromCallTableDTO?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBar && bar != null)
            {
                return bar(Bar!);
            }
            else if (IsPie && pie != null)
            {
                return pie(Pie!);
            }
            else if (IsLine && line != null)
            {
                return line(Line!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.UpdateBarInsightFromCallTableDTO?>? bar = null,
            global::System.Action<global::Vapi.UpdatePieInsightFromCallTableDTO?>? pie = null,
            global::System.Action<global::Vapi.UpdateLineInsightFromCallTableDTO?>? line = null,
            global::System.Action<global::Vapi.UpdateTextInsightFromCallTableDTO?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBar)
            {
                bar?.Invoke(Bar!);
            }
            else if (IsPie)
            {
                pie?.Invoke(Pie!);
            }
            else if (IsLine)
            {
                line?.Invoke(Line!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bar,
                typeof(global::Vapi.UpdateBarInsightFromCallTableDTO),
                Pie,
                typeof(global::Vapi.UpdatePieInsightFromCallTableDTO),
                Line,
                typeof(global::Vapi.UpdateLineInsightFromCallTableDTO),
                Text,
                typeof(global::Vapi.UpdateTextInsightFromCallTableDTO),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(InsightControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateBarInsightFromCallTableDTO?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdatePieInsightFromCallTableDTO?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateLineInsightFromCallTableDTO?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateTextInsightFromCallTableDTO?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerUpdateRequest obj1, InsightControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerUpdateRequest obj1, InsightControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerUpdateRequest o && Equals(o);
        }
    }
}
