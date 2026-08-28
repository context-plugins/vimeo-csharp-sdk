<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersSearch — operations

Accessor: `client.UsersSearch` · Source: `Api/UsersSearch.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchUsers

- **Signature**: `SearchUsers(Direction? direction, double? page, double? perPage, string? query, Sort13? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<SearchUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetLegacyError(out LegacyError)` [500, 503] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort13` | `Models/Enums/Sort13.cs` |
| `UserConnection` | `Models/UserConnection.cs` |
| `SearchUsersError` | `Errors/SearchUsersError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

