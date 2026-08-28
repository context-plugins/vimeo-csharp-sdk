<!-- Generated file — do not edit; regenerated with the SDK. -->

# LikesEssentials — operations

Accessor: `client.LikesEssentials` · Source: `Api/LikesEssentials.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfUserLikedVideo

- **Signature**: `CheckIfUserLikedVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserLikedVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserLikedVideoError` | `Errors/CheckIfUserLikedVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckIfUserLikedVideoAlt1

- **Signature**: `CheckIfUserLikedVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserLikedVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserLikedVideoAlt1Error` | `Errors/CheckIfUserLikedVideoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetLikes

- **Signature**: `GetLikes(double userId, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`filter` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetLikesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetLikesError` | `Errors/GetLikesError.cs` |
| `Error` | `Models/Error.cs` |

### GetLikesAlt1

- **Signature**: `GetLikesAlt1(Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`filter` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetLikesAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetLikesAlt1Error` | `Errors/GetLikesAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetVideoLikes

- **Signature**: `GetVideoLikes(double videoId, Direction? direction, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |

### GetVideoLikesAlt1

- **Signature**: `GetVideoLikesAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |

### GetVodLikes

- **Signature**: `GetVodLikes(double ondemandId, Direction? direction, Filter25? filter, double? page, double? perPage, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetVodLikesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter25` | `Models/Enums/Filter25.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetVodLikesError` | `Errors/GetVodLikesError.cs` |
| `Error` | `Models/Error.cs` |

### LikeVideo

- **Signature**: `LikeVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<LikeVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LikeVideoError` | `Errors/LikeVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### LikeVideoAlt1

- **Signature**: `LikeVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<LikeVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `LikeVideoAlt1Error` | `Errors/LikeVideoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UnlikeVideo

- **Signature**: `UnlikeVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UnlikeVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnlikeVideoError` | `Errors/UnlikeVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UnlikeVideoAlt1

- **Signature**: `UnlikeVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UnlikeVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnlikeVideoAlt1Error` | `Errors/UnlikeVideoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

