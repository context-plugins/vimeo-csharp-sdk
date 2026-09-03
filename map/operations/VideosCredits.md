<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosCredits — operations

Accessor: `client.VideosCredits` · Source: `Api/VideosCredits.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoCredit

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoCredit(double videoId, VideosCreditsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Credit`
- **Error**: `SdkException<AddVideoCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCreditsRequest` | `Models/VideosCreditsRequest.cs` |
| `Credit` | `Models/Credit.cs` |
| `AddVideoCreditError` | `Errors/AddVideoCreditError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideoCreditAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoCreditAlt1(double channelId, double videoId, ChannelsVideosCreditsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Credit`
- **Error**: `SdkException<AddVideoCreditAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsVideosCreditsRequest` | `Models/ChannelsVideosCreditsRequest.cs` |
| `Credit` | `Models/Credit.cs` |
| `AddVideoCreditAlt1Error` | `Errors/AddVideoCreditAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AvailableUsers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AvailableUsers(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |

### DeleteVideoCredit

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoCredit(double creditId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoCreditError` | `Errors/DeleteVideoCreditError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditVideoCredit

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditVideoCredit(double creditId, double videoId, VideosCreditsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Credit`
- **Error**: `SdkException<EditVideoCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideosCreditsRequest1` | `Models/VideosCreditsRequest1.cs` |
| `Credit` | `Models/Credit.cs` |
| `EditVideoCreditError` | `Errors/EditVideoCreditError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoCredit

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoCredit(double creditId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Credit`
- **Error**: `SdkException<GetVideoCreditError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Credit` | `Models/Credit.cs` |
| `GetVideoCreditError` | `Errors/GetVideoCreditError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoCredits

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoCredits(double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `CreditConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `CreditConnection` | `Models/CreditConnection.cs` |

### GetVideoCreditsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoCreditsAlt1(double channelId, double videoId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `CreditConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `CreditConnection` | `Models/CreditConnection.cs` |

