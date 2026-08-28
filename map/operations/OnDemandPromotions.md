<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandPromotions — operations

Accessor: `client.OnDemandPromotions` · Source: `Api/OnDemandPromotions.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreateVodPromotion

- **Signature**: `CreateVodPromotion(double ondemandId, OndemandPagesPromotionsRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPromotion`
- **Error**: `SdkException<CreateVodPromotionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OndemandPagesPromotionsRequest` | `Models/OndemandPagesPromotionsRequest.cs` |
| `OnDemandPromotion` | `Models/OnDemandPromotion.cs` |
| `CreateVodPromotionError` | `Errors/CreateVodPromotionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVodPromotion

- **Signature**: `DeleteVodPromotion(double ondemandId, double promotionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVodPromotionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVodPromotionError` | `Errors/DeleteVodPromotionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodPromotion

- **Signature**: `GetVodPromotion(double ondemandId, double promotionId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPromotion`
- **Error**: `SdkException<GetVodPromotionError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandPromotion` | `Models/OnDemandPromotion.cs` |
| `GetVodPromotionError` | `Errors/GetVodPromotionError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodPromotionCodes

- **Signature**: `GetVodPromotionCodes(double ondemandId, double promotionId, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `OnDemandPromotionCode`
- **Error**: `SdkException<GetVodPromotionCodesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandPromotionCode` | `Models/OnDemandPromotionCode.cs` |
| `GetVodPromotionCodesError` | `Errors/GetVodPromotionCodesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodPromotions

- **Signature**: `GetVodPromotions(double ondemandId, Filter26 filter, double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `OnDemandPromotion`
- **Error**: `SdkException<GetVodPromotionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [400, 403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Filter26` | `Models/Enums/Filter26.cs` |
| `OnDemandPromotion` | `Models/OnDemandPromotion.cs` |
| `GetVodPromotionsError` | `Errors/GetVodPromotionsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

