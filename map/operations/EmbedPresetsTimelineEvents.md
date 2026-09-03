<!-- Generated file — do not edit; regenerated with the SDK. -->

# EmbedPresetsTimelineEvents — operations

Accessor: `client.EmbedPresetsTimelineEvents` · Source: `Api/EmbedPresetsTimelineEvents.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVideoCustomLogo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `CreateVideoCustomLogo(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<CreateVideoCustomLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `CreateVideoCustomLogoError` | `Errors/CreateVideoCustomLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoCustomLogo

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVideoCustomLogo(double thumbnailId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Picture`
- **Error**: `SdkException<GetVideoCustomLogoError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Picture` | `Models/Picture.cs` |
| `GetVideoCustomLogoError` | `Errors/GetVideoCustomLogoError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

