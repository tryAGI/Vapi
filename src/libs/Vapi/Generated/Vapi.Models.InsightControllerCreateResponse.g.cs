#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerCreateResponse : global::System.IEquatable<InsightControllerCreateResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.InsightControllerCreateResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.BarInsight? Bar { get; init; }
#else
        public global::Vapi.BarInsight? Bar { get; }
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
        public global::Vapi.PieInsight? Pie { get; init; }
#else
        public global::Vapi.PieInsight? Pie { get; }
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
        public global::Vapi.LineInsight? Line { get; init; }
#else
        public global::Vapi.LineInsight? Line { get; }
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
        public global::Vapi.TextInsight? Text { get; init; }
#else
        public global::Vapi.TextInsight? Text { get; }
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
        public static implicit operator InsightControllerCreateResponse(global::Vapi.BarInsight value) => new InsightControllerCreateResponse((global::Vapi.BarInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.BarInsight?(InsightControllerCreateResponse @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateResponse(global::Vapi.BarInsight? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateResponse(global::Vapi.PieInsight value) => new InsightControllerCreateResponse((global::Vapi.PieInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.PieInsight?(InsightControllerCreateResponse @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateResponse(global::Vapi.PieInsight? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateResponse(global::Vapi.LineInsight value) => new InsightControllerCreateResponse((global::Vapi.LineInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.LineInsight?(InsightControllerCreateResponse @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateResponse(global::Vapi.LineInsight? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerCreateResponse(global::Vapi.TextInsight value) => new InsightControllerCreateResponse((global::Vapi.TextInsight?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.TextInsight?(InsightControllerCreateResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateResponse(global::Vapi.TextInsight? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerCreateResponse(
            global::Vapi.InsightControllerCreateResponseDiscriminatorType? type,
            global::Vapi.BarInsight? bar,
            global::Vapi.PieInsight? pie,
            global::Vapi.LineInsight? line,
            global::Vapi.TextInsight? text
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
            global::System.Func<global::Vapi.BarInsight?, TResult>? bar = null,
            global::System.Func<global::Vapi.PieInsight?, TResult>? pie = null,
            global::System.Func<global::Vapi.LineInsight?, TResult>? line = null,
            global::System.Func<global::Vapi.TextInsight?, TResult>? text = null,
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
            global::System.Action<global::Vapi.BarInsight?>? bar = null,
            global::System.Action<global::Vapi.PieInsight?>? pie = null,
            global::System.Action<global::Vapi.LineInsight?>? line = null,
            global::System.Action<global::Vapi.TextInsight?>? text = null,
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
                typeof(global::Vapi.BarInsight),
                Pie,
                typeof(global::Vapi.PieInsight),
                Line,
                typeof(global::Vapi.LineInsight),
                Text,
                typeof(global::Vapi.TextInsight),
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
        public bool Equals(InsightControllerCreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.BarInsight?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.PieInsight?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.LineInsight?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TextInsight?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerCreateResponse obj1, InsightControllerCreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerCreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerCreateResponse obj1, InsightControllerCreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerCreateResponse o && Equals(o);
        }
    }
}
