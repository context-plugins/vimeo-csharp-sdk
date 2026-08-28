<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandPosters — operations

Accessor: `client.OnDemandPosters` · Source: `Api/OnDemandPosters.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVodPoster

- **Signature**: `AddVodPoster(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<AddVodPosterError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `AddVodPosterError` | `Errors/AddVodPosterError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditVodPoster

- **Signature**: `EditVodPoster(double ondemandId, double posterId, OndemandPagesPicturesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OndemandPagesPicturesRequest` | `Models/OndemandPagesPicturesRequest.cs` |
| `Picture` | `Models/Picture.cs` |

### GetVodPoster

- **Signature**: `GetVodPoster(double ondemandId, double posterId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### GetVodPosters

- **Signature**: `GetVodPosters(double ondemandId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetVodPostersError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetVodPostersError` | `Errors/GetVodPostersError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

