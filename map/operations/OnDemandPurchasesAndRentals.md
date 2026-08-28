<!-- Generated file — do not edit; regenerated with the SDK. -->

# OnDemandPurchasesAndRentals — operations

Accessor: `client.OnDemandPurchasesAndRentals` · Source: `Api/OnDemandPurchasesAndRentals.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CheckIfVodWasPurchasedAlt1

- **Signature**: `CheckIfVodWasPurchasedAlt1(double ondemandId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `OnDemandPage`
- **Error**: `SdkException<CheckIfVodWasPurchasedAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `OnDemandPage` | `Models/OnDemandPage.cs` |
| `CheckIfVodWasPurchasedAlt1Error` | `Errors/CheckIfVodWasPurchasedAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodPurchases

- **Signature**: `GetVodPurchases(double userId, Direction? direction, Filter19? filter, double? page, double? perPage, Sort33? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandPageConnection`
- **Error**: `SdkException<GetVodPurchasesError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter19` | `Models/Enums/Filter19.cs` |
| `Sort33` | `Models/Enums/Sort33.cs` |
| `OnDemandPageConnection` | `Models/OnDemandPageConnection.cs` |
| `GetVodPurchasesError` | `Errors/GetVodPurchasesError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVodPurchasesAlt1

- **Signature**: `GetVodPurchasesAlt1(Direction? direction, Filter19? filter, double? page, double? perPage, Sort33? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 5 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `filter` ← `filter`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `OnDemandPageConnection`
- **Error**: `SdkException<GetVodPurchasesAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Filter19` | `Models/Enums/Filter19.cs` |
| `Sort33` | `Models/Enums/Sort33.cs` |
| `OnDemandPageConnection` | `Models/OnDemandPageConnection.cs` |
| `GetVodPurchasesAlt1Error` | `Errors/GetVodPurchasesAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

