<!-- Generated file — do not edit; regenerated with the SDK. -->

# LiveEventM3U8Playback — operations

Accessor: `client.LiveEventM3U8Playback` · Source: `Api/LiveEventM3U8Playback.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetLiveEventM3U8Playback

- **Signature**: `GetLiveEventM3U8Playback(double liveEventId, double userId, double? dvr, double? maxFpsFhd, double? ttl, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `dvr` — nullable, no default → **must pass explicitly**
  - `maxFpsFhd` — nullable, no default → **must pass explicitly**
  - `ttl` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `dvr` ← `dvr`, `max_fps_fhd` ← `maxFpsFhd`, `ttl` ← `ttl`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetLiveEventM3U8PlaybackError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLiveEventM3U8PlaybackError` | `Errors/GetLiveEventM3U8PlaybackError.cs` |
| `Error` | `Models/Error.cs` |

### GetLiveEventM3U8PlaybackAlt1

- **Signature**: `GetLiveEventM3U8PlaybackAlt1(double liveEventId, double? dvr, double? maxFpsFhd, double? ttl, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `dvr` — nullable, no default → **must pass explicitly**
  - `maxFpsFhd` — nullable, no default → **must pass explicitly**
  - `ttl` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `dvr` ← `dvr`, `max_fps_fhd` ← `maxFpsFhd`, `ttl` ← `ttl`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetLiveEventM3U8PlaybackAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetLiveEventM3U8PlaybackAlt1Error` | `Errors/GetLiveEventM3U8PlaybackAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

