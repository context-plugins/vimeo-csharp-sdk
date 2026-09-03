<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventActivation — operations

Accessor: `client.LiveEventActivation` · Source: `Api/LiveEventActivation.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateLiveEvent

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ActivateLiveEvent(double liveEventId, double userId, UsersLiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Video`
- **Error**: `SdkException<ActivateLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsActivateRequest` | `Models/UsersLiveEventsActivateRequest.cs` |
| `Video` | `Models/Video.cs` |
| `ActivateLiveEventError` | `Errors/ActivateLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### ActivateLiveEventAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ActivateLiveEventAlt1(double liveEventId, LiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Video`
- **Error**: `SdkException<ActivateLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsActivateRequest` | `Models/LiveEventsActivateRequest.cs` |
| `Video` | `Models/Video.cs` |
| `ActivateLiveEventAlt1Error` | `Errors/ActivateLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### ActivateLiveEventAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ActivateLiveEventAlt2(double liveEventId, MeLiveEventsActivateRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Video`
- **Error**: `SdkException<ActivateLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsActivateRequest` | `Models/MeLiveEventsActivateRequest.cs` |
| `Video` | `Models/Video.cs` |
| `ActivateLiveEventAlt2Error` | `Errors/ActivateLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

