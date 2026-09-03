<!-- Generated file — do not edit; regenerated with the SDK. -->

# SearchFederated — operations

Accessor: `client.SearchFederated` · Source: `Api/SearchFederated.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### FederatedSearchUserItems

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `FederatedSearchUserItems(double userId, Direction? direction, Filter30? filter, string? filterPrivacy, string? modifiedEndDate, string? modifiedStartDate, double? page, double? perPage, string? query, string? queryFields, Sort46? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_privacy` ← `filterPrivacy`, `modified_end_date` ← `modifiedEndDate`, `modified_start_date` ← `modifiedStartDate`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `FederatedSearchItemsConnection`
- **Error**: `SdkException<FederatedSearchUserItemsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter30` | `Models/Enums/Filter30.cs` |
| `Sort46` | `Models/Enums/Sort46.cs` |
| `FederatedSearchItemsConnection` | `Models/FederatedSearchItemsConnection.cs` |
| `FederatedSearchUserItemsError` | `Errors/FederatedSearchUserItemsError.cs` |
| `Error` | `Models/Error.cs` |

### FederatedSearchUserItemsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `FederatedSearchUserItemsAlt1(string workspaceUuid, Direction? direction, Filter30? filter, string? filterPrivacy, string? modifiedEndDate, string? modifiedStartDate, double? page, double? perPage, string? query, string? queryFields, Sort46? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 10 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `filter_privacy` ← `filterPrivacy`, `modified_end_date` ← `modifiedEndDate`, `modified_start_date` ← `modifiedStartDate`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `query_fields` ← `queryFields`, `sort` ← `sort`
- **Returns**: `FederatedSearchItemsConnection`
- **Error**: `SdkException<FederatedSearchUserItemsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter30` | `Models/Enums/Filter30.cs` |
| `Sort46` | `Models/Enums/Sort46.cs` |
| `FederatedSearchItemsConnection` | `Models/FederatedSearchItemsConnection.cs` |
| `FederatedSearchUserItemsAlt1Error` | `Errors/FederatedSearchUserItemsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

