<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthenticationExtrasAuthenticate — operations

Accessor: `client.AuthenticationExtrasAuthenticate` · Source: `Api/AuthenticationExtrasAuthenticate.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ClientAuth

- **Signature**: `ClientAuth(OauthAuthorizeClientRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Auth`
- **Error**: `SdkException<ClientAuthError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OauthAuthorizeClientRequest` | `Models/OauthAuthorizeClientRequest.cs` |
| `Auth` | `Models/Auth.cs` |
| `ClientAuthError` | `Errors/ClientAuthError.cs` |
| `Error` | `Models/Error.cs` |

