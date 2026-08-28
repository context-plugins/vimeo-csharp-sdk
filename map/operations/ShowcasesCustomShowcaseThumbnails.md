<!-- Generated file — do not edit; regenerated with the SDK. -->

# ShowcasesCustomShowcaseThumbnails — operations

Accessor: `client.ShowcasesCustomShowcaseThumbnails` · Source: `Api/ShowcasesCustomShowcaseThumbnails.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateShowcaseCustomThumb

- **Signature**: `CreateShowcaseCustomThumb(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateShowcaseCustomThumbError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateShowcaseCustomThumbError` | `Errors/CreateShowcaseCustomThumbError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteShowcaseCustomThumbnail

- **Signature**: `DeleteShowcaseCustomThumbnail(double albumId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteShowcaseCustomThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteShowcaseCustomThumbnailError` | `Errors/DeleteShowcaseCustomThumbnailError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseCustomThumbnail

- **Signature**: `GetShowcaseCustomThumbnail(double albumId, double thumbnailId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetShowcaseCustomThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetShowcaseCustomThumbnailError` | `Errors/GetShowcaseCustomThumbnailError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseCustomThumbs

- **Signature**: `GetShowcaseCustomThumbs(double albumId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetShowcaseCustomThumbsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetShowcaseCustomThumbsError` | `Errors/GetShowcaseCustomThumbsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### ReplaceShowcaseCustomThumb

- **Signature**: `ReplaceShowcaseCustomThumb(double albumId, double thumbnailId, double userId, UsersAlbumsCustomThumbnailsThumbnailIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<ReplaceShowcaseCustomThumbError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsCustomThumbnailsThumbnailIdRequest` | `Models/UsersAlbumsCustomThumbnailsThumbnailIdRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `ReplaceShowcaseCustomThumbError` | `Errors/ReplaceShowcaseCustomThumbError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

