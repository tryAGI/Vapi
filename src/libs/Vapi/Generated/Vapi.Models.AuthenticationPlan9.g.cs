#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Vapi
{
    /// <summary>
    /// This is the authentication plan. Supports OAuth2 RFC 6749, HMAC signing, and Bearer authentication.
    /// </summary>
    public readonly partial struct AuthenticationPlan9 : global::System.IEquatable<AuthenticationPlan9>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.OAuth2AuthenticationPlan? Oauth2 { get; init; }
#else
        public global::Vapi.OAuth2AuthenticationPlan? Oauth2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2))]
#endif
        public bool IsOauth2 => Oauth2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.HMACAuthenticationPlan? Hmac { get; init; }
#else
        public global::Vapi.HMACAuthenticationPlan? Hmac { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Hmac))]
#endif
        public bool IsHmac => Hmac != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Vapi.BearerAuthenticationPlan? Bearer { get; init; }
#else
        public global::Vapi.BearerAuthenticationPlan? Bearer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bearer))]
#endif
        public bool IsBearer => Bearer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthenticationPlan9(global::Vapi.OAuth2AuthenticationPlan value) => new AuthenticationPlan9((global::Vapi.OAuth2AuthenticationPlan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.OAuth2AuthenticationPlan?(AuthenticationPlan9 @this) => @this.Oauth2;

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationPlan9(global::Vapi.OAuth2AuthenticationPlan? value)
        {
            Oauth2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthenticationPlan9(global::Vapi.HMACAuthenticationPlan value) => new AuthenticationPlan9((global::Vapi.HMACAuthenticationPlan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.HMACAuthenticationPlan?(AuthenticationPlan9 @this) => @this.Hmac;

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationPlan9(global::Vapi.HMACAuthenticationPlan? value)
        {
            Hmac = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthenticationPlan9(global::Vapi.BearerAuthenticationPlan value) => new AuthenticationPlan9((global::Vapi.BearerAuthenticationPlan?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Vapi.BearerAuthenticationPlan?(AuthenticationPlan9 @this) => @this.Bearer;

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationPlan9(global::Vapi.BearerAuthenticationPlan? value)
        {
            Bearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthenticationPlan9(
            global::Vapi.UpdateCustomCredentialDTOAuthenticationPlanDiscriminatorType? type,
            global::Vapi.OAuth2AuthenticationPlan? oauth2,
            global::Vapi.HMACAuthenticationPlan? hmac,
            global::Vapi.BearerAuthenticationPlan? bearer
            )
        {
            Type = type;

            Oauth2 = oauth2;
            Hmac = hmac;
            Bearer = bearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Bearer as object ??
            Hmac as object ??
            Oauth2 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Oauth2?.ToString() ??
            Hmac?.ToString() ??
            Bearer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2 && !IsHmac && !IsBearer || !IsOauth2 && IsHmac && !IsBearer || !IsOauth2 && !IsHmac && IsBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Vapi.OAuth2AuthenticationPlan?, TResult>? oauth2 = null,
            global::System.Func<global::Vapi.HMACAuthenticationPlan?, TResult>? hmac = null,
            global::System.Func<global::Vapi.BearerAuthenticationPlan?, TResult>? bearer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2 && oauth2 != null)
            {
                return oauth2(Oauth2!);
            }
            else if (IsHmac && hmac != null)
            {
                return hmac(Hmac!);
            }
            else if (IsBearer && bearer != null)
            {
                return bearer(Bearer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Vapi.OAuth2AuthenticationPlan?>? oauth2 = null,
            global::System.Action<global::Vapi.HMACAuthenticationPlan?>? hmac = null,
            global::System.Action<global::Vapi.BearerAuthenticationPlan?>? bearer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2)
            {
                oauth2?.Invoke(Oauth2!);
            }
            else if (IsHmac)
            {
                hmac?.Invoke(Hmac!);
            }
            else if (IsBearer)
            {
                bearer?.Invoke(Bearer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Oauth2,
                typeof(global::Vapi.OAuth2AuthenticationPlan),
                Hmac,
                typeof(global::Vapi.HMACAuthenticationPlan),
                Bearer,
                typeof(global::Vapi.BearerAuthenticationPlan),
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
        public bool Equals(AuthenticationPlan9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Vapi.OAuth2AuthenticationPlan?>.Default.Equals(Oauth2, other.Oauth2) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.HMACAuthenticationPlan?>.Default.Equals(Hmac, other.Hmac) &&
                global::System.Collections.Generic.EqualityComparer<global::Vapi.BearerAuthenticationPlan?>.Default.Equals(Bearer, other.Bearer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthenticationPlan9 obj1, AuthenticationPlan9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthenticationPlan9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthenticationPlan9 obj1, AuthenticationPlan9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthenticationPlan9 o && Equals(o);
        }
    }
}
