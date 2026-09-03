<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthenticationExtrasEssentials — operations

Accessor: `client.AuthenticationExtrasEssentials` · Source: `Api/AuthenticationExtrasEssentials.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteToken

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteToken(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTokenError` | `Errors/DeleteTokenError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### VerifyToken

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `VerifyToken(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Auth`
- **Error**: `SdkException<VerifyTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Auth` | `Models/Auth.cs` |
| `VerifyTokenError` | `Errors/VerifyTokenError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

