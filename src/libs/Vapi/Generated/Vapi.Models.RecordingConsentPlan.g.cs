#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RecordingConsentPlan : global::System.IEquatable<RecordingConsentPlan>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.RecordingConsentPlanStayOnLine? StayOnLine { get; init; }
#else
        public global::Vapi.RecordingConsentPlanStayOnLine? StayOnLine { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StayOnLine))]
#endif
        public bool IsStayOnLine => StayOnLine != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.RecordingConsentPlanVerbal? Verbal { get; init; }
#else
        public global::Vapi.RecordingConsentPlanVerbal? Verbal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Verbal))]
#endif
        public bool IsVerbal => Verbal != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordingConsentPlan(global::Vapi.RecordingConsentPlanStayOnLine value) => new RecordingConsentPlan((global::Vapi.RecordingConsentPlanStayOnLine?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.RecordingConsentPlanStayOnLine?(RecordingConsentPlan @this) => @this.StayOnLine;

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(global::Vapi.RecordingConsentPlanStayOnLine? value)
        {
            StayOnLine = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RecordingConsentPlan(global::Vapi.RecordingConsentPlanVerbal value) => new RecordingConsentPlan((global::Vapi.RecordingConsentPlanVerbal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.RecordingConsentPlanVerbal?(RecordingConsentPlan @this) => @this.Verbal;

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(global::Vapi.RecordingConsentPlanVerbal? value)
        {
            Verbal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RecordingConsentPlan(
            global::Vapi.CompliancePlanRecordingConsentPlanDiscriminatorType? type,
            global::Vapi.RecordingConsentPlanStayOnLine? stayOnLine,
            global::Vapi.RecordingConsentPlanVerbal? verbal
            )
        {
            Type = type;

            StayOnLine = stayOnLine;
            Verbal = verbal;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Verbal as object ??
            StayOnLine as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StayOnLine?.ToString() ??
            Verbal?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStayOnLine && !IsVerbal || !IsStayOnLine && IsVerbal;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.RecordingConsentPlanStayOnLine?, TResult>? stayOnLine = null,
            global::System.Func<global::Vapi.RecordingConsentPlanVerbal?, TResult>? verbal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStayOnLine && stayOnLine != null)
            {
                return stayOnLine(StayOnLine!);
            }
            else if (IsVerbal && verbal != null)
            {
                return verbal(Verbal!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.RecordingConsentPlanStayOnLine?>? stayOnLine = null,
            global::System.Action<global::Vapi.RecordingConsentPlanVerbal?>? verbal = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStayOnLine)
            {
                stayOnLine?.Invoke(StayOnLine!);
            }
            else if (IsVerbal)
            {
                verbal?.Invoke(Verbal!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StayOnLine,
                typeof(global::Vapi.RecordingConsentPlanStayOnLine),
                Verbal,
                typeof(global::Vapi.RecordingConsentPlanVerbal),
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
        public bool Equals(RecordingConsentPlan other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.RecordingConsentPlanStayOnLine?>.Default.Equals(StayOnLine, other.StayOnLine) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.RecordingConsentPlanVerbal?>.Default.Equals(Verbal, other.Verbal) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RecordingConsentPlan obj1, RecordingConsentPlan obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RecordingConsentPlan>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RecordingConsentPlan obj1, RecordingConsentPlan obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RecordingConsentPlan o && Equals(o);
        }
    }
}
