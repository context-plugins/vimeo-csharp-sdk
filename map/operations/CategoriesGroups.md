<!-- Generated file — do not edit; regenerated with the SDK. -->

# CategoriesGroups — operations

Accessor: `client.CategoriesGroups` · Source: `Api/CategoriesGroups.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCategoryGroups

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCategoryGroups(string category, Direction? direction, double? page, double? perPage, string? query, Sort5? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `GroupConnection`
- **Error**: `SdkException<GetCategoryGroupsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort5` | `Models/Enums/Sort5.cs` |
| `GroupConnection` | `Models/GroupConnection.cs` |
| `GetCategoryGroupsError` | `Errors/GetCategoryGroupsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

