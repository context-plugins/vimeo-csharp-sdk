<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosLiveM3U8Playback — operations

Accessor: `client.VideosLiveM3U8Playback` · Source: `Api/VideosLiveM3U8Playback.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetOneTimeEventM3U8Playback

- **Signature**: `GetOneTimeEventM3U8Playback(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetOneTimeEventM3U8PlaybackError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOneTimeEventM3U8PlaybackError` | `Errors/GetOneTimeEventM3U8PlaybackError.cs` |
| `Error` | `Models/Error.cs` |

### GetOneTimeEventM3U8PlaybackAlt1

- **Signature**: `GetOneTimeEventM3U8PlaybackAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetOneTimeEventM3U8PlaybackAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOneTimeEventM3U8PlaybackAlt1Error` | `Errors/GetOneTimeEventM3U8PlaybackAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

