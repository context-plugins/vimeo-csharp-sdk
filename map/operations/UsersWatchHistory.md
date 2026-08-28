<!-- Generated file — do not edit; regenerated with the SDK. -->

# UsersWatchHistory — operations

Accessor: `client.UsersWatchHistory` · Source: `Api/UsersWatchHistory.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteFromWatchHistory

- **Signature**: `DeleteFromWatchHistory(double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteWatchHistory

- **Signature**: `DeleteWatchHistory(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetWatchHistory

- **Signature**: `GetWatchHistory(double? page, double? perPage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `page` — nullable, no default → **must pass explicitly**
  - `perPage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `page` ← `page`, `per_page` ← `perPage`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<GetWatchHistoryError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VideoConnection` | `Models/VideoConnection.cs` |
| `GetWatchHistoryError` | `Errors/GetWatchHistoryError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

