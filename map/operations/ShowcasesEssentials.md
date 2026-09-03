<!-- Generated file — do not edit; regenerated with the SDK. -->

# ShowcasesEssentials — operations

Accessor: `client.ShowcasesEssentials` · Source: `Api/ShowcasesEssentials.cs` · 14 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddFolderToShowcases

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddFolderToShowcases(double userId, string albumUris, double folderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `album_uris` ← `albumUris`, `folder_id` ← `folderId`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddFolderToShowcasesError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddFolderToShowcasesError` | `Errors/AddFolderToShowcasesError.cs` |
| `Error` | `Models/Error.cs` |

### CopyShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CopyShowcase(double albumId, double userId, UsersAlbumsCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<CopyShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsCopyRequest` | `Models/UsersAlbumsCopyRequest.cs` |
| `Album` | `Models/Album.cs` |
| `CopyShowcaseError` | `Errors/CopyShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CopyShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CopyShowcaseAlt2(double albumId, MeAlbumsCopyRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<CopyShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeAlbumsCopyRequest` | `Models/MeAlbumsCopyRequest.cs` |
| `Album` | `Models/Album.cs` |
| `CopyShowcaseAlt2Error` | `Errors/CopyShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateShowcase(double userId, UsersAlbumsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<CreateShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsRequest` | `Models/UsersAlbumsRequest.cs` |
| `Album` | `Models/Album.cs` |
| `CreateShowcaseError` | `Errors/CreateShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### CreateShowcaseAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateShowcaseAlt1(MeAlbumsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<CreateShowcaseAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeAlbumsRequest` | `Models/MeAlbumsRequest.cs` |
| `Album` | `Models/Album.cs` |
| `CreateShowcaseAlt1Error` | `Errors/CreateShowcaseAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteShowcase(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteShowcaseError` | `Errors/DeleteShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteShowcaseAlt2(double albumId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteShowcaseAlt2Error` | `Errors/DeleteShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditShowcase(double albumId, double userId, UsersAlbumsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<EditShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersAlbumsRequest1` | `Models/UsersAlbumsRequest1.cs` |
| `Album` | `Models/Album.cs` |
| `EditShowcaseError` | `Errors/EditShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditShowcaseAlt2(double albumId, MeAlbumsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Album`
- **Error**: `SdkException<EditShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeAlbumsRequest1` | `Models/MeAlbumsRequest1.cs` |
| `Album` | `Models/Album.cs` |
| `EditShowcaseAlt2Error` | `Errors/EditShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcase

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcase(double albumId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<GetShowcaseError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Album` | `Models/Album.cs` |
| `GetShowcaseError` | `Errors/GetShowcaseError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcaseAlt2

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcaseAlt2(double albumId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Album`
- **Error**: `SdkException<GetShowcaseAlt2Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Album` | `Models/Album.cs` |
| `GetShowcaseAlt2Error` | `Errors/GetShowcaseAlt2Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcases

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcases(double userId, Direction? direction, string? filterPrivacy, double? page, double? perPage, string? query, Sort18? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter_privacy` ← `filterPrivacy`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `AlbumConnection`
- **Error**: `SdkException<GetShowcasesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort18` | `Models/Enums/Sort18.cs` |
| `AlbumConnection` | `Models/AlbumConnection.cs` |
| `GetShowcasesError` | `Errors/GetShowcasesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetShowcasesAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetShowcasesAlt1(Direction? direction, string? filterPrivacy, double? page, double? perPage, string? query, Sort18? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter_privacy` ← `filterPrivacy`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `AlbumConnection`
- **Error**: `SdkException<GetShowcasesAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort18` | `Models/Enums/Sort18.cs` |
| `AlbumConnection` | `Models/AlbumConnection.cs` |
| `GetShowcasesAlt1Error` | `Errors/GetShowcasesAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UpdateShowcases

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateShowcases(double userId, string albumItemUris, string albumUris, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `album_item_uris` ← `albumItemUris`, `album_uris` ← `albumUris`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

