<!-- Generated file — do not edit; regenerated with the SDK. -->

# ShowcasesCustomShowcaseLogos — operations

Accessor: `client.ShowcasesCustomShowcaseLogos` · Source: `Api/ShowcasesCustomShowcaseLogos.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateShowcaseLogo

- **Signature**: `CreateShowcaseLogo(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateShowcaseLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateShowcaseLogoError` | `Errors/CreateShowcaseLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteShowcaseLogo

- **Signature**: `DeleteShowcaseLogo(double albumId, double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteShowcaseLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteShowcaseLogoError` | `Errors/DeleteShowcaseLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseLogo

- **Signature**: `GetShowcaseLogo(double albumId, double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetShowcaseLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetShowcaseLogoError` | `Errors/GetShowcaseLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseLogos

- **Signature**: `GetShowcaseLogos(double albumId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetShowcaseLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetShowcaseLogosError` | `Errors/GetShowcaseLogosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### ReplaceShowcaseLogo

- **Signature**: `ReplaceShowcaseLogo(double albumId, double logoId, double userId, UsersAlbumsLogosLogoIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Picture`
- **Error**: `SdkException<ReplaceShowcaseLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsLogosLogoIdRequest` | `Models/UsersAlbumsLogosLogoIdRequest.cs` |
| `Picture` | `Models/Picture.cs` |
| `ReplaceShowcaseLogoError` | `Errors/ReplaceShowcaseLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

