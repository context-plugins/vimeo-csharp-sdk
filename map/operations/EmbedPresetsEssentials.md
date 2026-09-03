<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbedPresetsEssentials — operations

Accessor: `client.EmbedPresetsEssentials` · Source: `Api/EmbedPresetsEssentials.cs` · 10 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateEmbedPresets

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateEmbedPresets(double userId, UsersPresetsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Preset`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UsersPresetsRequest` | `Models/UsersPresetsRequest.cs` |
| `Preset` | `Models/Preset.cs` |

### CreateEmbedPresetsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateEmbedPresetsAlt1(MePresetsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Preset`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `MePresetsRequest` | `Models/MePresetsRequest.cs` |
| `Preset` | `Models/Preset.cs` |

### DeleteEmbedPreset

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteEmbedPreset(double presetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteEmbedPresetError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteEmbedPresetError` | `Errors/DeleteEmbedPresetError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteEmbedPresetAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteEmbedPresetAlt1(double presetId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteEmbedPresetAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteEmbedPresetAlt1Error` | `Errors/DeleteEmbedPresetAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditEmbedPreset

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditEmbedPreset(double presetId, double userId, UsersPresetsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Preset`
- **Error**: `SdkException<EditEmbedPresetError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UsersPresetsRequest1` | `Models/UsersPresetsRequest1.cs` |
| `Preset` | `Models/Preset.cs` |
| `EditEmbedPresetError` | `Errors/EditEmbedPresetError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### EditEmbedPresetAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `EditEmbedPresetAlt1(double presetId, MePresetsRequest1? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Preset`
- **Error**: `SdkException<EditEmbedPresetAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `MePresetsRequest1` | `Models/MePresetsRequest1.cs` |
| `Preset` | `Models/Preset.cs` |
| `EditEmbedPresetAlt1Error` | `Errors/EditEmbedPresetAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetEmbedPreset

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetEmbedPreset(double presetId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Preset`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Preset` | `Models/Preset.cs` |

### GetEmbedPresetAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetEmbedPresetAlt1(double presetId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Preset`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Preset` | `Models/Preset.cs` |

### GetEmbedPresets

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetEmbedPresets(double userId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PresetConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PresetConnection` | `Models/PresetConnection.cs` |

### GetEmbedPresetsAlt1

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetEmbedPresetsAlt1(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `PresetConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PresetConnection` | `Models/PresetConnection.cs` |

