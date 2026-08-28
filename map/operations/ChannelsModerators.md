<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsModerators — operations

Accessor: `client.ChannelsModerators` · Source: `Api/ChannelsModerators.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddChannelModerator

- **Signature**: `AddChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddChannelModeratorError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddChannelModeratorError` | `Errors/AddChannelModeratorError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddChannelModerators

- **Signature**: `AddChannelModerators(double channelId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddChannelModeratorsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddChannelModeratorsError` | `Errors/AddChannelModeratorsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetChannelModerator

- **Signature**: `GetChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `User`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### GetChannelModerators

- **Signature**: `GetChannelModerators(double channelId, Direction? direction, double? page, double? perPage, string? query, Sort8? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `UserConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort8` | `Models/Enums/Sort8.cs` |
| `UserConnection` | `Models/UserConnection.cs` |

### RemoveChannelModerator

- **Signature**: `RemoveChannelModerator(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveChannelModeratorError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RemoveChannelModeratorError` | `Errors/RemoveChannelModeratorError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### RemoveChannelModerators

- **Signature**: `RemoveChannelModerators(double channelId, ChannelsModeratorsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RemoveChannelModeratorsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsModeratorsRequest` | `Models/ChannelsModeratorsRequest.cs` |
| `RemoveChannelModeratorsError` | `Errors/RemoveChannelModeratorsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### ReplaceChannelModerators

- **Signature**: `ReplaceChannelModerators(double channelId, ChannelsModeratorsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<User>`
- **Error**: `SdkException<ReplaceChannelModeratorsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsModeratorsRequest1` | `Models/ChannelsModeratorsRequest1.cs` |
| `User` | `Models/User.cs` |
| `ReplaceChannelModeratorsError` | `Errors/ReplaceChannelModeratorsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

