<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosUnlistedVideos — operations

Accessor: `client.VideosUnlistedVideos` · Source: `Api/VideosUnlistedVideos.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoPrivacyUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoPrivacyUser(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `User`
- **Error**: `SdkException<AddVideoPrivacyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |
| `AddVideoPrivacyUserError` | `Errors/AddVideoPrivacyUserError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideoPrivacyUsers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoPrivacyUsers(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<User>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### AddVideoPrivacyUsersAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVideoPrivacyUsersAlt1(double channelId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<User>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### DeleteVideoPrivacyUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVideoPrivacyUser(double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoPrivacyUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoPrivacyUserError` | `Errors/DeleteVideoPrivacyUserError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoPrivacyUsers

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoPrivacyUsers(double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetVideoPrivacyUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetVideoPrivacyUsersError` | `Errors/GetVideoPrivacyUsersError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoPrivacyUsersAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoPrivacyUsersAlt1(double channelId, double videoId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `UserConnection`
- **Error**: `SdkException<GetVideoPrivacyUsersAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UserConnection` | `Models/UserConnection.cs` |
| `GetVideoPrivacyUsersAlt1Error` | `Errors/GetVideoPrivacyUsersAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

