<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosRecommendations — operations

Accessor: `client.VideosRecommendations` · Source: `Api/VideosRecommendations.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetRelatedVideos

- **Signature**: `GetRelatedVideos(double videoId, Filter46? filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `filter` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetRelatedVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Filter46` | `Models/Enums/Filter46.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetRelatedVideosError` | `Errors/GetRelatedVideosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

