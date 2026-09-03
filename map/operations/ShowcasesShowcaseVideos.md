<!-- Generated file — do not edit; regenerated with the SDK. -->

# ShowcasesShowcaseVideos — operations

Accessor: `client.ShowcasesShowcaseVideos` · Source: `Api/ShowcasesShowcaseVideos.cs` · 16 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToShowcase(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToShowcaseError` | `Errors/AddVideoToShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideoToShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToShowcaseAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToShowcaseAlt2Error` | `Errors/AddVideoToShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAvailableShowcaseVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableShowcaseVideos(double albumId, Direction? direction, double? page, double? perPage, string? query, Sort2? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetAvailableShowcaseVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort2` | `Models/Enums/Sort2.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetAvailableShowcaseVideosError` | `Errors/GetAvailableShowcaseVideosError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAvailableVideoShowcases

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableVideoShowcases(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort74? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `AlbumConnection`
- **Error**: `SdkException<GetAvailableVideoShowcasesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort74` | `Models/Enums/Sort74.cs` |
| `AlbumConnection` | `Models/AlbumConnection.cs` |
| `GetAvailableVideoShowcasesError` | `Errors/GetAvailableVideoShowcasesError.cs` |
| `Error` | `Models/Error.cs` |

### GetShowcaseVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcaseVideo(double albumId, double userId, double videoId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `password` ← `password`
- **Returns**: `Video`
- **Error**: `SdkException<GetShowcaseVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetShowcaseVideoError` | `Errors/GetShowcaseVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseVideoAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcaseVideoAlt2(double albumId, double videoId, string? password, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `password` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `password` ← `password`
- **Returns**: `Video`
- **Error**: `SdkException<GetShowcaseVideoAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetShowcaseVideoAlt2Error` | `Errors/GetShowcaseVideoAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcaseVideos(double albumId, double userId, string? containingUri, Direction? direction, Filter10? filter, bool? filterEmbeddable, double? page, string? password, double? perPage, string? query, Sort21? sort, bool? weakSearch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`containingUri` … `weakSearch`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `password` ← `password`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `weak_search` ← `weakSearch`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetShowcaseVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter10` | `Models/Enums/Filter10.cs` |
| `Sort21` | `Models/Enums/Sort21.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetShowcaseVideosError` | `Errors/GetShowcaseVideosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseVideosAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcaseVideosAlt2(double albumId, string? containingUri, Direction? direction, Filter10? filter, bool? filterEmbeddable, double? page, string? password, double? perPage, string? query, Sort21? sort, bool? weakSearch, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`containingUri` … `weakSearch`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `password` ← `password`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`, `weak_search` ← `weakSearch`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetShowcaseVideosAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter10` | `Models/Enums/Filter10.cs` |
| `Sort21` | `Models/Enums/Sort21.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetShowcaseVideosAlt2Error` | `Errors/GetShowcaseVideosAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### RemoveVideoFromShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideoFromShowcase(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideoFromShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveVideoFromShowcaseError` | `Errors/RemoveVideoFromShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### RemoveVideoFromShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideoFromShowcaseAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideoFromShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveVideoFromShowcaseAlt2Error` | `Errors/RemoveVideoFromShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### ReplaceVideosInShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ReplaceVideosInShowcase(double albumId, double userId, UsersAlbumsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<ReplaceVideosInShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsVideosRequest` | `Models/UsersAlbumsVideosRequest.cs` |
| `ReplaceVideosInShowcaseError` | `Errors/ReplaceVideosInShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### ReplaceVideosInShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `ReplaceVideosInShowcaseAlt2(double albumId, MeAlbumsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<ReplaceVideosInShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeAlbumsVideosRequest` | `Models/MeAlbumsVideosRequest.cs` |
| `ReplaceVideosInShowcaseAlt2Error` | `Errors/ReplaceVideosInShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SetVideoAsShowcaseFeatured

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetVideoAsShowcaseFeatured(double albumId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<SetVideoAsShowcaseFeaturedError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Album` | `Models/Album.cs` |
| `SetVideoAsShowcaseFeaturedError` | `Errors/SetVideoAsShowcaseFeaturedError.cs` |
| `Error` | `Models/Error.cs` |

### SetVideoAsShowcaseFeaturedAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetVideoAsShowcaseFeaturedAlt2(double albumId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<SetVideoAsShowcaseFeaturedAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Album` | `Models/Album.cs` |
| `SetVideoAsShowcaseFeaturedAlt2Error` | `Errors/SetVideoAsShowcaseFeaturedAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

### SetVideoAsShowcaseThumbnail

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetVideoAsShowcaseThumbnail(double albumId, double userId, double videoId, UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<SetVideoAsShowcaseThumbnailError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest` | `Models/UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest.cs` |
| `Album` | `Models/Album.cs` |
| `SetVideoAsShowcaseThumbnailError` | `Errors/SetVideoAsShowcaseThumbnailError.cs` |
| `Error` | `Models/Error.cs` |

### SetVideoAsShowcaseThumbnailAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetVideoAsShowcaseThumbnailAlt2(double albumId, double videoId, MeAlbumsVideosSetAlbumThumbnailRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<SetVideoAsShowcaseThumbnailAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeAlbumsVideosSetAlbumThumbnailRequest` | `Models/MeAlbumsVideosSetAlbumThumbnailRequest.cs` |
| `Album` | `Models/Album.cs` |
| `SetVideoAsShowcaseThumbnailAlt2Error` | `Errors/SetVideoAsShowcaseThumbnailAlt2Error.cs` |
| `Error` | `Models/Error.cs` |

