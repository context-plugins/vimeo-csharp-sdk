<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersEssentials — operations

Accessor: `client.UsersEssentials` · Source: `Api/UsersEssentials.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### EditUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditUser(double userId, UsersRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `User`
- **Error**: `SdkException<EditUserError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersRequest` | `Models/UsersRequest.cs` |
| `User` | `Models/User.cs` |
| `EditUserError` | `Errors/EditUserError.cs` |
| `Error` | `Models/Error.cs` |

### EditUserAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditUserAlt1(MeRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `User`
- **Error**: `SdkException<EditUserAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeRequest` | `Models/MeRequest.cs` |
| `User` | `Models/User.cs` |
| `EditUserAlt1Error` | `Errors/EditUserAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetUser

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUser(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `User`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

### GetUserAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetUserAlt1(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `User`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `User` | `Models/User.cs` |

