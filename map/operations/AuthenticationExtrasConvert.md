<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthenticationExtrasConvert — operations

Accessor: `client.AuthenticationExtrasConvert` · Source: `Api/AuthenticationExtrasConvert.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ConvertAccessToken

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ConvertAccessToken(OauthAuthorizeVimeoOauth1Request body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Auth`
- **Error**: `SdkException<ConvertAccessTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetAuthError(out AuthError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OauthAuthorizeVimeoOauth1Request` | `Models/OauthAuthorizeVimeoOauth1Request.cs` |
| `Auth` | `Models/Auth.cs` |
| `ConvertAccessTokenError` | `Errors/ConvertAccessTokenError.cs` |
| `AuthError` | `Models/AuthError.cs` |

