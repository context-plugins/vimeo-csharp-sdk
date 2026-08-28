<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbedPresetsVideos — operations

Accessor: `client.EmbedPresetsVideos` · Source: `Api/EmbedPresetsVideos.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoEmbedPreset

- **Signature**: `AddVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteVideoEmbedPreset

- **Signature**: `DeleteVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoEmbedPresetError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoEmbedPresetError` | `Errors/DeleteVideoEmbedPresetError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetEmbedPresetVideos

- **Signature**: `GetEmbedPresetVideos(double presetId, double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetEmbedPresetVideosAlt1

- **Signature**: `GetEmbedPresetVideosAlt1(double presetId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetVideoEmbedPreset

- **Signature**: `GetVideoEmbedPreset(double presetId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetVideoEmbedPresetError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetVideoEmbedPresetError` | `Errors/GetVideoEmbedPresetError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

