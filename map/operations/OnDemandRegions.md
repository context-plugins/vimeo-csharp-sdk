<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandRegions — operations

Accessor: `client.OnDemandRegions` · Source: `Api/OnDemandRegions.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVodRegion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `AddVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegion`
- **Error**: `SdkException<AddVodRegionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandRegion` | `Models/OnDemandRegion.cs` |
| `AddVodRegionError` | `Errors/AddVodRegionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVodRegion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVodRegionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVodRegionError` | `Errors/DeleteVodRegionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVodRegions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `DeleteVodRegions(double ondemandId, OndemandPagesRegionsRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `IReadOnlyList<OnDemandRegion>`
- **Error**: `SdkException<DeleteVodRegionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesRegionsRequest` | `Models/OndemandPagesRegionsRequest.cs` |
| `OnDemandRegion` | `Models/OnDemandRegion.cs` |
| `DeleteVodRegionsError` | `Errors/DeleteVodRegionsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetRegion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetRegion(string country, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegion`
- **Error**: `SdkException<GetRegionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandRegion` | `Models/OnDemandRegion.cs` |
| `GetRegionError` | `Errors/GetRegionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetRegions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetRegions(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegionConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `OnDemandRegionConnection` | `Models/OnDemandRegionConnection.cs` |

### GetVodRegion

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodRegion(string country, double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegion`
- **Error**: `SdkException<GetVodRegionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandRegion` | `Models/OnDemandRegion.cs` |
| `GetVodRegionError` | `Errors/GetVodRegionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodRegions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `GetVodRegions(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegionConnection`
- **Error**: `SdkException<GetVodRegionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandRegionConnection` | `Models/OnDemandRegionConnection.cs` |
| `GetVodRegionsError` | `Errors/GetVodRegionsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### SetVodRegions

- **Auth**: `options.Oauth2AuthorizationCode` OR `options.Oauth2ClientCredentials` OR `options.Bearer`
- **Signature**: `SetVodRegions(double ondemandId, OndemandPagesRegionsRequest1 body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandRegion`
- **Error**: `SdkException<SetVodRegionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesRegionsRequest1` | `Models/OndemandPagesRegionsRequest1.cs` |
| `OnDemandRegion` | `Models/OnDemandRegion.cs` |
| `SetVodRegionsError` | `Errors/SetVodRegionsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

