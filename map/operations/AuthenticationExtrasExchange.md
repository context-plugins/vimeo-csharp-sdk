<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthenticationExtrasExchange — operations

Accessor: `client.AuthenticationExtrasExchange` · Source: `Api/AuthenticationExtrasExchange.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ExchangeAuthCode

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ExchangeAuthCode(OauthAccessTokenRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Auth`
- **Error**: `SdkException<ExchangeAuthCodeError>` — **Case A (typed)**
- **Error accessors**: `TryGetAuthError(out AuthError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OauthAccessTokenRequest` | `Models/OauthAccessTokenRequest.cs` |
| `Auth` | `Models/Auth.cs` |
| `ExchangeAuthCodeError` | `Errors/ExchangeAuthCodeError.cs` |
| `AuthError` | `Models/AuthError.cs` |

