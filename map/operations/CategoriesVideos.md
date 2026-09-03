<!-- Generated file — do not edit; regenerated with the SDK. -->

# CategoriesVideos — operations

Accessor: `client.CategoriesVideos` · Source: `Api/CategoriesVideos.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckCategoryForVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckCategoryForVideo(string category, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<CheckCategoryForVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `CheckCategoryForVideoError` | `Errors/CheckCategoryForVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetCategoryVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCategoryVideos(string category, Direction? direction, Filter? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort6? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetCategoryVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter` | `Models/Enums/Filter.cs` |
| `Sort6` | `Models/Enums/Sort6.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetCategoryVideosError` | `Errors/GetCategoryVideosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoCategories

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoCategories(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `CategoryConnection`
- **Error**: `SdkException<GetVideoCategoriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CategoryConnection` | `Models/CategoryConnection.cs` |
| `GetVideoCategoriesError` | `Errors/GetVideoCategoriesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SuggestVideoCategory

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SuggestVideoCategory(double videoId, VideosCategoriesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Category`
- **Error**: `SdkException<SuggestVideoCategoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCategoriesRequest` | `Models/VideosCategoriesRequest.cs` |
| `Category` | `Models/Category.cs` |
| `SuggestVideoCategoryError` | `Errors/SuggestVideoCategoryError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

