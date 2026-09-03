<!-- Generated file — do not edit; regenerated with the SDK. -->

# FoldersItems — operations

Accessor: `client.FoldersItems` · Source: `Api/FoldersItems.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteFolderItemsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteFolderItemsAlt1(double projectId, string uris, bool? sendToRecentlyDeleted, bool? shouldDeleteItems, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `sendToRecentlyDeleted` — nullable, no default → **must pass explicitly**
  - `shouldDeleteItems` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `uris` ← `uris`, `send_to_recently_deleted` ← `sendToRecentlyDeleted`, `should_delete_items` ← `shouldDeleteItems`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteFolderItemsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteFolderItemsAlt1Error` | `Errors/DeleteFolderItemsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetFolderItems

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetFolderItems(double projectId, string? clipPrivacyFilters, Direction? direction, Filter21? filter, double? page, double? perPage, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`clipPrivacyFilters` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `clip_privacy_filters` ← `clipPrivacyFilters`, `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter21` | `Models/Enums/Filter21.cs` |
| `Sort37` | `Models/Enums/Sort37.cs` |

### GetFolderItems2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetFolderItems2(double projectId, double userId, string? clipPrivacyFilters, Direction? direction, Filter21? filter, double? page, double? perPage, Sort37? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`clipPrivacyFilters` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `clip_privacy_filters` ← `clipPrivacyFilters`, `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter21` | `Models/Enums/Filter21.cs` |
| `Sort37` | `Models/Enums/Sort37.cs` |

