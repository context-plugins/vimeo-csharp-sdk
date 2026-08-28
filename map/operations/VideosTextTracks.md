<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosTextTracks — operations

Accessor: `client.VideosTextTracks` · Source: `Api/VideosTextTracks.cs` · 9 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateTextTrack

- **Signature**: `CreateTextTrack(double videoId, VideosTexttracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TextTrack`
- **Error**: `SdkException<CreateTextTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosTexttracksRequest` | `Models/VideosTexttracksRequest.cs` |
| `TextTrack` | `Models/TextTrack.cs` |
| `CreateTextTrackError` | `Errors/CreateTextTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateTextTrackAlt1

- **Signature**: `CreateTextTrackAlt1(double channelId, double videoId, ChannelsVideosTexttracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TextTrack`
- **Error**: `SdkException<CreateTextTrackAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsVideosTexttracksRequest` | `Models/ChannelsVideosTexttracksRequest.cs` |
| `TextTrack` | `Models/TextTrack.cs` |
| `CreateTextTrackAlt1Error` | `Errors/CreateTextTrackAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteTextTrack

- **Signature**: `DeleteTextTrack(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteTextTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteTextTrackError` | `Errors/DeleteTextTrackError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditTextTrack

- **Signature**: `EditTextTrack(double texttrackId, double videoId, VideosTexttracksRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `TextTrack`
- **Error**: `SdkException<EditTextTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosTexttracksRequest1` | `Models/VideosTexttracksRequest1.cs` |
| `TextTrack` | `Models/TextTrack.cs` |
| `EditTextTrackError` | `Errors/EditTextTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTextTrack

- **Signature**: `GetTextTrack(double texttrackId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `TextTrack`
- **Error**: `SdkException<GetTextTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TextTrack` | `Models/TextTrack.cs` |
| `GetTextTrackError` | `Errors/GetTextTrackError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTextTracks

- **Signature**: `GetTextTracks(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `TextTrackConnection`
- **Error**: `SdkException<GetTextTracksError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TextTrackConnection` | `Models/TextTrackConnection.cs` |
| `GetTextTracksError` | `Errors/GetTextTracksError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTextTracksAlt1

- **Signature**: `GetTextTracksAlt1(double videoId, string versionId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `TextTrackConnection`
- **Error**: `SdkException<GetTextTracksAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TextTrackConnection` | `Models/TextTrackConnection.cs` |
| `GetTextTracksAlt1Error` | `Errors/GetTextTracksAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTextTracksAlt2

- **Signature**: `GetTextTracksAlt2(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `TextTrackConnection`
- **Error**: `SdkException<GetTextTracksAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TextTrackConnection` | `Models/TextTrackConnection.cs` |
| `GetTextTracksAlt2Error` | `Errors/GetTextTracksAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTextTracksAlt3

- **Signature**: `GetTextTracksAlt3(double albumId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `TextTrackConnection`
- **Error**: `SdkException<GetTextTracksAlt3Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TextTrackConnection` | `Models/TextTrackConnection.cs` |
| `GetTextTracksAlt3Error` | `Errors/GetTextTracksAlt3Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

