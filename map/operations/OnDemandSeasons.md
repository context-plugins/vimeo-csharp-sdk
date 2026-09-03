<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandSeasons — operations

Accessor: `client.OnDemandSeasons` · Source: `Api/OnDemandSeasons.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetVodSeason

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodSeason(double ondemandId, double seasonId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandSeason`
- **Error**: `SdkException<GetVodSeasonError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandSeason` | `Models/OnDemandSeason.cs` |
| `GetVodSeasonError` | `Errors/GetVodSeasonError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodSeasonVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodSeasonVideos(double ondemandId, double seasonId, Filter27? filter, double? page, double? perPage, Sort44? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`filter` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter27` | `Models/Enums/Filter27.cs` |
| `Sort44` | `Models/Enums/Sort44.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetVodSeasons

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodSeasons(double ondemandId, Direction? direction, Filter27? filter, double? page, double? perPage, Sort43? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandSeasonConnection`
- **Error**: `SdkException<GetVodSeasonsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter27` | `Models/Enums/Filter27.cs` |
| `Sort43` | `Models/Enums/Sort43.cs` |
| `OnDemandSeasonConnection` | `Models/OnDemandSeasonConnection.cs` |
| `GetVodSeasonsError` | `Errors/GetVodSeasonsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

