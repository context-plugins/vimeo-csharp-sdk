<!-- Generated file — do not edit; regenerated with the SDK. -->

# CategoriesUsers — operations

Accessor: `client.CategoriesUsers` · Source: `Api/CategoriesUsers.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfUserSubscribedToCategory

- **Signature**: `CheckIfUserSubscribedToCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### CheckIfUserSubscribedToCategoryAlt1

- **Signature**: `CheckIfUserSubscribedToCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetCategorySubscriptions

- **Signature**: `GetCategorySubscriptions(double userId, Direction? direction, double? page, double? perPage, Sort24? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `CategoryConnection`
- **Error**: `SdkException<GetCategorySubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort24` | `Models/Enums/Sort24.cs` |
| `CategoryConnection` | `Models/CategoryConnection.cs` |
| `GetCategorySubscriptionsError` | `Errors/GetCategorySubscriptionsError.cs` |
| `Error` | `Models/Error.cs` |

### GetCategorySubscriptionsAlt1

- **Signature**: `GetCategorySubscriptionsAlt1(Direction? direction, double? page, double? perPage, Sort24? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `CategoryConnection`
- **Error**: `SdkException<GetCategorySubscriptionsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort24` | `Models/Enums/Sort24.cs` |
| `CategoryConnection` | `Models/CategoryConnection.cs` |
| `GetCategorySubscriptionsAlt1Error` | `Errors/GetCategorySubscriptionsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### SubscribeToCategory

- **Signature**: `SubscribeToCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### SubscribeToCategoryAlt1

- **Signature**: `SubscribeToCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### UnsubscribeFromCategory

- **Signature**: `UnsubscribeFromCategory(string category, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### UnsubscribeFromCategoryAlt1

- **Signature**: `UnsubscribeFromCategoryAlt1(string category, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

