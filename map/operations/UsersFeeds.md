<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersFeeds — operations

Accessor: `client.UsersFeeds` · Source: `Api/UsersFeeds.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetFeed

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetFeed(double userId, string? offset, double? page, double? perPage, Type29? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`offset` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `offset` ← `offset`, `page` ← `page`, `per_page` ← `perPage`, `type` ← `type`
- **Returns**: `Activity31Connection`
- **Error**: `SdkException<GetFeedError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type29` | `Models/Enums/Type29.cs` |
| `Activity31Connection` | `Models/Activity31Connection.cs` |
| `GetFeedError` | `Errors/GetFeedError.cs` |
| `Error` | `Models/Error.cs` |

### GetFeedAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetFeedAlt1(string? offset, double? page, double? perPage, Type29? type, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`offset` … `type`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `offset` ← `offset`, `page` ← `page`, `per_page` ← `perPage`, `type` ← `type`
- **Returns**: `Activity31Connection`
- **Error**: `SdkException<GetFeedAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Type29` | `Models/Enums/Type29.cs` |
| `Activity31Connection` | `Models/Activity31Connection.cs` |
| `GetFeedAlt1Error` | `Errors/GetFeedAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

