<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventDestinations — operations

Accessor: `client.LiveEventDestinations` · Source: `Api/LiveEventDestinations.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateLiveEventDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateLiveEventDestination(double liveEventId, MeLiveEventsDestinationsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventDestination`
- **Error**: `SdkException<CreateLiveEventDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsDestinationsRequest` | `Models/MeLiveEventsDestinationsRequest.cs` |
| `EventDestination` | `Models/EventDestination.cs` |
| `CreateLiveEventDestinationError` | `Errors/CreateLiveEventDestinationError.cs` |
| `Error` | `Models/Error.cs` |

### CreateLiveEventDestinationAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateLiveEventDestinationAlt1(double liveEventId, double userId, UsersLiveEventsDestinationsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventDestination`
- **Error**: `SdkException<CreateLiveEventDestinationAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsDestinationsRequest` | `Models/UsersLiveEventsDestinationsRequest.cs` |
| `EventDestination` | `Models/EventDestination.cs` |
| `CreateLiveEventDestinationAlt1Error` | `Errors/CreateLiveEventDestinationAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### CreateOttDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateOttDestination(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OttDestination`
- **Error**: `SdkException<CreateOttDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OttDestination` | `Models/OttDestination.cs` |
| `CreateOttDestinationError` | `Errors/CreateOttDestinationError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteLiveEventDestination(double destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventDestinationError` | `Errors/DeleteLiveEventDestinationError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteOttDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteOttDestination(double liveEventId, double userId, string destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteOttDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOttDestinationError` | `Errors/DeleteOttDestinationError.cs` |
| `Error` | `Models/Error.cs` |

### GetAvailableDestinations

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableDestinations(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAvailableDestinationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAvailableDestinationsError` | `Errors/GetAvailableDestinationsError.cs` |
| `Error` | `Models/Error.cs` |

### GetAvailableDestinationsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableDestinationsAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetAvailableDestinationsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAvailableDestinationsAlt1Error` | `Errors/GetAvailableDestinationsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventDestination(double destinationId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventDestination`
- **Error**: `SdkException<GetLiveEventDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EventDestination` | `Models/EventDestination.cs` |
| `GetLiveEventDestinationError` | `Errors/GetLiveEventDestinationError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventDestinations

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventDestinations(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventDestinationConnection`
- **Error**: `SdkException<GetLiveEventDestinationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EventDestinationConnection` | `Models/EventDestinationConnection.cs` |
| `GetLiveEventDestinationsError` | `Errors/GetLiveEventDestinationsError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventDestinationsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetLiveEventDestinationsAlt1(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventDestinationConnection`
- **Error**: `SdkException<GetLiveEventDestinationsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `EventDestinationConnection` | `Models/EventDestinationConnection.cs` |
| `GetLiveEventDestinationsAlt1Error` | `Errors/GetLiveEventDestinationsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetOttDestinations

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetOttDestinations(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OttDestinationConnection`
- **Error**: `SdkException<GetOttDestinationsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OttDestinationConnection` | `Models/OttDestinationConnection.cs` |
| `GetOttDestinationsError` | `Errors/GetOttDestinationsError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateLiveEventDestination

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateLiveEventDestination(double destinationId, DestinationRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `EventDestination`
- **Error**: `SdkException<UpdateLiveEventDestinationError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DestinationRequest` | `Models/DestinationRequest.cs` |
| `EventDestination` | `Models/EventDestination.cs` |
| `UpdateLiveEventDestinationError` | `Errors/UpdateLiveEventDestinationError.cs` |
| `Error` | `Models/Error.cs` |

