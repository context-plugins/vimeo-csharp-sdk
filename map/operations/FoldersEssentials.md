<!-- Generated file — do not edit; regenerated with the SDK. -->

# FoldersEssentials — operations

Accessor: `client.FoldersEssentials` · Source: `Api/FoldersEssentials.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateProject(double userId, UsersProjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<CreateProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersProjectsRequest` | `Models/UsersProjectsRequest.cs` |
| `Project` | `Models/Project.cs` |
| `CreateProjectError` | `Errors/CreateProjectError.cs` |
| `Error` | `Models/Error.cs` |

### CreateProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateProjectAlt1(MeProjectsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<CreateProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeProjectsRequest` | `Models/MeProjectsRequest.cs` |
| `Project` | `Models/Project.cs` |
| `CreateProjectAlt1Error` | `Errors/CreateProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### DeleteProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteProject(double projectId, double userId, UsersProjectsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersProjectsRequest1` | `Models/UsersProjectsRequest1.cs` |
| `DeleteProjectError` | `Errors/DeleteProjectError.cs` |
| `Error` | `Models/Error.cs` |

### DeleteProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteProjectAlt1(double projectId, MeProjectsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeProjectsRequest1` | `Models/MeProjectsRequest1.cs` |
| `DeleteProjectAlt1Error` | `Errors/DeleteProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### EditProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditProject(double projectId, double userId, UsersProjectsRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<EditProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersProjectsRequest2` | `Models/UsersProjectsRequest2.cs` |
| `Project` | `Models/Project.cs` |
| `EditProjectError` | `Errors/EditProjectError.cs` |
| `Error` | `Models/Error.cs` |

### EditProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditProjectAlt1(double projectId, MeProjectsRequest2 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<EditProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MeProjectsRequest2` | `Models/MeProjectsRequest2.cs` |
| `Project` | `Models/Project.cs` |
| `EditProjectAlt1Error` | `Errors/EditProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetPrivateToMeFolder

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetPrivateToMeFolder(double ownerId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<GetPrivateToMeFolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Project` | `Models/Project.cs` |
| `GetPrivateToMeFolderError` | `Errors/GetPrivateToMeFolderError.cs` |
| `Error` | `Models/Error.cs` |

### GetProject

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProject(double projectId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<GetProjectError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Project` | `Models/Project.cs` |
| `GetProjectError` | `Errors/GetProjectError.cs` |
| `Error` | `Models/Error.cs` |

### GetProjectAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProjectAlt1(double projectId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Project`
- **Error**: `SdkException<GetProjectAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Project` | `Models/Project.cs` |
| `GetProjectAlt1Error` | `Errors/GetProjectAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

### GetProjects

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProjects(double userId, Direction? direction, double? page, double? perPage, string? query, Sort36? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ProjectConnection`
- **Error**: `SdkException<GetProjectsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort36` | `Models/Enums/Sort36.cs` |
| `ProjectConnection` | `Models/ProjectConnection.cs` |
| `GetProjectsError` | `Errors/GetProjectsError.cs` |
| `Error` | `Models/Error.cs` |

### GetProjectsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetProjectsAlt1(Direction? direction, double? page, double? perPage, string? query, Sort36? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `query` ← `query`, `sort` ← `sort`
- **Returns**: `ProjectConnection`
- **Error**: `SdkException<GetProjectsAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort36` | `Models/Enums/Sort36.cs` |
| `ProjectConnection` | `Models/ProjectConnection.cs` |
| `GetProjectsAlt1Error` | `Errors/GetProjectsAlt1Error.cs` |
| `Error` | `Models/Error.cs` |

