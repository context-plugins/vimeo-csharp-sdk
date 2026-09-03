<!-- Generated file — do not edit; regenerated with the SDK. -->

# TeamsEssentials — operations

Accessor: `client.TeamsEssentials` · Source: `Api/TeamsEssentials.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### BackfillTeamCustomMetadata

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `BackfillTeamCustomMetadata(double userId, TeamsCustomMetadataBackfillRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<BackfillTeamCustomMetadataError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamsCustomMetadataBackfillRequest` | `Models/TeamsCustomMetadataBackfillRequest.cs` |
| `BackfillTeamCustomMetadataError` | `Errors/BackfillTeamCustomMetadataError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTeamCustomMetadataIncompleteVideos

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetTeamCustomMetadataIncompleteVideos(double userId, double? page, double? perPage, Sort48? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
  - `sort` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `void` (Task)
- **Error**: `SdkException<GetTeamCustomMetadataIncompleteVideosError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Sort48` | `Models/Enums/Sort48.cs` |
| `GetTeamCustomMetadataIncompleteVideosError` | `Errors/GetTeamCustomMetadataIncompleteVideosError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetTeamCustomMetadataSettings

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetTeamCustomMetadataSettings(double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CustomMetadataSettingsConnection`
- **Error**: `SdkException<GetTeamCustomMetadataSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [401, 403] · `TryGetError(out Error)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CustomMetadataSettingsConnection` | `Models/CustomMetadataSettingsConnection.cs` |
| `GetTeamCustomMetadataSettingsError` | `Errors/GetTeamCustomMetadataSettingsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateCustomMetadataFieldOptions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpdateCustomMetadataFieldOptions(double userId, TeamsCustomMetadataOptionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `CustomMetadataSettings`
- **Error**: `SdkException<UpdateCustomMetadataFieldOptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamsCustomMetadataOptionsRequest` | `Models/TeamsCustomMetadataOptionsRequest.cs` |
| `CustomMetadataSettings` | `Models/CustomMetadataSettings.cs` |
| `UpdateCustomMetadataFieldOptionsError` | `Errors/UpdateCustomMetadataFieldOptionsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### UpsertCustomMetadataSettings

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `UpsertCustomMetadataSettings(double userId, TeamsCustomMetadataRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<CustomMetadataSettings>`
- **Error**: `SdkException<UpsertCustomMetadataSettingsError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400] · `TryGetLegacyError(out LegacyError)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `TeamsCustomMetadataRequest` | `Models/TeamsCustomMetadataRequest.cs` |
| `CustomMetadataSettings` | `Models/CustomMetadataSettings.cs` |
| `UpsertCustomMetadataSettingsError` | `Errors/UpsertCustomMetadataSettingsError.cs` |
| `Error` | `Models/Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

