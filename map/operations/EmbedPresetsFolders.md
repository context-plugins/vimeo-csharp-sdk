<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbedPresetsFolders — operations

Accessor: `client.EmbedPresetsFolders` · Source: `Api/EmbedPresetsFolders.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteFolderEmbedPreset

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteFolderEmbedPreset(double presetId, double projectId, double userId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteFolderEmbedPresetError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteFolderEmbedPresetError` | `Errors/DeleteFolderEmbedPresetError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

