<!-- Generated file — do not edit; regenerated with the SDK. -->

# FoldersVideos — operations

Accessor: `client.FoldersVideos` · Source: `Api/FoldersVideos.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToProject(double projectId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToProjectError` | `Errors/AddVideoToProjectError.cs` |
| `Error` | `Models/Error.cs` |

### AddVideoToProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToProjectAlt1(double projectId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToProjectAlt1Error` | `Errors/AddVideoToProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### AddVideosToProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideosToProject(double projectId, double userId, UsersProjectsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersProjectsVideosRequest1` | `Models/UsersProjectsVideosRequest1.cs` |
| `AddVideosToProjectError` | `Errors/AddVideosToProjectError.cs` |
| `Error` | `Models/Error.cs` |

### AddVideosToProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideosToProjectAlt1(double projectId, MeProjectsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeProjectsVideosRequest1` | `Models/MeProjectsVideosRequest1.cs` |
| `AddVideosToProjectAlt1Error` | `Errors/AddVideosToProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetProjectVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProjectVideos(double projectId, double userId, Direction? direction, string? filterTag, string? filterTagAllOf, string? filterTagExclude, bool? includeSubfolders, double? page, double? perPage, string? query, string? queryFields, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter_tag` ← `filterTag`, `filter_tag_all_of` ← `filterTagAllOf`, `filter_tag_exclude` ← `filterTagExclude`, `include_subfolders` ← `includeSubfolders`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetProjectVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort37` | `Models/Enums/Sort37.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetProjectVideosError` | `Errors/GetProjectVideosError.cs` |
| `Error` | `Models/Error.cs` |

### GetProjectVideosAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProjectVideosAlt1(double projectId, Direction? direction, string? filterTag, string? filterTagAllOf, string? filterTagExclude, bool? includeSubfolders, double? page, double? perPage, string? query, string? queryFields, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter_tag` ← `filterTag`, `filter_tag_all_of` ← `filterTagAllOf`, `filter_tag_exclude` ← `filterTagExclude`, `include_subfolders` ← `includeSubfolders`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetProjectVideosAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort37` | `Models/Enums/Sort37.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetProjectVideosAlt1Error` | `Errors/GetProjectVideosAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideoFromProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideoFromProject(double projectId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideoFromProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveVideoFromProjectError` | `Errors/RemoveVideoFromProjectError.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideoFromProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideoFromProjectAlt1(double projectId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideoFromProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveVideoFromProjectAlt1Error` | `Errors/RemoveVideoFromProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideosFromProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideosFromProject(double projectId, double userId, UsersProjectsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersProjectsVideosRequest` | `Models/UsersProjectsVideosRequest.cs` |
| `RemoveVideosFromProjectError` | `Errors/RemoveVideosFromProjectError.cs` |
| `Error` | `Models/Error.cs` |

### RemoveVideosFromProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideosFromProjectAlt1(double projectId, MeProjectsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeProjectsVideosRequest` | `Models/MeProjectsVideosRequest.cs` |
| `RemoveVideosFromProjectAlt1Error` | `Errors/RemoveVideosFromProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

