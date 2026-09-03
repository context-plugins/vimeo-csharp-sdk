<!-- Generated file — do not edit; regenerated with the SDK. -->

# WatchLaterQueueEssentials — operations

Accessor: `client.WatchLaterQueueEssentials` · Source: `Api/WatchLaterQueueEssentials.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToWatchLater

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToWatchLater(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### AddVideoToWatchLaterAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToWatchLaterAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### CheckWatchLaterQueue

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckWatchLaterQueue(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<CheckWatchLaterQueueError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `CheckWatchLaterQueueError` | `Errors/CheckWatchLaterQueueError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckWatchLaterQueueAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckWatchLaterQueueAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<CheckWatchLaterQueueAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `CheckWatchLaterQueueAlt1Error` | `Errors/CheckWatchLaterQueueAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoFromWatchLater

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoFromWatchLater(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteVideoFromWatchLaterAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoFromWatchLaterAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetWatchLaterQueue

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetWatchLaterQueue(double userId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetWatchLaterQueueAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetWatchLaterQueueAlt1(Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

