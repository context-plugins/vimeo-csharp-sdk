<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosVersions — operations

Accessor: `client.VideosVersions` · Source: `Api/VideosVersions.cs` · 13 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateAudioTrack

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateAudioTrack(double versionId, double videoId, VideosVersionsAudiotracksRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AlternateAudioTrack`
- **Error**: `SdkException<CreateAudioTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosVersionsAudiotracksRequest` | `Models/VideosVersionsAudiotracksRequest.cs` |
| `AlternateAudioTrack` | `Models/AlternateAudioTrack.cs` |
| `CreateAudioTrackError` | `Errors/CreateAudioTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateVideoVersion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateVideoVersion(double videoId, VideosVersionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `VideoVersion`
- **Error**: `SdkException<CreateVideoVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosVersionsRequest` | `Models/VideosVersionsRequest.cs` |
| `VideoVersion` | `Models/VideoVersion.cs` |
| `CreateVideoVersionError` | `Errors/CreateVideoVersionError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteAudioTrack

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteAudioTrack(string audiotrackId, double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteAudioTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAudioTrackError` | `Errors/DeleteAudioTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoVersion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoVersion(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoVersionError` | `Errors/DeleteVideoVersionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditAudioTrack

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditAudioTrack(string audiotrackId, double versionId, double videoId, VideosVersionsAudiotracksAudiotrackIdRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AlternateAudioTrack`
- **Error**: `SdkException<EditAudioTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosVersionsAudiotracksAudiotrackIdRequest` | `Models/VideosVersionsAudiotracksAudiotrackIdRequest.cs` |
| `AlternateAudioTrack` | `Models/AlternateAudioTrack.cs` |
| `EditAudioTrackError` | `Errors/EditAudioTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditVideoVersion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditVideoVersion(double versionId, double videoId, VideosVersionsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `VideoVersion`
- **Error**: `SdkException<EditVideoVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosVersionsRequest1` | `Models/VideosVersionsRequest1.cs` |
| `VideoVersion` | `Models/VideoVersion.cs` |
| `EditVideoVersionError` | `Errors/EditVideoVersionError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAudioTrack

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAudioTrack(string audiotrackId, double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AlternateAudioTrack`
- **Error**: `SdkException<GetAudioTrackError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AlternateAudioTrack` | `Models/AlternateAudioTrack.cs` |
| `GetAudioTrackError` | `Errors/GetAudioTrackError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAudioTracks

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAudioTracks(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AlternateAudioTrackConnection`
- **Error**: `SdkException<GetAudioTracksError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AlternateAudioTrackConnection` | `Models/AlternateAudioTrackConnection.cs` |
| `GetAudioTracksError` | `Errors/GetAudioTracksError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAudiotrackDownloads

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAudiotrackDownloads(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetVersionThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVersionThumbnail(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |

### GetVideoVersion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoVersion(double versionId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `VideoVersion`
- **Error**: `SdkException<GetVideoVersionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideoVersion` | `Models/VideoVersion.cs` |
| `GetVideoVersionError` | `Errors/GetVideoVersionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoVersions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoVersions(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoVersionConnection`
- **Error**: `SdkException<GetVideoVersionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideoVersionConnection` | `Models/VideoVersionConnection.cs` |
| `GetVideoVersionsError` | `Errors/GetVideoVersionsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoVersionsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoVersionsAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoVersionConnection`
- **Error**: `SdkException<GetVideoVersionsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideoVersionConnection` | `Models/VideoVersionConnection.cs` |
| `GetVideoVersionsAlt1Error` | `Errors/GetVideoVersionsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

