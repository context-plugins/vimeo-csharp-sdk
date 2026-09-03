<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsSubscriptionsAndSubscribers — operations

Accessor: `client.ChannelsSubscriptionsAndSubscribers` · Source: `Api/ChannelsSubscriptionsAndSubscribers.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfUserSubscribedToChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckIfUserSubscribedToChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserSubscribedToChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserSubscribedToChannelError` | `Errors/CheckIfUserSubscribedToChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CheckIfUserSubscribedToChannelAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CheckIfUserSubscribedToChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<CheckIfUserSubscribedToChannelAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CheckIfUserSubscribedToChannelAlt1Error` | `Errors/CheckIfUserSubscribedToChannelAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannelSubscribers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelSubscribers(double channelId, Filter2 filter, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `filter` ← `filter`, `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetChannelSubscribersError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Filter2` | `Models/Enums/Filter2.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetChannelSubscribersError` | `Errors/GetChannelSubscribersError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SubscribeToChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SubscribeToChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SubscribeToChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeToChannelError` | `Errors/SubscribeToChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SubscribeToChannelAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SubscribeToChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SubscribeToChannelAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SubscribeToChannelAlt1Error` | `Errors/SubscribeToChannelAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UnsubscribeFromChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UnsubscribeFromChannel(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UnsubscribeFromChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnsubscribeFromChannelError` | `Errors/UnsubscribeFromChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UnsubscribeFromChannelAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UnsubscribeFromChannelAlt1(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<UnsubscribeFromChannelAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UnsubscribeFromChannelAlt1Error` | `Errors/UnsubscribeFromChannelAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

