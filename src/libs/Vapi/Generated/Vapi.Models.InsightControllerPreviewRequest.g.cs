#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InsightControllerPreviewRequest : global::System.IEquatable<InsightControllerPreviewRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.InsightControllerPreviewRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateBarInsightFromCallTableDTO? Bar { get; init; }
#else
        public global::Vapi.CreateBarInsightFromCallTableDTO? Bar { get; }
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
        public global::Vapi.CreatePieInsightFromCallTableDTO? Pie { get; init; }
#else
        public global::Vapi.CreatePieInsightFromCallTableDTO? Pie { get; }
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
        public global::Vapi.CreateLineInsightFromCallTableDTO? Line { get; init; }
#else
        public global::Vapi.CreateLineInsightFromCallTableDTO? Line { get; }
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
        public global::Vapi.CreateTextInsightFromCallTableDTO? Text { get; init; }
#else
        public global::Vapi.CreateTextInsightFromCallTableDTO? Text { get; }
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
        public static implicit operator InsightControllerPreviewRequest(global::Vapi.CreateBarInsightFromCallTableDTO value) => new InsightControllerPreviewRequest((global::Vapi.CreateBarInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateBarInsightFromCallTableDTO?(InsightControllerPreviewRequest @this) => @this.Bar;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerPreviewRequest(global::Vapi.CreateBarInsightFromCallTableDTO? value)
        {
            Bar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerPreviewRequest(global::Vapi.CreatePieInsightFromCallTableDTO value) => new InsightControllerPreviewRequest((global::Vapi.CreatePieInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreatePieInsightFromCallTableDTO?(InsightControllerPreviewRequest @this) => @this.Pie;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerPreviewRequest(global::Vapi.CreatePieInsightFromCallTableDTO? value)
        {
            Pie = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerPreviewRequest(global::Vapi.CreateLineInsightFromCallTableDTO value) => new InsightControllerPreviewRequest((global::Vapi.CreateLineInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateLineInsightFromCallTableDTO?(InsightControllerPreviewRequest @this) => @this.Line;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerPreviewRequest(global::Vapi.CreateLineInsightFromCallTableDTO? value)
        {
            Line = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InsightControllerPreviewRequest(global::Vapi.CreateTextInsightFromCallTableDTO value) => new InsightControllerPreviewRequest((global::Vapi.CreateTextInsightFromCallTableDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTextInsightFromCallTableDTO?(InsightControllerPreviewRequest @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerPreviewRequest(global::Vapi.CreateTextInsightFromCallTableDTO? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InsightControllerPreviewRequest(
            global::Vapi.InsightControllerPreviewRequestDiscriminatorType? type,
            global::Vapi.CreateBarInsightFromCallTableDTO? bar,
            global::Vapi.CreatePieInsightFromCallTableDTO? pie,
            global::Vapi.CreateLineInsightFromCallTableDTO? line,
            global::Vapi.CreateTextInsightFromCallTableDTO? text
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
            global::System.Func<global::Vapi.CreateBarInsightFromCallTableDTO?, TResult>? bar = null,
            global::System.Func<global::Vapi.CreatePieInsightFromCallTableDTO?, TResult>? pie = null,
            global::System.Func<global::Vapi.CreateLineInsightFromCallTableDTO?, TResult>? line = null,
            global::System.Func<global::Vapi.CreateTextInsightFromCallTableDTO?, TResult>? text = null,
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
            global::System.Action<global::Vapi.CreateBarInsightFromCallTableDTO?>? bar = null,
            global::System.Action<global::Vapi.CreatePieInsightFromCallTableDTO?>? pie = null,
            global::System.Action<global::Vapi.CreateLineInsightFromCallTableDTO?>? line = null,
            global::System.Action<global::Vapi.CreateTextInsightFromCallTableDTO?>? text = null,
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
                typeof(global::Vapi.CreateBarInsightFromCallTableDTO),
                Pie,
                typeof(global::Vapi.CreatePieInsightFromCallTableDTO),
                Line,
                typeof(global::Vapi.CreateLineInsightFromCallTableDTO),
                Text,
                typeof(global::Vapi.CreateTextInsightFromCallTableDTO),
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
        public bool Equals(InsightControllerPreviewRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateBarInsightFromCallTableDTO?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreatePieInsightFromCallTableDTO?>.Default.Equals(Pie, other.Pie) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateLineInsightFromCallTableDTO?>.Default.Equals(Line, other.Line) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTextInsightFromCallTableDTO?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InsightControllerPreviewRequest obj1, InsightControllerPreviewRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InsightControllerPreviewRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InsightControllerPreviewRequest obj1, InsightControllerPreviewRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InsightControllerPreviewRequest o && Equals(o);
        }
    }
}
