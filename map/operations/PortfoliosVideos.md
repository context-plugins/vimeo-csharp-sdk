<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfoliosVideos — operations

Accessor: `client.PortfoliosVideos` · Source: `Api/PortfoliosVideos.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoToPortfolio

- **Signature**: `AddVideoToPortfolio(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToPortfolioError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToPortfolioError` | `Errors/AddVideoToPortfolioError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### AddVideoToPortfolioAlt1

- **Signature**: `AddVideoToPortfolioAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoToPortfolioAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoToPortfolioAlt1Error` | `Errors/AddVideoToPortfolioAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoFromPortfolio

- **Signature**: `DeleteVideoFromPortfolio(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoFromPortfolioError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoFromPortfolioError` | `Errors/DeleteVideoFromPortfolioError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoFromPortfolioAlt1

- **Signature**: `DeleteVideoFromPortfolioAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoFromPortfolioAlt1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoFromPortfolioAlt1Error` | `Errors/DeleteVideoFromPortfolioAlt1Error.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetPortfolioVideo

- **Signature**: `GetPortfolioVideo(double portfolioId, double userId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |

### GetPortfolioVideoAlt1

- **Signature**: `GetPortfolioVideoAlt1(double portfolioId, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Video`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Video` | `Models/Video.cs` |

### GetPortfolioVideos

- **Signature**: `GetPortfolioVideos(double portfolioId, double userId, string? containingUri, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, Sort35? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort35` | `Models/Enums/Sort35.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

### GetPortfolioVideosAlt1

- **Signature**: `GetPortfolioVideosAlt1(double portfolioId, string? containingUri, Filter3? filter, bool? filterEmbeddable, double? page, double? perPage, Sort35? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`containingUri` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `containing_uri` ← `containingUri`, `filter` ← `filter`, `filter_embeddable` ← `filterEmbeddable`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `VideoConnection`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Filter3` | `Models/Enums/Filter3.cs` |
| `Sort35` | `Models/Enums/Sort35.cs` |
| `VideoConnection` | `Models/VideoConnection.cs` |

