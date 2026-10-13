#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TrafficAllocationControllerCreateResponse : global::System.IEquatable<TrafficAllocationControllerCreateResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError? Error { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.TrafficAllocationStaleConflictResponseDTO? StaleAllocation { get; init; }
#else
        public global::Vapi.TrafficAllocationStaleConflictResponseDTO? StaleAllocation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaleAllocation))]
#endif
        public bool IsStaleAllocation => StaleAllocation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStaleAllocation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.TrafficAllocationStaleConflictResponseDTO? value)
        {
            value = StaleAllocation;
            return IsStaleAllocation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.TrafficAllocationStaleConflictResponseDTO PickStaleAllocation() => StaleAllocation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaleAllocation' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.AssistantManagedConflictResponseDTO? AssistantManagedByVapiAgents { get; init; }
#else
        public global::Vapi.AssistantManagedConflictResponseDTO? AssistantManagedByVapiAgents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantManagedByVapiAgents))]
#endif
        public bool IsAssistantManagedByVapiAgents => AssistantManagedByVapiAgents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssistantManagedByVapiAgents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Vapi.AssistantManagedConflictResponseDTO? value)
        {
            value = AssistantManagedByVapiAgents;
            return IsAssistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Vapi.AssistantManagedConflictResponseDTO PickAssistantManagedByVapiAgents() => AssistantManagedByVapiAgents is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssistantManagedByVapiAgents' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrafficAllocationControllerCreateResponse(global::Vapi.TrafficAllocationStaleConflictResponseDTO value) => new TrafficAllocationControllerCreateResponse((global::Vapi.TrafficAllocationStaleConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.TrafficAllocationStaleConflictResponseDTO?(TrafficAllocationControllerCreateResponse @this) => @this.StaleAllocation;

        /// <summary>
        ///
        /// </summary>
        public TrafficAllocationControllerCreateResponse(global::Vapi.TrafficAllocationStaleConflictResponseDTO? value)
        {
            StaleAllocation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrafficAllocationControllerCreateResponse FromStaleAllocation(global::Vapi.TrafficAllocationStaleConflictResponseDTO? value) => new TrafficAllocationControllerCreateResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TrafficAllocationControllerCreateResponse(global::Vapi.AssistantManagedConflictResponseDTO value) => new TrafficAllocationControllerCreateResponse((global::Vapi.AssistantManagedConflictResponseDTO?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Vapi.AssistantManagedConflictResponseDTO?(TrafficAllocationControllerCreateResponse @this) => @this.AssistantManagedByVapiAgents;

        /// <summary>
        ///
        /// </summary>
        public TrafficAllocationControllerCreateResponse(global::Vapi.AssistantManagedConflictResponseDTO? value)
        {
            AssistantManagedByVapiAgents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TrafficAllocationControllerCreateResponse FromAssistantManagedByVapiAgents(global::Vapi.AssistantManagedConflictResponseDTO? value) => new TrafficAllocationControllerCreateResponse(value);

        /// <summary>
        ///
        /// </summary>
        public TrafficAllocationControllerCreateResponse(
            global::Vapi.TrafficAllocationControllerCreateResponseDiscriminatorError? error,
            global::Vapi.TrafficAllocationStaleConflictResponseDTO? staleAllocation,
            global::Vapi.AssistantManagedConflictResponseDTO? assistantManagedByVapiAgents
            )
        {
            Error = error;

            StaleAllocation = staleAllocation;
            AssistantManagedByVapiAgents = assistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AssistantManagedByVapiAgents as object ??
            StaleAllocation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            StaleAllocation?.ToString() ??
            AssistantManagedByVapiAgents?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsStaleAllocation && !IsAssistantManagedByVapiAgents || !IsStaleAllocation && IsAssistantManagedByVapiAgents;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.TrafficAllocationStaleConflictResponseDTO, TResult>? staleAllocation = null,
            global::System.Func<global::Vapi.AssistantManagedConflictResponseDTO, TResult>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StaleAllocation is { } __value0 && staleAllocation != null)
            {
                return staleAllocation(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1 && assistantManagedByVapiAgents != null)
            {
                return assistantManagedByVapiAgents(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.TrafficAllocationStaleConflictResponseDTO>? staleAllocation = null,

            global::System.Action<global::Vapi.AssistantManagedConflictResponseDTO>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StaleAllocation is { } __value0)
            {
                staleAllocation?.Invoke(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1)
            {
                assistantManagedByVapiAgents?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Vapi.TrafficAllocationStaleConflictResponseDTO>? staleAllocation = null,
            global::System.Action<global::Vapi.AssistantManagedConflictResponseDTO>? assistantManagedByVapiAgents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (StaleAllocation is { } __value0)
            {
                staleAllocation?.Invoke(__value0);
            }
            else if (AssistantManagedByVapiAgents is { } __value1)
            {
                assistantManagedByVapiAgents?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StaleAllocation,
                typeof(global::Vapi.TrafficAllocationStaleConflictResponseDTO),
                AssistantManagedByVapiAgents,
                typeof(global::Vapi.AssistantManagedConflictResponseDTO),
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
        public bool Equals(TrafficAllocationControllerCreateResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.TrafficAllocationStaleConflictResponseDTO?>.Default.Equals(StaleAllocation, other.StaleAllocation) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.AssistantManagedConflictResponseDTO?>.Default.Equals(AssistantManagedByVapiAgents, other.AssistantManagedByVapiAgents)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TrafficAllocationControllerCreateResponse obj1, TrafficAllocationControllerCreateResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TrafficAllocationControllerCreateResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TrafficAllocationControllerCreateResponse obj1, TrafficAllocationControllerCreateResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TrafficAllocationControllerCreateResponse o && Equals(o);
        }
    }
}
