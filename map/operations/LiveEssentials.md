<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEssentials — operations

Accessor: `client.LiveEssentials` · Source: `Api/LiveEssentials.cs` · 19 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateLiveEvent

- **Signature**: `CreateLiveEvent(double userId, UsersLiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<CreateLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsRequest1` | `Models/UsersLiveEventsRequest1.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `CreateLiveEventError` | `Errors/CreateLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### CreateLiveEventAlt1

- **Signature**: `CreateLiveEventAlt1(LiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<CreateLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsRequest1` | `Models/LiveEventsRequest1.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `CreateLiveEventAlt1Error` | `Errors/CreateLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### CreateLiveEventAlt2

- **Signature**: `CreateLiveEventAlt2(MeLiveEventsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<CreateLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsRequest1` | `Models/MeLiveEventsRequest1.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `CreateLiveEventAlt2Error` | `Errors/CreateLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEvent

- **Signature**: `DeleteLiveEvent(double liveEventId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventError` | `Errors/DeleteLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventAlt1

- **Signature**: `DeleteLiveEventAlt1(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventAlt1Error` | `Errors/DeleteLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventAlt2

- **Signature**: `DeleteLiveEventAlt2(double liveEventId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteLiveEventAlt2Error` | `Errors/DeleteLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEvents

- **Signature**: `DeleteLiveEvents(double userId, UsersLiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsRequest` | `Models/UsersLiveEventsRequest.cs` |
| `DeleteLiveEventsError` | `Errors/DeleteLiveEventsError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventsAlt1

- **Signature**: `DeleteLiveEventsAlt1(LiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsRequest` | `Models/LiveEventsRequest.cs` |
| `DeleteLiveEventsAlt1Error` | `Errors/DeleteLiveEventsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteLiveEventsAlt2

- **Signature**: `DeleteLiveEventsAlt2(MeLiveEventsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteLiveEventsAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsRequest` | `Models/MeLiveEventsRequest.cs` |
| `DeleteLiveEventsAlt2Error` | `Errors/DeleteLiveEventsAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEvent

- **Signature**: `GetLiveEvent(double liveEventId, double userId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `password` ← `password`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<GetLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `GetLiveEventError` | `Errors/GetLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventAlt1

- **Signature**: `GetLiveEventAlt1(double liveEventId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `password` ← `password`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<GetLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `GetLiveEventAlt1Error` | `Errors/GetLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventAlt2

- **Signature**: `GetLiveEventAlt2(double liveEventId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `password` ← `password`
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<GetLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `GetLiveEventAlt2Error` | `Errors/GetLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventOccurrences

- **Signature**: `GetLiveEventOccurrences(double userId, string startDate, string? endDate, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `endDate` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `start_date` ← `startDate`, `end_date` ← `endDate`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `LiveEventOccurrenceConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `LiveEventOccurrenceConnection` | `Models/LiveEventOccurrenceConnection.cs` |

### GetLiveEvents

- **Signature**: `GetLiveEvents(double userId, Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `type` ← `type`
- **Returns**: `EventConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter8` | `Models/Enums/Filter8.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `Type31` | `Models/Enums/Type31.cs` |
| `EventConnection` | `Models/EventConnection.cs` |

### GetLiveEventsAlt1

- **Signature**: `GetLiveEventsAlt1(Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `type` ← `type`
- **Returns**: `EventConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter8` | `Models/Enums/Filter8.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `Type31` | `Models/Enums/Type31.cs` |
| `EventConnection` | `Models/EventConnection.cs` |

### GetLiveEventsAlt2

- **Signature**: `GetLiveEventsAlt2(Direction? direction, Filter8? filter, double? page, double? perPage, string? query, Sort8? sort, Type31? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `type` ← `type`
- **Returns**: `EventConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter8` | `Models/Enums/Filter8.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `Type31` | `Models/Enums/Type31.cs` |
| `EventConnection` | `Models/EventConnection.cs` |

### UpdateLiveEvent

- **Signature**: `UpdateLiveEvent(double liveEventId, double userId, UsersLiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<UpdateLiveEventError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersLiveEventsRequest2` | `Models/UsersLiveEventsRequest2.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `UpdateLiveEventError` | `Errors/UpdateLiveEventError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateLiveEventAlt1

- **Signature**: `UpdateLiveEventAlt1(double liveEventId, LiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<UpdateLiveEventAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LiveEventsRequest2` | `Models/LiveEventsRequest2.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `UpdateLiveEventAlt1Error` | `Errors/UpdateLiveEventAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### UpdateLiveEventAlt2

- **Signature**: `UpdateLiveEventAlt2(double liveEventId, MeLiveEventsRequest2? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `RecurringEvent`
- **Error**: `SdkException<UpdateLiveEventAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeLiveEventsRequest2` | `Models/MeLiveEventsRequest2.cs` |
| `RecurringEvent` | `Models/RecurringEvent.cs` |
| `UpdateLiveEventAlt2Error` | `Errors/UpdateLiveEventAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

