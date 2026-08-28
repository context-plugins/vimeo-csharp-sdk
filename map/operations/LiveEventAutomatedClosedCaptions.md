<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventAutomatedClosedCaptions — operations

Accessor: `client.LiveEventAutomatedClosedCaptions` · Source: `Api/LiveEventAutomatedClosedCaptions.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EditLiveEventAutoCc

- **Signature**: `EditLiveEventAutoCc(double liveEventId, double userId, UsersLiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventAutomatedClosedCaptions`
- **Error**: `SdkException<EditLiveEventAutoCcError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsAutoCcRequest` | `Models/UsersLiveEventsAutoCcRequest.cs` |
| `EventAutomatedClosedCaptions` | `Models/EventAutomatedClosedCaptions.cs` |
| `EditLiveEventAutoCcError` | `Errors/EditLiveEventAutoCcError.cs` |
| `Error` | `Models/Error.cs` |

### EditLiveEventAutoCcAlt1

- **Signature**: `EditLiveEventAutoCcAlt1(double liveEventId, LiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventAutomatedClosedCaptions`
- **Error**: `SdkException<EditLiveEventAutoCcAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsAutoCcRequest` | `Models/LiveEventsAutoCcRequest.cs` |
| `EventAutomatedClosedCaptions` | `Models/EventAutomatedClosedCaptions.cs` |
| `EditLiveEventAutoCcAlt1Error` | `Errors/EditLiveEventAutoCcAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### EditLiveEventAutoCcAlt2

- **Signature**: `EditLiveEventAutoCcAlt2(double liveEventId, MeLiveEventsAutoCcRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `EventAutomatedClosedCaptions`
- **Error**: `SdkException<EditLiveEventAutoCcAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsAutoCcRequest` | `Models/MeLiveEventsAutoCcRequest.cs` |
| `EventAutomatedClosedCaptions` | `Models/EventAutomatedClosedCaptions.cs` |
| `EditLiveEventAutoCcAlt2Error` | `Errors/EditLiveEventAutoCcAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

