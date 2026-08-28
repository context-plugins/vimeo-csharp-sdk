<!-- Generated file — do not edit; regenerated with the SDK. -->

# VideosEmbedPrivacy — operations

Accessor: `client.VideosEmbedPrivacy` · Source: `Api/VideosEmbedPrivacy.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddVideoPrivacyDomain

- **Signature**: `AddVideoPrivacyDomain(string domain, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<AddVideoPrivacyDomainError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AddVideoPrivacyDomainError` | `Errors/AddVideoPrivacyDomainError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### DeleteVideoPrivacyDomain

- **Signature**: `DeleteVideoPrivacyDomain(string domain, double videoId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteVideoPrivacyDomainError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteVideoPrivacyDomainError` | `Errors/DeleteVideoPrivacyDomainError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

### GetVideoPrivacyDomains

- **Signature**: `GetVideoPrivacyDomains(double videoId, Direction? direction, double? page, double? perPage, Sort78? sort, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`direction` … `sort`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `direction` ← `direction`, `page` ← `page`, `per_page` ← `perPage`, `sort` ← `sort`
- **Returns**: `DomainConnection`
- **Error**: `SdkException<GetVideoPrivacyDomainsError>` — **Case A (typed)**
- **Error accessors**: `TryGetLegacyError(out LegacyError)` [403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `Sort78` | `Models/Enums/Sort78.cs` |
| `DomainConnection` | `Models/DomainConnection.cs` |
| `GetVideoPrivacyDomainsError` | `Errors/GetVideoPrivacyDomainsError.cs` |
| `LegacyError` | `Models/LegacyError.cs` |

