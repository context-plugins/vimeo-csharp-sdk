<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbedPresetsCustomLogos — operations

Accessor: `client.EmbedPresetsCustomLogos` · Source: `Api/EmbedPresetsCustomLogos.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateCustomLogo

- **Signature**: `CreateCustomLogo(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateCustomLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateCustomLogoError` | `Errors/CreateCustomLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateCustomLogoAlt1

- **Signature**: `CreateCustomLogoAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateCustomLogoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateCustomLogoAlt1Error` | `Errors/CreateCustomLogoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteCustomLogo

- **Signature**: `DeleteCustomLogo(double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCustomLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomLogoError` | `Errors/DeleteCustomLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteCustomLogoAlt1

- **Signature**: `DeleteCustomLogoAlt1(double logoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteCustomLogoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteCustomLogoAlt1Error` | `Errors/DeleteCustomLogoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCustomLogo

- **Signature**: `GetCustomLogo(double logoId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetCustomLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetCustomLogoError` | `Errors/GetCustomLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCustomLogoAlt1

- **Signature**: `GetCustomLogoAlt1(double logoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetCustomLogoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetCustomLogoAlt1Error` | `Errors/GetCustomLogoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCustomLogos

- **Signature**: `GetCustomLogos(double userId, double? page, double? perPage, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `sizes` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `sizes` ← `sizes`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetCustomLogosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetCustomLogosError` | `Errors/GetCustomLogosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCustomLogosAlt1

- **Signature**: `GetCustomLogosAlt1(double? page, double? perPage, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `sizes` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `sizes` ← `sizes`
- **Returns**: `PictureConnection`
- **Error**: `SdkException<GetCustomLogosAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PictureConnection` | `Models/PictureConnection.cs` |
| `GetCustomLogosAlt1Error` | `Errors/GetCustomLogosAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

