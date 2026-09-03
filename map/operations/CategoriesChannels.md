<!-- Generated file — do not edit; regenerated with the SDK. -->

# CategoriesChannels — operations

Accessor: `client.CategoriesChannels` · Source: `Api/CategoriesChannels.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCategoryChannels

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetCategoryChannels(string category, Direction? direction, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ChannelConnection`
- **Error**: `SdkException<GetCategoryChannelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort4` | `Models/Enums/Sort4.cs` |
| `ChannelConnection` | `Models/ChannelConnection.cs` |
| `GetCategoryChannelsError` | `Errors/GetCategoryChannelsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

