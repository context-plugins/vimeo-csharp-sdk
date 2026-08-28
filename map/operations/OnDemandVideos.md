<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandVideos — operations

Accessor: `client.OnDemandVideos` · Source: `Api/OnDemandVideos.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToVod

- **Signature**: `AddVideoToVod(double ondemandId, double videoId, OndemandPagesVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandVideo`
- **Error**: `SdkException<AddVideoToVodError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesVideosRequest` | `Models/OndemandPagesVideosRequest.cs` |
| `OnDemandVideo` | `Models/OnDemandVideo.cs` |
| `AddVideoToVodError` | `Errors/AddVideoToVodError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoFromVod

- **Signature**: `DeleteVideoFromVod(double ondemandId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoFromVodError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoFromVodError` | `Errors/DeleteVideoFromVodError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodVideo

- **Signature**: `GetVodVideo(double ondemandId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |

### GetVodVideos

- **Signature**: `GetVodVideos(double ondemandId, Direction? direction, Filter29? filter, double? page, double? perPage, Sort45? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandVideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter29` | `Models/Enums/Filter29.cs` |
| `Sort45` | `Models/Enums/Sort45.cs` |
| `OnDemandVideoConnection` | `Models/OnDemandVideoConnection.cs` |

