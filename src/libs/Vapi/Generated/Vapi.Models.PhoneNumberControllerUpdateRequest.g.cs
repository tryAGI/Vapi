#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerUpdateRequest : global::System.IEquatable<PhoneNumberControllerUpdateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateByoPhoneNumberDTO? ByoPhoneNumber { get; init; }
#else
        public global::Vapi.UpdateByoPhoneNumberDTO? ByoPhoneNumber { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ByoPhoneNumber))]
#endif
        public bool IsByoPhoneNumber => ByoPhoneNumber != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateTwilioPhoneNumberDTO? Twilio { get; init; }
#else
        public global::Vapi.UpdateTwilioPhoneNumberDTO? Twilio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateVonagePhoneNumberDTO? Vonage { get; init; }
#else
        public global::Vapi.UpdateVonagePhoneNumberDTO? Vonage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vonage))]
#endif
        public bool IsVonage => Vonage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateVapiPhoneNumberDTO? Vapi { get; init; }
#else
        public global::Vapi.UpdateVapiPhoneNumberDTO? Vapi { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Vapi))]
#endif
        public bool IsVapi => Vapi != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.UpdateTelnyxPhoneNumberDTO? Telnyx { get; init; }
#else
        public global::Vapi.UpdateTelnyxPhoneNumberDTO? Telnyx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Telnyx))]
#endif
        public bool IsTelnyx => Telnyx != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::Vapi.UpdateByoPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::Vapi.UpdateByoPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateByoPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::Vapi.UpdateByoPhoneNumberDTO? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::Vapi.UpdateTwilioPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::Vapi.UpdateTwilioPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateTwilioPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::Vapi.UpdateTwilioPhoneNumberDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::Vapi.UpdateVonagePhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::Vapi.UpdateVonagePhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateVonagePhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::Vapi.UpdateVonagePhoneNumberDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::Vapi.UpdateVapiPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::Vapi.UpdateVapiPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateVapiPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::Vapi.UpdateVapiPhoneNumberDTO? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerUpdateRequest(global::Vapi.UpdateTelnyxPhoneNumberDTO value) => new PhoneNumberControllerUpdateRequest((global::Vapi.UpdateTelnyxPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.UpdateTelnyxPhoneNumberDTO?(PhoneNumberControllerUpdateRequest @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(global::Vapi.UpdateTelnyxPhoneNumberDTO? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerUpdateRequest(
            global::Vapi.PhoneNumberControllerUpdateRequestDiscriminatorProvider? provider,
            global::Vapi.UpdateByoPhoneNumberDTO? byoPhoneNumber,
            global::Vapi.UpdateTwilioPhoneNumberDTO? twilio,
            global::Vapi.UpdateVonagePhoneNumberDTO? vonage,
            global::Vapi.UpdateVapiPhoneNumberDTO? vapi,
            global::Vapi.UpdateTelnyxPhoneNumberDTO? telnyx
            )
        {
            Provider = provider;

            ByoPhoneNumber = byoPhoneNumber;
            Twilio = twilio;
            Vonage = vonage;
            Vapi = vapi;
            Telnyx = telnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Telnyx as object ??
            Vapi as object ??
            Vonage as object ??
            Twilio as object ??
            ByoPhoneNumber as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ByoPhoneNumber?.ToString() ??
            Twilio?.ToString() ??
            Vonage?.ToString() ??
            Vapi?.ToString() ??
            Telnyx?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && IsTwilio && !IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && IsVonage && !IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && IsVapi && !IsTelnyx || !IsByoPhoneNumber && !IsTwilio && !IsVonage && !IsVapi && IsTelnyx;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.UpdateByoPhoneNumberDTO?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::Vapi.UpdateTwilioPhoneNumberDTO?, TResult>? twilio = null,
            global::System.Func<global::Vapi.UpdateVonagePhoneNumberDTO?, TResult>? vonage = null,
            global::System.Func<global::Vapi.UpdateVapiPhoneNumberDTO?, TResult>? vapi = null,
            global::System.Func<global::Vapi.UpdateTelnyxPhoneNumberDTO?, TResult>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber && byoPhoneNumber != null)
            {
                return byoPhoneNumber(ByoPhoneNumber!);
            }
            else if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsVonage && vonage != null)
            {
                return vonage(Vonage!);
            }
            else if (IsVapi && vapi != null)
            {
                return vapi(Vapi!);
            }
            else if (IsTelnyx && telnyx != null)
            {
                return telnyx(Telnyx!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.UpdateByoPhoneNumberDTO?>? byoPhoneNumber = null,
            global::System.Action<global::Vapi.UpdateTwilioPhoneNumberDTO?>? twilio = null,
            global::System.Action<global::Vapi.UpdateVonagePhoneNumberDTO?>? vonage = null,
            global::System.Action<global::Vapi.UpdateVapiPhoneNumberDTO?>? vapi = null,
            global::System.Action<global::Vapi.UpdateTelnyxPhoneNumberDTO?>? telnyx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsByoPhoneNumber)
            {
                byoPhoneNumber?.Invoke(ByoPhoneNumber!);
            }
            else if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsVonage)
            {
                vonage?.Invoke(Vonage!);
            }
            else if (IsVapi)
            {
                vapi?.Invoke(Vapi!);
            }
            else if (IsTelnyx)
            {
                telnyx?.Invoke(Telnyx!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ByoPhoneNumber,
                typeof(global::Vapi.UpdateByoPhoneNumberDTO),
                Twilio,
                typeof(global::Vapi.UpdateTwilioPhoneNumberDTO),
                Vonage,
                typeof(global::Vapi.UpdateVonagePhoneNumberDTO),
                Vapi,
                typeof(global::Vapi.UpdateVapiPhoneNumberDTO),
                Telnyx,
                typeof(global::Vapi.UpdateTelnyxPhoneNumberDTO),
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
        public bool Equals(PhoneNumberControllerUpdateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateByoPhoneNumberDTO?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateTwilioPhoneNumberDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateVonagePhoneNumberDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateVapiPhoneNumberDTO?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.UpdateTelnyxPhoneNumberDTO?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerUpdateRequest obj1, PhoneNumberControllerUpdateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerUpdateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerUpdateRequest obj1, PhoneNumberControllerUpdateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerUpdateRequest o && Equals(o);
        }
    }
}
