<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventVideos — operations

Accessor: `client.LiveEventVideos` · Source: `Api/LiveEventVideos.cs` · 12 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideosToLiveEvent

- **Signature**: `AddVideosToLiveEvent(double liveEventId, double userId, UsersLiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsVideosRequest1` | `Models/UsersLiveEventsVideosRequest1.cs` |
| `AddVideosToLiveEventError` | `Errors/AddVideosToLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### AddVideosToLiveEventAlt1

- **Signature**: `AddVideosToLiveEventAlt1(double liveEventId, LiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsVideosRequest1` | `Models/LiveEventsVideosRequest1.cs` |
| `AddVideosToLiveEventAlt1Error` | `Errors/AddVideosToLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### AddVideosToLiveEventAlt2

- **Signature**: `AddVideosToLiveEventAlt2(double liveEventId, MeLiveEventsVideosRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsVideosRequest1` | `Models/MeLiveEventsVideosRequest1.cs` |
| `AddVideosToLiveEventAlt2Error` | `Errors/AddVideosToLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideo

- **Signature**: `GetLiveEventVideo(double liveEventId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<GetLiveEventVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetLiveEventVideoError` | `Errors/GetLiveEventVideoError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideoAlt1

- **Signature**: `GetLiveEventVideoAlt1(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<GetLiveEventVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetLiveEventVideoAlt1Error` | `Errors/GetLiveEventVideoAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideoAlt2

- **Signature**: `GetLiveEventVideoAlt2(double liveEventId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<GetLiveEventVideoAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetLiveEventVideoAlt2Error` | `Errors/GetLiveEventVideoAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideos

- **Signature**: `GetLiveEventVideos(double liveEventId, double userId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetLiveEventVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort17` | `Models/Enums/Sort17.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetLiveEventVideosError` | `Errors/GetLiveEventVideosError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideosAlt1

- **Signature**: `GetLiveEventVideosAlt1(double liveEventId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetLiveEventVideosAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort17` | `Models/Enums/Sort17.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetLiveEventVideosAlt1Error` | `Errors/GetLiveEventVideosAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventVideosAlt2

- **Signature**: `GetLiveEventVideosAlt2(double liveEventId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort17? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetLiveEventVideosAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort17` | `Models/Enums/Sort17.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetLiveEventVideosAlt2Error` | `Errors/GetLiveEventVideosAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideosFromLiveEvent

- **Signature**: `RemoveVideosFromLiveEvent(double liveEventId, double userId, UsersLiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsVideosRequest` | `Models/UsersLiveEventsVideosRequest.cs` |
| `RemoveVideosFromLiveEventError` | `Errors/RemoveVideosFromLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideosFromLiveEventAlt1

- **Signature**: `RemoveVideosFromLiveEventAlt1(double liveEventId, LiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsVideosRequest` | `Models/LiveEventsVideosRequest.cs` |
| `RemoveVideosFromLiveEventAlt1Error` | `Errors/RemoveVideosFromLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideosFromLiveEventAlt2

- **Signature**: `RemoveVideosFromLiveEventAlt2(double liveEventId, MeLiveEventsVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsVideosRequest` | `Models/MeLiveEventsVideosRequest.cs` |
| `RemoveVideosFromLiveEventAlt2Error` | `Errors/RemoveVideosFromLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

