<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventEnd — operations

Accessor: `client.LiveEventEnd` · Source: `Api/LiveEventEnd.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EndLiveEvent

- **Signature**: `EndLiveEvent(double liveEventId, string userId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clipId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `clip_id` ← `clipId`
- **Returns**: `Video`
- **Error**: `SdkException<EndLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `EndLiveEventError` | `Errors/EndLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### EndLiveEventAlt1

- **Signature**: `EndLiveEventAlt1(double liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clipId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `clip_id` ← `clipId`
- **Returns**: `Video`
- **Error**: `SdkException<EndLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `EndLiveEventAlt1Error` | `Errors/EndLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### EndLiveEventAlt2

- **Signature**: `EndLiveEventAlt2(double liveEventId, double? clipId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `clipId` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `clip_id` ← `clipId`
- **Returns**: `Video`
- **Error**: `SdkException<EndLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `EndLiveEventAlt2Error` | `Errors/EndLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

