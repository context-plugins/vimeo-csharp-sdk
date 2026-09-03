<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandEssentials — operations

Accessor: `client.OnDemandEssentials` · Source: `Api/OnDemandEssentials.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVod

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateVod(double userId, UsersOndemandPagesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersOndemandPagesRequest` | `Models/UsersOndemandPagesRequest.cs` |
| `OnDemandPage` | `Models/OnDemandPage.cs` |

### CreateVodAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateVodAlt1(MeOndemandPagesRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MeOndemandPagesRequest` | `Models/MeOndemandPagesRequest.cs` |
| `OnDemandPage` | `Models/OnDemandPage.cs` |

### DeleteVodDraft

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVodDraft(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVodDraftError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVodDraftError` | `Errors/DeleteVodDraftError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditVod

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditVod(double ondemandId, OndemandPagesRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<EditVodError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesRequest` | `Models/OndemandPagesRequest.cs` |
| `OnDemandPage` | `Models/OnDemandPage.cs` |
| `EditVodError` | `Errors/EditVodError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetUserVods

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUserVods(double userId, Direction? direction, Filter18? filter, double? page, double? perPage, Sort32? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandPageConnection`
- **Error**: `SdkException<GetUserVodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter18` | `Models/Enums/Filter18.cs` |
| `Sort32` | `Models/Enums/Sort32.cs` |
| `OnDemandPageConnection` | `Models/OnDemandPageConnection.cs` |
| `GetUserVodsError` | `Errors/GetUserVodsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetUserVodsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUserVodsAlt1(Direction? direction, Filter18? filter, double? page, double? perPage, Sort32? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandPageConnection`
- **Error**: `SdkException<GetUserVodsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter18` | `Models/Enums/Filter18.cs` |
| `Sort32` | `Models/Enums/Sort32.cs` |
| `OnDemandPageConnection` | `Models/OnDemandPageConnection.cs` |
| `GetUserVodsAlt1Error` | `Errors/GetUserVodsAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVod

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVod(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<GetVodError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandPage` | `Models/OnDemandPage.cs` |
| `GetVodError` | `Errors/GetVodError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

