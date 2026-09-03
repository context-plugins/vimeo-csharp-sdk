<!-- Generated file — do not edit; regenerated with the SDK. -->

# ChannelsPrivateChannelMembers — operations

Accessor: `client.ChannelsPrivateChannelMembers` · Source: `Api/ChannelsPrivateChannelMembers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteChannelPrivacyUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteChannelPrivacyUser(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteChannelPrivacyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteChannelPrivacyUserError` | `Errors/DeleteChannelPrivacyUserError.cs` |
| `Error` | `Models/Error.cs` |

### GetChannelPrivacyUsers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetChannelPrivacyUsers(double channelId, Direction? direction, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `direction` — nullable, no default → **must pass explicitly**
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetChannelPrivacyUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetChannelPrivacyUsersError` | `Errors/GetChannelPrivacyUsersError.cs` |
| `Error` | `Models/Error.cs` |

### SetChannelPrivacyUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetChannelPrivacyUser(double channelId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<SetChannelPrivacyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SetChannelPrivacyUserError` | `Errors/SetChannelPrivacyUserError.cs` |
| `Error` | `Models/Error.cs` |

### SetChannelPrivacyUsers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetChannelPrivacyUsers(double channelId, ChannelsPrivacyUsersRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<User>`
- **Error**: `SdkException<SetChannelPrivacyUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ChannelsPrivacyUsersRequest` | `Models/ChannelsPrivacyUsersRequest.cs` |
| `User` | `Models/User.cs` |
| `SetChannelPrivacyUsersError` | `Errors/SetChannelPrivacyUsersError.cs` |
| `Error` | `Models/Error.cs` |

