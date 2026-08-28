<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosAnimatedThumbnails — operations

Accessor: `client.VideosAnimatedThumbnails` · Source: `Api/VideosAnimatedThumbnails.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAnimatedThumbset

- **Signature**: `CreateAnimatedThumbset(double videoId, VideosAnimatedThumbsetsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnimatedThumbset`
- **Error**: `SdkException<CreateAnimatedThumbsetError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [403, 429] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosAnimatedThumbsetsRequest` | `Models/VideosAnimatedThumbsetsRequest.cs` |
| `AnimatedThumbset` | `Models/AnimatedThumbset.cs` |
| `CreateAnimatedThumbsetError` | `Errors/CreateAnimatedThumbsetError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteAnimatedThumbset

- **Signature**: `DeleteAnimatedThumbset(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteAnimatedThumbsetError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAnimatedThumbsetError` | `Errors/DeleteAnimatedThumbsetError.cs` |
| `Error` | `Models/Error.cs` |

### GetAllAnimatedThumbset

- **Signature**: `GetAllAnimatedThumbset(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `AnimatedThumbsetConnection`
- **Error**: `SdkException<GetAllAnimatedThumbsetError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AnimatedThumbsetConnection` | `Models/AnimatedThumbsetConnection.cs` |
| `GetAllAnimatedThumbsetError` | `Errors/GetAllAnimatedThumbsetError.cs` |
| `Error` | `Models/Error.cs` |

### GetAnimatedThumbset

- **Signature**: `GetAnimatedThumbset(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnimatedThumbset`
- **Error**: `SdkException<GetAnimatedThumbsetError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AnimatedThumbset` | `Models/AnimatedThumbset.cs` |
| `GetAnimatedThumbsetError` | `Errors/GetAnimatedThumbsetError.cs` |
| `Error` | `Models/Error.cs` |

### GetAnimatedThumbsetStatus

- **Signature**: `GetAnimatedThumbsetStatus(string pictureId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AnimatedThumbset`
- **Error**: `SdkException<GetAnimatedThumbsetStatusError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AnimatedThumbset` | `Models/AnimatedThumbset.cs` |
| `GetAnimatedThumbsetStatusError` | `Errors/GetAnimatedThumbsetStatusError.cs` |
| `Error` | `Models/Error.cs` |

