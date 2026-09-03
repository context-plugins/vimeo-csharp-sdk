<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsVideos — operations

Accessor: `client.ChannelsVideos` · Source: `Api/ChannelsVideos.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoToChannel(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToChannelError` | `Errors/AddVideoToChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideosToChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideosToChannel(double channelId, ChannelsVideosRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideosToChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsVideosRequest1` | `Models/ChannelsVideosRequest1.cs` |
| `AddVideosToChannelError` | `Errors/AddVideosToChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoFromChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoFromChannel(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoFromChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoFromChannelError` | `Errors/DeleteVideoFromChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetAvailableVideoChannels

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetAvailableVideoChannels(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `ChannelConnection`
- **Error**: `SdkException<GetAvailableVideoChannelsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelConnection` | `Models/ChannelConnection.cs` |
| `GetAvailableVideoChannelsError` | `Errors/GetAvailableVideoChannelsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannelVideo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelVideo(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<GetChannelVideoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |
| `GetChannelVideoError` | `Errors/GetChannelVideoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannelVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelVideos(double channelId, string? containingUri, Direction? direction, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, string? query, string? sizes, Sort10? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 9 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `direction` ← `direction`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sizes` ← `sizes`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetChannelVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort10` | `Models/Enums/Sort10.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetChannelVideosError` | `Errors/GetChannelVideosError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### RemoveVideosFromChannel

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `RemoveVideosFromChannel(double channelId, ChannelsVideosRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveVideosFromChannelError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsVideosRequest` | `Models/ChannelsVideosRequest.cs` |
| `RemoveVideosFromChannelError` | `Errors/RemoveVideosFromChannelError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

