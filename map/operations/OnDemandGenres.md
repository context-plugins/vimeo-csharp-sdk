<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandGenres — operations

Accessor: `client.OnDemandGenres` · Source: `Api/OnDemandGenres.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVodGenre

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVodGenre(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandGenre`
- **Error**: `SdkException<AddVodGenreError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandGenre` | `Models/OnDemandGenre.cs` |
| `AddVodGenreError` | `Errors/AddVodGenreError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVodGenre

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVodGenre(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVodGenreError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVodGenreError` | `Errors/DeleteVodGenreError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetGenreVod

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGenreVod(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<GetGenreVodError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandPage` | `Models/OnDemandPage.cs` |
| `GetGenreVodError` | `Errors/GetGenreVodError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetGenreVods

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetGenreVods(string genreId, Direction? direction, Filter24? filter, double? page, double? perPage, string? query, Sort41? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `OnDemandPageConnection`
- **Error**: `SdkException<GetGenreVodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter24` | `Models/Enums/Filter24.cs` |
| `Sort41` | `Models/Enums/Sort41.cs` |
| `OnDemandPageConnection` | `Models/OnDemandPageConnection.cs` |
| `GetGenreVodsError` | `Errors/GetGenreVodsError.cs` |
| `Error` | `Models/Error.cs` |

### GetVodGenre

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodGenre(string genreId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandGenre`
- **Error**: `SdkException<GetVodGenreError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandGenre` | `Models/OnDemandGenre.cs` |
| `GetVodGenreError` | `Errors/GetVodGenreError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodGenreByOndemandId

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodGenreByOndemandId(string genreId, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandGenre`
- **Error**: `SdkException<GetVodGenreByOndemandIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandGenre` | `Models/OnDemandGenre.cs` |
| `GetVodGenreByOndemandIdError` | `Errors/GetVodGenreByOndemandIdError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodGenres

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodGenres(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandGenreConnection`
- **Error**: `SdkException<GetVodGenresError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandGenreConnection` | `Models/OnDemandGenreConnection.cs` |
| `GetVodGenresError` | `Errors/GetVodGenresError.cs` |
| `Error` | `Models/Error.cs` |

### GetVodGenresByOndemandId

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodGenresByOndemandId(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandGenreConnection`
- **Error**: `SdkException<GetVodGenresByOndemandIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandGenreConnection` | `Models/OnDemandGenreConnection.cs` |
| `GetVodGenresByOndemandIdError` | `Errors/GetVodGenresByOndemandIdError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

