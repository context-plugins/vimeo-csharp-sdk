<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosEssentials — operations

Accessor: `client.VideosEssentials` · Source: `Api/VideosEssentials.cs` · 15 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfUserOwnsVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckIfUserOwnsVideo(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<CheckIfUserOwnsVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `CheckIfUserOwnsVideoError` | `Errors/CheckIfUserOwnsVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckIfUserOwnsVideoAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckIfUserOwnsVideoAlt1(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<CheckIfUserOwnsVideoAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `CheckIfUserOwnsVideoAlt1Error` | `Errors/CheckIfUserOwnsVideoAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CopyVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CopyVideo(double userId, double videoId, UsersVideosCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Video`
- **Error**: `SdkException<CopyVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersVideosCopyRequest` | `Models/UsersVideosCopyRequest.cs` |
| `Video` | `Models/Video.cs` |
| `CopyVideoError` | `Errors/CopyVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CopyVideoAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CopyVideoAlt2(double videoId, MeVideosCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Video`
- **Error**: `SdkException<CopyVideoAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeVideosCopyRequest` | `Models/MeVideosCopyRequest.cs` |
| `Video` | `Models/Video.cs` |
| `CopyVideoAlt2Error` | `Errors/CopyVideoAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideo(double videoId, VideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosRequest` | `Models/VideosRequest.cs` |
| `DeleteVideoError` | `Errors/DeleteVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideos(double userId, string uris, UsersVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `uris` ← `uris`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersVideosRequest` | `Models/UsersVideosRequest.cs` |
| `DeleteVideosError` | `Errors/DeleteVideosError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteVideosAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideosAlt1(string uris, MeVideosRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `uris` ← `uris`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideosAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeVideosRequest` | `Models/MeVideosRequest.cs` |
| `DeleteVideosAlt1Error` | `Errors/DeleteVideosAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### EditVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditVideo(double videoId, VideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<EditVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosRequest1` | `Models/VideosRequest1.cs` |
| `Video` | `Models/Video.cs` |
| `EditVideoError` | `Errors/EditVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAppearances

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAppearances(double userId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetAppearancesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetAppearancesError` | `Errors/GetAppearancesError.cs` |
| `Error` | `Models/Error.cs` |

### GetAppearancesAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAppearancesAlt1(Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetAppearancesAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetAppearancesAlt1Error` | `Errors/GetAppearancesAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideo(double videoId, bool? timeLinks, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `timeLinks` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `time_links` ← `timeLinks`
- **Returns**: `Video`
- **Error**: `SdkException<GetVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetVideoError` | `Errors/GetVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideos(double userId, string? containingUri, Direction? direction, Filter22? filter, bool? filterEmbeddable, bool? filterPlayable, bool? filterScreenRecorded, string? filterTag, string? filterTagAllOf, string? filterTagExclude, double? filterUploader, double? page, double? perPage, string? query, QueryFields? queryFields, Sort39? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 15 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `filter_playable` ← `filterPlayable`, `filter_screen_recorded` ← `filterScreenRecorded`, `filter_tag` ← `filterTag`, `filter_tag_all_of` ← `filterTagAllOf`, `filter_tag_exclude` ← `filterTagExclude`, `filter_uploader` ← `filterUploader`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter22` | `Models/Enums/Filter22.cs` |
| `QueryFields` | `Models/Enums/QueryFields.cs` |
| `Sort39` | `Models/Enums/Sort39.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetVideosAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideosAlt1(string? containingUri, Direction? direction, Filter22? filter, bool? filterEmbeddable, bool? filterPlayable, bool? filterScreenRecorded, string? filterTag, string? filterTagAllOf, string? filterTagExclude, double? filterUploader, double? page, double? perPage, string? query, QueryFields? queryFields, Sort39? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 15 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `filter_playable` ← `filterPlayable`, `filter_screen_recorded` ← `filterScreenRecorded`, `filter_tag` ← `filterTag`, `filter_tag_all_of` ← `filterTagAllOf`, `filter_tag_exclude` ← `filterTagExclude`, `filter_uploader` ← `filterUploader`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter22` | `Models/Enums/Filter22.cs` |
| `QueryFields` | `Models/Enums/QueryFields.cs` |
| `Sort39` | `Models/Enums/Sort39.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

### SearchVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SearchVideos(Direction? direction, Filter45? filter, string? links, double? page, double? perPage, string? query, Sort73? sort, string? uris, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 8 params (`direction` … `uris`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `links` ← `links`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `uris` ← `uris`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<SearchVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 404] · `TryGetLegacyError(out LegacyError)` [503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter45` | `Models/Enums/Filter45.cs` |
| `Sort73` | `Models/Enums/Sort73.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `SearchVideosError` | `Errors/SearchVideosError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UpdateVideoCustomMetadata

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateVideoCustomMetadata(double videoId, VideosCustomMetadataRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<CustomMetadataValues>`
- **Error**: `SdkException<UpdateVideoCustomMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCustomMetadataRequest` | `Models/VideosCustomMetadataRequest.cs` |
| `CustomMetadataValues` | `Models/CustomMetadataValues.cs` |
| `UpdateVideoCustomMetadataError` | `Errors/UpdateVideoCustomMetadataError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

