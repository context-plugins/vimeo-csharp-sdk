<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventLowLatency — operations

Accessor: `client.LiveEventLowLatency` · Source: `Api/LiveEventLowLatency.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ToggleRleLowLatency

- **Signature**: `ToggleRleLowLatency(double liveEventId, double userId, UsersLiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEventLowLatency`
- **Error**: `SdkException<ToggleRleLowLatencyError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsLowLatencyRequest` | `Models/UsersLiveEventsLowLatencyRequest.cs` |
| `RecurringEventLowLatency` | `Models/RecurringEventLowLatency.cs` |
| `ToggleRleLowLatencyError` | `Errors/ToggleRleLowLatencyError.cs` |
| `Error` | `Models/Error.cs` |

### ToggleRleLowLatencyAlt1

- **Signature**: `ToggleRleLowLatencyAlt1(double liveEventId, LiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEventLowLatency`
- **Error**: `SdkException<ToggleRleLowLatencyAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsLowLatencyRequest` | `Models/LiveEventsLowLatencyRequest.cs` |
| `RecurringEventLowLatency` | `Models/RecurringEventLowLatency.cs` |
| `ToggleRleLowLatencyAlt1Error` | `Errors/ToggleRleLowLatencyAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### ToggleRleLowLatencyAlt2

- **Signature**: `ToggleRleLowLatencyAlt2(double liveEventId, MeLiveEventsLowLatencyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEventLowLatency`
- **Error**: `SdkException<ToggleRleLowLatencyAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsLowLatencyRequest` | `Models/MeLiveEventsLowLatencyRequest.cs` |
| `RecurringEventLowLatency` | `Models/RecurringEventLowLatency.cs` |
| `ToggleRleLowLatencyAlt2Error` | `Errors/ToggleRleLowLatencyAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

