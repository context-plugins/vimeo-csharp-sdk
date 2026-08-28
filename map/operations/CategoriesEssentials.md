<!-- Generated file — do not edit; regenerated with the SDK. -->

# CategoriesEssentials — operations

Accessor: `client.CategoriesEssentials` · Source: `Api/CategoriesEssentials.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCategories

- **Signature**: `GetCategories(Direction? direction, double? page, double? perPage, Sort3? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `CategoryConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort3` | `Models/Enums/Sort3.cs` |
| `CategoryConnection` | `Models/CategoryConnection.cs` |

### GetCategory

- **Signature**: `GetCategory(string category, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Category`
- **Error**: `SdkException<GetCategoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Category` | `Models/Category.cs` |
| `GetCategoryError` | `Errors/GetCategoryError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

