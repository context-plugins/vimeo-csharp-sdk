<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosShowcases — operations

Accessor: `client.VideosShowcases` · Source: `Api/VideosShowcases.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddOrRemoveMultipleAlbums

- **Signature**: `AddOrRemoveMultipleAlbums(double videoId, VideosAlbumsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<Album>`
- **Error**: `SdkException<AddOrRemoveMultipleAlbumsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAlbumsRequest` | `Models/VideosAlbumsRequest.cs` |
| `Album` | `Models/Album.cs` |
| `AddOrRemoveMultipleAlbumsError` | `Errors/AddOrRemoveMultipleAlbumsError.cs` |
| `Error` | `Models/Error.cs` |

### GetVideoAlbums

- **Signature**: `GetVideoAlbums(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `AlbumConnection`
- **Error**: `SdkException<GetVideoAlbumsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AlbumConnection` | `Models/AlbumConnection.cs` |
| `GetVideoAlbumsError` | `Errors/GetVideoAlbumsError.cs` |
| `Error` | `Models/Error.cs` |

