<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEmbedPrivacy — operations

Accessor: `client.LiveEmbedPrivacy` · Source: `Api/LiveEmbedPrivacy.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLiveEventWhitelist

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventWhitelist(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DomainConnection`
- **Error**: `SdkException<GetLiveEventWhitelistError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DomainConnection` | `Models/DomainConnection.cs` |
| `GetLiveEventWhitelistError` | `Errors/GetLiveEventWhitelistError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventWhitelistAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventWhitelistAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DomainConnection`
- **Error**: `SdkException<GetLiveEventWhitelistAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DomainConnection` | `Models/DomainConnection.cs` |
| `GetLiveEventWhitelistAlt1Error` | `Errors/GetLiveEventWhitelistAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventWhitelistAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventWhitelistAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `DomainConnection`
- **Error**: `SdkException<GetLiveEventWhitelistAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DomainConnection` | `Models/DomainConnection.cs` |
| `GetLiveEventWhitelistAlt2Error` | `Errors/GetLiveEventWhitelistAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### SetLiveEventWhitelist

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetLiveEventWhitelist(double liveEventId, double userId, UsersLiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<SetLiveEventWhitelistError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsPrivacyDomainsRequest` | `Models/UsersLiveEventsPrivacyDomainsRequest.cs` |
| `SetLiveEventWhitelistError` | `Errors/SetLiveEventWhitelistError.cs` |
| `Error` | `Models/Error.cs` |

### SetLiveEventWhitelistAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetLiveEventWhitelistAlt1(double liveEventId, LiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<SetLiveEventWhitelistAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsPrivacyDomainsRequest` | `Models/LiveEventsPrivacyDomainsRequest.cs` |
| `SetLiveEventWhitelistAlt1Error` | `Errors/SetLiveEventWhitelistAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### SetLiveEventWhitelistAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetLiveEventWhitelistAlt2(double liveEventId, MeLiveEventsPrivacyDomainsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<SetLiveEventWhitelistAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsPrivacyDomainsRequest` | `Models/MeLiveEventsPrivacyDomainsRequest.cs` |
| `SetLiveEventWhitelistAlt2Error` | `Errors/SetLiveEventWhitelistAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

