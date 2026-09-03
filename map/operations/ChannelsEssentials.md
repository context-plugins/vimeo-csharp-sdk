<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsEssentials — operations

Accessor: `client.ChannelsEssentials` · Source: `Api/ChannelsEssentials.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateChannel(ChannelsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Channel`
- **Error**: `SdkException<CreateChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsRequest` | `Models/ChannelsRequest.cs` |
| `Channel` | `Models/Channel.cs` |
| `CreateChannelError` | `Errors/CreateChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteChannel(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChannelError` | `Errors/DeleteChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditChannel(double channelId, ChannelsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Channel`
- **Error**: `SdkException<EditChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsRequest1` | `Models/ChannelsRequest1.cs` |
| `Channel` | `Models/Channel.cs` |
| `EditChannelError` | `Errors/EditChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannel(double channelId, string? sizes, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `sizes` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `sizes` ← `sizes`
- **Returns**: `Channel`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Channel` | `Models/Channel.cs` |

### GetChannelSubscriptions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelSubscriptions(double userId, Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ChannelConnection`
- **Error**: `SdkException<GetChannelSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter12` | `Models/Enums/Filter12.cs` |
| `Sort4` | `Models/Enums/Sort4.cs` |
| `ChannelConnection` | `Models/ChannelConnection.cs` |
| `GetChannelSubscriptionsError` | `Errors/GetChannelSubscriptionsError.cs` |
| `Error` | `Models/Error.cs` |

### GetChannelSubscriptionsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelSubscriptionsAlt1(Direction? direction, Filter12? filter, double? page, double? perPage, string? query, Sort4? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ChannelConnection`
- **Error**: `SdkException<GetChannelSubscriptionsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter12` | `Models/Enums/Filter12.cs` |
| `Sort4` | `Models/Enums/Sort4.cs` |
| `ChannelConnection` | `Models/ChannelConnection.cs` |
| `GetChannelSubscriptionsAlt1Error` | `Errors/GetChannelSubscriptionsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetChannels

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannels(Direction? direction, Filter1? filter, double? page, double? perPage, string? query, Sort7? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ChannelConnection`
- **Error**: `SdkException<GetChannelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter1` | `Models/Enums/Filter1.cs` |
| `Sort7` | `Models/Enums/Sort7.cs` |
| `ChannelConnection` | `Models/ChannelConnection.cs` |
| `GetChannelsError` | `Errors/GetChannelsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

