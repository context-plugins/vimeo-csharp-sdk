<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandBackgrounds — operations

Accessor: `client.OnDemandBackgrounds` · Source: `Api/OnDemandBackgrounds.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVodBackground

- **Signature**: `CreateVodBackground(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateVodBackgroundError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateVodBackgroundError` | `Errors/CreateVodBackgroundError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVodBackground

- **Signature**: `DeleteVodBackground(double backgroundId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVodBackgroundError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVodBackgroundError` | `Errors/DeleteVodBackgroundError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditVodBackground

- **Signature**: `EditVodBackground(double backgroundId, double ondemandId, OndemandPagesBackgroundsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<EditVodBackgroundError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesBackgroundsRequest` | `Models/OndemandPagesBackgroundsRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `EditVodBackgroundError` | `Errors/EditVodBackgroundError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodBackground

- **Signature**: `GetVodBackground(double backgroundId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetVodBackgroundError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetVodBackgroundError` | `Errors/GetVodBackgroundError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodBackgrounds

- **Signature**: `GetVodBackgrounds(double ondemandId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetVodBackgroundsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetVodBackgroundsError` | `Errors/GetVodBackgroundsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

