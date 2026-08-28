<!-- Generated file — do not edit; regenerated with the SDK. -->

# GroupsUsers — operations

Accessor: `client.GroupsUsers` · Source: `Api/GroupsUsers.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfUserJoinedGroup

- **Signature**: `CheckIfUserJoinedGroup(double groupId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserJoinedGroupError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserJoinedGroupError` | `Errors/CheckIfUserJoinedGroupError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckIfUserJoinedGroupAlt1

- **Signature**: `CheckIfUserJoinedGroupAlt1(double groupId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserJoinedGroupAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserJoinedGroupAlt1Error` | `Errors/CheckIfUserJoinedGroupAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetGroupMembers

- **Signature**: `GetGroupMembers(double groupId, Direction? direction, Filter2? filter, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetGroupMembersError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter2` | `Models/Enums/Filter2.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetGroupMembersError` | `Errors/GetGroupMembersError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetUserGroups

- **Signature**: `GetUserGroups(double userId, Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `GroupConnection`
- **Error**: `SdkException<GetUserGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter12` | `Models/Enums/Filter12.cs` |
| `Sort5` | `Models/Enums/Sort5.cs` |
| `GroupConnection` | `Models/GroupConnection.cs` |
| `GetUserGroupsError` | `Errors/GetUserGroupsError.cs` |
| `Error` | `Models/Error.cs` |

### GetUserGroupsAlt1

- **Signature**: `GetUserGroupsAlt1(Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `GroupConnection`
- **Error**: `SdkException<GetUserGroupsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter12` | `Models/Enums/Filter12.cs` |
| `Sort5` | `Models/Enums/Sort5.cs` |
| `GroupConnection` | `Models/GroupConnection.cs` |
| `GetUserGroupsAlt1Error` | `Errors/GetUserGroupsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

