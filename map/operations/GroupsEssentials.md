<!-- Generated file — do not edit; regenerated with the SDK. -->

# GroupsEssentials — operations

Accessor: `client.GroupsEssentials` · Source: `Api/GroupsEssentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateGroup

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateGroup(GroupsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Group`
- **Error**: `SdkException<CreateGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GroupsRequest` | `Models/GroupsRequest.cs` |
| `Group` | `Models/Group.cs` |
| `CreateGroupError` | `Errors/CreateGroupError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteGroup

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteGroup(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteGroupError` | `Errors/DeleteGroupError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### GetGroup

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGroup(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Group`
- **Error**: `SdkException<GetGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Group` | `Models/Group.cs` |
| `GetGroupError` | `Errors/GetGroupError.cs` |
| `Error` | `Models/Error.cs` |

### GetGroups

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGroups(Direction? direction, Filter1? filter, double? page, double? perPage, string? query, Sort13? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `GroupConnection`
- **Error**: `SdkException<GetGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter1` | `Models/Enums/Filter1.cs` |
| `Sort13` | `Models/Enums/Sort13.cs` |
| `GroupConnection` | `Models/GroupConnection.cs` |
| `GetGroupsError` | `Errors/GetGroupsError.cs` |
| `Error` | `Models/Error.cs` |

