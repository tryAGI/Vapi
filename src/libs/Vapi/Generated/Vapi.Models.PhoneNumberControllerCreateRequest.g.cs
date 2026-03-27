#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneNumberControllerCreateRequest : global::System.IEquatable<PhoneNumberControllerCreateRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.CreateByoPhoneNumberDTO? ByoPhoneNumber { get; init; }
#else
        public global::Vapi.CreateByoPhoneNumberDTO? ByoPhoneNumber { get; }
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
        public global::Vapi.CreateTwilioPhoneNumberDTO? Twilio { get; init; }
#else
        public global::Vapi.CreateTwilioPhoneNumberDTO? Twilio { get; }
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
        public global::Vapi.CreateVonagePhoneNumberDTO? Vonage { get; init; }
#else
        public global::Vapi.CreateVonagePhoneNumberDTO? Vonage { get; }
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
        public global::Vapi.CreateVapiPhoneNumberDTO? Vapi { get; init; }
#else
        public global::Vapi.CreateVapiPhoneNumberDTO? Vapi { get; }
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
        public global::Vapi.CreateTelnyxPhoneNumberDTO? Telnyx { get; init; }
#else
        public global::Vapi.CreateTelnyxPhoneNumberDTO? Telnyx { get; }
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
        public static implicit operator PhoneNumberControllerCreateRequest(global::Vapi.CreateByoPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::Vapi.CreateByoPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateByoPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.ByoPhoneNumber;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::Vapi.CreateByoPhoneNumberDTO? value)
        {
            ByoPhoneNumber = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::Vapi.CreateTwilioPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::Vapi.CreateTwilioPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTwilioPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::Vapi.CreateTwilioPhoneNumberDTO? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::Vapi.CreateVonagePhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::Vapi.CreateVonagePhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateVonagePhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Vonage;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::Vapi.CreateVonagePhoneNumberDTO? value)
        {
            Vonage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::Vapi.CreateVapiPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::Vapi.CreateVapiPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateVapiPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Vapi;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::Vapi.CreateVapiPhoneNumberDTO? value)
        {
            Vapi = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneNumberControllerCreateRequest(global::Vapi.CreateTelnyxPhoneNumberDTO value) => new PhoneNumberControllerCreateRequest((global::Vapi.CreateTelnyxPhoneNumberDTO?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.CreateTelnyxPhoneNumberDTO?(PhoneNumberControllerCreateRequest @this) => @this.Telnyx;

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(global::Vapi.CreateTelnyxPhoneNumberDTO? value)
        {
            Telnyx = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneNumberControllerCreateRequest(
            global::Vapi.PhoneNumberControllerCreateRequestDiscriminatorProvider? provider,
            global::Vapi.CreateByoPhoneNumberDTO? byoPhoneNumber,
            global::Vapi.CreateTwilioPhoneNumberDTO? twilio,
            global::Vapi.CreateVonagePhoneNumberDTO? vonage,
            global::Vapi.CreateVapiPhoneNumberDTO? vapi,
            global::Vapi.CreateTelnyxPhoneNumberDTO? telnyx
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
            global::System.Func<global::Vapi.CreateByoPhoneNumberDTO?, TResult>? byoPhoneNumber = null,
            global::System.Func<global::Vapi.CreateTwilioPhoneNumberDTO?, TResult>? twilio = null,
            global::System.Func<global::Vapi.CreateVonagePhoneNumberDTO?, TResult>? vonage = null,
            global::System.Func<global::Vapi.CreateVapiPhoneNumberDTO?, TResult>? vapi = null,
            global::System.Func<global::Vapi.CreateTelnyxPhoneNumberDTO?, TResult>? telnyx = null,
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
            global::System.Action<global::Vapi.CreateByoPhoneNumberDTO?>? byoPhoneNumber = null,
            global::System.Action<global::Vapi.CreateTwilioPhoneNumberDTO?>? twilio = null,
            global::System.Action<global::Vapi.CreateVonagePhoneNumberDTO?>? vonage = null,
            global::System.Action<global::Vapi.CreateVapiPhoneNumberDTO?>? vapi = null,
            global::System.Action<global::Vapi.CreateTelnyxPhoneNumberDTO?>? telnyx = null,
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
                typeof(global::Vapi.CreateByoPhoneNumberDTO),
                Twilio,
                typeof(global::Vapi.CreateTwilioPhoneNumberDTO),
                Vonage,
                typeof(global::Vapi.CreateVonagePhoneNumberDTO),
                Vapi,
                typeof(global::Vapi.CreateVapiPhoneNumberDTO),
                Telnyx,
                typeof(global::Vapi.CreateTelnyxPhoneNumberDTO),
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
        public bool Equals(PhoneNumberControllerCreateRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateByoPhoneNumberDTO?>.Default.Equals(ByoPhoneNumber, other.ByoPhoneNumber) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTwilioPhoneNumberDTO?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateVonagePhoneNumberDTO?>.Default.Equals(Vonage, other.Vonage) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateVapiPhoneNumberDTO?>.Default.Equals(Vapi, other.Vapi) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.CreateTelnyxPhoneNumberDTO?>.Default.Equals(Telnyx, other.Telnyx) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneNumberControllerCreateRequest obj1, PhoneNumberControllerCreateRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneNumberControllerCreateRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneNumberControllerCreateRequest obj1, PhoneNumberControllerCreateRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneNumberControllerCreateRequest o && Equals(o);
        }
    }
}
