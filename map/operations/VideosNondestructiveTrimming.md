<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosNondestructiveTrimming — operations

Accessor: `client.VideosNondestructiveTrimming` · Source: `Api/VideosNondestructiveTrimming.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ClipTrim

- **Signature**: `ClipTrim(double videoId, VideosTrimRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TrimmedVideo`
- **Error**: `SdkException<ClipTrimError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosTrimRequest` | `Models/VideosTrimRequest.cs` |
| `TrimmedVideo` | `Models/TrimmedVideo.cs` |
| `ClipTrimError` | `Errors/ClipTrimError.cs` |
| `Error` | `Models/Error.cs` |

