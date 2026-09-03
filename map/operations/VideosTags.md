<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosTags — operations

Accessor: `client.VideosTags` · Source: `Api/VideosTags.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Tag`
- **Error**: `SdkException<AddVideoTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Tag` | `Models/Tag.cs` |
| `AddVideoTagError` | `Errors/AddVideoTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideoTags

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoTags(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `IReadOnlyList<Tag>`
- **Error**: `SdkException<AddVideoTagsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Tag` | `Models/Tag.cs` |
| `AddVideoTagsError` | `Errors/AddVideoTagsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckVideoForTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckVideoForTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Tag`
- **Error**: `SdkException<CheckVideoForTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Tag` | `Models/Tag.cs` |
| `CheckVideoForTagError` | `Errors/CheckVideoForTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoTag(double videoId, string word, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoTagError` | `Errors/DeleteVideoTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoTags

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoTags(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `TagConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `TagConnection` | `Models/TagConnection.cs` |

### GetVideosWithTag

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideosWithTag(string word, Direction? direction, double? page, double? perPage, Sort47? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetVideosWithTagError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort47` | `Models/Enums/Sort47.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetVideosWithTagError` | `Errors/GetVideosWithTagError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

