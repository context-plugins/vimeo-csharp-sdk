<!-- Generated file — do not edit; regenerated with the SDK. -->

# GroupsVideos — operations

Accessor: `client.GroupsVideos` · Source: `Api/GroupsVideos.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToGroup

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToGroup(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<AddVideoToGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `AddVideoToGroupError` | `Errors/AddVideoToGroupError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteVideoFromGroup

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoFromGroup(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoFromGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoFromGroupError` | `Errors/DeleteVideoFromGroupError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### GetAvailableVideoGroups

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableVideoGroups(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `GroupConnection`
- **Error**: `SdkException<GetAvailableVideoGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GroupConnection` | `Models/GroupConnection.cs` |
| `GetAvailableVideoGroupsError` | `Errors/GetAvailableVideoGroupsError.cs` |
| `Error` | `Models/Error.cs` |

### GetGroupVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGroupVideo(double groupId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<GetGroupVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetGroupVideoError` | `Errors/GetGroupVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetGroupVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGroupVideos(double groupId, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, Sort15? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetGroupVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort15` | `Models/Enums/Sort15.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetGroupVideosError` | `Errors/GetGroupVideosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

